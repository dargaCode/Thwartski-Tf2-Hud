using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//TODO work on removing to other classes
using System.IO;
using System.Net;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace Thwartski_Hud_Installer
{
    public partial class Form1 : Form
    {
        //Instantiate classes
        private OptionsTracker optionsTracker;
        private UiTracker uiTracker;
        private Installer installer;
        private Downloader downloader;
        private Browser browser;
        private Uninstaller uninstaller;

        //instances of the hud to compare, install from etc
        private Location assetLocation;
        private Location installLocation;

        //instances of options to update, modify files, etc
        private Option aspectOption;
        private Option scoreboardMinmodeOption;
        private Option scoreboardMaxmodeOption;


        //defining tooltips for the form
        static ToolTip HudInstallerTooltips = new ToolTip(); //TODO where should this go?





        //FORM EVENTS BELOW THIS POINT



        public Form1()
        {
            InitializeComponent();
        }

        //default functionality as form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiate classes so they can control public functions on this form
            this.assetLocation = new Location(this);
            this.installLocation = new Location(this);
            this.uiTracker = new UiTracker(this);

            //option objects
            this.aspectOption = new Option(this, installer, aspectCombobox, aspectPicturebox, aspectLabel, Properties.Settings.Default.settingComboboxAspect);
            this.scoreboardMinmodeOption = new Option(this, installer, scoreboardMinmodeCombobox, scoreboardMinmodePicturebox, scoreboardMinmodeLabel, Properties.Settings.Default.settingComboboxMinmode);
            this.scoreboardMaxmodeOption = new Option(this, installer, scoreboardMaxmodeCombobox, scoreboardMaxmodePicturebox, scoreboardMaxmodeLabel, Properties.Settings.Default.settingComboboxMaxmode);

            //objects which reference other class objects
            this.browser = new Browser(this, installLocation);
            this.downloader = new Downloader(this, assetLocation, installLocation); 
            this.installer = new Installer(this, assetLocation, installLocation);
            this.optionsTracker = new OptionsTracker(this, assetLocation, installLocation, aspectOption, scoreboardMinmodeOption, scoreboardMaxmodeOption);

            //basic objects which only reference the form so far
            this.uninstaller = new Uninstaller(this);




            //TODO make these actually dynamic
            assetLocation.VersionHud = new Version("2.0.4");
            installLocation.VersionHud = new Version("2.0.4");



            //generate tooltips for the form
            updateTooltips();


            //Generate tooltips, populate strings, comboboxes, and assets.
            optionsTracker.Setup();


            //Fill the browser with a best guess default string or a saved string, if one exists
            browser.populateDefaultPath();



            //optionsTracker.Update(); //TODO is this necesary?

        }

        //browse for valid install locations
        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            browser.BrowseForInstallFolder();

        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void aspectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            optionsTracker.updateAspect();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardMaxmodeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            optionsTracker.updateScoreboard();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardMinmodeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            optionsTracker.updateScoreboard();
        }

        //actually install the hud or update the installation with new custom files
        private void installButton_InstallClick(object sender, EventArgs e)
        {
            //disable form contents
            form1LayoutPanel.Enabled = false;

            //attempt to install the hud
            if (installer.performInstallation())
            {
                //initialize form2, passing this form so the buttons can be reenabled and the install path for documentation
                Form2 installSuccessForm = new Form2(this, installLocation.PathFolderHudLocation);

                //show form2 only if the install succeeded
                installSuccessForm.Show();
                //form contents will be enabled when the success form is closed
            }
            else
            {
                //enable form contents, even if the operation failed.
                form1LayoutPanel.Enabled = true;
            }

            //save the options to the settings file
            optionsTracker.saveOptions();
        }

        //actually install the hud or update the installation with new custom files
        private void installButton_OptionsClick(object sender, EventArgs e)
        {
            //disable form contents
            form1LayoutPanel.Enabled = false;

            //attempt to update the custom files (has its own validation)
            if (installer.updateCustomFiles())
            {
                MessageBox.Show(Properties.Resources.stringMessageUpdateSettingsComplete);
            }

            //enable form contents
            form1LayoutPanel.Enabled = true;

            //save the options to the settings file
            optionsTracker.saveOptions();
        }

        //when there is nothing to install or save, launch the game
        private void installButton_LaunchClick(object sender, EventArgs e)
        {
            //try to launch the game
            if (launchGame())
            {
                //close form1
                this.Close();
            }
        }

        //public custom event called by form2 as it closes
        public void Form1_ReenabledByForm2(object sender, EventArgs e)
        {
            //enable form content
            form1LayoutPanel.Enabled = true;

            //update and save the custom file settings
            optionsTracker.saveOptions();
        }

        //delete and back up whatever hud files are in the destination folder, whether thwartski hud or other
        private void uninstallButton_Click(object sender, EventArgs e)
        {
            //disable form contents
            form1LayoutPanel.Enabled = false;

            //attempt to delete the destination files (without saving backups)
            if (installer.wipeHudFiles(false))
            {
                //show the success message (but only if the function returned true)
                MessageBox.Show(Properties.Resources.stringMessageUninstallComplete);

                //update and save the custom file settings
                optionsTracker.saveOptions();
            }
            //enable form contents, even if the function failed.
            form1LayoutPanel.Enabled = true;

        }

        //save settings on program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //options that have been changed but not saved at the time of install should not be saved
            optionsTracker.revertOptions();
        }






        //CUSTOM METHODS BELOW THIS POINT











        /// <summary>
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        public void updateStrings()  //TODO REMOVE ENTIRELY
        {


            //the path for backup files
            GlobalStrings.BackupPath = installLocation.PathFolderHudLocation + Properties.Resources.stringFolderBackup;
        }





        /// <summary>
        /// Check whether to enable or disable install/uninstall/update buttons
        /// </summary>
        public void updateButtons()
        {
            //the hud is currently installed
            if (installer.isHudInstalled())
            {
                //always enable the uninstall button if the hud is installed
                uninstallButton.Enabled = true;

                //if the hud is installed but options have changed, install button has special rules
                if (optionsTracker.detectOptionsChanges())
                {
                    //options mode changes the event on the button and its text
                    installButtonMode(Properties.Resources.stringButtonInstallOptionsMode);
                }
                //if the hud is installed and no options have changed, it's redundant
                else
                {
                    //launch mode changes the event on the button and its text
                    installButtonMode(Properties.Resources.stringButtonInstallLaunchMode);
                }
            }
            //the hud is not currently installed
            else
            {
                //freshMode is the default functionality of allowing a fresh install
                installButtonMode(Properties.Resources.stringButtonInstallFreshMode);

                //disable uninstall when nothing to uninstall
                uninstallButton.Enabled = false;
            }
        }



        /// <summary>
        /// Change the install button functionality between update and install
        /// </summary>
        private void installButtonMode(string modeSetting)
        {
            //fresh mode
            if (modeSetting == Properties.Resources.stringButtonInstallFreshMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_OptionsClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_LaunchClick);

                //change the install button click event to the normal install event
                this.installButton.Click += new System.EventHandler(this.installButton_InstallClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for fresh mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallFreshMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallFreshMode;

                //generate tooltips with the updated strings
                updateTooltips();
            }
            //update options mode
            else if (modeSetting == Properties.Resources.stringButtonInstallOptionsMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_OptionsClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_LaunchClick);

                //change the install button click event to the special options event
                this.installButton.Click += new System.EventHandler(this.installButton_OptionsClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for options mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallOptionsMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallOptionsMode;

                //generate tooltips with the updated strings
                updateTooltips();
            }
            //launch mode
            else if (modeSetting == Properties.Resources.stringButtonInstallLaunchMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_OptionsClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_LaunchClick);

                //change the install button click event to the special update event
                this.installButton.Click += new System.EventHandler(this.installButton_LaunchClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for launch mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallLaunchMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallFreshMode;

                //generate tooltips with the updated strings
                updateTooltips();
            }

            //something broke
            else
            {
                errorWindow("debug: invalid install mode! modesetting=" + modeSetting);
            }
        }

        /// <summary>
        /// Generate tooltips or update them if strings have changed
        /// </summary>
        private void updateTooltips()
        {
            //clear all the tooltips so duplicates can't be created
            HudInstallerTooltips.RemoveAll();

            //assign browser tooltips
            HudInstallerTooltips.SetToolTip(this.browseFolderInstructionsLabel, GlobalStrings.TooltipFolderBrowse);
            HudInstallerTooltips.SetToolTip(this.folderBrowserBoxLabel, GlobalStrings.TooltipFolderBrowse);
            HudInstallerTooltips.SetToolTip(this.folderBrowserButton, GlobalStrings.TooltipFolderBrowse);
            //assign aspect ratio tooltips
            HudInstallerTooltips.SetToolTip(this.aspectPicturebox, GlobalStrings.TooltipAspectRatio);
            HudInstallerTooltips.SetToolTip(this.aspectLabel, GlobalStrings.TooltipAspectRatio);
            HudInstallerTooltips.SetToolTip(this.aspectCombobox, GlobalStrings.TooltipAspectRatio);
            //assign maxmode scoreboard tooltips
            HudInstallerTooltips.SetToolTip(this.scoreboardMinmodePicturebox, GlobalStrings.TooltipMaxmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMinmodeLabel, GlobalStrings.TooltipMaxmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMinmodeCombobox, GlobalStrings.TooltipMaxmode);
            //assign minmode scoreboard tooltips
            HudInstallerTooltips.SetToolTip(this.scoreboardMaxmodePicturebox, GlobalStrings.TooltipMinmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMaxmodeLabel, GlobalStrings.TooltipMinmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMaxmodeCombobox, GlobalStrings.TooltipMinmode);
            //assign install and uninstall tooltips
            HudInstallerTooltips.SetToolTip(this.installButton, GlobalStrings.TooltipInstallButton);
            HudInstallerTooltips.SetToolTip(this.uninstallButton, GlobalStrings.TooltipUninstallButton);

            //TODO only some tooltips need to be refreshed dynamically rather than just initially defined
        }





        

        /// <summary>
        /// launch the game and close the installer
        /// </summary>
        /// <returns></returns>
        public bool launchGame()
        {
            try
            {
                //launch tf2
                System.Diagnostics.Process.Start(Properties.Resources.stringTeamFortressLaunchCommand);
            }
            //not sure what can go wrong here
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                errorWindow(problem.Message);

                //return false so the app doesn't close
                return false;
            }
            //if the game is launching properly, allow the app to close
            return true;
        }

        /// <summary>
        /// Show a special error window with a sound and a custom message.
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public void errorWindow(string exceptionMessage)
        {
            //open a special messagebox with Error as the window text and an icon
            MessageBox.Show(exceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }







        //TODO remove this button and make the check happen automatically

        //testing for downloading and upzipping files
        private void downloadButton_Click(object sender, EventArgs e)
        {

            //download current updates and check if they need to be installed
            if (downloader.checkAndUpdate())
            {
                //TODO special mode for the install button
            }

        }








    } //namespace
} //class

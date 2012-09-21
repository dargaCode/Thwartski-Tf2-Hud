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
        private Tracker tracker;
        private Buttons buttons;
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

        //instance of form2 to launch after install
        private Form2 form2;




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

            //objects which reference the form and/or other class objects

            //option objects
            this.aspectOption = new Option(installer, aspectCombobox, aspectPicturebox, aspectLabel, Properties.Settings.Default.settingComboboxAspect);
            this.scoreboardMinmodeOption = new Option(installer, scoreboardMinmodeCombobox, scoreboardMinmodePicturebox, scoreboardMinmodeLabel, Properties.Settings.Default.settingComboboxMinmode);
            this.scoreboardMaxmodeOption = new Option(installer, scoreboardMaxmodeCombobox, scoreboardMaxmodePicturebox, scoreboardMaxmodeLabel, Properties.Settings.Default.settingComboboxMaxmode);

            //hud location objects
            this.assetLocation = new Location();
            this.installLocation = new Location();
            
            //one-off class objects
            this.buttons = new Buttons(this, uninstallButton, installButton);
            this.installer = new Installer(buttons, assetLocation, installLocation);
            this.uninstaller = new Uninstaller();
            this.browser = new Browser(installer, InstallBrowserDialog, InstallBrowserPathLabel, InstallBrowserInstructLabel, Properties.Settings.Default.settingInstallBrowserPath);
            this.downloader = new Downloader(assetLocation, installLocation); 

            this.tracker = new Tracker(buttons, installer, assetLocation, installLocation, aspectOption, scoreboardMinmodeOption, scoreboardMaxmodeOption);

            //form2, passing this form so the buttons can be reenabled and the install path for documentation
            this.form2 = new Form2(this, installLocation.PathFolderHudLocation);



            //TODO make these actually dynamic
            //assetLocation.VersionHud = new Version("2.0.4");
            //installLocation.VersionHud = new Version("2.0.4");

            //MessageBox.Show(Convert.ToString("asset version " + assetLocation.VersionHud));
            //MessageBox.Show(Convert.ToString("install version " + installLocation.VersionHud));

            //generate tooltips for the form
            updateTooltips();


            //Generate tooltips, populate strings, comboboxes, and assets.
            tracker.Setup();


            //Fill the browser with a best guess default string or a saved string, if one exists
            browser.Setup();


            //download current updates and check if they need to be installed
            if (downloader.checkAndUpdate())
            {
                //TODO special mode for the install button
            }


        }

        //browse for valid install locations
        private void InstallBrowserButton_Click(object sender, EventArgs e)
        {
            browser.BrowseForInstallFolder();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            tracker.uiUpdate();
        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void aspectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            tracker.updateAspect();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            tracker.uiUpdate();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardMaxmodeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            tracker.updateScoreboard();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            tracker.uiUpdate();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardMinmodeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            tracker.updateScoreboard();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            tracker.uiUpdate();
        }



        //actually install the hud or update the installation with new custom files
        public void installButton_InstallClick(object sender, EventArgs e)
        {
            //disable form contents
            form1LayoutPanel.Enabled = false;

            //attempt to install the hud
            if (installer.performInstallation())
            {
                //show form2 only if the install succeeded
                form2.Show();
                //form contents will be enabled when the success form is closed
            }
            else
            {
                //enable form contents, even if the operation failed.
                form1LayoutPanel.Enabled = true;
            }

            //save the options to the settings file
            tracker.saveOptions();
        }

        //actually install the hud or update the installation with new custom files
        public void installButton_OptionsClick(object sender, EventArgs e)
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
            tracker.saveOptions();
        }

        //when there is nothing to install or save, launch the game
        public void installButton_LaunchClick(object sender, EventArgs e)
        {
            //try to launch the game
            if (installer.launchGame())
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
            tracker.saveOptions();
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
                tracker.saveOptions();
            }
            //enable form contents, even if the function failed.
            form1LayoutPanel.Enabled = true;

        }

        //save settings on program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //options that have been changed but not saved at the time of install should not be saved
            tracker.revertOptions();
        }












        //CUSTOM METHODS BELOW THIS POINT















        /// <summary>
        /// Generate tooltips or update them if strings have changed
        /// </summary>
        public void updateTooltips() //TODO hook this back up
        {
            //clear all the tooltips so duplicates can't be created
            HudInstallerTooltips.RemoveAll();

            //assign browser tooltips
            HudInstallerTooltips.SetToolTip(this.InstallBrowserInstructLabel, GlobalStrings.TooltipFolderBrowse);
            HudInstallerTooltips.SetToolTip(this.InstallBrowserPathLabel, GlobalStrings.TooltipFolderBrowse);
            HudInstallerTooltips.SetToolTip(this.InstallBrowserButton, GlobalStrings.TooltipFolderBrowse);
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





    } //namespace
} //class

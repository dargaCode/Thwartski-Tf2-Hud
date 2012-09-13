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
        private Installer installer;
        private Downloader downloader;
        private Browser browser;
        private Uninstaller uninstaller;

        //instances of the hud to compare, install from etc
        private HudFiles assetHud;
        private HudFiles installHud;

        //instances of options to update, modify files, etc
        private HudOptions aspectOptions;
        private HudOptions scoreboardMinmodeOptions;
        private HudOptions scoreboardMaxmodeOptions;


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
            this.assetHud = new HudFiles(this);
            this.installHud = new HudFiles(this);

            this.aspectOptions = new HudOptions(this, aspectCombobox, aspectPicturebox);
            this.scoreboardMinmodeOptions = new HudOptions(this, scoreboardComboboxMinmode, scoreboardPictureboxMinmode);
            this.scoreboardMaxmodeOptions = new HudOptions(this, scoreboardComboboxMaxmode, scoreboardPictureboxMaxmode);


            //objects which reference other class objects
            this.downloader = new Downloader(this, assetHud, installHud); 
            this.installer = new Installer(this, assetHud, installHud);
            this.optionsTracker = new OptionsTracker(this, assetHud, installHud, aspectOptions, scoreboardMinmodeOptions, scoreboardMaxmodeOptions);

            //basic objects which only reference the form so far
            this.uninstaller = new Uninstaller(this);
            this.browser = new Browser(this);



            //TODO make these actually dynamic
            assetHud.VersionHud = new Version("2.0.4");
            installHud.VersionHud = new Version("2.0.4");



            //generate tooltips for the form
            updateTooltips();



            optionsTracker.PopulateOptionObjects();


            //Generate tooltips, populate strings, comboboxes, and assets.
            optionsTracker.PopulateComboboxes();

            //Fill the browser with a best guess default string or a saved string, if one exists
            browser.populateDefaultPath();





        }

        //browse for valid install locations
        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            BrowseForInstallFolder();

        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void aspectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            aspectOptions.Update();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardComboboxMinmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            scoreboardMinmodeOptions.Update();
        }

        //assign the correct image to the Picturebox, depending on the combobox's selection
        private void scoreboardComboboxMaxmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update images and file paths
            scoreboardMaxmodeOptions.Update();
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
                Form2 installSuccessForm = new Form2(this, installHud.PathFolderHudLocation);

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
            saveOptions();
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
            saveOptions();
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
            saveOptions();
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
                saveOptions();
            }
            //enable form contents, even if the function failed.
            form1LayoutPanel.Enabled = true;

        }

        //save settings on program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //options that have been changed but not saved at the time of install should not be saved
            revertOptions();
        }








        //CUSTOM METHODS BELOW THIS POINT






        /// <summary>
        /// Browse, then make sure user has selected a valid folder.
        /// </summary>
        private void BrowseForInstallFolder()
        {
            // Show the Open File dialog. If the user clicks OK, record their Folder location.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //the player selected a valid folder
                if (folderBrowserDialog1.SelectedPath.EndsWith(Properties.Resources.stringFolderTeamFortress2))
                {
                    setInstallLocation(folderBrowserDialog1.SelectedPath);
                }
                //the player didn't select a valid folder
                else
                {
                    errorWindow(GlobalStrings.MessageBadFolderSelected);
                }
            }
        }


        /// <summary>
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        public void setInstallLocation(string validInstallLocation)
        {
            //MessageBox.Show(validInstallLocation + " is the location to install");

            //global variable used for actually installing the files
            installHud.PathFolderHudLocation = validInstallLocation + Properties.Resources.stringFolderInstallPathTf;

            //prepare the rest of the the strings for install paths, filenames, etc.
            updateStrings();

            //update the install path box
            folderBrowserBoxLabel.Text = validInstallLocation;
            folderBrowserBoxLabel.BackColor = Color.White;

            //update the folder browser dialog
            folderBrowserDialog1.SelectedPath = validInstallLocation;
            folderBrowserDialog1.Description = GlobalStrings.FolderBrowserDescValid;

            //update the install path setting
            Properties.Settings.Default.settingFolderBrowserPath = validInstallLocation;
            //MessageBox.Show("changing path setting: " + Properties.Settings.Default.folderBrowserPath);

            //check whether the install and uninstall buttons should be enabled
            updateButtons();
        }

        /// <summary>
        /// Based on the settings for the two scoreboard comboboxes, determine which files to install.
        /// </summary>
        public void updateScoreboardFiles()
        {
            int maxmodeIndex = scoreboardComboboxMaxmode.SelectedIndex;
            int minmodeIndex = scoreboardComboboxMinmode.SelectedIndex;

            //pub24 maxmode, comp6 minmode
            if (maxmodeIndex == 0 && minmodeIndex == 0)
            {
                //load the corresponding files into bit arrays for later copying
                assetHud.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardPub24Comp6;
                assetHud.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuPub24Comp6;
                //MessageBox.Show("pub24/comp6");
            }
            //pub24 maxmode, comp9 minmode
            else if (maxmodeIndex == 0 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                assetHud.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardPub24Comp9;
                assetHud.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuPub24Comp9;
                //MessageBox.Show("pub24/comp9");
            }
            //pub32 maxmode, comp6 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 0)
            {
                //load the corresponding files into bit arrays for later copying
                assetHud.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardPub32Comp6;
                assetHud.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuPub32Comp6;
                //MessageBox.Show("pub32/comp6");
            }
            //pub32 maxmode, comp9 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                assetHud.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardPub32Comp9;
                assetHud.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuPub32Comp9;
                //MessageBox.Show("pub32/comp9");
            }
            //something went wrong
            else
            {
                //this case is triggered legitimately when the initial values are being set and the second is -1
                //the error messages in each combobox event above should handle everything else
            }
        }

        /// <summary>
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        public void updateStrings()
        {
            //the paths of the custom asset files
            GlobalStrings.AssetOptionsPath = assetHud.PathFolderHudLocation + Properties.Resources.stringFolderInstallPathResource + Properties.Resources.stringFolderInstallPathUi + Properties.Resources.stringFolderAssetOptions;
            GlobalStrings.AspectSelectedAssetPath = GlobalStrings.AssetOptionsPath + assetHud.FilenameHudAspect;
            GlobalStrings.ScoreboardSelectedAssetPath = GlobalStrings.AssetOptionsPath + assetHud.FilenameHudScoreboard;
            GlobalStrings.MenuSelectedAssetPath = GlobalStrings.AssetOptionsPath + assetHud.FilenameHudMenu;

            //the paths the custom asset files will be installed to
            GlobalStrings.CustomInstallPathResource = installHud.PathFolderHudLocation + Properties.Resources.stringFolderInstallPathResource;
            GlobalStrings.CustomInstallPathUi = GlobalStrings.CustomInstallPathResource + Properties.Resources.stringFolderInstallPathUi;

            //the names and paths of the custom install files
            GlobalStrings.MenuFileDestination = GlobalStrings.CustomInstallPathResource + Properties.Resources.stringFilenameInstallMenu;
            GlobalStrings.AspectFileDestination = GlobalStrings.CustomInstallPathUi + Properties.Resources.stringFilenameInstallAspect;
            GlobalStrings.ScoreboardFileDestination = GlobalStrings.CustomInstallPathUi + Properties.Resources.stringFilenameInstallScoreboard;

            //name and path of the "hud is installed" tracking file
            GlobalStrings.InstallCheckerDestination = GlobalStrings.CustomInstallPathResource + Properties.Resources.stringFilenameInstallChecker;

            //the path for backup files
            GlobalStrings.BackupPath = installHud.PathFolderHudLocation + Properties.Resources.stringFolderBackup;

            //MessageBox.Show("installPath: \n" + installPath);
            //MessageBox.Show("assetOptionsPath: \n" + assetOptionsPath);
            //MessageBox.Show("aspectSelectedAssetPath: \n" + aspectSelectedAssetPath);
            //MessageBox.Show("scoreboardSelectedAssetPath: \n" + scoreboardSelectedAssetPath);
            //MessageBox.Show("menuSelectedAssetPath: \n" + menuSelectedAssetPath);
            //MessageBox.Show("customInstallPathResource: \n" + customInstallPathResource);
            //MessageBox.Show("customInstallPathUi: \n" + customInstallPathUi);
            //MessageBox.Show("menuFileDestination: \n" + menuFileDestination);
            //MessageBox.Show("aspectFileDestination: \n" + aspectFileDestination);
            //MessageBox.Show("scoreboardFileDestination: \n" + scoreboardFileDestination);
            //MessageBox.Show("installCheckerDestination: \n" + installCheckerDestination);
            //MessageBox.Show("backupPath: \n" + backupPath);
        }



        /// <summary>
        /// Check if any options are different from their saved values.
        /// </summary>
        public bool detectOptionsChanges()
        {
            //local boolean value used if the hud is installed
            bool optionsChanged = false;

            //if the hud hasn't been installed, no need to detect options changes
            if (!installer.isHudInstalled())
            {
                aspectLabel.BackColor = Color.Empty;
                scoreboardMaxmodeLabel.BackColor = Color.Empty;
                scoreboardMinmodeLabel.BackColor = Color.Empty;
                return false;
            }
            //aspect ratio option is different
            if (aspectCombobox.SelectedIndex != Properties.Settings.Default.settingComboboxAspect)
            {
                //highlight the background
                aspectLabel.BackColor = Color.LightGreen;
                //need to update all 3 before returning true, so updating the local variable instead
                optionsChanged = true;
            }
            //aspect ratio option is not different
            else
            {
                //manually changing it back to empty for cases when the option was changed and then changed back
                aspectLabel.BackColor = Color.Empty;
            }

            //maxmode scoreboard option is different
            if (scoreboardComboboxMaxmode.SelectedIndex != Properties.Settings.Default.settingComboboxMaxmode)
            {
                //highlight the background
                scoreboardMaxmodeLabel.BackColor = Color.LightGreen;
                //need to update all 3 before returning true, so updating the local variable instead
                optionsChanged = true;
            }
            //maxmode scoreboard option is not different
            else
            {
                //manually changing it back to empty for cases when the option was changed and then changed back
                scoreboardMaxmodeLabel.BackColor = Color.Empty;
            }
            //minmode scoreboard option is different
            if (scoreboardComboboxMinmode.SelectedIndex != Properties.Settings.Default.settingComboboxMinmode)
            {
                //highlight the background
                scoreboardMinmodeLabel.BackColor = Color.LightGreen;
                //need to update all 3 before returning true, so updating the local variable instead
                optionsChanged = true;
            }
            //minmode scoreboard option is not different
            else
            {
                //manually changing it back to empty for cases when the option was changed and then changed back
                scoreboardMinmodeLabel.BackColor = Color.Empty;
            }
            //if none of the options were different, this will still be false
            return optionsChanged;
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
                if (detectOptionsChanges())
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
            HudInstallerTooltips.SetToolTip(this.scoreboardPictureboxMaxmode, GlobalStrings.TooltipMaxmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMaxmodeLabel, GlobalStrings.TooltipMaxmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardComboboxMaxmode, GlobalStrings.TooltipMaxmode);
            //assign minmode scoreboard tooltips
            HudInstallerTooltips.SetToolTip(this.scoreboardPictureboxMinmode, GlobalStrings.TooltipMinmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardMinmodeLabel, GlobalStrings.TooltipMinmode);
            HudInstallerTooltips.SetToolTip(this.scoreboardComboboxMinmode, GlobalStrings.TooltipMinmode);
            //assign install and uninstall tooltips
            HudInstallerTooltips.SetToolTip(this.installButton, GlobalStrings.TooltipInstallButton);
            HudInstallerTooltips.SetToolTip(this.uninstallButton, GlobalStrings.TooltipUninstallButton);

            //TODO only some tooltips need to be refreshed dynamically rather than just initially defined
        }

        /// <summary>
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        private void saveOptions()
        {
            //the settings aren't saved until this method is run so the current options can be compared to the saved settings
            //and the install button can be enabled when options have changed.

            //update the settings for each combobox option (the folder browser path is saved right as it changes)
            Properties.Settings.Default.settingComboboxAspect = aspectCombobox.SelectedIndex;
            Properties.Settings.Default.settingComboboxMaxmode = scoreboardComboboxMaxmode.SelectedIndex;
            Properties.Settings.Default.settingComboboxMinmode = scoreboardComboboxMinmode.SelectedIndex;

            //now actually save the settings
            Properties.Settings.Default.Save();

            //update options so that modified options won't remain highlighted
            detectOptionsChanges();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            updateButtons();
        }

        /// <summary>
        /// Revert the options to their state at the last save 
        /// </summary>
        private void revertOptions()
        {
            //update the settings for each combobox options (the folder browser path is saved right as it changes)
            aspectCombobox.SelectedIndex = Properties.Settings.Default.settingComboboxAspect;
            scoreboardComboboxMaxmode.SelectedIndex = Properties.Settings.Default.settingComboboxMaxmode;
            scoreboardComboboxMinmode.SelectedIndex = Properties.Settings.Default.settingComboboxMinmode;

            //update options so that modified options won't remain highlighted
            detectOptionsChanges();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            updateButtons();
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


       









    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Thwartski_Hud_Installer
{
    public partial class Form1 : Form
    {


        //TONS OF GLOBAL VARIABLES, MOSTLY STRINGS



        //boolean for backup checkbox
        static Boolean createBackupFolders = false;

        //exception messages
        //Environment.NewLine for non-escaped linebreaks
        static string exceptionFolderOpen = "The previous hud installation could not be deleted! \n \nPlease make sure your hud folders are closed.";
        static string exceptionGameRunning = "The previous hud installation could not be deleted! \n \nPlease make sure TF2 is not running.";
        static string exceptionAssetsMissing = "The hud source files could not be found! \n \nPlease re-download the installer or replace any deleted files.";

        //success messages
        static string updateSettingsCompleteMessage =   "Your custom options have been installed.";
        static string uninstallCompleteMessage =        "All hud files are now reverted to Valve defaults. \n \nBackups of hud files can be found in ";

        //display text for comboboxes arrays
        static string aspectNormalText =                "Normal";
        static string aspectWidescreenText =            "Widescreen";
        static string scoreboardComp6Text =             "6v6";
        static string scoreboardComp9Text =             "Highlander";
        static string scoreboardPub24Text =             "24 Player";
        static string scoreboardPub32Test =             "32 Player";

        //display text for install button modes
        static string installMode =                     "Install Hud";
        static string updateMode =                      "Update Options";
        static string disabledMode =                    "Already Installed";
        
        //paths for populating the folder browser
        static string defaultSteamappsFolder32Bit =     @"C:\Program Files (x86)\Steam\steamapps\";
        static string defaultSteamappsFolder64Bit =     @"C:\Program Files\Steam\steamapps\";
        static string unknownSteamappsFolder =          @"\YOUR_STEAM_FOLDER\steamapps\";
        static string unknownSteamUser =                @"YOUR_USERNAME";
        static string teamFortress2Subfolder =          @"\team fortress 2";
        static string steamappsFolder;                  //written at runtime
        static string steamUser;                        //written at runtime

        //paths for browsing folders
        static string partialTeamFortress2Location;     //written at runtime
        static string unknownTeamFortress2Location =    unknownSteamappsFolder + unknownSteamUser + teamFortress2Subfolder;

        //forder browser descriptions and errors
        static string unknownFolderBrowserDesc =        @"Please select " + unknownTeamFortress2Location;
        static string partialFolderBrowserDesc =        @"Please select your \steamapps\" + unknownSteamUser + teamFortress2Subfolder + " folder";
        static string validFolderBrowserDesc =          @"Please select your Team Fortress 2 folder.";
        static string badFolderSelectedMessage =        @"Please select " + unknownTeamFortress2Location;

        //see where the exe is running from
        static string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath); 
        
        //paths for copying assets and installing them
        static string assetPath =                       exeFolder + @"\Install Files\";
        static string installPathTfSubFolder =          @"\tf\";
        static string installPathResourceSubfolder =    @"resource\";
        static string installPathUiSubfolder =          @"ui\";
        static string installPath;                      //written at runtime
        static string assetOptionsSubfolder =           @"_Thwartski Hud Options\";
        static string assetOptionsPath;                 //written at runtime
        static string backupSubFolder =                 @"_HUD BACKUPS\";
        static string backupPath;                       //written at runtime

        //used for cycling through assetfolder directory
        static DirectoryInfo assetFolderDir = new DirectoryInfo(assetPath);

        //names of custom asset files for aspect options
        static string aspectAssetFileNormal =           "SpectatorTournament_Normal.res";
        static string aspectAssetFileWidescreen =       "SpectatorTournament_Widescreen.res";

        //names of custom asset files for scoreboard options
        static string scoreboardAssetFilePub24Comp6 =   "ScoreBoard_Pub24Comp6.res";
        static string scoreboardAssetFilePub24Comp9 =   "ScoreBoard_Pub24Comp9.res";
        static string scoreboardAssetFilePub32Comp6 =   "ScoreBoard_Pub32Comp6.res";
        static string scoreboardAsserFilePub32Comp9 =   "ScoreBoard_Pub32Comp9.res";

        //names of custom asset files for menu options
        static string menuAssetFilePub24Comp6 =         "GameMenu_Pub24Comp6.res";
        static string menuAssetFilePub24Comp9 =         "GameMenu_Pub24Comp9.res";
        static string menuAssetFilePub32Comp6 =         "GameMenu_Pub32Comp6.res";
        static string menuAssetFilePub32Comp9 =         "GameMenu_Pub32Comp9.res";

        //which custom assets were selected to be installed in the comboboxes
        static string aspectSelectedAssetFile;          //written at runtime
        static string scoreboardSelectedAssetFile;      //written at runtime
        static string menuSelectedAssetFile;            //written at runtime
        static string aspectSelectedAssetPath;          //written at runtime
        static string scoreboardSelectedAssetPath;      //written at runtime
        static string menuSelectedAssetPath;            //written at runtime

        //names of custom install files to write the asset options to
        static string aspectInstallFile =               "SpectatorTournament.res";
        static string scoreboardInstallFile =           "ScoreBoard.res";
        static string menuInstallFile =                 "GameMenu.res";

        //paths to write custom files to
        static string customInstallPathResource;        //written at runtime
        static string customInstallPathUi;              //written at runtime
        static string aspectFileDestination;            //written at runtime
        static string scoreboardFileDestination;        //written at runtime
        static string menuFileDestination;              //written at runtime

        //file and path to let the buttons know the hud is installed
        static string installCheckerFile =              "Thwartski Hud Installed.txt";
        static string installCheckerDestination;        //written at runtime



        //FORM EVENTS BELOW THIS POINT



        public Form1()
        {
            InitializeComponent();
        }

        //default functionality as form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //create arrays of combobox strings
            string[] aspects = { aspectNormalText, aspectWidescreenText };
            string[] scoreboardsMaxmode = { scoreboardPub24Text, scoreboardPub32Test };
            string[] scoreboardsMinmode = { scoreboardComp6Text, scoreboardComp9Text };

            //populate the comboboxes with the correct options
            aspectSelector.Items.AddRange(aspects);
            scoreboardSelectorMaxmode.Items.AddRange(scoreboardsMaxmode);
            scoreboardSelectorMinmode.Items.AddRange(scoreboardsMinmode);

            //load settings for comboxes and checkboxes
            backupCheckbox.Checked = Properties.Settings.Default.settingSaveBackups;
            aspectSelector.SelectedIndex = Properties.Settings.Default.settingComboboxAspect;
            scoreboardSelectorMaxmode.SelectedIndex = Properties.Settings.Default.settingComboboxMaxmode;
            scoreboardSelectorMinmode.SelectedIndex = Properties.Settings.Default.settingComboboxMinmode;

            //decide whether to use the saved install path setting or to start generating one
            string savedBrowserPath = Properties.Settings.Default.settingFolderBrowserPath;
            if (Directory.Exists(savedBrowserPath) && savedBrowserPath.EndsWith(teamFortress2Subfolder))
            {
                //allow the hud to be installed at the saved location
                setInstallLocation(savedBrowserPath);
                //MessageBox.Show("saved location good: " + savedBrowserPath);
            }
            else
            {
                //try to guess at a default install directory
                SetDefaultFolder();
                //MessageBox.Show("saved location no good: " + savedBrowserPath);
            }
        }

        //browse for valid install locations
        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, record their
            // Folder location.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //the player selected a valid folder
                if (folderBrowserDialog1.SelectedPath.EndsWith(teamFortress2Subfolder))
                {
                    setInstallLocation(folderBrowserDialog1.SelectedPath);
                }
                //the player didn't select a valid folder
                else
                {
                    errorWindow(badFolderSelectedMessage);
                }
            }
        }

        //enable or disable creating backups when modifying hud files
        private void backupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (backupCheckbox.Checked)
            {
                //update global variable  (but not settings)
                createBackupFolders = true;
            }
            else
            {
                //update global variable (but not settings)
                createBackupFolders = false;
            }
        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void aspectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //normal aspect ratio
            if (aspectSelector.SelectedIndex == 0)
            {
                //load image resource
                aspectImageBox.Image = Properties.Resources.aspectImageNormal;

                //load the matching file into a bit array for later copying
                aspectSelectedAssetFile = aspectAssetFileNormal;
            }
            //widescreen aspect ratio
            else if (aspectSelector.SelectedIndex == 1)
            {
                //load image resource
                aspectImageBox.Image = Properties.Resources.aspectImageWidescreen;

                //load the matching file into a bit array for later copying
                aspectSelectedAssetFile = aspectAssetFileWidescreen;
            }
            //something went wrong
            else
            {
                errorWindow("debug: variable index out of range! aspect=" + aspectSelector.SelectedIndex);
            }

            //update the text strings, buttons, etc.
            optionsTracker();
        }

        //assign the correct image to the imagebox, depending on the combobox's selection
        private void scoreboardSelectorMaxmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pub24 scoreboard
            if (scoreboardSelectorMaxmode.SelectedIndex == 0)
            {
                //load image resource
                scoreboardPictureboxMaxmode.Image = Properties.Resources.scoreboardImagePub24;
            }
            //pub32 scoreboard
            else if (scoreboardSelectorMaxmode.SelectedIndex == 1)
            {
                //load image resource
                scoreboardPictureboxMaxmode.Image = Properties.Resources.scoreboardImagePub32;
            }
            //something went wrong
            else
            {
                errorWindow("debug: variable index out of range! maxmode=" + scoreboardSelectorMaxmode.SelectedIndex);
            }
            //check both comboboxes and identify the right scoreboard files
            updateScoreboardFiles();

            //update the text strings, buttons, etc.
            optionsTracker();
        }
        //assign the correct image to the imagebox, depending on the combobox's selection
        private void scoreboardSelectorMinmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comp6 scoreboard
            if (scoreboardSelectorMinmode.SelectedIndex == 0)
            {
                //load image resource
                scoreboardPictureboxMinmode.Image = Properties.Resources.scoreboardImageComp6;
            }
            //comp9 scoreboard
            else if (scoreboardSelectorMinmode.SelectedIndex == 1)
            {
                //load image resource
                scoreboardPictureboxMinmode.Image = Properties.Resources.scoreboardImageComp9;
            }
            //something went wrong
            else
            {
                errorWindow("debug: variable index out of range! minmode=" + scoreboardSelectorMinmode.SelectedIndex);
            }

            //check both comboboxes and identify the right scoreboard files
            updateScoreboardFiles();

            //update the text strings, buttons, etc.
            optionsTracker();
        }
        //actually install the hud or update the installation with new custom files
        private void installButton_InstallClick(object sender, EventArgs e)
        {
            //disable form contents
            tableLayoutPanel1.Enabled = false;

            //attempt to install the hud
            if (installHud())
            {
                //initialize form2, passing this form so the buttons can be reenabled and the install path for documentation
                Form2 installSuccessForm = new Form2(this, installPath);

                //show form2 only if the install succeeded
                installSuccessForm.Show();
                //form contents will be enabled when the success form is closed
            }
            else
            {
                //enable form contents, even if the operation failed.
                tableLayoutPanel1.Enabled = true;
            }

            //save the options to the settings file
            saveOptions();
        }

        //actually install the hud or update the installation with new custom files
        private void installButton_UpdateClick(object sender, EventArgs e)
        {
            //disable form contents
            tableLayoutPanel1.Enabled = false;

            //attempt to update the custom files (has its own validation)
            if (updateCustomFiles())
            {
                MessageBox.Show(updateSettingsCompleteMessage);
            }

            //enable form contents
            tableLayoutPanel1.Enabled = true;

            //save the options to the settings file
            saveOptions();
        }


        //public custom event called by form2 as it closes
        public void Form1_ReenabledByForm2(object sender, EventArgs e)
        {
            //enable form content
            tableLayoutPanel1.Enabled = true;

            //update and save the custom file settings
            saveOptions();
        }

        //delete and back up whatever hud files are in the destination folder, whether thwartski hud or other
        private void uninstallButton_Click(object sender, EventArgs e)
        {
            //disable form contents
            tableLayoutPanel1.Enabled = false;

            //attempt to delete the destination files
            if (wipeHudFiles())
            {
                //show the success message (but only if the function returned true)
                MessageBox.Show(uninstallCompleteMessage + teamFortress2Subfolder + installPathTfSubFolder + backupSubFolder);

                //update and save the custom file settings
                saveOptions();
            }
            //enable form contents, even if the function failed.
            tableLayoutPanel1.Enabled = true;

        }

        //save settings on program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //options that have been changed but not saved at the time of install should not be saved
            revertOptions();
        }



        //CUSTOM METHODS BELOW THIS POINT
        


        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        private void SetDefaultFolder()
        {
            if (Directory.Exists(defaultSteamappsFolder32Bit))
            {
                //a steam folder was fond
                steamappsFolder = defaultSteamappsFolder32Bit;

                //try to guess your username
                guessSteamUser(steamappsFolder); 
            }
            else if (Directory.Exists(defaultSteamappsFolder64Bit))
	        {
                //a steam folder was found
                steamappsFolder = defaultSteamappsFolder64Bit;

                //try to guess your username
                guessSteamUser(defaultSteamappsFolder64Bit); 
	        }
            else
            {
                //no obvious steam install was found
                folderBrowserLabel.Text = unknownTeamFortress2Location;
                folderBrowserDialog1.Description = unknownFolderBrowserDesc;
            }
        }

        /// <summary>
        /// Find a likely folder for the player's steam username.
        /// </summary>
        private void guessSteamUser(string steamappsFolder)
        {
            //create an array of the possible steam user folders
            DirectoryInfo possibleSteamUserFoldersDir = new DirectoryInfo(steamappsFolder);
            DirectoryInfo[] steamUserFolders = possibleSteamUserFoldersDir.GetDirectories();

            //cycle through the steamapps folders in the default location, and eliminate obvious mismatches
            foreach (DirectoryInfo steamUserFolder in steamUserFolders)
            {
                //MessageBox.Show(Convert.ToString(steamUser));

                if (Convert.ToString(steamUserFolder) == "common")
                {
                    //everyone has this folder; do nothing
                }
                else if (Convert.ToString(steamUserFolder) == "downloading")
                {
                    //everyone has this folder; do nothing
                }
                else if (Convert.ToString(steamUserFolder) == "sourcemods")
                {
                    //everyone has this folder; do nothing
                }
                else if (Convert.ToString(steamUserFolder) == "temp")
                {
                    //everyone has this folder; do nothing
                }
                else
                {
                    //whatever's left is likely to be a userfolder.
                    DirectoryInfo possibleTeamFortress2PathDir = new DirectoryInfo(steamappsFolder + steamUserFolder + teamFortress2Subfolder);

                    //the possible user contains the right folders
                    if (possibleTeamFortress2PathDir.Exists)
	                {
                        //MessageBox.Show(defaultFolder + steamUser + teamFortress2Folder);

                        //the username is legit
                        steamUser = Convert.ToString(steamUserFolder);
                        //MessageBox.Show(steamUser + " is the userfolder");
                        
                        //allow install at this location
                        setInstallLocation(Convert.ToString(possibleTeamFortress2PathDir));

                        //stop cycling through steam users
                        return;

	                }
                    //this user seemed legitimate, but didn't contain the right subfolder. keep looking
                    else
                    {
                        //MessageBox.Show(defaultFolder + steamUser + teamFortress2Folder + "doesn't exist");
                    }
                }
            }
            //failed to find a steam user with tf2 obviously installed
            //MessageBox.Show("no users were found with " + teamFortress2Folder);

            //build the partial path
            steamUser = unknownSteamUser;
            partialTeamFortress2Location = steamappsFolder + steamUser + teamFortress2Subfolder;

            //update the textbox and folder browser with the partial path to get the player started.
            folderBrowserDialog1.SelectedPath = steamappsFolder;
            folderBrowserLabel.Text = partialTeamFortress2Location;

            //change the text in the folder browser dialog
            folderBrowserDialog1.Description = partialFolderBrowserDesc;
        }

        /// <summary>
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        private void setInstallLocation(string validInstallLocation)
        {
            //MessageBox.Show(validInstallLocation + " is the location to install");

            //global variable used for actually installing the files
            installPath = validInstallLocation + installPathTfSubFolder;

            //prepare the rest of the the strings for install paths, filenames, etc.
            updateStrings();

            //update the install path box
            folderBrowserLabel.Text = validInstallLocation;
            folderBrowserLabel.BackColor = Color.White;

            //update the folder browser dialog
            folderBrowserDialog1.SelectedPath = validInstallLocation;
            folderBrowserDialog1.Description = validFolderBrowserDesc;

            //update the install path setting
            Properties.Settings.Default.settingFolderBrowserPath = validInstallLocation;
            //MessageBox.Show("changing path setting: " + Properties.Settings.Default.folderBrowserPath);

            //check whether the install and uninstall buttons should be enabled
            updateButtons();
        }

        /// <summary>
        /// Based on the settings for the two scoreboard comboboxes, determine which files to install.
        /// </summary>
        private void updateScoreboardFiles()
        {
            int maxmodeIndex = scoreboardSelectorMaxmode.SelectedIndex;
            int minmodeIndex = scoreboardSelectorMinmode.SelectedIndex;

            //pub24 maxmode, comp6 minmode
            if (maxmodeIndex == 0 && minmodeIndex == 0)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardSelectedAssetFile = scoreboardAssetFilePub24Comp6;
                menuSelectedAssetFile = menuAssetFilePub24Comp6;
                //MessageBox.Show("pub24/comp6");
            }
            //pub24 maxmode, comp9 minmode
            else if (maxmodeIndex == 0 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardSelectedAssetFile = scoreboardAssetFilePub24Comp9;
                menuSelectedAssetFile = menuAssetFilePub24Comp9;
                //MessageBox.Show("pub24/comp9");
            }
            //pub32 maxmode, comp6 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 0)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardSelectedAssetFile = scoreboardAssetFilePub32Comp6;
                menuSelectedAssetFile = menuAssetFilePub32Comp6;
                //MessageBox.Show("pub32/comp6");
            }
            //pub32 maxmode, comp9 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardSelectedAssetFile = scoreboardAsserFilePub32Comp9;
                menuSelectedAssetFile = menuAssetFilePub32Comp9;
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
        private void updateStrings()
        {
            //the paths of the custom asset files
            assetOptionsPath = assetPath + installPathResourceSubfolder + installPathUiSubfolder + assetOptionsSubfolder;
            aspectSelectedAssetPath = assetOptionsPath + aspectSelectedAssetFile;
            scoreboardSelectedAssetPath = assetOptionsPath + scoreboardSelectedAssetFile;
            menuSelectedAssetPath = assetOptionsPath + menuSelectedAssetFile;

            //the paths the custom asset files will be installed to
            customInstallPathResource = installPath + installPathResourceSubfolder;
            customInstallPathUi = customInstallPathResource + installPathUiSubfolder;

            //the names and paths of the custom install files
            menuFileDestination = customInstallPathResource + menuInstallFile;
            aspectFileDestination = customInstallPathUi + aspectInstallFile;
            scoreboardFileDestination = customInstallPathUi + scoreboardInstallFile;

            //name and path of the "hud is installed" tracking file
            installCheckerDestination = customInstallPathResource + installCheckerFile;

            //the path for backup files
            backupPath = installPath + backupSubFolder;

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
        /// Update all relevant elements when an option is changed.
        /// </summary>
        private void optionsTracker()
        {
            //rebuild text strings
            updateStrings();

            //update options string background color
            detectOptionsChanges();

            //update install/uninstall buttons
            updateButtons();
        }

        /// <summary>
        /// Check if any options are different from their saved values.
        /// </summary>
        public bool detectOptionsChanges()
        {
            //local boolean value used if the hud is installed
            bool optionsChanged = false;

            //if the hud hasn't been installed, no need to detect options changes
            if (!isHudInstalled())
            {
                aspectLabel.BackColor = Color.Empty;
                scoreboardMaxmodeLabel.BackColor = Color.Empty;
                scoreboardMinmodeLabel.BackColor = Color.Empty;
                return false;
            }
            //aspect ratio option is different
            if (aspectSelector.SelectedIndex != Properties.Settings.Default.settingComboboxAspect)
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
            if (scoreboardSelectorMaxmode.SelectedIndex != Properties.Settings.Default.settingComboboxMaxmode)
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
            if (scoreboardSelectorMinmode.SelectedIndex != Properties.Settings.Default.settingComboboxMinmode)
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
        private void updateButtons()
        {
            //the hud is currently installed
            if (isHudInstalled())
            {
                //always enable the uninstall button if the hud is installed
                uninstallButton.Enabled = true;

                //if the hud is installed but options have changed, install button has special rules
                if (detectOptionsChanges())
                {
                    //update mode changes the event on the button and its text
                    installButtonMode(updateMode);
                }
                //if the hud is installed and no options have changed, it's redundant
                else
                {
                    //disabled mode cleans up extra events from the buttons and disables it
                    installButtonMode(disabledMode);
                }
            }
            //the hud is not currently installed
            else
            {
                //installmode is the default functionality of allowing a fresh install
                installButtonMode(installMode);

                //disable uninstall when nothing to uninstall
                uninstallButton.Enabled = false;
            }
        }

        /// <summary>
        /// check if the hud is installed
        /// </summary>
        /// <returns></returns>
        public bool isHudInstalled() 
        {
            //check for the dummy file in the resource folder
            if (System.IO.File.Exists(installCheckerDestination))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Change the install button functionality between update and install
        /// </summary>
        private void installButtonMode(string modeSetting)
        {
            //defining fonts to use for bolding and unbolding the button text
            Font unboldedButtonFont = new Font(installButton.Font, FontStyle.Regular);
            Font boldedButtonFont = new Font(installButton.Font, FontStyle.Bold);

            //install mode
            if (modeSetting == installMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_UpdateClick);

                //change the install button click event to the normal install event
                this.installButton.Click += new System.EventHandler(this.installButton_InstallClick);

                //enable the install button
                installButton.Enabled = true;

                //bold the install button
                installButton.Font = boldedButtonFont;
                //unbold the uninstall button
                uninstallButton.Font = unboldedButtonFont;
            }
            //update options mode
            else if (modeSetting == updateMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_UpdateClick);

                //change the install button click event to the special update event
                this.installButton.Click += new System.EventHandler(this.installButton_UpdateClick);

                //enable the install button
                installButton.Enabled = true;

                //bold the install button
                installButton.Font = boldedButtonFont;
                //unbold the uninstall button
                uninstallButton.Font = unboldedButtonFont;
            }
            //disabled mode
            else if (modeSetting == disabledMode)
            {
                //update the button text to match the mode
                installButton.Text = modeSetting;

                //clean up old events on the install button
                this.installButton.Click -= new System.EventHandler(this.installButton_InstallClick);
                this.installButton.Click -= new System.EventHandler(this.installButton_UpdateClick);

                //disable the install button
                installButton.Enabled = false;

                //unbold the install button
                installButton.Font = unboldedButtonFont;
                //bold the uninstall button
                uninstallButton.Font = boldedButtonFont;
            }
            //something broke
            else
            {
                errorWindow("debug: invalid install mode! modesetting=" + modeSetting);
            }
        }

        /// <summary>
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        private void saveOptions()
        {
            //the settings aren't saved until this method is run so the current options can be compared to the saved settings
            //and the install button can be enabled when options have changed.

            //update the settings for each combobox and checkbox options (the folder browser path is saved right as it changes)
            Properties.Settings.Default.settingComboboxAspect = aspectSelector.SelectedIndex;
            Properties.Settings.Default.settingComboboxMaxmode = scoreboardSelectorMaxmode.SelectedIndex;
            Properties.Settings.Default.settingComboboxMinmode = scoreboardSelectorMinmode.SelectedIndex;
            Properties.Settings.Default.settingSaveBackups = createBackupFolders;

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
            //update the settings for each combobox and checkbox options (the folder browser path is saved right as it changes)
            aspectSelector.SelectedIndex = Properties.Settings.Default.settingComboboxAspect;
            scoreboardSelectorMaxmode.SelectedIndex = Properties.Settings.Default.settingComboboxMaxmode;
            scoreboardSelectorMinmode.SelectedIndex = Properties.Settings.Default.settingComboboxMinmode;
            createBackupFolders = Properties.Settings.Default.settingSaveBackups;

            //update options so that modified options won't remain highlighted
            detectOptionsChanges();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            updateButtons();
        }

        /// <summary>
        /// Attempt to install the hud.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        public bool installHud()
        {
            //Used for iterating through file and folder lists
            DirectoryInfo installFolderDir = new DirectoryInfo(installPath);

            //attempt to delete the destination files (contains its own exception handling)
            if (!wipeHudFiles())
            {
                //wiping the hud failed; immediately return false
                return false;
            }
            else
            {
                //exception handling for installing the hud
                try
                {
                    //wiping the hud succeeded. attempt to install the new hud files
                    copyFilesAndFolders(assetFolderDir, installFolderDir);

                    //create a dummy text file to let the launcher know the hud is installed
                    if (!isHudInstalled())
                    {
                        //create the file, but just close it without writing any text inside
                        using (StreamWriter versionFile = new StreamWriter(installCheckerDestination))
                        {
                            versionFile.Close();
                            versionFile.Dispose();
                        }
                    }
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    //happens when the gameassets folder has been deleted or moved away from the exe
                    errorWindow(exceptionAssetsMissing);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.UnauthorizedAccessException)
                {
                    //happens when tf2 is running (and therefore keeping the font files in use).
                    errorWindow(exceptionGameRunning);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.IO.IOException)
                {
                    //usually happens when the user tries to delete a folder they are viewing.
                    errorWindow(exceptionFolderOpen);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.Exception problem)
                {
                    //generic exception for unexpected case
                    errorWindow(problem.Message);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
            }
            //attempt to update the custom files (contains its own exception handling)
            if (!updateCustomFiles())
            {
                //installing custom files failed; immediately return false
                return false;
            }
            //uninstalling and installing worked with no exceptions; return true
            return true;
        }

        /// <summary>
        /// Backup and delete all relevant files from the install directory.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        public bool wipeHudFiles()
        {
            //Establish backup time so different folders can't straddle multiple seconds. (this actually has been happening)
            string timestampFolderName = String.Format(@"\Date-{0:yyyy-MM-dd_}Time.{1:HH.mm.ss}\", DateTime.Now, DateTime.Now);
            //MessageBox.Show(timestampFolderName);

            //exception handling for file deletion
            try
            {
                //Iterate through all the folders in the source asset folder and back up all of them before copying.
                DirectoryInfo[] assetSubFolders = assetFolderDir.GetDirectories();
                foreach (DirectoryInfo assetSubFolder in assetSubFolders)
                {
                    backupAndDeleteFolder(installPath, assetSubFolder, backupPath, createBackupFolders, timestampFolderName);
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                //happens when the gameassets folder has been deleted or moved away from the exe
                errorWindow(exceptionAssetsMissing);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.UnauthorizedAccessException)
            {
                //happens when tf2 is running (and therefore keeping the font files in use).
                errorWindow(exceptionGameRunning);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.IO.IOException)
            {
                //usually happens when the user tries to delete a folder they are viewing.
                errorWindow(exceptionFolderOpen);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                errorWindow(problem.Message);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            //if everything worked with no exceptions, return true
            return true;
        }

        /// <summary>
        /// Back up the folder with a timestamp, then delete it and all its contents.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void backupAndDeleteFolder(string sourcePath, DirectoryInfo folderName, string backupPath, bool backupDesired, string backupFolderName)
        {
            string existingCompletePath = sourcePath + folderName;
            string backupCompletePath = backupPath + backupFolderName + folderName;

            DirectoryInfo existingFolderDir = new DirectoryInfo(existingCompletePath);
            DirectoryInfo backupFolderDir = new DirectoryInfo(backupCompletePath);

            if (existingFolderDir.Exists)
            {
                //If the player hasn't deleted it, and they checked the option, back the folder up.
                if (backupDesired)
                {
                    copyFilesAndFolders(existingFolderDir, backupFolderDir);
                }

                //delete existing hud file either way
                Directory.Delete(existingCompletePath, true);
            }
        }

        /// <summary>
        /// Copy all files and folders to a new location, overwriting all files.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void copyFilesAndFolders(DirectoryInfo sourceFolder, DirectoryInfo destinationFolder)
        {
            if (!destinationFolder.Exists)
            {
                destinationFolder.Create();
            }
            else
            {
                //Make the folder writeable
                destinationFolder.Attributes = FileAttributes.Normal;
            }

            // Copy all files. 
            FileInfo[] files = sourceFolder.GetFiles();
            foreach (FileInfo asset in files)
            {
                //make the file writeable
                asset.IsReadOnly = false;

                //Copy file to new location, overwriting if it already exists.
                asset.CopyTo(Path.Combine(destinationFolder.FullName, asset.Name), true);
            }

            // Process subdirectories. 
            DirectoryInfo[] subfolders = sourceFolder.GetDirectories();
            foreach (DirectoryInfo sourceSubFolder in subfolders)
            {
                // Get destination directory. 
                string destinationSubFolder = Path.Combine(destinationFolder.FullName, sourceSubFolder.Name);

                // Call CopyDirectory() recursively. 
                copyFilesAndFolders(sourceSubFolder, new DirectoryInfo(destinationSubFolder));
            }
        }

        /// <summary>
        /// Don't install the full hud, just update the custom files.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        public bool updateCustomFiles()
        {
            //exception handling for installing the hud
            try
            {
                //copy the custom files from their asset location to their install location
                System.IO.File.Copy(menuSelectedAssetPath, menuFileDestination, true);
                System.IO.File.Copy(aspectSelectedAssetPath, aspectFileDestination, true);
                System.IO.File.Copy(scoreboardSelectedAssetPath, scoreboardFileDestination, true);

                //MessageBox.Show(assetFolderDir + " to " + installFolderDir);
                //MessageBox.Show(menuSelectedAssetPath + " to " + menuFileDestination);
                //MessageBox.Show(aspectSelectedAssetPath + " to " + aspectFileDestination);
                //MessageBox.Show(scoreboardSelectedAssetPath + " to " + scoreboardFileDestination);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                //happens when the gameassets folder has been deleted or moved away from the exe
                errorWindow(exceptionAssetsMissing);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.UnauthorizedAccessException)
            {
                //happens when tf2 is running (and therefore keeping the font files in use).
                errorWindow(exceptionGameRunning);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.IO.IOException)
            {
                //usually happens when the user tries to delete a folder they are viewing.
                errorWindow(exceptionFolderOpen);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                errorWindow(problem.Message);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }

            //installing the custom files worked with no exceptions; return true
            return true;
        }

        /// <summary>
        /// Show a special error window with a sound and a custom message.
        /// </summary>
        /// <param name="exceptionMessage"></param>
        private void errorWindow(string exceptionMessage)
        {
            //open a special messagebox with Error as the window text and an icon
            MessageBox.Show(exceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
       
    }
}

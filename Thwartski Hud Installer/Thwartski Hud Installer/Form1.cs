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

        //status updates and error messages
        //Environment.NewLine for non-escaped linebreaks
        static string exceptionFolderOpen =             "The previous hud installation could not be deleted! \n \nPlease make sure your hud folders are closed.";
        static string exceptionGameRunning =            "The previous hud installation could not be deleted! \n \nPlease make sure TF2 is not running.";
        static string exceptionAssetsMissing =          "The hud source files could not be found! \n \nPlease re-download the installer or replace any deleted files.";
        static string uninstallCompleteMessage =        "All hud files are now reverted to Valve defaults. \n \nBackups of hud files can be found in ";

        //display text for comboboxes arrays
        static string aspectNormalText =                "Normal";
        static string aspectWidescreenText =            "Widescreen";
        static string scoreboardComp6Text =             "Competitive";
        static string scoreboardComp9Text =             "Highlander";
        static string scoreboardPub24Text =             "Pub 24";
        static string scoreboardPub32Test =             "Pub 32";
        
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

        //paths for copying assets and installing them
        static string assetPath =                       @"Install Files\"; //relative to exe
        static string installPath;                      //written at runtime
        static string installPathTfSubFolder =          @"\tf\";
        static string installPathResourceSubfolder =    @"resource\";
        static string installPathUiSubfolder =          @"ui\";
        static string assetOptionsPath =                assetPath + installPathResourceSubfolder + installPathUiSubfolder + @"_Thwartski Hud Options\";
        static string backupPath;                       //written at runtime
        static string backupSubFolder =                 @"_HUD BACKUPS\";

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

        static string customInstallPathResource;        //written at runtime
        static string customInstallPathUi;              //written at runtime
        static string aspectFileDestination;            //written at runtime
        static string scoreboardFileDestination;        //written at runtime
        static string menuFileDestination;              //written at runtime



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
            if (Directory.Exists(savedBrowserPath) && savedBrowserPath.EndsWith("team fortress 2"))
            {
                //allow the hud to be installed at the saved location
                enableInstall(savedBrowserPath);
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
                if (folderBrowserDialog1.SelectedPath.EndsWith("team fortress 2"))
                {
                    enableInstall(folderBrowserDialog1.SelectedPath);
                }
                //the player didn't select a valid folder
                else
                {
                    MessageBox.Show(badFolderSelectedMessage);
                }
            }
        }

        //enable or disable creating backups when modifying hud files
        private void backupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (backupCheckbox.Checked)
            {
                //update global variable and settings
                createBackupFolders = true;
                Properties.Settings.Default.settingSaveBackups = true;
            }
            else
            {
                //update global variable and settings
                createBackupFolders = false;
                Properties.Settings.Default.settingSaveBackups = false;
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
                MessageBox.Show("debug: variable index out of range! aspect=" + aspectSelector.SelectedIndex);
            }
            //save settings
            Properties.Settings.Default.settingComboboxAspect = aspectSelector.SelectedIndex;
            //rebuild text strings
            assembleStrings();
        }

        //assign the correct image to the imagebox, depending on the combobox's selection
        private void scoreboardSelectorMaxmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pub24 scoreboard
            if (scoreboardSelectorMaxmode.SelectedIndex == 0)
            {
                //load image resource
                scoreboardPictureboxMaxmode.Image = Properties.Resources.scoreboardImagePub24;

                //check both comboboxes and identify the right scoreboard files
                determineScoreboardFiles();
            }
            //pub32 scoreboard
            else if (scoreboardSelectorMaxmode.SelectedIndex == 1)
            {
                //load image resource
                scoreboardPictureboxMaxmode.Image = Properties.Resources.scoreboardImagePub32;

                //check both comboboxes and identify the right scoreboard files
                determineScoreboardFiles();
            }
            //something went wrong
            else
            {
                MessageBox.Show("debug: variable index out of range! maxmode=" + scoreboardSelectorMaxmode.SelectedIndex);
            }
            //save settings
            Properties.Settings.Default.settingComboboxMaxmode = scoreboardSelectorMaxmode.SelectedIndex;
            //rebuild text strings
            assembleStrings();
        }
        //assign the correct image to the imagebox, depending on the combobox's selection
        private void scoreboardSelectorMinmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comp6 scoreboard
            if (scoreboardSelectorMinmode.SelectedIndex == 0)
            {
                //load image resource
                scoreboardPictureboxMinmode.Image = Properties.Resources.scoreboardImageComp6;

                //check both comboboxes and identify the right scoreboard files
                determineScoreboardFiles();
            }
            //comp9 scoreboard
            else if (scoreboardSelectorMinmode.SelectedIndex == 1)
            {
                //load image resource
                scoreboardPictureboxMinmode.Image = Properties.Resources.scoreboardImageComp9;

                //check both comboboxes and identify the right scoreboard files
                determineScoreboardFiles();
            }
            //something went wrong
            else
            {
                MessageBox.Show("debug: variable index out of range! minmode=" + scoreboardSelectorMinmode.SelectedIndex);
            }
            //save settings
            Properties.Settings.Default.settingComboboxMinmode = scoreboardSelectorMinmode.SelectedIndex;
            //rebuild text strings
            assembleStrings();
        }
        //actually install the hud or update the installation with new custom files
        private void installButton_Click(object sender, EventArgs e)
        {
            //disable all buttons
            tableLayoutPanel1.Enabled = false;

            //attempt to install the hud
            if (installHud())
            {
                //initialize form2, passing this form so the buttons can be reenabled and the install path for documentation
                Form2 installSuccessForm = new Form2(this, installPath);

                //show form2 only if the install succeeded
                installSuccessForm.Show();
                //buttons will be enabled when the success form is closed
            }
            else
            {
                //enable all buttons if the operation failed.
                tableLayoutPanel1.Enabled = true;
            }
        }

        //public custom event called by form2 as it closes
        public void Form1_ReenabledByForm2(object sender, EventArgs e)
        {
            //enable all buttons
            tableLayoutPanel1.Enabled = true;
        }

        //delete and back up whatever hud files are in the destination folder, whether thwartski hud or other
        private void uninstallButton_Click(object sender, EventArgs e)
        {
            //disable all buttons
            tableLayoutPanel1.Enabled = false;

            //attempt to delete the destination files
            if (wipeHudFiles())
            {
                //show the success message (but only if the function returned true)
                MessageBox.Show(uninstallCompleteMessage + teamFortress2Subfolder + installPathTfSubFolder + backupSubFolder);
            } 
            //enable all buttons, even if the function failed.
            tableLayoutPanel1.Enabled = true;
        }

        //save settings on program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
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
                        enableInstall(Convert.ToString(possibleTeamFortress2PathDir));

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
        /// Based on the settings for the two scoreboard comboboxes, determine which files to install.
        /// </summary>
        private void determineScoreboardFiles()
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
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        private void enableInstall(string validInstallLocation)
        {
            //MessageBox.Show(validInstallLocation + " is the location to install");

            //global variable used for actually installing the files
            installPath = validInstallLocation + installPathTfSubFolder;

            //prepare the rest of the the strings for install paths, filenames, etc.
            assembleStrings();

            //update the install path box
            folderBrowserLabel.Text = validInstallLocation;
            folderBrowserLabel.BackColor = Color.White;

            //update the folder browser dialog
            folderBrowserDialog1.SelectedPath = validInstallLocation;
            folderBrowserDialog1.Description = validFolderBrowserDesc;

            //update the install path setting
            Properties.Settings.Default.settingFolderBrowserPath = validInstallLocation;
            //MessageBox.Show("changing path setting: " + Properties.Settings.Default.folderBrowserPath);

            //enable buttons
            installButton.Enabled = true;
            uninstallButton.Enabled = true;
        }

        /// <summary>
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        private void assembleStrings()
        {
            //the paths of the custom asset files
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

            //the path for backup files
            backupPath = installPath + backupSubFolder;

            //MessageBox.Show("installPath: \n" + installPath);
            //MessageBox.Show("aspectSelectedAssetPath: \n" + aspectSelectedAssetPath);
            //MessageBox.Show("scoreboardSelectedAssetPath: \n" + scoreboardSelectedAssetPath);
            //MessageBox.Show("menuSelectedAssetPath: \n" + menuSelectedAssetPath);
            //MessageBox.Show("customInstallPathResource: \n" + customInstallPathResource);
            //MessageBox.Show("customInstallPathUi: \n" + customInstallPathUi);
            //MessageBox.Show("menuFileDestination: \n" + menuFileDestination);
            //MessageBox.Show("aspectFileDestination: \n" + aspectFileDestination);
            //MessageBox.Show("scoreboardFileDestination: \n" + scoreboardFileDestination);
            //MessageBox.Show("backupPath: \n" + backupPath);
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
                MessageBox.Show(exceptionAssetsMissing);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.UnauthorizedAccessException)
            {
                //happens when tf2 is running (and therefore keeping the font files in use).
                MessageBox.Show(exceptionGameRunning);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.IO.IOException)
            {
                //usually happens when the user tries to delete a folder they are viewing.
                MessageBox.Show(exceptionFolderOpen);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                MessageBox.Show(problem.Message);

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
                    MessageBox.Show(exceptionAssetsMissing);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.UnauthorizedAccessException)
                {
                    //happens when tf2 is running (and therefore keeping the font files in use).
                    MessageBox.Show(exceptionGameRunning);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.IO.IOException)
                {
                    //usually happens when the user tries to delete a folder they are viewing.
                    MessageBox.Show(exceptionFolderOpen);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.Exception problem)
                {
                    //generic exception for unexpected case
                    MessageBox.Show(problem.Message);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
            }
            //uninstalling and installing worked with no exceptions; return true
            return true;
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






       
    }
}

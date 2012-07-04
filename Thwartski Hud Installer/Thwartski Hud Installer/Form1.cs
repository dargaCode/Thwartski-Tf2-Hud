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

        //which custom sourcefiles to copy
        static byte[] aspectAssetFile;                  //written at runtime
        static byte[] scoreboardAssetFile;              //written at runtime
        static byte[] menuAssetFile;                    //written at runtime

        //strings for comboboxes
        static string aspectNormalText =                "Normal";
        static string aspectWidescreenText =            "Widescreen";
        static string scoreboardComp6Text =             "Comp 6s";
        static string scoreboardComp9Text =             "Highlander";
        static string scoreboardPub24Text =             "Pub 24";
        static string scoreboardPub32Test =             "Pub 32";

        //paths for populating the folder browser
        static string defaultSteamappsFolder32Bit =     @"C:\Program Files (x86)\Steam\steamapps\";
        static string defaultSteamappsFolder64Bit =     @"C:\Program Files\Steam\steamapps\";
        static string unknownSteamappsFolder =          @"\YOUR_STEAM_FOLDER\steamapps\";
        static string unknownSteamUser =                @"YOUR_USERNAME";
        static string teamFortress2Folder =             @"\team fortress 2";
        static string steamappsFolder;                  //written at runtime
        static string steamUser;                        //written at runtime

        //paths for browsing folders
        static string partialTeamFortress2Location;     //written at runtime
        static string unknownTeamFortress2Location =    unknownSteamappsFolder + unknownSteamUser + teamFortress2Folder;

        //error message for folder browser
        static string badFolderSelectedMessage =        @"Please select " + unknownTeamFortress2Location;

        //error message for exception handling
        //Environment.NewLine for non-escaped linebreaks
        static string exceptionFolderOpen =             "The previous hud installation could not be deleted! \n \nPlease make sure your hud folders are closed.";
        static string exceptionGameRunning =            "The previous hud installation could not be deleted! \n \nPlease make sure TF2 is not running.";
        static string exceptionAssetsMissing =          "The hud source files could not be found! \n \nPlease re-download the installer or replace any deleted files.";

        //descriptions for the folder browser
        static string unknownFolderBrowserDesc =        @"Please select " + unknownTeamFortress2Location;
        static string partialFolderBrowserDesc =        @"Please select your \steamapps\" + unknownSteamUser + teamFortress2Folder + " folder";
        static string validFolderBrowserDesc =          @"Please select your Team Fortress 2 folder.";

        //paths for installing files
        static string assetPathRelative =               @"Install Files\";
        static string installPath;                      //written at runtime
        static string installPathSubFolder =            @"\tf\";

        //used for cycling through assetfolder directory
        static DirectoryInfo assetFolderDir = new DirectoryInfo(assetPathRelative);

        //full destinations for custom install files
        static string installPathResourceSubfolder =    @"resource\";
        static string installPathUiSubfolder =          @"ui\";
        static string aspectFileInstallFilename =       "SpectatorTournament.res";
        static string scoreboardFileInstallFilename =   "ScoreBoard.res";
        static string menuFileInstallFilename =         "GameMenu.res";
        static string customInstallPathResource;        //written at runtime
        static string customInstallPathUi;              //written at runtime
        static string aspectFileDestination;            //written at runtime
        static string scoreboardFileDestination;        //written at runtime
        static string menuFileDestination;              //written at runtime

        //path for saving backups
        static string backupPathSubFolder =             @"_HUD BACKUPS\";
        static string backupPath;                       //written at runtime

        //text for uninstall complete
        static string uninstallCompleteMessage = "All hud files are now reverted to Valve defaults. \n \nBackups of hud files can be found in ";


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
                aspectAssetFile = Properties.Resources.aspectFileNormal;
            }
            //widescreen aspect ratio
            else if (aspectSelector.SelectedIndex == 1)
            {
                //load image resource
                aspectImageBox.Image = Properties.Resources.aspectImageWidescreen;

                //load the matching file into a bit array for later copying
                aspectAssetFile = Properties.Resources.aspectFileWidescreen;
            }
            //something went wrong
            else
            {
                MessageBox.Show("debug: variable index out of range! aspect=" + aspectSelector.SelectedIndex);
            }
            //save settings
            Properties.Settings.Default.settingComboboxAspect = aspectSelector.SelectedIndex;
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
                MessageBox.Show(uninstallCompleteMessage + teamFortress2Folder + installPathSubFolder + backupPathSubFolder);
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
                    DirectoryInfo possibleTeamFortress2PathDir = new DirectoryInfo(steamappsFolder + steamUserFolder + teamFortress2Folder);

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
            partialTeamFortress2Location = steamappsFolder + steamUser + teamFortress2Folder;

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
                scoreboardAssetFile = Properties.Resources.scoreboardFilePub24Comp6;
                menuAssetFile = Properties.Resources.menuFilePub24Comp6;
                //MessageBox.Show("pub24/comp6");
            }
            //pub24 maxmode, comp9 minmode
            else if (maxmodeIndex == 0 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardAssetFile = Properties.Resources.scoreboardFilePub24Comp9;
                menuAssetFile = Properties.Resources.menuFilePub24Comp9;
                //MessageBox.Show("pub24/comp9");
            }
            //pub32 maxmode, comp6 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 0)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardAssetFile = Properties.Resources.scoreboardFilePub32Comp6;
                menuAssetFile = Properties.Resources.menuFilePub32Comp6;
                //MessageBox.Show("pub32/comp6");
            }
            //pub32 maxmode, comp9 minmode
            else if (maxmodeIndex == 1 && minmodeIndex == 1)
            {
                //load the corresponding files into bit arrays for later copying
                scoreboardAssetFile = Properties.Resources.scoreboardFilePub32Comp9;
                menuAssetFile = Properties.Resources.menuFilePub32Comp9;
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

            //REBUILD STRINGS FOR GLOBAL VARIABLES

            //where the install files will be going
            installPath = validInstallLocation + installPathSubFolder;
            //where the custom menu file will be going
            customInstallPathResource = installPath + installPathResourceSubfolder;
            //where the other custom files will be going
            customInstallPathUi = customInstallPathResource + installPathUiSubfolder;
            //where the menu file will be going and what it will be called
            menuFileDestination = customInstallPathResource + menuFileInstallFilename;
            //where the spectator hud file will be going and what it will be called
            aspectFileDestination = customInstallPathUi + aspectFileInstallFilename;
            //where the scoreboard file will be going and what it will be called
            scoreboardFileDestination = customInstallPathUi + scoreboardFileInstallFilename;
            //where the backup files will be going
            backupPath = installPath + backupPathSubFolder;

            //MessageBox.Show("installPath: " + installPath);
            //MessageBox.Show("customInstallPathResource: " + customInstallPathResource);
            //MessageBox.Show("customInstallPathUi: " + customInstallPathUi);
            //MessageBox.Show("menuFileDestination: " + menuFileDestination);
            //MessageBox.Show("aspectFileDestination: " + aspectFileDestination);
            //MessageBox.Show("scoreboardFileDestination: " + scoreboardFileDestination);
            //MessageBox.Show("backupPath: " + backupPath);

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

                    //copy the custom files from the byte array to the custom install file location
                    File.WriteAllBytes(menuFileDestination, menuAssetFile);
                    File.WriteAllBytes(aspectFileDestination, aspectAssetFile);
                    File.WriteAllBytes(scoreboardFileDestination, scoreboardAssetFile);
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

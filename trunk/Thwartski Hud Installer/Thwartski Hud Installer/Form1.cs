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

        //strings for comboboxes
        static string aspectNormalText =                "Normal";
        static string aspectWidescreenText =            "Widescreen";
        static string scoreboardComp6Text =             "Comp 6s";
        static string scoreboardComp9Text =             "Highlander";
        static string scoreboardPub24Text =             "Pub 24";
        static string scoreboardPub32Test =             "Pub 32";

        //names of image files for comboboxes
        static string aspectNormalImage =               "SpectatorTournament_Normal.jpg";
        static string aspectWidescreenImage =           "SpectatorTournament_Widescreen.jpg";
        static string scoreboardComp6Image =            "ScoreBoard_Comp6.jpg";
        static string scoreboardComp9Image =            "ScoreBoard_Comp9.jpg";
        static string scoreboardPub24Image =            "ScoreBoard_Pub24.jpg";
        static string scoreboardPub32Image =            "ScoreBoard_Pub32.jpg";

        //paths for populating the folder browser
        static string defaultSteamappsFolder32Bit =     @"C:\Program Files (x86)\Steam\steamapps\";
        static string defaultSteamappsFolder64Bit =     @"C:\Program Files\Steam\steamapps\";
        static string unknownSteamappsFolder =          @"\YOUR_STEAM_FOLDER\steamapps\";
        static string unknownSteamUser =                @"YOUR_USERNAME";
        static string teamFortress2Folder =             @"\team fortress 2\";
        static string steamappsFolder;                  //written at runtime
        static string steamUser;                        //written at runtime

        //paths for browsing folders
        static string validTeamFortress2Location;       //written at runtime
        static string partialTeamFortress2Location;     //written at runtime

        //error message for folder browser
        static string unknownTeamFortress2Location =    unknownSteamappsFolder + unknownSteamUser + teamFortress2Folder;
        static string badFolderSelectedMessage =        @"Please select " + unknownTeamFortress2Location;

        //descriptions for the folder browser
        static string unknownFolderBrowserDesc =        @"Please select " + unknownTeamFortress2Location;
        static string partialFolderBrowserDesc =        @"Please select your \steamapps\" + unknownSteamUser + teamFortress2Folder + " folder";
        static string validFolderBrowserDesc =          @"Please select your Team Fortress 2 folder.";

        //paths for installing files
        static string assetPath =                       @"e:\Userdata\Desktop\bullshit\tf\";  //eventually needs to be relative from the exe file
        static string customAssetPath =                 assetPath + @"DELETEME RESOURCE\ui\_Thwartski Hud Options\";
        static string installPath;                      //written at runtime
        static string installPathSubFolder =            @"tf\";

        //filenames for copying custom files
        static string aspectNormalFile =                "SpectatorTournament_Normal.res";
        static string aspectWidescreenFile =            "SpectatorTournament_Widescreen.res";
        static string scoreboardComp6File =             "ScoreBoard_Comp6.res";
        static string scoreboardComp9File =             "ScoreBoard_Comp9.res";
        static string scoreboardPub24File =             "ScoreBoard_Pub24.res";
        static string scoreboardPub32File =             "ScoreBoard_Pub32.res";

        //which custom sourcefiles to copy
        static string aspectAssetFile;                  //written at runtime
        static string scoreboardAssetFile;              //written at runtime

        //full destinations for both custom files
        static string installPathCustomSubfolder =      @"DELETEME RESOURCE\ui\";
        static string aspectFileInstallFilename =       "SpectatorTournament.res";
        static string scoreboardFileInstallFilename =   "ScoreBoard.res";
        static string customInstallPath;                //written at runtime
        static string aspectFileDestination;            //written at runtime
        static string scoreboardFileDestination;        //written at runtime

        //path for saving backups
        static string backupPathSubFolder =             @"_HUD BACKUPS\";
        static string backupPath;                       //written at runtime

        //used for cycling through assetfolder directory
        static DirectoryInfo assetFolderDir = new DirectoryInfo(assetPath);


        //FORM EVENTS BELOW THIS POINT


        public Form1()
        {
            InitializeComponent();
        }

        //default functionality as form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //try to guess at a default install directory
            SetDefaultFolder();

            //create arrays of combobox strings
            string[] aspects = { aspectNormalText, aspectWidescreenText };
            string[] scoreboards = { scoreboardComp6Text, scoreboardComp9Text, scoreboardPub24Text, scoreboardPub32Test };

            //populate the comboboxes with the correct options
            aspectSelector.Items.AddRange(aspects);
            scoreboardSelector.Items.AddRange(scoreboards);

            //default values for each combobox and checkbox
            backupCheckbox.Checked = true;
            aspectSelector.SelectedItem = aspectWidescreenText;
            scoreboardSelector.SelectedItem = scoreboardPub24Text;
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
                    validTeamFortress2Location = folderBrowserDialog1.SelectedPath;
                    enableInstall();
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
                createBackupFolders = true;
            }
            else
            {
                createBackupFolders = false;
            }

        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void aspectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(aspectSelector.SelectedItem) == aspectNormalText)
            {
                //normal aspect ratio
                aspectImageBox.Load(customAssetPath + aspectNormalImage);
                aspectAssetFile = customAssetPath + aspectNormalFile;
            }
            else if (Convert.ToString(aspectSelector.SelectedItem) == aspectWidescreenText)
            {
                //widescreen aspect ratio
                aspectImageBox.Load(customAssetPath + aspectWidescreenImage);
                aspectAssetFile = customAssetPath + aspectWidescreenFile;
            }
        }

        //assign the correct image to be copied, depending on the combobox's selection
        private void scoreboardSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardComp6Text)
            {
                //comp6 scoreboard
                scoreboardImage.Load(customAssetPath + scoreboardComp6Image);
                scoreboardAssetFile = customAssetPath + scoreboardComp6File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardComp9Text)
            {
                //comp9 scoreboard
                scoreboardImage.Load(customAssetPath + scoreboardComp9Image);
                scoreboardAssetFile = customAssetPath + scoreboardComp9File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardPub24Text)
            {
                //pub24 scoreboard
                scoreboardImage.Load(customAssetPath + scoreboardPub24Image);
                scoreboardAssetFile = customAssetPath + scoreboardPub24File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardPub32Test)
            {
                //pub32 scoreboard
                scoreboardImage.Load(customAssetPath + scoreboardPub32Image);
                scoreboardAssetFile = customAssetPath + scoreboardPub32File;
            }
        }

        //actually install the hud or update the installation with new custom files
        private void installButton_Click(object sender, EventArgs e)
        {
            //disable all buttons
            tableLayoutPanel1.Enabled = false;

            //Used for iterating through file and folder lists
            DirectoryInfo installFolderDir = new DirectoryInfo(installPath);

            //delete the destination files
            wipeHudFiles();

            //install the new hud files
            copyFilesAndFolders(assetFolderDir, installFolderDir);

            //copy the custom files
            System.IO.File.Copy(aspectAssetFile, aspectFileDestination, true);
            System.IO.File.Copy(scoreboardAssetFile, scoreboardFileDestination, true);

            //enable all buttons
            tableLayoutPanel1.Enabled = true;

            MessageBox.Show("Hud Installed!");
        }

        //delete and back up whatever hud files are in the destination folder, whether thwartski hud or other
        private void uninstallButton_Click(object sender, EventArgs e)
        {
            //disable all buttons
            tableLayoutPanel1.Enabled = false;

            //delete the destination files
            wipeHudFiles();

            //enable all buttons
            tableLayoutPanel1.Enabled = true;

            MessageBox.Show("Hud Files Removed!");
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
                        validTeamFortress2Location = Convert.ToString(possibleTeamFortress2PathDir);
                        enableInstall();

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

            //force the player to browse for a folder immediately on load
            //folderBrowserButton_Click(folderBrowserButton, EventArgs.Empty); 
        }

        /// <summary>
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        private void enableInstall()
        {
            //MessageBox.Show(validTeamFortress2Location + " is the location to install");

            //REBUILD STRINGS FOR GLOBAL VARIABLES
                //where the install files will be going
            installPath = validTeamFortress2Location + installPathSubFolder;
                //where the custom files will be going
            customInstallPath = installPath + installPathCustomSubfolder;
                //what the spectator hud file will go and what it will be called
            aspectFileDestination = customInstallPath + aspectFileInstallFilename;
                //what the scoreboard file will go and what it will be called
            scoreboardFileDestination = customInstallPath + scoreboardFileInstallFilename;
                //where the backup files will be going
            backupPath = installPath + backupPathSubFolder;

            //update the install path box
            folderBrowserLabel.Text = validTeamFortress2Location;
            folderBrowserLabel.BackColor = Color.White;

            //update the folder browser dialog
            folderBrowserDialog1.SelectedPath = validTeamFortress2Location;
            folderBrowserDialog1.Description = validFolderBrowserDesc;

            //enable buttons
            installButton.Enabled = true;
            uninstallButton.Enabled = true;
        }


        /// <summary>
        /// Backup and delete all relevant files from the install directory.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void wipeHudFiles()
        {
            //Iterate through all the folders in the source asset folder and back up all of them before copying.
            DirectoryInfo[] assetSubFolders = assetFolderDir.GetDirectories();
            foreach (DirectoryInfo assetSubFolder in assetSubFolders)
            {
                backupAndDeleteFolder(installPath, assetSubFolder, backupPath, createBackupFolders);
            }
        }

        /// <summary>
        /// Back up the folder with a timestamp, then delete it and all its contents.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void backupAndDeleteFolder(string sourcePath, DirectoryInfo folderName, string backupPath, bool backupDesired)
        {
            string existingCompletePath = String.Format(@"{0}\{1}", sourcePath, folderName);
            string backupCompletePath = String.Format(@"{0}\Date-{1:yyyy-MM-dd_}Time.{2:HH.mm.ss}\{3}", backupPath, DateTime.Now, DateTime.Now, folderName);

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



       
    }
}

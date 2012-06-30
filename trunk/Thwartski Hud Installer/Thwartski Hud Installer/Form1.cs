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
        //boolean for backup checkbox
        static Boolean createBackupFolders = false;

        //Strings for comboboxes
        static string aspectNormalText = "Normal";
        static string aspectWidescreenText = "Widescreen";
        static string scoreboardComp6Text = "Comp 6s";
        static string scoreboardComp9Text = "Highlander";
        static string scoreboardPub24Text = "Pub 24";
        static string scoreboardPub32Test = "Pub 32";

        //names of image files for comboboxes
        static string aspectNormalImage = "SpectatorTournament_Normal.jpg";
        static string aspectWidescreenImage = "SpectatorTournament_Widescreen.jpg";
        static string scoreboardComp6Image = "ScoreBoard_Comp6.jpg";
        static string scoreboardComp9Image = "ScoreBoard_Comp9.jpg";
        static string scoreboardPub24Image = "ScoreBoard_Pub24.jpg";
        static string scoreboardPub32Image = "ScoreBoard_Pub32.jpg";

        //paths for installing files
        static string assetPath = @"e:\Userdata\Desktop\bullshit";
        static string installPath = @"C:\Program Files (x86)\Steam\steamapps\mdarga\team fortress 2\tf";
        static string backupPath = installPath + @"\_HUD BACKUPS";

        static DirectoryInfo assetFolder = new DirectoryInfo(assetPath);
        static DirectoryInfo installFolder = new DirectoryInfo(installPath);

        //paths for copying custom files
        static string aspectFile = "";
        static string scoreboardFile = "";

        static string customAssetPath = assetPath + @"\DELETEME I WILL NOT BE BACKED UP\";
        static string customInstallPath = installPath + @"\CUSTOM\";

        static string aspectFileDestination =customInstallPath + "Spectator_Tournament.res";
        static string scoreboardFileDestination = customInstallPath + "ScoreBoard.res";

        //names for copying custom files
        static string aspectNormalFile = "SpectatorTournament_Normal.res";
        static string aspectWidescreenFile = "SpectatorTournament_Widescreen.res";
        static string scoreboardComp6File = "ScoreBoard_Comp6.res";
        static string scoreboardComp9File = "ScoreBoard_Comp9.res";
        static string scoreboardPub24File = "ScoreBoard_Pub24.res";
        static string scoreboardPub32File = "ScoreBoard_Pub32.res";


        public Form1()
        {
            InitializeComponent();

            //try to guess at an install directory
            SetDefaultFolder();

            //arrays of combobox strings
            string[] aspects = {aspectNormalText, aspectWidescreenText};
            string[] scoreboards = {scoreboardComp6Text, scoreboardComp9Text, scoreboardPub24Text, scoreboardPub32Test};

            //populate the comboboxes with the correct options
            aspectSelector.Items.AddRange(aspects);
            scoreboardSelector.Items.AddRange(scoreboards);

            //default values for options
            backupCheckbox.Checked = true;
            aspectSelector.SelectedItem = aspectWidescreenText;
            scoreboardSelector.SelectedItem = scoreboardPub24Text;

        }

        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        private void SetDefaultFolder()
        {

            //clean these up a bit into variables so it's not so redundant

            string DefaultFolder32Bit = @"C:\Program Files (x86)\Steam\steamapps";
            string DefaultFolder64Bit = @"C:\Program Files\Steam\steamapps";

            if (Directory.Exists(DefaultFolder32Bit))
            {
                folderBrowserDialog1.SelectedPath = DefaultFolder32Bit;
                folderBrowserTextBox.Text = DefaultFolder32Bit + @"\YOUR_USERNAME\Team Fortress 2\";
            }
            else if (Directory.Exists(DefaultFolder64Bit))
	        {
                folderBrowserDialog1.SelectedPath = DefaultFolder64Bit;
                folderBrowserTextBox.Text = DefaultFolder64Bit + @"\YOUR_USERNAME\Team Fortress 2\";
	        }
            else
            {
                folderBrowserTextBox.Text = @"YOUR_STEAM_FOLDER\Steamapps\YOUR_USERNAME\Team Fortress 2\";
            }

        }


        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, record their
            // Folder location.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (folderBrowserDialog1.SelectedPath.EndsWith("team fortress 2"))
                {
                    folderBrowserTextBox.Text = folderBrowserDialog1.SelectedPath;
                    folderBrowserTextBox.BackColor = Color.White;
                }

                else
                {
                    MessageBox.Show(@"Please select \YOUR_STEAM_FOLDER\Steamapps\YOUR_USERNAME\Team Fortress 2\");
                }

            }
        }

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

        //assign the right image to be copied, depending on the combobox's selection
        private void aspectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(aspectSelector.SelectedItem) == aspectNormalText)
            {
                aspectImageBox.Load(customAssetPath + aspectNormalImage);

                aspectFile = customAssetPath + aspectNormalFile;
            }
            else if (Convert.ToString(aspectSelector.SelectedItem) == aspectWidescreenText)
            {
                aspectImageBox.Load(customAssetPath + aspectWidescreenImage);

                aspectFile = customAssetPath + aspectWidescreenFile;
            }
        }

        //assign the right image to be copied, depending on the combobox's selection
        private void scoreboardSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardComp6Text)
            {
                scoreboardImage.Load(customAssetPath + scoreboardComp6Image);

                scoreboardFile = customAssetPath + scoreboardComp6File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardComp9Text)
            {
                scoreboardImage.Load(customAssetPath + scoreboardComp9Image);

                scoreboardFile = customAssetPath + scoreboardComp9File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardPub24Text)
            {
                scoreboardImage.Load(customAssetPath + scoreboardPub24Image);

                scoreboardFile = customAssetPath + scoreboardPub24File;
            }
            else if (Convert.ToString(scoreboardSelector.SelectedItem) == scoreboardPub32Test)
            {
                scoreboardImage.Load(customAssetPath + scoreboardPub32Image);

                scoreboardFile = customAssetPath + scoreboardPub32File;
            }
        }


        private void installButton_Click(object sender, EventArgs e)
        {
            //delete the destination files
            wipeHudFiles();

            //install the new hud files
            copyFilesAndFolders(assetFolder, installFolder);

            //copy the custom files
            System.IO.File.Copy(aspectFile, aspectFileDestination, true);
            System.IO.File.Copy(scoreboardFile, scoreboardFileDestination, true);

            MessageBox.Show("Hud Installed!");
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            //delete the destination files
            wipeHudFiles();

            MessageBox.Show("Hud Files Removed!");
        }

        /// <summary>
        /// Backup and delete all relevant files from the install directory.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void wipeHudFiles()
        {
            //Iterate through all the folders in the source asset folder and back up all of them before copying.
            DirectoryInfo[] assetSubFolders = assetFolder.GetDirectories();
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

            DirectoryInfo existingFolder = new DirectoryInfo(existingCompletePath);
            DirectoryInfo backupFolder = new DirectoryInfo(backupCompletePath);

            if (existingFolder.Exists)
            {
                //If the player hasn't deleted it, and they checked the option, back the folder up.
                if (backupDesired)
                {
                    copyFilesAndFolders(existingFolder, backupFolder);
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

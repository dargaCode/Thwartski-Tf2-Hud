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
        public Form1()
        {
            InitializeComponent();
            SetDefaultFolder();

        }

        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        private void SetDefaultFolder()
        {

            //clean these up a bit into variables so it's not so redundant?

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

        private void installButton_Click(object sender, EventArgs e)
        {
            string assetPath = @"e:\Userdata\Desktop\bullshit";
            string installPath = @"C:\Program Files (x86)\Steam\steamapps\mdarga\team fortress 2\tf";

            string backupPath = installPath + @"\_HUD BACKUPS";

            DirectoryInfo assetFolder = new DirectoryInfo(assetPath);
            DirectoryInfo installFolder = new DirectoryInfo(installPath);

            //Iterate through all the folders in the source asset folder and back up all of them before copying.
            DirectoryInfo[] assetSubFolders = assetFolder.GetDirectories();
            foreach (DirectoryInfo assetSubFolder in assetSubFolders)
            {
                backupAndDeleteFolder(assetSubFolder, installPath, backupPath);
            }


            CopyFilesAndFolders(assetFolder, installFolder);

            MessageBox.Show("Done!");

        }


        /// <summary>
        /// Back up the folder with a timestamp, then delete it and all its contents.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void backupAndDeleteFolder(DirectoryInfo folderName, string sourcePath, string backupPath)
        {

            string existingCompletePath = String.Format(@"{0}\{1}", sourcePath, folderName);
            string backupCompletePath = String.Format(@"{0}\Date-{1:yyyy-MM-dd_}Time.{2:HH.mm.ss}\{3}", backupPath, DateTime.Now, DateTime.Now, folderName);

            DirectoryInfo existingFolder = new DirectoryInfo(existingCompletePath);
            DirectoryInfo backupFolder = new DirectoryInfo(backupCompletePath);

            if (existingFolder.Exists)
            {
                //If the player hasn't deleted it, back the folder up.
                CopyFilesAndFolders(existingFolder, backupFolder);

                Directory.Delete(existingCompletePath, true);

            }
        }
      

        /// <summary>
        /// Copy all files and folders to a new location, overwriting all files.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void CopyFilesAndFolders(DirectoryInfo sourceFolder, DirectoryInfo destinationFolder)
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
                CopyFilesAndFolders(sourceSubFolder, new DirectoryInfo(destinationSubFolder));
            }
        } 


    }
}

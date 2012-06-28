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
        /// Take a guess where the right folder is, and set it as the default location if it exists.
        /// </summary>
        private void SetDefaultFolder()
        {
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
            string installPath = @"C:\Program Files (x86)\Steam\steamapps\mdarga\team fortress 2\tf\DELETEME FAKE RESOURCE";

            DirectoryInfo assetFolder = new DirectoryInfo(assetPath);
            DirectoryInfo installFolder = new DirectoryInfo(installPath);

            backupFolder(installPath);

            CopyFilesAndFolders(assetFolder, installFolder);

            MessageBox.Show("Done!");

        }


        /// <summary>
        /// Back up the folder with a timestamp.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        static void backupFolder(string sourcePath)
        {
            string backupPath = String.Format("{0}_Backup_Date-{1:yyyy-MM-dd_}Time.{2:HH.mm.ss}", sourcePath, DateTime.Now, DateTime.Now);

            DirectoryInfo existingFolder = new DirectoryInfo(sourcePath);

            DirectoryInfo backupFolder = new DirectoryInfo(backupPath);

            if (existingFolder.Exists)
            {
                //If the player hasn't deleted it, back the folder up.
                CopyFilesAndFolders(existingFolder, backupFolder);
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

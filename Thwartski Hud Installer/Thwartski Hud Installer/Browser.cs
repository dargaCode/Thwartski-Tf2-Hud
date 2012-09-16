using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Thwartski_Hud_Installer
{
    class Browser
    {

        //classes to store the value being passed in
        private Form1 mainForm = null;
        private Location installLocation = null;

        //constructor?
        public Browser(Form1 f, Location install)
        {
            //store the calling form
            mainForm = f;

            //store the install location
            installLocation = install;
        }



        /// <summary>
        /// Fill the browser with a best guess default string or a saved string, if one exists.
        /// </summary>
        /// <returns></returns>
        public void populateDefaultPath()
        {
            //decide whether to use the saved install path setting or to start generating one
            string savedBrowserPath = Properties.Settings.Default.settingFolderBrowserPath;
            if (Directory.Exists(savedBrowserPath) && savedBrowserPath.EndsWith(Properties.Resources.stringFolderTeamFortress2))
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


        /// <summary>
        /// Browse, then make sure user has selected a valid folder.
        /// </summary>
        public void BrowseForInstallFolder()
        {
            // Show the Open File dialog. If the user clicks OK, record their Folder location.
            if (mainForm.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //the player selected a valid folder
                if (mainForm.folderBrowserDialog1.SelectedPath.EndsWith(Properties.Resources.stringFolderTeamFortress2))
                {
                    setInstallLocation(mainForm.folderBrowserDialog1.SelectedPath);
                }
                //the player didn't select a valid folder
                else
                {
                    mainForm.errorWindow(GlobalStrings.MessageBadFolderSelected);
                }
            }
        }



        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        public void SetDefaultFolder()
        {
            if (Directory.Exists(Properties.Resources.stringFolderSteamapps32Bit))
            {
                //a steam folder was fond
                GlobalStrings.FolderSteamapps = Properties.Resources.stringFolderSteamapps32Bit;

                //try to guess your username
                guessSteamUser(GlobalStrings.FolderSteamapps);
            }
            else if (Directory.Exists(Properties.Resources.stringFolderSteamapps64Bit))
            {
                //a steam folder was found
                GlobalStrings.FolderSteamapps = Properties.Resources.stringFolderSteamapps64Bit;

                //try to guess your username
                guessSteamUser(Properties.Resources.stringFolderSteamapps64Bit);
            }
            else
            {
                //no obvious steam install was found
                mainForm.folderBrowserBoxLabel.Text = GlobalStrings.PathUnknownTeamFortress2;
                mainForm.folderBrowserDialog1.Description = GlobalStrings.FolderBrowserDescUnknown;
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
                    DirectoryInfo possibleTeamFortress2PathDir = new DirectoryInfo(steamappsFolder + steamUserFolder + Properties.Resources.stringFolderTeamFortress2);

                    //the possible user contains the right folders
                    if (possibleTeamFortress2PathDir.Exists)
                    {
                        //MessageBox.Show(defaultFolder + steamUser + teamFortress2Folder);

                        //the username is legit
                        GlobalStrings.FolderSteamUser = Convert.ToString(steamUserFolder);
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
            GlobalStrings.FolderSteamUser = Properties.Resources.stringFolderSteamUserUnknown;
            GlobalStrings.PathPartialTeamFortress2 = steamappsFolder + GlobalStrings.FolderSteamUser + Properties.Resources.stringFolderTeamFortress2;

            //update the textbox and folder browser with the partial path to get the player started.
            mainForm.folderBrowserDialog1.SelectedPath = steamappsFolder;
            mainForm.folderBrowserBoxLabel.Text = GlobalStrings.PathPartialTeamFortress2;

            //change the text in the folder browser dialog
            mainForm.folderBrowserDialog1.Description = GlobalStrings.FolderBrowserDescPartial;
        }


        /// <summary>
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        public void setInstallLocation(string validInstallLocation)
        {
            //MessageBox.Show(validInstallLocation + " is the location to install");

            //global variable used for actually installing the files
            installLocation.PathFolderHudLocation = validInstallLocation + Properties.Resources.stringFolderTf;

            //prepare the rest of the the strings for install paths, filenames, etc.
            mainForm.updateStrings();

            //update the install path box
            mainForm.folderBrowserBoxLabel.Text = validInstallLocation;
            mainForm.folderBrowserBoxLabel.BackColor = Color.White;

            //update the folder browser dialog
            mainForm.folderBrowserDialog1.SelectedPath = validInstallLocation;
            mainForm.folderBrowserDialog1.Description = GlobalStrings.FolderBrowserDescValid;

            //update the install path setting
            Properties.Settings.Default.settingFolderBrowserPath = validInstallLocation;
            //MessageBox.Show("changing path setting: " + Properties.Settings.Default.folderBrowserPath);

            //check whether the install and uninstall buttons should be enabled
            mainForm.updateButtons();
        }




    } //namespace
} //class

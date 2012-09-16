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
        private Installer installer = null;

        //reference to which combox and imagebox they are linked to
        private FolderBrowserDialog myFolderBrowser = null;
        private Label myPathLabel = null;
        private Label myInstructLabel = null;
        private string savedSetting = null;

        //new Browser(this, installer, installLocation, InstallBrowserDialog, InstallBrowserPathLabel, InstallBrowserInstructLabel, Properties.Settings.Default.settingInstallBrowserPath

        //constructor?
        public Browser(Installer i, FolderBrowserDialog b, Label path, Label instruct, string setting)
        {
            //store the installer
            installer = i;

            //assign the hud objects
            myFolderBrowser = b;
            myPathLabel = path;
            myInstructLabel = instruct;

            //assign the default setting
            savedSetting = setting;

        }



        /// <summary>
        /// Fill the browser with a best guess default string or a saved string, if one exists.
        /// </summary>
        /// <returns></returns>
        public void Setup()
        {
            //decide whether to use the saved install path setting or to start generating one
            string savedBrowserPath = Properties.Settings.Default.settingInstallBrowserPath;
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
            if (myFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                //the player selected a valid folder
                if (myFolderBrowser.SelectedPath.EndsWith(Properties.Resources.stringFolderTeamFortress2))
                {
                    setInstallLocation(myFolderBrowser.SelectedPath);
                }
                //the player didn't select a valid folder
                else
                {
                    GlobalStrings.errorWindow(GlobalStrings.MessageBadFolderSelected);
                }
            }
        }



        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        public void SetDefaultFolder()
        {
            string folderSteamapps;

            if (Directory.Exists(Properties.Resources.stringFolderSteamapps32Bit))
            {
                //a steam folder was fond
                folderSteamapps = Properties.Resources.stringFolderSteamapps32Bit;

                //try to guess your username
                guessSteamUser(folderSteamapps);
            }
            else if (Directory.Exists(Properties.Resources.stringFolderSteamapps64Bit))
            {
                //a steam folder was found
                folderSteamapps = Properties.Resources.stringFolderSteamapps64Bit;

                //try to guess your username
                guessSteamUser(folderSteamapps);
            }
            else
            {
                //no obvious steam install was found
                myPathLabel.Text = GlobalStrings.PathUnknownTeamFortress2;
                myFolderBrowser.Description = GlobalStrings.FolderBrowserDescUnknown;
            }
        }

        /// <summary>
        /// Find a likely folder for the player's steam username.
        /// </summary>
        private void guessSteamUser(string folderSteamapps)
        {
            //used for building the install path
            string steamUser = null;
            string partialKnownPath = null;

            //create an array of the possible steam user folders
            DirectoryInfo possibleSteamUserFoldersDir = new DirectoryInfo(folderSteamapps);
            DirectoryInfo[] steamUserFolders = possibleSteamUserFoldersDir.GetDirectories();

            //cycle through the steamapps folders in the default location, and eliminate obvious mismatches
            foreach (DirectoryInfo steamUserFolder in steamUserFolders)
            {
                //MessageBox.Show(Convert.ToString(steamUserFolder));

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
                    DirectoryInfo possibleTeamFortress2PathDir = new DirectoryInfo(folderSteamapps + steamUserFolder + Properties.Resources.stringFolderTeamFortress2);

                    //the possible user contains the right folders
                    if (possibleTeamFortress2PathDir.Exists)
                    {
                        //MessageBox.Show(defaultFolder + steamUserFolder + teamFortress2Folder);

                        //the username is legit
                        steamUser = Convert.ToString(steamUserFolder);
                        //MessageBox.Show(steamUserFolder + " is the userfolder");

                        //allow install at this location
                        setInstallLocation(Convert.ToString(possibleTeamFortress2PathDir));

                        //stop cycling through steam users
                        return;

                    }
                    //this user seemed legitimate, but didn't contain the right subfolder. keep looking
                    else
                    {
                        //MessageBox.Show(defaultFolder + steamUserFolder + teamFortress2Folder + "doesn't exist");
                    }
                }
            }
            //failed to find a steam user with tf2 obviously installed
            //MessageBox.Show("no users were found with " + teamFortress2Folder);

            //build the partial path
            steamUser = Properties.Resources.stringFolderSteamUserUnknown;
            partialKnownPath = folderSteamapps + steamUser + Properties.Resources.stringFolderTeamFortress2;

            //update the textbox and folder browser with the partial path to get the player started.
            myFolderBrowser.SelectedPath = folderSteamapps;
            myPathLabel.Text = partialKnownPath;  //TODO don't modify these objects directly, pass them in

            //change the text in the folder browser dialog
            myFolderBrowser.Description = GlobalStrings.FolderBrowserDescPartial;
        }


        /// <summary>
        /// Once a valid location has been identified, allow the user to install.
        /// </summary>
        public void setInstallLocation(string validFolder) //TODO hook up or delete
        {
            //MessageBox.Show(validFolder + " is the location to install");


            //update the install path box
            myPathLabel.Text = validFolder;
            myPathLabel.BackColor = Color.White;

            //update the folder browser dialog
            myFolderBrowser.SelectedPath = validFolder;
            myFolderBrowser.Description = GlobalStrings.FolderBrowserDescValid;

            //update the install path setting
            Properties.Settings.Default.settingInstallBrowserPath = validFolder;
            //MessageBox.Show("changing path setting: " + Properties.Settings.Default.folderBrowserPath);


            //let the installer know that a valid location has been found
            installer.ValidLocation = validFolder;

        }




    } //namespace
} //class

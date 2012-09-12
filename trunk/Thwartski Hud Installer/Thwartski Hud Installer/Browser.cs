﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Thwartski_Hud_Installer
{
    class Browser
    {

        //form to store the value being passed in
        private Form1 mainForm = null;

        //constructor?
        public Browser(Form1 caller)
        {
            //store the calling form
            mainForm = caller;
        }





        /// <summary>
        /// Take a guess where the right folder is, and set it as the default browser location if it exists.
        /// </summary>
        public void SetDefaultFolder()
        {
            if (Directory.Exists(Properties.Resources.stringFolderDefaultSteamapps32Bit))
            {
                //a steam folder was fond
                GlobalStrings.FolderSteamapps = Properties.Resources.stringFolderDefaultSteamapps32Bit;

                //try to guess your username
                guessSteamUser(GlobalStrings.FolderSteamapps);
            }
            else if (Directory.Exists(Properties.Resources.stringFolderDefaultSteamapps64Bit))
            {
                //a steam folder was found
                GlobalStrings.FolderSteamapps = Properties.Resources.stringFolderDefaultSteamapps64Bit;

                //try to guess your username
                guessSteamUser(Properties.Resources.stringFolderDefaultSteamapps64Bit);
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
                        mainForm.setInstallLocation(Convert.ToString(possibleTeamFortress2PathDir));

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



    }
}

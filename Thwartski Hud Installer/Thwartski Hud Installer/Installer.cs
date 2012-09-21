using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Thwartski_Hud_Installer
{
    class Installer
    {
        //classes to store the value being passed in
        private Buttons buttons = null;
        private Location assetLocation = null;
        private Location installLocation = null;

        //commonly used strings for copying etc
        string resource = Properties.Resources.stringFolderResource;
        string ui = Properties.Resources.stringFolderUi;
        string options = Properties.Resources.stringFolderOptions;

        //verified install location from the browser
        private string _validLocation = null;

            //getters and setters
            public string ValidLocation { get { return _validLocation; } set { _validLocation = value; Enable(value); } } //also performs Enable


        //constructor?
        public Installer(Buttons b, Location asset, Location install)
        {
            //assign the buttons object
            buttons = b;
            
            //assign the hud objects
            assetLocation = asset;
            installLocation = install;
        }


        /// <summary>
        /// Attempt to install the hud.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destinationFolder"></param>
        public bool performInstallation()
        {
            //used for cycling through assetfolder directory
            DirectoryInfo assetFolderDir = new DirectoryInfo(assetLocation.PathFolderHudLocation); //TODO figure out where this should actually be

            //Used for iterating through file and folder lists
            DirectoryInfo installFolderDir = new DirectoryInfo(installLocation.PathFolderHudLocation);

            //delete the files that are automatically created on game launch
            deleteForcedValveFiles();

            //attempt to delete the destination files (and save backups)
            if (!wipeHudFiles(true))
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
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    //happens when the gameassets folder has been deleted or moved away from the exe
                    GlobalStrings.errorWindow(GlobalStrings.ExceptionAssetsMissing);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.UnauthorizedAccessException)
                {
                    //happens when tf2 is running (and therefore keeping the font files in use).
                    GlobalStrings.errorWindow(GlobalStrings.ExceptionGameRunning);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                catch (System.IO.IOException)
                {
                    //usually happens when the user tries to delete a folder they are viewing.
                    GlobalStrings.errorWindow(GlobalStrings.ExceptionFolderOpen);

                    //stop the function, send false back to stop the rest of the button functionality.
                    return false;
                }
                //generic exception catch
                catch (System.Exception problem)
                {
                    //generic exception for unexpected case
                    GlobalStrings.errorWindow(problem.Message);

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
        public bool wipeHudFiles(bool saveBackups)
        {
            //string for where to put the backups
            string backupPath = installLocation.PathFolderHudLocation + Properties.Resources.stringFolderBackup;

            //Establish backup time once so different folders can't straddle multiple seconds. (this actually has been happening)
            string timestampFolderName = String.Format(@"\Date-{0:yyyy-MM-dd_}Time.{1:HH.mm.ss}\", DateTime.Now, DateTime.Now);
            //MessageBox.Show(timestampFolderName);

            //exception handling for file deletion
            try
            {
                //used for cycling through assetfolder directory
                DirectoryInfo assetFolderDir = new DirectoryInfo(assetLocation.PathFolderHudLocation); //TODO figure out where this should actually be

                //Iterate through all the folders in the source asset folder and back up all of them before copying.
                DirectoryInfo[] assetSubFolders = assetFolderDir.GetDirectories();
                foreach (DirectoryInfo assetSubFolder in assetSubFolders)
                {
                    backupAndDeleteFolder(installLocation.PathFolderHudLocation, assetSubFolder, backupPath, saveBackups, timestampFolderName);
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                //happens when the gameassets folder has been deleted or moved away from the exe
                GlobalStrings.errorWindow(GlobalStrings.ExceptionAssetsMissing);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.UnauthorizedAccessException)
            {
                //happens when tf2 is running (and therefore keeping the font files in use).
                GlobalStrings.errorWindow(GlobalStrings.ExceptionGameRunning);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.IO.IOException)
            {
                //usually happens when the user tries to delete a folder they are viewing.
                GlobalStrings.errorWindow(GlobalStrings.ExceptionFolderOpen);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                GlobalStrings.errorWindow(problem.Message);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            //if everything worked with no exceptions, return true
            return true;
        }

        /// <summary>
        /// Delete the valve files which are created on game launch, so they don't trigger a pointless backup.
        /// </summary>
        private void deleteForcedValveFiles()
        {
            //shorter local string name for readability
            string resourcePath = installLocation.PathFolderHudLocation + resource;

            //one large try for everything since this fail isn't important
            try
            {
                //go through the list of valve fonts/icons and delete them if they exist
                foreach (string forcedValveFile in GlobalStrings.ForcedValveFiles)
                {
                    if (File.Exists(resourcePath + forcedValveFile))
                    {
                        File.Delete(resourcePath + forcedValveFile);
                        //MessageBox.Show("deleting " + ValveFile);
                    }
                }
                //if resources exists but is empty, delete it so it won't generate a useless backup for one empty folder
                if (Directory.Exists(resourcePath))
                {
                    //MessageBox.Show(String.Format(@"{0} has {1} files and {2} folders after cleanup", Resource, Convert.ToString(Directory.GetFiles(Resource).Length), Convert.ToString(Directory.GetDirectories(Resource).Length)));

                    if (Directory.GetDirectories(resourcePath).Length == 0 && Directory.GetFiles(resourcePath).Length == 0)
                    {
                        Directory.Delete(resourcePath);
                    }
                }
            }
            catch (Exception)
            {
                //swallowing this exception
                //if this method fails to do its job, an unnecessary backup may be created, but that's it
                //it's not worth warning the user about
            }
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
                //If the player hasn't deleted it, and a request for backups has been passed in, back the folder up.
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
            //where to install from
            string customAssetPath = assetLocation.PathFolderHudLocation + resource + ui + Properties.Resources.stringFolderOptions;
            
            //where to install to
            string customInstallPathResource = installLocation.PathFolderHudLocation + resource; //for the menu file
            string customInstallPathResourceUi = installLocation.PathFolderHudLocation + resource + ui; //for aspect and scoreboard


            //exception handling for installing the hud
            try
            {
                //copy the custom files from their asset location to their install location
                System.IO.File.Copy(customAssetPath + assetLocation.FilenameHudMenu, customInstallPathResource + Properties.Resources.stringFilenameInstallMenu, true);
                System.IO.File.Copy(customAssetPath + assetLocation.FilenameHudAspect, customInstallPathResourceUi + Properties.Resources.stringFilenameInstallAspect, true);
                System.IO.File.Copy(customAssetPath + assetLocation.FilenameHudScoreboard, customInstallPathResourceUi + Properties.Resources.stringFilenameInstallScoreboard, true);

            }
            catch (System.IO.DirectoryNotFoundException)
            {
                //happens when the gameassets folder has been deleted or moved away from the exe
                GlobalStrings.errorWindow(GlobalStrings.ExceptionAssetsMissing);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.UnauthorizedAccessException)
            {
                //happens when tf2 is running (and therefore keeping the font files in use).
                GlobalStrings.errorWindow(GlobalStrings.ExceptionGameRunning);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.IO.IOException)
            {
                //usually happens when the user tries to delete a folder they are viewing.
                GlobalStrings.errorWindow(GlobalStrings.ExceptionFolderOpen);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                GlobalStrings.errorWindow(problem.Message);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }

            //installing the custom files worked with no exceptions; return true
            return true;
        }


        /// <summary>
        /// launch the game and close the installer
        /// </summary>
        /// <returns></returns>
        public bool launchGame()
        {
            try
            {
                //launch tf2
                System.Diagnostics.Process.Start(Properties.Resources.stringTeamFortressLaunchCommand);
            }
            //not sure what can go wrong here
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                GlobalStrings.errorWindow(problem.Message);

                //return false so the app doesn't close
                return false;
            }
            //if the game is launching properly, allow the app to close
            return true;
        }


        /// <summary>
        /// Enable the hud to be installed
        /// </summary>
        /// <param name="validFolder"></param>
        private void Enable(string validFolder)
        {
            //tell the install location where the proper /tf location will be
            installLocation.PathFolderHudLocation = validFolder + Properties.Resources.stringFolderTf;
        }


        /// <summary>
        /// check the hud version and return if it's installed or not
        /// </summary>
        /// <returns></returns>
        public bool hudInstalled()
        {
            Version notInstalled = new Version("0.0.0");

            //hud is not installed
            if (installLocation.VersionHud.Equals(notInstalled))
            {
                MessageBox.Show("hud not installed");
                return false;
            }
            //hud is installed
            else if (installLocation.VersionHud.CompareTo(notInstalled) < 0)
            {
                MessageBox.Show("hud is installed");
                return true;
            }
            //something is wrong with the installation, ignore it
            else
            {
                return false;
            }

        }



    } //namespace
} //class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System.Windows.Forms; 


namespace Thwartski_Hud_Installer
{
    class Downloader
    {
        //TODO make this actually dynamic from the webserver
        Version serverVersion = new Version("2.0.4");





        //form to store the value being passed in
        private Form1 mainForm = null;

        //constructor?
        public Downloader(Form1 caller)
        {
            //store the calling form
            mainForm = caller;
        } 



        /// <summary>
        /// If necessary, download and unzip new assets. Return true if install should be updated.
        /// </summary>
        public bool checkAndUpdate(HudFiles assetHud, HudFiles installHud) 
        {

            //need to update assets?
            if (updateRequired(assetHud.VersionHud, serverVersion))
            {

                MessageBox.Show("Downloading new assets!");

                //assets successfully updated
                if (updateAssets())
                {
                    //don't return true, because the assets you just downloaded might not actually be newer than the install (if the player deleted them)
                }
                //something went wrong
                else
                { 
                    //don't install updates if they might be bad somehow
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No need to update assets.");
            }

            //need to update install?
            if (updateRequired(installHud.VersionHud, assetHud.VersionHud))
            {
                MessageBox.Show("Install new assets!");

                //new assets need to be installed
                return true;
            }
            else
            {
                MessageBox.Show("No need to install new assets.");

                //new assets don't need to be installed
                return false;
            }
        
        }


        /// <summary>
        /// Compare an active version with a latest version, return true if update required.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="latest"></param>
        /// <returns></returns>
        private bool updateRequired(Version active, Version latest)
        {
            //active older than latest
            if ((active.CompareTo(latest)) < 0)
            {
                //MessageBox.Show("Version comparison: " + Convert.ToString((active.CompareTo(latest))) + "\n \nVersion out of date.");
                
                //update required
                return true;
            }
            //active equal to latest
            else if ((active.CompareTo(latest)) == 0)
            {
                //MessageBox.Show("Version comparison: " + Convert.ToString((active.CompareTo(latest))) + "\n \nVersion up to date.");
                
                //no need to update
                return false;
            }
            //active newer than latest!?
            else
            {
                //errorWindow("Version comparison: " + Convert.ToString((active.CompareTo(latest))) + "\n \nERROR! Active version newer than newest version!");
                
                //if something's broken, better update to correct it
                return true;
            }
        }


        /// <summary>
        /// Download the hud assets, return true if it worked.
        /// </summary>
        /// <returns></returns>
        private bool updateAssets()
        {

            //used for cycling through assetfolder directory
            DirectoryInfo assetFolderDir = new DirectoryInfo(GlobalStrings.AssetPath);

            //try to download and unzip
            try
            {
                //create a place to place the assets
                if (!assetFolderDir.Exists)
                {
                    assetFolderDir.Create();
                }

                //download the most recent file
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://thwartski-tf2-hud.googlecode.com/files/Thwartski_Hud_v2.0.1_test.zip", GlobalStrings.ZipFileLocation); //TODO needs to eventually be dynamic
                }

                //unzip the files to wherever the exe is
                unZip(GlobalStrings.ZipFileLocation, GlobalStrings.ExeFolder);

                //remove the zip file when done
                if (File.Exists(GlobalStrings.ZipFileLocation))
                {
                    File.Delete(GlobalStrings.ZipFileLocation);
                }
            }
            //something went wrong with creating the folder, unzipping, or cleaning up
            catch (System.Exception problem)
            {
                //generic exception for unexpected case
                mainForm.errorWindow(problem.Message);

                //stop the function, send false back to stop the rest of the button functionality.
                return false;
            }

            //everything worked
            return true;
        }

        /// <summary>
        /// Unzip function taken from sharpziplib
        /// </summary>
        /// <param name="sourceZipFile"></param>
        /// <param name="DestinationFolder"></param>
        private void unZip(string sourceZipFile, string DestinationFolder)
        {
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(sourceZipFile)))
            {

                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);

                    // create directory
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(DestinationFolder + directoryName);
                    }

                    if (fileName != String.Empty)
                    {
                        using (FileStream streamWriter = File.Create(DestinationFolder + theEntry.Name))
                        {

                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }






    }
}

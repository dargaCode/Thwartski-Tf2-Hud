using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Thwartski_Hud_Installer
{
    class Location
    {
        //constructor?
        public Location()
        {

        } 

        //should contain: 

        private string _pathFolderHudLocation;
        private string _filenameHudAspect;
        private string _filenameHudScoreboard;
        private string _filenameHudMenu;
        private Version _versionHud = new Version("0.0.0");

            //getters and setters
            public string PathFolderHudLocation { get { return _pathFolderHudLocation; } set { _pathFolderHudLocation = value; } }
            public string FilenameHudAspect { get { return _filenameHudAspect; } set { _filenameHudAspect = value; } }
            public string FilenameHudScoreboard { get { return _filenameHudScoreboard; } set { _filenameHudScoreboard = value; } }
            public string FilenameHudMenu { get { return _filenameHudMenu; } set { _filenameHudMenu = value; } }
            public Version VersionHud { get { return getVersion(); } } //run getversion on getter method instead of the variable directly; //TODO make read only


        /// <summary>
        /// check if the hud is installed and return the version
        /// </summary>
        /// <returns></returns>
        private Version getVersion()
        {
            string versionFile = this.PathFolderHudLocation + Properties.Resources.stringFolderResource + Properties.Resources.stringFilenameInstallVersion;

            //check for the version file in the resource folder
            if (System.IO.File.Exists(versionFile))
            {
                //read and save the version 
                StreamReader reader = new StreamReader(versionFile);

                _versionHud = new Version(reader.ReadLine());  //TODO needs exception handling

                reader.Close();
            }
            else
            {
                //no version file present
                _versionHud = new Version("0.0.0");
            }

            //return the version
            return _versionHud;
        }




    } //namespace
} //class

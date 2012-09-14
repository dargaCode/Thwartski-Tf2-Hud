using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    class Location
    {
        //classes to store the value being passed in
        private Form1 mainForm = null;

        //constructor?
        public Location(Form1 caller)
        {
            //store the calling form
            mainForm = caller;
        } 

        //should contain: 

        private string _pathFolderHudLocation;
        private string _filenameHudAspect;
        private string _filenameHudScoreboard;
        private string _filenameHudMenu;
        private Version _versionHud;

            //getters and setters
            public string PathFolderHudLocation { get { return _pathFolderHudLocation; } set { _pathFolderHudLocation = value; } }
            public string FilenameHudAspect { get { return _filenameHudAspect; } set { _filenameHudAspect = value; } }
            public string FilenameHudScoreboard { get { return _filenameHudScoreboard; } set { _filenameHudScoreboard = value; } }
            public string FilenameHudMenu { get { return _filenameHudMenu; } set { _filenameHudMenu = value; } }
            public Version VersionHud { get { return _versionHud; } set { _versionHud = value; } }


    }
}

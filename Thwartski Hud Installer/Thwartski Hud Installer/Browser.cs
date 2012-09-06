using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    static class Browser
    {
        //paths for populating the folder browser
        private string folderDefaultSteamapps32Bit = @"C:\Program Files (x86)\Steam\steamapps\";
        private string folderDefaultefaultSteamapps64Bit = @"C:\Program Files\Steam\steamapps\";
        private static string folderSteamappsUnknown = @"\YOUR_STEAM_FOLDER\steamapps\";
        private static string folderSteamUserUnknown = @"YOUR_USERNAME";
        private static string folderTeamFortress2 = @"\team fortress 2";
        
        
        public string folderSteamapps;                  //written at runtime
        public string folderSteamUser;                  //written at runtime

        //paths for browsing folders
        public string pathPartialTeamFortress2;     //written at runtime
        public static string pathUnknownTeamFortress2 = folderSteamappsUnknown + folderSteamUserUnknown + folderTeamFortress2;

        //forder browser descriptions and errors
        public string folderBrowserDescUnknown = @"Please select " + pathUnknownTeamFortress2;
        public string folderBrowserDescPartial = @"Please select your \steamapps\" + folderSteamUserUnknown + folderTeamFortress2 + " folder";
        public string folderBrowserDescValid = @"Please select your Team Fortress 2 folder.";
        public string messageBadFolderSelected = @"Please select " + pathUnknownTeamFortress2;

    }
}

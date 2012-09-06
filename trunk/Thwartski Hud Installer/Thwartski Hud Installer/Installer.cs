using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Thwartski_Hud_Installer
{
    static class Installer
    {
        //used for cycling through assetfolder directory
        //DirectoryInfo assetFolderDir = new DirectoryInfo(assetPath);

        //file and path to let the buttons know the hud is installed
        private string installCheckerFile = "Thwartski Hud Installed.txt";

        //private string for launching tf2
        private string teamFortressLaunchCommand = "steam://rungameid/440";

        //array of filenames that valve automatically generates, so they can be left out from backups
        private string[] forcedValveFiles = { "game.ico", "tf.ttf", "tf2.ttf", "tf2build.ttf", "tf2professor.ttf", "tf2secondary.ttf", "tfd.ttf" };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    static class Options
    {

        //see where the exe is running from
        //private static string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\";

        //names of custom install files to write the asset options to
        private string aspectInstallFile = "SpectatorTournament.res";
        private string scoreboardInstallFile = "ScoreBoard.res";
        private string menuInstallFile = "GameMenu.res";

        //paths for copying assets and installing them
        private string installPathTfSubFolder = @"\tf\";
        private string installPathResourceSubfolder = @"resource\";
        private string installPathUiSubfolder = @"ui\";
        private string assetOptionsSubfolder = @"_Thwartski Hud Options\";
        private string backupSubFolder = @"_HUD BACKUPS\";

        //names of custom asset files for aspect options
        private string aspectAssetFileNormal = "SpectatorTournament_Normal.res";
        private string aspectAssetFileWidescreen = "SpectatorTournament_Widescreen.res";

        //names of custom asset files for scoreboard options
        private string scoreboardAssetFilePub24Comp6 = "ScoreBoard_Pub24Comp6.res";
        private string scoreboardAssetFilePub24Comp9 = "ScoreBoard_Pub24Comp9.res";
        private string scoreboardAssetFilePub32Comp6 = "ScoreBoard_Pub32Comp6.res";
        private string scoreboardAsserFilePub32Comp9 = "ScoreBoard_Pub32Comp9.res";

        //names of custom asset files for menu options
        private string menuAssetFilePub24Comp6 = "GameMenu_Pub24Comp6.res";
        private string menuAssetFilePub24Comp9 = "GameMenu_Pub24Comp9.res";
        private string menuAssetFilePub32Comp6 = "GameMenu_Pub32Comp6.res";
        private string menuAssetFilePub32Comp9 = "GameMenu_Pub32Comp9.res";


        //default install/uninstall button tooltips
        //public string tooltipInstallButton = tooltipInstallFreshMode;    //overridden in installButtonMode
        //public string tooltipUninstallButton = tooltipInstallOptionsMode;  //overridden in installButtonMode


        //paths for copying assets and installing them
        //string assetPath = exeFolder + @"Thwartski Hud Install Files\";
        public string installPath;                      //written at runtime
        public string assetOptionsPath;                 //written at runtime
        public string backupPath;                       //written at runtime

        //which custom assets were selected to be installed in the comboboxes
        public string aspectSelectedAssetFile;          //written at runtime
        public string scoreboardSelectedAssetFile;      //written at runtime
        public string menuSelectedAssetFile;            //written at runtime
        public string aspectSelectedAssetPath;          //written at runtime
        public string scoreboardSelectedAssetPath;      //written at runtime
        public string menuSelectedAssetPath;            //written at runtime

        //paths to write custom files to
        public string customInstallPathResource;        //written at runtime
        public string customInstallPathUi;              //written at runtime
        public string aspectFileDestination;            //written at runtime
        public string scoreboardFileDestination;        //written at runtime
        public string menuFileDestination;              //written at runtime

        //file and path to let the buttons know the hud is installed
        public string installCheckerDestination;        //written at runtime




    }
}

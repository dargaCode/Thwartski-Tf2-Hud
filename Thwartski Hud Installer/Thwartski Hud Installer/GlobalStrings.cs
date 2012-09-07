using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    static class GlobalStrings
    {


        //WRITABLE


        //default install/uninstall button tooltips
        private static string _tooltipInstallButton = _tooltipInstallFreshMode;    //overridden in installButtonMode
        private static string _tooltipUninstallButton = _tooltipInstallOptionsMode;  //overridden in installButtonMode

            //getters and setters
            public static string TooltipInstallButton { get { return _tooltipInstallButton; } set { _tooltipInstallButton = value; } }
            public static string TooltipUninstallButton { get { return _tooltipUninstallButton; } set { _tooltipUninstallButton = value; } }

        //see where the exe is running from
        private static string _exeFolder; //written at runtime

            //getters and setters
            public static string ExeFolder { get { return _exeFolder; } set { _exeFolder = value; } }

        //paths for copying assets and installing them
        private static string _assetPath = _exeFolder + @"Thwartski Hud Install Files\";
        private static string _zipFileLocation = _assetPath + "AssetFiles.zip";

            //getters and setters
            public static string AssetPath { get { return _assetPath; } set { _assetPath = value; } }
            public static string ZipFileLocation { get { return _zipFileLocation; } set { _assetPath = value; } }








        private static string installPath;                      //written at runtime
        private static string assetOptionsPath;                 //written at runtime
        private static string backupPath;                       //written at runtime

        //which custom assets were selected to be installed in the comboboxes
        private static string aspectSelectedAssetFile;          //written at runtime
        private static string scoreboardSelectedAssetFile;      //written at runtime
        private static string menuSelectedAssetFile;            //written at runtime
        private static string aspectSelectedAssetPath;          //written at runtime
        private static string scoreboardSelectedAssetPath;      //written at runtime
        private static string menuSelectedAssetPath;            //written at runtime

        //paths to write custom files to
        private static string customInstallPathResource;        //written at runtime
        private static string customInstallPathUi;              //written at runtime
        private static string aspectFileDestination;            //written at runtime
        private static string scoreboardFileDestination;        //written at runtime
        private static string menuFileDestination;              //written at runtime

        //file and path to let the buttons know the hud is installed
        private static string installCheckerDestination;        //written at runtime

        private static string folderSteamapps;                  //written at runtime
        private static string folderSteamUser;                  //written at runtime

        //paths for browsing folders
        private static string pathPartialTeamFortress2;     //written at runtime





        //READ ONLY


        //array of filenames that valve automatically generates, so they can be left out from backups
        private static string[] _forcedValveFiles = { "game.ico", "tf.ttf", "tf2.ttf", "tf2build.ttf", "tf2professor.ttf", "tf2secondary.ttf", "tfd.ttf" };

            //getters (read only)
            public static string[] ForcedValveFiles { get { return _forcedValveFiles; } }

        //double new line for easily combining multi-line strings
        private static string paragraph = Environment.NewLine + Environment.NewLine;

        //tooltip messages
        private static string _tooltipFolderBrowse = string.Format(@"{1}{0}{2}", paragraph, @"Use the Browse button to select your 'Team Fortress 2' folder.", @"(You'll find it under \YOUR STEAM FOLDER\steamapps\YOUR STEAM USERNAME.)");
        private static string _tooltipAspectRatio = string.Format(@"{1}{0}{2}", paragraph, @"This will position your spectator hud correctly for competitive games.", @"(Enable by checking 'Use Advanced Spectator Hud' under Advanced Options.)");
        private static string _tooltipMaxmode = string.Format(@"{1}{0}{2}", paragraph, @"Which scoreboard will you use when playing on pub servers?", @"(Switch scoreboards using the buttons on your in-game escape menu.)");
        private static string _tooltipMinmode = string.Format(@"{1}{0}{2}", paragraph, @"Which scoreboard will you use when playing competitive games?", @"(Switch scoreboards using the buttons on your in-game escape menu.)");
        
            //getters (read only)
            public static string TooltipFolderBrowse { get { return _tooltipFolderBrowse; } }
            public static string TooltipAspectRatio { get { return _tooltipAspectRatio; } }
            public static string TooltipMaxmode { get { return _tooltipMaxmode; } }
            public static string TooltipMinmode { get { return _tooltipMinmode; } }

        //install/uninstall button tooltips for fresh uninstall
        private static string _tooltipInstallFreshMode = string.Format(@"{1}{0}{2}", paragraph, @"Install Thwartski Hud with the selected options.", @"(If you have custom hud files installed, they'll be backed up first.)");
        private static string _tooltipUninstallFreshMode = string.Format(@"{1}{0}{2}", paragraph, @"Uninstall Thwartski Hud and restore Valve's default hud files.", @"(Thwartski Hud won't be backed up, but you can easily reinstall it.)");

            //getters (read only)
            public static string TooltipInstallFreshMode { get { return _tooltipInstallFreshMode; } }
            public static string TooltipUninstallFreshMode { get { return _tooltipUninstallFreshMode; } }

        //install/uninstall button tooltips for updating options
        private static string _tooltipInstallOptionsMode = string.Format(@"{1}{0}{2}", paragraph, @"Update the modified options only.", @"(Unlike installing, this action can be performed with the game running.)");
        private static string _tooltipUninstallOptionsMode = string.Format(@"{1}", paragraph, @"Ignore the modified options and uninstall Thwartski Hud.", @"(second line hidden)");

            //getters (read only)
            public static string TooltipInstallOptionsMode { get { return _tooltipInstallOptionsMode; } }
            public static string TooltipUninstallOptionsMode { get { return _tooltipUninstallOptionsMode; } }

        //install button tooltip for launching game
        private static string _tooltipInstallLaunchMode = string.Format(@"{1}", paragraph, @"Launch TF2 and close the installer.", @"(second line hidden)");

            //getters (read only)
            public static string TooltipInstallLaunchMode { get { return _tooltipInstallLaunchMode; } }

        //exception messages
        private static string _exceptionFolderOpen = string.Format(@"{1}{0}{2}", paragraph, @"The previous hud installation could not be deleted!", @"Please make sure your hud folders are closed.");
        private static string _exceptionGameRunning = string.Format(@"{1}{0}{2}", paragraph, @"The previous hud installation could not be deleted!", @"Please make sure TF2 is not running.");
        private static string _exceptionAssetsMissing = string.Format(@"{1}{0}{2}", paragraph, @"The Thwartski Hud source files could not be found!", @"Please re-download the installer or replace any deleted files.");
        
            //getters (read only)
            public static string ExceptionFolderOpen { get { return _exceptionFolderOpen; } }
            public static string ExceptionGameRunning { get { return _exceptionGameRunning; } }
            public static string ExceptionAssetsMissing { get { return _exceptionAssetsMissing; } }

        //paths for browsing folders
        private static string _pathUnknownTeamFortress2 = Properties.Resources.stringFolderSteamappsUnknown + Properties.Resources.stringFolderSteamUserUnknown + Properties.Resources.stringFolderTeamFortress2;

            //getters (read only)
            public static string PathUnknownTeamFortress2 { get { return _pathUnknownTeamFortress2; } }

        //forder browser descriptions and errors
            private static string _folderBrowserDescUnknown = @"Please select " + _pathUnknownTeamFortress2;
            private static string _folderBrowserDescPartial = @"Please select your \steamapps\" + Properties.Resources.stringFolderSteamUserUnknown + Properties.Resources.stringFolderTeamFortress2 + " folder";
            private static string _folderBrowserDescValid = @"Please select your Team Fortress 2 folder.";
            private static string _messageBadFolderSelected = @"Please select " + _pathUnknownTeamFortress2;

            //getters (read only)
            public static string FolderBrowserDescUnknown { get { return _folderBrowserDescUnknown; } }
            public static string FolderBrowserDescPartial { get { return _folderBrowserDescPartial; } }
            public static string FolderBrowserDescValid { get { return _folderBrowserDescValid; } }
            public static string MessageBadFolderSelected { get { return _messageBadFolderSelected; } }


    }
}

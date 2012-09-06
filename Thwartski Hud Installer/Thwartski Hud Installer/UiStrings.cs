using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    static class UiStrings
    {
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

        //success messages
        private static string _messageUpdateSettingsComplete = "Your custom options have been installed.";
        private static string _messageUninstallComplete = "All hud files are now reverted to Valve defaults.";

            //getters (read only)
            public static string MessageUpdateSettingsComplete { get { return _messageUpdateSettingsComplete; } }
            public static string MessageUninstallComplete { get { return _messageUninstallComplete; } }

        //display text for comboboxes arrays
        private static string _comboboxAspectNormalText = "Normal";
        private static string _comboboxAspectWidescreenText = "Widescreen";
        private static string _comboboxScoreboardComp6Text = "6v6";
        private static string _comboboxScoreboardComp9Text = "Highlander";
        private static string _comboboxScoreboardPub24Text = "24 Player";
        private static string _comboboxScoreboardPub32Text = "32 Player";

            //getters (read only)
            public static string ComboboxAspectNormalText { get { return _comboboxAspectNormalText; } }
            public static string ComboboxAspectWidescreenText { get { return _comboboxAspectWidescreenText; } }
            public static string ComboboxScoreboardComp6Text { get { return _comboboxScoreboardComp6Text; } }
            public static string ComboboxScoreboardComp9Text { get { return _comboboxScoreboardComp9Text; } }
            public static string ComboboxScoreboardPub24Text { get { return _comboboxScoreboardPub24Text; } }
            public static string ComboboxScoreboardPub32Text { get { return _comboboxScoreboardPub32Text; } }

        //display text for install button modes
        private static string _buttonInstallFreshMode = "Install Hud";
        private static string _buttonInstallOptionsMode = "Save Options";
        private static string _buttonInstallLaunchMode = "Launch TF2";

            //getters (read only)
            public static string ButtonInstallFreshMode { get { return _buttonInstallFreshMode; } }
            public static string ButtonInstallOptionsMode { get { return _buttonInstallOptionsMode; } }
            public static string ButtonInstallLaunchMode { get { return _buttonInstallLaunchMode; } }

    }
}

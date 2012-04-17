//modified from valve, inspired by eve, frankenhud, and more (who included the demoui)

"GameMenu" [$WIN32]
{

	"ServerBrowserButton"
	{
		"label" "#MMenu_BrowseServers" 
		"command" "OpenServerBrowser"
		"subimage" "glyph_server"
		"subimage" "glyph_server_browser"
		//"subimage" "glyph_workshop_view" //bigger magnifying glass lense
		"OnlyAtMenu" "0"
	} 

	"CreateServerButton"
	{
		"label" "#GameUI_GameMenu_CreateServer" 
		"command" "OpenCreateMultiplayerGameDialog"
		"subimage" "glyph_create"
		"OnlyAtMenu" "0"
	}
	
	"CharacterSetupButton"
	{
		"label" "Manage Items"//"#MMenu_CharacterSetup"
		"command" "engine open_charinfo"
		"subimage" "glyph_items"
	}
	
	"AchievementButton"
	{
		"label" "View Achievements"
		"command" "OpenAchievementsDialog"
		"subimage"	"icon_checkbox"
	}
	
	"ReplayBrowserButton"
	{
		"label" "Edit Replays"//"#GameUI_GameMenu_ReplayDemos"
		"command" "engine replay_reloadbrowser"
		"subimage" "glyph_tv"
	}

	
	"QuickPlayMiniButton"
	{
		"command" "quickplay"
		"OnlyAtMenu" "0"
		"tooltip" "Quickplay"
	}

	"TrainingMiniButton"
	{
		"command" "offlinepractice"
		"OnlyAtMenu" "0"
		"tooltip" "#TF_Training"
	}

	"StoreMiniButton"
	{
		"command" "engine open_store"
		"OnlyAtMenu" "0"
		"tooltip" "#MMenu_Shop"
	}	
	
	"DemoMiniButton"
	{

		"command" "engine demoui"
		"OnlyAtMenu" "0"
		"tooltip" "Play Demos"
	}

	// These buttons are only shown while in-game
	// and also are positioned by MainMenuOverride.res

	"CallVoteButton"
	{
		"command"		"callvote"
		"OnlyInGame"	"1"
		"subimage"	"glyph_forums"
		"tooltip" "#MMenu_CallVote"
	}
	"MutePlayersButton"
	{
		"command"		"OpenPlayerListDialog"
		"OnlyInGame"	"1"
		"subimage"		"icon_coach" //headphones
		"tooltip" "#MMenu_MutePlayers"
	}
	"ReportAbuseButton"
	{
		"command"		"engine abuse_report_submit"
		"OnlyInGame"	"1"
		"subimage" "glyph_view"
		"tooltip" 	"REPORT ABUSE"
		
	}
	
	"SteamWorkshopStripButton"
	{
		"command"		"engine OpenSteamWorkshopDialog"
		"OnlyInGame"	"0"
		"subimage" "glyph_steamworkshop"
		"tooltip" 	"#MMenu_SteamWorkshop"
		
	}
	
		"AdvancedOptionsStripButton"
	{
		"command"		"opentf2options"
		"OnlyInGame"	"0"
		"subimage" 		"glyph_options"
		"tooltip"		"Advanced Options"//"#MMenu_AdvOptions"
		
	}
	
}

//Scoreboard with multiple settings based on cl_hud_minmode
//Maxmode = Pub32
//Minmode = Comp6

//inspired by maco (layout) and pvhud (minmode)

"Resource/UI/Scoreboard.res"
{
	"scores"
	{
		"ControlName"		"CTFClientScoreBoardDialog"
		"fieldName"		"scoreinfo"
		"xpos"			"c-300"
		"ypos"			"c-224"
		"wide"			"600"
		"tall"			"490"

		"xpos_minmode"			"c-300"
		"ypos_minmode"			"c-176"
		"wide_minmode"			"600"
		"tall_minmode"			"480"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"		"0"
		"avatar_width"		"58"	
		"name_width"		"134"//"139"	
		"status_width"		"15"//"15"	
		"nemesis_width"		"14"//"15"	
		"class_width"		"14"//"15"	
		"score_width"		"26"
		"ping_width"		"23"		
	}
	"BlueScoreBG"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"BlueScoreBG"
		"xpos"			"14"//"0"
		"ypos"			"10"
		"zpos"			"2"
		"wide"			"286"
		"tall"			"54"
		
		"xpos_minmode"			"14"
		"ypos_minmode"			"60"
		"wide_minmode"			"286"
		"tall_minmode"			"54"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		//"image"			"../hud/score_panel_blue_bg"
		//"scaleImage"		"1"

		"fillcolor"		"91 122 140 255"
	
	}

	"RedScoreBG"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"RedScoreBG"
		"xpos"			"301"
		"ypos"			"10"
		"zpos"			"2"
		"wide"			"286"//"300"
		"tall"			"54"
		
		"xpos_minmode"			"301"
		"ypos_minmode"			"60"
		"wide_minmode"			"286"
		"tall_minmode"			"54"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		//"image"			"../hud/score_panel_red_bg"
		//"scaleImage"		"1"

		"fillcolor"		"189 59 59 255"

	}
	"MainBG"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"MainBG"
		"xpos"			"14"//"0"
		"ypos"			"10"
		"zpos"			"-1"
		"wide"			"573"//"600"
		"tall"			"384"
		
		"xpos_minmode"			"14"
		"ypos_minmode"			"60"
		"wide_minmode"			"573"
		"tall_minmode"			"199"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		//"border"		"TFThinLineBorder"
		"fillcolor"		"0 0 0 220"

	}

	"PlayerStatsBG"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"PlayerStatsBG"
		"xpos"			"150"
		"ypos"			"406"	
		"zpos"			"-10"
		"wide"			"300"
		"tall"			"70"
		
		"xpos_minmode"			"150"
		"ypos_minmode"			"279"
		"wide_minmode"			"300"
		"tall_minmode"			"70"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"	
		"fillcolor"		"0 0 0 255" //220	
		"PaintBackgroundType"	"0"
	
	}
	
	"MainVerticalLine"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"MainVerticalLine"
		"xpos"			"300"
		"ypos"			"64"
		"zpos"			"3"
		"wide"			"1"
		"tall"			"299"
		
		"xpos_minmode"			"300"
		"ypos_minmode"			"114"
		"wide_minmode"			"1"
		"tall_minmode"			"112"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"	
		"fillcolor"		"255 255 255 200"
		//"fillcolor"		"127 127 127 153"
		"PaintBackgroundType"	"0"
	}
	"HorizontalLine"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"HorizontalLine"
		"xpos"			"115"
		"ypos"			"397"	
		"zpos"			"3"
		"wide"			"464"
		"tall"			"1"
		
		"xpos_minmode"			"115"
		"ypos_minmode"			"447"	
		"wide_minmode"			"464"
		"tall_minmode"			"1"	
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"		"0"	
		"fillcolor"		"127 127 127 153"
		"PaintBackgroundType"	"0"
	}

	"PlayerScoreLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"PlayerScoreLabel"
		"font"			"ScoreboardMedium"
		"labelText"		"%playerscore%"
		"textAlignment"		"Center"
		"xpos"			"231"
		"ypos"			"413"
		"zpos"			"3"
		"wide"			"140"
		"tall"			"20"
		
		"xpos_minmode"			"231"
		"ypos_minmode"			"286"
		"wide_minmode"			"140"
		"tall_minmode"			"20"	
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}				
	"BlueTeamLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"BlueTeamLabel"
		"font"			"ScoreboardTeamNameLarge"
		//"labelText"		"REALLYLONGTEAMNAME"
		"labelText"		"%blueteamname%"
		"textAlignment"		"west"
		"xpos"			"24"//"15"
		"ypos"			"10"//"28"
		"zpos"			"3"	
		"wide"			"250"
		"tall"			"34"
		

		"xpos_minmode"			"24"
		"ypos_minmode"			"60"
		"wide_minmode"			"250"
		"tall_minmode"			"34"		
		
		"autoResize"    "0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
	"BlueTeamScore"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"BlueTeamScore"
		"font"			"ScoreboardTeamScore"
		"labelText"		"%blueteamscore%"
		"textAlignment"		"east"
		"xpos"			"194"
		"ypos"			"10" 
		"zpos"			"5"
		"wide"			"100"
		"tall"			"55"
		

		"xpos_minmode"			"194"
		"ypos_minmode"			"60" 
		"wide_minmode"			"100"
		"tall_minmode"			"55"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}
	"BlueTeamScoreDropshadow"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"BlueTeamScoreDropshadow"
		"font"			"ScoreboardTeamScore"
		"fgcolor"		"Black"
		"labelText"		"%blueteamscore%"
		"textAlignment"		"east"
		"xpos"			"195"
		"ypos"			"11" 
		"zpos"			"4"
		"wide"			"100"
		"tall"			"55"
		
		"xpos_minmode"			"195"
		"ypos_minmode"			"61" 
		"wide_minmode"			"100"
		"tall_minmode"			"55"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
	"BlueTeamPlayerCount"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"BlueTeamPlayerCount"
		"font"			"ScoreboardMedium"
		"labelText"		"%blueteamplayercount%"
		"textAlignment"	"center"
		"xpos"			"14"//"110"	
		"ypos"			"35"
		"zpos"			"3"
		"wide"			"286"//"100"
		"tall"			"29"
		
		"xpos_minmode"			"14"
		"ypos_minmode"			"85"
		"wide_minmode"			"286"
		"tall_minmode"			"29"	
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
	"RedTeamLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"RedTeamLabel"
		"font"			"ScoreboardTeamNameLarge"
		"labelText"		"%redteamname%"
		//"labelText"	"REALLYLONGTEAMNAME"
		"textAlignment"		"east"
		"xpos"			"328"//"448"
		"ypos"			"10"//"28"
		"zpos"			"3"	
		"wide"			"250"
		"tall"			"34"
		
		"xpos_minmode"			"328"
		"ypos_minmode"			"60"
		"wide_minmode"			"250"
		"tall_minmode"			"34"	
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
	"RedTeamScore"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"RedTeamScore"
		"font"			"ScoreboardTeamScore"
		"labelText"		"%redteamscore%"
		"textAlignment"		"west"
		"xpos"			"310"
		"ypos"			"10" 
		"zpos"			"5"
		"wide"			"100"
		"tall"			"55"
		
		"xpos_minmode"			"310"
		"ypos_minmode"			"60" 
		"wide_minmode"			"100"
		"tall_minmode"			"55"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}
	"RedTeamScoreDropshadow"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"RedTeamScoreDropshadow"
		"font"			"ScoreboardTeamScore"
		"fgcolor"		"Black"
		"labelText"		"%redteamscore%"
		"textAlignment"		"west"
		"xpos"			"311"
		"ypos"			"11"
		"zpos"			"4"
		"wide"			"100"
		"tall"			"55"
		
		"xpos_minmode"			"311"
		"ypos_minmode"			"61"
		"wide_minmode"			"100"
		"tall_minmode"			"55"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
	"RedTeamPlayerCount"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"RedTeamPlayerCount"
		"font"			"ScoreboardMedium"
		"labelText"		"%redteamplayercount%"
		"textAlignment"		"center"
		"xpos"			"301"//"375"
		"ypos"			"35"
		"zpos"			"3"
		"wide"			"286"//"100"
		"tall"			"29"
		
		"xpos_minmode"			"301"
		"ypos_minmode"			"85"
		"wide_minmode"			"286"
		"tall_minmode"			"29"	
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							
							
	"BluePlayerList"
	{
		"ControlName"	"SectionedListPanel"
		"fieldName"		"BluePlayerList"
		"xpos"			"12"//"6"
		"ypos"			"51"
		"zpos"			"1"
		"wide"			"290"
		"tall"			"400"	
		
		"xpos_minmode"			"12"
		"ypos_minmode"			"101"
		"wide_minmode"			"290"
		"tall_minmode"			"126"			
		
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"		"0"
		"autoresize"		"3"
		"linespacing"		"19" //"22"
		"fgcolor"		"blue"
	}
	"RedPlayerList"
	{
		"ControlName"	"SectionedListPanel"
		"fieldName"		"RedPlayerList"
		"xpos"			"299"//"305"
		"ypos"			"51"
		"zpos"			"1"
		"wide"			"290"
		"tall"			"400"	
		
		"xpos_minmode"			"299"
		"ypos_minmode"			"101"
		"wide_minmode"			"290"
		"tall_minmode"			"126"		
		
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"autoresize"	"3"
		"linespacing"		"19"//"22"
		"textcolor"		"red"
	}

	"Spectators"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"Spectators"
		"font"			"ScoreboardVerySmall"
		"labelText"		"%spectators%"
		"textAlignment"		"west"
		"xpos"			"20"
		"ypos"			"c+121"	
		"zpos"			"4"
		"wide"			"560"
		"tall"			"20"
		
		"xpos_minmode"			"20"
		"ypos_minmode"			"c-14"	
		"wide_minmode"			"560"
		"tall_minmode"			"20"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}	
	"SpectatorsInQueue"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"SpectatorsInQueue"
		"font"			"ScoreboardVerySmall"
		"labelText"		"%waitingtoplay%"
		"textAlignment"	"east"
		"xpos"			"20"
		"ypos"			"c+121"	
		"zpos"			"4"
		"wide"			"560"
		"tall"			"20"
		
	
		"xpos_minmode"			"20"
		"ypos_minmode"			"c-14"	
		"wide_minmode"			"560"
		"tall_minmode"			"20"	
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
	}							

	"ServerLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"ServerLabel"
		"font"			"ScoreboardTiny"
		"labelText"		"%server%"
		"textAlignment"		"west"
		"xpos"			"20"
		"ypos"			"374"
		"wide"			"300"
		"tall"			"20"
		
		"xpos_minmode"			"20"
		"ypos_minmode"			"239"
		"wide_minmode"			"300"
		"tall_minmode"			"20"		
		
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"	
		"enabled"		"1"
	}
	"ServerTimeLeft"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"ServerTimeLeft"
		"font"			"ScoreboardTiny"
		"labelText"		"%servertimeleft%"
		"textAlignment"		"east"
		"xpos"			"20"
		"ypos"			"373"
		"wide"			"560"
		"tall"			"20"
		
		"xpos_minmode"			"20"
		"ypos_minmode"			"239"
		"wide_minmode"			"560"
		"tall_minmode"			"20"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"	
		"enabled"		"1"
	}


	
	
	"ClassImage"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"ClassImage"
		"xpos"			"22"
		"ypos"			"423"	
		"zpos"			"3"
		"wide"			"0"
		"tall"			"0"
		

		"xpos_minmode"			"22"
		"ypos_minmode"			"400"	
		"wide_minmode"			"0"
		"tall_minmode"			"0"		
		
		"visible"		"0"
		"enabled"		"1"
		//"image"			"../hud/class_scoutred"
		"scaleImage"		"1"	
	}
	"PlayerNameLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"PlayerNameLabel"
		"font"			"ScoreboardMedium"
		"labelText"		"%playername%"
		"textAlignment"		"west"
		"xpos"			"115"
		"ypos"			"450"	
		"zpos"			"3"
		"wide"			"325"	
		"tall"			"20"
		
		"xpos_minmode"			"115"
		"ypos_minmode"			"427"	
		"wide_minmode"			"325"	
		"tall_minmode"			"20"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
	}							

	"LocalPlayerDuelStatsPanel"
	{
		"ControlName"		"EditablePanel"
		"fieldName"		"LocalPlayerDuelStatsPanel"
		"xpos"			"0"
		"ypos"			"429"
		"zpos"			"3"
		"wide"			"600"
		"tall"			"53"
		
		"xpos_minmode"			"0"
		"ypos_minmode"			"301"
		"wide_minmode"			"600"
		"tall_minmode"			"53"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"DuelingLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"DuelingLabel"
			"font"			"ScoreboardSmall"
			"labelText"		"#TF_ScoreBoard_Dueling"
			"textAlignment"		"center"
			"xpos"			"250"
			"ypos"			"2"
			"zpos"			"3"
			"wide"			"100"
			"tall"			"20"
		
			"xpos_minmode"			"250"
			"ypos_minmode"			"2	"
			"wide_minmode"			"100"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}

		"DuelingIcon"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"DuelingIcon"
			"xpos"			"284"
			"ypos"			"15"
			"zpos"			"2"
			"wide"			"32"
			"tall"			"32"
		
			"xpos_minmode"			"284"
			"ypos_minmode"			"15"
			"wide_minmode"			"32"
			"tall_minmode"			"32"	
		
			"visible"		"1"
			"enabled"		"1"
			"image"			"../backpack/player/items/crafting/icon_dueling"
			"scaleImage"	"1"
		}

		"LocalPlayerData"
		{
			"ControlName"		"EditablePanel"
			"fieldName"		"LocalPlayerData"
			"xpos"			"75"
			"ypos"			"0"
			"wide"			"200"
			"tall"			"53"
		
			"xpos_minmode"			"75"
			"ypos_minmode"			"0"
			"wide_minmode"			"200"
			"tall_minmode"			"53"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
	
			"AvatarBGPanel"
			{
				"ControlName"	"EditablePanel"
				"fieldName"		"AvatarBGPanel"
				"xpos"			"157"
				"ypos"			"7"
				"zpos"			"-1"
				"wide"			"36"
				"tall"			"36"
		
				"xpos_minmode"			"157"
				"ypos_minmode"			"7"
				"wide_minmode"			"36"
				"tall_minmode"			"36"		
		
				"visible"		"1"
				"PaintBackgroundType"	"2"
				"bgcolor_override"	"117 107 94 255"
			}
			"AvatarImage"
			{
				"ControlName"	"CAvatarImagePanel"
				"fieldName"		"AvatarImage"
				"xpos"			"159"
				"ypos"			"9"
				"zpos"			"0"
				"wide"			"32"
				"tall"			"32"
		
				"xpos_minmode"			"159"
				"ypos_minmode"			"9"
				"wide_minmode"			"32"
				"tall_minmode"			"32"		
		
				"visible"		"1"
				"enabled"		"1"
				"image"			""
				"scaleImage"	"1"	
				"color_outline"	"52 48 45 255"
			}
			"AvatarTextLabel"
			{	
				"ControlName"	"CExLabel"
				"fieldName"		"AvatarTextLabel"
				"fgcolor"		"TanLight"
				"xpos"			"50"
				"ypos"			"7"
				"zpos"			"2"
				"wide"			"100"
				"tall"			"18"
		
				"xpos_minmode"			"50"
				"ypos_minmode"			"7"
				"wide_minmode"			"100"
				"tall_minmode"			"18"		
		
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"enabled"		"1"
				"wrap"			"0"
				"labelText"		"%playername%"
				"textAlignment"	"east"
				"font"			"HudFontSmallest"
			}
			"Score"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"Score"
				"labelText"		"%score%"
				"textAlignment"	"east"
				"xpos"			"50"
				"ypos"			"23"
				"zpos"			"3"
				"wide"			"100"
				"tall"			"20"
		
				"xpos_minmode"			"50"
				"ypos_minmode"			"23"
				"wide_minmode"			"100"
				"tall_minmode"			"20"		
		
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"enabled"		"1"
				"font"			"ScoreboardMedium"
			}
		}

		"OpponentData"
		{
			"ControlName"		"EditablePanel"
			"fieldName"		"OpponentData"
			"xpos"			"325"
			"ypos"			"0"
			"wide"			"200"
			"tall"			"53"
		
			"xpos_minmode"			"325"
			"ypos_minmode"			"0"
			"wide_minmode"			"200"
			"tall_minmode"			"53"	
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
	
			"AvatarBGPanel"
			{
				"ControlName"	"EditablePanel"
				"fieldName"		"AvatarBGPanel"
				"xpos"			"7"
				"ypos"			"7"
				"zpos"			"-1"
				"wide"			"36"
				"tall"			"36"
		
				"xpos_minmode"			"7"
				"ypos_minmode"			"7"
				"wide_minmode"			"36"
				"tall_minmode"			"36"	
		
				"visible"		"1"
				"PaintBackgroundType"	"2"
				"bgcolor_override"	"117 107 94 255"
			}
			"AvatarImage"
			{
				"ControlName"	"CAvatarImagePanel"
				"fieldName"		"AvatarImage"
				"xpos"			"9"
				"ypos"			"9"
				"zpos"			"0"
				"wide"			"32"
				"tall"			"32"
		
				"xpos_minmode"			"9"
				"ypos_minmode"			"9"
				"wide_minmode"			"32"
				"tall_minmode"			"32"		
		
				"visible"		"1"
				"enabled"		"1"
				"image"			""
				"scaleImage"	"1"	
				"color_outline"	"52 48 45 255"
			}
			"AvatarTextLabel"
			{	
				"ControlName"	"CExLabel"
				"fieldName"		"AvatarTextLabel"
				"fgcolor"		"TanLight"
				"xpos"			"50"
				"ypos"			"7"
				"zpos"			"2"
				"wide"			"100"
				"tall"			"18"
		
				"xpos_minmode"			"50"
				"ypos_minmode"			"7"
				"wide_minmode"			"100"
				"tall_minmode"			"18"		
		
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"enabled"		"1"
				"wrap"			"0"
				"labelText"		"%playername%"
				"textAlignment"	"west"
				"font"			"HudFontSmallest"
			}
			"Score"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"Score"
				"labelText"		"%score%"
				"textAlignment"	"west"
				"xpos"			"50"
				"ypos"			"23"
				"zpos"			"3"
				"wide"			"200"
				"tall"			"20"
		
				"xpos_minmode"			"50"
				"ypos_minmode"			"23"
				"wide_minmode"			"200"
				"tall_minmode"			"20"		
		
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"enabled"		"1"
				"font"			"ScoreboardMedium"
			}
		}		
	}

	"LocalPlayerStatsPanel"
	{
		"ControlName"		"EditablePanel"
		"fieldName"		"LocalPlayerStatsPanel"
		"xpos"			"0"
		"ypos"			"346"
		"zpos"			"5"
		"wide"			"600"
		"tall"			"448"
		
		"xpos_minmode"			"0"
		"ypos_minmode"			"219"
		"wide_minmode"			"600"
		"tall_minmode"			"448"		
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"MapName"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"mapname"
			"font"			"ScoreboardTiny"
			"labelText"		"%mapname%"
			"textAlignment"		"center"
			"xpos"			"228"
			"ypos"			"28"
			"zpos"			"13"
			"wide"			"146"
			"tall"			"20"
		
	
			"xpos_minmode"			"228"
			"ypos_minmode"			"20"
			"wide_minmode"			"146"
			"tall_minmode"			"20"	
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"fgcolor"		"236 227 203 255"
		}	
		




			
			
		"Kills"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Kills"
			"font"			"HudFontBig"
			"labelText"		"%kills%"
			"textAlignment"	"east"
			"xpos"			"196"
			"ypos"			"87"	
			"zpos"			"3"
			"wide"			"100"
			"tall"			"40"

			"xpos_minmode"			"196"
			"ypos_minmode"			"87"	
			"wide_minmode"			"100"
			"tall_minmode"			"40"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		"KDRatio"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"KDRatio"
			"font"			"HudFontBig"
			"labelText"		":"
			"textAlignment"	"center"
			"xpos"			"282"
			"ypos"			"87"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"40"
		
			"xpos_minmode"			"282"
			"ypos_minmode"			"87"	
			"wide_minmode"			"40"
			"tall_minmode"			"40"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}	

		"Deaths"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"Deaths"
			"font"			"HudFontBig"
			"labelText"		"%deaths%"
			"textAlignment"		"west"
			"xpos"			"308"
			"ypos"			"87"	
			"zpos"			"3"
			"wide"			"100"
			"tall"			"40"
		
			"xpos_minmode"			"308"
			"ypos_minmode"			"87"	
			"wide_minmode"			"100"
			"tall_minmode"			"40"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}	
							
		"PlayerStatsVerticalLine"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"PlayerStatsVerticalLine"
			"xpos"			"223"
			"ypos"			"70"
			"zpos"			"3"
			"wide"			"1"
			"tall"			"50"
		
			"xpos_minmode"			"223"
			"ypos_minmode"			"70"
			"wide_minmode"			"1"
			"tall_minmode"			"54"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"tabPosition"	"0"	
			"fillcolor"		"255 255 255 200"
			//"fillcolor"		"127 127 127 153"
			"PaintBackgroundType"	"0"
		}				
		
		"ClassStatsVerticalLine"
		{
			"ControlName"		"ImagePanel"
			"fieldName"		"ClassStatsVerticalLine"
			"xpos"			"376	"
			"ypos"			"70"
			"zpos"			"3"
			"wide"			"1"
			"tall"			"50"
		
			"xpos_minmode"			"376	"
			"ypos_minmode"			"70"
			"wide_minmode"			"1"
			"tall_minmode"			"50"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"tabPosition"	"0"	
			"fillcolor"		"255 255 255 200"
			//"fillcolor"		"127 127 127 153"
			"PaintBackgroundType"	"0"
		}
	
		"CapturesLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"CapturesLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_CapturesLabel"
			"textAlignment"		"west"
			"xpos"			"159"		
			"ypos"			"80"//"60"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		
	
			"xpos_minmode"			"159"		
			"ypos_minmode"			"80"
			"wide_minmode"			"40"
			"tall_minmode"			"20"	
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
								
		}						
						
		"Captures"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Captures"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%captures%"
			"textAlignment"		"east"
			"xpos"			"179"	
			"ypos"			"80"//"60"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"179"	
			"ypos_minmode"			"80"
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		
		"DefensesLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"DefensesLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_DefensesLabel"
			"textAlignment"		"west"
			"xpos"			"159"		
			"ypos"			"90"//"70"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		
			"xpos_minmode"			"159"		
			"ypos_minmode"			"90"
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}	


		"Defenses"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Defenses"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%defenses%"
			"textAlignment"		"east"
			"xpos"			"179"	
			"ypos"			"90"//"70"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"179"	
			"ypos_minmode"			"90"
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		"AssistsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"AssistsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_AssistsLabel"
			"textAlignment"		"west"
			"xpos"			"159"	
			"ypos"			"60"//"80"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		
			"xpos_minmode"			"159"	
			"ypos_minmode"			"60"
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}

		"Assists"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Assists"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%assists%"
			"textAlignment"		"east"
			"xpos"			"179"
			"ypos"			"60"//"80"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"179"
			"ypos_minmode"			"60"
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"DestructionLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"DestructionLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_DestructionLabel"
			"textAlignment"		"west"
			"xpos"			"159"	
			"ypos"			"70"//"90"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		
			"xpos_minmode"			"159"	
			"ypos_minmode"			"70"
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"Destruction"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Destruction"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%destruction%"
			"textAlignment"		"east"
			"xpos"			"179"
			"ypos"			"70"//"90"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"179"
			"ypos_minmode"			"70"
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}

		"DominationLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"DominationLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_DominationLabel"
			"textAlignment"		"west"
			"xpos"			"159"		
			"ypos"			"100"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		

			"xpos_minmode"			"159"		
			"ypos_minmode"			"100"	
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}



		"Domination"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Domination"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%dominations%"
			"textAlignment"		"east"
			"xpos"			"179"	
			"ypos"			"100"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		

			"xpos_minmode"			"179"	
			"ypos_minmode"			"100"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		"RevengeLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"RevengeLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_RevengeLabel"
			"textAlignment"		"west"
			"xpos"			"159"	
			"ypos"			"110"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		

			"xpos_minmode"			"159"	
			"ypos_minmode"			"110"	
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}		

		"Revenge"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Revenge"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%Revenge%"
			"textAlignment"		"east"
			"xpos"			"179"	
			"ypos"			"110"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"179"	
			"ypos_minmode"			"110"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		
		
				
		"InvulnLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"InvulnLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"Ubers:"//"#TF_ScoreBoard_InvulnLabel"
			"textAlignment"		"west"
			"xpos"			"387"	
			"ypos"			"60"	
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
			
			"xpos_minmode"			"387"	
			"ypos_minmode"			"60"	
			"wide_minmode"			"40"
			"tall_minmode"			"20"

		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		"Invuln"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Invuln"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%invulns%"
			"textAlignment"		"east"
			"xpos"			"405"	
			"ypos"			"60"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"405"	
			"ypos_minmode"			"60"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}				
						
		"Healing"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Healing"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%healing%"
			"textAlignment"	"east"
			"xpos"			"405"	
			"ypos"			"70"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"405"	
			"ypos_minmode"			"70"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
						
		"HealingLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"HealingLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_HealingLabel"
			"textAlignment"		"west"
			"xpos"			"387"	
			"ypos"			"70"	
			"zpos"			"3"
			"wide"			"40"	
			"tall"			"20"
		

			"xpos_minmode"			"387"	
			"ypos_minmode"			"70"	
			"wide_minmode"			"40"	
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"HeadshotsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"HeadshotsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_HeadshotsLabel"
			"textAlignment"		"west"
			"xpos"			"387"	
			"ypos"			"80"	
			"zpos"			"3"
			"wide"			"40"	
			"tall"			"20"
		
			"xpos_minmode"			"387"	
			"ypos_minmode"			"80"	
			"wide_minmode"			"40"	
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}			
		"Headshots"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Headshots"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%headshots%"
			"textAlignment"		"east"
			"xpos"			"405"	
			"ypos"			"80"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"405"	
			"ypos_minmode"			"80"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}						
		"BackstabsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"BackstabsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_BackstabsLabel"
			"textAlignment"		"west"
			"xpos"			"387"
			"ypos"			"90"
			"zpos"			"5"
			"wide"			"40"
			"tall"			"20"
		
			"xpos_minmode"			"387"
			"ypos_minmode"			"90"
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"Backstabs"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Backstabs"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%backstabs%"
			"textAlignment"		"east"
			"xpos"			"405"
			"ypos"			"90"
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
			"xpos_minmode"			"405"
			"ypos_minmode"			"90"
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"		"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}

		"TeleportsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"TeleportsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_TeleportsLabel"
			"textAlignment"		"west"
			"xpos"			"387"	
			"ypos"			"100"	
			"zpos"			"3"
			"wide"			"40"	
			"tall"			"20"
		
			"xpos_minmode"			"387"	
			"ypos_minmode"			"100"	
			"wide_minmode"			"40"	
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"Teleports"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Teleports"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%teleports%"
			"textAlignment"		"east"
			"xpos"			"405"	
			"ypos"			"100"	
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		

			"xpos_minmode"			"405"	
			"ypos_minmode"			"100"	
			"wide_minmode"			"35"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}		
		"BonusLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"BonusLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_BonusLabel"
			"textAlignment"		"west"
			"xpos"			"387"
			"ypos"			"110"
			"zpos"			"3"
			"wide"			"40"
			"tall"			"20"
		
			"xpos_minmode"			"387"
			"ypos_minmode"			"110"
			"wide_minmode"			"40"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}
		"Bonus"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"Bonus"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%bonus%"
			"textAlignment"		"east"
			"xpos"			"405"
			"ypos"			"110"
			"zpos"			"3"
			"wide"			"35"
			"tall"			"20"
		
		
			"xpos_minmode"			"405"
			"ypos_minmode"			"110"
			"wide_minmode"			"35"
			"tall_minmode"			"20"
		
			"autoResize"		"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
		}

	

			"KillsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"KillsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_KillsLabel"
			"textAlignment"		"east"
			"xpos"			"0"
			"ypos"			"0"	
			"zpos"			"3"
			"wide"			"95"
			"tall"			"20"
		
			"xpos_minmode"			"0"
			"ypos_minmode"			"0"	
			"wide_minmode"			"95"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"0"
			"enabled"		"1"
		}						
		"DeathsLabel"
		{
			"ControlName"		"CExLabel"
			"fieldName"		"DeathsLabel"
			"font"			"ScoreboardVerySmall"
			"labelText"		"#TF_ScoreBoard_DeathsLabel"
			"textAlignment"		"east"
			"xpos"			"0"
			"ypos"			"0"	
			"zpos"			"3"
			"wide"			"95"
			"tall"			"20"
		
			"xpos_minmode"			"0"
			"ypos_minmode"			"0"	
			"wide_minmode"			"95"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"0"
			"enabled"		"1"
		}
		"GameType"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"gametype"
			"font"			"ScoreboardVerySmall"
			"labelText"		"%gametype%"
			"textAlignment"		"east"
			"xpos"			"0"
			"ypos"			"0"
			"zpos"			"3"
			"wide"			"145"
			"tall"			"20"
		
			"xpos_minmode"			"0"
			"ypos_minmode"			"0"
			"wide_minmode"			"145"
			"tall_minmode"			"20"		
		
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"0"
			"enabled"		"1"
			"fgcolor"		"185 177 153 255"
		}
		
	}

}

//based on commhud

"Resource/UI/SpectatorTournament.res"
{
	"specgui"
	{
		"ControlName"		"Frame"
		"fieldName"		"specgui"
		"wide"			"f0"
		"tall"			"480"
		"autoResize"	"0"
		"pinCorner"		"0"
		"enabled"		"1"
		
		"team1_player_base_offset_x"		"260"
		"team1_player_base_y"				"160"
		"team1_player_delta_x"				"0"
		"team1_player_delta_y"				"35"
		
		"team2_player_base_offset_x"		"341"
		"team2_player_base_y"				"160"
		"team2_player_delta_x"				"0"
		"team2_player_delta_y"				"35"
		"playerpanels_kv"

		{
			"visible"		"0"
			"wide"			"55"
			"tall"			"33"
			"zpos"			"10"
			
			"ClassBGThwartski"
			{
				"ControlName"		"Imagepanel"
				"fieldName"			"ClassBGThwartski"
				"xpos"			"0"
				"ypos"			"0"
				"zpos"			"-10"
				"wide"			"55"
				"tall"			"23"
				"visible"			"1"
				"enabled"			"1"
				"scaleImage"		"1"	
				"fillcolor"			"0 0 0 255"
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}
			
			"LeftBarThwartski"
			{
				"ControlName"		"Imagepanel"
				"fieldName"			"LeftBarThwartski"
				"xpos"			"0"
				"ypos"			"1"
				"zpos"			"10"
				"wide"			"3"
				"tall"			"31"
				"visible"			"1"
				"enabled"			"1"
				"scaleImage"		"1"	
				"fillcolor"			"0 0 0 255"
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}
			
			"RightBarThwartski"
			{
				"ControlName"		"Imagepanel"
				"fieldName"			"RightBarThwartski"
				"xpos"			"52"
				"ypos"			"1"
				"zpos"			"10"
				"wide"			"3"
				"tall"			"31"
				"visible"			"1"
				"enabled"			"1"
				"scaleImage"		"1"	
				"fillcolor"			"0 0 0 255"
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}
		
			"TopBarThwartski"
			{
				"ControlName"		"Imagepanel"
				"fieldName"			"TopBarThwartski"
				"xpos"				"0"
				"ypos"				"1"
				"zpos"				"2"
				"wide"				"55"
				"tall"				"3"
				"visible"			"1"
				"enabled"			"1"
				"scaleImage"		"1"	
				"fillcolor"			"0 0 0 255"
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}

		
			"BottomBarThwartski"
			{
				"ControlName"		"Imagepanel"
				"fieldName"			"BottomBarThwartski"
				"xpos"				"0"
				"ypos"				"30"
				"zpos"				"2"
				"wide"				"55"
				"tall"				"3"
				"visible"			"1"
				"enabled"			"1"
				"scaleImage"		"1"	
				"fillcolor"			"0 0 0 255"
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}
			
			"playername"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"playername"
				"font"			"defaultverysmall"
				"xpos"			"3"
				"ypos"			"23"
				"zpos"			"5"
				"wide"			"48"
				"tall"			"8"
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"labelText"		"%playername%"
				"textAlignment"	"north-west"
				"fgcolor"		"235 226 202 255"
			}
			
			"classimage"
			{
				"ControlName"	"CTFClassImage"
				"fieldName"		"classimage"
				"xpos"			"3"
				"ypos"			"3"
				"zpos"			"-2"
				"wide"			"20"
				"tall"			"20"
				"visible"		"1"
				"enabled"		"1"
				"image"			"../hud/class_scoutred"
				"scaleImage"	"1"	
			}
			
			"HealthIcon"
			{
				"ControlName"		"EditablePanel"
				"fieldName"			"HealthIcon"
				"xpos"				"5"
				"ypos"				"3"
				"zpos"				"3"
				"wide"				"55"
				"tall"				"33"
				"visible"			"1"
				"enabled"			"1"	
				"HealthBonusPosAdj"	"12"
				"HealthDeathWarning"		"0.55"
				"TFFont"					"HudFontSmallest"
				"HealthDeathWarningColor"	"HUDDeathWarning"
				"TextColor"					"White"
			}	
			
			"respawntime"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"respawntime"
				"font"			"HudFontSmallBold"//"HudFontSmallestBorder"
				"xpos"			"0"
				"ypos"			"0"
				"zpos"			"6"
				"wide"			"55"
				"tall"			"33"
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"labelText"		"%respawntime%"
				"textAlignment"	"center"
				"fgcolor"		"255 0 0 255"
			}
			
			"chargeamount"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"chargeamount"
				"font"			"HudFontSmallBold"
				"xpos"			"5"
				"ypos"			"10"
				"zpos"			"6"
				"wide"			"35"
				"tall"			"15"
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"1"
				"labelText"		"%chargeamount%"
				"textAlignment"	"east"
				"fgcolor"		"0 255 0 255"
			}
			
			"specindex"
			{
				"ControlName"	"CExLabel"
				"fieldName"		"specindex"
				"font"			"DefaultVerySmall"
				"xpos"			"4"
				"ypos"			"3"
				"zpos"			"5"
				"wide"			"50"
				"tall"			"8"
				"autoResize"	"0"
				"pinCorner"		"0"
				"visible"		"0"
				"labelText"		"%specindex%"
				"textAlignment"	"north-west"
				//"fgcolor"		"235 226 202 255"
			}
		}
	}
	"topbar"
	{
		"ControlName"		"Panel"
		"fieldName"		"TopBar"
		"xpos"			"0"
		"ypos"			"0"
		"tall"			"28"
		"wide"			"0"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"		"0"
	}
	"BottomBar"
	{
		"ControlName"	"Frame"
		"fieldName"		"BottomBar"
		"xpos"			"0"
		"ypos"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"		"0"
	}
	"bottombarblank"
	{
		"ControlName"		"Panel"
		"fieldName"		"bottombarblank"
		"xpos"			"0"
		"ypos"			"r3"
		"tall"			"0"		// this needs to match the size of BottomBar
		"tall"			"0"	
		"wide"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"visible_minmode"		"0"
		"enabled"		"1"
		"tabPosition"		"0"
	}
	"ReinforcementsLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"ReinforcementsLabel"
		"xpos"			"c94"
		"ypos"			"23"//"18"
		"wide"			"600"
		"tall"			"18"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"#game_respawntime_in_secs"
		"textAlignment"		"west"
		"font"			"HudFontMediumSmallSecondary"
		"fgcolor"		"0 255 0 255"
	}
	"MapLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"MapLabel"
		"visible"		"0"
	}
	"ClassOrTeamLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"ClassOrTeamLabel"
		"visible"		"0"
	}
	"SwitchCamModeKeyLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"SwitchCamModeKeyLabel"
		"visible"		"0"
		
	}
	"SwitchCamModeLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"SwitchCamModeLabel"
		"visible"		"0"
	}
	"CycleTargetFwdKeyLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"CycleTargetFwdKeyLabel"
		"visible"		"0"
	}
	"CycleTargetFwdLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"CycleTargetFwdLabel"
		"visible"		"0"
	}
	"CycleTargetRevKeyLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"CycleTargetRevKeyLabel"
		"visible"		"0"
	}
	"CycleTargetRevLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"CycleTargetRevLabel"
		"visible"		"0"
	}
	"TipLabel"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"TipLabel"
		"visible"		"0"
	}
	"itempanel"
	{
		"ControlName"	"CItemModelPanel"
		"fieldName"		"itempanel"
		"xpos"			"r270"
		"ypos"			"300"
		"zpos"			"1"
		"wide"			"270"
		"tall"			"180"
		"visible"		"0"
		"bgcolor_override"		"255 255 255 0"
		"PaintBackgroundType"	"0"
		
		"model_xpos"		"10"
		"model_center_y"	"1"
		"model_wide"		"90"
		"model_tall"		"55"
		
		"text_xpos"		"90"
		"text_wide"		"170"
		"text_center"	"1"
		
		"max_text_height"	"90"
		"padding_height"	"40"
		"resize_to_text"	"1"
		"text_forcesize"	"2"
		
		"itemmodelpanel"
		{
			"fieldName"		"itemmodelpanel"
			"use_item_rendertarget" "1"
			"useparentbg"		"1"
		}
		
		"ItemLabel"
		{	
			"ControlName"	"Label"
			"fieldName"		"ItemLabel"
			"font"			"DefaultSmall"
			"xpos"			"10"
			"ypos"			"3"
			"zpos"			"1"
			"wide"			"270"
			"tall"			"9"
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"labelText"		"#FreezePanel_Item"
			"textAlignment"	"Left"
			"dulltext"		"0"
			"brighttext"	"0"
		}
		
		"attriblabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"attriblabel"
			"font"			"ItemFontAttribLarge"
			"xpos"			"0"
			"ypos"			"30"
			"zpos"			"2"
			"wide"			"140"
			"tall"			"60"
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"labelText"		"%attriblist%"
			"textAlignment"	"south"
			"fgcolor"		"235 226 202 255"
			"centerwrap"	"1"
		}
	}			
}

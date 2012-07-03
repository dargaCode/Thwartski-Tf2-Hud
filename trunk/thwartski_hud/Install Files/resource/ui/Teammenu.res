//Layout based on CommunityHUD
//Button mouseover and click behavior from EVE

"Resource/UI/TeamMenu.res"
{
	"team"
	{
		"ControlName"	"CTeamMenu"
		"fieldName"		"team"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"f0"
		"tall"			"480"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
	}

	"SysMenu"
	{
		"ControlName"	"Menu"
		"fieldName"		"SysMenu"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
	}

	"MapInfo"
	{
		"ControlName"	"HTML"
		"fieldName"		"MapInfo"
		"xpos"			"100"
		"ypos"			"34"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"3"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"
	}

	"mapname"
	{
		"ControlName"	"Label"
		"fieldName"		"mapname"
		"xpos"			"c-256"
		"ypos"			"150"
		"wide"			"500"
		"tall"			"24"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		""
		"textAlignment"	"center"
		"dulltext"		"0"
		"font"			"HudFontMediumSmall"
		"brighttext"	"1"
	}
	
	"BGThwartski"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"BGThwartski"
		"xpos"			"c-52"
		"ypos"			"c-52"
		"zpos"			"0"
		"wide"			"104"
		"tall"			"104"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"	
		"fillcolor"		"54 51 52 255"
		"PaintBackgroundType"	"0"
	}
	
	
	"teambutton0"
	{
		"ControlName"	"CTFTeamButton"
		"fieldName"		"teambutton0"
		"xpos"			"c-52"
		"ypos"			"c-26"
		"zpos"			"10"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"3"
		"labelText"		"&3"
		"textAlignment"	"west"
		"dulltext"		"0"
		"brighttext"	"0"
		"paintborder"	"1"
		"command"		"jointeam blue"
		"team"				"3"		// team blue
		"associated_model"	""
		"hover"				""
		"font"			"Hud"
		"fgcolor"		"0 0 0 0"

		"defaultFgColor_override" 		"255 255 255 255"
		"defaultbgcolor_override"		"88 133 162 0"
		"armedbgcolor_override"			"88 133 162 200"
		"armedFgColor_override" 		"255 255 255 255"
		"depressedbgcolor_override"		"92 113 132 0"
		"depressedfgColor_override" 		"255 255 255 255"
		
		"sound_armed"				"ui/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"

	}
	
	"BluText"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"BluText"
		"xpos"			"c-52"
		"ypos"			"c-17"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"3"
		"labelText"		"BLU"
		"textAlignment"	"North"
		"font"			"HudFontSmallBold"
		"fgcolor"		"255 255 255 255"
	}

	"teambutton1"
	{
		"ControlName"	"CTFTeamButton"
		"fieldName"		"teambutton1"
		"xpos"			"c"
		"ypos"			"c-26"
		"zpos"			"5"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"4"
		"labelText"		"&4"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"0"
		"paintborder"	"0"
		"command"		"jointeam red"
		"team"				"2"		// team red
		"associated_model"	""	
		"hover"				""
		"font"			"Hud"
		"fgcolor"		"0 0 0 0"

		"defaultFgColor_override" 		"184 56 59 0"
		"defaultbgcolor_override"		"184 56 59 0"
		"armedbgcolor_override"			"184 56 59 200"
		"armedFgColor_override" 		"255 255 255 255"
		
		"sound_armed"				"ui/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"

	}
	
	"RedText"
	{
		"ControlName"		"CExLabel"
		"fieldName"		"RedText"
		"xpos"			"c"
		"ypos"			"c-17"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"3"
		"labelText"		"RED"
		"textAlignment"	"north"
		"font"			"HudFontSmallBold"
		"fgcolor"		"255 255 255 255"
	}


	"teambutton2"
	{
		"ControlName"		"CTFTeamButton"
		"fieldName"		"teambutton2"
		"xpos"			"c-52"
		"ypos"			"c-52"
		"zpos"			"5"
		"wide"			"104"
		"tall"			"26"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"1"
		"labelText"		"RANDOM"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"0"
		"paintborder"	"0"
		"command"		"jointeam auto"
		"associated_model"	"RandomFrame"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 255"

		"defaultFgColor_override" 		"255 255 255 255"
		"defaultbgcolor_override"		"50 50 50 0"		
		"armedbgcolor_override"			"60 60 60 255"		
		"armedFgColor_override" 		"255 255 255 255"

		"sound_armed"				"ui/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"


	}
	
	"RandomText"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"RandomText"
		"xpos"			"c-52"
		"ypos"			"c-65"
		"zpos"			"4"
		"wide"			"104"
		"tall"			"52"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"		"1"
		"textAlignment"		"center"
		"labelText"		"RANDOM"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 255"
	}
	
	"teambutton3"
	{
		"ControlName"	"CTFTeamButton"
		"fieldName"		"teambutton3"
		"xpos"			"c-52"
		"ypos"			"c26"
		"zpos"			"5"
		"wide"			"104"
		"tall"			"26"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"2"
		"labelText"		"SPECTATE"	
		"textAlignment"		"center"
		"dulltext"		"0"
		"brighttext"	"0"
		"paintborder"	"0"
		"command"		"jointeam spectate"
		"associated_model"	"SpectateFrame"	
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 255"

		"defaultFgColor_override" 		"255 255 255 255"
		"defaultbgcolor_override"		"50 50 50 0"	
		"armedbgcolor_override"			"60 60 60 255"		
		"armedFgColor_override" 		"255 255 255 255"
		"depressedbgcolor_override"		"40 40 40 255"
		"depressedfgColor_override" 		"255 255 255 255"

		"sound_armed"				"ui/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"


	}
	"SpecText"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"SpecText"
		"xpos"			"c-25"
		"ypos"			"c+34"
		"zpos"			"4"
		"wide"			"50"
		"tall"			"10"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"	"2"
		"labelText"		"SPECTATE"
		"textAlignment"	"center"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 255"
	}
	
	"CancelButton"
	{
		"ControlName"		"CExButton"
		"fieldName"		"CancelButton"
		"xpos"			"c-88"
		"ypos"			"c-88"
		"zpos"			"1"
		"wide"			"0"//"176"
		"tall"			"0"//"176"
		"autoResize"		"0"
		"pinCorner"		"2"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"		"1"
		"labelText"		"#TF_Cancel"
		"textAlignment"		"south"
		"dulltext"		"0"
		"brighttext"		"0"
		"command"		"cancelmenu"
		"font"			"HudFontSmallest"

		"defaultFgColor_override" 		"255 255 255 255"
		//"defaultbgcolor_override"		"60 60 60 255"
		"armedbgcolor_override"			"90 90 90 255"
		"armedFgColor_override" 		"255 255 255 255"
		//"depressedbgcolor_override"		"50 50 50 255"
		//"depressedfgColor_override" 		"255 255 255 255"

		"sound_armed"				"ui/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"


	}
	
	"TeamMenuSelect"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"TeamMenuSelect"
		"xpos"			"30"
		"ypos"			"r40"
		"zpos"			"6"
		"wide"			"0"
		"tall"			""
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"#TF_SelectATeam"
		"textAlignment"	"west"
		"dulltext"		"0"
		"brighttext"	"0"
		"font"			"MenuMainTitle"
		"fgcolor"		"HudOffWhite"
	}
	
	"TeamMenuAuto"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"TeamMenuAuto"
		"xpos"			"c20"
		"ypos"			"c-36"
		"zpos"			"4"
		"wide"			"100"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"UNUSED"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"0"
		"wrap"			"0"
		"font"			"default"
		"fgcolor"		"White"
	}
	
	"TeamMenuSpectate"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"TeamMenuSpectate"
		"xpos"			"c20"
		"ypos"			"c-17"
		"zpos"			"4"
		"wide"			"100"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"UNUSED"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"0"
		"wrap"			"0"
		"font"			"default"
		"fgcolor"		"white"
	}

	"MenuBG"
	{
		"ControlName"	"CModelPanel"
		"fieldName"		"MenuBG"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"0"		
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"fov"			"20"
		
		"model"
		{
			"modelname"	"models/vgui/UI_team01.mdl"
			"skin"		"0"
			"angles_x" "0"
			"angles_y" "180"
			"angles_z" "0"
			"origin_x" "290"
			"origin_y" "0"
			"origin_z" "-34"
		}
	}	
	
	"ShadedBar"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"ShadedBar"
		"xpos"			"0"
		"ypos"			"r50"
		"zpos"			"5"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"	
		"fillcolor"		"0 0 0 180"
		"PaintBackgroundType"	"0"
	}		
	
	"BlueCount"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"BlueCount"
		"xpos"			"c-52"
		"ypos"			"c-16"
		"zpos"			"4"
		"wide"			"52"
		"tall"			"52"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%bluecount%"
		"textAlignment"		"center"
		"dulltext"		"0"
		"brighttext"		"1"
		"font"			"HudFontSmallBold"
		"fgcolor"		"White"
	}		
	
	"RedCount"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"RedCount"
		"xpos"			"c"
		"ypos"			"c-16"
		"zpos"			"4"
		"wide"			"52"
		"tall"			"52"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%redcount%"
		"textAlignment"		"center"
		"dulltext"		"0"
		"brighttext"		"1"
		"font"			"HudFontSmallBold"
		"fgcolor"		"White"
	}	

	"Blueframe"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"Blueframe"
		"xpos"			"c-52"
		"ypos"			"c-26"
		"zpos"			"2"		
		"wide"			"52"
		"tall"			"52"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"image"			"../hud/color_panel_blu"
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"

	}
	
	"Redframe"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"Redframe"		
		"xpos"			"c+0"
		"ypos"			"c-26"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"image"			"../hud/color_panel_red"
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}	
	
	"BlueLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"BlueLabel"
		"xpos"			"c"
		"ypos"			"c"
		"zpos"			"2"
		"wide"			"90"
		"tall"			"20"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		"Blu players:"
		"textAlignment"		"left"
		"dulltext"		"0"
		"brighttext"		"1"
		"font"			"rxpSmall"
		"fgcolor"		"White"
	}		
	
	"RedLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"RedLabel"
		"xpos"			"c"
		"ypos"			"c"
		"zpos"			"2"
		"wide"			"90"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		"Red players:"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"1"
		"font"			"default"
		"fgcolor"		"White"
	}	
	"BluePlayersLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"BluePlayersLabel"
		"xpos"			"c51"
		"ypos"			"c-2"
		"zpos"			"2"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		"players"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"1"
		"font"			"default"
		"fgcolor"		"White"
	}	
	
	"RedPlayersLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"RedPlayersLabel"
		"xpos"			"c160"
		"ypos"			"c-35"
		"zpos"			"2"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		"Players:"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"1"
		"font"			"default"
		"fgcolor"		"White"
	}
	
	"RandomFrame"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"RandomFrame"
		"xpos"			"c-52"
		"ypos"			"c-52"
		"zpos"			"2"		
		"wide"			"104"
		"tall"			"26"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"image"			"../hud/color_panel_brown"
		
		"src_corner_height"		"23"
		"src_corner_width"		"23"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}		
	
	"SpectateFrame"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"SpectateFrame"
		"xpos"			"c-52"
		"ypos"			"c+26"
		"zpos"			"2"
		"wide"			"104"
		"tall"			"26"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"

		"image"			"../hud/color_panel_brown"

		"src_corner_height"		"23"
		"src_corner_width"		"23"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
		
	}			
}


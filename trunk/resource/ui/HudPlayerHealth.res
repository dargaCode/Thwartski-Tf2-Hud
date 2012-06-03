//based on commhud, inspired by oxide

"Resource/UI/HudPlayerHealth.res"
{	
	// player health data
	"HudPlayerHealth"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"HudPlayerHealth"
		"xpos"			"c-368"//"c-368"	
		"ypos"			"r117"//"r114"	
		"zpos"			"2"
		"wide"			"400"//"400"
		"tall"			"120"
		"visible"		"1"
		"enabled"		"1"	
		"HealthBonusPosAdj"		"56"
		"HealthDeathWarning"	"0.55"
		"HealthDeathWarningColor"	"HUDDeathWarning"
	}	
	
	//health bar filling
	"PlayerStatusHealthImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImage"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
		"zpos"			"4"

		
		"xpos"			"90"
		"ypos"			"46"		
		"wide"			"44"
		"tall"			"44"
	

	}		
	
	//black background
	"PlayerStatusHealthImageBG"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImageBG"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_bg"
		"scaleImage"	"1"
		"zpos"			"3"

		
		"xpos"			"88"
		"ypos"			"44"
		"wide"			"48"
		"tall"			"48"		
	
	}	
	
	"PlayerStatusHealthBonusImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthBonusImage"
		"xpos"			"175"	
		"ypos"			"32"//"29"	
		"zpos"			"-2"
		"wide"			"57"	
		"tall"			"57"	
		"visible"		"0"
		"enabled"		"1"
		"image"			"../hud/health_over_bg"
		"scaleImage"	"1"	
	}
	"PlayerStatusHealthValuePovo"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"PlayerStatusHealthValuePovo"
		"xpos"			"124"
		"ypos"			"25"
		"zpos"			"5"
		"wide"			"160"
		"tall"			"70"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%Health%"
		"textAlignment"	"center"	
		"font"			"HudFontHuge"
		"fgcolor"		"White"
	}	
	"PlayerStatusHealthValueShadowPovo"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"PlayerStatusHealthValueShadowPovo"
		"xpos"			"126"
		"ypos"			"27"
		"zpos"			"4"
		"wide"			"160"
		"tall"			"70"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%Health%"
		"textAlignment"	"center"	
		"font"			"HudFontHuge"
		"fgcolor"		"Black"
	}		
	
	"VerticalTeamColorThwartski"
	{
		"ControlName"		"CTFImagePanel"
		"fieldName"		"VerticalTeamColorThwartski"
		"xpos"			"100"
		"ypos"			"41"
		"zpos"			"-1"
		"wide"			"24"
		"tall"	 		"54"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"		"1"
		"teambg_1"		"../hud/color_panel_brown"
		"teambg_2"		"../hud/color_panel_red"
		"teambg_3"		"../hud/color_panel_blu"
		
		"src_corner_height"		"40"
		"src_corner_width"		"40"			
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	
	"VerticalBlackBGThwartski"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"BlackCartBGThwartski"	
		"xpos"			"100"
		"ypos"			"41"
		"zpos"			"-2"
		"wide"			"24"
		"tall"	 		"54"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		""
		"scaleImage"	"1"
		"image"			""
		"fillcolor"		"0 0 0 255"
	}
	
	"HorizontalTeamColorThwartski"
	{
		"ControlName"		"CTFImagePanel"
		"fieldName"		"HorizontalTeamColorThwartski"
		"xpos"			"85"
		"ypos"			"56"
		"zpos"			"-3"
		"wide"			"54"
		"tall"	 		"24"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"		"1"
		"teambg_1"		"../hud/color_panel_brown"
		"teambg_2"		"../hud/color_panel_red"
		"teambg_3"		"../hud/color_panel_blu"
		
		"src_corner_height"		"40"
		"src_corner_width"		"40"			
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}

	"HorizontalBlackBGThwartski"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"HorizontalBlackBGThwartski"	
		"xpos"			"85"
		"ypos"			"56"
		"zpos"			"-4"
		"wide"			"54"
		"tall"	 		"24"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		""
		"scaleImage"	"1"
		"image"			""
		"fillcolor"		"0 0 0 255"
	}
	
	"PlayerStatusBleedImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusBleedImage"
		"xpos"			"70"//"96"
		"ypos"			"48"//"0"
		"zpos"			"7"
		"wide"			"32"
		"tall"			"32"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
		"image"			"../vgui/bleed_drop"
		"fgcolor"		"TanDark"
	}	
	"PlayerStatusMilkImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusMilkImage"
		"xpos"			"70"//"96"
		"ypos"			"48"//"0"
		"zpos"			"7"
		"wide"			"32"
		"tall"			"32"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
		"image"			"../vgui/bleed_drop"
		"fgcolor"		"TanDark"
	}
	"PlayerStatusMarkedForDeathImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusMarkedForDeathImage"
		"xpos"			"70"//"96"
		"ypos"			"48"//"0"
		"zpos"			"7"
		"wide"			"32"
		"tall"			"32"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
		"image"			"../vgui/marked_for_death"
		"fgcolor"		"TanDark"
	}
}

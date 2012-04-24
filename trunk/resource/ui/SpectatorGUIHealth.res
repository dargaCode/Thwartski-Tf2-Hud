//based on Commhud

"Resource/UI/SpectatorGUIHealth.res"
{
	"PlayerStatusHealthImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImage"
		"xpos"			"15"
		"ypos"			"17"
		"zpos"			"4"
		"wide"			"16"
		"tall"			"16"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
	}		
	"PlayerStatusHealthImageBG"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImageBG"
		"xpos"			"13"
		"ypos"			"15"
		"zpos"			"3"
		"wide"			"20"//"15"
		"tall"			"20"//"15"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_bg"
		"scaleImage"	"1"	
	}	
	
	//extends cross bg to the right
	"HealthImageThwartski1"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"HealthImageThwartski1"
		"xpos"			"19"
		"ypos"			"15"
		"zpos"			"3"
		"wide"			"20"//"15"
		"tall"			"20"//"15"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_bg"
		"scaleImage"	"1"	
	}	
	//covers up the right arm of health cross
	"HealthImageThwartski2"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"HealthImageThwartski2"
		"xpos"			"25"
		"ypos"			"15"
		"zpos"			"5"
		"wide"			"20"//"15"
		"tall"			"20"//"15"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_bg"
		"scaleImage"	"1"	
	}	
	
	"BuildingStatusHealthImageBG"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"BuildingStatusHealthImageBG"
		"xpos"			"4"
		"ypos"			"5"
		"zpos"			"2"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"0"
		"image"			"../hud/health_equip_bg"
		"scaleImage"	"1"	
	}	
	"PlayerStatusHealthBonusImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthBonusImage"
		"xpos"			"13"
		"ypos"			"15"
		"zpos"			"0"
		"wide"			"20"
		"tall"			"20"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_over_bg"
		"scaleImage"	"1"	
	}
	"PlayerStatusHealthValue"
	{	
		"ControlName"		"Label"
		"fieldName"		"PlayerStatusHealthValue"
		"xpos"			"30"
		"ypos"			"24"
		"zpos"			"10"
		"wide"			"30"
		"tall"			"10"
		"visible"		"1"
		"enabled"		"1"
		"labeltext"		"%Health%"
		"textAlignment"		"west"
		"font"			"hudfontsmallestbold"
		"fgcolor"		"0 0 0 255"
	}	

	"BlackBGThwartski"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"BlackBGThwartski"
		"xpos"			"26"
		"ypos"			"15"
		"zpos"			"7"
		"wide"			"26"
		"tall"	 		"20"
		"autoResize"		"1"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"fillcolor"		"0 0 0 255"
		"PaintBackgroundType"	"0"
	}
	
	"TeamBGThwartski"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"TeamBGThwartski"
		"xpos"			"26"
		"ypos"			"24"
		"zpos"			"9"
		"wide"			"29"
		"tall"	 		"11"
		"autoResize"		"1"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"		"1"
		"teambg_1"		"../hud/color_panel_brown"
		"teambg_2"		"../hud/color_panel_red"
		"teambg_2_lodef"	"../hud/color_panel_red"
		"teambg_3"		"../hud/color_panel_blu"
		"teambg_3_lodef"	"../hud/color_panel_blu"
		
		"src_corner_height"		"40"			// pixels inside the image
		"src_corner_width"		"40"			
		"draw_corner_width"		"0"			// screen size of the corners ( and sides ), proportional
		"draw_corner_height" 		"0"		
	}	
}

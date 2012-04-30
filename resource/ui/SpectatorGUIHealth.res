//based on Commhud

"Resource/UI/SpectatorGUIHealth.res"
{

	"BlackBGThwartski"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"BlackBGThwartski"
		"xpos"			"26"
		"ypos"			"15"
		"zpos"			"7"
		"wide"			"29"
		"tall"	 		"30"
		"autoResize"		"1"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"fillcolor"		"0 0 0 255"
		"PaintBackgroundType"	"0"
	}
	
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
	
	"CrossCoverupThwartski"
	{
		"ControlName"		"Imagepanel"
		"fieldName"			"CrossCoverupThwartski"
		"xpos"				"25"
		"ypos"				"15"
		"zpos"				"5"
		"wide"				"80"
		"tall"				"20"
		"visible"			"1"
		"enabled"			"1"
		"scaleImage"		"1"	
		"fillcolor"			"54 51 52 255"
		
		"src_corner_height"		"90"//"23"
		"src_corner_width"		"90"//"23"
		
		"draw_corner_width"		"0"//"6"
		"draw_corner_height" 	"0"//"6"	
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
		"ypos"			"15"
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


}

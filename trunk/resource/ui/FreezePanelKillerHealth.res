//based on eve hud

"Resource/UI/FreezePanelKillerHealth.res"
{
	"PlayerStatusHealthImage"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImage"
		"xpos"			"8"
		"ypos"			"8"
		"zpos"			"4"
		"wide"			"24"//"13"
		"tall"			"24"//"13"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
	}		
	"PlayerStatusHealthImageBG"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthImageBG"
		"xpos"			"5"
		"ypos"			"5"
		"zpos"			"3"
		"wide"			"30"//"15"
		"tall"			"30"//"15"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/health_bg"
		"scaleImage"	"1"	
	}	
	"BuildingStatusHealthImageBG"  //gears behind sentry guns
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"BuildingStatusHealthImageBG"
		"xpos"			"3"
		"ypos"			"2"
		"zpos"			"2"
		"wide"			"0"//"19"
		"tall"			"0"//"19"
		"visible"		"0"
		"enabled"		"1"
		"image"			"../hud/health_equip_bg"
		"scaleImage"	"1"	
	}	
	"PlayerStatusHealthBonusImage" //overheal and damage highlight
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"PlayerStatusHealthBonusImage"
		"xpos"			"5"
		"ypos"			"5"
		"zpos"			"3"
		"wide"			"30"//"13"
		"tall"			"30"//"13"
		"visible"		"0"
		"enabled"		"1"
		"image"			"../hud/health_over_bg"
		"scaleImage"	"1"	
	}
	"PlayerStatusHealthValue"
	{	
		"ControlName"	"CExLabel"
		"fieldName"		"PlayerStatusHealthValue"
		"xpos"			"28"
		"ypos"			"26"
		"zpos"			"6"
		"wide"			"35"
		"tall"			"10"
		"visible"		"1"
		"enabled"		"1"
		"labeltext"		"%Health%"
		"textAlignment"	"west"
		"font"			"hudfontsmallestbold"
		"fgcolor"		"white"
	}	
	"PlayerStatusHealthValueShadow"
	{	
		"ControlName"	"CExLabel"
		"fieldName"		"PlayerStatusHealthValueShadow"
		"xpos"			"29"
		"ypos"			"27"
		"zpos"			"5"
		"wide"			"35"
		"tall"			"10"
		"visible"		"1"
		"enabled"		"1"
		"fgcolor"		"Black"
		"labeltext"		"%Health%"
		"textAlignment"	"west"
		"font"			"hudfontsmallestbold"		
	}		
}

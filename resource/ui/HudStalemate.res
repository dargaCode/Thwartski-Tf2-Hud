"Resource/UI/HudStalemate.res"

//This is actually sudden death, not stalemate.
{
	"HudStalemateBG"
	{
		"ControlName"		"CTFImagePanel"
		"fieldName"		"HudStalemateBG"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"-1"
		"wide"			"160"
		"tall"			"41"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/death_panel_black_bg"
		"scaleImage"		"1"
		
		"src_corner_height"		"40"
		"src_corner_width"		"40"			
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"
	}
	"StalemateLabel"
	{	
		"ControlName"		"Label"
		"fieldName"		"StalemateLabel"
		"font"			"HudFontMediumSmall"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"1"
		"wide"			"160"
		"tall"			"41"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"wrap"			"0"
		"labelText"		"Sudden Death!"
		"textAlignment"	"center"
	}
	"ReasonLabel"
	{	
		"ControlName"		"Label"
		"fieldName"		"ReasonLabel"
		"font"			"HudFontSmall"
		"xpos"			"25"
		"ypos"			"34"
		"zpos"			"1"
		"wide"			"280"
		"tall"			"55"
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"wrap"			"1"
		"labelText"		""
		"textAlignment"		"northwest"
	}
}

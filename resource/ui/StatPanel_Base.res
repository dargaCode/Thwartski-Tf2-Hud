"Resource/UI/StatPanel_PlayTime.res"
{
	"StatPanelBG"
	{
		"ControlName"		"CTFImagePanel"
		"fieldName"		"StatPanelBG"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"-1"
		"wide"			"190"
		"tall"			"46"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/death_panel_blue_bg"
		"scaleImage"		"1"	
		"teambg_2"		"../hud/death_panel_red_bg"
		"teambg_3"		"../hud/death_panel_blue_bg"
		
		"src_corner_height"		"40"
		"src_corner_width"		"40"			
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"
		
	}
	"StatPanelClassImage"
	{
		"ControlName"		"ImagePanel"
		"fieldName"		"StatPanelClassImage"
		"xpos"			"0"
		"ypos"			"2"
		"zpos"			"1"
		"wide"			"44"
		"tall"			"44"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/class_scoutred"
		"scaleImage"		"1"	
	}
	
	//Well that was impressive:"
	"titleLable"
	{	
		"ControlName"	"Label"
		"fieldName"		"titleLable"
		"font"			"TFFontSmall"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"2"
		"wide"			"110"
		"tall"			"10"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"%title%"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"0"
	}
	
	//You came close to your record for [stat] as [class] that round:"
	"summaryLabel"
	{	
		"ControlName"	"Label"
		"fieldName"		"summaryLabel"
		"font"			"TFFontMedium"
		"xpos"			"48"
		"ypos"			"3"
		"zpos"			"2"
		"wide"			"148"
		"tall"			"40"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%statdesc%"
		"textAlignment"		"north-west"
		"dulltext"		"0"
		"brighttext"		"0"
		"wrap"			"1"
	}
	
	//That round: x Your best: y"
	"StatLabelLarge"
	{	
		"ControlName"		"Label"
		"fieldName"		"StatLabelLarge"
		"font"			"HudFontMedium"
		"xpos"			"48"
		"ypos"			"33"
		"zpos"			"3"
		"wide"			"148"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%stattextlarge%"
		"textAlignment"		"north-west"
		"dulltext"		"0"
		"brighttext"		"0"
	}
	"StatLabelSmall"
	{	
		"ControlName"	"Label"
		"fieldName"		"StatLabelSmall"
		"font"			"TFFontMedium"
		"xpos"			"48"
		"ypos"			"33"
		"zpos"			"3"
		"wide"			"148"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%stattextsmall%"
		"textAlignment"	"north-west"
		"dulltext"		"0"
		"brighttext"	"0"
	}
	StatBox
	{
		"ControlName"	"Panel"		
		"fieldName"		"StatBox"
		"visible"		"0"
		"enabled"		"1"
		"pinCorner"		"0"
		"xpos"			"72"
		"ypos"			"77"
		"zpos"			"3"
		"wide"			"175"
		"tall"			"20"
		"PaintBackgroundType"	"2"
	}
}

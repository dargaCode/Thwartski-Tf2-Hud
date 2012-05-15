//based on EVE and inspired by Comm

"Resource/UI/HudDamageAccount.res"
{
	"CDamageAccountPanel"
	{
		"fieldName"				"CDamageAccountPanel"
		"text_x"				"0"
		"text_y"				"0"
		"delta_item_end_y"		"0"
		"PositiveColor"			"0 255 0 255"
		"NegativeColor"			"255 165 0 255"		//orange
		"delta_lifetime"		"1.5"
		"delta_item_font"		"HudFontSmallish"		
		"delta_item_font_big"	"HudFontMedium"	
		"visible"				"1"
		"visible_minmode"		"1"
	}
	
	"DamageAccountValueEve"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"DamageAccountValueEve"
		"xpos"			"c-289"
		"ypos"			"r108"
		"zpos"			"2"
		"wide"			"100"
		"tall"			"26"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%metal%"
		"textAlignment"	"east"
		"fgcolor"		"255 165 0 255"		//orange
		"font"			"HudFontBiggerBold"
	}	
	"DamageAccountValueShadowEve"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"DamageAccountValueShadowEve"
		"xpos"			"c-287"
		"ypos"			"r106"
		"zpos"			"1"
		"wide"			"100"
		"tall"			"26"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%metal%"
		"textAlignment"	"east"
		"fgcolor"		"0 0 0 255"
		"font"			"HudFontBiggerBold"
	}
}
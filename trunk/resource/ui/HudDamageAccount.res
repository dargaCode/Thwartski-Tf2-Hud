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
		"xpos"			"c-215"
		"xpos_minmode"	"c135"
		"ypos"			"r150"
		"ypos_minmode"	"c95"
		"zpos"			"2"
		"wide"			"100"
		"tall"			"26"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%metal%"
		"textAlignment"	"center"
		"fgcolor"		"255 165 0 255"		//orange
		"font"			"HudFontBiggerBold"
	}	
	"DamageAccountValueShadowEve"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"DamageAccountValueShadowEve"
		"xpos"			"c-213"
		"xpos_minmode"	"c137"
		"ypos"			"r148"
		"ypos_minmode"	"c97"
		"zpos"			"1"
		"wide"			"100"
		"tall"			"26"
		"visible"		"1"
		"enabled"		"1"
		"labelText"		"%metal%"
		"textAlignment"	"center"
		"fgcolor"		"0 0 0 255"
		"font"			"HudFontBiggerBold"
	}
}
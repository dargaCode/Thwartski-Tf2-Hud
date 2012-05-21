//based on commhud

"Resource/UI/HudMedicCharge.res"
{	
	"Background"
	{
		"ControlName"		"CTFImagePanel"
		"fieldName"		"Background"
		"xpos"			"2"
		"ypos"			"71"
		"zpos"			"-1"
		"wide"			"98"
		"tall"	 		"12"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
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
	"ChargeLabelPercentThwartski"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"ChargeLabelPercentThwartski"
		"font"			"HudFontMediumSmallBold"
		"xpos"			"122"
		"ypos"			"24"
		"zpos"			"6"
		"wide"			"50"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"#TF_UberchargeMinHUD"//"#TF_Ubercharge"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"1"
		"fgcolor" 	"0 255 0 255"
	}
	"ChargeLabelPercentShadowThwartski"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"ChargeLabelPercentShadowThwartski"
		"font"			"HudFontMediumSmallBold"
		"xpos"			"123"
		"ypos"			"25"
		"zpos"			"6"
		"wide"			"50"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"#TF_UberchargeMinHUD"//"#TF_Ubercharge"
		"textAlignment"	"left"
		"dulltext"		"0"
		"brighttext"	"1"
		"fgcolor" 	"0 0 0 255"
	}
	"UberLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"UberLabel"
		"font"			"HudFontMediumSmallBold"
		"xpos"			"0"
		"ypos"			"200"
		"zpos"			"6"
		"wide"			"200"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"Ubercharge"//"#TF_Ubercharge"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"1"
		"fgcolor" 	"0 0 0 100"
	}

	"ChargeMeter"
	{	
		"ControlName"	"ContinuousProgressBar"
		"fieldName"		"ChargeMeter"
		"font"			"Default"
		"xpos"			"0"
		"ypos"			"210"
		"zpos"			"3"
		"wide"			"200"
		"tall"			"20"			
		"autoResize"	"1"
		"pinCorner"		"1"
		"visible"		"1"
		"enabled"		"1"
		"textAlignment"	"Left"
		"dulltext"		"0"
		"brighttext"	"1"
	}		
	
	"HealthClusterIcon"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"HealthClusterIcon"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"20"
		"tall"			"20"
		"visible"		"0"
		"enabled"		"1"
		"image"			"../hud/ico_health_cluster"
		"scaleImage"	"1"	
	}		
}

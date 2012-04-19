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
		"autoResize"		"0"
		"pinCorner"		"0"
		"visible"		"0"
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
	"ChargeLabelPercent"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"ChargeLabelPercent"
		"font"			"HudFontMediumSmallBold"
		"font_minmode"			"HudFontGiantBold"
		"xpos"			"0"
		"xpos_minmode"			"4"
		"ypos"			"60"
		"ypos_minmode"			"37"
		"zpos"			"6"
		"wide"			"200"
		"wide_minmode"		"100"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"#TF_UberchargeMinHUD"//"#TF_Ubercharge"
		"labelText_minmode"	"#TF_UberchargeMinHUD"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"1"
		"fgcolor" 	"0 255 0 255"
	}
	"ChargeLabelPercentShadow"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"ChargeLabelPercentShadow"
		"font"			"HudFontMediumSmallBold"
		"font_minmode"			"HudFontGiantBold"
		"xpos"			"1"
		"xpos_minmode"			"4"
		"ypos"			"61"
		"ypos_minmode"			"37"
		"zpos"			"6"
		"wide"			"200"
		"wide_minmode"		"100"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"#TF_UberchargeMinHUD"//"#TF_Ubercharge"
		"labelText_minmode"	"#TF_UberchargeMinHUD"
		"textAlignment"	"center"
		"dulltext"		"0"
		"brighttext"	"1"
		"fgcolor" 	"0 0 0 255"
	}
	"UberLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"UberLabel"
		"font"			"HudFontMediumSmallBold"
		"font_minmode"			"HudFontGiantBold"
		"xpos"			"0"
		"xpos_minmode"			"4"
		"ypos"			"198"
		"ypos_minmode"			"37"
		"zpos"			"6"
		"wide"			"200"
		"wide_minmode"		"100"
		"tall"			"40"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"5"
		"labelText"		"Ubercharge"//"#TF_Ubercharge"
		"labelText_minmode"	"#TF_UberchargeMinHUD"
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
		"xpos_minmode"			"3"
		"ypos"			"208"
		"ypos_minmode"			"72"
		"zpos"			"3"
		"wide"			"200"
		"wide_minmode"			"96"
		"tall"			"20"
		"tall_minmode"			"10"				
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
		"visible_minmode"		"0"
		"enabled"		"1"
		"image"			"../hud/ico_health_cluster"
		"scaleImage"	"1"	
	}		
}

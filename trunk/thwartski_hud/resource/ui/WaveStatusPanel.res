"Resource/UI/WaveStatusPanel.res"
{
	"Background"
	{
		"ControlName"	"ScalableImagePanel"
		"fieldName"		"Background"
		"xpos"			"100"
		"ypos"			"0"
		"zpos"			"-1"
		"wide"			"230"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_brown"

		"src_corner_height"	"40"
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"
		"draw_corner_height" "0"	
	}
	
	"BackgroundThwartski" 
	{
		"ControlName"	"ScalableImagePanel"
		"fieldName"		"BackgroundThwartski"
		"xpos"			"100"
		"ypos"			"0"
		"zpos"			"-1"
		"wide"			"230"
		"tall"			"14"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_brown"

		"src_corner_height"	"40"
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"
		"draw_corner_height" "0"	
	}
	
	
	"WaveCountLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"WaveCountLabel"
		"font"			"HudFontSmallestBold"
		"fgcolor"		"TanLight"
		"xpos"			"227"
		"ypos"			"0"
		"zpos"			"3"
		"wide"			"100"
		"tall"			"13"
		"visible"		"1"
		"enabled"		"1"
		"textAlignment"	"east"
		"labelText"		"%wave_count%"
	}
	
	"ProgressBarBG"
	{
		"ControlName"	"ScalableImagePanel"
		"fieldName"		"ProgressBarBG"
		"xpos"			"100"
		"ypos"			"0"
		"zpos"			"2"
		"wide"			"200"
		"tall"			"14"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_tan"
		
		"src_corner_height"	"40"				
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"				
		"draw_corner_height" "0"
	}
	
	"ProgressBar"
	{
		"ControlName"	"ScalableImagePanel"
		"fieldName"		"ProgressBar"
		"xpos"			"100"
		"ypos"			"0"
		"zpos"			"3"
		"wide"			"200"
		"tall"			"14"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_blu"
		
		"src_corner_height"	"40"				
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"				
		"draw_corner_height" "0"	
	}
	
	"SeparatorBar"
	{
		"ControlName"	"Panel"
		"fieldName"		"SeparatorBar"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"3"
		"wide"			"1"
		"tall"			"30"
		"visible"		"0"
		"enabled"		"1"
		"scaleImage"	"1"
		"PaintBackgroundType" "2"
		"bgcolor_override"	"TanLight"
		
		if_verbose
		{
			"visible"		"1"
		}
	}
	
	"SupportLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"SupportLabel"
		"font"			"HudFontSmallestBold"
		"fgcolor"		"TanLight"
		"xpos"			"55"
		"ypos"			"6"
		"zpos"			"3"
		"wide"			"60"
		"tall"			"15"
		"visible"		"0"
		"enabled"		"1"
		"textAlignment"				"west"
		"labelText"					"#TF_MVM_Support"
		
		if_verbose
		{
			"visible"		"1"
		}		
	}
	

}
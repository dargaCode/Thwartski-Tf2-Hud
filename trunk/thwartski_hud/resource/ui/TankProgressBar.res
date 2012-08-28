"Resource/UI/TankProgressBar.res"
{
	"TankProgressBar"
	{
		"ControlName"	"CTankProgressBar"
		"fieldName"		"TankProgressBar"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"3"
		"wide"			"400"
		"tall"			"18"
		"visible"		"0"
		"enabled"		"1"	
	}

	"TankImage"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"TankImage"
		"xpos"			"300"
		"ypos"			"-2"
		"zpos"			"3"
		"wide"			"20"
		"tall"			"18"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/leaderboard_class_tank"
		"scaleImage"	"1"
	}

	"ProgressBar"
	{
		"ControlName"		"ScalableImagePanel"
		"fieldName"		"ProgressBar"
		"xpos"			"95"
		"ypos"			"0"
		"zpos"			"1"
		"wide"			"199"
		"tall"			"14"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_blu"
		
		"src_corner_height"	"40"				
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"				
		"draw_corner_height" "0"	
	}
	
	"ProgressBarBG"
	{
		"ControlName"		"ScalableImagePanel"
		"fieldName"		"ProgressBarBG"
		"xpos"			"95"
		"ypos"			"0"
		"zpos"			"0"
		"wide"			"199"
		"tall"			"14"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../HUD/tournament_panel_tan"
		
		"src_corner_height"	"40"				
		"src_corner_width"	"40"
	
		"draw_corner_width"	"0"				
		"draw_corner_height" "0"	
	}
}

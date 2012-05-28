//Based on EVE hud

"Resource/UI/ClassSelection.res"
{ 
	
	"MainBG"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"MainBG"
		"xpos"			"c-84"
		"ypos"			"c-91"
		"zpos"			"1"
		"wide"			"168"
		"tall"			"175"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_blu"
		"scaleImage"			"1"	
		"teambg_1"		"../hud/color_panel_blu"
		"teambg_2"		"../hud/color_panel_red"
		"teambg_3"		"../hud/color_panel_blu"
		
		"src_corner_height"		"20"
		"src_corner_width"		"20"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"
	}

	"BackgroundThwartski"
	{
		"ControlName"	"Imagepanel"
		"fieldName"		"BackgroundThwartski"
		"xpos"			"c-84"
		"ypos"			"c-91"
		"zpos"			"1"
		"wide"			"168"
		"tall"			"175"
		"visible"		"1"
		"enabled"		"1"
		"scaleImage"	"1"	
		"fillcolor"		"0 0 0 255"	
	}
	
	"CancelButton"
	{
		"ControlName"	"CExButton"
		"fieldName"		"CancelButton"
		"xpos"			"c-120"
		"ypos"			"c-120"
		"zpos"			"-1"
		"wide"			"0"//"240" //"276"
		"tall"			"0"//"240" //"276"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_Cancel"
		"textAlignment"		"south"
		"Command"		"vguicancel"
		"font"			"HudFontSmallest"
		
		"defaultFgColor_override" 		"255 255 255 255"
		//"defaultbgcolor_override"		"60 60 60 255"
		"armedbgcolor_override"			"90 90 90 255"
		"armedFgColor_override" 		"255 255 255 255"
		//"depressedbgcolor_override"		"50 50 50 255"
		//"depressedfgColor_override" 		"255 255 255 255"	
		
		"sound_armed"				"UI/item_info_mouseover.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"

	}

	"ShadedBG"
	{
		"ControlName"	"ImagePanel"
		"fieldName"		"ShadedBG"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"-10"
		"wide"			"0"//"f0"
		"tall"			"0"//"2000"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"	"0"	
		"fillcolor"		"0 0 0 200"
		"PaintBackgroundType"	"0"
	}

	"Offense"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"Offense"
		"xpos"			"c-99"
		"ypos"			"c-91"
		"zpos"			"2"
		"wide"			"92"
		"tall"			"12"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_Offense"
		"textAlignment"	"center"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 200"
	}		
	"Defense"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"Defense"
		"xpos"			"c-45"
		"ypos"			"c-91"
		"zpos"			"2"
		"wide"			"92"
		"tall"			"12"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_Defense"
		"textAlignment"	"center"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 200"
	}	
	"Support"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"Support"
		"xpos"			"c+11"
		"ypos"			"c-91"
		"zpos"			"2"
		"wide"			"90"
		"tall"			"12"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_Support"
		"textAlignment"	"center"
		"font"			"HudFontSmallest"
		"fgcolor"		"255 255 255 200"
	}
	
	"frame_scout"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_scout"
		"xpos"			"c-80"
		"ypos"			"c-80"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	"scout"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"scout"
		"xpos"				"c-80"
		"ypos"				"c-80"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 1"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_scout_inactive"
		"image_armed"		"class_sel_sm_scout_inactive"
		
		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
				
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-35"
			"zpos"			"5"
			"wide"			"58"
			"tall"			"116"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_scout_inactive"
			"scaleImage"	"1"
		}
	}
	
	
	"frame_soldier"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_soldier"
		"xpos"			"c-80"
		"ypos"			"c-26"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"
	}
	"soldier"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"soldier"
		"xpos"				"c-80"
		"ypos"				"c-26"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 3"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_soldier_inactive"
		"image_armed"		"class_sel_sm_soldier_inactive"
		
		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"

		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-29"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_soldier_inactive"
			"scaleImage"	"1"
		}				
	}


	
	"frame_pyro"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_pyro"
		"xpos"			"c-80"
		"ypos"			"c+28"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	"pyro"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"pyro"
		"xpos"				"c-80"
		"ypos"				"c+28"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 7"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_pyro_inactive"
		"image_armed"		"class_sel_sm_pyro_inactive"

		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"		""
		"sound_depressed"	"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-30"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_pyro_inactive"
			"scaleImage"	"1"
		}	
	}


	
	"frame_demoman"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_demoman"
		"xpos"			"c-26"
		"ypos"			"c-80"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	"demoman"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"demoman"
		"xpos"				"c-26"
		"ypos"				"c-80"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 4"
		"Default"			"0"


		"scaleImage"		"1"

		
		"image_default"		"class_sel_sm_demo_inactive"
		"image_armed"		"class_sel_sm_demo_inactive"
		
		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-26"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_demo_inactive"
			"scaleImage"	"1"
		}
	}


	
	
	"frame_heavy"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_heavy"
		"xpos"			"c-26"
		"ypos"			"c-26"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}	
	"heavyweapons"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"heavyweapons"
		"xpos"				"c-26"
		"ypos"				"c-26"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 6"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_heavy_inactive"
		"image_armed"		"class_sel_sm_heavy_inactive"
		
		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"

		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-25"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_heavy_inactive"
			"scaleImage"	"1"
		}		
	}

	
	"frame_engie"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_engie"
		"xpos"			"c-26"
		"ypos"			"c+28"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"
	}
	"engineer"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"engineer"
		"xpos"				"c-26"
		"ypos"				"c+28"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 9"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_engineer_inactive"
		"image_armed"		"class_sel_sm_engineer_inactive"
		
		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-29"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_engineer_inactive"
			"scaleImage"	"1"
		}
	}
	


	"frame_medic"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_medic"
		"xpos"			"c+28"
		"ypos"			"c-80"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	"medic"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"medic"
		"xpos"				"c+28"
		"ypos"				"c-80"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 5"
		"Default"			"0"

		"scaleImage"		"1"

		
		"image_default"		"class_sel_sm_medic_inactive"
		"image_armed"		"class_sel_sm_medic_inactive"

		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-25"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_medic_inactive"
			"scaleImage"	"1"
		}
	}	

	
	"frame_sniper"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"Bframe_sniper"
		"xpos"			"c+28"
		"ypos"			"c-26"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height"	"0"	
	}
	"sniper"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"sniper"
		"xpos"				"c+28"
		"ypos"				"c-26"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 2"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_sniper_inactive"
		"image_armed"		"class_sel_sm_sniper_inactive"

		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"	
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-25"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_sniper_inactive"
			"scaleImage"	"1"
		}
	}

	
	"frame_spy"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"frame_spy"
		"xpos"			"c+28"
		"ypos"			"c+28"
		"zpos"			"2"
		"wide"			"52"
		"tall"			"52"
		"visible"		"1"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"90"
		"src_corner_width"		"90"
		"draw_corner_width"		"0"
		"draw_corner_height" 	"0"	
	}
	"spy"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"spy"
		"xpos"				"c+28"
		"ypos"				"c+28"
		"zpos"				"6"
		"wide"				"52"
		"tall"				"52"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"1"
		"enabled"			"1"
		"tabPosition"		"0"
		"Command"			"select 8"
		"Default"			"0"

		"scaleImage"		"1"
		
		"image_default"		"class_sel_sm_spy_inactive"
		"image_armed"		"class_sel_sm_spy_inactive"

		"bgcolor"					"54 51 52 0"
		"defaultbgColor_override" 	"54 51 52 0"
		"armedbgColor_override" 	"White"
		"depressedbgColor_override" "White"
		"selectedbgColor_override" 	"White"
		
		"sound_armed"			""
		"sound_depressed"		"UI/buttonclickrelease.wav"
		
		"paintbackground"		"1"
		
		"image_drawcolor"		"40 40 40 255"
		"image_armedcolor"		"255 255 255 255"
		"image_selectedcolor"	"255 255 255 255"

		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"-27"
			"zpos"			"5"
			"wide"			"52"
			"tall"			"104"
			"visible"		"1"
			"enabled"		"1"
			"image"			"class_sel_sm_spy_inactive"
			"scaleImage"	"1"
		}	
	}

	"numScout"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numScout"
		"xpos"			"c-80"
		"ypos"			"c-80"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numScout%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}
	
	"numSoldier"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numSoldier"
		"xpos"			"c-80"
		"ypos"			"c-26"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numSoldier%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}

	"numPyro"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numPyro"
		"xpos"			"c-80"
		"ypos"			"c+28"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numPyro%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}

	"numDemoman"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numDemoman"
		"xpos"			"c-26"
		"ypos"			"c-80"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numDemoman%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}

	"numHeavy"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numHeavy"
		"xpos"			"c-26"
		"ypos"			"c-26"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numHeavy%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}

	"numEngineer"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numEngineer"
		"xpos"			"c-26"
		"ypos"			"c+28"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numEngineer%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}
	"numMedic"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numMedic"
		"xpos"			"c+28"
		"ypos"			"c-80"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numMedic%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}
	"numSniper"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numSniper"
			"xpos"			"c+28"
		"ypos"			"c-26"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numSniper%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}	
	"numSpy"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"numSpy"
		"xpos"			"c+28"
		"ypos"			"c+28"
		"zpos"			"3"
		"wide"			"52"
		"tall"			"52"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"1"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"%numSpy%"
		"textAlignment"	"center"
		"font"			"HudFontHUGE"
		"fgcolor"		"255 0 0 130"
	}
	
	
	
//not using anything here -----------------------------------------------------------------

	"class"
	{
		"ControlName"	"Frame"
		"fieldName"		"class"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"
	}
	"SysMenu"
	{
		"ControlName"	"Menu"
		"fieldName"		"SysMenu"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"64"
		"tall"			"24"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"
	}

	"TeamLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"TeamLabel"
		"xpos"			"c5"
		"ypos"			"58"
		"zpos"			"3"
		"wide"			"200"
		"tall"			"24"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"#TF_SelectAClass"
		"textAlignment"	"center"
		"font"			"HudFontMediumSmallBold"		//"HudFontMedium"
		"fgcolor"		"white"
	}	
	"TeamLabelShadow"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"TeamLabelShadow"
		"xpos"			"c7"
		"ypos"			"59"
		"zpos"			"2"
		"wide"			"200"
		"tall"			"24"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"#TF_SelectAClass"
		"textAlignment"	"center"
		"font"			"HudFontMediumSmallBold"
		"fgcolor"		"0 0 0 255"
	}	

	
	"RandomBG"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"RandomBG"
		"xpos"			"c182"
		"ypos"			"130"
		"zpos"			"0"
		"wide"			"45"
		"tall"			"90"
		"visible"		"0"
		"enabled"		"1"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"20"
		"src_corner_width"		"20"
		"draw_corner_width"		"4"
		"draw_corner_height" 	"4"	
	}
	"random"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"random"
		"xpos"				"c180"
		"ypos"				"122"
		"zpos"				"6"
		"wide"				"50"
		"tall"				"100"
		"autoResize"		"0"
		"pinCorner"			"2"
		"visible"			"0"
		"enabled"			"0"
		"tabPosition"		"0"
		"labelText"			""
		"textAlignment"		"south-west"
		"Command"			"select 12"
		"Default"			"1"
		"font"				"MenuKeys"
		"fgcolor"			"TanDark"
		"scaleImage"		"1"
		//"activeimage"		"class_sel_sm_random_blu"
		//"inactiveimage"		"class_sel_sm_random_inactive"
		
		"image_default"		"class_sel_sm_random_inactive"
		"image_armed"		"class_sel_sm_random_inactive"
		
		"paintbackground"	"0"
		
		"stayselectedonclick"	"1"
		"selectonhover"			"1"
		"keyboardinputenabled"	"0"
		
		"sound_armed"				"UI/buttonclickrelease.wav"
		//"sound_depressed"			"UI/buttonclickrelease.wav"
		"sound_released"			"UI/duel_challenge_accepted.wav"
		
		"SubImage"
		{
			"ControlName"	"ImagePanel"
			"fieldName"		"SubImage"
			"xpos"			"0"
			"ypos"			"0"
			"zpos"			"5"
			"wide"			"50"
			"tall"			"100"
			"visible"		"0"
			"enabled"		"1"
			"image"			"class_sel_sm_random_inactive"
			"scaleImage"	"1"
		}
	}
	"random_shortcut"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"random_shortcut"
		"xpos"				"c180"
		"ypos"				"122"
		"zpos"				"-5"
		"wide"				"0"
		"tall"				"0"
		"visible"			"0"
		"enabled"			"1"
		"labelText"			"&R"
		"Command"			"joinclass random"
		"Default"			"1"
		"font"				"MenuKeys"
		"fgcolor"			"TanDark"
	}	
	"RandomLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"RandomLabel"
		"xpos"			"c186"
		"ypos"			"206"
		"zpos"			"3"
		"wide"			"10"
		"tall"			"10"
		"visible"		"0"
		"enabled"		"1"
		"labelText"		"R"
		"textAlignment"	"center"
		"font"			"HudFontSmallBold"
		"fgcolor"		"255 255 255 255"
	}
	
	"loadout_shortcut"
	{
		"ControlName"		"CExImageButton"
		"fieldName"			"loadout_shortcut"
		"xpos"				"c180"
		"ypos"				"122"
		"zpos"				"-10"
		"wide"				"0"
		"tall"				"0"
		"visible"			"1"
		"enabled"			"1"
		"labelText"			"&E"
		"Command"			"openloadout"
		"Default"			"1"
		"font"				"MenuKeys"
		"fgcolor"			"TanDark"
	}
	
	
	"EditLoadoutButton"
	{
		"ControlName"	"CExButton"
		"fieldName"		"EditLoadoutButton"
		"xpos"			"c10000"	//"c45"
		"ypos"			"290"
		"zpos"			"6"
		"wide"			"120"
		"tall"			"20"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"
		"labelText"		"#EditLoadout"
		"textAlignment"	"center"
		"Command"		"openloadout"
		"font"			"HudFontSmallBold"
		
		"defaultFgColor_override" 		"255 255 255 255"
		"defaultbgcolor_override"		"70 70 70 220"
		"armedbgcolor_override"			"90 90 90 255"		
		
		"sound_armed"				"UI/buttonclickrelease.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"
	}

	"ResetButton"
	{
		"ControlName"	"CExButton"
		"fieldName"		"ResetButton"
		"xpos"			"c195"
		"ypos"			"230"
		"zpos"			"6"
		"wide"			"100"
		"tall"			"40"
		"autoResize"	"0"
		"pinCorner"		"2"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_ClassMenu_Reset"
		"textAlignment"	"center"
		"Command"		"resetclass"
		"font"			"HudFontSmallBold"
		
		"defaultFgColor_override" 		"255 255 255 255"
		"defaultbgcolor_override"		"50 50 50 230"
		"armedbgcolor_override"			"80 80 80 255"	
		"depressedbgcolor_override"		"45 45 45 255"
		"depressedfgColor_override" 	"255 255 255 255"	
		
		"sound_armed"				"UI/buttonclickrelease.wav"
		"sound_depressed"			"UI/buttonclickrelease.wav"
		"sound_released"			"UI/duel_score_behind.wav"
	}

	"ClassMenuSelect"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"ClassMenuSelect"
		"xpos"			"30"
		"ypos"			"r40"
		"zpos"			"5"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"labelText"		"#TF_SelectAClass"
		"textAlignment"	"west"
		"font"			"MenuMainTitle"
		"fgcolor"		"HudOffWhite"
	}
	
	"MenuBG"
	{
		"ControlName"	"CModelPanel"
		"fieldName"		"MenuBG"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"0"		
		"wide"			"f0"
		"tall"			"480"
		"visible"		"0"
		"enabled"		"1"
	}	
	"localPlayerImage"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"localPlayerImage"
		"xpos"			"c-23"
		"ypos"			"295"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"0"
		"image"			""	
		"scaleImage"	"1"	
	}	
	"localPlayerBG"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"localPlayerBG"
		"xpos"			"c-28"
		"ypos"			"310"
		"zpos"			"2"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"image"			"../hud/color_panel_clear"
		"scaleImage"	"1"	
		"teambg_2"		"../hud/color_panel_clear"
		"teambg_3"		"../hud/color_panel_clear"
		
		"src_corner_height"		"23"
		"src_corner_width"		"23"
		"draw_corner_width"		"5"	
		"draw_corner_height" 	"5"	
	}
	"countImage0"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage0"
		"xpos"			"c30"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage1"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage1"
		"xpos"			"c-60"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage2"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage2"
		"xpos"			"c60"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage3"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage3"
		"xpos"			"c-90"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage4"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage4"
		"xpos"			"c90"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage5"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage5"
		"xpos"			"c-120"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage6"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage6"
		"xpos"			"c120"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage7"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage7"
		"xpos"			"c-150"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage8"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage8"
		"xpos"			"c150"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage9"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage9"
		"xpos"			"c-180"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"countImage10"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"countImage10"
		"xpos"			"c180"
		"ypos"			"315"
		"zpos"			"9"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"1"
		"image"			""	
		"scaleImage"	"1"	
	}
	"CountLabel"
	{
		"ControlName"	"CExLabel"
		"fieldName"		"CountLabel"
		"xpos"			"c3000"	//"c30"
		"ypos"			"310"
		"zpos"			"10"
		"wide"			"150"
		"tall"			"18"
		"autoResize"	"1"
		"pinCorner"		"2"
		"visible"		"0"
		"enabled"		"1"
		"tabPosition"	"0"
		"labelText"		"#TF_TeamCount"
		"textAlignment"	"left"
		"font"			"HudFontMediumSmallSecondary"
		"fgcolor"		"TanLight"
	}	

	"TFPlayerModelBG"
	{
		"ControlName"	"CTFImagePanel"
		"fieldName"		"TFPlayerModelBG"
		"xpos"			"c-224"	
		"ypos"			"51"
		"zpos"			"0"
		"wide"			"0"
		"tall"			"0"
		"visible"		"0"
		"enabled"		"0"
		"image"			"../hud/color_panel_brown"
		"scaleImage"			"1"	
		
		"src_corner_height"		"23"
		"src_corner_width"		"23"
		"draw_corner_width"		"3"
		"draw_corner_height" 	"3"	
	}	

	"TFPlayerModel"
	{
		"ControlName"	"CTFPlayerModelPanel"
		"fieldName"		"TFPlayerModel"
		
		"xpos"			"c-220"
		"ypos"			"55"
		"zpos"			"10"		
		"wide"			"0"
		"tall"			"0"
		
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		
		"fov"			"25"
		"allow_rot"		"0"

		"paintbackground" "1"		
		"paintbackgroundenabled" "0"
		"bgcolor_override" "0 0 0 125"
		
		"model"
		{
			"force_pos"	"1"

			"angles_x" "0"
			"angles_y" "180"
			"angles_z" "0"
			"origin_x" "180"
			"origin_y" "0"
			"origin_z" "-40"
			"frame_origin_x"	"0"
			"frame_origin_y"	"0"
			"frame_origin_z"	"0"
			"spotlight" "1"
		
			"modelname"		""
			"vcd"		"class_select.vcd"		
			
			"animation"
			{
				"name"		"PRIMARY"
				"activity"	"ACT_MP_STAND_PRIMARY"
				"default"	"1"
			}
			"animation"
			{
				"name"		"SECONDARY"
				"activity"	"ACT_MP_STAND_SECONDARY"
			}
			"animation"
			{
				"name"		"MELEE"
				"activity"	"ACT_MP_STAND_MELEE"
			}
			"animation"
			{
				"name"		"BUILDING"
				"activity"	"ACT_MP_STAND_BUILDING"
			}
			"animation"
			{
				"name"		"PDA"
				"activity"	"ACT_MP_STAND_PDA"
			}
			"animation"
			{
				"name"		"ITEM1"
				"activity"	"ACT_MP_STAND_ITEM1"
			}						
			"animation"
			{
				"name"		"ITEM2"
				"activity"	"ACT_MP_STAND_ITEM2"
			}	
			"animation"
			{
				"name"		"MELEE_ALLCLASS"
				"activity"	"ACT_MP_STAND_MELEE_ALLCLASS"
			}								
		}
	}
	"ClassInfoPanel"
	{
		"ControlName"	"CTFClassInfoPanel"
		"fieldName"		"ClassInfoPanel"
		"xpos"			"c46"
		"ypos"			"c-79"
		"zpos"			"7"
		"wide"			"0"
		"tall"			"0"
		"autoResize"	"0"
		"pinCorner"		"0"
		"visible"		"0"
		"enabled"		"0"
		"tabPosition"	"0"
	}	
}

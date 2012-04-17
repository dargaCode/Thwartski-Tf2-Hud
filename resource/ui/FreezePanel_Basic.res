//based on eve hud

"Resource/UI/FreezePanel_Basic.res"
{

	"itempanel"
	{
		"ControlName"		"CItemModelPanel"
		"fieldName"			"itempanel"
		"xpos"				"r177"//"r175"//"r275"
		"ypos"				"r180"
		"zpos"				"-1"
		"wide"				"170"//"270"
		"tall"				"180"
		"visible"			"0"
		"bgcolor_override"		"255 255 255 0"
		"PaintBackgroundType"	"0"
		
		"model_xpos"		"210"//"10"
		"model_center_y"	"1"
		"model_wide"		"73"
		"model_tall"		"45"
		
		"text_xpos"			"0"//"90"
		"text_wide"			"170"
		"text_center"		"1"
		
		"max_text_height"	"90"
		"padding_height"	"20"
		"resize_to_text"	"1"
		"text_forcesize"	"2"
		
		"itemmodelpanel"
		{
			"fieldName"					"itemmodelpanel"
			"use_item_rendertarget" 	"1"
			"useparentbg"				"1"
		}
		
		"ItemLabel"
		{	
			"ControlName"	"Label"
			"fieldName"		"ItemLabel"
			"font"			"ScoreboardSmall"
			"xpos"			"0"
			"ypos"			"5"
			"zpos"			"10"
			"wide"			"140"
			"tall"			"10"
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"0"
			"enabled"		"1"
			"labelText"		"#FreezePanel_Item"
			"textAlignment"	"center"
			"dulltext"		"0"
			"brighttext"	"0"
		}
		
		"attriblabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"attriblabel"
			"font"			"ItemFontAttribLarge"
			"xpos"			"50"
			"ypos"			"30"
			"zpos"			"2"
			"wide"			"140"
			"tall"			"60"
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"labelText"		"%attriblist%"
			"textAlignment"	"south"
			"fgcolor"		"235 226 202 255"
			"centerwrap"	"1"
		}
	}		
	
	"FreezePanelBase"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"FreezePanelBase"
		"xpos"			"r430"//"r455"//"c-316"
		"ypos"			"193"//"r118""
		"zpos"			"1"
		"wide"			"450"
		"tall"			"100"		
		"visible"		"1"
	
		"FreezePanelBG"
		{
			"ControlName"		"CTFImagePanel"
			"fieldName"			"FreezePanelBG"
			"xpos"				"226"//"208"
			"ypos"				"64"//"60"
			"zpos"				"-4"
			"wide"				"180"//"216"
			"tall"				"26"//"33"
			"visible"			"1"
			"enabled"			"1"
			"image"				"../hud/color_panel_blu"
			"scaleImage"		"1"	
			
			"src_corner_height"		"90"//"23"
			"src_corner_width"		"90"//"23"
			
			"draw_corner_width"		"0"//"6"
			"draw_corner_height" 	"0"//"6"
		}

		"FreezePanelHealth"
		{
			"ControlName"		"CTFFreezePanelHealth"
			"fieldName"			"FreezePanelHealth"
			"xpos"				"206"//"190"//"208"
			"ypos"				"57"//"64"
			"zpos"				"4"
			"wide"				"80"
			"tall"				"80"
			"visible"			"1"
			"enabled"			"1"	
			"HealthBonusPosAdj"			"9"
			"HealthDeathWarning"		"0.49"
			"TFFont"					"HudFontSmall"
			"HealthDeathWarningColor"	"HUDDeathWarning"
			"TextColor"					"HudOffWhite"
		}	

		"FreezeLabel2"
		{	
			"ControlName"		"Label"
			"fieldName"			"FreezeLabel2"
			"font"				"ScoreboardSmallBold"
			"xpos"				"208"
			"ypos"				"65"
			"zpos"				"1"
			"wide"				"216"
			"tall"				"12"
			"autoResize"		"0"
			"pinCorner"			"0"
			"visible"			"1"
			"enabled"			"1"
			"labelText"			"#FreezePanel_Killer"
			"textAlignment"		"North"
			"dulltext"			"0"
			"brighttext"		"0"
		}
		
	
		"FreezeLabelKiller2"
		{	
			"ControlName"		"Label"
			"fieldName"			"FreezeLabelKiller2"
			"font"				"HudFontSmall"
			"xpos"				"208"
			"ypos"				"74"
			"zpos"				"10"
			"wide"				"216"
			"tall"				"18"
			"autoResize"		"0"
			"pinCorner"			"0"
			"visible"			"1"
			"enabled"			"1"
			"labelText"			"%killername%"
			"textAlignment"		"Center"
		}

		"AvatarImage"
		{
			"ControlName"		"CAvatarImagePanel"
			"fieldName"			"AvatarImage"
			"xpos"				"393"//"391"//"408"//"393"
			"ypos"				"64"//"62"
			"zpos"				"3"
			"wide"				"26"//"30"//"18"
			"tall"				"26"//"30"//"18"
			"visible"			"1"
			"enabled"			"1"
			"image"				""
			"scaleImage"		"1"
		}
		
		"AvatarImage2" //fake background
		{
			"ControlName"		"EditablePanel"
			"fieldName"			"AvatarImage2"
			"xpos"				"391"//"408"//"393"
			"ypos"				"62"
			"zpos"				"-2"
			"wide"				"30"//"18"
			"tall"				"30"//"18"
			"visible"			"1"
			"enabled"			"1"
			//"scaleImage"		"1"
			//"PaintBackgroundType"	"2"
			"bgcolor_override"		"46 43 42 255"
		}
		"AvatarQuestionMark"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"AvatarQuestionMark"
			"font"			"HudFontSmallishBold"
			"labelText"		"?"
			"textAlignment"	"west"
			"xpos"			"402"//"419"//"402"
			"ypos"			"68"
			"zpos"			"2"
			"wide"			"18"
			"tall"			"18"
			"autoResize"	"0"
			"pinCorner"		"0"
			"visible"		"1"
			"enabled"		"1"
			"fgcolor"		"255 255 255 255"
		}		
		
		"FreezeLabel"
		{	
			"ControlName"		"Label"
			"fieldName"			"FreezeLabel"
			"font"				"ScoreboardSmall"
			"xpos"				"258"
			"ypos"				"63"
			"zpos"				"1"
			"wide"				"0"
			"tall"				"0"
			"autoResize"		"0"
			"pinCorner"			"0"
			"visible"			"0"
			"enabled"			"1"
			"labelText"			"#FreezePanel_Killer"
			"textAlignment"		"North-West"
			"dulltext"			"0"
			"brighttext"		"0"
		}
		"FreezeLabelKiller"
		{	
			"ControlName"		"Label"
			"fieldName"			"FreezeLabelKiller"
			"font"				"HudFontSmall"
			"xpos"				"0"
			"ypos"				"0"
			"zpos"				"0"
			"wide"				"0"
			"tall"				"0"
			"autoResize"		"0"
			"pinCorner"			"0"
			"visible"			"0"
			"enabled"			"0"
			"labelText"			"%killername%"
			"textAlignment"		"Center"
		}
		
		"NemesisSubPanel"
		{
			"ControlName"		"EditablePanel"
			"fieldName"			"NemesisSubPanel"
			"xpos"				"276"
			"ypos"				"40"//"42"			
			"zpos"				"2"//"4"
			"wide"				"306"
			"tall"				"100"
			"visible"			"1"


			
			"NemesisPanelBGThwartski"
			{
				"ControlName"		"Imagepanel"//"ScalableImagePanel"
				"fieldName"			"NemesisPanelBGThwartski"
				"xpos"				"0"//"110"
				"ypos"				"18"//"4"
				"zpos"				"5"
				"wide"				"80"
				"tall"				"16"//"29"
				"visible"			"1"
				"enabled"			"1"
				"image"				""//"../hud/color_panel_brown"
				"scaleImage"		"1"	
				//"fillcolor"		"0 0 0 255"
				"fillcolor"			"46 43 42 255"
				
				
				"src_corner_height"		"90"//"23"
				"src_corner_width"		"90"//"23"
				
				"draw_corner_width"		"0"//"6"
				"draw_corner_height" 	"0"//"6"	
			}
			
			"NemesisLabelThwartski"
			{	
				"ControlName"		"Label"
				"fieldName"			"NemesisLabelThwartski"
				"font"				"HudFontSmallestBold"//"HudFontSmallBold"//"HudFontMediumSmall"
				"xpos"				"1"
				"ypos"				"18"
				"zpos"				"6"
				"wide"				"80"
				"tall"				"16"
				"autoResize"		"0"
				"pinCorner"			"0"
				"visible"			"1"
				"enabled"			"1"
				"labelText"			"%nemesisname%"
				"textAlignment"		"center"
			}
			
			"NemesisIconThwartski"
			{
				"ControlName"	"ImagePanel"
				"fieldName"		"NemesisIconThwartski"
				"xpos"			"108"//"109"//"106"
				"ypos"			"15"//"15"//"12"//"10"
				"zpos"			"0"
				"wide"			"42"//"42"//"48"//"36"
				"tall"			"42"//"42"//"48"//"36"
				"visible"		"1"
				"enabled"		"1"
				"image"			"../hud/leaderboard_nemesis_freezecam"
				"scaleImage"	"1"	
				//"image_drawcolor"		"0 0 0 55"
			}	
			
			"FakeBackgroundNemesis" //covers up the question mark
			{
				"ControlName"		"EditablePanel"
				"fieldName"			"FakeBackgroundNemesis"
				"xpos"				"115"
				"ypos"				"22"
				"zpos"				"1"
				"wide"				"30"
				"tall"				"30"
				"visible"			"1"
				"enabled"			"1"
				//"scaleImage"		"1"
				//"PaintBackgroundType"	"2"
				"bgcolor_override"	"46 43 42 200"//255"
			}
			
			//----------------------------------------------------------------------
			// 							ALL TURNED OFF
			//----------------------------------------------------------------------	
		
			
			"NemesisIcon"
			{
				"ControlName"	"ImagePanel"
				"fieldName"		"NemesisIcon"
				"xpos"			"0"
				"ypos"			"0"
				"zpos"			"6"
				"wide"			"48"//"36"
				"tall"			"48"//"36"
				"visible"		"0"
				"enabled"		"1"
				"image"			"../hud/leaderboard_nemesis_freezecam"
				"scaleImage"	"1"	
			}	
			
			"NemesisLabel"
			{	
				"ControlName"		"Label"
				"fieldName"			"NemesisLabel"
				"font"				"HudFontSmallestBold"//"HudFontSmallBold"//"HudFontMediumSmall"
				"xpos"				"0"
				"ypos"				"10"
				"zpos"				"6"
				"wide"				"100"
				"tall"				"18"
				"autoResize"		"0"
				"pinCorner"			"0"
				"visible"			"0"
				"enabled"			"1"
				"labelText"			"DOMINATED!"//"%nemesisname%"
				"textAlignment"		"west"
			}
			
			"NemesisPanelBG"
			{
				"ControlName"		"ImagePanel"
				"fieldName"		"NemesisPanelBG"
				"xpos"			"0"
				"ypos"			"0"
				"zpos"			"5"
				"wide"			"166"
				"tall"			"38"
				"visible"		"0"
				"enabled"		"1"
				"image"			"../hud/freezecam_black_bg"
				"scaleImage"		"1"		
			}
		}
	}
		
	"ScreenshotPanel"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"ScreenshotPanel"
		"xpos"			"0"
		"ypos"			"0"
		"zpos"			"2"
		"wide"			"0"
		"tall"			"0"
		"tall_minmode"	"0"
		"visible"		"0"
		
		"ScreenshotPanelBG"
		{
			"ControlName"		"ImagePanel"
			"fieldName"			"ScreenshotPanelBG"
			"xpos"				"0"
			"ypos"				"0"
			"zpos"				"0"
			"wide"				"0"
			"tall"				"0"
			"visible"			"0"
			"enabled"			"0"
			"image"				""
			"scaleImage"		"1"
			
		}
		"ScreenshotIcon"
		{
			"ControlName"		"ImagePanel"
			"fieldName"			"ScreenshotIcon"
			"xpos"				"0"
			"ypos"				"0"
			"zpos"				"1"
			"wide"				"0"
			"tall"				"0"
			"visible"			"0"
			"enabled"			"1"
			"image"				""
			"scaleImage"		"1"
		}		
		"ScreenshotLabel"
		{	
			"ControlName"		"CExLabel"
			"fieldName"			"ScreenshotLabel"
			"font"				"HudFontMediumSmallestbold"
			"xpos"				"0"
			"ypos"				"0"
			"zpos"				"2"
			"wide"				"0"
			"tall"				"0"
			"autoResize"		"0"
			"pinCorner"			"0"
			"visible"			"0"
			"enabled"			"1"
			"labelText"			""
			"textAlignment"		"west"
			"dulltext"			"0"
			"brighttext"		"0"		
		}
	}	
}

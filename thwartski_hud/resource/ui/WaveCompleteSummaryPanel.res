"Resource/UI/WaveCompletePanel.res"
{		
	"Background"
	{
		"ControlName"		"ScalableImagePanel"
		"fieldName"		"Background"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"160"
		"tall"			"70"
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
	
	"WaveCompleteContainer"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"WaveCompleteContainer"
		"xpos"			"0"
		"ypos"			"0"
		"wide"			"160"
		"tall"			"35"
		"visible"		"1"
		"PaintBackgroundType" "2"
	
		"WaveCompleteLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"WaveCompleteLabel"
			"font"			"HudFontMediumSmall"
			"textAlignment"	"center"
			"labelText"		"Success!"//"%titletext%"
			"xpos"			"0"
			"ypos"			"0"
			"zpos"			"1"
			"wide"			"160"
			"tall"			"28"
			"visible"		"1"
			"enabled"		"1"
			"fgcolor"		"tanlight"		
		}
		
		"WaveCompleteLabelShadow"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"WaveCompleteLabelShadow"
			"font"			"HudFontMediumSmall"
			"textAlignment"	"center"
			"labelText"		"Success!"//"%titletextshadow%"
			"xpos"			"1"
			"ypos"			"1"
			"zpos"			"0"
			"wide"			"160"
			"tall"			"28"
			"visible"		"1"
			"enabled"		"1"
			"fgcolor"		"black"		
		}
		
	}
		
	"CreditContainer"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"CreditContainer"
		"xpos"			"0"
		"ypos"			"23"
		"wide"			"160"
		"tall"			"160"
		"autoResize"	"1"
		"visible"		"1"
		
		"CreditCollectedTextLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditCollectedTextLabel"
			"font"			"HudFontSmall"
			"labelText"		"Earned   $"//"#TF_PVE_CurrencyCollected"
			"textAlignment" "north-east"
			"xpos"			"0"
			"ypos"			"5"
			"wide"			"80"
			"fgcolor"		"tanlight"
		}
		
		"CreditCollectedCountLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditCollectedCountLabel"
			"font"			"HudFontSmall"
			"labelText"		"%creditscollected%"
			"textAlignment" "north-east"
			"xpos"			"75"
			"ypos"			"5"
			"wide"			"30"
			"fgcolor"		"CreditsGreen"
		}
		
		"CreditMissedTextLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditMissedTextLabel"
			"font"			"HudFontSmall"
			"labelText"		"Missed   $"//"#TF_PVE_Missed"
			"textAlignment" "north-east"
			"xpos"			"0"
			"ypos"			"17"
			"wide"			"80"
			"fgcolor"		"tanlight"
		}
		
		"CreditMissedCountLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditMissedCountLabel"
			"font"			"HudFontSmall"
			"labelText"		"%creditsmissed%"
			"textAlignment" "north-east"
			"xpos"			"75"
			"ypos"			"17"
			"wide"			"30"
			"fgcolor"		"RedSolid"
		}
		
		"CreditBonusTextLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditBonusTextLabel"
			"font"			"HudFontSmall"
			"labelText"		"Bonus   $"//"#TF_PVE_Bonus"
			"textAlignment" "north-east"
			"xpos"			"0"
			"ypos"			"29"
			"wide"			"80"
			"fgcolor"		"tanlight"
		}
		
		"CreditBonusCountLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"CreditBonusCountLabel"
			"font"			"HudFontSmall"
			"labelText"		"%creditbonus%"
			"textAlignment" "north-east"
			"xpos"			"75"
			"ypos"			"29"
			"wide"			"30"
			"fgcolor"		"CreditsGreen"
		}
	}
	
	"RatingContainer"
	{
		"ControlName"	"EditablePanel"
		"fieldName"		"RatingContainer"
		"xpos"			"106"
		"ypos"			"24"
		"wide"			"55"
		"tall"			"60"
		"autoResize"	"1"
		"visible"		"1"
		
		"RatingLabel"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"RatingLabel"
			"font"			"HudFontSmall"
			"labelText"		"%ratinglabel%"
			"textAlignment" "center"
			"xpos"			"0"
			"ypos"			"0"
			"wide"			"55"
			"fgcolor"		"tanlight"
			"visible"		"0"
		}
		
		"RatingText"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"RatingText"
			"font"			"HudFontMediumBold"
			"labelText"		"%ratingscore%"
			"textAlignment" "north"
			"xpos"			"0"
			"ypos"			"3"
			"zpos" 			"1"
			"wide"			"55"
			"fgcolor"		"White"
		}
		
		"RatingTextShadow"
		{
			"ControlName"	"CExLabel"
			"fieldName"		"RatingTextShadow"
			"font"			"HudFontMediumBold"
			"labelText"		"%ratingscoreshadow%"
			"textAlignment" "center"
			"xpos"			"1"
			"ypos"			"4"
			"zpos" 			"0"
			"wide"			"55"
			"fgcolor"		"Black"
		}
		

	}
}

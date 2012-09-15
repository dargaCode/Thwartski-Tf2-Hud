using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms; 


namespace Thwartski_Hud_Installer
{
    class OptionsTracker
    {
        //classes to store the value being passed in
        private Form1 mainForm = null;
        private Location assetLocation = null;
        private Location installLocation = null;
        private Option aspectOption = null;
        private Option scoreboardMinmodeOption = null;
        private Option scoreboardMaxmodeOption = null;

        //constructor?
        public OptionsTracker(Form1 caller, Location assets, Location install, Option aspect, Option scoreboardMin, Option scoreboardMax)
        {
            //store the calling form
            mainForm = caller;

            //assign the hud objects
            assetLocation = assets;
            installLocation = install;

            //assign the options objects
            aspectOption = aspect;
            scoreboardMinmodeOption = scoreboardMin;
            scoreboardMaxmodeOption = scoreboardMax;
        }

        /// <summary>
        /// Set up the options with the right attributes.
        /// </summary>
        public void Setup()
        { 
            //populate the correct dictionaries and images
            PopulateOptionDictonaries();

            //populate comboboxes
            //has to happen after the options objects are populated, or the image lookups won't work
            PopulateComboboxes();
        }

        /// <summary>
        /// Populate the 
        /// </summary>
        private void PopulateOptionDictonaries() //TODO HOOK THIS UP
        {
            //update asset dictionaries
            aspectOption.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectNormal, Properties.Resources.aspectImageNormal);
            aspectOption.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectWidescreen, Properties.Resources.aspectImageWidescreen);

            //update minmode scoreboard dictionaries
            scoreboardMinmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.scoreboardImageComp6);
            scoreboardMinmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp9, Properties.Resources.scoreboardImageComp9);

            //update maxmode scoreboard dictionaries
            scoreboardMaxmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.scoreboardImagePub24);
            scoreboardMaxmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub32, Properties.Resources.scoreboardImagePub32);
        }

        /// <summary>
        /// Populate comboboxes with arrays and default values.
        /// </summary>
        private void PopulateComboboxes()
        {
            //create arrays of combobox strings
            string[] aspects = { Properties.Resources.stringComboboxAspectNormal, Properties.Resources.stringComboboxAspectWidescreen };
            string[] scoreboardsMinmode = { Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.stringComboboxScoreboardComp9 };
            string[] scoreboardsMaxmode = { Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.stringComboboxScoreboardPub32 };
 
            //populate the comboboxes with the correct options
            mainForm.aspectCombobox.Items.AddRange(aspects);
            mainForm.scoreboardComboboxMinmode.Items.AddRange(scoreboardsMinmode);
            mainForm.scoreboardComboboxMaxmode.Items.AddRange(scoreboardsMaxmode);

            //load settings for comboxes
            mainForm.aspectCombobox.SelectedIndex = Properties.Settings.Default.settingComboboxAspect;
            mainForm.scoreboardComboboxMinmode.SelectedIndex = Properties.Settings.Default.settingComboboxMinmode;
            mainForm.scoreboardComboboxMaxmode.SelectedIndex = Properties.Settings.Default.settingComboboxMaxmode;
        }

        /// <summary>
        /// Get the new string from the aspect option and update the assets
        /// </summary>
        /// <param name="option"></param>
        public void updateAspect()
        {
            //get the new string from the option
            string aspectRatio = aspectOption.Update();

            //don't update if the value wasn't legitimage
            if (aspectRatio != null)
            {
                //normal
                if (aspectRatio == Properties.Resources.stringComboboxAspectNormal)
                {
                    //place the corresponding string in the asset object 
                    assetLocation.FilenameHudAspect = Properties.Resources.stringFilenameAssetAspectNormal;
                }
                //widescreen
                else if (aspectRatio == Properties.Resources.stringComboboxAspectWidescreen)
                {
                    //place the corresponding string in the asset object 
                    assetLocation.FilenameHudAspect = Properties.Resources.stringFilenameAssetAspectWidescreen;
                }
                //something went wrong
                else
                {
                    mainForm.errorWindow("No match for asset file: " + aspectRatio);
                }
            }
        }

        /// <summary>
        /// Based on the settings for the two scoreboard options, determine which files to point to in the asset object.
        /// </summary>
        public void updateScoreboard()
        {
            string comp6 = Properties.Resources.stringComboboxScoreboardComp6;
            string comp9 = Properties.Resources.stringComboboxScoreboardComp9;
            string pub24 = Properties.Resources.stringComboboxScoreboardPub24;
            string pub32 = Properties.Resources.stringComboboxScoreboardPub32;

            string minmodeScoreboard = scoreboardMinmodeOption.Update();
            string maxmodeScoreboard = scoreboardMaxmodeOption.Update();

            //don't update if one of the values wasn't legitimage
            if (minmodeScoreboard != null && maxmodeScoreboard != null)
            {
                //comp6 minmode, pub24 maxmode
                if (minmodeScoreboard == comp6 && maxmodeScoreboard == pub24)
                {
                    //set the asset object to point to the right files
                    assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp6Pub24;
                    assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp6Pub24;
                    //MessageBox.Show(comp6 + " / " + pub24);
                }
                //comp9 minmode, pub24 maxmode
                else if (minmodeScoreboard == comp9 && maxmodeScoreboard == pub24)
                {
                    //set the asset object to point to the right files
                    assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp9Pub24;
                    assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp9Pub24;
                    //MessageBox.Show(comp9 + " / " + pub24);
                }
                //comp6 minmode, pub32 maxmode
                else if (minmodeScoreboard == comp6 && maxmodeScoreboard == pub32)
                {
                    //set the asset object to point to the right files
                    assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp6Pub32;
                    assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp6Pub32;
                    //MessageBox.Show(comp6 + " / " + pub32);
                }
                //comp9 minmode, pub32 maxmode
                else if (minmodeScoreboard == comp9 && maxmodeScoreboard == pub32)
                {
                    //set the asset object to point to the right files
                    assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp9Pub32;
                    assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp9Pub32;
                    //MessageBox.Show(comp9 + " / " + pub32);
                }
                //something went wrong
                else
                {
                    //this case is triggered legitimately when the initial values are being set and the second is -1
                    //the error messages in each combobox event above should handle everything else
                }
            }
        }

        /// <summary>
        /// Update all relevant elements when an option is changed.
        /// </summary>
        public void Update() //TODO HOOK THIS UP
        {
            //rebuild text strings
            mainForm.updateStrings();  //TODO this can be deleted entirely and handled at install

            //update options string background color
            mainForm.detectOptionsChanges();

            //update install/uninstall buttons
            mainForm.updateButtons();
        }
    }
}

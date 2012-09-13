using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Thwartski_Hud_Installer
{
    class OptionsTracker
    {
        //classes to store the value being passed in
        private Form1 mainForm = null;
        private HudFiles assetHud = null;
        private HudFiles installHud = null;
        private HudOptions aspectOptions = null;
        private HudOptions scoreboardMinmodeOptions = null;
        private HudOptions scoreboardMaxmodeOptions = null;

        //constructor?
        public OptionsTracker(Form1 caller, HudFiles assets, HudFiles install, HudOptions aspect, HudOptions scoreboardMin, HudOptions scoreboardMax)
        {
            //store the calling form
            mainForm = caller;

            //assign the hud objects
            assetHud = assets;
            installHud = install;

            //ssign the options objects
            aspectOptions = aspect;
            scoreboardMinmodeOptions = scoreboardMin;
            scoreboardMaxmodeOptions = scoreboardMax;
        }


        /// <summary>
        /// Set up the options with the right attributes. //TODO this does nothing
        /// </summary>
        public void Setup()
        { 
            //populate the correct dictionaries
            //populate saved settings?
            //populate comboboxes
        
        }

        /// <summary>
        /// Populate comboboxes with arrays and default values.
        /// </summary>
        public void PopulateComboboxes()
        {

            //create arrays of combobox strings
            string[] aspects = { Properties.Resources.stringComboboxAspectNormal, Properties.Resources.stringComboboxAspectWidescreen };
            string[] scoreboardsMinmode = { Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.stringComboboxScoreboardComp9 };
            string[] scoreboardsMaxmode = { Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.stringComboboxScoreboardPub32 };
 

            //populate the comboboxes with the correct options
            mainForm.aspectCombobox.Items.AddRange(aspects);
            mainForm.scoreboardComboboxMaxmode.Items.AddRange(scoreboardsMaxmode);
            mainForm.scoreboardComboboxMinmode.Items.AddRange(scoreboardsMinmode);

            //load settings for comboxes
            mainForm.aspectCombobox.SelectedIndex = Properties.Settings.Default.settingComboboxAspect;
            mainForm.scoreboardComboboxMinmode.SelectedIndex = Properties.Settings.Default.settingComboboxMinmode;
            mainForm.scoreboardComboboxMaxmode.SelectedIndex = Properties.Settings.Default.settingComboboxMaxmode;


        }

        /// <summary>
        /// 
        /// </summary>
        public void PopulateOptionObjects() //TODO HOOK THIS UP
        {

            //update asset dictionaries
            aspectOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxAspectNormal, Properties.Resources.stringFilenameAssetAspectNormal);
            aspectOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxAspectWidescreen, Properties.Resources.stringFilenameAssetAspectWidescreen);

            aspectOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectNormal, Properties.Resources.aspectImageNormal);
            aspectOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectWidescreen, Properties.Resources.aspectImageWidescreen);

            //update minmode scoreboard dictionaries
            scoreboardMinmodeOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardComp6, "6");
            scoreboardMinmodeOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardComp9, "9");

            scoreboardMinmodeOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.scoreboardImageComp6);
            scoreboardMinmodeOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp9, Properties.Resources.scoreboardImageComp9);

            //update maxmode scoreboard dictionaries
            scoreboardMaxmodeOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardPub24, "24");
            scoreboardMaxmodeOptions.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardPub32, "32");

            scoreboardMaxmodeOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.scoreboardImagePub24);
            scoreboardMaxmodeOptions.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub32, Properties.Resources.scoreboardImagePub32);

        }

        /// <summary>
        /// Update all relevant elements when an option is changed.
        /// </summary>
        public void Update() //TODO HOOK THIS UP
        {

            //check both comboboxes and identify the right scoreboard files
            mainForm.updateScoreboardFiles();

            //rebuild text strings
            mainForm.updateStrings();

            //update options string background color
            mainForm.detectOptionsChanges();

            //update install/uninstall buttons
            mainForm.updateButtons();


        }
        

    }
}

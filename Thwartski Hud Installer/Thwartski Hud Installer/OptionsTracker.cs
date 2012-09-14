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

        //attributes to be set from Option objects
        private string _settingMinmodeScoreboard;
        private string _settingMaxmodeScoreboard;

        public string SettingMinmodeScoreboard { get { return _settingMinmodeScoreboard; } set { _settingMinmodeScoreboard = value; updateScoreboardFiles(); } }
        public string SettingMaxmodeScoreboard { get { return _settingMaxmodeScoreboard; } set { _settingMaxmodeScoreboard = value; updateScoreboardFiles(); } }


        private string comp6 = "Comp6";
        private string comp9 = "Comp9";
        private string pub24 = "Pub24";
        private string pub32 = "Pub32";


        //constructor?
        public OptionsTracker(Form1 caller, Location assets, Location install, Option aspect, Option scoreboardMin, Option scoreboardMax)
        {
            //store the calling form
            mainForm = caller;

            //assign the hud objects
            assetLocation = assets;
            installLocation = install;

            //ssign the options objects
            aspectOption = aspect;
            scoreboardMinmodeOption = scoreboardMin;
            scoreboardMaxmodeOption = scoreboardMax;
        }


        /// <summary>
        /// Set up the options with the right attributes.
        /// </summary>
        public void Setup()
        { 
            //populate the correct dictionaries
            //populate saved settings?
            //populate comboboxes

            PopulateComboboxes();
            PopulateOptionObjects();

        
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
        private void PopulateOptionObjects() //TODO HOOK THIS UP
        {

            //update asset dictionaries
            aspectOption.DictionaryFiles.Add(Properties.Resources.stringComboboxAspectNormal, Properties.Resources.stringFilenameAssetAspectNormal);
            aspectOption.DictionaryFiles.Add(Properties.Resources.stringComboboxAspectWidescreen, Properties.Resources.stringFilenameAssetAspectWidescreen);

            aspectOption.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectNormal, Properties.Resources.aspectImageNormal);
            aspectOption.DictionaryPictures.Add(Properties.Resources.stringComboboxAspectWidescreen, Properties.Resources.aspectImageWidescreen);

            //update minmode scoreboard dictionaries
            scoreboardMinmodeOption.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardComp6, comp6);
            scoreboardMinmodeOption.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardComp9, comp9);

            scoreboardMinmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.scoreboardImageComp6);
            scoreboardMinmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardComp9, Properties.Resources.scoreboardImageComp9);

            //update maxmode scoreboard dictionaries
            scoreboardMaxmodeOption.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardPub24, pub24);
            scoreboardMaxmodeOption.DictionaryFiles.Add(Properties.Resources.stringComboboxScoreboardPub32, pub32);

            scoreboardMaxmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.scoreboardImagePub24);
            scoreboardMaxmodeOption.DictionaryPictures.Add(Properties.Resources.stringComboboxScoreboardPub32, Properties.Resources.scoreboardImagePub32);

        }

        public void updateOption(Option option)
        {
            //MessageBox.Show(Convert.ToString(option));
            //MessageBox.Show(Convert.ToString(aspectOption));

            if (option == aspectOption)
            {
                //get the new string from the option dictionary and place it in the asset object 
                assetLocation.FilenameHudAspect = option.Update();
            }
            else if (option == scoreboardMinmodeOption || option == scoreboardMaxmodeOption)
            {
                //check both results and modify multiple files
                updateScoreboardFiles();
            }
            else
            { 
                //something went wrong
                mainForm.errorWindow("OptionsTracker.updateOption: Invalid Option: " + option);
            }
        
        
        }


        /// <summary>
        /// Based on the settings for the two scoreboard options, determine which files to point to in the asset object.
        /// </summary>
        private void updateScoreboardFiles()
        {
            //comp6 minmode, pub24 maxmode
            if (_settingMinmodeScoreboard == comp6 && _settingMaxmodeScoreboard == pub24)
            {
                //set the asset object to point to the right files
                assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp6Pub24;
                assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp6Pub24;
                MessageBox.Show(comp6+pub24);
            }
            //comp9 minmode, pub24 maxmode
            else if (_settingMinmodeScoreboard == comp9 && _settingMaxmodeScoreboard == pub24)
            {
                //set the asset object to point to the right files
                assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp9Pub24;
                assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp9Pub24;
                MessageBox.Show(comp9 + pub24);
            }
            //comp6 minmode, pub32 maxmode
            else if (_settingMinmodeScoreboard == comp6 && _settingMaxmodeScoreboard == pub32)
            {
                //set the asset object to point to the right files
                assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp6Pub32;
                assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp6Pub32;
                MessageBox.Show(comp6 + pub32);
            }
            //comp9 minmode, pub32 maxmode
            else if (_settingMinmodeScoreboard == comp9 && _settingMaxmodeScoreboard == pub32)
            {
                //set the asset object to point to the right files
                assetLocation.FilenameHudScoreboard = Properties.Resources.stringFilenameAssetScoreboardComp9Pub32;
                assetLocation.FilenameHudMenu = Properties.Resources.stringFilenameAssetMenuComp9Pub32;
                MessageBox.Show(comp9 + pub32);
            }
            //something went wrong
            else
            {
                //this case is triggered legitimately when the initial values are being set and the second is -1
                //the error messages in each combobox event above should handle everything else
            }
        }


        /// <summary>
        /// Update all relevant elements when an option is changed.
        /// </summary>
        public void Update() //TODO HOOK THIS UP
        {

            //check both comboboxes and identify the right scoreboard files
            updateScoreboardFiles();

            //rebuild text strings
            mainForm.updateStrings();

            //update options string background color
            mainForm.detectOptionsChanges();

            //update install/uninstall buttons
            mainForm.updateButtons();


        }
        

    }
}

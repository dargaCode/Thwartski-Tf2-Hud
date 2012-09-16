using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms; 


namespace Thwartski_Hud_Installer
{
    class Tracker
    {
        //classes to store the value being passed in
        private Buttons buttons = null;
        private Location assetLocation = null;
        private Location installLocation = null;
        private Option aspectOption = null;
        private Option scoreboardMinmodeOption = null;
        private Option scoreboardMaxmodeOption = null;

        //constructor?
        public Tracker(Buttons b, Location asset, Location install, Option aspect, Option scoreMin, Option scoreMax)
        {
            //assign the buttons object
            buttons = b;

            //assign the hud objects
            assetLocation = asset;
            installLocation = install;

            //assign the options objects
            aspectOption = aspect;
            scoreboardMinmodeOption = scoreMin;
            scoreboardMaxmodeOption = scoreMax;
        }

        /// <summary>
        /// Set up the options with the right attributes.
        /// </summary>
        public void Setup()
        { 
            //populate the correct strings, dictionaries, images, and indices
            PopulateOptionsObjects();

            //TODO does anything else happen here? can just cut out the middle man if not
        }

        /// <summary>
        /// Populate the 
        /// </summary>
        private void PopulateOptionsObjects()
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

            //load arrays of strings into the objects (and comboboxes)
            aspectOption.ComboboxStrings = new string[] { Properties.Resources.stringComboboxAspectNormal, Properties.Resources.stringComboboxAspectWidescreen };
            scoreboardMinmodeOption.ComboboxStrings = new string[] { Properties.Resources.stringComboboxScoreboardComp6, Properties.Resources.stringComboboxScoreboardComp9 };
            scoreboardMaxmodeOption.ComboboxStrings = new string[] { Properties.Resources.stringComboboxScoreboardPub24, Properties.Resources.stringComboboxScoreboardPub32 };

            //load initial combobox values //TODO make sure this also works with resaved defaults after install
            aspectOption.Setup();
            scoreboardMinmodeOption.Setup();
            scoreboardMaxmodeOption.Setup();
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
                    GlobalStrings.errorWindow("No match for asset file: " + aspectRatio);
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
        /// Build all the strings for global variables such as install paths and filenames 
        /// </summary>
        public void saveOptions()
        {
            //the settings aren't saved until this method is run so the current options can be compared to the saved settings
            //and the install button can be enabled when options have changed.

            //(the folder browser path is saved right as it changes, so it's left out here)
            aspectOption.Save();
            scoreboardMinmodeOption.Save();
            scoreboardMaxmodeOption.Save();

            //now actually save the settings
            Properties.Settings.Default.Save();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            buttons.Update();
        }

        /// <summary>
        /// Revert the options to their state at the last save 
        /// </summary>
        public void revertOptions()
        {
            //(the folder browser path is saved right as it changes, so it's left out here
            aspectOption.Revert();
            scoreboardMinmodeOption.Revert();
            scoreboardMaxmodeOption.Revert();

            //updated buttons so that the install and uninstall buttons will be in the correct state
            buttons.Update();
        }


        /// <summary>
        /// Check if any options are different from their saved values.
        /// </summary>
        public bool Modified()
        {
            bool optionsModified = false;
            
            //aspect
            if(aspectOption.Modified)
            {
                optionsModified = true;
            }
            //minmode
            if(scoreboardMinmodeOption.Modified)
            {
                optionsModified = true;
            }
            //maxmode
            if(scoreboardMaxmodeOption.Modified)
            {
                optionsModified = true;
            }

            //if any options were different, this will be true
            return optionsModified;
        }

        /// <summary>
        /// check if the hud is installed
        /// </summary>
        /// <returns></returns>
        public bool hudInstalled()
        {
            //check for the version file in the resource folder
            if (System.IO.File.Exists(installLocation.PathFolderHudLocation + Properties.Resources.stringFolderResource + Properties.Resources.stringFilenameInstallVersion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    } //namespace
} //class

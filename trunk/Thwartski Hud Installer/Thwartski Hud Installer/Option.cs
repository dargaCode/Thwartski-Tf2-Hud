using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Thwartski_Hud_Installer
{
    class Option
    {
        //classes to store the value being passed in
        private Installer installer = null;

        //reference to which combox and imagebox they are linked to
        private ComboBox myCombobox = null;
        private PictureBox myPicturebox = null;
        private Label myLabel = null;

        //array of combobox strings
        private string[] _comboboxStrings = null;

            //getters and setters 
            public string[] ComboboxStrings { get { return _comboboxStrings; } set { _comboboxStrings = value; myCombobox.Items.AddRange(value); } } //also populates the combobox

        //dictionary of display text to images
        private Dictionary<string, Bitmap> _dictionaryPictures = new Dictionary<string, Bitmap>();

            //getters and setters
            public Dictionary<string, Bitmap> DictionaryPictures { get { return _dictionaryPictures; } set { _dictionaryPictures = value; } }

        //default setting for this option
        private int _defaultSetting = -1;

            //getters and setters
            public int DefaultSetting { get { return _defaultSetting; } set { _defaultSetting = value; UiUpdate(); } } //also refreshes the UI

        //whether the option has been updated from its default settings
        private bool _modified = false;

            //getters and setters
            public bool Modified { get { return _modified; } set { _modified = value; } } 


        //constructor?
        public Option(Installer i, ComboBox c, PictureBox p, Label l, int index)
        {
            //store the UiTracker
            installer = i;

            //assign the hud objects
            myCombobox = c;
            myPicturebox = p;
            myLabel = l;

            //assign the default setting
            _defaultSetting = index;
        }

        /// <summary>
        /// Set the option's setting to the default value
        /// </summary>
        public void Setup()
        {
            myCombobox.SelectedIndex = _defaultSetting;
        }

        /// <summary>
        /// Update all settings based on the selection, and return a string with the correct filename
        /// </summary>
        public string Update()
        {
            string validResult = PictureDictionaryLookup();

            //the setting was successfully changed
            if (validResult != null)
            {
                //decide whether to update the ui to highlight the new changes
                UiUpdate();

                //return the new setting, which will be sent to the asset object
                return validResult;
            }
            //the setting was not changed
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Update the combobox and image, and return a string with the correct filename
        /// </summary>
        /// <returns></returns>
        private string PictureDictionaryLookup()
        {
            //stops the initial load from breaking
            if (myCombobox.SelectedIndex != -1)
            {
                //Take the string value of the index currently selected
                string currentOption = Convert.ToString(myCombobox.Items[myCombobox.SelectedIndex]);

                //MessageBox.Show("Combobox: " + myCombobox.Name + " = " + Convert.ToString(myCombobox.Items[myCombobox.SelectedIndex]));

                //look up the option value in both dictionaries
                if (DictionaryPictures.ContainsKey(currentOption))
                {
                    //display the matching image in the appropriate picturebox
                    myPicturebox.Image = DictionaryPictures[currentOption];

                    //return the selection so it can be sent to the asset object
                    return currentOption;
                }
                //something went wrong with the dictionary lookup
                else
                {
                    GlobalStrings.errorWindow("No match in dictionary! Object: " + this + " Item: " + currentOption);

                    //don't use this value to modify any other strings
                    return null;
                }
            }
            //the combobox index is -1
            else
            {
                return null;
            }
        }

        /// <summary>
        /// decide whether to update the ui to highlight the new changes
        /// </summary>
        private void UiUpdate() 
            
        //TODO implement
        {
            ////if the hud hasn't been installed, no need to detect options changes
            //if (!installer.isHudInstalled())
            //{
            //    myLabel.BackColor = Color.Empty;
            //
            //    //it doesn't matter yet if the setting has been modified, because it will just refert if not installed
            //    _modified = false;
            //}

            //the option's setting is different from the saved default
            if (myCombobox.SelectedIndex != _defaultSetting)
            {
                //highlight the background
                myLabel.BackColor = Color.LightGreen;

                //the setting has been modified
                _modified = true;
            }
            //the option's setting matches
            else
            {
                myLabel.BackColor = Color.Empty;

                //the setting has not been modified
                _modified = false;
            }
        }

        /// <summary>
        /// Set the option's current setting as its new default setting
        /// </summary>
        public void Save()
        {
            //by using the setter, uiUpdate is called automatically
            this.DefaultSetting = myCombobox.SelectedIndex;
        }

        /// <summary>
        /// Set the option's current setting to its default setting
        /// </summary>
        public void Revert()
        {
            //don't need the setter here.  //TODO always use setters internally?
             myCombobox.SelectedIndex = _defaultSetting;
        }


    } //namespace
} //class

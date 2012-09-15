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
        private Form1 mainForm = null;

        //reference to which combox and imagebox they are linked to
        private ComboBox myCombobox = null;
        private PictureBox myPicturebox = null;

        //dictionary of display text to images
        private Dictionary<string, Bitmap> _dictionaryPictures = new Dictionary<string, Bitmap>();

            //getters and setters
            public Dictionary<string, Bitmap> DictionaryPictures { get { return _dictionaryPictures; } set { _dictionaryPictures = value; } }


        //constructor?
        public Option(Form1 caller, ComboBox combo, PictureBox picture)
        {
            //store the calling form
            mainForm = caller;

            //assign the hud objects
            myCombobox = combo;
            myPicturebox = picture;
        }



        /// <summary>
        /// Update all settings based on the selection, and return a string with the correct filename
        /// </summary>
        public string Update()
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
                    mainForm.errorWindow("No match in dictionary! Object: " + this + " Item: " + currentOption);

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






    }
}

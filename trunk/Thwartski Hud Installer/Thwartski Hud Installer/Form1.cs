using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Thwartski_Hud_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDefaultFolder();
        }

        /// <summary>
        /// Take a guess where the right folder is, and set it as the default location if it exists.
        /// </summary>
        private void SetDefaultFolder()
        {
            string DefaultFolder32Bit = "C:\\Program Files (x86)\\Steam\\steamapps";
            string DefaultFolder64Bit = "C:\\Program Files\\Steam\\steamapps";

            if (Directory.Exists(DefaultFolder32Bit))
            {
                folderBrowserDialog1.SelectedPath = DefaultFolder32Bit;
                folderBrowserTextBox.Text = DefaultFolder32Bit + "\\YOUR_USERNAME\\Team Fortress 2\\";
            }
            else if (Directory.Exists(DefaultFolder64Bit))
	        {
                folderBrowserDialog1.SelectedPath = DefaultFolder64Bit;
                folderBrowserTextBox.Text = DefaultFolder64Bit + "\\YOUR_USERNAME\\Team Fortress 2\\";
	        }
            else
            {
                folderBrowserTextBox.Text = "YOUR_STEAM_FOLDER\\Steamapps\\YOUR_USERNAME\\Team Fortress 2\\";
            }

        }


        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, record their
            // Folder location.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (folderBrowserDialog1.SelectedPath.EndsWith("team fortress 2"))
                {
                    folderBrowserTextBox.Text = folderBrowserDialog1.SelectedPath;
                    folderBrowserTextBox.BackColor = Color.White;
                }

                else
                {
                    MessageBox.Show("Please select \\YOUR_STEAM_FOLDER\\Steamapps\\YOUR_USERNAME\\Team Fortress 2\\");
                }

            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

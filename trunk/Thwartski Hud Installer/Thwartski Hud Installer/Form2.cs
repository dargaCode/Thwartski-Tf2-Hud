using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Thwartski_Hud_Installer
{
    public partial class Form2 : Form
    {
        //global variable strings
        
        //for opening text files
        static string documentationPath; //written at runtime
        static string documentationSubfolder = @"_Thwartski Hud\";
        static string releaseNotesFile = "Thwartski Hud - Release Notes.txt";
        static string readmeFile = "Thwartski Hud - README.txt";
        static string faqFile = "Thwartski Hud - FAQ.txt";

        //error if documentation is not found
        static string exceptionDocumentationMissing = "The documentation file could not be found! \n \nYou may need to reinstall the hud if other files are missing.";

        //somehow making Form1 accessible from by form2
        private Form1 mainForm = null;
        //making form2 accept an argument from the form that created it
        public Form2(Form callingForm, string installationLocation)
        {
            //TODO cleanup form above to be form1?

            //need to understand "as" better
            mainForm = callingForm as Form1;
            InitializeComponent();

            //update the documentation path so text files can be loaded
            documentationPath = installationLocation + documentationSubfolder;
            //MessageBox.Show(documentationPath);
        } 

        //open the release notes file
        private void releaseNotesButton_Click(object sender, EventArgs e)
        {
            //open the documentation at the current path
            openDocumentation(documentationPath + releaseNotesFile);
        }

        //open the readme file
        private void readmeButton_Click(object sender, EventArgs e)
        {
            //open the documentation at the current path
            openDocumentation(documentationPath + readmeFile);
        }

        //open the faq file
        private void faqButton_Click(object sender, EventArgs e)
        {
            //open the documentation at the current path
            openDocumentation(documentationPath + faqFile);
        }

        //when the success form is closed
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //enable form contents on the main form
            this.mainForm.Form1_ReenabledByForm2(null, null);
        }

        private void openDocumentation(string fileToOpen)
        {
            //exception handling for opening documentation
            try
            {
                //open the file passed in from the buttons
                Process.Start(fileToOpen);
            }
            catch (System.Exception)
            {
                //the file probably could not be found
                MessageBox.Show(exceptionDocumentationMissing);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //close form2
            this.Close();
        }

    }
}

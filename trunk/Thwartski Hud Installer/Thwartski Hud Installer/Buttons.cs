using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thwartski_Hud_Installer
{
    class Buttons
    {
        //classes to store the value being passed in
        private Form1 mainForm = null;

        //reference to which buttons it is linked to
        private Button uninstallButton = null;
        private Button installButton = null;

        //common strings used for comparisons
        string installFresh = Properties.Resources.stringButtonInstallFreshMode;
        string modifiedOptions = Properties.Resources.stringButtonInstallOptionsMode;
        string assetsPatched; //TODO implement
        string launchReady = Properties.Resources.stringButtonInstallLaunchMode;


        //constructor?
        public Buttons(Form1 f, Button uninstall, Button install)
        {
            //assign the buttons
            uninstallButton = uninstall;
            installButton = install;

            mainForm = f;

        }



        /// <summary>
        /// Check whether to enable or disable install/uninstall/update buttons
        /// </summary>
        public void Update(bool hudInstalled, bool optionsModified)
        {
            //the hud is currently installed
            if (hudInstalled)
            {
                //always enable the uninstall button if the hud is installed
                uninstallButton.Enabled = true;

                //if the hud is installed but options have changed, install button has special rules
                if (optionsModified)
                {
                    //options mode changes the event on the button and its text
                    installButtonMode(modifiedOptions);
                }
                //if the hud is installed and no options have changed, it's redundant
                else
                {
                    //launch mode changes the event on the button and its text
                    installButtonMode(launchReady);
                }
            }
            //the hud is not currently installed
            else
            {
                //freshMode is the default functionality of allowing a fresh install
                installButtonMode(installFresh);

                //disable uninstall when nothing to uninstall
                uninstallButton.Enabled = false;
            }
        }


        /// <summary>
        /// Change the install button functionality between update and install
        /// </summary>
        private void installButtonMode(string buttonMode)
        {

            //fresh mode
            if (buttonMode == installFresh)
            {
                //update the button text to match the mode
                installButton.Text = buttonMode;

                //clean up old events on the install button
                installButton.Click -= new System.EventHandler(mainForm.installButton_InstallClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_OptionsClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_LaunchClick);

                //change the install button click event to the normal install event
                installButton.Click += new System.EventHandler(mainForm.installButton_InstallClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for fresh mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallFreshMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallFreshMode;

                //generate tooltips with the updated strings
                mainForm.updateTooltips();
            }

            //modified options mode
            else if (buttonMode == modifiedOptions)
            {
                //update the button text to match the mode
                installButton.Text = buttonMode;

                //clean up old events on the install button
                installButton.Click -= new System.EventHandler(mainForm.installButton_InstallClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_OptionsClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_LaunchClick);

                //change the install button click event to the special options event
                installButton.Click += new System.EventHandler(mainForm.installButton_OptionsClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for options mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallOptionsMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallOptionsMode;

                //generate tooltips with the updated strings
                mainForm.updateTooltips();
            }

            //launch mode
            else if (buttonMode == launchReady)
            {
                //update the button text to match the mode
                installButton.Text = buttonMode;

                //clean up old events on the install button
                installButton.Click -= new System.EventHandler(mainForm.installButton_InstallClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_OptionsClick);
                installButton.Click -= new System.EventHandler(mainForm.installButton_LaunchClick);

                //change the install button click event to the special update event
                installButton.Click += new System.EventHandler(mainForm.installButton_LaunchClick);

                //enable the install button
                installButton.Enabled = true;

                //update tooltips for launch mode
                GlobalStrings.TooltipInstallButton = GlobalStrings.TooltipInstallLaunchMode;
                GlobalStrings.TooltipUninstallButton = GlobalStrings.TooltipUninstallFreshMode;

                //generate tooltips with the updated strings
                mainForm.updateTooltips();
            }

            //something broke
            else
            {
                GlobalStrings.errorWindow("debug: invalid install mode! modesetting=" + buttonMode);
            }
        }


    } //namespace
} //class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thwartski_Hud_Installer
{
    class UiController
    {

        //form to store the value being passed in
        private Form1 mainForm = null;

        //constructor?
        public UiController(Form1 caller)
        {
            //store the calling form
            mainForm = caller;
        } 

        
    }
}

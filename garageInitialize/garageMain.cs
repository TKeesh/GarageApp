﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using garageWF;
using garageController;
using garageUtility;

namespace garageInitialize
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(controller));
        }
    }
}

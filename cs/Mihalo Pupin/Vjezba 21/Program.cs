﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prosti.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string fileName = null;
            if (args.Length != 0)
                fileName = args[0];

            Application.Run(new frmMain(fileName));
        }
    }
}

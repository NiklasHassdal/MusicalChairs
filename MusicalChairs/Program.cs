﻿using System;
using System.Windows.Forms;

namespace MusicalChairs
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}

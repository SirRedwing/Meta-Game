// File/Project Prolog
// Name:     <PUT YOUR NAME HERE>
// Period:   <PUT YOUR PERIOD HERE>
// Username: campbcol007
// Project:  Meta_Game
// Date:     4/12/2018 1:42:57 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Meta_Game {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Meta_Game {
    public partial class Welcome: Form {
        public Welcome() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Game play = new Game();
            play.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

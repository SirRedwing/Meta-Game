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
            ActivateHide();
        }

        public void ActivateHide()
        {
            Option1.Hide();
            Option2.Hide();
            Option3.Hide();
            Option4.Hide();
            OpeningDialogue.Hide();
        }
        public void ActivateShow() {
            Option1.Show();
            Option2.Show();
            Option3.Show();
            Option4.Show();
            OpeningDialogue.Show();
        }

        public void Button1_Click(object sender, EventArgs e) {
            ActivateShow();
        }
    }
}

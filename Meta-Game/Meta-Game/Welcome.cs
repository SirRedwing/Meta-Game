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

        private bool ActivateHide()
        {
            List<Button> options = new List<Button> {Option1, Option2, Option3, Option4};
            foreach (Button option in options)
            {
                Hide();
            }
            OpeningDialogue.Hide();
        }
    }
}

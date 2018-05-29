using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Game {
    class BusyBee {

        public Form f;

        public BusyBee(Form f) {
            this.f = f;
        }

        public void DrawAgain() {
            f.Refresh();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meta_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.Anchor = 
        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitDialog ed = new ExitDialog();
            ed.Show();
            //MessageBox.Show("Why are you leaving? Aren't you having fun?");
            e.Cancel = true;
        }
        private void Menu_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Windows.Forms;

namespace Meta_Game
{
    public partial class ExitDialog : Form
    {

        public ExitDialog()
        {
            InitializeComponent();
        }

        private void ExitDialog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
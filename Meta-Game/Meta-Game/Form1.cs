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
        public int pointValue = 0;
        public Form1()
        {
            InitializeComponent();

            flower.Hide();
        }
        public void Randomness()
        {
            Random randNum = new Random();
            int nextBox = randNum.Next(0, 8);
            Button[] buttons = new Button[] { flower }; // ...
            Button button = buttons[nextBox];
            button.Show();
        }

        public void Points()
        {
            pointValue++;
            flower.Location = new Point(4, 1);
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
            ExitDialog exit = new ExitDialog();
            exit.Show();
            e.Cancel = true;
        }
        private void Menu_Click(object sender, EventArgs e)
        {

        }
        private void Button10_Click(object sender, EventArgs e)
        {
            Randomness();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //button1.Hide();
            Points();
        }
    }
}

using System;
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
            textBox1.Text = $"{pointValue}";
        }
        public void RandomMove()
        {
            Random randNum = new Random();

            int newPositionX = randNum.Next(10, 1190);
            int newPositionY = randNum.Next(10, 710);
            flower.Location = new Point(newPositionX, newPositionY);
        }

        public void Points()
        {
            pointValue++;
            textBox1.Text = $"{pointValue}";
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
            RandomMove();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //button1.Hide();
            Points();
            RandomMove();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

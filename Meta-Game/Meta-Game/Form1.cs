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



            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
        }
        public void Randomness()
        {
            Random randNum = new Random();
            int nextBox = randNum.Next(0, 8);
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 }; // ...
            Button button = buttons[nextBox];
            button.Show();
        }

        public void Points()
        {
            pointValue++;
            button1.Location = new Point(4, 1);
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

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button5.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
        }
    }
}

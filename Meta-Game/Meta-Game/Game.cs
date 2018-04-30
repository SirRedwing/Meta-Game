using System;
using System.Drawing;
using System.Windows.Forms;

namespace Meta_Game
{
    public partial class Game : Form
    {
        public int pointValue;
        public Game()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            PointsBox.Text = String.Format($"{0}", pointValue);
        }
        public void RandomMove()
        {
            Random randNum = new Random();

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }

        public void RandomImage()
        {
            Random randImg = new Random();

            int nextImg = randImg.Next(1, 3);
            switch (nextImg)
            {
                case 1:
                    flower.Image = Properties.Resources.Flower_1;
                    System.Diagnostics.Debug.WriteLine("Came out as 1");
                    break;

                case 2:
                    flower.Image = Properties.Resources.Flower_2;
                    System.Diagnostics.Debug.WriteLine("Came out as 2");
                    break;
            }
        }

        public void Points()
        {
            pointValue++;
            PointsBox.Text = String.Format($"{0}", pointValue);
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

        private void Flower_Click(object sender, EventArgs e)
        {
            Points();
            RandomMove();
            RandomImage();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

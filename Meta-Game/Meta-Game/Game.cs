using System;
using System.Drawing;
using System.Windows.Forms;

namespace Meta_Game {
    public partial class Game: Form {
        public int PointValue;
        public Game() {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            PointsBox.Text = String.Format($"{0}", PointValue);
        }
        private static void Shake(Form form) {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shakeAmplitude = 1;
            for(int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shakeAmplitude, shakeAmplitude), original.Y + rnd.Next(-shakeAmplitude, shakeAmplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        private void RandomMove() {
            Random randNum = new Random();

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }

        private void RandomImage() {
            Random randImg = new Random();

            int nextImg = randImg.Next(1, 3);
            switch(nextImg) {
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

        private void Points() {
            PointValue++;
            PointsBox.Text = String.Format($"{PointValue}");
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e) {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            ExitDialog exit = new ExitDialog();
            exit.Show();
            e.Cancel = true;
        }
        private void Menu_Click(object sender, EventArgs e) {

        }
        private void Button10_Click(object sender, EventArgs e) {
            Shake(this);
            Points();
            
        }

        private void Flower_Click(object sender, EventArgs e) {
            Points();
            RandomMove();
            RandomImage();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Game_Load(object sender, EventArgs e) {

        }
    }
}

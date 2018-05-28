using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Meta_Game
{
    public partial class Game : Form
    {
        private int pointValue;
        int shakeCalled = 1;
        int glitchPressed;

        private List<Action> pointChangeEventsList = new List<Action>();
        public Game()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            PointsBox.Text = String.Format($"{0}", pointValue);
            button2.Hide();
            ActivateGlitch();
        }

        private void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            int shakeAmplitude = shakeCalled;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shakeAmplitude, shakeAmplitude), original.Y + rnd.Next(-shakeAmplitude, shakeAmplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        private void RandomMove()
        {
            Random randNum = new Random();

            if (randNum.Next(1, 5) == 3)
            {
                button2.Show();
            }

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }

        private void RandomGlitch()
        {
            Random randNum = new Random();

            if (randNum.Next(1, 5) == 3)
            {
                button2.Show();
            }

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }
        private void RandomImage()
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

        private void Points()
        {
            pointValue++;
            PointsBox.Text = String.Format($"{pointValue}");
            OnPointValueChange();
        }
        private void OnPointValueChange()
        {
            pointChangeEventsList.Add(FakeError);
            foreach (Action pointMethod in pointChangeEventsList)
            {
                pointChangeEventsList[0]();
            }

        }

        private void FakeError()
        {
            if (pointValue == 67)
            {
                if (!File.Exists("config.txt"))
                {
                    pointValue = Int32.MaxValue;
                    PointsBox.Text = String.Format($"{pointValue}");
                    Refresh();
                    MessageBox.Show(@"Int Overflow, restart the application", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string errorstate = "1";
                    File.WriteAllText("config.txt", errorstate);
                    Environment.Exit(0);
                }
            }

        }

        private void ActivateGlitch()
        {
            if (File.Exists("config.txt") && File.ReadAllText("config.txt") == "1")
            {
                button2.Show();
            }
        }

        private void ErrorPress()
        {
            glitchPressed++;

            switch(glitchPressed){
                case 1:
                    MessageBox.Show(@"“Don’t touch that!”", @"Stop",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    MessageBox.Show(@"”St̷̛̺͉̙͓̳̻̻͂̒̂̔̓͊͛͋̒̈̋͜͝͝op it!”", @"Please",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show(@"“What are you ̴̨̥̳̠̠͖͎̩̰̾̄̄̎̓̾͌̈͒͂̑̓̐̏͝d̷̡̰̼̪̮̞̘̭̹̻̬̐̆̒͠ͅͅő̷̳͖̺͈̟͓̖͋̋ͅͅï̶̦̤͓̖̪̯̝̲͔̣̗͕̩̑̅̈́͆͗̔̿̌͊̅͘n̴̡̨̺͎͎͈͖͕̖̏͐̌̅̔̆̚̚̚g̷̥͕̗͉̿̕͠”", @"Why?",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case 4:
                    MessageBox.Show(@"̶̢̢̮̣͈͓̰͉̝̼̺̓̈́̇͒̅͂̇̈̀͘Ḟ̴̛̖͆̀́̿̐̍̋̓͂̉͒͘o̸͔̱̟͎̱̠̤͈̹̿̾ͅͅl̵͈͍̳̟̘͙̹͇͙̬̯̘̳͚̋̓̓͋ͅl̵̹̘̮̇̏̇͌̋̄ͅọ̵̻͛͗̆̔̂̔̾̋̾̏́w̸̟̝̮̟̭̜̥͔͇̥͚̑̓͋ ̶̤̜͂͂̏͘t̴̩͍͉͈̻͎̰͔̥̄̓͐̍̚ĥ̶̹̬̗̳͓͉̬̭͉̩̍̍̾̿̆̅́̋͠ͅͅë̴͈͙͉̂͐̓ ̶̥͇̞̝̩̺̞͍̜̀̈͂̀̋͊̓͊͊̐i̸̬͙̪͎̪͔̞̫̳͖͒̈́̓̍̇̈̂͜͠͠n̴͕̺̰̜̗̖͐͝s̷̡̭̤̼̥̠̤̝͈̼͖͋̾͑̈́̈́́̀͑̑͝ṯ̵̟̌͛ȑ̷̛̛͉̱̜̟̗̠͔̫͚̜̜̥͇̊̎̀̿͐̾̌̑̃̿̚͝uctions!”", @"STOP",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case 5:
                    MessageBox.Show(@"“y̶̡̢̛͍̳̥̯̯̱̹̻̥̑̐̇̏̒͌͘͠o̵̡̡͉̬͖̰̻͓̼̭͎̠̓͊̓̍́̈́͆̈̒̄̽͠ů̶̝̦̬̐̾̀̔̇̊̽͘͘'̴̢̹͈̬̘͓̬͍̬̬̥͚̹̊͂̔̍͆̚ŗ̷͍͉̤͇̟̗͙͔̀̓̅̌̊̓͐̀͐̈͗͆̀ḕ̷͎͈̉̿̾͒͌̊́̅́̐́̔ ̶̬̫͇̺̀͜k̷̨̧̛̰̻͉̲̟̟͍̬̘͇̜̜̅̌̿̿̔̑̃̃̿͛́͆̕͝i̴̻̱̪̜͕͚͒̃̈̈́̍̈́̈́̈́͜l̵̬͍̽́l̴̖̫̤̝̮̈́i̶̼͇͛̈́ṅ̷̳̮͚̪̩̿͐̽͜͝g̷̩̙͉̯͙͖̩̹͗̅̑ ̴̦͖̞͉̘̯̜́ͅh̷̨̩̫̟̥̪̱̤̳̫̣͖̼̒͋̈́̄͌̌̀͝ȉ̷͖̣͖ḿ̶̢̢̥̫̗͇̥͙̰̇͂̀̊̿͗̈́͘͜͠͝͠͝”", @"*sob*",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show(@"g̵̡̯̝̥̖̋͗̀̏̊͌́̽̈́̂͒͘̕͝ͅa̸̻̖͓͙̞͈̗̫̥̐͒̿̓̈́͂͋t̵̖̦̔̆̋̿̾̈́̍̔̋͋̀̒̕h̸͙̞̙̯̦͒e̷̡͚̙̖̠͋̋̊̍͊̿́́̓̽ṙ̵͙̪̮̮̂͆͘͜͜.̸̨̢̡̡̧̗͚͉͕̱̱̯̦̼̻̄̄̐̽ẻ̵̳̣̼͈̞̬̩̺̼̈́x̷̨̡̨̛̲̙͇̰̭͓̜̜̮͉̪̋̔̈̓̄̎͜e̵̲̟̽͋̀͒̾͊͛̾̿̌̓̆͆ ̷̧̻͚̳̹͎̭̹͕̦̜̰̽̂̑̔̌̓̉͗̒͛̐͜͝͠h̶̰͑̈́̽͌̎̕͘ḁ̶̛̱͔̞̝̝̃̀̅͋͊̒s̷̞̀̈́ ̶̢͍̻̳̠͖͙̳̟͕̻̇͆̍̾͘͜͠ͅͅs̷̖̥̺͖̬͖͔̪͂̈́̍̉̋͌͜͜͜͝͝ẗ̴̨̛͓̗̹̬̟̠̦̝́͒̐̈̑̚͠ő̷̗͍̩̘͓̩͇̩̪̖̟̟̐̽̏́̂̓͘͝ṕ̴̼̺̰̹̻̻͎̬̠̎͐͗͛̌̔̀̃͘̚̕͠͝p̴̘͉͖͕̈͂̍̂͒̒̃̓̈́ȩ̶̨̡̜̰̜̯͍̲̗͉͎̙̫̭̒̊̕͝d̴̝͔̖̹̋̀͜ ̸̝̹͇͒̆̀̎͆͠w̷̧̢̛̭͓̫̥̻̜̖̻̟̫͚̥̫̍͌͗͐̂̏̌̂͘o̶̡̧̧̗̼͔̻̜̺̲̱̙͙̽̈́̎̀̓͗͠ṛ̶̨͌̈͛̀̂͂̓̓k̴͎̹͊̐̑͑ī̵͖͎̫̱̯̞͚̖̲̹̥̰̍̃͋̋͆͌̄̃͘n̶͎̮̯̻͇̱̲̾͆̾̂͂͊͜g̷̠̰͉̣̮̰̗̣̘͕͔͕̍͋̈́͌̈̆͊̃͝͠", @"...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    string errorState2 = "2";
                    File.WriteAllText("config.txt", errorState2);

                    Environment.Exit(1);
                    break;
            }
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
            Points();

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

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            Shake(this);
            ErrorPress();
            shakeCalled++;
            if(shakeCalled == 6)
            {
                shakeCalled = 100;
            }
            RandomGlitch();
            pointValue = pointValue + 200;
            PointsBox.Text = String.Format($"{pointValue}");
            Refresh();
        }
    }
}
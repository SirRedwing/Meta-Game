using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Meta_Game {
    public partial class Game: Form {
        //Int that stores the value for how many points the player has acquired.
        private int pointValue;
        //Int that stores the value for how hard the screen is supposed to shake during the Shake function.
        int shakeCalled = 1;
        //Count's how many times the "glitch" object was pressed.
        int glitchPressed;
        //Creates a variable to run the music.
        private SoundPlayer music;

        private List<Action> pointChangeEventsList = new List<Action>();
        public Game() {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            PointsBox.Text = String.Format($"{0}", pointValue);
            button2.Hide();
            ActivateGlitch();
            PlayMusic();
        }
        //Make's the music go.
        private void PlayMusic() {
            if(File.Exists("config.txt") && File.ReadAllText("config.txt") == "1") {
                music = new SoundPlayer(Properties.Resources.halfbitfreaky);
                music.PlayLooping();
            } else {
                music = new SoundPlayer(Properties.Resources.HalfBit);
                music.PlayLooping();
            }
        }
        //Makes the window shake.
        private void Shake(Form form) {
            var original = form.Location;
            var rnd = new Random(1337);
            int shakeAmplitude = shakeCalled;
            for(int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shakeAmplitude, shakeAmplitude), original.Y + rnd.Next(-shakeAmplitude, shakeAmplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
        //Moves an object around randomly.
        private void RandomMove() {
            Random randNum = new Random();
            if(File.Exists("config.txt") && File.ReadAllText("config.txt") == "1") {
                if(randNum.Next(1, 5) == 3) {
                    button2.Show();
                }
            }

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }
        //Makes the "glitch" object move around and randomly appear.
        private void RandomGlitch() {
            Random randNum = new Random();

            if(randNum.Next(1, 5) == 3) {
                button2.Show();
            }

            int newPositionX = randNum.Next(200, 1000);
            int newPositionY = randNum.Next(200, 520);
            flower.Location = new Point(newPositionX, newPositionY);
        }
        //Changes the image on one of the objects randomly.
        private void RandomImage() {
            Random randImg = new Random();

            int nextImg = randImg.Next(1, 2);
            switch(nextImg) {
                case 1:
                    flower.Image = Properties.Resources.Flower_1;
                    break;

                case 2:
                    flower.Image = Properties.Resources.Flower_2;
                    break;
            }
        }
        //Iterates points everytime the player does what they are supposed to do.
        private void Points() {
            pointValue++;
            PointsBox.Text = String.Format($"{pointValue}");
            FakeError();
        }
        //Calls a fake error message and closes the application.
        private void FakeError() {
            if(pointValue == 67) {
                if(!File.Exists("config.txt")) {
                    pointValue = Int32.MaxValue;
                    PointsBox.Text = String.Format($"{pointValue}");
                    Refresh();
                    MessageBox.Show(@"Int Overflow, restart the application", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string errorstate = "1";
                    File.WriteAllText("config.txt", errorstate);
                    Application.Exit();
                }
            }

        }
        //Activates stage 2.
        private void ActivateGlitch() {
            if(File.Exists("config.txt") && File.ReadAllText("config.txt") == "1") {
                button2.Show();
            }
        }
        //Iterates everytime the "glitch" is clicked on.
        private void ErrorPress() {
            glitchPressed++;

            switch(glitchPressed) {
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

                    Application.Exit();
                    break;
            }
        }
        //Prevents user from closing program, except when the program closes itself.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if(e.CloseReason == CloseReason.UserClosing) {
                ExitDialog exit = new ExitDialog();
                exit.Show();
                e.Cancel = true;
            }
        }
        //Occurs whenever an object is clicked.
        private void Flower_Click(object sender, EventArgs e) {
            Points();
            RandomMove();
            RandomImage();
        }
        //Occurs whenever the "glitch" is clicked.
        private void Button2_Click(object sender, EventArgs e) {
            button2.Hide();
            Shake(this);
            ErrorPress();
            shakeCalled++;
            if(shakeCalled == 6) {
                shakeCalled = 100;
            }
            RandomGlitch();
            pointValue = pointValue + 200;
            PointsBox.Text = String.Format($"{pointValue}");
            Refresh();
        }
    }
}
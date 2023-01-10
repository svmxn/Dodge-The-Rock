using System.Drawing.Text;

namespace DodgeTheRock
{
    public partial class carGame : Form
    {
        int carSpeed;
        int roadSpeed;
        int rockSpeed;
        int carLane = 3;
        int pos1 = 32;
        int pos2 = 185;
        int pos3 = 330;
        int pos4 = 477;
        int pos5 = 627;
        Random rand = new Random();
        int rockLane;

        public carGame()
        {
            InitializeComponent();
        }

        private void carGame_Load(object sender, EventArgs e)
        {
            rock1.Location = new Point(pos1, -200);
            rock2.Location = new Point(pos2, -200);
            rock3.Location = new Point(pos3, -200);
            rock4.Location = new Point(pos4, -200);
            rock5.Location = new Point(pos5, -200);
            stopGame();            
        }

        private void carGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) 
            {
                e.Handled = true;
                moveLeft();
                return;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                e.Handled = true;
                moveRight();
                return;
            }         

            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                stopGame();
                menu();
            }
        }

        private void background_Tick(object sender, EventArgs e)
        {
            rollBackground();
        }

        private void rollRockTimer_Tick(object sender, EventArgs e)
        {
            int lastRock = rockLane;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "rock")
                {
                    if (x.Location.Y == 0)
                    {
                        while (rockLane == lastRock)
                        {
                            rockLane = rand.Next(1, 6);
                        }
                        rollRock(rockLane);
                    }

                    if (racecar.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver();
                    }
                }
            }
        }

        private void moveLeft()
        {
            switch (carLane)
            {
                case 1:
                    for (int i = 0; i < pos1; i++)
                    {
                        if (i <= (pos1 / 2))
                        {
                            racecar.Location = new Point(racecar.Location.X - 1, 550);
                        }
                        else
                        {
                            racecar.Location = new Point(racecar.Location.X + 1, 550);
                        }
                    }
                    racecar.Location = new Point(pos1, 550);
                    break;
                case 2:
                    while (racecar.Location.X != pos1)
                    {
                        racecar.Location = new Point(racecar.Location.X - carSpeed, 550);
                        if (racecar.Location.X < pos1)
                        {
                            racecar.Location = new Point(pos1, 550);
                        }
                    }
                    carLane = 1;
                    break;
                case 3:
                    while (racecar.Location.X != pos2)
                    {
                        racecar.Location = new Point(racecar.Location.X - carSpeed, 550);
                        if (racecar.Location.X < pos2)
                        {
                            racecar.Location = new Point(pos2, 550);
                        }
                    }
                    carLane = 2;
                    break;
                case 4:
                    while (racecar.Location.X != pos3)
                    {
                        racecar.Location = new Point(racecar.Location.X - carSpeed, 550);
                        if (racecar.Location.X < pos3)
                        {
                            racecar.Location = new Point(pos3, 550);
                        }
                    }
                    carLane = 3;
                    break;
                case 5:
                    while (racecar.Location.X != pos4)
                    {
                        racecar.Location = new Point(racecar.Location.X - carSpeed, 550);
                        if (racecar.Location.X < pos4)
                        {
                            racecar.Location = new Point(pos4, 550);
                        }
                    }
                    carLane = 4;
                    break;
            }
        }

        private void moveRight()
        {
            switch (carLane)
            {
                case 1:
                    while (racecar.Location.X != pos2)
                    {
                        racecar.Location = new Point(racecar.Location.X + carSpeed, 550);
                        if (racecar.Location.X > pos2)
                        {
                            racecar.Location = new Point(pos2, 550);
                        }
                    }
                    carLane = 2;
                    break;
                case 2:
                    while (racecar.Location.X != pos3)
                    {
                        racecar.Location = new Point(racecar.Location.X + carSpeed, 550);
                        if (racecar.Location.X > pos3)
                        {
                            racecar.Location = new Point(pos3, 550);
                        }
                    }
                    carLane = 3;
                    break;
                case 3:
                    while (racecar.Location.X != pos4)
                    {
                        racecar.Location = new Point(racecar.Location.X + carSpeed, 550);
                        if (racecar.Location.X > pos4)
                        {
                            racecar.Location = new Point(pos4, 550);
                        }
                    }
                    carLane = 4;
                    break;
                case 4:
                    while (racecar.Location.X != pos5)
                    {
                        racecar.Location = new Point(racecar.Location.X + carSpeed, 550);
                        if (racecar.Location.X > pos5)
                        {
                            racecar.Location = new Point(pos5, 550);
                        }
                    }
                    carLane = 5;
                    break;
                case 5:
                    for (int i = 0; i < pos1; i++)
                    {
                        if (i <= (pos1 / 2))
                        {
                            racecar.Location = new Point(racecar.Location.X + 1, 550);
                        }
                        else
                        {
                            racecar.Location = new Point(racecar.Location.X - 1, 550);
                        }
                    }
                    racecar.Location = new Point(pos5, 550);
                    break;
            }
        }

        private void rollBackground()
        {
            raceTrack.Location = new Point(0, raceTrack.Location.Y + roadSpeed);
            raceTrack1.Location = new Point(0, raceTrack1.Location.Y + roadSpeed);
            if (raceTrack1.Location.Y == 0)
            {
                raceTrack.Location = new Point(0, -285);
            }
            if (raceTrack.Location.Y == 0)
            {
                raceTrack1.Location = new Point(0, -285);
            }
        }

        private void rollRock(int rockLane)
        {
            switch (rockLane)
            {
                case 1:
                    rock1Timer.Enabled = true;
                    break;
                case 2:
                    rock2Timer.Enabled = true;
                    break;
                case 3:
                    rock3Timer.Enabled = true;
                    break;
                case 4:
                    rock4Timer.Enabled = true;
                    break;
                case 5:
                    rock5Timer.Enabled = true;
                    break;
            }
        }

        private void menu()
        {
            menuPic.Visible = true;
            startBtn.Visible = true;
            changeBtn.Visible = true;
            exitBtn.Visible = true;
            menuPic.BringToFront();
            startBtn.BringToFront();
            changeBtn.BringToFront();
            exitBtn.BringToFront();
        }

        private void hideMenu()
        {
            menuPic.Visible = false;
            startBtn.Visible = false;
            changeBtn.Visible = false;
            exitBtn.Visible = false;
        }

        private void stopGame()
        {
            carSpeed = 0;
            roadSpeed = 0;
            rockSpeed = 0;
        }

        private void gameOver()
        {
            gameOverPic.Visible = true;
            gameOverText.Visible = true;
            gameOverText.BringToFront();
            pressEnterText.Visible = true;
            pressEnterText.BringToFront();
        }

        private void rock1Timer_Tick(object sender, EventArgs e)
        {
            rock1.Location = new Point(pos1, rock1.Location.Y + rockSpeed);
            if (rock1.Location.Y == 800)
            {
                rock1.Location = new Point(pos1, -200);
                rock1Timer.Enabled = false;
            }
        }

        private void rock2Timer_Tick(object sender, EventArgs e)
        {
            rock2.Location = new Point(pos2, rock2.Location.Y + rockSpeed);
            if (rock2.Location.Y == 800)
            {
                rock2.Location = new Point(pos1, -200);
                rock2Timer.Enabled = false;
            }
        }

        private void rock3Timer_Tick(object sender, EventArgs e)
        {
            rock3.Location = new Point(pos3, rock3.Location.Y + rockSpeed);
            if (rock3.Location.Y == 800)
            {
                rock3.Location = new Point(pos1, -200);
                rock3Timer.Enabled = false;
            }
        }

        private void rock4Timer_Tick(object sender, EventArgs e)
        {
            rock4.Location = new Point(pos4, rock4.Location.Y + rockSpeed);
            if (rock4.Location.Y == 800)
            {
                rock4.Location = new Point(pos1, -200);
                rock4Timer.Enabled = false;
            }
        }

        private void rock5Timer_Tick(object sender, EventArgs e)
        {
            rock5.Location = new Point(pos5, rock5.Location.Y + rockSpeed);
            if (rock5.Location.Y == 800)
            {
                rock5.Location = new Point(pos1, -200);
                rock5Timer.Enabled = false;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            rockLane = rand.Next(1, 6);
            rollRock(rockLane);
            carSpeed = 10;
            roadSpeed = 5;
            rockSpeed = 10;
            menuPic.Visible = false;
            startBtn.Visible = false;
            changeBtn.Visible = false;
            exitBtn.Visible = false;
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && gameOverPic.Visible == true && gameOverText.Visible == true && pressEnterText.Visible == true)
            {
                menu();
                gameOverPic.Visible = false;
                gameOverText.Visible = false;
                pressEnterText.Visible = false;
                gameOverText.SendToBack();
                pressEnterText.SendToBack();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
using System;
using System.Windows.Forms;

namespace BalloonArcade
{
    public partial class Form1 : Form
    {
        int score;
        int speed;
        Random rnd = new Random();
        bool gameOver;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MakeEventTime(object sender, EventArgs e)
        {
            txtScore.Text = "Score:" + score;
            if (gameOver == true)
            {
                timer1.Stop();
                txtScore.Text = "Score:" + score+ " Oyun Bitti.";

            }
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    control.Top -= speed;

                    if (control.Top < -100)
                    {
                        control.Top = rnd.Next(750, 1000);
                        control.Left = rnd.Next(5, 500);
                    }
                    if ((string)control.Tag == "balloon" && control.Top < -50)
                    {
                        timer1.Stop();
                        txtScore.Text += "Oyun Bitti";
                        gameOver = true;
                    }
                }
            }
            if (score >= 10)
            {
                speed = 8;
            }
            if (score >= 20) { speed = 16; }
            if (score >= 35) { speed = 20; }
        }

        private void PopBalloon(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                
                var balloon = (PictureBox)sender;
               
                balloon.Top = rnd.Next(750, 1000);
                balloon.Left = rnd.Next(5, 500);
                score = score + 5;
            }
        }

        private void AfterPlayer(object sender, EventArgs e)
        {

        }

        private void BeforePlayer(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;
            foreach (Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    control.Top = rnd.Next(750, 1000);
                    control.Left= rnd.Next(5, 500);
                }
                

            }
            
            txtScore.Text = "Score:" + score;
            timer1.Start();
        }

       

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_School
{
    public partial class grade2secondgame : Form
    {

        Studenthomepage frm1;
        public grade2secondgame(Studenthomepage fr1)
        {
            InitializeComponent();
            LoadPicture();
            frm1 = fr1;
           
        }
       
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstchoice;
        string secondchoice;
        int tries;
        int yourscore;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 60;
        int countDownTime;
        bool gameOver = false;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RestartGame();
            label10.Hide();
            tries = 0;
            score.Text = "0";
            yourscore = 0;
            button1.Enabled = false;
            button1.Text = "RESTART (0)";
        }

        private void LoadPicture()
        {
            int leftpos = 260;
            int toppos = 190;
            int rows = 0;

            for (int i=0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += newPic_Click;
                pictures.Add(newPic);

                if(rows < 3)
                {
                    rows++;
                    newPic.Left = leftpos;
                    newPic.Top = toppos;

                    this.Controls.Add(newPic);
                    leftpos = leftpos + 60;
                }
                if(rows == 3)
                {
                    leftpos = 260;
                    toppos += 60;
                    rows = 0;
                }
            }
            RestartGame();
        }

        private void newPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (firstchoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("e-guess shapes/" + (string)picA.Tag + ".png");
                    firstchoice = (string)picA.Tag;
                }
            }
            else if (secondchoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("e-guess shapes/" + (string)picB.Tag + ".png");
                    secondchoice = (string)picB.Tag;
                }
            }
            else
            {
                Checkpictures(picA, picB);
            }
        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(o => Guid.NewGuid()).ToList();
            numbers = randomList;
            statuslbl.Text = "Playing";
            
            panel3.Hide();

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            mismatch.Text = tries.ToString();
            gameOver = false;
            timer1.Start();
            countDownTime = totalTime;

                
        }

        private void Checkpictures(PictureBox A, PictureBox B)
        {
            if(firstchoice == secondchoice)
            {
                A.Tag = null;
                B.Tag = null;
                yourscore++;
                score.Text = yourscore.ToString(); 

            }
            else
            {
                tries++;
                mismatch.Text = tries.ToString();
            }

            firstchoice = null;
            secondchoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if(pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if(pictures.All( o => o.Tag == pictures[0].Tag))
            {
                GameOver("YOU WON !!!");
                timer1.Stop();
                statuslbl.Text = "FINISHED";
                label10.Show();
            }
        }

        private void GameOver(string msg)
        {
            timer1.Stop();
            gameOver = true;
            statuslbl.Text = msg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want to exit? \nSee the 'help' from homepage for more information. Thank you!", "Notice.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("You will lose your progress and you cannot retrieve all your scores from this game. \nPlease contact your guardian for assistance.", "Quit Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    frm1.Show();
                    this.Hide();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grade2secondgame_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            label11.Hide();
            label10.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDownTime--;
            label4.Text = countDownTime.ToString();

            if(countDownTime < 1)
            {
                GameOver("TIME IS UP !");
                button2.Enabled = true;
                panel3.Show();
                timer1.Stop();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.pictureBox6.Hide();
            frm1.Show();
            frm1.label10.Text = yourscore.ToString() + "/6";
            this.Hide();
            frm1.button7.Enabled = false;
            frm1.thirdsecondscore1 = yourscore.ToString();
            frm1.width += 183;
            frm1.progressbar.Start();
        }

        private void score_TextChanged(object sender, EventArgs e)
        {
            if(score.Text == "6")
            {
                button2.Enabled = true;
                timer1.Stop();
                statuslbl.Text = "FINISHED";
                label10.Show();
                label11.Show();
                GameOver("YOU GOT PERFECT SCORE 6/6 !!!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

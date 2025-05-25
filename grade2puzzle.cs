using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Math_School
{
    public partial class grade2puzzle : Form
    {
        Studenthomepage frm1;
        public grade2puzzle(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;
        }
        int correctanswer;
        int score;
        int question;
        int questionlevel = 1;
        private void grade2puzzle_Load(object sender, EventArgs e)
        {
            Levels(1);
            givenpic1.SizeMode = PictureBoxSizeMode.Normal;
            givenpic2.SizeMode = PictureBoxSizeMode.Normal;
            givenpic3.SizeMode = PictureBoxSizeMode.Normal;
            givenpic4.SizeMode = PictureBoxSizeMode.Normal;
            label2.Hide();
            label3.Hide();
            label7.Hide();
            label6.Hide();
            panel1.Hide();
            finalpanel.Hide();
            label4.Hide();
            pictureBox5.Hide();
            Introduction();
        }

        private async void Introduction()
        {
            await Task.Delay(2050);
            label5.Hide();
            label2.Show();
            await Task.Delay(3000);
            label4.Show();
            label2.Hide();
            pictureBox5.Show();
            label6.Show();
            await Task.Delay(5060);
            label4.Hide();
            label6.Hide();
            pictureBox5.Hide();
            cover.Hide();
            givenpic1.SizeMode = PictureBoxSizeMode.StretchImage;
            givenpic2.SizeMode = PictureBoxSizeMode.StretchImage;
            givenpic3.SizeMode = PictureBoxSizeMode.StretchImage;
            givenpic4.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(5060);
            label6.Hide();

        }

        private void Levels(int level)
        {
            switch (level)
            {
                case 1:
                    question = 1;
                    givenpic1.Image = Image.FromFile("puzzlegrade2/question1.jpg");
                    givenpic2.Image = Image.FromFile("puzzlegrade2/question2.jpg");
                    givenpic3.Image = Image.FromFile("puzzlegrade2/question3.jpg");
                    givenpic4.Image = Image.FromFile("puzzlegrade2/question4.jpg");


                    pic1.Image = Image.FromFile("puzzlegrade2/a.jpg");
                    pic2.Image = Image.FromFile("puzzlegrade2/b.jpg");
                    pic3.Image = Image.FromFile("puzzlegrade2/question5.jpg");
                    pic4.Image = Image.FromFile("puzzlegrade2/g.jpg");
                    pic5.Image = Image.FromFile("puzzlegrade2/e.jpg");
                    break;
                case 2:
                    question = 2;
                    pic1.Left = 118;
                    pic1.Top = 509;
                    pic2.Left = 77;
                    pic2.Top = 488;
                    pic3.Left = 143;
                    pic3.Top = 469;
                    pic4.Left = 206;
                    pic4.Top = 488;
                    pic5.Left = 166;
                    pic5.Top = 509;
                    givenpic1.Image = Image.FromFile("puzzlegrade2/2question1.jpg");
                    givenpic2.Image = Image.FromFile("puzzlegrade2/2question2.jpg");
                    givenpic3.Image = Image.FromFile("puzzlegrade2/2question3.jpg");
                    givenpic4.Image = Image.FromFile("puzzlegrade2/2question4.jpg");


                    pic1.Image = Image.FromFile("puzzlegrade2/a2.jpg");
                    pic2.Image = Image.FromFile("puzzlegrade2/b2.jpg");
                    pic3.Image = Image.FromFile("puzzlegrade2/2question1.jpg");
                    pic4.Image = Image.FromFile("puzzlegrade2/b3.jpg");
                    pic5.Image = Image.FromFile("puzzlegrade2/b4.jpg");
                    break;
                case 3:
                    question = 3;
                    pic1.Left = 118;
                    pic1.Top = 509;
                    pic2.Left = 77;
                    pic2.Top = 488;
                    pic3.Left = 143;
                    pic3.Top = 469;
                    pic4.Left = 206;
                    pic4.Top = 488;
                    pic5.Left = 166;
                    pic5.Top = 509;
                    givenpic1.Image = Image.FromFile("puzzlegrade2/3question1.jpg");
                    givenpic2.Image = Image.FromFile("puzzlegrade2/3question2.jpg");
                    givenpic3.Image = Image.FromFile("puzzlegrade2/3question3.jpg");
                    givenpic4.Image = Image.FromFile("puzzlegrade2/3question4.jpg");


                    pic1.Image = Image.FromFile("puzzlegrade2/3a.jpg");
                    pic2.Image = Image.FromFile("puzzlegrade2/3b.jpg");
                    pic3.Image = Image.FromFile("puzzlegrade2/3c.jpg");
                    pic4.Image = Image.FromFile("puzzlegrade2/3d.jpg");
                    pic5.Image = Image.FromFile("puzzlegrade2/3question1.jpg");
                    break;
                case 4:
                    question = 4;
                    pic1.Left = 118;
                    pic1.Top = 509;
                    pic2.Left = 77;
                    pic2.Top = 488;
                    pic3.Left = 143;
                    pic3.Top = 469;
                    pic4.Left = 206;
                    pic4.Top = 488;
                    pic5.Left = 166;
                    pic5.Top = 509;
                    givenpic1.Image = Image.FromFile("puzzlegrade2/4question1.jpg");
                    givenpic2.Image = Image.FromFile("puzzlegrade2/4question2.jpg");
                    givenpic3.Image = Image.FromFile("puzzlegrade2/4question3.jpg");
                    givenpic4.Image = Image.FromFile("puzzlegrade2/4question4.jpg");


                    pic1.Image = Image.FromFile("puzzlegrade2/4a.jpg");
                    pic2.Image = Image.FromFile("puzzlegrade2/4b.jpg");
                    pic3.Image = Image.FromFile("puzzlegrade2/4c.jpg");
                    pic4.Image = Image.FromFile("puzzlegrade2/4d.jpg");
                    pic5.Image = Image.FromFile("puzzlegrade2/4e.jpg");
                    break;
                case 5:
                    question = 5;
                    pic1.Left = 118;
                    pic1.Top = 509;
                    pic2.Left = 77;
                    pic2.Top = 488;
                    pic3.Left = 143;
                    pic3.Top = 469;
                    pic4.Left = 206;
                    pic4.Top = 488;
                    pic5.Left = 166;
                    pic5.Top = 509;
                    givenpic1.Image = Image.FromFile("puzzlegrade2/4question1.jpg");
                    givenpic2.Image = Image.FromFile("puzzlegrade2/4question1.jpg");
                    givenpic3.Image = Image.FromFile("puzzlegrade2/4a.jpg");
                    givenpic4.Image = Image.FromFile("puzzlegrade2/5question.jpg");


                    pic1.Image = Image.FromFile("puzzlegrade2/5a.jpg");
                    pic2.Image = Image.FromFile("puzzlegrade2/5b.jpg");
                    pic3.Image = Image.FromFile("puzzlegrade2/5c.jpg");
                    pic4.Image = Image.FromFile("puzzlegrade2/4question1.jpg");
                    pic5.Image = Image.FromFile("puzzlegrade2/4a.jpg");
                    break;
                case 6:
                    panel1.Show();
                    finalpanel.Show();
                    break;
            }

        }
        Point lastPoint0;
        private void pic2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic2.Left += e.X - lastPoint0.X;
                pic2.Top += e.Y - lastPoint0.Y;
            }
            if (pic2.Left >= 871 && pic2.Top <= 250 && pic2.Bottom >= 250 && pic2.Right <= 995)
            {
                pictureBox5.Show();
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                pictureBox5.Hide();
            }
        }
        private void pic2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint0 = new Point(e.X, e.Y);

        }
        Point lastPoint1;
        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic1.Left += e.X - lastPoint1.X;
                pic1.Top += e.Y - lastPoint1.Y;
            }
            if (pic1.Left >= 871 && pic1.Top <= 250 && pic1.Bottom >= 250 && pic1.Right <= 995)
            {
                pictureBox5.Show();
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                pictureBox5.Hide();
            }
        }
        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);

        }
        Point lastPoint2;
        private void pic3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic3.Left += e.X - lastPoint2.X;
                pic3.Top += e.Y - lastPoint2.Y;
            }
            if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
            {
                button1.Enabled = false;
                pictureBox5.Show();
                button1.Enabled = true;
            }
            else
            {
                pictureBox5.Hide();
            }
        }

        private void pic3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }
        Point lastPoint3;
        private void pic4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic4.Left += e.X - lastPoint3.X;
                pic4.Top += e.Y - lastPoint3.Y;
            }
            if (pic4.Left >= 871 && pic4.Top <= 250 && pic4.Bottom >= 250 && pic4.Right <= 995)
            {
                button1.Enabled = true;
                pictureBox5.Show();
            }
            else
            {
                
                pictureBox5.Hide();
            }
        }

        private void pic4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint3 = new Point(e.X, e.Y);
        }
        Point lastPoint4;
        private void pic5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic5.Left += e.X - lastPoint4.X;
                pic5.Top += e.Y - lastPoint4.Y;
            }
            if (pic5.Left >= 871 && pic5.Top <= 250 && pic5.Bottom >= 250 && pic5.Right <= 995)
            {
                pictureBox5.Show();
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                pictureBox5.Hide();
            }
        }

        private void pic5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint4 = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "CHECK YOUR ANSWER (2)")
            {
                button1.Text = "CHECK YOUR ANSWER (1)";
                if (question == 1)
                {
                    if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if (question == 2)
                {
                    if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if(question == 3)
                {
                    if (pic5.Left >= 871 && pic5.Top <= 250 && pic5.Bottom >= 250 && pic5.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if(question == 4)
                {
                    if (pic1.Left >= 871 && pic1.Top <= 250 && pic1.Bottom >= 250 && pic1.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if(question == 5)
                {
                    if(pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
            }
            else if (button1.Text == "CHECK YOUR ANSWER(1)")
            {
                button1.Text = "CHECK YOUR ANSWER (0)";
                if (question == 1)
                {
                    if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if (question == 2)
                {
                    if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if (question == 3)
                {
                    if (pic5.Left >= 871 && pic5.Top <= 250 && pic5.Bottom >= 250 && pic5.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if (question == 4)
                {
                    if (pic1.Left >= 871 && pic1.Top <= 250 && pic1.Bottom >= 250 && pic1.Right <= 995)
                    {
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        score++;
                        increasing();
                    }
                }
                else if (question == 5)
                {
                    if (pic3.Left >= 871 && pic3.Top <= 250 && pic3.Bottom >= 250 && pic3.Right <= 995)
                    {
                        score++;
                        button1.Text = "CHECK YOUR ANSWER (2)";
                        increasing();
                    }
                }
            }
            else
            {
                questionlevel++;
                Levels(questionlevel);
                button1.Text = "CHECK YOUR ANSWER (2)";
                Notice();

            }

        }
        private async void Notice()
        {
            label7.Show();
            await Task.Delay(4000);
            label7.Hide();
            


        }
        private async void increasing()
        {
            label3.Show();
            button1.Hide();
            await Task.Delay(4000);
            label3.Hide();
            button1.Show();
            questionlevel++;
            Levels(questionlevel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
            frm1.width += 183;
            frm1.progressbar.Start();
            frm1.label22.Text = score.ToString();
            frm1.button1.Enabled = false;
            frm1.thirdscore = score.ToString();
            if (!frm1.button8.Enabled && !frm1.button7.Enabled && !frm1.button1.Enabled)
            {
                frm1.button20.Enabled = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Game? \n(All your data will be loss and you cannot play this game again.) \n \nPlease contact your guardian or adviser for guidance. Thank You.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                frm1.Show();
                frm1.thirdscore = "0";
                frm1.button1.Enabled = false;
            }
        }

        private void cover_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

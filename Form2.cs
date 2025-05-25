using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_School
{
    public partial class Form2 : Form
    {
        Studenthomepage frm1;
        public Form2(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;
        }
        int askquestion = 1;
        int score;
        int time = 180;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            finishpanel.Hide();
            label10.Hide();
            button14.Hide();
            guessedpanel.Hide();
            confetti1.Hide();
            TexttoShow();
            Level(1);
            
        }
        private async void TexttoShow()
        {
            label11.Show();
            await Task.Delay(2050);
            label11.Hide();
        }

        private void Level(int level)
        {
            switch (level)
            {
                case 1:

                    label7.Text = "1";

                    box6.Hide();
                    box7.Hide();
                    box8.Hide();

                    box1.Left += 83;
                    box2.Left += 83;
                    box3.Left += 83;
                    box4.Left += 83;
                    box5.Left += 83;

                    

                    pictureBox1.Image = Image.FromFile("fourpics/1a.jpg");
                    pictureBox2.Image = Image.FromFile("fourpics/1b.jpg");
                    pictureBox3.Image = Image.FromFile("fourpics/1c.jpg");
                    pictureBox4.Image = Image.FromFile("fourpics/1d.jpg");

                    button1.Text = "S";
                    button2.Text = "E";
                    button3.Text = "M";
                    button4.Text = "S";
                    button6.Text = "E";
                    button7.Text = "H";
                    button8.Text = "W";
                    button9.Text = "P";
                    button10.Text = "A";
                    button11.Text = "Q";
                    button12.Text = "X";
                    button13.Text = "O";
                    break;
                case 2:
                    label7.Text = "2";
                    guessedpanel.Hide();
                    box1.Show();
                    box2.Show();
                    box3.Show();
                    box1.Left -= 83;
                    box2.Left -= 83;
                    box3.Left -= 83;
                    box4.Left -= 83;
                    box5.Left -= 83;
                    box4.Show();
                    box5.Show();
                    box6.Show();
                    box7.Show();
                    box8.Show();
                    
                    confetti1.Hide();
                    first.Text = "X";
                    second.Text = "X";
                    box1.Hide();
                    box2.Hide();
                    box7.Hide();
                    box8.Hide();
                    pictureBox1.Image = Image.FromFile("fourpics/2a.jpg");
                    pictureBox2.Image = Image.FromFile("fourpics/2b.jpg");
                    pictureBox3.Image = Image.FromFile("fourpics/2c.jpg");
                    pictureBox4.Image = Image.FromFile("fourpics/2d.jpg");

                    button1.Text = "T";
                    button2.Text = "E";
                    button3.Text = "M";
                    button4.Text = "L";
                    button6.Text = "I";
                    button7.Text = "O";
                    button8.Text = "C";
                    button9.Text = "M";
                    button10.Text = "K";
                    button11.Text = "E";
                    button12.Text = "W";
                    button13.Text = "Q";
                    break;
                case 3:
                    label7.Text = "3";
                    guessedpanel.Hide();
                    box5.Hide();
                    confetti1.Hide();
                    
                    
                    box1.Show();
                    box2.Show();
                    box3.Show();
                    box5.Show();
                    box4.Show();
                    box6.Show();
                    box7.Show();
                    box8.Show();
                    pictureBox1.Image = Image.FromFile("fourpics/3a.jpg");
                    pictureBox2.Image = Image.FromFile("fourpics/3b.jpg");
                    pictureBox3.Image = Image.FromFile("fourpics/3c.jpg");
                    pictureBox4.Image = Image.FromFile("fourpics/3d.jpg");

                    button1.Text = "A";
                    button2.Text = "N";
                    button3.Text = "D";
                    button4.Text = "D";
                    button6.Text = "I";
                    button7.Text = "O";
                    button8.Text = "T";
                    button9.Text = "I";
                    button10.Text = "K";
                    button11.Text = "O";
                    button12.Text = "W";
                    button13.Text = "Q";
                    break;
                case 4:
                    label7.Text = "4";
                    box7.Hide();
                    confetti1.Hide();
                    box8.Hide();
                    guessedpanel.Hide();
                    box1.Left += 57;
                    box2.Left += 57;
                    box3.Left += 57;
                    box4.Left += 57;
                    box5.Left += 57;
                    box6.Left += 57;

                    pictureBox1.Image = Image.FromFile("fourpics/4a.jpg");
                    pictureBox2.Image = Image.FromFile("fourpics/4b.jpg");
                    pictureBox3.Image = Image.FromFile("fourpics/4c.jpg");
                    pictureBox4.Image = Image.FromFile("fourpics/4d.jpg");

                    button1.Text = "Q";
                    button2.Text = "W";
                    button3.Text = "D";
                    button4.Text = "N";
                    button6.Text = "U";
                    button7.Text = "O";
                    button8.Text = "M";
                    button9.Text = "I";
                    button10.Text = "B";
                    button11.Text = "R";
                    button12.Text = "E";
                    button13.Text = "S";
                    break;
                case 5:
                    label7.Text = "5 (Last)";
                    box7.Show();
                    box8.Show();
                    confetti1.Hide();
                    guessedpanel.Hide();

                    box1.Left -= 57;
                    box2.Left -= 57;
                    box3.Left -= 57;
                    box4.Left -= 57;
                    box5.Left -= 57;
                    box6.Left -= 57;

                    pictureBox1.Image = Image.FromFile("fourpics/5a.jpg");
                    pictureBox2.Image = Image.FromFile("fourpics/5b.jpg");
                    pictureBox3.Image = Image.FromFile("fourpics/5c.jpg");
                    pictureBox4.Image = Image.FromFile("fourpics/5d.jpg");

                    button1.Text = "C";
                    button2.Text = "O";
                    button3.Text = "U";
                    button4.Text = "N";
                    button6.Text = "U";
                    button7.Text = "O";
                    button8.Text = "T";
                    button9.Text = "I";
                    button10.Text = "B";
                    button11.Text = "N";
                    button12.Text = "G";
                    button13.Text = "X";
                    break;
                case 6:
                    timer1.Stop();
                    finishpanel.Show();
                    break;



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            if(first.Text == "")
            {
                first.Text = button1.Text;
            }
            else if(second.Text == "")
            {
                second.Text = button1.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button1.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button1.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button1.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button1.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button1.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button1.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            if (first.Text == "")
            {
                first.Text = button2.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button2.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button2.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button2.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button2.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button2.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button2.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button2.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            } 
            else if(askquestion == 4)
            {
                if(first.Text == "N")
                {
                    if(second.Text == "U")
                    {
                        if(third.Text == "M")
                        {
                            if(fourth.Text == "B")
                            {
                                if(fifth.Text == "E")
                                {
                                    if(sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            if (first.Text == "")
            {
                first.Text = button2.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button3.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button3.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button3.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button3.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button3.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button3.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button3.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            if (first.Text == "")
            {
                first.Text = button4.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button4.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button4.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button4.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button4.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button4.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button4.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button4.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
            if (first.Text == "")
            {
                first.Text = button6.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button6.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button6.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button6.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button6.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button6.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button6.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button6.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
            if (first.Text == "")
            {
                first.Text = button7.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button7.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button7.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button7.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button7.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button7.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button7.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button7.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
            if (first.Text == "")
            {
                first.Text = button8.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button8.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button8.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button8.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button8.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button8.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button8.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button8.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            if (first.Text == "")
            {
                first.Text = button9.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button9.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button9.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button9.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button9.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button9.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button9.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button9.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            if (first.Text == "")
            {
                first.Text = button10.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button10.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button10.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button10.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button10.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button10.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button10.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button10.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            if (first.Text == "")
            {
                first.Text = button11.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button11.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button11.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button11.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button11.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button11.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button11.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button11.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Hide();
            if (first.Text == "")
            {
                first.Text = button12.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button12.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button12.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button12.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button12.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button12.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button12.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button12.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Hide();
            if (first.Text == "")
            {
                first.Text = button13.Text;
            }
            else if (second.Text == "")
            {
                second.Text = button13.Text;
            }
            else if (third.Text == "")
            {
                third.Text = button13.Text;
            }
            else if (fourth.Text == "")
            {
                fourth.Text = button13.Text;
            }
            else if (fifth.Text == "")
            {
                fifth.Text = button13.Text;
            }
            else if (sixth.Text == "")
            {
                sixth.Text = button13.Text;
            }
            else if (seventh.Text == "")
            {
                seventh.Text = button13.Text;
            }
            else if (eighth.Text == "")
            {
                eighth.Text = button13.Text;
            }
            if (askquestion == 1)
            {
                if (first.Text == "S")
                {
                    if (second.Text == "H")
                    {
                        if (third.Text == "A")
                        {
                            if (fourth.Text == "P")
                            {
                                if (fifth.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();

                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();


                            }
                        }
                    }
                }
            }
            else if (askquestion == 3)
            {
                if (first.Text == "A")
                {
                    if (second.Text == "D")
                    {
                        if (third.Text == "D")
                        {
                            if (fourth.Text == "I")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "O")
                                        {
                                            if (eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (askquestion == 4)
            {
                if (first.Text == "N")
                {
                    if (second.Text == "U")
                    {
                        if (third.Text == "M")
                        {
                            if (fourth.Text == "B")
                            {
                                if (fifth.Text == "E")
                                {
                                    if (sixth.Text == "R")
                                    {
                                        guessedpanel.Show();
                                        score++;
                                        button14.Hide();
                                        label8.Text = score.ToString();
                                        confetti1.Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 5)
            {
                if (first.Text == "C")
                {
                    if (second.Text == "O")
                    {
                        if (third.Text == "U")
                        {
                            if (fourth.Text == "N")
                            {
                                if (fifth.Text == "T")
                                {
                                    if (sixth.Text == "I")
                                    {
                                        if (seventh.Text == "N")
                                        {
                                            if (eighth.Text == "G")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(first.Text != "")
            {
                button14.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first.Text = "";
            second.Text = "";
            third.Text = "";
            fourth.Text = "";
            fifth.Text = "";
            sixth.Text = "";
            seventh.Text = "";
            eighth.Text = "";
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            if (askquestion == 2)
            {
                first.Text = "x";
                second.Text = "x";
            }



        }

        private void label13_TextChanged(object sender, EventArgs e)
        {
            
            if (askquestion == 1)
            {
                if (third.Text == "S")
                {
                    if (fourth.Text == "H")
                    {
                        if (fifth.Text == "A")
                        {
                            if (sixth.Text == "P")
                            {
                                if (seventh.Text == "E")
                                {
                                    guessedpanel.Show();
                                    score++;
                                    button14.Hide();
                                    label8.Text = score.ToString();
                                    confetti1.Show();
                                    
                                }
                            }
                        }
                    }
                }
            }
            else if (askquestion == 2)
            {
                if (third.Text == "T")
                {
                    if (fourth.Text == "I")
                    {
                        if (fifth.Text == "M")
                        {
                            if (sixth.Text == "E")
                            {

                                guessedpanel.Show();
                                score++;
                                button14.Hide();
                                label8.Text = score.ToString();
                                confetti1.Show();
                                

                            }
                        }
                    }
                }
            }
            else if(askquestion ==3)
            {
                if(first.Text == "A")
                {
                    if(second.Text == "D")
                    {
                        if(third.Text == "D")
                        {
                            if(fourth.Text == "I")
                            {
                                if(fifth.Text == "T")
                                {
                                    if(sixth.Text == "I")
                                    {
                                        if(seventh.Text == "O")
                                        {
                                            if(eighth.Text == "N")
                                            {
                                                guessedpanel.Show();
                                                score++;
                                                button14.Hide();
                                                label8.Text = score.ToString();
                                                confetti1.Show();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                               
                    }
                }
            }
        }
    
            
        
        private void confetti1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            first.Text = "";
            second.Text = "";
            third.Text = "";
            fourth.Text = "";
            fifth.Text = "";
            sixth.Text = "";
            seventh.Text = "";
            eighth.Text = "";




            askquestion++;
            Level(askquestion);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time --;
            label6.Text = time.ToString() + " Second(s)";
            if(time < 1)
            {
                finishpanel.Show();
                label10.Show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
            frm1.button1.Enabled = false;
            frm1.width += 183;
            frm1.label22.Text = score.ToString();
            frm1.thirdscore = score.ToString();
            frm1.progressbar.Start();
            if (!frm1.button8.Enabled && !frm1.button7.Enabled && !frm1.button1.Enabled)
            {
                frm1.button20.Enabled = true;
            }
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Game? \n(All your data will be loss and you cannot play this game again.) \n \nPlease contact your guardian or adviser for guidance. Thank You.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                frm1.Show();
                frm1.button1.Enabled = false;
            }
        }
    }
}

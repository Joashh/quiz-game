using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Math_School
{
    public partial class secondmathact : Form
    {
        Studenthomepage frm1;
        public secondmathact(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;
        }
        int scorefirst;
        int finalscorefirst; //16

        int scoresecond;
        int finalscoresecond; //4

        int scorethird; //3
        int questionnum;
        int totalquestion = 8;
        int finalscorethird;

        int exptotal;
        int totalscore;
        int correctanswer1;

        public int handtemp;

        public string namedito;
        SqlConnection con = new SqlConnection(Class1.conReturn());
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void six_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel12.Show();
            button12.Show();
            button11.Hide();
            if (six.Text == "6")
            {
                scorefirst++;
            }
            if (nine.Text == "9")
            {
                scorefirst++;
            }
            if (eleven.Text == "11")
            {
                scorefirst++;
            }
            if (twelve.Text == "18")
            {
                scorefirst++;
            }
            if (eighteen.Text == "9")
            {
                scorefirst++;
            }
            if (twenty.Text == "20")
            {
                scorefirst++;
            }
            if (twentyone.Text == "21")
            {
                scorefirst++;
            }
            if (twentythree.Text == "23")
            {
                scorefirst++;
            }
            if (twentyeight.Text == "28")
            {
                scorefirst++;
            }
            if (twentynine.Text == "29")
            {
                scorefirst++;
            }
            if (thirtythree.Text == "33")
            {
                scorefirst++;
            }
            if (thirtyfour.Text == "35")
            {
                scorefirst++;
            }
            if (thirthysix.Text == "36")
            {
                scorefirst++;
            }
            if (thirtynine.Text == "39")
            {
                scorefirst++;
            }
            if (fourty.Text == "40")
            {
                scorefirst++;
            }
            if (fourtyseven.Text == "47")
            {
                scorefirst++;
            }

           
        }

        private void secondmathact_Load(object sender, EventArgs e)
        {
            Intermediatemathpanel.Hide();
            panel3.Hide();
            patternpanel.Hide();
            scorepanelsecond.Hide();
            Problemsolving.Hide();
            question1panel.Hide();
            checkfor1.Hide();
            button9.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patternpanel.Show();
            panel12.Hide();
            button12.Hide();
            
            whatisyourname.Hide();
            panel3.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            scorepanelsecond.Show();
            button17.Hide();
            if (question1.Text == "How many boys are sitting on the fence now?")
                scoresecond++;
            if (question2.Text == "2 boys and 4 more boys")
                scoresecond++;
            if (question3.Text == "Addition")
                scoresecond++;
            if (question4.Text == "4 + 2 = 6")
                scoresecond++;

            if (scoresecond == 4)
            {
                finalscoresecond = 100;
            }
            else if (scoresecond == 3)
            {
                finalscoresecond = 75;
            }
            else if (scoresecond == 2)
            {
                finalscoresecond = 50;
            }
            else if (scoresecond == 1)
            {
                finalscoresecond = 25;
            }
            else if (scoresecond == 0)
            {
                finalscoresecond = 0;
            }
            label15.Text = finalscoresecond.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Problemsolving.Show();
            whatisyourname.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Problemsolving.Hide();
            button3.Enabled = false;
            whatisyourname.Show();

            if(button3.Enabled == false && button4.Enabled == false && button2.Enabled == false )
            {
                button6.Enabled = true;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            patternpanel.Hide();
            button3.Enabled = true;
            whatisyourname.Show();
            button4.Enabled = false;
            if (button3.Enabled == false && button4.Enabled == false && button2.Enabled == false)
            {
                button6.Enabled = true;
            }
        }

        private void checkanswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctanswer1)
            {
                scorethird++;
            }
            if(questionnum == totalquestion)
            {
                label34.Text = scorethird.ToString();
            }
            
            questionnum++;
            askquestion(questionnum);
            
        }

        private void askquestion(int num)
        {
            switch (num)
            {
                case 1:
                    question1panel.Show();
                    correctanswer1 = 4;
                    
                break;
                case 2:
                    checkfor1.Show();
                    
                    button9.Show();

                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                break;
                case 3:
                    checkfor1.Hide();
                    button9.Hide();

                    question2panel.Show();

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;
                    opt1.Text = "40 Pesos";
                    opt2.Text = "209 Pesos";
                    opt3.Text = "205 Pesos";
                    opt4.Text = "200 Pesos";
                    opt5.Text = "109 Pesos";

                    correctanswer1 = 3;
                    break;
                case 4:
                    checksfor2.Show();
                    button9.Show();
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    break;
                case 5:
                    checksfor2.Hide();
                    button9.Hide();
                    question3panel.Show();
                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;
                    opt1.Text = "280 Pesos";
                    opt2.Text = "209 Pesos";
                    opt3.Text = "299 Pesos";
                    opt4.Text = "300 Pesos";
                    opt5.Text = "450 Pesos";

                    correctanswer1 = 3;
                    break;
                case 6:

                    thirdchecker.Show();
                    button9.Show();
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    break;
                case 7:
                    panel8.Show();
                    break;
                case 8:
                    button9.Hide();
                    finalpanel.Show();

                    if (scorethird == 13)
                    {
                        finalscorethird = 100;
                    }
                    else if (scorethird >= 2)
                    {
                        finalscorethird = 60;
                    }
                    else if (scorethird > 1)
                    {
                        finalscorethird = 25;
                    }
                    else if (scorethird > 0)
                    {
                        finalscorethird = 00;
                    }

                    label34.Text = finalscorethird.ToString() + "%";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            askquestion(1);
            Intermediatemathpanel.Show();
            panel8.Hide();
            whatisyourname.Hide();
            question2panel.Hide();
            thirdchecker.Hide();
            checksfor2.Hide();
            question3panel.Hide();
            panel3.Hide();
            finalpanel.Hide();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            questionnum++;
            askquestion(questionnum);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Intermediatemathpanel.Hide();
            button4.Enabled = true;
            whatisyourname.Show();
            button2.Enabled = false;
            if (button3.Enabled == false && button4.Enabled == false && button2.Enabled == false )
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            totalscore = finalscorefirst + finalscoresecond + finalscorethird;
            frm1.pictureBox6.Hide();
            frm1.progressbar.Start();

            
            

            this.Close();
            
            frm1.Show();
            frm1.category1score2 = scorethird.ToString();
            frm1.category2score2 = scoresecond.ToString();
            frm1.category3score2 = scorefirst.ToString();
            exptotal = (int)Math.Round((double)(100 * totalscore) / 153);

           
            frm1.exp2 = exptotal.ToString();
            frm1.button7.Enabled = false;
            frm1.label10.Text = exptotal.ToString();
            frm1.classicscore.Show();
            frm1.width += 183;

            if(!frm1.button8.Enabled && !frm1.button7.Enabled && !frm1.button1.Enabled)
            {
                frm1.button20.Enabled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txta1.Text != "" && txta2.Text != "" && txtb1.Text != "" && txtb2.Text != "" && txtc1.Text != "" && txtc2.Text != "")
                {
                    int suma = int.Parse(txta1.Text) + int.Parse(txta2.Text);
                    int sumb = int.Parse(txtb1.Text) + int.Parse(txtb2.Text);
                    int sumc = int.Parse(txtc1.Text) + int.Parse(txtc2.Text);

                    int sumd = int.Parse(txtd1.Text) + int.Parse(txtd2.Text);
                    int sume = int.Parse(txte1.Text) + int.Parse(txte2.Text);
                    int sumf = int.Parse(txtf1.Text) + int.Parse(txtf2.Text);

                    int sumg = int.Parse(txtg1.Text) + int.Parse(txtg2.Text);
                    int sumh = int.Parse(txth1.Text) + int.Parse(txth2.Text);
                    int sumi = int.Parse(txti1.Text) + int.Parse(txti2.Text);

                    if (suma == 20)
                    {
                        scorethird++;
                    }
                    if (sumb == 20)
                    {
                        scorethird++;
                    }
                    if (sumc == 20)
                    {
                        scorethird++;
                    }

                    if (sumd == 27)
                    {
                        scorethird++;
                    }
                    if (sume == 27)
                    {
                        scorethird++;
                    }
                    if (sumf == 27)
                    {
                        scorethird++;
                    }

                    if (sumg == 17)
                    {
                        scorethird++;
                    }
                    if (sumh == 17)
                    {
                        scorethird++;
                    }
                    if (sumi == 17)
                    {
                        scorethird++;
                    }
                    questionnum++;
                    askquestion(questionnum);
                }
                else
                {
                    MessageBox.Show("Please complete the squares. If you do not know the answer just put zero '0'.", "You are not finished.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please complete the squares. If you do not know the answer just put zero '0'. Thank you!.", "You are not finished.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (aa != null && bb != null && cc != null && dd != null && ee != null)
            {
                panel3.Show();
                if (aa.Text == "i" || aa.Text == "I")
                {
                    scorefirst++;
                }
                if (bb.Text == "13")
                {
                    scorefirst++;
                }
                if (cc.Text == "Gg" || cc.Text == "gg")
                {
                    scorefirst++;
                }
                if (dd.Text == "15")
                {
                    scorefirst++;
                }
                if (ee.Text == "35")
                {
                    scorefirst++;
                }

                if (scorefirst >= 21)
                {
                    finalscorefirst = 100;
                }
                else if (scorefirst > 16)
                {
                    finalscorefirst = 75;
                }
                else if (scorefirst > 11)
                {
                    finalscorefirst = 50;
                }
                else if (scorefirst > 5)
                {
                    finalscorefirst = 25;
                }
                else
                {
                    finalscorefirst = 0;
                }

                label5.Text = finalscorefirst.ToString();
            }
            else
            {
                MessageBox.Show("Please complete the squares. If you do not know the answer just put zero '0'.", "You are not finished.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void six_Enter(object sender, EventArgs e)
        {
            six.Text = "";
        }

        private void nine_Enter(object sender, EventArgs e)
        {
            nine.Text = "";
        }

        private void eleven_Enter(object sender, EventArgs e)
        {
            eleven.Text = "";
        }

        private void twelve_Enter(object sender, EventArgs e)
        {
            twelve.Text = "";
        }

        private void eighteen_Enter(object sender, EventArgs e)
        {
            eighteen.Text = "";
        }

        private void twenty_Enter(object sender, EventArgs e)
        {
            twenty.Text = "";
        }

        private void twentyone_Enter(object sender, EventArgs e)
        {
            twentyone.Text = "";
        }

        private void twentythree_Enter(object sender, EventArgs e)
        {
            twentythree.Text = "";
        }

        private void twentyeight_Enter(object sender, EventArgs e)
        {
            twentyeight.Text = "";
        }

        private void twentynine_Enter(object sender, EventArgs e)
        {
            twentynine.Text = "";
        }

        private void thirtythree_Enter(object sender, EventArgs e)
        {
            thirtythree.Text = "";
        }

        private void thirtyfour_Enter(object sender, EventArgs e)
        {
            thirtyfour.Text = "";
        }

        private void thirthysix_Enter(object sender, EventArgs e)
        {
            thirthysix.Text = "";
        }

        private void thirtynine_Enter(object sender, EventArgs e)
        {
            thirtynine.Text = "";
        }

        private void fourty_Enter(object sender, EventArgs e)
        {
            fourty.Text = "";
        }

        private void fourtyseven_Enter(object sender, EventArgs e)
        {
            fourtyseven.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

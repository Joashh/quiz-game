using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_School
{
    public partial class mixedtopic : Form
    {
        grade2mathact form1;
        public mixedtopic(grade2mathact frm1)
        {
            InitializeComponent();
            form1 = frm1;
        }
        int scoretime;
        int measscore;
        int fracscore;
        int oddnumscore;
        int evennumscore;
        int equationscore;

        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            timepanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(opt1.Text == "12:45")
            {
                scoretime++;
            }
            if (opt2.Text == "11:00")
            {
                scoretime++;
            }
            if (opt3.Text == "09:30")
            {
                scoretime++;
            }
            if (opt4.Text == "10:30")
            {
                scoretime++;
            }
            
            if(scoretime == 4)
            {
                timescorelabel.Text = "100%";
            }
            else if(scoretime == 3)
            {
                timescorelabel.Text = "75%";
            }
            else if (scoretime == 2)
            {
                timescorelabel.Text = "50%";
            }
            else
            {
                timescorelabel.Text = "25%";
            }
            scorepaneltime.Show();
            button1.Hide();
            exittime.Show();
        }

        private void mixedtopic_Load(object sender, EventArgs e)
        {
            timepanel.Hide();
            exittime.Hide();
            scorepaneltime.Hide();
            measurement.Hide();
            measpanelscore.Hide();
            button3.Hide();

            fraction.Hide();
            panel2.Hide();
            button4.Hide();

            oddnumberpanel.Hide();
            panel3.Hide();
            button6.Hide();

            evennumpanel.Hide();
            panel6.Hide();
            button8.Hide();

            equationpanel.Hide();
            panel9.Hide();
            button10.Hide();
        }

        private void exittime_Click(object sender, EventArgs e)
        {
            timepanel.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            measurement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(meas1.Text == "Same as")
            {
                measscore++;
            }
            if(meas2.Text == "Lighter than")
            {
                measscore++;
            }
            if (meas3.Text == "Heavier than")
            {
                measscore++;
            }
            measpanelscore.Show();

            if(measscore == 3)
            {
                finalmeasscorelabel.Text = "100%";
            }
            else if (measscore == 2)
            {
                finalmeasscorelabel.Text = "50%";
            }
            else 
            {
                finalmeasscorelabel.Text = "25%";
            }
            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            measurement.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            fraction.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox3.Text == "1 Whole")
            {
                fracscore++;
                label12.Text = "100%";
            }
            else
            {
                label12.Text = "25%";
            }
            button5.Hide();
            panel2.Show();
            button4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fraction.Hide();
        }

        private void oddnumber_Click(object sender, EventArgs e)
        {
            oddnumberpanel.Show();
        }

        private void evennumber_Click(object sender, EventArgs e)
        {
            evennumpanel.Show();
        }

        private void equation_Click(object sender, EventArgs e)
        {
            equationpanel.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Show();
            if(tree.Text == "3")
            {
                oddnumscore++;
            }
            if (seven.Text == "7")
            {
                oddnumscore++;
            }
            if (eleven.Text == "11")
            {
                oddnumscore++;
            }

            if (fifthteen.Text == "15")
            {
                oddnumscore++;
            }
            if (nineteen.Text == "19")
            {
                oddnumscore++;
            }
            if (twentythree.Text == "23")
            {
                oddnumscore++;
            }

            if (oddnumscore == 6)
            {
                label14.Text = "100%";
            }
            else if(oddnumscore == 4)
            {
                label14.Text = "75%";
            }
            else if (oddnumscore == 3)
            {
                label14.Text = "50%";
            }
            else 
            {
                label14.Text = "25%";
            }
            button7.Hide();
            button6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oddnumberpanel.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            if(four.Text == "4")
            {
                evennumscore++;
            }
            if (eight.Text == "8")
            {
                evennumscore++;
            }
            if (twelve.Text == "12")
            {
                evennumscore++;
            }
            if (eighteen.Text == "18")
            {
                evennumscore++;
            }
            if (twentytwo.Text == "22")
            {
                evennumscore++;
            }
            if (twentysix.Text == "26")
            {
                evennumscore++;
            }

            if (evennumscore == 6)
            {
                label22.Text = "100%";
            }
            else if (evennumscore == 4)
            {
                label22.Text = "75%";
            }
            else if (evennumscore == 3)
            {
                label22.Text = "50%";
            }
            else
            {
                label22.Text = "25%";
            }
            button8.Show();
            panel6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            evennumpanel.Hide();
        }

        private void evennumpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            button10.Show();
            panel9.Show();
            if(five.Text == "5")
            {
                equationscore++;
            }
            if (two.Text == "2")
            {
                equationscore++;
            }
            if (piptin.Text == "15")
            {
                equationscore++;
            }
            if (payb.Text == "5")
            {
                equationscore++;
            }
            if (twelb.Text == "5")
            {
                equationscore++;
            }

            if(equationscore == 5)
            {
                label28.Text = "100%";
            }
            else if(equationscore == 4)
            {
                label28.Text = "75%";
            }
            else if (equationscore == 3)
            {
                label28.Text = "50";
            }
            else
            {
                label28.Text = "25%";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            equationpanel.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to finish? \nBe sure that you answered all the topics before clicking 'Yes'.", "Finish?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int sum = scoretime + measscore + fracscore + oddnumscore + evennumscore + equationscore;
                form1.mixscore = sum;
                form1.button6.Enabled = false;
                form1.genmathbutton.Enabled = true;
                this.Close();
                form1.Show();
            }
            else
            {

            }
        }
    }
}

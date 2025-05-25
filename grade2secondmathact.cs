using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Math_School
{
    public partial class grade2secondmathact : Form
    {
        Studenthomepage frm1;
        public grade2secondmathact(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;
            pictureBox2.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(80, 46);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(35, 43);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(128, 107);
            pictureBox6.BackColor = Color.Transparent;
        }
        SqlConnection con = new SqlConnection(Class1.conReturn());
        int correctanswer;
        int score = 200;
        int yourquestion;
        int totalquestion = 15;
        int health = 1;
        bool attackmonster = false;
        int healthbear = 200;
        bool win = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void problemsolvingbutton_Click(object sender, EventArgs e)
        {

        }

        private void checkanswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == correctanswer)
            {
                
                Damageeffect();
            }
            if(buttonTag != correctanswer)
            {
                Damagebear();
            }
            if(yourquestion == totalquestion)
            {
                bottompanelend.Show();
                bottompanelend.BringToFront();
                
                    scorelabel.Text = healthbear.ToString() + "/200";
                
                
                if(score < healthbear)
                {
                    finalwinpanel.Show();
                } 
                else if(healthbear < score)
                {
                    finallosepanel.Show();
                }
            }
            if(score <= 1) //buhay nung monster
            {
                
                finalwinpanel.Show();
                bottompanelend.Show();
                bottompanelend.BringToFront();
            }
            if(healthbear <= 1)
            {
                finallosepanel.Show();
                bottompanelend.Show();
                bottompanelend.BringToFront();
            }
            
            yourquestion++;
            switchquestion(yourquestion);
        }
        private async void Damagebear()
        {
            pictureBox5.Show();
            pictureBox6.Show();
            await Task.Delay(250);
            pictureBox5.Hide();
            pictureBox6.Hide();
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
            healthbear -= 1;
            await Task.Delay(50);
            panel4.Width = healthbear;
           
        }
        private async void Damageeffect()
        {
            pictureBox4.Show();
            await Task.Delay(1000);
            pictureBox4.Hide();
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
            await Task.Delay(50);
            monsterlife.Width = score;
            score -= 1;
        
        }
        private void switchquestion(int switchquestion)
        {
            switch(switchquestion)
            {
                case 1:
                    
                    panel6.Show();
                    panel6.BringToFront();

                    correctanswer = 11;

                    break;
                case 2:
                   
                    label7.Text = "Ordering the numbers into highest to lowest 54 , 9, 25 , 10 , 67 , 82 ?";
                    label8.Hide();
                    option1long.Text = "82 , 67 ,54 , 25 , 10 ,9 ";
                    option2long.Text = "67, 82 ,54 , 10 ,25 ,9";
                    option3long.Text = "82 , 54 ,67 , 25 , 10 , 9";

                    correctanswer = 10;
                    break;
                case 3:
                    
                    panel6.Hide();

                    
                    
                    option1.Text = "14";
                    option2.Text = "15";
                    option3.Text = "12";

                    correctanswer = 3;
                    break;
                case 4:
                    
                    question2.Show();
                    question1.Hide();

                    option1.Text = "15";
                    option2.Text = "19";
                    option3.Text = "20";

                    correctanswer = 2;
                    break;
                case 5:
                    question2.Hide();
                    question3.Show();

                    option1.Text = "6";
                    option2.Text = "8";
                    option3.Text = "4";

                    correctanswer = 3;
                    break;
                case 6:
                    question3.Hide();
                    question4.Show();
                    option1.Text = "300";
                    option2.Text = "299";
                    option3.Text = "232";

                    correctanswer = 1;
                    break;
                case 7:
                    shape1.Show();
                    identifyshapepanel.Show();

                    option1shape.Text = "Cylinder";
                    option2shape.Text = "Circlular";
                    option3shape.Text = "Cilinder";

                    correctanswer = 21;

                    break;
                case 8:
                    shape1.Hide();
                    shape2.Show();

                    option1shape.Text = "Rhombuz";
                    option2shape.Text = "Half-Triangle";
                    option3shape.Text = "Trapezoid";

                    correctanswer = 23;
                    break;
                case 9:
                    shape2.Hide();
                    shape3.Show();

                    option1shape.Text = "Octagon";
                    option2shape.Text = "Hexagon";
                    option3shape.Text = "Pentagon";

                    correctanswer = 22;
                    break;
                case 10:
                    shape3.Hide();
                    shape4.Show();

                    option1shape.Text = "Parallelogram";
                    option2shape.Text = "Slant Square";
                    option3shape.Text = "Rectangle";

                    correctanswer = 21;
                    break;
                case 11:
                    operationpanel.Show();
                    operationpanel.BringToFront();
                    a.Text = "34";
                    operation.Text = "+";
                    b.Text = "56";

                    operation1.Text = "90";
                    operation2.Text = "89";
                    operation3.Text = "93";

                    correctanswer = 31;
                    break;
                case 12:
                    a.Text = "61";
                    operation.Text = "-";
                    b.Text = "30";

                    operation1.Text = "34";
                    operation2.Text = "31";
                    operation3.Text = "30";

                    correctanswer = 32;
                    break;
                case 13:
                    a.Text = "25";
                    operation.Text = "×";
                    b.Text = "4";

                    operation1.Text = "101";
                    operation2.Text = "100";
                    operation3.Text = "1000";

                    correctanswer = 32;
                    break;
                case 14:
                    a.Text = "162";
                    operation.Text = "÷";
                    b.Text = "6";

                    operation1.Text = "28";
                    operation2.Text = "29";
                    operation3.Text = "27";

                    correctanswer = 33;
                    break;
                case 15:
                    a.Text = "36";
                    operation.Text = "×";
                    b.Text = "3";

                    operation1.Text = "110";
                    operation2.Text = "107";
                    operation3.Text = "108";

                    correctanswer = 33;
                    break;
            }
        }

        private void grade2secondmathact_Load(object sender, EventArgs e)
        {
            question1.Hide();
            option1.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox4.Hide();
            identifyshapepanel.Hide();
            option2.Hide();
            panel6.Hide();
            shape1.Hide();
            operationpanel.Hide();
            shape2.Hide();
            //end
            finallosepanel.Hide();
            finalwinpanel.Hide();
            bottompanelend.Hide();
            //end
            shape3.Hide();
            shape4.Hide();
            question2.Hide();
            question3.Hide();
            question4.Hide();
            option3.Hide();
            
        }

        private void finishbutton_Click(object sender, EventArgs e)
        {
            panel1category.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            switchquestion(1);
            question1.Show();
            button10.Hide();
            option1.Show();
            option2.Show();
            option3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Go back to Homepage? \nAll your existing scores will be recorded and you cannot play the game again. \n \nPlease contact your adviser or teacher for guidance. Thank You!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                frm1.Show();
                frm1.button7.Enabled = false;

            }
            else
            {

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Damageeffect();
            yourquestion++;
            switchquestion(yourquestion);
            button24.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm1.pictureBox6.Hide();
            this.Close();
            frm1.Show();
            frm1.button7.Enabled = false;
            frm1.progressbar.Start();
            frm1.width += 184;
            //label10.Text = healthbear.ToString();
            frm1.label10.Text = healthbear.ToString();
            frm1.secondexp2 = healthbear.ToString();
            if (!frm1.button8.Enabled && !frm1.button7.Enabled)
            {
                frm1.button20.Enabled = true;
            }
        }
        Point lastPoint;
        private void grade2secondmathact_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void grade2secondmathact_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            instruction i = new instruction();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.pictureBox6.Hide();
            this.Hide();
            frm1.Show();
            frm1.width += 183;
            frm1.progressbar.Start();
            frm1.button7.Enabled = false;
            //label10.Text = healthbear.ToString();
            frm1.label10.Text = healthbear.ToString();
            frm1.secondexp2 = healthbear.ToString();
            if (!frm1.button8.Enabled && !frm1.button7.Enabled)
            {
                frm1.button20.Enabled = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void finallosepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

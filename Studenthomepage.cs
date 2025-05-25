using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Linq;

namespace Math_School
{
    public partial class Studenthomepage : Form
    {
        
        public string variable;
        public Studenthomepage()
        {
            InitializeComponent();
            
        }
       
        public string category1score;
        public string category2score;
        public string category3score;
        public string category4score;
        public string exp;

        public string category1score2;
        public string category2score2;
        public string category3score2;
        public string category4score2;
        public string exp2;

        public string secondcategory1score;
        public string secondcategory2score;
        public string secondcategory3score;
        public string secondexp;

        public string mixscore;
        public string thirdscore1;
        public string thirdscore2;
        public string thirdscore3;
        int thirdtotalscore;

        public string thirdsecondscore1;

        public string thirdlastscore1;

        public string secondexp2;

        public string thirdscore;

        string progress;
        string progress2;
        public int width;
        int skill;
        public int overallscoregrade2;

        public int firstscore;
        public int secondscore;
        int overall;

        int secondoverall;

        string score;

        int logic;
        int mathematicskill;
        int analyticalskill;
        int masteryinnumbers;

        //FOR VIDEOPLAYER

        List<string> filteredfiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;


        SqlConnection con = new SqlConnection(Class1.conReturn());
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Studenthomepage_Load(object sender, EventArgs e)
        {
            panel23.Hide();
            
            if(label15.Text == "GRADE 1")
            {
                label14.Text = "PICTOGRAPH";
            }
            panel24.Hide();
            helppanel.Hide();
            label7.Hide();
            panel21.Hide();
            label15.Text = variable;
            
            namepanel.Show();
            namepanel.BringToFront();
            label3.Text = variable;
            
            progpanel.Hide();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();
            if (label3.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select studentname, code from createcode where code=@code", con);
                cmd.Parameters.AddWithValue("@code", label3.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    label3.Text = da.GetValue(0).ToString().ToUpper();
                    code.Text = da.GetValue(1).ToString();

                }

            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout? \n all your data will be loss.", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                loginstudent log = new loginstudent();
                log.Show();
            } 
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application? \n (All your data will be loss)", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label15.Text == "GRADE 1")
            {
                mathact game = new mathact(this);
                game.Show();
                this.Hide();
            } 
            else if (label15.Text == "GRADE 2")
            {
                grade2mathact game2 = new grade2mathact(this);
                game2.Show();
                this.Hide();

            }
            else if(label15.Text == "GRADE 3")
            {
                grade3mathact game3 = new grade3mathact(this);
                game3.Show();
                this.Hide();
            }
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tutorial help = new tutorial();
            help.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gamemodepanel.Show();
            label41.Show();
            gamemodepanel.BringToFront();
            progpanel.Hide();
            helppanel.Hide();
            try
            {
                bunifuTransition1.ShowSync(gamemodepanel);
                bunifuTransition1.ShowSync(gamemodepanel);
                bunifuTransition1.ShowSync(gamemodepanel);
                bunifuTransition1.ShowSync(panel3);
                bunifuTransition1.ShowSync(panel5);
                bunifuTransition1.ShowSync(panel8);
            }
            catch
            {
                gamemodepanel.Show();
                panel3.Show();
                panel5.Show();
                panel8.Show();
            }
            lecturepanel.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            helppanel.Hide();
            panel3.Hide();
            panel5.Hide();
            panel8.Hide();
            pictureBox14.Hide();
            try
            {
                if (label15.Text == "GRADE 1")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 4 overall, Name  FROM grade1record WHERE code=@code ORDER BY cast(overall as int) DESC", con);
                    cmd.Parameters.AddWithValue("@code", code.Text);
                    SqlDataReader da = cmd.ExecuteReader();

                    StringBuilder sb = new StringBuilder();
                    StringBuilder sb2 = new StringBuilder();

                    try
                    {
                        while (da.Read())
                        {
                            sb.Append(String.Format("{0} \n", da.GetString(0)));
                            sb2.Append(String.Format("{0} \n", da.GetString(1)));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();

                    var resultdatarray = sb.ToString().Split(new char[] { '\n' });
                    scorefirst.Text = resultdatarray[0];
                    scoresecond.Text = resultdatarray[1];
                    scorethird.Text = resultdatarray[2];
                    scorefourth.Text = resultdatarray[3];

                    var resultdatarray2 = sb2.ToString().Split(new char[] { '\n' });

                    firstname.Text = resultdatarray2[0];
                    secondname.Text = resultdatarray2[1];
                    thirdname.Text = resultdatarray2[2];
                    fourthname.Text = resultdatarray2[3];

                    gamemodepanel.Hide();
                    progpanel.Show();
                    
                    progpanel.BringToFront();
                    lecturepanel.Hide();
                    con.Close();
                    helppanel.Hide();
                }

                //GRADE 2
                else if (label15.Text == "GRADE 2")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 4 overall, name  FROM grade2record WHERE code=@code ORDER BY cast(overall as int) DESC", con);
                    cmd.Parameters.AddWithValue("@code", code.Text);
                    SqlDataReader da = cmd.ExecuteReader();

                    StringBuilder sb = new StringBuilder();
                    StringBuilder sb2 = new StringBuilder();

                    try
                    {
                        while (da.Read())
                        {
                            sb.Append(String.Format("{0} \n", da.GetString(0)));
                            sb2.Append(String.Format("{0} \n", da.GetString(1)));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    if (sb.Length >= 3)
                    {

                        var resultdatarray = sb.ToString().Split(new char[] { '\n' });
                        scorefirst.Text = resultdatarray[0];
                        scoresecond.Text = resultdatarray[1];
                        scorethird.Text = resultdatarray[2];
                        scorefourth.Text = resultdatarray[3];

                        var resultdatarray2 = sb2.ToString().Split(new char[] { '\n' });

                        firstname.Text = resultdatarray2[0];
                        secondname.Text = resultdatarray2[1];
                        thirdname.Text = resultdatarray2[2];
                        fourthname.Text = resultdatarray2[3];

                    }
                    else
                    {
                        MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    gamemodepanel.Hide();
                    progpanel.Show();
                    
                    progpanel.BringToFront();
                    lecturepanel.Hide();
                    con.Close();
                }
                if(label15.Text == "GRADE 3")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 4 overall, name  FROM grade3record WHERE code=@code ORDER BY cast(overall as int) DESC", con);
                    cmd.Parameters.AddWithValue("@code", code.Text);
                    SqlDataReader da = cmd.ExecuteReader();

                    StringBuilder sb = new StringBuilder();
                    StringBuilder sb2 = new StringBuilder();

                    try
                    {
                        while (da.Read())
                        {
                            sb.Append(String.Format("{0} \n", da.GetString(0)));
                            sb2.Append(String.Format("{0} \n", da.GetString(1)));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    if (sb.Length >= 3)
                    {

                        var resultdatarray = sb.ToString().Split(new char[] { '\n' });
                        scorefirst.Text = resultdatarray[0];
                        scoresecond.Text = resultdatarray[1];
                        scorethird.Text = resultdatarray[2];
                        scorefourth.Text = resultdatarray[3];

                        var resultdatarray2 = sb2.ToString().Split(new char[] { '\n' });

                        firstname.Text = resultdatarray2[0];
                        secondname.Text = resultdatarray2[1];
                        thirdname.Text = resultdatarray2[2];
                        fourthname.Text = resultdatarray2[3];

                    }
                    else
                    {
                        MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    gamemodepanel.Hide();
                     progpanel.Show();
                    
                    progpanel.BringToFront();
                    lecturepanel.Hide();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("There is not enough score record to be shown", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (label15.Text == "GRADE 1")
            {
                secondmathact second = new secondmathact(this);
                //second.handtemp = int.Parse(intrototalscore.Text);
                second.Show();
                this.Hide();
            }
            else if(label15.Text == "GRADE 2")
            {
                grade2secondmathact second = new grade2secondmathact(this);
                second.Show();
                this.Hide();
            }
            else if(label15.Text == "GRADE 3")
            {
                grade2secondgame grade3 = new grade2secondgame(this);
                grade3.Show();
                this.Hide();

            }
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            if (label15.Text == "GRADE 1")
            {
                logic += int.Parse(category1score);
                mathematicskill += int.Parse(category1score);
                analyticalskill += int.Parse(category1score);
                masteryinnumbers += int.Parse(category1score);

                mathematicskill += int.Parse(category2score);
                masteryinnumbers += int.Parse(category2score);

                analyticalskill += int.Parse(category3score);
                logic += int.Parse(category3score);

                logic += int.Parse(category4score);
                analyticalskill += int.Parse(category4score);

                logic += int.Parse(category1score2);
                mathematicskill += int.Parse(category1score2);
                analyticalskill += int.Parse(category1score2);
                masteryinnumbers += int.Parse(category1score2);

                logic += int.Parse(category2score2);
                mathematicskill += int.Parse(category2score2);

                logic += int.Parse(category3score2);
                analyticalskill += int.Parse(category3score2);
                masteryinnumbers += int.Parse(category3score2);

                logic += int.Parse(thirdscore);
                analyticalskill += int.Parse(thirdscore);

                overall = int.Parse(category1score) + int.Parse(category2score) + int.Parse(category3score) + int.Parse(category4score) + int.Parse(category1score2) + int.Parse(category2score2) + int.Parse(category3score2) + int.Parse(thirdscore);
                con.Open();
                SqlCommand cmd = new  SqlCommand("insert into grade1record values ('" + namehome.Text + "','" + category1score + "','" + category2score + "','" + category3score + "','" + category4score + "','" + exp + "','" + code.Text + "','" + category1score2 + "','" + category2score2 + "','" + category3score2 + "','" + exp2 + "','" + overall + "', '" + thirdscore + "', '" + logic+ "', '" + mathematicskill + "', '" + analyticalskill + "', '" + masteryinnumbers + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your score was successfully recorded. See the scores to check your ranking.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else if (label15.Text == "GRADE 2")
            {
                logic += int.Parse(secondcategory1score);
                mathematicskill += int.Parse(secondcategory1score);
                analyticalskill += int.Parse(secondcategory1score);

                logic += int.Parse(secondcategory2score);
                mathematicskill += int.Parse(secondcategory2score);
                analyticalskill += int.Parse(secondcategory2score);
                masteryinnumbers += int.Parse(secondcategory2score);

                mathematicskill += int.Parse(secondcategory3score);
                analyticalskill += int.Parse(secondcategory3score);
                masteryinnumbers += int.Parse(secondcategory3score);

                logic += int.Parse(secondexp2);
                mathematicskill += int.Parse(secondexp2);
                analyticalskill += int.Parse(secondexp2);
                masteryinnumbers += int.Parse(secondexp2);

                logic += int.Parse(thirdscore);
                mathematicskill += int.Parse(thirdscore);
                analyticalskill += int.Parse(thirdscore);
                masteryinnumbers += int.Parse(thirdscore);

                logic += int.Parse(mixscore);
                mathematicskill += int.Parse(mixscore);
                analyticalskill += int.Parse(mixscore);
                masteryinnumbers += int.Parse(mixscore);


                secondoverall = int.Parse(secondcategory1score) + int.Parse(secondcategory2score) + int.Parse(secondcategory3score) + int.Parse(secondexp2) + int.Parse(thirdscore); ;
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into grade2record values ('" + namehome.Text + "','" + secondcategory1score + "','" + secondcategory2score + "','" + secondcategory3score + "','" + secondexp + "','" + code.Text + "','" + secondexp2 + "','" + secondoverall + "','" + logic+ "','" + mathematicskill+ "','" + analyticalskill + "','" + masteryinnumbers + "','"+thirdscore+"')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your score was successfully recorded. See the scores to check your ranking.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else if (label15.Text == "GRADE 3")
            {
                logic += int.Parse(thirdscore1);
                mathematicskill += int.Parse(thirdscore1);
                analyticalskill += int.Parse(thirdscore1);
                masteryinnumbers += int.Parse(thirdscore1);

                logic += int.Parse(thirdscore2);
                mathematicskill += int.Parse(thirdscore2);
                analyticalskill += int.Parse(thirdscore2);
                masteryinnumbers += int.Parse(thirdscore2);

                mathematicskill += int.Parse(thirdscore3);
                analyticalskill += int.Parse(thirdscore3);
                

                logic += int.Parse(thirdsecondscore1);
                mathematicskill += int.Parse(thirdsecondscore1);
                analyticalskill += int.Parse(thirdsecondscore1);
                masteryinnumbers += int.Parse(thirdsecondscore1);

                logic += int.Parse(thirdscore);
                mathematicskill += int.Parse(thirdscore);
                analyticalskill += int.Parse(thirdscore);
                masteryinnumbers += int.Parse(thirdscore);


                secondoverall = int.Parse(thirdscore1) + int.Parse(thirdscore2) + int.Parse(thirdscore3) + int.Parse(thirdsecondscore1) + int.Parse(thirdscore);
                thirdtotalscore = int.Parse(thirdscore1) + int.Parse(thirdscore2) + int.Parse(thirdscore3);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into grade3record values ('" + namehome.Text + "','" + thirdscore1 + "','" + thirdscore2 + "','" + thirdscore3 + "','" + thirdtotalscore + "','" + thirdsecondscore1 + "','" + thirdscore + "','" + code.Text + "','" + secondoverall+ "','" + logic + "','" + mathematicskill + "','" + analyticalskill + "','" + masteryinnumbers + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Your score was successfully recorded. See the scores to check your ranking.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (nametext.Text != "")
            {
                namepanel.Hide();
                
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button14.Enabled = true;
                namehome.Text = nametext.Text;
                if (label15.Text == "GRADE 2")
                {
                    panel21.Show();
                }
                else if(label15.Text == "GRADE 3")
                {
                    panel23.Show();
                }
            }
            else
            {
                MessageBox.Show("Please put your full name in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
           
        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel8.Hide();
            lecturepanel.Show();
            
            helppanel.Hide();
           
            gamemodepanel.Hide();
            progpanel.Hide();
        }

        private void label15_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();

            if (label15.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select gradelevel from createcode where code=@code", con);
                cmd.Parameters.AddWithValue("@code", label15.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    label15.Text = da.GetValue(0).ToString().ToUpper();

                }

            }
            con.Close();
        }
        Point lastPoint;
        private void Studenthomepage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Studenthomepage_MouseDown(object sender, MouseEventArgs e)
        {
               lastPoint = new Point(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                panel18.Show();
                panel18.Height += 13;
                if (panel18.Height >= 41)
                {
                    timer1.Stop();
                }
                
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                panel18.Height -= 13;
                if (panel18.Height <= 1)
                {
                    timer2.Stop();
                }
            
        }

        


        private void button20_EnabledChanged(object sender, EventArgs e)
        {
            if (panel22.Width == 546)
            {
                button20.Enabled = true;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button13_Click(object sender, EventArgs e)
        {
            viewallscore scoresall = new viewallscore(this);
            scoresall.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gamemodepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label15.Text == "GRADE 1")
            {
                Form2 puzzle = new Form2(this);
                puzzle.Show();
                this.Hide();
            }
            else if (label15.Text == "GRADE 2")
            {
                grade2puzzle puzzle = new grade2puzzle(this);
                puzzle.Show();
                this.Hide();
            }
            else if (label15.Text == "GRADE 3")
            {
                grade2puzzle puzzle = new grade2puzzle(this);
                puzzle.Show();
                this.Hide();
            }

        }

        private void progressbar_Tick_1(object sender, EventArgs e)
        {




            panel22.Width++;
            if (panel22.Width == width)
            {
                progressbar.Stop();
            }

            if (panel22.Width >= 540)
            {
                try
                {
                    bunifuTransition2.ShowSync(label7);
                }
                catch
                {
                    label7.Show();
                }
            }

        }

        

        private void help(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! If you are having a problem accessing the videos, please refer to your guardians. \nIf the videos are keep gicing errors, kindly contact your developer of this program. Thank you!", "About Lecture",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {
            if(nametext.Text != null)
            {
                
                button10.Enabled = true;
                
            }
            else
            {
                button10.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void Loadplaylist()
        {
           
          
        }
        private void PlayFile(string url)
        {

        }
        private void Showfilename(Label name)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/time.mp4"));
        }

        private void subtract(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Subtraction.mp4"));
        }

        private void division(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/ordering number.mp4"));

        }

        private void number(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Fraction.mp4"));

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Numbers.mp4"));
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/time.mp4"));

        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Fraction.mp4"));

        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Multiplication.mp4"));

        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/ordering number.mp4"));

        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/place value.mp4"));

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button20_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(panel24.Visible == true)
            {
                panel24.Hide();
            }
            else
            {
                panel24.Show();
            }
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            lecturepanel.Hide();
            panel3.Hide();
            panel5.Hide();
            panel8.Hide();
            gamemodepanel.Hide();
            pictureBox14.Show();
            progpanel.Hide();
            helppanel.Show();
            
        }

        private void scoresecond_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Numbers.mp4"));
        }

        private void bunifuTileButton16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Numbers.mp4"));
        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/advanceadd.mp4"));
        }

        private void bunifuTileButton15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/advancesub.mp4"));
        }

        private void bunifuTileButton17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/advancemulti.mp4"));
        }

        private void bunifuTileButton18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/advancediv.mp4"));
        }

        private void bunifuTileButton19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/ordering number.mp4"));
        }

        private void bunifuTileButton20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/Fraction.mp4"));
        }

        private void bunifuTileButton21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/time.mp4"));
        }

        private void bunifuTileButton14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.GetFullPath("Grade 1 Lectures/place value.mp4"));
        }

        private void panel18_MouseEnter(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel18.Hide();
            panel18.Height = 1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

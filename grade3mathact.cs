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
    public partial class grade3mathact : Form
    {
        Studenthomepage form1;
        public grade3mathact(Studenthomepage fr1)
        {
            InitializeComponent();
            form1 = fr1;
        }
        int intro;

        int perimetercorrectanswer;
        int scoreperim;
        int permquest;
        int permtotalquestion = 10;

        int grade3totalscore;

        int timecorrectanswer;
        int scoretime;
        int timequestion;
        int timetotalquestion = 11;

        int identifycorrectanswer;
        int scoreidentify;
        int identifyquestion;
        int identifytotalquestion = 6;

        int genmathtotalquest;
        int fracscore;
        private void grade3mathact_Load(object sender, EventArgs e)
        {
            genmathpanel.Hide();
            button15.Hide();
            label130.Hide();
            button17.Hide();
            if (Properties.Settings.Default.toggle == true && Properties.Settings.Default.gradelevel == "Grade 3")
            {
                button15.Show();
            }
            else
            {
                button15.Hide();
                
            }

            if (Properties.Settings.Default.questionno == "Five")
            {
                genmathtotalquest = 5;
            }
            else if (Properties.Settings.Default.questionno == "Ten")
            {
                genmathtotalquest = 10;
            }
            else
            {
                genmathtotalquest = 3;
            }

            panel23.Hide();
            intro2.Hide();
            intro1.Hide();
            panel10.Hide();
            label112.Hide();
            label113.Hide();
            intro3.Hide();
            panel1.Hide();
            perimeterpanel.Hide();
            timepanel.Hide();
            introduction(1);
            identificationpanel.Hide();
        }
        private void introduction(int num)
        {
            switch (num)
            {
                case 1:
                    intro1.Show();
                    break;
                case 2:
                    intro1.Hide();
                    intro2.Show();
                    break;
                case 3:
                    intro2.Hide();
                    intro3.Show();
                    break;
                case 4:
                    panel1.Show();
                    intro3.Hide();
                    break;
            }
           
        }

        private void opt1div_Click(object sender, EventArgs e)
        {
            intro++;
            introduction(intro);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkanswerevent(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == perimetercorrectanswer)
            {
                scoreperim++;
                label5.Text = scoreperim.ToString();

            }
            if(permtotalquestion == permquest)
            {
                finalpanel.Show();
                label6.Text = scoreperim.ToString();
            }
            permquest++;
            askquestion(permquest);
            
        }
        private void askquestion(int askq)
        {
            switch(askq)
            {
                case 1:
                    question1perim.Show();
                    option1.Text = "A. 1";
                    option2.Text = "B. 10";
                    option3.Text = "C. 1000";

                    perimetercorrectanswer = 3;
                    break;
                case 2:
                    question1perim.Hide();
                    question2perim.Show();
                    option1.Text = "A. 2000";
                    option2.Text = "B. 20";
                    option3.Text = "C. 1000";

                    perimetercorrectanswer = 2;
                    break;
                case 3:
                    question2perim.Hide();
                    question3perim.Show();
                    option1.Text = "A. 2100";
                    option2.Text = "B. 10";
                    option3.Text = "C. 9000";

                    perimetercorrectanswer = 2;
                    break;
                case 4:
                    question3perim.Hide();
                    question4perim.Show();
                    option1.Text = "A. 4000";
                    option2.Text = "B. 30";
                    option3.Text = "C. 3000";

                    perimetercorrectanswer = 3;
                    break;
                case 5:
                    question4perim.Hide();
                    question5perim.Show();
                    option1.Text = "A. 5000";
                    option2.Text = "B. 1000";
                    option3.Text = "C. 7000";

                    perimetercorrectanswer = 1;
                    break;
                case 6:
                    question5perim.Hide();
                    quest6.Show();
                    panel11.Show();

                    label116.Text = "If perimeter = 19 inches,  what is \nthe value of x?";
                    label116.Location = new System.Drawing.Point(470, 118);
                    option1.Text = "A. x = 8";
                    option2.Text = "B. x = 16";
                    option3.Text = "C. x = 7";
                    perimetercorrectanswer = 1;
                    break;
                case 7:
                    question5perim.Hide();
                    quest6.Hide();
                    quest7.Show();

                    label116.Text = "If perimeter is equal to 45 cm, \nwhat is the vaulue of x?";
                    label116.Location = new System.Drawing.Point(470, 118);

                    option1.Text = "A. x = 10";
                    option2.Text = "B. x = 18";
                    option3.Text = "C. x = 9";
                    perimetercorrectanswer = 3;
                    break;
                case 8:
                    question5perim.Hide();
                    quest7.Hide();
                    quest8.Show();

                    label116.Text = "If perimeter = 27 yard, what is \nthe value of x?";
                    label116.Location = new System.Drawing.Point(470, 118);

                    option1.Text = "A. x = 1";
                    option2.Text = "B. x = 4";
                    option3.Text = "C. x = 3";
                    perimetercorrectanswer = 3;
                    break;
                case 9:
                    question5perim.Hide();
                    quest8.Hide();
                    quest9.Show();

                    label116.Text = "If perimeter = 16 inches, \nwhat is the value of x?";
                    label116.Location = new System.Drawing.Point(470, 118);

                    option1.Text = "A. x = 8";
                    option2.Text = "B. x = 5";
                    option3.Text = "C. x = 9";
                    perimetercorrectanswer = 2;
                    break;
                case 10:
                    question5perim.Hide();
                    quest9.Hide();
                    quest10.Show();

                    label116.Text = "If perimeter = 28 yard, what is \nthe value of x?";
                    label116.Location = new System.Drawing.Point(470, 118);

                    option1.Text = "A. x = 6";
                    option2.Text = "B. x = 4";
                    option3.Text = "C. x = 9";
                    perimetercorrectanswer = 1;
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e) //dito perim button
        {
            perimeterpanel.Show();
            panel1.Hide();
            finalpanel.Hide();

            panel11.Hide();
            quest6.Hide();
            quest7.Hide();
            quest8.Hide();
            quest9.Hide();
            quest10.Hide();
            panel12.Hide();
            question2perim.Hide();
            question3perim.Hide();
            question4perim.Hide();
            question5perim.Hide();
        }

        private void finalbutton_Click(object sender, EventArgs e)
        {
            perimeterpanel.Hide();
            button10.Enabled = false;
            button15.Enabled = true;
            if (!button2.Enabled && !button10.Enabled && !button3.Enabled)
            {
                button4.Enabled = true;
            }
            panel1.Show();
            
            button10.ForeColor = Color.Gray;
        }

        private void checkanswertime(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == timecorrectanswer)
            {
                scoretime++;
                label12.Text = scoretime.ToString();
            }
            if(timequestion == timetotalquestion)
            {
                finalpaneltime.Show();
                label16.Text = scoretime.ToString();
            }
            timequestion++;
            asktime(timequestion);

        }

        private void asktime(int timenum)
        {
            switch (timenum)
            {
                case 1:
                    label9.Show();

                    timeoption1.Text = "A. 86";
                    timeoption2.Text = "B. 96";
                    timeoption3.Text = "C. 24";

                    timecorrectanswer = 2;

                    break;
                case 2:
                    label61.Hide();
                    label9.Hide();
                    question2time.Show();

                    timeoption1.Text = "A. 1200";
                    timeoption2.Text = "B. 5400";
                    timeoption3.Text = "C. 2300";

                    timecorrectanswer = 2;

                    break;
                case 3:

                    question2time.Hide();
                    question3.Show();
                    timeoption1.Text = "A. 120";
                    timeoption2.Text = "B. 23";
                    timeoption3.Text = "C. 129";

                    timecorrectanswer = 2;

                    break;
                case 4:
                    question3.Hide();
                    question4.Show();
                    timeoption1.Text = "A. 817";
                    timeoption2.Text = "B. 221";
                    timeoption3.Text = "C. 220";

                    timecorrectanswer = 3;


                    break;
                case 5:

                    question4.Hide();
                    question5.Show();
                    timeoption1.Text = "A. 20";
                    timeoption2.Text = "B. 21";
                    timeoption3.Text = "C. 14";

                    timecorrectanswer = 3;

                    break;
                case 6:
                    question5.Hide();
                    question6.Show();
                    question6.Text = "HOW MANY SECONDS \n ARE IN 1 HOUR AND \n 10 MINUTES? ";
                    

                    timeoption1.Text = "A. 4200";
                    timeoption2.Text = "B. 3600";
                    timeoption3.Text = "C. 3000";

                    timecorrectanswer = 1;

                    break;
                case 7:
                    question6.Text = "HOW MANY HOURS\n ARE IN 1 WEEK AND 3\n DAYS COMBINED? ";
                    

                    timeoption1.Text = "A. 230";
                    timeoption2.Text = "B. 380";
                    timeoption3.Text = "C. 240";

                    timecorrectanswer = 3;
                    break;
                case 8:
                    question6.Text = "LORA FINISHED HER \n LAUNDRY IN 3 HOURS. HOW \n MANY MINUTES DID HE \n FINISH HIS LAUNDRY? ";
                    

                    timeoption1.Text = "A. 108";
                    timeoption2.Text = "B. 120";
                    timeoption3.Text = "C. 180";

                    timecorrectanswer = 3;
                    break;
                case 9:
                    question6.Text = "NASH AND MATTHEW DO \n THEIR SCIENCE PROJECT.\n IT TOOK THREE WEEKS BEFORE THEY FINISHED IT.\n     HOW MANY DAYS DID THEY FINISH THE PROJECT? ";
                    

                    timeoption1.Text = "A. 7";
                    timeoption2.Text = "B. 21";
                    timeoption3.Text = "C. 16";

                    timecorrectanswer = 2;
                    break;
                case 10:
                    question6.Text = "JOANA LOVES TO READ BOOKS. \nSHE FINISHED READING A BOOK IN 1 WEEK, \n4 DAYS, AND 4 HOURS. HOW MANY DAYS TOTAL \nDOES HE TAKE TO READ A BOOK?";
                    

                    timeoption1.Text = "A. 7";
                    timeoption2.Text = "B. 21";
                    timeoption3.Text = "C. 16";

                    timecorrectanswer = 2;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            timepanel.Show();
            panel1.Hide();
            question2time.Hide();
            finalpaneltime.Hide();
            question3.Hide();
            question4.Hide();
            question5.Hide();
            question6.Hide();
            panel3.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            finalpaneltime.Hide();
            button2.Enabled = false;
            button12.Enabled = true;
            if (!button2.Enabled && !button10.Enabled && !button3.Enabled)
            {
                button4.Enabled = true;
            }
            
            timepanel.Hide();
            panel1.Show();
            
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            form1.Show();
            this.Hide();
            form1.width += 183;
            form1.progressbar.Start();
            grade3totalscore = scoreperim + scoretime + scoreidentify;
            form1.intrototalscore.Text = grade3totalscore.ToString();
            form1.button8.Enabled = false;
            form1.lock2.Hide();
            form1.thirdscore1 = scoreperim.ToString();
            form1.thirdscore2 = scoretime.ToString();
            form1.thirdscore3 = scoreidentify.ToString();



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            identificationpanel.Show();
            identificationpanel.BringToFront();
            timepanel.Hide();
            question2iden.Hide();
            question3iden.Hide();
            question4iden.Hide();
            question5iden.Hide();
            perimeterpanel.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            label89.Hide();
            finalpanelidentification.Hide();
            questionsofidentification(1);
        }

        
        private void checkansidentify(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == identifycorrectanswer)
            {
                scoreidentify++;
                label48.Text = scoreidentify.ToString();
            }
            if(identifyquestion == identifytotalquestion)
            {
                
                
            }

            identifyquestion++;
            questionsofidentification(identifyquestion);
        }

        private void questionsofidentification(int identifyquest)
        {
            switch (identifyquest)
            {
                case 1:

                    identifycorrectanswer = 2;
                    break;
                case 2:
                    label61.Hide();
                    label47.Hide();
                    question2iden.Show();
                    question1iden.Hide();
                    option1iden.Text = "Segment";
                    option2iden.Text = "Point";
                    option3iden.Text = "Line";

                    identifycorrectanswer = 3;
                    
                    break;
                case 3:
                    question2iden.Hide();
                    question3iden.Show();

                    option1iden.Text = "Arrowhead";
                    option2iden.Text = "Endpoint";
                    option3iden.Text = "Dot";

                    identifycorrectanswer = 1;


                    break;
                case 4:
                    question3iden.Hide();
                    question4iden.Show();

                    option1iden.Text = "Twenty";
                    option2iden.Text = "Two";
                    option3iden.Text = "Three";

                    identifycorrectanswer = 2;


                    break;
                case 5:
                    question4iden.Hide();
                    question5iden.Show();

                    option1iden.Text = "Point";
                    option2iden.Text = "Line";
                    option3iden.Text = "Segment";

                    identifycorrectanswer = 2;

                    break;
                case 6:
                    panel6.Show();
                    break;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            identificationpanel.Hide();
            button3.Enabled = false;
            button10.Enabled = true;

            if(!button2.Enabled && !button10.Enabled && !button3.Enabled)
            {
                button4.Enabled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void identificationpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void question6_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you do you want to exit the game? \nYou will lose your progress and you cannot play this game again. Click 'HELP' button at the homepage for more information.", "Quit Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (MessageBox.Show("Are you really sure? \nPlease contact your adviser or guardian for assistance. Thank you!", "Quit Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                    form1.Show();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Hide();
            }
            else
            {
                panel3.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "75")
            {
                scoreidentify++;
            }
            if(textBox2.Text == "105")
            {
                scoreidentify++;
            }
            if (textBox3.Text == "49")
            {
                scoreidentify++;
            }
            if (textBox4.Text == "56")
            {
                scoreidentify++;
            }
            if (textBox5.Text == "70")
            {
                scoreidentify++;
            }
            if (textBox6.Text == "90")
            {
                scoreidentify++;
            }
            panel8.Show();
            help();

        }
        private async void help()
        {
            await Task.Delay(10000);
            label89.Show();
            await Task.Delay(10000);
            label89.Hide();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == true)
            {
                panel7.Hide();
            }
            else
            {
                panel7.Show();
            }
        }

        private void finalfinishiden_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "84 Cookies")
            {
                scoreidentify++;
            }
            if (comboBox2.Text == "7 Boxes")
            {
                scoreidentify++;
            }
            if (comboBox3.Text == "84 ÷ 7 ")
            {
                scoreidentify++;
            }
            if (comboBox4.Text == "TWELVE TIMES SEVEN EQUALS EIGHTY-FOUR (12 x 7=84)")
            {
                scoreidentify++;
            }
            if (comboBox5.Text == "12 Pieces of Cookies")
            {
                scoreidentify++;
            }
            finalpanelidentification.Show();
            label52.Text = scoreidentify.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel10.Show();
            panel10.BringToFront();
            label113.Visible = false;
            label112.Visible = false;
        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(a.Text =="FEO")
            {
                fracscore++;
            }
            if (b.Text == "FEO")
            {
                fracscore++;
            }
            if (c.Text == "FMO")
            {
                fracscore++;
            }
            if (d.Text == "FMO")
            {
                fracscore++;
            }
            if(eh.Text == "FMO")
            {
                fracscore++;
            }
            if (f.Text == "FMO")
            {
                fracscore++;
            }
            if (g.Text == "FEO")
            {
                fracscore++;
            }
            
            if (i.Text == "FMO")
            {
                fracscore++;
            }
            if (j.Text == "FMO")
            {
                fracscore++;
            }
            if (k.Text == "FEO")
            {
                fracscore++;
            }
            label113.Text = fracscore.ToString();
            label112.Show();
            label113.Show();

            if(label113.Visible == true && label112.Visible == true)
            {
                panel10.Hide();
                button3.Enabled = true;
                button12.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(panel12.Visible == true)
            {
                panel12.Hide();
            }
            else
            {
                panel12.Show();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            genmathpanel.Show();
            genmath(1);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }
        private void genmath(int series)
        {
            switch (series)
            {
                case 1:
                    genmathquestlabel.Text = Properties.Settings.Default.item1[0];
                    optgen1.Text = Properties.Settings.Default.item1[1];
                    optgen2.Text = Properties.Settings.Default.item1[2];
                    optgen3.Text = Properties.Settings.Default.item1[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct1.ToString();
                    label124.Text = Properties.Settings.Default.correct1.ToString();
                    break;
                case 2:
                    genmathquestlabel.Text = Properties.Settings.Default.item2[0];
                    optgen1.Text = Properties.Settings.Default.item2[1];
                    optgen2.Text = Properties.Settings.Default.item2[2];
                    optgen3.Text = Properties.Settings.Default.item2[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct2.ToString();
                    label124.Text = Properties.Settings.Default.correct2.ToString();
                    break;
                case 3:
                    genmathquestlabel.Text = Properties.Settings.Default.item3[0];
                    optgen1.Text = Properties.Settings.Default.item3[1];
                    optgen2.Text = Properties.Settings.Default.item3[2];
                    optgen3.Text = Properties.Settings.Default.item3[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct3.ToString();
                    label124.Text = Properties.Settings.Default.correct3.ToString();
                    break;
                case 4:
                    genmathquestlabel.Text = Properties.Settings.Default.item4[0];
                    optgen1.Text = Properties.Settings.Default.item4[1];
                    optgen2.Text = Properties.Settings.Default.item4[2];
                    optgen3.Text = Properties.Settings.Default.item4[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct4.ToString();
                    label124.Text = Properties.Settings.Default.correct4.ToString();
                    break;
                case 5:
                    genmathquestlabel.Text = Properties.Settings.Default.item5[0];
                    optgen1.Text = Properties.Settings.Default.item5[1];
                    optgen2.Text = Properties.Settings.Default.item5[2];
                    optgen3.Text = Properties.Settings.Default.item5[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct5.ToString();
                    label124.Text = Properties.Settings.Default.correct5.ToString();
                    break;
                case 6:
                    genmathquestlabel.Text = Properties.Settings.Default.item6[0];
                    optgen1.Text = Properties.Settings.Default.item6[1];
                    optgen2.Text = Properties.Settings.Default.item6[2];
                    optgen3.Text = Properties.Settings.Default.item6[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct6.ToString();
                    label124.Text = Properties.Settings.Default.correct6.ToString();
                    break;
                case 7:
                    genmathquestlabel.Text = Properties.Settings.Default.item7[0];
                    optgen1.Text = Properties.Settings.Default.item7[1];
                    optgen2.Text = Properties.Settings.Default.item7[2];
                    optgen3.Text = Properties.Settings.Default.item7[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct7.ToString();
                    label124.Text = Properties.Settings.Default.correct7.ToString();
                    break;
                case 8:
                    genmathquestlabel.Text = Properties.Settings.Default.item8[0];
                    optgen1.Text = Properties.Settings.Default.item8[1];
                    optgen2.Text = Properties.Settings.Default.item8[2];
                    optgen3.Text = Properties.Settings.Default.item8[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct8.ToString();
                    label124.Text = Properties.Settings.Default.correct8.ToString();
                    break;
                case 9:
                    genmathquestlabel.Text = Properties.Settings.Default.item9[0];
                    optgen1.Text = Properties.Settings.Default.item9[1];
                    optgen2.Text = Properties.Settings.Default.item9[2];
                    optgen3.Text = Properties.Settings.Default.item9[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct9.ToString();
                    label124.Text = Properties.Settings.Default.correct9.ToString();
                    break;
                case 10:
                    genmathquestlabel.Text = Properties.Settings.Default.item10[0];
                    optgen1.Text = Properties.Settings.Default.item10[1];
                    optgen2.Text = Properties.Settings.Default.item10[2];
                    optgen3.Text = Properties.Settings.Default.item10[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct10.ToString();
                    label124.Text = Properties.Settings.Default.correct10.ToString();
                    break;
            }
        }
        string genmathcorrectanswer;
        string useranswer;
        int genmathpoints;
        int genmathquestions = 1;
        private void checkansgenmath(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            useranswer = btn.Text.ToString();

            if (useranswer == genmathcorrectanswer)
            {
                genmathpoints++;
                label125.Text = genmathpoints.ToString();
            }

            if(genmathtotalquest == genmathquestions)
            {
                label123.Hide();
                genmathquestlabel.Hide();
                optgen1.Hide();
                optgen2.Hide();
                optgen3.Hide();
                label122.Hide();
               

                label127.Hide();
                label128.Hide();
                label129.Hide();

                label130.Show();
                button17.Show();
            }

            genmathquestions++;
            genmath(genmathquestions);

        }
        private async void hint()
        {
            panel23.Show();
            await Task.Delay(10000);
            panel23.Hide();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            hint();
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            genmathpanel.Hide();
            button15.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

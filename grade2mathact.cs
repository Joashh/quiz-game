using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Math_School
{
    public partial class grade2mathact : Form
    {
        Studenthomepage form1;
        public grade2mathact(Studenthomepage frm1)
        {
            InitializeComponent();
            form1 = frm1;
        }
        int num;

        int question;
        int correctanswer;

        int pvquestion;
        int pvcorrectanswer;

        int fractotalquestion = 15;
        int fracquestion;
        int fraccorrectanswer;

        int scorefirst;
        int pvscore;
        int fracscore;

        public int mixscore;

        int overallscoregrade2;
        private void grade2mathact_Load(object sender, EventArgs e)
        {
            genmathbutton.Hide();
            
            genmathpanel.Hide();
            panel23.Hide();
            genmathpanel.Hide();
            label86.Hide();
            label87.Hide();
            button9.Hide();

            if (Properties.Settings.Default.toggle == true && Properties.Settings.Default.gradelevel == "Grade 2")
            {
                genmathbutton.Show();
                
            }
            else
            {
                genmathbutton.Hide();
               
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

            wordproblempanel.Hide();
            placevaluepanel.Hide();
            panel1.Hide();
            fractionpanel.Hide();
            intro1.Show();
            intro2.Hide();
            intro3.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            num++;
            lipat(num);

        }

        private void lipat(int number)
        {
            switch (number)
            {
                case 1:
                    intro1.Hide();
                    intro2.Show();
                    break;
                case 2:
                    intro3.Show();
                    intro2.Hide();
                    break;
                case 3:
                    panel1.Show();
                    break;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want to exit? \nSee the 'help' from homepage for more information. Thank you!", "Notice.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("You will lose your progress and you cannot retrieve all your scores from this game. \nPlease contact your guardian for assistance.", "Quit Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    form1.Show();
                    this.Hide();
                }
            }
        }

        private void firstquestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (question1.Text == "How many pages did Rona read in all ?")
            {
                scorefirst++;
            }
            if (comboBox1.Text == "12 Pages of a pocket book and 8 more")
            {
                scorefirst++;
            }
            if (comboBox2.Text == "Addition")
            {
                scorefirst++;
            }
            if (comboBox3.Text == "20 Pages")
            {
                scorefirst++;
            }
            askquestionproblemsolving(1);
        }

        private void problemsolvingbutton_Click(object sender, EventArgs e)
        {
            wordproblempanel.Show();
            panel1.Hide();

            question2.Hide();
            options.Hide();
            next.Hide();
            secondchecker.Hide();
            question3.Hide();
            checkergen.Hide();
            thirdchecker.Hide();
            question4.Hide();
            question5.Hide();
            question6.Hide();
            fourthchecker.Hide();
            finalpanel.Hide();
        }

        private void checkanswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctanswer)
            {
                scorefirst++;
            }
            
            question++;
            askquestionproblemsolving(question);
        }

        private void askquestionproblemsolving(int first)
        {
            switch (first)
            {
                case 1:
                    question2.Show();
                    options.Show();
                    button10.Hide();
                    firstchecker.Hide();

                    opt1.Text = "17 Birds";
                    opt2.Text = "13 Birds";
                    opt3.Text = "19 Birds";
                    opt4.Text = "16 Birds";
                    opt5.Text = "12 Birds";

                    correctanswer = 1;
                    break;
                case 2:
                    firstchecker.Show();
                    next.Show();

                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    break;
                case 3:
                    question3.Show();
                    firstchecker.Hide();
                    next.Hide();
                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "14 asleep";
                    opt2.Text = "7 asleep";
                    opt3.Text = "10 asleep";
                    opt4.Text = "6 asleep";
                    opt5.Text = "12 asleep";

                    correctanswer = 4;
                    break;
                case 4:
                    secondchecker.Show();

                    next.Show();
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    break;
                case 5:
                    question3.Hide();
                    secondchecker.Hide();
                    next.Hide();
                    question4.Show();

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "1 Dog";
                    opt2.Text = "11 Dogs";
                    opt3.Text = "9 Dogs";
                    opt4.Text = "2 Dogs";
                    opt5.Text = "4 Dogs";

                    correctanswer = 5;
                    break;
                case 6:
                    thirdchecker.Show();
                    next.Show();
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;


                    break;
                case 7:
                    next.Hide();
                    thirdchecker.Hide();
                    question5.Show();
                    question4.Hide();

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "9 Cupcakes";
                    opt2.Text = "5 Cupcakes";
                    opt3.Text = "6 Cupcakes";
                    opt4.Text = "4 Cupcakes";
                    opt5.Text = "8 Cupcakes";

                    correctanswer = 2;
                    break;
                case 8:
                    fourthchecker.Show();
                    next.Show();
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    break;
                case 9:
                    next.Hide();
                    fourthchecker.Hide();
                    question6.Show();
                    question5.Hide();
                    label70.Text = "There are 5 dogs waiting to be adopted. \n3 of them are puppies. \nWhat fraction of the dogs are puppies? ";
                    label70.Location = new System.Drawing.Point(153, 91);

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "3/5";
                    opt2.Text = "5/3";
                    opt3.Text = "2/2";
                    opt4.Text = "9/2";
                    opt5.Text = "2/5";
                    
                    correctanswer = 1;
                    break;
                case 10:
                    checkergen.Show();
                    crrct.Location = new System.Drawing.Point(72, -2);
                    label72.Location = new System.Drawing.Point(570, -3);
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    next.Show();
                    break;
                case 11:
                    next.Hide();
                    checkergen.Hide();
                    label70.Text = "There were 32 girls, 39 boys and 3 teachers \non the playground at recess. How many children \nwere there in all? ";
                    label70.Location = new System.Drawing.Point(90, 94);

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "22";
                    opt2.Text = "88";
                    opt3.Text = "21";
                    opt4.Text = "71";
                    opt5.Text = "72";
                    
                    correctanswer = 4;
                    break;
                case 12:
                    checkergen.Show();
                    crrct.Location = new System.Drawing.Point(570, -3);
                    label75.Location = new System.Drawing.Point(237, -2);
                    label72.Location = new System.Drawing.Point(72, -2);
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    next.Show();
                    break;
                case 13:
                    next.Hide();
                    checkergen.Hide();
                    label70.Text = "There are 5 rabbits on display. \n3 of the rabbits are white and 2 of them are grey. \nWhat fraction of rabbits are grey? ";
                    label70.Location = new System.Drawing.Point(69, 94);

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "22/1";
                    opt2.Text = "2/5";
                    opt3.Text = "2/6";
                    opt4.Text = "2/3";
                    opt5.Text = "5/2";

                    correctanswer = 2;
                    break;
                case 14:
                    checkergen.Show();
                    crrct.Location = new System.Drawing.Point(237, -2);
                    label75.Location = new System.Drawing.Point(570, -3);
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    next.Show();
                    break;
                case 15:
                    next.Hide();
                    checkergen.Hide();
                    label70.Text = "There were 154 geese in the farmer’s field. \n29 of the geese flew away. How many geese were left?";
                    label70.Location = new System.Drawing.Point(19, 106);

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "122";
                    opt2.Text = "123";
                    opt3.Text = "124";
                    opt4.Text = "125";
                    opt5.Text = "126";

                    correctanswer = 4;
                    break;
                case 16:
                    checkergen.Show();
                    crrct.Location = new System.Drawing.Point(570, -3);
                    label75.Location = new System.Drawing.Point(237, -2);
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    next.Show();
                    break;
                case 17:
                    next.Hide();
                    checkergen.Hide();
                    label70.Text = "Neil has observed that his father \nuses 4 big cups of flour and 4 teaspoons \nof yeast for each pizza. If they need to make 12 pizzas, \nhow many big cups of flour are they going to use?";
                    label70.Location = new System.Drawing.Point(25, 73);

                    opt1.Enabled = true;
                    opt2.Enabled = true;
                    opt3.Enabled = true;
                    opt4.Enabled = true;
                    opt5.Enabled = true;

                    opt1.Text = "23";
                    opt2.Text = "13";
                    opt3.Text = "48";
                    opt4.Text = "24";
                    opt5.Text = "88";

                    correctanswer = 3;
                    break;
                case 18:
                    checkergen.Show();
                    crrct.Location = new System.Drawing.Point(410, -2);
                    label74.Location = new System.Drawing.Point(570, -3);
                    opt1.Enabled = false;
                    opt2.Enabled = false;
                    opt3.Enabled = false;
                    opt4.Enabled = false;
                    opt5.Enabled = false;
                    next.Show();
                    break;
                case 19:

                    finalpanel.Show();
                    scorelabelproblem.Text = scorefirst.ToString() + "/8";
                    next.Hide();
                    break;



            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            question++;
            askquestionproblemsolving(question);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wordproblempanel.Hide();
            panel1.Show();
            button6.Enabled = true;
            problemsolvingbutton.Enabled = false;
            if (placevaluebutton.Enabled == false && problemsolvingbutton.Enabled == false && fractionbutton.Enabled == false)
            {
                finishbutton.Enabled = true;
            }
        }

        private void placevaluebutton_Click(object sender, EventArgs e) // DITO KA MAG HIDE FOR PV
        {
            placevaluepanel.Show();
            placevaluepanel.BringToFront();
            askplacevalue(1);
            pvchecker.Hide();
            secondlabelquestion.Hide();
            pvnext.Hide();
            pvquest6.Hide();
            checker6.Hide();
            secondcheckerpv.Hide();
            thirdchckerpv.Hide();
            question3pv.Hide();
            question4pv.Hide();
            fourthcheckerpv.Hide();
            finalpanelpv.Hide();
        }

        private void checkanswerplacevalue(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == pvcorrectanswer)
            {
                pvscore++;
            }

            pvquestion++;
            askplacevalue(pvquestion);

        }

        private void askplacevalue(int pvnum)
        {
            switch (pvnum)
            {
                case 1:
                    option1.Text = "270";
                    option2.Text = "275";
                    option3.Text = "277";
                    option4.Text = "273";

                    pvcorrectanswer = 4;
                    break;
                case 2:
                    pvchecker.Show();
                    pvnext.Show();
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 3:
                    secondlabelquestion.Show();
                    firstquestion2.Hide();
                    pvchecker.Hide();
                    pvnext.Show();

                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "60";
                    option2.Text = "50";
                    option3.Text = "20";
                    option4.Text = "70";

                    pvcorrectanswer = 2;

                    break;
                case 4:
                    secondcheckerpv.Show();
                    pvnext.Show();
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 5:
                    question3pv.Show();
                    secondcheckerpv.Hide();
                    secondlabelquestion.Hide();
                    pvnext.Hide();

                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;

                    option1.Text = "4,2,5";
                    option2.Text = "2,7,3";
                    option3.Text = "1,4,2";
                    option4.Text = "2,3,7";

                    pvcorrectanswer = 2;

                    break;
                case 6:

                    pvnext.Show();
                    thirdchckerpv.Show();
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 7:
                    question3pv.Hide();
                    question4pv.Show();
                    pvnext.Hide();
                    thirdchckerpv.Hide();

                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "543";
                    option2.Text = "453";
                    option3.Text = "354";
                    option4.Text = "435";

                    pvcorrectanswer = 3;
                    break;
                case 8:
                    pvnext.Show();
                    fourthcheckerpv.Show();
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 9:
                    question4pv.Hide();
                    pvnext.Hide();
                    thirdchckerpv.Hide();
                    fourthcheckerpv.Hide();
                    pvquest6.Show();
                    pvquest6.Text = "What are the 3-digits numbers of \n400+ 25 + 4 = ?";
                    pvquest6.Location = new System.Drawing.Point(152, 70);

                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "439";
                    option2.Text = "438";
                    option3.Text = "429";
                    option4.Text = "444";

                    pvcorrectanswer = 3;
                    break;
                case 10: //checker
                    pvnext.Show();
                    checker6.Show();
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 11:
                    pvnext.Hide();
                    checker6.Hide();
                    
                    pvquest6.Text = "What is the missing place value of \n8 + ___ + 435 = 469 ";
                    pvquest6.Location = new System.Drawing.Point(150, 62);
                    option1.Enabled = true;
                    option2.Enabled = true; 
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "31";
                    option2.Text = "19";
                    option3.Text = "40";
                    option4.Text = "26";

                    pvcorrectanswer = 4;
                    break;
                case 12: //checker
                    pvnext.Show();
                    checker6.Show(); 
                    check.Location = new System.Drawing.Point(959, 0);
                    label76.Location = new System.Drawing.Point(671, 0);
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 13:
                    pvnext.Hide();
                    checker6.Hide();
                    
                    pvquest6.Text = "What is the number that will represent \n“Hundreds” in 563?";
                    pvquest6.Location = new System.Drawing.Point(92, 62);
                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "6";
                    option2.Text = "3";
                    option3.Text = "5";
                    option4.Text = "2";

                    pvcorrectanswer = 3;
                    break;
                case 14: //checker
                    pvnext.Show();
                    checker6.Show();
                    check.Location = new System.Drawing.Point(671, 0);
                    label76.Location = new System.Drawing.Point(959, 0);
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 15:
                    pvnext.Hide();
                    checker6.Hide();

                    pvquest6.Text = "What is the number that will represent \n“tens” in 469?";
                    pvquest6.Location = new System.Drawing.Point(92, 62);
                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "4";
                    option2.Text = "6";
                    option3.Text = "9";
                    option4.Text = "10";

                    pvcorrectanswer = 2;
                    break;
                case 16: //checker
                    pvnext.Show();
                    checker6.Show();
                    check.Location = new System.Drawing.Point(404, -1);
                    label76.Location = new System.Drawing.Point(959, 0);
                    label77.Location = new System.Drawing.Point(671, 0);
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 17:
                    pvnext.Hide();
                    checker6.Hide();

                    pvquest6.Text = "What is the number that will \nrepresent “ones” in 278?";
                    pvquest6.Location = new System.Drawing.Point(227, 66);
                    option1.Enabled = true;
                    option2.Enabled = true;
                    option3.Enabled = true;
                    option3.Enabled = true;
                    option1.Text = "8";
                    option2.Text = "2";
                    option3.Text = "7";
                    option4.Text = "20";

                    pvcorrectanswer = 1;
                    break;
                case 18: //checker
                    pvnext.Show();
                    checker6.Show();
                    check.Location = new System.Drawing.Point(115, -5);
                    label76.Location = new System.Drawing.Point(959, 0);
                    label77.Location = new System.Drawing.Point(671, 0);
                    label78.Location = new System.Drawing.Point(404, -1);
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;
                    option3.Enabled = false;
                    break;
                case 19:
                    finalpanelpv.Show();
                    pvnext.Hide();
                    fourthchecker.Hide();

                    label64.Text = pvscore.ToString();
                    break;

            }

        }

        private void pvnext_Click(object sender, EventArgs e)
        {
            pvquestion++;
            askplacevalue(pvquestion);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            placevaluepanel.Hide();
            fractionbutton.Enabled = true;
            placevaluebutton.Enabled = false;

            if (placevaluebutton.Enabled == false && problemsolvingbutton.Enabled == false && fractionbutton.Enabled == false)
            {
                finishbutton.Enabled = true;
            }
        }
        SqlConnection con = new SqlConnection(Class1.conReturn());
        int totalscoreto;
        private void finishbutton_Click(object sender, EventArgs e)
        {
            overallscoregrade2 = scorefirst + pvscore + fracscore;
            form1.intrototalscore.Text = overallscoregrade2.ToString();
            this.Hide();
            form1.Show();

            
            form1.button8.Enabled = false;
            form1.secondcategory1score = scorefirst.ToString();
            form1.secondcategory2score = pvscore.ToString();
            form1.secondcategory3score = fracscore.ToString();
            form1.mixscore = mixscore.ToString();

            form1.secondexp = overallscoregrade2.ToString();


            form1.lock2.Hide();
            form1.width += 184;
            form1.progressbar.Start();

            if (!form1.button8.Enabled && !form1.button7.Enabled)
            {
                form1.button20.Enabled = true;
            }




        }

        private void fractionbutton_Click(object sender, EventArgs e)
        {
            fractionpanel.Show();
            fractionpanel.BringToFront();
            question2frac.Hide();
            quest6.Hide();
            panel2.Hide();
            pictureBox25.Hide();
            pictureBox22.Hide();
            quest7.Hide();
            question3label.Hide();
            remark.Hide();
            question2label.Hide();
            askfrac(1);
            finalpanelfrac.Hide();
        }

        private void checkansfraction(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == fraccorrectanswer)
            {
                fracscore++;
                remark.Show();
                label68.Hide();
            }
            fracquestion++;
            askfrac(fracquestion);
        }
        private void askfrac(int fracquest)
        {
            switch (fracquest)
            {
                case 1:

                    option1frac.Text = "1/8";
                    option2frac.Text = "1/6";
                    option3frac.Text = "8/1";
                    fracnext.Hide();
                    fraccorrectanswer = 1;
                    break;
                case 2:
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 3:
                    remark.Hide();
                    question2frac.Show();
                    question2label.Show();
                    label65.Hide();
                    fracnext.Hide();
                    label68.Show();
                    
                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "Numerator";
                    option2frac.Text = "Denominator";
                    option3frac.Text = "Enumerator";

                    fraccorrectanswer = 2;
                    break;
                case 4:
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 5:
                    remark.Hide();
                    label68.Show();
                    fracnext.Hide();
                    
                    question3label.Show();
                    question2label.Hide();
                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "Denominator";
                    option2frac.Text = "Enumerator";
                    option3frac.Text = "Numerator";

                    fraccorrectanswer = 3;
                    break;
                case 6: //check
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 7:
                    remark.Hide();
                    pictureBox13.Hide();
                    question2frac.Hide();
                    label68.Show();
                    panel2.Show();
                    fracnext.Hide();
                    question3label.Hide();
                    quest6.Show();
                    quest6.Text = "What fraction is the group of short cakes";
                    

                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "3/5";
                    option2frac.Text = "2/5";
                    option3frac.Text = "5/3";

                    fraccorrectanswer = 1;
                    break;
                case 8:
                
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    
                    break;
                case 9:
                    remark.Hide();
                    label68.Show();
                    fracnext.Hide();
                    
                    quest6.Text = "What fraction is the group of hat?";
                   

                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "2/5";
                    option2frac.Text = "5/5";
                    option3frac.Text = "5/3";

                    fraccorrectanswer = 1;
                    break;
                case 10:
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 11:
                    remark.Hide();
                    label68.Show();
                    fracnext.Hide();
                    quest7.Show();
                    panel2.Hide();
                    pictureBox25.Show();
                    quest6.Text = "What fraction shows in the picture?";
                    

                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "2/2";
                    option2frac.Text = "2/4";
                    option3frac.Text = "4/4";

                    fraccorrectanswer = 2;
                    break;
                case 12:
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 13:
                    remark.Hide();
                    label68.Show();
                    fracnext.Hide();
                    quest7.Show();
                    panel2.Hide();
                    pictureBox25.Hide();
                    pictureBox22.Show();
                    quest6.Text = "What fraction shows in the picture?";
                    

                    option1frac.Enabled = true;
                    option2frac.Enabled = true;
                    option3frac.Enabled = true;

                    option1frac.Text = "4/2";
                    option2frac.Text = "1/1";
                    option3frac.Text = "4/4";

                    fraccorrectanswer = 3;
                    break;
                case 14:
                    option1frac.Enabled = false;
                    option2frac.Enabled = false;
                    option3frac.Enabled = false;

                    fracnext.Show();
                    label68.Hide();
                    break;
                case 15:
                    option1frac.Hide();
                    option2frac.Hide();
                    option3frac.Hide();
                    finalpanelfrac.Show();
                    finalpanelfrac.BringToFront();
                    label67.Text = fracscore.ToString() + "/7";
                    fracnext.Hide();
                    break;
            }

        }

        private void fractionpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fracquestion++;
            askfrac(fracquestion);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fractionpanel.Hide();
            problemsolvingbutton.Enabled = true;
            fractionbutton.Enabled = false;
            if (placevaluebutton.Enabled == false && problemsolvingbutton.Enabled == false && fractionbutton.Enabled == false)
            {
                finishbutton.Enabled = true;
            }
        }

        private void finalpanelfrac_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void question3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finalanswer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scorelabelproblem_Click(object sender, EventArgs e)
        {

        }

        private void question4pv_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void intro3_Click(object sender, EventArgs e)
        {

        }

        private void question5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mixedtopic mix = new mixedtopic(this);
            mix.Show();
            this.Hide();
        }

        private void label80_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void genmathbutton_Click(object sender, EventArgs e)
        {
            genmathpanel.Show();
            genmath(1);
        }

        string genmathcorrectanswer;
        string useranswer;
        int genmathpoints;
        private void genmath(int series)
        {
            switch(series)
            {
                case 1:
                    genmathquestlabel.Text = Properties.Settings.Default.item1[0];
                    optgen1.Text = Properties.Settings.Default.item1[1];
                    optgen2.Text = Properties.Settings.Default.item1[2];
                    optgen3.Text = Properties.Settings.Default.item1[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct1.ToString();
                    label78.Text = Properties.Settings.Default.correct1.ToString();
                    break;
                case 2:
                    genmathquestlabel.Text = Properties.Settings.Default.item2[0];
                    optgen1.Text = Properties.Settings.Default.item2[1];
                    optgen2.Text = Properties.Settings.Default.item2[2];
                    optgen3.Text = Properties.Settings.Default.item2[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct2.ToString();
                    label78.Text = Properties.Settings.Default.correct2.ToString();
                    break;
                case 3:
                    genmathquestlabel.Text = Properties.Settings.Default.item3[0];
                    optgen1.Text = Properties.Settings.Default.item3[1];
                    optgen2.Text = Properties.Settings.Default.item3[2];
                    optgen3.Text = Properties.Settings.Default.item3[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct3.ToString();
                    label78.Text = Properties.Settings.Default.correct3.ToString();
                    break;
                case 4:
                    genmathquestlabel.Text = Properties.Settings.Default.item4[0];
                    optgen1.Text = Properties.Settings.Default.item4[1];
                    optgen2.Text = Properties.Settings.Default.item4[2];
                    optgen3.Text = Properties.Settings.Default.item4[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct4.ToString();
                    label78.Text = Properties.Settings.Default.correct4.ToString();
                    break;
                case 5:
                    genmathquestlabel.Text = Properties.Settings.Default.item5[0];
                    optgen1.Text = Properties.Settings.Default.item5[1];
                    optgen2.Text = Properties.Settings.Default.item5[2];
                    optgen3.Text = Properties.Settings.Default.item5[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct5.ToString();
                    label78.Text = Properties.Settings.Default.correct5.ToString();
                    break;
                case 6:
                    genmathquestlabel.Text = Properties.Settings.Default.item6[0];
                    optgen1.Text = Properties.Settings.Default.item6[1];
                    optgen2.Text = Properties.Settings.Default.item6[2];
                    optgen3.Text = Properties.Settings.Default.item6[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct6.ToString();
                    label78.Text = Properties.Settings.Default.correct6.ToString();
                    break;
                case 7:
                    genmathquestlabel.Text = Properties.Settings.Default.item7[0];
                    optgen1.Text = Properties.Settings.Default.item7[1];
                    optgen2.Text = Properties.Settings.Default.item7[2];
                    optgen3.Text = Properties.Settings.Default.item7[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct7.ToString();
                    label78.Text = Properties.Settings.Default.correct7.ToString();
                    break;
                case 8:
                    genmathquestlabel.Text = Properties.Settings.Default.item8[0];
                    optgen1.Text = Properties.Settings.Default.item8[1];
                    optgen2.Text = Properties.Settings.Default.item8[2];
                    optgen3.Text = Properties.Settings.Default.item8[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct8.ToString();
                    label78.Text = Properties.Settings.Default.correct8.ToString();
                    break;
                case 9:
                    genmathquestlabel.Text = Properties.Settings.Default.item9[0];
                    optgen1.Text = Properties.Settings.Default.item9[1];
                    optgen2.Text = Properties.Settings.Default.item9[2];
                    optgen3.Text = Properties.Settings.Default.item9[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct9.ToString();
                    label78.Text = Properties.Settings.Default.correct9.ToString();
                    break;
                case 10:
                    genmathquestlabel.Text = Properties.Settings.Default.item10[0];
                    optgen1.Text = Properties.Settings.Default.item10[1];
                    optgen2.Text = Properties.Settings.Default.item10[2];
                    optgen3.Text = Properties.Settings.Default.item10[3];

                    genmathcorrectanswer = Properties.Settings.Default.correct10.ToString();
                    label78.Text = Properties.Settings.Default.correct10.ToString();
                    break;
            }
        }
        private async void hint()
        {
            panel23.Show();
            await Task.Delay(10000);
            panel23.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
            hint();
        }
        int genmathquest = 1;
        int genmathtotalquest;
        private void checkansgenmath(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            useranswer = btn.Text.ToString();

            if (useranswer == genmathcorrectanswer)
            {
                genmathpoints++;
                label84.Text = genmathpoints.ToString();
            }

            

            if (genmathquest == genmathtotalquest)
            {
                optgen1.Hide();
                optgen2.Hide();
                optgen3.Hide();
                label83.Hide();
                label74.Hide();
                genmathquestlabel.Hide();
                button7.Hide();
                label85.Hide();
                panel23.Hide();

                label86.Show();
                label87.Show();
                button9.Show();
            }
            panel23.Hide();
            genmathquest++;
            genmath(genmathquest);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            genmathpanel.Hide();
        }

        private void finalpanelpv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wordproblempanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void remark_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }
    }
}

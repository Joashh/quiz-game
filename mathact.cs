using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //ginamit to to display the user's name and to record quiz data
using System.Threading.Tasks;

namespace Math_School
{
    public partial class mathact : Form
    {
        public string variable;
        public string codecontainer;
        int correctAnswer;
        int questionnumber = 1;
        int score;
        int percentage;
        int totalquestion;

        int correctAnswersub;
        int questionnumbersub = 1;
        int scoresub;
        int percentagesub;
        int totalquestionsub;

        int correctAnswermul;
        int questionnumbermul = 1;
        int scoremul;
        int percentagemul;
        int totalquestionmul;

        int correctAnswerdiv;
        int scoredivvar;
        int questionnumberdiv = 1;
        int percentagediv;
        int totalquestiondiv;

        int timeleft = 31;
        int timeleftsub = 31;
        int timeleftmul= 31;
        int timeleftdiv=31;

        int evalscoreadd;
        int evalscoresub;
        int evalscoremul;
        int evalscorediv12;

        int totalscore;
        int exp;

        int timeremark;

        string studentcode;

        public string namedito;

       

        SqlConnection con = new SqlConnection(Class1.conReturn());
        Studenthomepage frm1;
        public mathact(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;
        }

        private void signup_Click(object sender, EventArgs e)
        {

            if (label1.Visible)
            {
                
                panel1.Show();
                
            }
            else
            {
                label2.Hide();
                label1.Show();
            }


        }

       

        private void mathact_Load(object sender, EventArgs e)
        {
            panel23.Hide();
            label75.Hide();
            button7.Hide();
            generalmathpanel.Hide();
            button6.Hide();
            genmthscore.Hide();

            homepageforteacher eto = new homepageforteacher(null);
            if(Properties.Settings.Default.toggle == true && Properties.Settings.Default.gradelevel == "Grade 1")
            {
                button6.Show();
                genmthscore.Show();
            }
            else
            {
                button6.Hide();
                genmthscore.Hide();
            }

            if(Properties.Settings.Default.questionno == "Five")
            {
                genmathtotalquest = 5;
            }
            else if(Properties.Settings.Default.questionno == "Ten")
            {
                genmathtotalquest = 10;
            }
            else
            {
                genmathtotalquest = 3;
            }
            finalpanel.Hide();
            panel1.Hide();
            panel2.Hide();
            label1.Hide();
            
            result.Hide();
            Subtract.Hide();
            resultsub.Hide();
            
            
            
            panel7.Hide();
            resultmul.Hide();
            panel8.Hide();
            correct.Hide();
            timer1.Enabled = true;
            addtimer.Enabled = true;
            multiplytimer.Enabled = true;
            timerdiv.Enabled = true;
            addtimer.Stop();
            multiplytimer.Stop();
            timerdiv.Stop();
            timer1.Stop();
            divisionpanel.Hide();
            resultdiv.Hide();
            loginstudent ito = new loginstudent();

            
           
           


        }

        private void addition_Click(object sender, EventArgs e)
        {

        }

        private void addition_Click_1(object sender, EventArgs e)
        {
            
               
            
                panel2.Show();
            
            
            label8.Show();

            Askquestion(1);
            totalquestion = 15;
            panel1.Hide();

        }
        
            private void CheckAnswerEvent(object sender, EventArgs e)
            {
            timeleft = 31;
           
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                timeremark = 3;
                remark.Start();
                score++;
                scorelbl.Text = score.ToString();
               
             
            }
            
            if (questionnumber == totalquestion)
            {
                addtimer.Stop();
                label8.Hide();
                result.Show();
                result.BringToFront();
                additiontime.Hide();
                scorelbl.Hide();
                addpass.Hide();
                pictureBox21.Hide();
                label7.Hide();
                label6.Hide();
                label9.Hide();
                label5.Hide();
               
                percentage = (int)Math.Round((double)(score * 100) / totalquestion);
                scoreresult.Text = score.ToString();
                percentresult.Text = percentage.ToString();

                if (percentage > 50)
                {
                    remarks.Text = "WELL DONE!";
                }
                else
                {
                    remarks.Text = "GOOD";
                }

                /*score = 0;
                questionnumber = 0;
                Askquestion(questionnumber);*/

            }

            
            questionnumber++;
            Askquestion(questionnumber);
            
        }

        private void Askquestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    addtimer.Start();
                    
                    a.Text = "2";
                    b.Text = "3";
                    op.Text = "+";

                    opt1.Text = "5";
                    opt2.Text = "12";
                    opt3.Text = "8";
                    opt4.Text = "10";

                    correctAnswer = 1;
                    break;

                case 2:
                    addtimer.Start();
                    
                    a.Text = "3";
                    b.Text = "10";
                    op.Text = "+";

                    opt1.Text = "9";
                    opt2.Text = "13";
                    opt3.Text = "32";
                    opt4.Text = "12";

                    correctAnswer = 2;
                    break;
                case 3:
                    addtimer.Start();
                    
                    a.Text = "8";
                    b.Text = "2";
                    op.Text = "×";

                    opt1.Text = "19";
                    opt2.Text = "16";
                    opt3.Text = "5";
                    opt4.Text = "39";

                    correctAnswer = 2;
                    break;
                case 4:
                    addtimer.Start();
                    
                    a.Text = "12";
                    b.Text = "7";
                    op.Text = "-";

                    opt1.Text = "4";
                    opt2.Text = "5";
                    opt3.Text = "12";
                    opt4.Text = "13";

                    correctAnswer = 2;
                    break;
                case 5:
                    addtimer.Start();
                    
                    a.Text = "12";
                    b.Text = "3";
                    op.Text = "÷";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 3;
                    break;
                case 6:
                    addtimer.Start();

                    a.Text = "1";
                    b.Text = "1";
                    op.Text = "×";

                    opt1.Text = "4";
                    opt2.Text = "2";
                    opt3.Text = "1";
                    opt4.Text = "11";

                    correctAnswer = 3;
                    break;
                case 7:
                    addtimer.Start();

                    a.Text = "4";
                    b.Text = "5";
                    op.Text = "+";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 4;
                    break;
                case 8:
                    addtimer.Start();

                    a.Text = "6";
                    b.Text = "2";
                    op.Text = "-";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 3;
                    break;
                case 9:
                    addtimer.Start();

                    a.Text = "9";
                    b.Text = "3";
                    op.Text = "÷";

                    opt1.Text = "3";
                    opt2.Text = "1";
                    opt3.Text = "22";
                    opt4.Text = "2";

                    correctAnswer = 1;
                    break;
                case 10:
                    addtimer.Start();

                    a.Text = "16";
                    b.Text = "4";
                    op.Text = "÷";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 3;
                    break;
                case 11:
                    addtimer.Start();

                    a.Text = "18";
                    b.Text = "3";
                    op.Text = "÷";

                    opt1.Text = "6";
                    opt2.Text = "1";
                    opt3.Text = "22";
                    opt4.Text = "7";

                    correctAnswer = 1;
                    break;
                case 12:
                    addtimer.Start();

                    a.Text = "19";
                    b.Text = "6";
                    op.Text = "-";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 1;
                    break;
                case 13:
                    addtimer.Start();

                    a.Text = "3";
                    b.Text = "4";
                    op.Text = "+";

                    opt1.Text = "3";
                    opt2.Text = "4";
                    opt3.Text = "7";
                    opt4.Text = "2";

                    correctAnswer = 3;
                    break;
                case 14:
                    addtimer.Start();

                    a.Text = "20";
                    b.Text = "10";
                    op.Text = "-";

                    opt1.Text = "10";
                    opt2.Text = "20";
                    opt3.Text = "11";
                    opt4.Text = "21";

                    correctAnswer = 1;
                    break;
                case 15:
                    addtimer.Start();

                    a.Text = "8";
                    b.Text = "2";
                    op.Text = "÷";

                    opt1.Text = "13";
                    opt2.Text = "3";
                    opt3.Text = "4";
                    opt4.Text = "9";

                    correctAnswer = 3;
                    break;



            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addscore.Text = scoreresult.Text.ToString();
            subtraction.Enabled = true;
            result.Hide();
            panel2.Hide();
            panel1.Show();
            addition.Enabled = false;
            addition.ForeColor = Color.Gray;

            if (addition.Enabled == false && subtraction.Enabled == false && multiply.Enabled == false && division.Enabled == false)
            {
                button5.Enabled = true;
                button5.ForeColor = Color.White;
            }
            else
            {
                button5.Enabled = false;
                button5.ForeColor = Color.Gray;

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



        private void subtractpanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void result_Paint(object sender, PaintEventArgs e)
        {

        }





        private void AskquestionSubtract(int qnumsub)
        {


        }



        private void AskquestionSub(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    timer1.Start();

                    counting1.Show();

                    option1.Text = "1";
                    option2.Text = "2";
                    option3.Text = "5";
                    option4.Text = "8";

                    correctAnswersub = 8;
                    break;

                case 2:
                    counting1.Hide();
                    timer1.Start();

                    count2.Show();

                    option1.Text = "3";
                    option2.Text = "4";
                    option3.Text = "1";
                    option4.Text = "8";

                    correctAnswersub = 6;
                    break;
                case 3:
                    count2.Hide();
                    count3.Show();
                    timer1.Start();
                   
                    
                    option1.Text = "13";
                    option2.Text = "3";
                    option3.Text = "5";
                    option4.Text = "4";

                    correctAnswersub = 8;
                    break;
                case 4:
                    timer1.Start();
                    count3.Hide();
                    count4.Show();
                    

                    option1.Text = "12";
                    option2.Text = "21";
                    option3.Text = "11";
                    option4.Text = "13";



                    correctAnswersub = 5;
                    break;
                case 5:
                    timer1.Start();

                    count4.Hide();
                    count5.Show();

                    option1.Text = "24";
                    option2.Text = "21";
                    option3.Text = "45";
                    option4.Text = "26";

                    correctAnswersub = 8;
                    break;
                case 6:
                    count5.Hide();
                    count6.Show();
                    timer1.Start();
                    label54.Text = "HOW MANY BALLOONS ARE INSIDE THE BOX?";
                    label54.Location = new System.Drawing.Point(169, 15);
                    option1.Text = "22";
                    option2.Text = "11";
                    option3.Text = "12";
                    option4.Text = "10";
                    
                    correctAnswersub = 7;
                    break;
                case 7:
                    timer1.Start();
                    balloon.Hide();
                    trees.Show();
                    label54.Text = "HOW MANY TREES ARE INSIDE THE BOX?";
                    label54.Location = new System.Drawing.Point(200, 12);
                    option1.Text = "14";//5
                    option2.Text = "12";//6
                    option3.Text = "11";//7
                    option4.Text = "15";//8

                    correctAnswersub = 5;
                    break;
                case 8:
                    timer1.Start();
                    trees.Hide();
                    blend.Show();
                    label54.Text = "HOW MANY LOLLIPOP ARE PRESENT INSIDE THE BOX?";
                    label54.Location = new System.Drawing.Point(128, 10);
                    option1.Text = "5";
                    option2.Text = "11";
                    option3.Text = "3";
                    option4.Text = "4";

                    correctAnswersub = 8;
                    break;
                case 9:
                    timer1.Start();
                    label54.Text = "HOW MANY PILLOWS ARE THERE IN THE BOX?";
                    label54.Location = new System.Drawing.Point(162,8);
                    option1.Text = "5";
                    option2.Text = "4";
                    option3.Text = "3";
                    option4.Text = "7";

                    correctAnswersub = 5;
                    break;
                case 10:
                    timer1.Start();
                    label54.Text = "HOW MANY EGG ARE THERE IN THE BOX?";
                    label54.Location = new System.Drawing.Point(186, 9);
                    option1.Text = "2";
                    option2.Text = "4";
                    option3.Text = "6";
                    option4.Text = "8";

                    correctAnswersub = 7;
                    break;
                

            }
        }

        private void checkanssub(object sender, EventArgs e)
        {
            timeleftsub = 31;
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswersub)
            {
                scoresub++;
                label20.Text = scoresub.ToString();
                
                
            }
            

            if (questionnumbersub == totalquestionsub)
            {
                timer1.Stop();
                resultsub.Show();
                resultsub.BringToFront();

                counting1.Hide();
                counting1.SendToBack();
                count2.Hide();
                count3.Hide();
                count4.Hide();
                count5.Hide();
                count6.Hide();
                panel1.Hide();
                panel9.Hide();
                panel13.Hide();
                panel14.Hide();

                option1.Hide();
                option2.Hide();
                option3.Hide();
                option4.Hide();
                panel9.Hide();
                passsub.Hide();
                option4.Hide();
                option2.Hide();
                subtime.Hide();
                label20.Hide();
                
                label25.Hide();
                label24.Hide();
                label16.Hide();
                label18.Hide();
               
              
                percentagesub = (int)Math.Round((double)(scoresub * 100) / totalquestionsub);
                scoreresultsub.Text = scoresub.ToString();
                percentresultsub.Text = percentagesub.ToString();

                if (percentagesub > 50)
                {
                    remarksresultsub.Text = "WELL DONE!";
                }
                else
                {
                    remarksresultsub.Text = "GOOD";
                }

                

            }

            
            questionnumbersub++;
            AskquestionSub(questionnumbersub);

        }


        private void subtraction_Click_1(object sender, EventArgs e)
        {
            
                
           
                Subtract.Show();
            
            counting1.Hide();
            count2.Hide();
            count3.Hide();
            count4.Hide();
            count5.Hide();
            panel1.Hide();
            blend.Hide();
            count6.Hide();
            trees.Hide();
            label8.Show();
            

            AskquestionSub(1);
            totalquestionsub = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            division.Enabled = true;
            subtraction.Enabled = false;
            subtraction.ForeColor = Color.Gray;
            subtime.Hide();
            label25.Hide();
            label16.Hide();
            label20.Hide();
            label18.Hide();
            Subtract.Hide();
            panel1.Show();
            panel1.BringToFront();
            subtractscore.Text = scoreresultsub.Text.ToString();
            resultsub.Hide();

            if (addition.Enabled == false && subtraction.Enabled == false && multiply.Enabled == false && division.Enabled == false)
            {
                button5.Enabled = true;
                button5.ForeColor = Color.White;
            }
            else
            {
                button5.Enabled = false;
                button5.ForeColor = Color.Gray;

            }
        }

        private void addscore_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            oneword.Hide();
            twoword.Hide();
            threeword.Hide();
            fourword.Hide();
            fiveword.Hide();
            quest6.Hide();
            
                panel8.Show();
            
            panel1.Hide();
            label8.Show();
            AskquestionMul(1);
            totalquestionmul = 15;
        }
        private void AskquestionMul(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    multiplytimer.Start();
                    timeleftmul = 31;

                    oneword.Show();
                    

                    option1mul.Text = "3";
                    option2mul.Text = "1";
                    option3mul.Text = "8";
                    option4mul.Text = "5";

                    correctAnswermul = 9;
                    break;

                case 2:
                    multiplytimer.Start();
                    oneword.Hide();
                    twoword.Show();
                    

                    option1mul.Text = "2";
                    option2mul.Text = "1";
                    option3mul.Text = "0";
                    option4mul.Text = "3";

                    correctAnswermul = 10;
                    break;
                case 3:
                    multiplytimer.Start();
                    twoword.Hide();
                    threeword.Show();

                    

                    option1mul.Text = "4";
                    option2mul.Text = "11";
                    option3mul.Text = "2";
                    option4mul.Text = "6";

                    correctAnswermul = 12;
                    break;
                case 4:
                    multiplytimer.Start();
                    threeword.Hide();
                    fourword.Show();
                    

                    option1mul.Text = "8";
                    option2mul.Text = "4";
                    option3mul.Text = "9";
                    option4mul.Text = "10";

                    correctAnswermul = 11;
                    break;
                case 5:
                    multiplytimer.Start();
                    fiveword.Show();
                    fourword.Hide();
                    

                    option1mul.Text = "22";
                    option2mul.Text = "6";
                    option3mul.Text = "1";
                    option4mul.Text = "9";

                    correctAnswermul = 10;
                    break;
                case 6:
                    multiplytimer.Start();
                    fiveword.Hide();
                    quest6.Show();
                    quest6.Text = "There are 15 doves and 3 parrots. How many birds are there in all?";
                    

                    option1mul.Text = "12"; //9
                    option2mul.Text = "18"; //10
                    option3mul.Text = "10"; //11
                    option4mul.Text = "11";  //12

                    correctAnswermul = 10;
                    break;
                case 7:
                    multiplytimer.Start();
                    
                    quest6.Show();
                    quest6.Text = "There are 20 boys and 22 girls inside the room. \nHow many pupils are there in all?";
                    

                    option1mul.Text = "40"; //9
                    option2mul.Text = "41"; //10
                    option3mul.Text = "42"; //11
                    option4mul.Text = "43";  //12

                    correctAnswermul = 11;
                    break;
                case 8:
                    multiplytimer.Start();
                    
                    quest6.Show();
                    quest6.Text = "In the farm of Lolo Karding, there are 12 rooster and 12 hens. \nHow many chickens are there in all?";
                  

                    option1mul.Text = "24"; //9
                    option2mul.Text = "15"; //10
                    option3mul.Text = "26"; //11
                    option4mul.Text = "11";  //12

                    correctAnswermul = 9;
                    break;
                case 9:
                    multiplytimer.Start();
                    
                    quest6.Show();
                    quest6.Text = "Mr. Garcia has 25 English books and 24 Filipino books, \nhow many books are there in all";
                    

                    option1mul.Text = "60"; //9
                    option2mul.Text = "47"; //10
                    option3mul.Text = "49"; //11
                    option4mul.Text = "12";  //12

                    correctAnswermul = 11;
                    break;
                case 10:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "Rachel has 42.00 pesos while Ana has 50.00 pesos. \nHow much money do they have in all?";
                    

                    option1mul.Text = "50.00"; //9
                    option2mul.Text = "90.00"; //10
                    option3mul.Text = "92.00"; //11
                    option4mul.Text = "12.21";  //12

                    correctAnswermul = 11;
                    break;
                case 11:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "Mother gave 37.00 pesos to Rea. While father gave her 22.00 pesos. \nHow much money does Rea have in all?";
               

                    option1mul.Text = "59.00"; //9
                    option2mul.Text = "41.00"; //10
                    option3mul.Text = "52.00"; //11
                    option4mul.Text = "49.21";  //12

                    correctAnswermul = 9;
                    break;
                case 12:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "The principal planted 30 narra trees and 10 acacia trees. \nHow many trees are planted by the principal?";
                 

                    option1mul.Text = "20"; //9
                    option2mul.Text = "30"; //10
                    option3mul.Text = "40"; //11
                    option4mul.Text = "50";  //12

                    correctAnswermul = 11;
                    break;
                case 13:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "Mara has 18 ribbons. Cara 14 ribbons too. \nHow many ribbons do they have in all?";
                  

                    option1mul.Text = "22"; //9
                    option2mul.Text = "32"; //10
                    option3mul.Text = "42"; //11
                    option4mul.Text = "52";  //12

                    correctAnswermul = 10;
                    break;
                case 14:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "Sam has 23 guavas and Tim has 20 guavas too. \nHow many guavas do they have in all?";
                   
                    option1mul.Text = "43"; //9
                    option2mul.Text = "56"; //10
                    option3mul.Text = "53"; //11
                    option4mul.Text = "42";  //12

                    correctAnswermul = 9;
                    break;
                case 15:
                    multiplytimer.Start();

                    quest6.Show();
                    quest6.Text = "Sandra has 14 bond papers and Rey has 7 bond papers, \nhow many bond papers do they have in all?";
                   
                    option1mul.Text = "21"; //9
                    option2mul.Text = "22"; //10
                    option3mul.Text = "23"; //11
                    option4mul.Text = "32";  //12

                    correctAnswermul = 9;
                    break;
            }
        }

        private void checkanswers(object sender, EventArgs e)
        {

            timeleftmul = 31;
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswermul)
            {
                scoremul++;
                label33.Text = scoremul.ToString();
                
            }
            if (questionnumbermul == totalquestionmul)
            {
                multiplytimer.Stop();
                resultmul.Show();
                resultmul.BringToFront();

                fiveword.Hide();
                option1mul.Hide();
                panel10.Hide();
                mulpass.Hide();
                quest6.Hide();
                pictureBox19.Hide();
                option2mul.Hide();
                option3mul.Hide();
                panel19.Hide();
                option4mul.Hide();
                multiplypanel.Hide();
                label35.Hide();
                label38.Hide();
                label21.Hide();
                panel15.Hide();
                panel19.Hide();
                label33.Hide();
                label37.Hide();
                label31.Hide();
               
                
                
                
                percentagemul = (int)Math.Round((double)(scoremul * 100) / totalquestionmul);
                mulscoreresult.Text = scoremul.ToString();
                mulpercentresult.Text = percentagemul.ToString();

                if (percentagemul > 50)
                {
                    mulremarksresult.Text = "WELL DONE!";
                }
                else
                {
                    mulremarksresult.Text = "GOOD";
                }

               

            }
            
            questionnumbermul++;
                AskquestionMul(questionnumbermul);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            panel8.Hide();
            multiplypanel.Hide();
            mulscore.Text = mulscoreresult.Text.ToString();
            panel1.Show();
            multiply.Enabled = false;
            multiply.ForeColor = Color.Gray;
            resultmul.Hide();
            if (addition.Enabled == false && subtraction.Enabled == false && multiply.Enabled == false && division.Enabled == false)
            {
                button5.Enabled = true;
                button5.ForeColor = Color.White;
            }
            else
            {
                button5.Enabled = false;
                button5.ForeColor = Color.Gray;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleftsub > 0)
            {
                timeleftsub--;
                subtime.Text = timeleftsub.ToString();
            }
            
            if (timeleftsub == 0)
            {

                passsub.PerformClick();
          
            }
        }

        private void addtimer_Tick(object sender, EventArgs e)
        {
            
            if (timeleft > 0)
            {
                timeleft--;
                additiontime.Text = timeleft.ToString();
            }

            if (timeleft == 0)
            {
                addpass.PerformClick();

                

                

            }
        }

        private void multiplytimer_Tick(object sender, EventArgs e)
        {
            if (timeleftmul > 0)
            {
                timeleftmul--;
                label35.Text = timeleftmul.ToString();
            }

            if (timeleftmul == 0)
            {
                mulpass.PerformClick();

                
                
                
                
            }
        }

        private void divisionpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {
           
                divisionpanel.Show();
            
            
            idone.Hide();
            id6.Hide();
            idtwo.Hide();
            idthree.Hide();
            idfour.Hide();
            idfive.Hide();
            panel1.Hide();
            label8.Show();
            
            divisionpanel.BringToFront();
            AskquestionDiv(1);
            totalquestiondiv = 10;
        }
        private void AskquestionDiv(int qnum)
        {
            switch (qnum)
            {
                //a-13
                //b-14
                //c-15
                //d-16
                case 1:
                    timerdiv.Start();
                    timeleft = 31;
                    idone.Show();
                   

                    opt1div.Text = "12";
                    option2div.Text = "10";
                    option3div.Text = "9";
                    option4div.Text = "22";

                    correctAnswerdiv = 14;
                    break;

                case 2:
                    timerdiv.Start();
                    idone.Hide();
                    idtwo.Show();
                   

                    opt1div.Text = "+";
                    option2div.Text = "-";
                    option3div.Text = "/";
                    option4div.Text = "!";

                    correctAnswerdiv = 13;
                    break;
                case 3:
                    timerdiv.Start();
                    idtwo.Hide();
                    idthree.Show();
                   

                    opt1div.Text = "-";
                    option2div.Text = "+";
                    option3div.Text = "/";
                    option4div.Text = "%";

                    correctAnswerdiv = 13;
                    break;
                case 4:
                    timerdiv.Start();
                    idfour.Show();
                    idthree.Hide();
                  

                    opt1div.Text = "12";
                    option2div.Text = "65";
                    option3div.Text = "32";
                    option4div.Text = "40";

                    correctAnswerdiv = 16;
                    break;
                case 5:
                    timerdiv.Start();
                    idfour.Hide();
                    idfive.Show();
                   

                    opt1div.Text = "23";
                    option2div.Text = "15";
                    option3div.Text = "26";
                    option4div.Text = "24";

                    correctAnswerdiv = 15;
                    break;
                case 6:
                    idfive.Hide();
                    id6.Show();
                    label55.Text = "19 = ___ + 9";

                    opt1div.Text = "11"; //12
                    option2div.Text = "10"; //14
                    option3div.Text = "12"; //15
                    option4div.Text = "22"; //16

                    correctAnswerdiv = 14;
                    break;
                case 7:
                    label55.Text = "35 = 30 + __";

                    opt1div.Text = "3"; //12
                    option2div.Text = "5"; //14
                    option3div.Text = "2"; //15
                    option4div.Text = "8"; //16

                    correctAnswerdiv = 14;
                    break;
                case 8:
                    label55.Text = "40 = 31 + __";

                    opt1div.Text = "4"; //12
                    option2div.Text = "12"; //14
                    option3div.Text = "9"; //15
                    option4div.Text = "11"; //16

                    correctAnswerdiv = 15;
                    break;
                case 9:
                    label55.Text = "21 = 20 + __";

                    opt1div.Text = "1"; //12
                    option2div.Text = "12"; //14
                    option3div.Text = "7"; //15
                    option4div.Text = "11"; //16

                    correctAnswerdiv = 12;
                    break;
                case 10:
                    label55.Text = "31 = 20 + __";

                    opt1div.Text = "11"; //12
                    option2div.Text = "21"; //14
                    option3div.Text = "11"; //15
                    option4div.Text = "12"; //16

                    correctAnswerdiv = 15;
                    break;
            }
        }
        private void checkeventdiv(object sender, EventArgs e)
        {
            timeleftdiv = 31;
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswerdiv)
            {
                scoredivvar++;
                scoreinpaneldiv.Text = scoredivvar.ToString();
                
            }
            if (questionnumberdiv == totalquestiondiv)
            {
                timerdiv.Stop();
                resultdiv.Show(); //edit
                resultdiv.BringToFront();
                

                opt1div.Hide();
                panel12.Hide();
                option2div.Hide();
                option4div.Hide();
                panel20.Hide();
                idone.Hide();
                idtwo.Hide();
                idthree.Hide();
                idfour.Hide();
                idfive.Hide();
                timediv.Hide();
                label32.Hide();
                label26.Hide();
                label49.Hide();
                label48.Hide();
                label34.Hide();
                scoreinpaneldiv.Hide();
                
                
                
                
                label6.Hide();
                
                
       
                percentagediv = (int)Math.Round((double)(scoredivvar * 100) / totalquestiondiv);
                scoredivresult.Text = scoredivvar.ToString();
                percentageresultdiv.Text = percentagediv.ToString();

                if (percentagediv > 50)
                {
                    remarksdiv.Text = "WELL DONE!";
                }
                else
                {
                    remarksdiv.Text = "GOOD";
                }

                

            }
            
            questionnumberdiv++;
            AskquestionDiv(questionnumberdiv);

        }

        private void timerdiv_Tick(object sender, EventArgs e)
        {
            if (timeleftdiv > 0)
            {
                timeleftdiv--;
                timediv.Text = timeleftdiv.ToString();
            }

            if (timeleftdiv == 0)
            {
                divpass.PerformClick();
                
            }
        }

        private void donebuttondiv_Click(object sender, EventArgs e)
        {
            divisionpanel.Hide();
            multiply.Enabled = true;
            divscore.Text = scoredivresult.Text.ToString();
            panel1.Show();
            resultdiv.Hide();
            division.Enabled = false;

            if (addition.Enabled == false && subtraction.Enabled == false && multiply.Enabled == false && division.Enabled == false)
            {
                button5.Enabled = true;
                button5.ForeColor = Color.White;
            }
            else
            {
                button5.Enabled = false;
                button5.ForeColor = Color.Gray;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalscore = int.Parse(addscore.Text) + int.Parse(subtractscore.Text) + int.Parse(mulscore.Text) + int.Parse(divscore.Text);
            exp = (int)Math.Round((double)(100 * totalscore) / 20);

            label45.Text = exp.ToString() + "%";

            finalpanel.Show();
            finalpanel.BringToFront();
            
        }

        private void mathact_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            
            this.Close();
            

            frm1.category1score = score.ToString();
            frm1.category2score = scoresub.ToString();
            frm1.category3score = scoremul.ToString();
            frm1.category4score = scoredivvar.ToString();
            
            

            frm1.button8.Enabled = false;
            frm1.exp = exp.ToString();
            frm1.introscore.Show();
            frm1.intrototalscore.Text = exp.ToString();
            frm1.Show();
            
            
            frm1.width += 183;
            frm1.lock2.Hide();
          
            frm1.progressbar.Start();

            frm1.skilltimer.Start();
            if (!frm1.button8.Enabled && !frm1.button7.Enabled && !frm1.button1.Enabled)
            {
                frm1.button20.Enabled = true;
            }
        }
        Point lastPoint;
        private void mathact_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mathact_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void amul_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void multiplypanel_Click(object sender, EventArgs e)
        {

        }

        private void bmul_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void resultmul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void namepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void remark_Tick(object sender, EventArgs e)
        {
            if (timeremark > 0)
            {
                timeremark--;
                correct.Show();
            }
            else if(timeremark == 0)
            {
                correct.Hide();
                remark.Stop();
            }
        }

        private void resultsub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void count4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void genmath(int num)
        {
            switch (num)
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
        private void button6_Click_1(object sender, EventArgs e)
        {
            genmath(1);
            generalmathpanel.BringToFront();
           
                generalmathpanel.Show();
            
        }
        int genmathquest = 1;
        private void optgen3_Click(object sender, EventArgs e)
        {

        }
        int genmathtotalquest;
        int genmathpoints;
        string genmathcorrectanswer;
        string useranswer;
        private void checkansgenmath(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            useranswer = btn.Text.ToString();
            
            if (useranswer == genmathcorrectanswer)
            {
                genmathpoints++;
                label59.Text = genmathpoints.ToString();
            }

            panel23.Hide();
            genmathquest++;
            genmath(genmathquest);

            if (genmathquest == genmathtotalquest)
            {
                optgen1.Hide();
                optgen2.Hide();
                optgen3.Hide();
                label80.Hide();
                label74.Hide();
                genmathquestlabel.Hide();
                pictureBox8.Hide();
                label59.Hide();
                button8.Hide();
                button7.Show();
                label75.Show();
            }

            
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            generalmathpanel.Hide();
            genmthscore.Text = genmathpoints.ToString();
            //button6.Enabled = false;
        }

        private async void hint()
        {
            panel23.Show();
            await Task.Delay(10000);
            panel23.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            hint();
            button8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void quest6_Click(object sender, EventArgs e)
        {

        }
    }
}


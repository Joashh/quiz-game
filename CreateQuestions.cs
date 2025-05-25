using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Math_School
{
    public partial class CreateQuestions : Form
    {
        public CreateQuestions()
        {
            InitializeComponent();
        }

        public string[] questions = new string[] { };


        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(questionno.Text == "Ten")
            {
                panel2.Show();
            }
            else
            {
                panel2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void CreateQuestions_Load(object sender, EventArgs e)
        {

            comboBox5.Text = Properties.Settings.Default.gradelevel;
            

            question1.Text = Properties.Settings.Default.item1[0];
            question2.Text = Properties.Settings.Default.item2[0];
            question3.Text = Properties.Settings.Default.item3[0];
            question4.Text = Properties.Settings.Default.item4[0];
            question5.Text = Properties.Settings.Default.item5[0];
            question6.Text = Properties.Settings.Default.item6[0];
            question7.Text = Properties.Settings.Default.item7[0];
            question8.Text = Properties.Settings.Default.item8[0];
            question9.Text = Properties.Settings.Default.item9[0];
            question10.Text = Properties.Settings.Default.item10[0];

            opta1.Text = Properties.Settings.Default.item1[1];
            opta2.Text = Properties.Settings.Default.item2[1];
            opta3.Text = Properties.Settings.Default.item3[1];
            opta4.Text = Properties.Settings.Default.item4[1];
            opta5.Text = Properties.Settings.Default.item5[1];
            opta6.Text = Properties.Settings.Default.item6[1];
            opta7.Text = Properties.Settings.Default.item7[1];
            opta8.Text = Properties.Settings.Default.item8[1];
            opta9.Text = Properties.Settings.Default.item9[1];
            opta10.Text = Properties.Settings.Default.item10[1];

            optb1.Text = Properties.Settings.Default.item1[2];
            optb2.Text = Properties.Settings.Default.item2[2];
            optb3.Text = Properties.Settings.Default.item3[2];
            optb4.Text = Properties.Settings.Default.item4[2];
            optb5.Text = Properties.Settings.Default.item5[2];
            optb6.Text = Properties.Settings.Default.item6[2];
            optb7.Text = Properties.Settings.Default.item7[2];
            optb8.Text = Properties.Settings.Default.item8[2];
            optb9.Text = Properties.Settings.Default.item9[2];
            optb10.Text = Properties.Settings.Default.item10[2];

            optc1.Text = Properties.Settings.Default.item1[3];
            optc2.Text = Properties.Settings.Default.item2[3];
            optc3.Text = Properties.Settings.Default.item3[3];
            optc4.Text = Properties.Settings.Default.item4[3];
            optc5.Text = Properties.Settings.Default.item5[3];
            optc6.Text = Properties.Settings.Default.item6[3];
            optc7.Text = Properties.Settings.Default.item7[3];
            optc8.Text = Properties.Settings.Default.item8[3];
            optc9.Text = Properties.Settings.Default.item9[3];
            optc10.Text = Properties.Settings.Default.item10[3];

            crrct1.Text = Properties.Settings.Default.correct1;
            crrct2.Text = Properties.Settings.Default.correct2;
            crrct3.Text = Properties.Settings.Default.correct3;
            crrct4.Text = Properties.Settings.Default.correct4;
            crrct5.Text = Properties.Settings.Default.correct5;
            crrct6.Text = Properties.Settings.Default.correct6;
            crrct7.Text = Properties.Settings.Default.correct7;
            crrct8.Text = Properties.Settings.Default.correct8;
            crrct9.Text = Properties.Settings.Default.correct9;
            crrct10.Text = Properties.Settings.Default.correct10;

            panel2.Hide();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please re-check your questions before pressing complete button. \nAre these questions final?", "Verify your question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Properties.Settings.Default.correct1 = crrct1.Text;
                    Properties.Settings.Default.correct2 = crrct2.Text;
                    Properties.Settings.Default.correct3 = crrct3.Text;
                    Properties.Settings.Default.correct4 = crrct4.Text;
                    Properties.Settings.Default.correct5 = crrct5.Text;
                    Properties.Settings.Default.correct6 = crrct6.Text;
                    Properties.Settings.Default.correct7 = crrct7.Text;
                    Properties.Settings.Default.correct8 = crrct8.Text;
                    Properties.Settings.Default.correct9 = crrct9.Text;
                    Properties.Settings.Default.correct10 = crrct10.Text;

                    StringCollection items_1 = new StringCollection();
                    items_1.Add(question1.Text);
                    items_1.Add(opta1.Text);
                    items_1.Add(optb1.Text);
                    items_1.Add(optc1.Text);
                    Properties.Settings.Default.item1 = items_1;
                    Properties.Settings.Default.Save();

                    StringCollection items_2 = new StringCollection();
                    items_2.Add(question2.Text);
                    items_2.Add(opta2.Text);
                    items_2.Add(optb2.Text);
                    items_2.Add(optc2.Text);
                    Properties.Settings.Default.item2 = items_2;
                    Properties.Settings.Default.Save();

                    StringCollection items_3 = new StringCollection();
                    items_3.Add(question3.Text);
                    items_3.Add(opta3.Text);
                    items_3.Add(optb3.Text);
                    items_3.Add(optc3.Text);
                    Properties.Settings.Default.item3 = items_3;
                    Properties.Settings.Default.Save();

                    StringCollection items_4 = new StringCollection();
                    items_4.Add(question4.Text);
                    items_4.Add(opta4.Text);
                    items_4.Add(optb4.Text);
                    items_4.Add(optc4.Text);
                    Properties.Settings.Default.item4 = items_4;
                    Properties.Settings.Default.Save();

                    StringCollection items_5 = new StringCollection();
                    items_5.Add(question5.Text);
                    items_5.Add(opta5.Text);
                    items_5.Add(optb5.Text);
                    items_5.Add(optc5.Text);
                    Properties.Settings.Default.item5 = items_5;
                    Properties.Settings.Default.Save();

                    StringCollection items_6 = new StringCollection();
                    items_6.Add(question6.Text);
                    items_6.Add(opta6.Text);
                    items_6.Add(optb6.Text);
                    items_6.Add(optc6.Text);
                    Properties.Settings.Default.item6 = items_6;
                    Properties.Settings.Default.Save();

                    StringCollection items_7 = new StringCollection();
                    items_7.Add(question7.Text);
                    items_7.Add(opta7.Text);
                    items_7.Add(optb7.Text);
                    items_7.Add(optc7.Text);
                    Properties.Settings.Default.item7 = items_7;
                    Properties.Settings.Default.Save();

                    StringCollection items_8 = new StringCollection();
                    items_8.Add(question8.Text);
                    items_8.Add(opta8.Text);
                    items_8.Add(optb8.Text);
                    items_8.Add(optc8.Text);
                    Properties.Settings.Default.item8 = items_8;
                    Properties.Settings.Default.Save();

                    StringCollection items_9 = new StringCollection();
                    items_9.Add(question9.Text);
                    items_9.Add(opta9.Text);
                    items_9.Add(optb9.Text);
                    items_9.Add(optc9.Text);
                    Properties.Settings.Default.item9 = items_9;
                    Properties.Settings.Default.Save();

                    StringCollection items_10 = new StringCollection();
                    items_10.Add(question10.Text);
                    items_10.Add(opta10.Text);
                    items_10.Add(optb10.Text);
                    items_10.Add(optc10.Text);
                    Properties.Settings.Default.item10 = items_10;

                    Properties.Settings.Default.questionno = questionno.Text;
                    Properties.Settings.Default.gradelevel = comboBox5.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Questions are successfully created.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error, contact service provider.", "Not Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? \nDo you want to cancel creating question?", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}

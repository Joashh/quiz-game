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
    public partial class TEACHER : Form
    {
        public TEACHER()
        {
            InitializeComponent();
        }
        string grade;
        //Change this if transferring to another PC :)
        SqlConnection con = new SqlConnection(Class1.conReturn());
        private void TEACHER_Load(object sender, EventArgs e)
        {
            verifpanel.Hide();
            panel2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            STARTUP una = new STARTUP();
            una.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            
            verifpanel.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void grade1_Click(object sender, EventArgs e)
        {
            //This will be change this po when transferring to another PC :)
            con.Open();
            grade = "1";
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[registration] ([firstname],[middlename],[lastname],[birthday],[email],[contact],[type],[username],[password],[gradelevel],[securityquestion],[answer])VALUES('" + name.Text + "','" + midname.Text + "','" + lastname.Text + "','" + birthday.Text + "','" + email.Text + "','" + contact.Text + "','" + type.Text + "','" + username.Text + "','" + password.Text + "','" + grade + "','" + comboBox1.Text + "', '" + answer.Text + "')", con);
            if (MessageBox.Show("Are you sure you want to select it?", "Please Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                STARTUP una = new STARTUP();
                una.Show();
            }
            con.Close();
        }

        private void grade2_Click(object sender, EventArgs e)
        {
            //This will be change this po when transferring to another PC :)
            con.Open();
            grade = "2";

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[registration] ([firstname],[middlename],[lastname],[birthday],[email],[contact],[type],[username],[password],[gradelevel],[securityquestion],[answer])VALUES('" + name.Text + "','" + midname.Text + "','" + lastname.Text + "','" + birthday.Text + "','" + email.Text + "','" + contact.Text + "','" + type.Text + "','" + username.Text + "','" + password.Text + "','" + grade + "','" + comboBox1.Text + "', '" + answer.Text + "')", con);
            if (MessageBox.Show("Are you sure you want to select it?", "Please Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                STARTUP una = new STARTUP();
                una.Show();
            }
            con.Close();
        }

        private void grade3_Click(object sender, EventArgs e)
        {
            //This will be change this po when transferring to another PC :)
            con.Open();
            grade = "3";
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[registration] ([firstname],[middlename],[lastname],[birthday],[email],[contact],[type],[username],[password],[gradelevel],[securityquestion],[answer])VALUES('" + name.Text + "','" + midname.Text + "','" + lastname.Text + "','" + birthday.Text + "','" + email.Text + "','" + contact.Text + "','" + type.Text + "','" + username.Text + "','" + password.Text + "','" + grade + "','" + comboBox1.Text + "', '" + answer.Text + "')", con);
            if (MessageBox.Show("Are you sure you want to select it?", "Please Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                STARTUP una = new STARTUP();
                una.Show();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && answer.Text != "")
            {
                panel2.Show();
            }
            else
            {
                MessageBox.Show("Please choose proper question and answer it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                label9.Hide();
            }
            else if (name.Text == "")
            {
                checkBox1.Checked = false;
                label9.Show();
                signup.Enabled = false;
            }

            
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (lastname.Text != "")
            {
                label3.Hide();
            }
            else if (lastname.Text == "")
            {
                checkBox1.Checked = false;
                label3.Show();
                signup.Enabled = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                label5.Hide();
            }
            else if (email.Text == "")
            {
                checkBox1.Checked = false;
                label5.Show();
                signup.Enabled = false;
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            if (contact.Text != "")
            {
                label6.Hide();
            }
            else if (contact.Text == "")
            {
                checkBox1.Checked = false;
                label6.Show();
                signup.Enabled = false;
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text != "")
            {
                label8.Hide();
            }
            else if (contact.Text == "")
            {
                checkBox1.Checked = false;
                label8.Show();
                signup.Enabled = false;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text != "")
            {
                label10.Hide();
            }
            else if (username.Text == "")
            {
                checkBox1.Checked = false;
                label10.Show();
                signup.Enabled = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != "")
            {
                label11.Hide();
            }
            else if (password.Text == "")
            {
                checkBox1.Checked = false;
                label11.Show();
                signup.Enabled = false;
            }
            
        }

        private void signup_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label12.Hide();
                if(label9.Visible == false && label3.Visible == false && label5.Visible == false && label6.Visible == false && label8.Visible == false && label10.Visible == false && label11.Visible == false && checkBox1.Checked == true)
                    {
                        signup.Enabled = true;
                    }
                
            }else
            {
                label12.Show();
                signup.Enabled = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            midname.Text = "";
            lastname.Text = "";
            email.Text = "";
            type.Text = "";
            contact.Text = "";
            username.Text = "";
            password.Text = "";
        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        
        
    
    
        
        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Type your username....")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
            
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            { 
                username.Text = "Type your username....";
            username.ForeColor = Color.Gray;
            }
            else
            {
                username.ForeColor = Color.Black;
            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Type your password...")
                password.Text = "";
            password.UseSystemPasswordChar = true;
            password.ForeColor = Color.Black;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.UseSystemPasswordChar = false;
                password.Text = "Type your password...";
                password.ForeColor = Color.Gray;
            }
            else
            {
            password.UseSystemPasswordChar = true;
            password.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            STARTUP una = new STARTUP();
            una.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TEACHER reg = new TEACHER();
            reg.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This system was created as a fulfillment for final thesis project of students pursuing Bachelor Science in Computer Science. \nAll the concepts, ideas, and structure of this program are open for future developments and improving. \n \nThis system is limited ideally formed by the ideas of the non-professional students. \nAll the efforts and concept of this program was created with love, blood, and sacrifices. \n \nPlease enjoy the system as it is.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
           
            if ("admin" == username.Text && "admin" == password.Text)
            {
                admin admin = new admin();
                admin.Show();
                this.Close();
            }
            else if(username.Text == "admincon" && password.Text == "admincon")
            {
                Form3 conection = new Form3();
                conection.Show();
            }
            else
            {
                credits secret = new credits();
                try
                {
                    SqlConnection con = new SqlConnection(Class1.conReturn());
                    con.Open();
                    if (username.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("Select type from registration where username=@username", con);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.ExecuteNonQuery();
                        var da = cmd.ExecuteScalar();

                        string tanong = "SELECT * FROM REGISTRATION WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            homepageforteacher form2 = new homepageforteacher(this); //need this
                            form2.Show();
                            this.Close();

                        }

                        else
                        {
                            MessageBox.Show("Invalid Input", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            password.Clear();
                            username.Clear();
                            username.Focus();
                        }
                        con.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            
            }
            
        }

        public String usernamevalue
        {
            get
            {
                return this.username.Text;
            }
              
        }

        private void Login_Load(object sender, EventArgs e)
        {
            codepass1.Text = "ENTER NEW PASSWORD";
            codepass1.ForeColor = Color.BlueViolet;
            
            codepass2.Text = "CONFIRM NEW PASSWORD";
            codepass2.ForeColor = Color.BlueViolet;
            codepass1.UseSystemPasswordChar = false;
            codepass2.UseSystemPasswordChar = false;

            textBox3.Text = "ENTER NEW PASSWORD";
            textBox3.ForeColor = Color.BlueViolet;

            textBox4.Text = "CONFIRM NEW PASSWORD";
            textBox4.ForeColor = Color.BlueViolet;
            textBox3.UseSystemPasswordChar = false;
            textBox4.UseSystemPasswordChar = false;
            panel5.Hide();
            codechangepass.Hide();
            this.AcceptButton = signup;
            panel3.Hide();
            panel2.Hide();
            panel4.Hide();
            if (Properties.Settings.Default.strDataSource == @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + System.IO.Path.GetFullPath("Finaldb.mdf") + "; Integrated Security = True; Connect Timeout = 30")
            {
                label2.Text = "Status: You are connected in Local Database (Single Use)";
            }
            else if (Properties.Settings.Default.strDataSource == null)
            {
                label2.Text = "Status: There is no connection established. Go to admin settings";
            }
            else
            {
                label2.Text = "Status: You are connected in Local Area Network (MultiUser Use)";
            }
            
        }
        string id;
        private void grade1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();
            string tanong = "SELECT * FROM REGISTRATION WHERE contact = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                id = textBox1.Text;
               
                SqlCommand cmd = new SqlCommand("Select securityquestion from registration where contact=@contact", con);
                cmd.Parameters.AddWithValue("@contact", textBox1.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    label11.Text = da.GetValue(0).ToString().ToUpper();
                    
                }
                panel3.Show();

            }
            else
            {
                MessageBox.Show("Could not find your account", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();


                textBox1.Focus();
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uwu.HideSync(panel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uwu.HideSync(panel3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            string tanong = "SELECT * FROM registration WHERE answer = '" + textBox2.Text + "' AND contact = '" + id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {

                uwu.ShowSync(panel4);


            }
            else
            {
                MessageBox.Show("Wrong answer!", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();


                textBox1.Focus();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text == textBox4.Text)
            {
                button10.Enabled = true;
            }
            else
            {
                button10.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                button10.Enabled = true;
            }else
            {
                button10.Enabled = false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();
            SqlCommand cmd = new SqlCommand("update registration set password = '" + textBox3.Text + "' where contact = '" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            if (MessageBox.Show("Your password was updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                uwu.HideSync(panel4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uwu.ShowSync(panel2);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void verifycode_Click(object sender, EventArgs e)
        {
           
            if (textboxcode.Text == Properties.Settings.Default.generatedcodeuser)
            {
                codechangepass.Show();
            }
            else
            {
                MessageBox.Show("Temporary code invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            codechangepass.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("update registration set password = '" + codepass1.Text + "' where contact = '" + Properties.Settings.Default.tempid + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            if (MessageBox.Show("Your password was updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Properties.Settings.Default.generatedcodeuser = "";
                Properties.Settings.Default.tempid = "";
                try
                {
                    uwu.HideSync(panel5);
                }
                catch
                {
                    panel5.Hide();
                }
            }
        }

        private void codepass2_TextChanged(object sender, EventArgs e)
        {
            if (codepass1.Text == codepass2.Text)
            {
                button13.Enabled = true;
            }
            else
            {
                button13.Enabled = false;
            }
        }

        private void balik1()
        {
            codepass1.Text = "ENTER NEW PASSWORD";
            codepass1.ForeColor = Color.BlueViolet;
            codepass2.Text = "CONFIRM NEW PASSWORD";
            codepass2.ForeColor = Color.BlueViolet;
            codepass1.UseSystemPasswordChar = false;
            codepass2.UseSystemPasswordChar = false;
        }
        private void balik2()
        {
            codepass2.Text = "CONFIRM NEW PASSWORD";
            codepass2.ForeColor = Color.BlueViolet;
           
            codepass2.UseSystemPasswordChar = false;
        }

        private void txtbx4()
        {
            textBox4.Text = "CONFIRM NEW PASSWORD";
            textBox4.ForeColor = Color.BlueViolet;

            textBox4.UseSystemPasswordChar = false;
        }

        private void txtbx3()
        {
            textBox3.Text = "CONFIRM NEW PASSWORD";
            textBox3.ForeColor = Color.BlueViolet;

            textBox3.UseSystemPasswordChar = false;
        }
        private void codepass1_Enter(object sender, EventArgs e)
        {
            codepass1.UseSystemPasswordChar = true;
            codepass1.Text = "";
            codepass1.ForeColor = Color.White;
        }

        private void codepass2_Enter(object sender, EventArgs e)
        {
            codepass2.UseSystemPasswordChar = true;
            codepass2.Text = "";
            codepass2.ForeColor = Color.White;
        }

        private void codepass2_Leave(object sender, EventArgs e)
        {
            if (codepass1.Text == "")
            {
                balik2();
            }
        }

        private void codepass1_Leave(object sender, EventArgs e)
        {
            if(codepass2.Text == "")
            balik1();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            textBox3.Text = "";
            textBox3.ForeColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;
            textBox4.Text = "";
            textBox4.ForeColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                txtbx3();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                txtbx4();
        }
    }
}

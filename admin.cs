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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        int type;
        SqlConnection con = new SqlConnection(Class1.conReturn());
        private void admin_Load(object sender, EventArgs e)
        {
            modifyadminkeypanel.Hide();
            label19.Hide();
            button8.Hide();
            credits secret = new credits();
            panel10.Hide();
            label17.Hide();
            panel11.Hide();
            BindData();
            BindDatagrade1();
            BindDatagrade2();
            BindDatagrade3();
            button4.Hide();

            connection.Text = Properties.Settings.Default.strDataSource;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            credits secret = new credits();
            modifyadminkeypanel.Show();
            button4.Show();
            

        }

        
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select firstname, middlename, lastname, birthday, email, contact, type, gradelevel from registration", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void BindDatagrade1()
        {
            SqlCommand cmd = new SqlCommand("select * from grade1record", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
             sd.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        void BindDatagrade2()
        {
            SqlCommand cmd = new SqlCommand("select * from grade2record", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView3.DataSource = dt;

        }
        void BindDatagrade3()
        {
            SqlCommand cmd = new SqlCommand("select * from grade3record", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView4.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login balik = new Login();
            balik.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            credits secret = new credits();
           
            modifyadminkeypanel.Hide();
            button4.Hide();
            
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text == "Type your username....")
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
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Type your password...")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {

            if (password.Text == "")
            {
                password.Text = "Type your password...";
                password.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strDataSource = connection.Text;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int uplvl = 1;
        public string generatedcode;
        private void verification(int level)
        {
            switch(level)
            {
                case 1:
                label16.Text = "ENTER THE ID NUMBER OF USER";
                    label17.Text = "DO NOT SUBMIT EMPTY NUMBER ID INPUT !";
                    veriftextbox.ForeColor = Color.White;
                    break;
                case 2:
                    veriftextbox.Text = "";
                    veriftextbox.ForeColor = Color.White;
                    label17.Hide();
                    label16.Text = "PLEASE ENTER THE USERNAME OF THE USER";
                    label17.Text = "DO NOT SUBMIT EMPTY USERNAME !";
                    break;
                case 3:
                    code.ForeColor = Color.White;
                    panel11.Show();
                    break;
            }
        }
        private static Random random = new Random();
        string contactid;
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void verifbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (uplvl == 1)
                {
                    if (veriftextbox.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select contact from registration where contact=@contact", con);
                        cmd.Parameters.AddWithValue("@contact", veriftextbox.Text);
                        cmd.ExecuteNonQuery();
                        var da = cmd.ExecuteScalar();
                        string tanong = "SELECT * FROM registration WHERE contact = '" + veriftextbox.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        if (dtable.Rows.Count > 0)
                        {
                            contactid = da.ToString();
                            uplvl++;
                            verification(uplvl);
                          
                        }
                        else
                        {
                            MessageBox.Show("Your ID is incorrect", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            veriftextbox.Text = "";
                        }
                        con.Close();
                    }
                    else
                    {
                        label17.Show();
                    }
                }
                else if (uplvl == 2)
                {
                    if (veriftextbox.Text != "")
                    {
                        con.Open();
                        /*SqlCommand cmd = new SqlCommand("Select username from registration where contact=@contact", con);
                        cmd.Parameters.AddWithValue("@contact", contactid);
                        cmd.ExecuteNonQuery();
                        var da = cmd.ExecuteScalar();
                        */
                        string tanong = "SELECT username FROM registration WHERE contact = '" + contactid + "' AND username = '"+ veriftextbox.Text +"'";

                        SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        if (dtable.Rows.Count > 0)
                        {

                            uplvl++;
                            verification(uplvl);
                        }
                        else
                        {
                            MessageBox.Show("Username does not match any records or incorrect", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            veriftextbox.Text = "";
                        }
                        con.Close();
                    }
                    else
                    {
                        label17.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("System Password Recovery is not available at the moment. \nPlease try again later.", "There was a problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void veriftextbox_Enter(object sender, EventArgs e)
        {
            label17.Hide();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            generate.Enabled = false;
            
            code.Text = RandomString(10);
            Clipboard.SetText(code.Text);
            try
            {
                bunifuTransition1.ShowSync(label19);
                bunifuTransition1.ShowSync(button8);
            }
            catch
            {
                label19.Show();
                button8.Show();
            }
            Properties.Settings.Default.generatedcodeuser = code.Text;
            Properties.Settings.Default.tempid = contactid;
            Properties.Settings.Default.Save();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel10.Hide();
        }
        Point lastPoint;
        private void admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

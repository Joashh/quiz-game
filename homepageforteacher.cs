using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZXing;
using System.IO;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode.Internal;
using ZXing.QrCode;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Math_School
{
    public partial class homepageforteacher : Form
    {
        Login frm1;
        public homepageforteacher(Login fr1)
        {
            InitializeComponent();
            this.frm1 = fr1;
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            
        }
        string input = string.Empty;

        int logic;
        int mathematicskill;
        int analyticalskill;
        int masteryinnumbers;

        SqlConnection con = new SqlConnection(Class1.conReturn());
        private void homepageforteacher_Load(object sender, EventArgs e)
        {
            
            panel5.Hide();
            optionpanel.Hide();
            evalpanel.Hide();
            createcodepanel.Hide();
            label62.Hide();
            previewprint.Hide();
            panel14.Hide();
            panel13.Hide();
            panel5.Hide();
            seefullpanel.Hide();
            grade3a.Hide();
            grade3b.Hide();
            grade2a.Hide();
            grade2b.Hide();
            grade2c.Hide();
            grade1a.Hide();
            grade1b.Hide();
            grade1c.Hide();
            SqlCommand ccmd = new SqlCommand("SELECT gradelevel from registration", con);
            con.Open();
            SqlDataReader gradelevel = ccmd.ExecuteReader();
            while (gradelevel.Read())
            {

                time.Text = "Grade " + gradelevel.GetString(0);
            }
            con.Close();

            toggle.Value = Properties.Settings.Default.toggle;
            optionpanel.Hide();
            timer1.Start();
            evalpanel.Hide();
            label2.Text = DateTime.Now.ToLongDateString();
            name.Text = frm1.usernamevalue;
            createcodepanel.Hide();
            


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();

            if (name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select firstname from REGISTRATION where username=@username", con);
                cmd.Parameters.AddWithValue("@username", name.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    name.Text = da.GetValue(0).ToString().ToUpper();

                }
                con.Close();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "8";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "1";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "2";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "3";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "4";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "5";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "6";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "7";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label19.Hide();
            codes.Text = "";

            this.codes.Text = "";
            input += "9";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label19.Hide();
            this.codes.Text = "";
            input += "0";
            this.codes.Text += input;
            if (codes.TextLength == 4)
            {
                button8.Enabled = false;
                button18.Enabled = false;
                button12.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button11.Enabled = false;
                button7.Enabled = false;


            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            label19.Show();
            input = "";
            button8.Enabled = true;
            button18.Enabled = true;
            button12.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button11.Enabled = true;
            button7.Enabled = true;

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private async void error()
        {
            label62.Show();
            await Task.Delay(5000);
            label62.Hide();
        }
        private void createcode_Click(object sender, EventArgs e)
        {
            if (codestudentname.Text == null)
            {
                error();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[createcode]([code],[studentname],[gradelevel],[sex]) VALUES ('" + codes.Text + "','" + codestudentname.Text + "','" + codegradelevel.Text + "','" + codesex.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                codecreated eto = new codecreated();
                eto.Show();
                
            }
        }

        private void generateqr_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[createcode]([code],[studentname],[gradelevel],[sex]) VALUES ('" + codes.Text + "','" + codestudentname.Text + "','" + codegradelevel.Text + "','" + codesex.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            BarcodeWriter bwriter = new BarcodeWriter();
            EncodingOptions encodingopt = new EncodingOptions() { Width = 3000, Height = 3000, Margin = 0, PureBarcode = false };
            encodingopt.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            bwriter.Renderer = new BitmapRenderer();
            string qrdata = codes.Text + "\n" + codestudentname.Text + "\n" + codegradelevel.Text + "\n" + codesex.Text + "\n";
            bwriter.Options = encodingopt;
            bwriter.Format = BarcodeFormat.QR_CODE;

            Bitmap bitmap = bwriter.Write(qrdata);
            Bitmap logo = new Bitmap($"{Application.StartupPath}/kk-removebg-preview.png");

            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));

            QRcode pic = new QRcode();
            pic.pictureBox1.Image = bitmap;

            pic.Show();



            /*string qrdata = codes.Text + "\n" + codestudentname.Text + "\n" + codegradelevel.Text + "\n" + codesex.Text + "\n";
            string qrfilename = codes.Text;

            if (string.IsNullOrEmpty(qrdata) || string.IsNullOrEmpty(qrfilename))
            {
                MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(Class1.conFile() + qrfilename + ".png"))
            {
                MessageBox.Show("File name exists! Cannot Duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BarcodeWriter barcodewriter = new BarcodeWriter();
            barcodewriter.Format = BarcodeFormat.QR_CODE;
            
            
            
            barcodewriter.Write(qrdata).Save(Class1.conFile() + qrfilename + ".png");
            
            pic.pictureBox1.Image = Image.FromFile(Class1.conFile() + qrfilename + ".png");
            */


        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            optionpanel.Hide();
            evalpanel.Hide();
            codegradelevel.Text = time.Text;
            
            createcodepanel.BringToFront();
            createcodepanel.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previewprint.Hide();
            panel5.Hide();
            optionpanel.Hide();
            evalpanel.Hide();
            createcodepanel.Hide();
           
            
            
        }

        private void homepageforteacher_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint;
        private void homepageforteacher_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            
            if (time.Text == "Grade 1")
            {
                con.Open();
                SqlCommand cmdsuggest = new SqlCommand("SELECT Name from grade1record", con);
                SqlDataReader suggestreader = cmdsuggest.ExecuteReader();
                AutoCompleteStringCollection Mycollection = new AutoCompleteStringCollection();
                while (suggestreader.Read())
                {
                    Mycollection.Add(suggestreader.GetString(0));
                }
                textBox1.AutoCompleteCustomSource = Mycollection;
                con.Close();
            }
            else if (time.Text == "Grade 2")
            {
                con.Open();
                SqlCommand cmdsuggest = new SqlCommand("SELECT Name from grade2record", con);
                SqlDataReader suggestreader = cmdsuggest.ExecuteReader();
                AutoCompleteStringCollection Mycollection = new AutoCompleteStringCollection();
                while (suggestreader.Read())
                {
                    Mycollection.Add(suggestreader.GetString(0));
                }
                textBox1.AutoCompleteCustomSource = Mycollection;
                con.Close();
            }
            else if (time.Text == "Grade 3")
            {
                SqlCommand cmdsuggest = new SqlCommand("SELECT Name from grade3record", con);
                con.Open();
                SqlDataReader suggestreader = cmdsuggest.ExecuteReader();
                AutoCompleteStringCollection Mycollection = new AutoCompleteStringCollection();
                while (suggestreader.Read())
                {
                    Mycollection.Add(suggestreader.GetString(0));
                }
                textBox1.AutoCompleteCustomSource = Mycollection;
                con.Close();
            }
            optionpanel.Hide();
            
            createcodepanel.Hide();
            evalpanel.Show();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();

                Login log = new Login();
                log.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Hide();

            evalpanel.Hide();
            createcodepanel.Hide();
            optionpanel.Show();
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (time.Text == "Grade 1")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select  logic, mathematicalskill, analyticalskill, masteryinnumber, Name from grade1record where Name= '" + textBox1.Text + "'", con);
                        SqlDataReader da = cmd.ExecuteReader();

                        while (da.Read())
                        {

                            logic = Convert.ToInt32(da.GetValue(0));
                            mathematicskill = Convert.ToInt32(da.GetValue(1));
                            analyticalskill = Convert.ToInt32(da.GetValue(2));
                            masteryinnumbers = Convert.ToInt32(da.GetValue(3));
                            label12.Text = da.GetValue(4).ToString();

                        }
                        con.Close();

                        if (logic >= 68) //old 25 //total new 91
                        {
                            label20.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 91) + "%";
                            label125.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 91) + "%";
                        }
                        else
                        {
                            label20.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 91) + "%";
                            label125.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 91) + "%";
                        }
                        if (mathematicskill >= 38) //old 9 //total new 50
                        {
                            label21.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 50) + "%";
                            label127.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 50) + "%";
                        }
                        else
                        {
                            label21.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 50) + "%";
                            label127.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 50) + "%";
                        }
                        if (analyticalskill >= 68) //old 22 //total new 91
                        {
                            label22.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 91) + "%";
                            label126.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 91) + "%";

                        }
                        else
                        {
                            label22.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 91) + "%";
                            label126.Text = "GOOD " + (int)Math.Round((double)(analyticalskill * 100) / 91) + "%";

                        }
                        if (masteryinnumbers >= 47) //old 15 //new 62
                        {
                            label23.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 62) + "%";
                            label123.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 62) + "%";
                        }
                        else
                        {
                            label23.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 62) + "%";
                            label123.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 62) + "%";
                        }
                    }
                    catch
                    {
                        con.Close();
                        MessageBox.Show("E-Guess record cannot be found, it was deleted or corrupt. \nPlease re-login to proceed.", "E-Guess Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (time.Text == "Grade 2")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select  logic, mathematicskill, analyticalskill, masterynumber, name from grade2record where Name= '" + textBox1.Text + "'", con);
                        SqlDataReader da = cmd.ExecuteReader();

                        while (da.Read())
                        {

                            logic = Convert.ToInt32(da.GetValue(0));
                            mathematicskill = Convert.ToInt32(da.GetValue(1));
                            analyticalskill = Convert.ToInt32(da.GetValue(2));
                            masteryinnumbers = Convert.ToInt32(da.GetValue(3));
                            label12.Text = da.GetValue(4).ToString();
                        }
                        con.Close();

                        if (logic >= 188) //+35
                        {
                            label20.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 250) + "%";
                            label125.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 250) + "%";
                        }
                        else
                        {
                            label20.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 250) + "%";
                            label125.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 250) + "%";
                        }
                        if (mathematicskill >= 193) //+39
                        {
                            label21.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 257) + "%";
                            label127.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 257) + "%";
                        }
                        else
                        {
                            label21.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 257) + "%";
                            label127.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 257) + "%";
                        }
                        if (analyticalskill >= 109) //+39
                        {
                            label22.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 257) + "%";
                            label126.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 257) + "%";

                        }
                        else
                        {
                            label22.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 257) + "%";
                            label126.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 257) + "%";
                        }
                        if (masteryinnumbers >= 185)//+34
                        {
                            label23.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 247) + "%";
                            label123.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 247) + "%";
                        }
                        else
                        {
                            label23.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 213) + "%";
                            label123.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 247) + "%";
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("Record can't retrieve. Either saving process is failed or interrupted.", "E-Guess", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else if (time.Text == "Grade 3")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select  logic, mathematicskill, analyticalskill, masterynumber, name from grade3record where Name= '" + textBox1.Text + "'", con);
                        SqlDataReader da = cmd.ExecuteReader();

                        while (da.Read())
                        {

                            logic = Convert.ToInt32(da.GetValue(0));
                            mathematicskill = Convert.ToInt32(da.GetValue(1));
                            analyticalskill = Convert.ToInt32(da.GetValue(2));
                            masteryinnumbers = Convert.ToInt32(da.GetValue(3));
                            label12.Text = da.GetValue(4).ToString();
                        }
                        con.Close();

                        if (logic >= 29) //+16
                        {
                            label20.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 38) + "%";
                            label125.Text = "EXCELLENT " + (int)Math.Round((double)(logic * 100) / 38) + "%";
                        }
                        else
                        {
                            label20.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 38) + "%";
                            label125.Text = "GOOD " + (int)Math.Round((double)(logic * 100) / 38) + "%";
                        }
                        if (mathematicskill >= 31) //+21
                        {
                            label21.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 41) + "%";
                            label127.Text = "EXCELLENT " + (int)Math.Round((double)(mathematicskill * 100) / 41) + "%";
                        }
                        else
                        {
                            label21.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 41) + "%";
                            label127.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 41) + "%";
                        }
                        if (analyticalskill >= 13) //+21
                        {
                            label22.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 26) + "%";
                            label126.Text = "EXCELLENT " + (int)Math.Round((double)(analyticalskill * 100) / 26) + "%";
                        }
                        else
                        {
                            label22.Text = "GOOD " + (int)Math.Round((double)(mathematicskill * 100) / 26) + "%";
                            label126.Text = "GOOD " + (int)Math.Round((double)(analyticalskill * 100) / 26) + "%";
                        }
                        if (masteryinnumbers >= 24) //+16
                        {
                            label23.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 32) + "%";
                            label123.Text = "EXCELLENT " + (int)Math.Round((double)(masteryinnumbers * 100) / 32) + "%";
                        }
                        else
                        {
                            label23.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 16) + "%";
                            label123.Text = "GOOD " + (int)Math.Round((double)(masteryinnumbers * 100) / 32) + "%";
                        }
                    }
                    catch
                    {
                        con.Close();
                        MessageBox.Show("Record can't retrieve. Either saving process is failed or interrupted.", "E-Guess", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Record can't retrieve. Either saving process is failed or interrupted.", "E-Guess", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        private void codes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void codes_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void codes_Leave(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            credits cre = new credits();
            cre.Show();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label28.Text = label12.Text;
            studentgrade.Text = time.Text;

            if (!seefullpanel.Visible)
            {
                seefullpanel.Show();
            }
            else if(seefullpanel.Visible)
            {
                seefullpanel.Hide();
            }


            if (time.Text == "Grade 1")
                {
                grade1a.Show();
                grade1b.Show();
                grade1c.Show();

                grade3a.Hide();
                grade3b.Hide();

                grade2a.Hide();
                grade2b.Hide();
                grade2c.Hide();
                con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT category1, category2, category3, category4, secondcateg1, secondcateg2, secondcateg3, thirdtotal from grade1record where Name=@name", con);
                    cmd.Parameters.AddWithValue("@name", label12.Text);
                    SqlDataReader da = cmd.ExecuteReader();

                    while(da.Read())
                    {
                        basicmath.Text = da.GetString(0).ToString();
                        count.Text = da.GetValue(1).ToString();
                        wordprob.Text = da.GetValue(2).ToString();
                        identific.Text = da.GetValue(3).ToString();
                        interm.Text = da.GetValue(4).ToString();
                        problemsolv.Text = da.GetValue(5).ToString();
                        patte.Text = da.GetValue(6).ToString();
                        label49.Text = da.GetValue(7).ToString();
                    }
                con.Close();
            }
            else if (time.Text == "Grade 2")
            {
                grade2a.Show();
                grade2b.Show();
                grade2c.Show();

                grade3a.Hide();
                grade3b.Hide();

                grade1a.Hide();
                grade1b.Hide();
                grade1c.Hide();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT category1, category2, categor3, secondcategory1, thirdscore, name from grade2record where name=@name", con);
                cmd.Parameters.AddWithValue("@name", label12.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    probsolv.Text = da.GetValue(0).ToString();
                    placevalue.Text = da.GetValue(1).ToString();
                    rounding.Text = da.GetValue(1).ToString();
                    fraction.Text = da.GetValue(2).ToString();
                    sequencegame.Text = da.GetValue(3).ToString();
                    ordering.Text = da.GetValue(4).ToString();
                    ordering1.Text = da.GetValue(4).ToString();
                    label28.Text = da.GetValue(5).ToString();
                }
                con.Close();
            }
            else if (time.Text == "Grade 3")
            {
                grade3a.Show();
                grade3b.Show();

                grade1a.Hide();
                grade1b.Hide();
                grade1c.Hide();
                grade2a.Hide();
                grade2b.Hide();
                grade2c.Hide();



                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT score1, score2, score3, secondscore, puzzlethird, name from grade3record where name=@name", con);
                cmd.Parameters.AddWithValue("@name", label12.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    Perim.Text = da.GetValue(0).ToString();
                    timseefull.Text = da.GetValue(1).ToString();
                    identification2.Text = da.GetValue(2).ToString();
                    label43.Text = da.GetValue(4).ToString();
                    label63.Text = da.GetValue(3).ToString();
                    label28.Text = da.GetValue(5).ToString();

                }
                con.Close();
            }



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            if(label12.Text != "")
            {
                button16.Enabled = true;
            }
            else
            {
                button16.Enabled = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel5.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel13.Hide();
            optionpanel.Hide();
            panel14.Hide();
            evalpanel.Hide();
            createcodepanel.Hide();
             panel5.Show();
            
            panel5.BringToFront();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            panel5.Hide();
            optionpanel.Hide();
            evalpanel.Hide();
            panel14.Hide();
            createcodepanel.Hide();
            panel13.Show();
            
            panel13.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel13.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            optionpanel.Hide();
            panel14.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pic1.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pic2.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pic3.BringToFront();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel14.Hide();
            optionpanel.Show();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {

        }

        private void homepageforteacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.toggle = toggle.Value;
            Properties.Settings.Default.Save();
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            CreateQuestions quest = new CreateQuestions();
            quest.Show();
        }

        private void grade2a_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grade3a_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            seefullpanel.Hide();
        }

        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        
        

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 1000, 567);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, 0,0);
            
        }
        public void Print(Panel pnl)
        {
            previewprint = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }
        private void printme_Click(object sender, EventArgs e)
        {
            previewprint.Hide();
            label114.Text = label12.Text;
            label115.Text = time.Text;
            label113.Text = Perim.Text;
            label111.Text = timseefull.Text;
            label108.Text = identification2.Text;
            label106.Text = label43.Text;
            label88.Text = probsolv.Text;
            label86.Text = placevalue.Text;
            label83.Text = rounding.Text;
            label81.Text = fraction.Text;
            label104.Text = basicmath.Text;
            label102.Text = count.Text;
            label99.Text = wordprob.Text;
            label97.Text = identific.Text;
            label70.Text = label63.Text;
            label76.Text = sequencegame.Text;
            label73.Text = ordering.Text;
            label95.Text = interm.Text;
            label67.Text = label49.Text;
            label79.Text = ordering1.Text;
                label92.Text = problemsolv.Text;
                label90.Text = patte.Text;
            uno1.Hide();
            uno2.Hide();
            uno3.Hide();

            dos1.Hide();
            dos2.Hide();
            dos3.Hide();

            tres1.Hide();
            tres2.Hide();
            if (time.Text == "Grade 1")
            {
                uno1.Show();
                uno2.Show();
                uno3.Show();
            }
            else if (time.Text == "Grade 2")
            {
                dos1.Show();
                dos2.Show();
                dos3.Show();
            }
            else if (time.Text == "Grade 3")
            {
                tres1.Show();
                tres2.Show();
                
            }

            if (MessageBox.Show("Are you sure you want to print this?", "E-Guess Print Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                printdoc1.DefaultPageSettings.Landscape = true;
                Print(this.previewprint);
            }
            else
            {

            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void dos3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = " Type the student name here...";
                textBox1.ForeColor = Color.Yellow;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

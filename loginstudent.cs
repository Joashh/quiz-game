using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Math_School
{
    public partial class loginstudent : Form
    {
        //indicator of gradelevel

        
        public loginstudent()
        {
            InitializeComponent();
            scannerpicturebox.Controls.Add(scanning);
            scanning.Location = new Point(0, 0);
            scanning.BackColor = Color.Transparent;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        void stop()
        {
            captureDevice.SignalToStop();
            captureDevice.NewFrame -= new NewFrameEventHandler(CaptureDevice_NewFrame);
            captureDevice = null;


        }
        private void code_Enter(object sender, EventArgs e)
        {
            if(code.Text == "TYPE THE ROOM CODE HERE")
            {
                code.Text = "";
                code.ForeColor = Color.CornflowerBlue;
            }
        }

        private void code_Leave(object sender, EventArgs e)
        {
            if(code.Text == "")
            {
                code.Text = "TYPE THE ROOM CODE HERE";
                code.ForeColor = Color.Gray;
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            STARTUP una = new STARTUP();
            una.Show();

            Thread.Sleep(1000);
            if(captureDevice != null)
            {
                if(captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void loginstudent_Load(object sender, EventArgs e)
        {
            label9.Hide();
            label8.Hide();
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cameras.Items.Add(filterInfo.Name);
                cameras.SelectedIndex = 0;
            }
            catch 
            {
                MessageBox.Show("You cannot use the QR Scanner process due to camera problem. \nThe system cannot detect any available cameras within this device. \n \nPlease contact the developer of this project to solve this problem. Thank you.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            scanning.Hide();
            qrcodescannerpanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrcodescannerpanel.Show();
        }

        private void qrcodescannerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            scanning.Show();
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cameras.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            scannerpicturebox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void loginstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scannerpicturebox.Image != null)
            {

                BarcodeReader barcodereader = new BarcodeReader();
                Result result = barcodereader.Decode((Bitmap)scannerpicturebox.Image);
                
                if (result != null)
                {
                    scanning.Hide();
                    var resultdatarray = result.Text.Split(new char[] { '\n' });
                    decoded.Text = resultdatarray[0].ToString();
                   
                    button5.Enabled = true;
                    
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        stop();
                    Thread.Sleep(1000);
                }


                



            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            qrcodescannerpanel.Hide();
            Thread.Sleep(1000);
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class1.conReturn());
            con.Open();
            if (decoded.Text != "0000" || decoded.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select code from createcode where code=@code", con);
                cmd.Parameters.AddWithValue("@code", decoded.Text);
                cmd.ExecuteNonQuery();
                var da = cmd.ExecuteScalar();
                string tanong = "SELECT * FROM createcode WHERE code = '" + decoded.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Studenthomepage form2 = new Studenthomepage();
                    form2.variable = decoded.Text;
                    form2.Show();
                    
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Your code is not valid", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
                con.Close();
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Class1.conReturn());
                con.Open();
                if (code.Text != "" || code.Text != "TYPE YOUR STUDENT CODE")
                {

                    string tanong = "SELECT * FROM createcode WHERE code = '" + code.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(tanong, con);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Studenthomepage form2 = new Studenthomepage();

                        form2.variable = code.Text;

                        form2.Show();
                        this.Hide();

                    }
                    else
                    {
                        Error();

                    }
                }
                else
                {
                    Empty();
                }
                con.Close();
            }
            catch(Exception pe)
            {
                //MessageBox.Show("There is something wrong with your server. E-Guess cannot access the database. \nPlease double check the admincon configuaration, make sure you type the correct format. \nIf error keeps throwing, contact your developer. Thank you!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(pe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Error()
        {
            label8.Show();
            await Task.Delay(3000);
            label8.Hide();
        }

        private async void Empty()
        {
            label9.Show();
            await Task.Delay(3000);
            label9.Hide();
        }
        Point lastPoint;

        private void loginstudent_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginstudent_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

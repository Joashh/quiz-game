using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Math_School
{
    public partial class STARTUP : Form
    {
        public STARTUP()
        {
            InitializeComponent();
        }

        private void areyouregistered_Paint(object sender, PaintEventArgs e)
        {


        }

        private void STARTUP_Load(object sender, EventArgs e)
        {
            
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            TEACHER reg = new TEACHER();
            reg.Show();
            this.Hide();
         
        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginstudent stud = new loginstudent();

                stud.Show();
            
            
        }
        private void exit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void help_Click(object sender, EventArgs e)
        {
          
           credits cred = new credits();
           cred.Show();
        }
        Point lastPoint;
        private void STARTUP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void STARTUP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Math_School
{
    public partial class loadingform : Form
    {
        public loadingform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loading.Value < loading.MaximumValue)
            {
                loading.Value += 5;
            }
            if (loading.Value == loading.MaximumValue)
            {
                
                timer1.Stop();
                STARTUP start = new STARTUP();
                start.Show();
                this.Hide();
            }
            
            

        }

        private void loadingform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

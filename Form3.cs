using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_School
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        string con = @"Data Source=" + Properties.Settings.Default.finaloutput + ";Network Library=DBMSSOCN; Initial Catalog=MathSchool; User ID=eguessusers;Password=joash; Integrated Security = false; MultipleActiveResultSets=True";
        private void Form3_Load(object sender, EventArgs e)
        {
            datasource.Text = Properties.Settings.Default.strDataSourceLocal;
            textBox1.Text = Properties.Settings.Default.strDataSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strDataSource = con;
            Properties.Settings.Default.Save();
            MessageBox.Show("Data Source was changed. Please restart the application.", "E-Guess: A Prodiy Adaptive Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.finaloutput = datasource.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Data source successfully changed.", "E-Guess: A Prodiy Adaptive Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Properties.Settings.Default.strDataSource = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + System.IO.Path.GetFullPath("Finaldb.mdf") + "; Integrated Security = True; Connect Timeout = 30";
            Properties.Settings.Default.Save();
            MessageBox.Show("Data source successfully changed.", "E-Guess: A Prodiy Adaptive Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                button2.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}

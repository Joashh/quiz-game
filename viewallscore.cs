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
    public partial class viewallscore : Form
    {
        Studenthomepage frm1;
        public viewallscore(Studenthomepage fr1)
        {
            InitializeComponent();
            frm1 = fr1;

        }

        Point lastPoint;
        private DataTable dataTable = new DataTable();
        private void viewallscore_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void viewallscore_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
                
            }
        }

        private void viewallscore_Load(object sender, EventArgs e)
        {
            
            

            if (frm1.label15.Text == "GRADE 1")
            {
                
                SqlConnection con = new SqlConnection(Class1.conReturn());
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Name + '   ..........................   ' + overall As viewall from grade1record where code=@code Order By overall ASC ", con);
                cmd.Parameters.AddWithValue("@code", frm1.code.Text);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
                this.listBox1.DataSource = new DataView(dataTable);
                this.listBox1.DisplayMember = "viewall";
                this.listBox1.Visible = true;
               
                con.Close();
            } 
            else if(frm1.label15.Text == "GRADE 2")
            {
                
                SqlConnection con = new SqlConnection(Class1.conReturn());
                con.Open();
                SqlCommand cmd = new SqlCommand("Select name + '   ..........................   ' + overall As viewall from grade2record where code=@code Order By name ASC ", con);
                cmd.Parameters.AddWithValue("@code", frm1.code.Text);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
               
                this.listBox1.DataSource = new DataView(dataTable);
                this.listBox1.DisplayMember = "viewall";
                this.listBox1.Visible = true;

                con.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class advancelevel : Form
    {
        public advancelevel()
        {
            InitializeComponent();
        }

        private void advancelevel_Load(object sender, EventArgs e)
        {

        }

        private void questions(int quest)
        {
            
            switch(quest)
            {
                case 1:
                    CreateQuestions hello = new CreateQuestions();
                    label1.Text = hello.questions[0]; 
                    break;
            }
        }
    }
}

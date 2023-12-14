using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVDTest
{
    public partial class Form1 : Form
    {
        Form2 TestForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            if(TestForm != null && TestForm.Visible) 
            { 
                TestForm.BringToFront();
            }
            else
            {
                TestForm = new Form2();
                TestForm.Show(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btnAdd_LERIN
{
    public partial class frmMain : Form
    {
        private Form2 Form1ni;
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1ni = new Form2();
            Form1ni.setEveryThing(this, this.btnMain);
            Form1ni.Show();
            //Form2 myForm2 = new Form2();
            //myForm2.Show();
        }
    }
}



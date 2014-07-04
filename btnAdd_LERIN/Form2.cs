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
    public partial class Form2 : Form
    {
        private frmMain Form1ni;

        
        public Form2()
        {
            InitializeComponent();
        }

         public void setEveryThing(frmMain Formko, Button btnMain)
        {
            this.Form1ni = Formko;
            this.btnAdd = btnMain;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
             int number;

            try
            {
                number = int.Parse(txtAddnum.Text);
                this.btnAdd.Text = (number + int.Parse(this.btnAdd.Text)).ToString();
                this.Close();
            }
            catch (Exception) { }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class app1 : Form
    {
        private Form1 parentName;
        //public int _sa;
        //private Form1 parname;

        public app1()
        {
            InitializeComponent();
        }

        public app1(Form1 callingFrom, int code)
        {
            InitializeComponent();

            //Console.Write("Constructor 2 called");
            parentName = callingFrom;
            parentName.Enabled = false;
            
            
        }

        public app1(string pname)
        {
            Console.Write("Constructor 3 called");
            //parentName = pname;
            //parname.Name = pname;
            InitializeComponent();

        }

        private void app1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if this.close() come here, Form1 is not focussed. But works as expected
            parentName.Enabled = true;
            this.Close();
            //this.Dispose(true);
        }
    }
}

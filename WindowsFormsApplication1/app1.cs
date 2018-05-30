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
        private int randomNum=0;
        //public int _sa;
        //private Form1 parname;

        public app1()
        {
            InitializeComponent();
        }

        //this method disables the parent, and enables after closing the child________
        public app1(Form1 callingFrom, int code)
        {
            InitializeComponent();
            //Console.Write("Constructor 2 called");
            disableParent(callingFrom); //returns bool
             
        } //end of app1(Form1 callingFrom, int code)___________________________________


        // this method returns[actually passing] data to the parent form________________
        public app1(Form1 callingFrom)
        {
            InitializeComponent();
            disableParent(callingFrom);
            Random rnd = new Random();
            randomNum= rnd.Next(0, 15);

            this.lblRand1.Text = randomNum.ToString();
            callingFrom.setlable3(randomNum);
            
            //this.Dispose(true);
            //return randomNum;
        } //end of app1(Form1 callingFrom)________________________________________________

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
            this.Dispose();
            //this.Dispose(true);
        }

        private bool disableParent(Form1 callingFrom)
        {
            bool res = false;

            parentName = callingFrom; //get parent element
            parentName.Enabled = false; //disable the parent
            res = true; 
            return res; //return success
        }
    }
}

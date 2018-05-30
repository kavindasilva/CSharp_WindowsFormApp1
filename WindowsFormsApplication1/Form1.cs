﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool enabledBtns=true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Main form loaded"); //working
            //MessageBox.Show(this.);

        }

        private void btnApp1_Click(object sender, EventArgs e)
        {
            //String objname = new app1().Name;
            //this.Enabled = false;
            /*  This form should be disabled by the child.
             *  Otherwise enabling again not works
             */
            new app1(this, 1).Show();

        }

        private void btnApp1C3_Click(object sender, EventArgs e)
        {
            if (enabledBtns)
            {
                this.btnApp1.Enabled = false;
                this.btnApp1C2.Enabled = false;
                enabledBtns = false;
            }
            else 
            { 
                this.btnApp1.Enabled = true;
                this.btnApp1C2.Enabled = true;
                enabledBtns = true;
            }


        }

        private void btnApp1C2_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿
//using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class app1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //this.Parent.Enabled = true;
            MessageBox.Show("Closing");
            parentName.Enabled = true;
            //parname.Enabled = true;
            //parentName.

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRand1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Random Number=";
            // 
            // lblRand1
            // 
            this.lblRand1.Location = new System.Drawing.Point(277, 115);
            this.lblRand1.Name = "lblRand1";
            this.lblRand1.Size = new System.Drawing.Size(100, 23);
            this.lblRand1.TabIndex = 2;
            this.lblRand1.Text = "0";
            // 
            // app1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 271);
            this.Controls.Add(this.lblRand1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "app1";
            this.Text = "app1";
            this.Load += new System.EventHandler(this.app1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label lblRand1;
    }
}
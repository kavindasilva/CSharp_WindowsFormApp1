namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnApp1 = new System.Windows.Forms.Button();
            this.btnApp1C3 = new System.Windows.Forms.Button();
            this.btnApp1C2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btndb1 = new System.Windows.Forms.Button();
            this.lblBtn1 = new System.Windows.Forms.Label();
            this.lblBtn3 = new System.Windows.Forms.Label();
            this.lblBtn2 = new System.Windows.Forms.Label();
            this.lblBtn4 = new System.Windows.Forms.Label();
            this.lblBtn5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApp1
            // 
            this.btnApp1.Location = new System.Drawing.Point(302, 43);
            this.btnApp1.Name = "btnApp1";
            this.btnApp1.Size = new System.Drawing.Size(75, 23);
            this.btnApp1.TabIndex = 0;
            this.btnApp1.Text = "App1";
            this.btnApp1.UseVisualStyleBackColor = true;
            this.btnApp1.Click += new System.EventHandler(this.btnApp1_Click);
            // 
            // btnApp1C3
            // 
            this.btnApp1C3.Location = new System.Drawing.Point(302, 129);
            this.btnApp1C3.Name = "btnApp1C3";
            this.btnApp1C3.Size = new System.Drawing.Size(75, 23);
            this.btnApp1C3.TabIndex = 1;
            this.btnApp1C3.Text = "App1-c3";
            this.btnApp1C3.UseVisualStyleBackColor = true;
            this.btnApp1C3.Click += new System.EventHandler(this.btnApp1C3_Click);
            // 
            // btnApp1C2
            // 
            this.btnApp1C2.Location = new System.Drawing.Point(302, 87);
            this.btnApp1C2.Name = "btnApp1C2";
            this.btnApp1C2.Size = new System.Drawing.Size(75, 23);
            this.btnApp1C2.TabIndex = 2;
            this.btnApp1C2.Text = "App1-c2";
            this.btnApp1C2.UseVisualStyleBackColor = true;
            this.btnApp1C2.Click += new System.EventHandler(this.btnApp1C2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btndb1
            // 
            this.btndb1.Location = new System.Drawing.Point(302, 172);
            this.btndb1.Name = "btndb1";
            this.btndb1.Size = new System.Drawing.Size(75, 23);
            this.btndb1.TabIndex = 4;
            this.btndb1.Text = "DB";
            this.btndb1.UseVisualStyleBackColor = true;
            this.btndb1.Click += new System.EventHandler(this.btndb1_Click);
            // 
            // lblBtn1
            // 
            this.lblBtn1.Location = new System.Drawing.Point(383, 43);
            this.lblBtn1.Name = "lblBtn1";
            this.lblBtn1.Size = new System.Drawing.Size(216, 23);
            this.lblBtn1.TabIndex = 5;
            this.lblBtn1.Text = "Open app1 in a window. returns nothing";
            // 
            // lblBtn3
            // 
            this.lblBtn3.Location = new System.Drawing.Point(383, 129);
            this.lblBtn3.Name = "lblBtn3";
            this.lblBtn3.Size = new System.Drawing.Size(189, 23);
            this.lblBtn3.TabIndex = 6;
            this.lblBtn3.Text = "disables \'App1\', \'App1-c2\' buttons";
            // 
            // lblBtn2
            // 
            this.lblBtn2.Location = new System.Drawing.Point(383, 87);
            this.lblBtn2.Name = "lblBtn2";
            this.lblBtn2.Size = new System.Drawing.Size(259, 23);
            this.lblBtn2.TabIndex = 7;
            this.lblBtn2.Text = "Open app1 in a window. returns a random number";
            // 
            // lblBtn4
            // 
            this.lblBtn4.Location = new System.Drawing.Point(383, 172);
            this.lblBtn4.Name = "lblBtn4";
            this.lblBtn4.Size = new System.Drawing.Size(189, 23);
            this.lblBtn4.TabIndex = 8;
            this.lblBtn4.Text = "View DB";
            // 
            // lblBtn5
            // 
            this.lblBtn5.Location = new System.Drawing.Point(383, 216);
            this.lblBtn5.Name = "lblBtn5";
            this.lblBtn5.Size = new System.Drawing.Size(189, 23);
            this.lblBtn5.TabIndex = 9;
            this.lblBtn5.Text = "Open app1 in a window. returns nothing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 273);
            this.Controls.Add(this.lblBtn5);
            this.Controls.Add(this.lblBtn4);
            this.Controls.Add(this.lblBtn2);
            this.Controls.Add(this.lblBtn3);
            this.Controls.Add(this.lblBtn1);
            this.Controls.Add(this.btndb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApp1C2);
            this.Controls.Add(this.btnApp1C3);
            this.Controls.Add(this.btnApp1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApp1;
        private System.Windows.Forms.Button btnApp1C3;
        private System.Windows.Forms.Button btnApp1C2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndb1;
        private System.Windows.Forms.Label lblBtn1;
        private System.Windows.Forms.Label lblBtn3;
        private System.Windows.Forms.Label lblBtn2;
        private System.Windows.Forms.Label lblBtn4;
        private System.Windows.Forms.Label lblBtn5;
    }
}


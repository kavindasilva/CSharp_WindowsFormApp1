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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbCmd = new System.Windows.Forms.RadioButton();
            this.rbPy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 249);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDate);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tab1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(83, 57);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "OK";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRun);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtCmd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CMD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(73, 154);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJava);
            this.groupBox1.Controls.Add(this.rbCmd);
            this.groupBox1.Controls.Add(this.rbPy);
            this.groupBox1.Location = new System.Drawing.Point(20, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(39, 59);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(48, 17);
            this.rbJava.TabIndex = 2;
            this.rbJava.Text = "Java";
            this.rbJava.UseVisualStyleBackColor = true;
            // 
            // rbCmd
            // 
            this.rbCmd.AutoSize = true;
            this.rbCmd.Location = new System.Drawing.Point(39, 34);
            this.rbCmd.Name = "rbCmd";
            this.rbCmd.Size = new System.Drawing.Size(45, 17);
            this.rbCmd.TabIndex = 1;
            this.rbCmd.Text = "cmd";
            this.rbCmd.UseVisualStyleBackColor = true;
            // 
            // rbPy
            // 
            this.rbPy.AutoSize = true;
            this.rbPy.Checked = true;
            this.rbPy.Location = new System.Drawing.Point(39, 10);
            this.rbPy.Name = "rbPy";
            this.rbPy.Size = new System.Drawing.Size(58, 17);
            this.rbPy.TabIndex = 0;
            this.rbPy.TabStop = true;
            this.rbPy.Text = "Python";
            this.rbPy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "command";
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(73, 32);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(170, 20);
            this.txtCmd.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(260, 223);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 273);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbCmd;
        private System.Windows.Forms.Button btnRun;
    }
}


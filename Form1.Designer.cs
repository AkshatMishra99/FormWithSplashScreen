namespace FormWithSplashScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.find_Btn = new System.Windows.Forms.Button();
            this.upd_Btn = new System.Windows.Forms.Button();
            this.crt_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upl_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addInput = new System.Windows.Forms.TextBox();
            this.phInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sub_Btn = new System.Windows.Forms.Button();
            this.rst_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Roll Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // find_Btn
            // 
            this.find_Btn.Location = new System.Drawing.Point(338, 35);
            this.find_Btn.Name = "find_Btn";
            this.find_Btn.Size = new System.Drawing.Size(75, 23);
            this.find_Btn.TabIndex = 2;
            this.find_Btn.Text = "Find";
            this.find_Btn.UseVisualStyleBackColor = true;
            this.find_Btn.Click += new System.EventHandler(this.find_Btn_Click);
            // 
            // upd_Btn
            // 
            this.upd_Btn.Location = new System.Drawing.Point(419, 35);
            this.upd_Btn.Name = "upd_Btn";
            this.upd_Btn.Size = new System.Drawing.Size(75, 23);
            this.upd_Btn.TabIndex = 2;
            this.upd_Btn.Text = "Update";
            this.upd_Btn.UseVisualStyleBackColor = true;
            this.upd_Btn.Click += new System.EventHandler(this.upd_Btn_Click);
            // 
            // crt_Btn
            // 
            this.crt_Btn.Location = new System.Drawing.Point(500, 35);
            this.crt_Btn.Name = "crt_Btn";
            this.crt_Btn.Size = new System.Drawing.Size(75, 23);
            this.crt_Btn.TabIndex = 2;
            this.crt_Btn.Text = "Create";
            this.crt_Btn.UseVisualStyleBackColor = true;
            this.crt_Btn.Click += new System.EventHandler(this.crt_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upl_Btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.addInput);
            this.groupBox1.Controls.Add(this.phInput);
            this.groupBox1.Controls.Add(this.emailInput);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(142, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // upl_Btn
            // 
            this.upl_Btn.Enabled = false;
            this.upl_Btn.Location = new System.Drawing.Point(368, 169);
            this.upl_Btn.Name = "upl_Btn";
            this.upl_Btn.Size = new System.Drawing.Size(75, 23);
            this.upl_Btn.TabIndex = 6;
            this.upl_Btn.Text = "Upload Photo";
            this.upl_Btn.UseVisualStyleBackColor = true;
            this.upl_Btn.Click += new System.EventHandler(this.upl_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // addInput
            // 
            this.addInput.Enabled = false;
            this.addInput.Location = new System.Drawing.Point(153, 142);
            this.addInput.Multiline = true;
            this.addInput.Name = "addInput";
            this.addInput.Size = new System.Drawing.Size(118, 50);
            this.addInput.TabIndex = 1;
            // 
            // phInput
            // 
            this.phInput.Enabled = false;
            this.phInput.Location = new System.Drawing.Point(153, 105);
            this.phInput.Name = "phInput";
            this.phInput.Size = new System.Drawing.Size(118, 20);
            this.phInput.TabIndex = 1;
            // 
            // emailInput
            // 
            this.emailInput.Enabled = false;
            this.emailInput.Location = new System.Drawing.Point(153, 68);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(118, 20);
            this.emailInput.TabIndex = 1;
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(153, 31);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(118, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // sub_Btn
            // 
            this.sub_Btn.Enabled = false;
            this.sub_Btn.Location = new System.Drawing.Point(500, 298);
            this.sub_Btn.Name = "sub_Btn";
            this.sub_Btn.Size = new System.Drawing.Size(75, 23);
            this.sub_Btn.TabIndex = 4;
            this.sub_Btn.Text = "Submit";
            this.sub_Btn.UseVisualStyleBackColor = true;
            this.sub_Btn.Click += new System.EventHandler(this.sub_Btn_Click);
            // 
            // rst_Btn
            // 
            this.rst_Btn.Enabled = false;
            this.rst_Btn.Location = new System.Drawing.Point(581, 298);
            this.rst_Btn.Name = "rst_Btn";
            this.rst_Btn.Size = new System.Drawing.Size(75, 23);
            this.rst_Btn.TabIndex = 5;
            this.rst_Btn.Text = "Reset";
            this.rst_Btn.UseVisualStyleBackColor = true;
            this.rst_Btn.Click += new System.EventHandler(this.rst_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rst_Btn);
            this.Controls.Add(this.sub_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crt_Btn);
            this.Controls.Add(this.upd_Btn);
            this.Controls.Add(this.find_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button find_Btn;
        private System.Windows.Forms.Button upd_Btn;
        private System.Windows.Forms.Button crt_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button upl_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addInput;
        private System.Windows.Forms.TextBox phInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sub_Btn;
        private System.Windows.Forms.Button rst_Btn;
    }
}


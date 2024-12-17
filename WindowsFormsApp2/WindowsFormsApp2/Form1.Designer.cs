namespace WindowsFormsApp2
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
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.vorod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(46, 49);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(177, 39);
            this.textpassword.TabIndex = 0;
            this.textpassword.LocationChanged += new System.EventHandler(this.textBox1_LocationChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = ":نام کاربری";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = ":رمز عبور";
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(356, 49);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(177, 39);
            this.textname.TabIndex = 3;
            this.textname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // vorod
            // 
            this.vorod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vorod.Location = new System.Drawing.Point(375, 158);
            this.vorod.Name = "vorod";
            this.vorod.Size = new System.Drawing.Size(158, 47);
            this.vorod.TabIndex = 4;
            this.vorod.Text = "ورود";
            this.vorod.UseVisualStyleBackColor = true;
            this.vorod.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(375, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "ثبت نام";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(425, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "من ربات نیستم ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(135, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 75);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin panel:\r\nusername: admin\r\npassword: 123456";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vorod);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "ورود ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button vorod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}


namespace WindowsFormsApp2
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpaye = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "نمایش اطلاعات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.uname,
            this.base0,
            this.number,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 292);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(878, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "بروزرسانی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(890, 370);
            this.txtuname.Multiline = true;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(266, 38);
            this.txtuname.TabIndex = 4;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(890, 486);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(266, 42);
            this.txtnumber.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(890, 304);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(266, 45);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtpaye
            // 
            this.txtpaye.Location = new System.Drawing.Point(890, 428);
            this.txtpaye.Multiline = true;
            this.txtpaye.Name = "txtpaye";
            this.txtpaye.Size = new System.Drawing.Size(266, 39);
            this.txtpaye.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1041, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "ثبت";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(890, 552);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(266, 45);
            this.txtpassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1181, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = ": نام و نام خانوادگی";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1233, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = ":نام کاربری ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1217, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = ": پایه تحصیلی ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1227, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = ": شماره تماس";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1235, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = ": رمز عبور ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام و نام خانوادگی";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // uname
            // 
            this.uname.DataPropertyName = "uname";
            this.uname.HeaderText = "نام کاربری";
            this.uname.MinimumWidth = 6;
            this.uname.Name = "uname";
            // 
            // base0
            // 
            this.base0.DataPropertyName = "base0";
            this.base0.HeaderText = "پایه تحصیلی";
            this.base0.MinimumWidth = 6;
            this.base0.Name = "base0";
            // 
            // number
            // 
            this.number.DataPropertyName = "phone_number";
            this.number.HeaderText = "شماره تماس";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // password
            // 
            this.password.DataPropertyName = "user_password";
            this.password.HeaderText = "رمزعبور";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtpaye);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.RightToLeftLayout = true;
            this.Text = "پنل مدیریت";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpaye;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn base0;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}
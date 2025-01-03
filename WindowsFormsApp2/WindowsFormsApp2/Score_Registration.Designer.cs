namespace School
{
    partial class Score_Registration
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geography = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ritual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.science = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtexercise = new System.Windows.Forms.TextBox();
            this.txtscience = new System.Windows.Forms.TextBox();
            this.txtritual = new System.Windows.Forms.TextBox();
            this.txtgeography = new System.Windows.Forms.TextBox();
            this.txtpersian = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.math,
            this.persian,
            this.geography,
            this.ritual,
            this.science,
            this.exercise,
            this.uname,
            this.user_password,
            this.phone_number,
            this.base0,
            this.saturday,
            this.sunday,
            this.monday,
            this.tuesday,
            this.wednesday});
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام و نام خانوادگی";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // math
            // 
            this.math.DataPropertyName = "math";
            this.math.HeaderText = "ریاضی";
            this.math.MinimumWidth = 6;
            this.math.Name = "math";
            // 
            // persian
            // 
            this.persian.DataPropertyName = "persian";
            this.persian.HeaderText = "ادبیات";
            this.persian.MinimumWidth = 6;
            this.persian.Name = "persian";
            // 
            // geography
            // 
            this.geography.DataPropertyName = "geography";
            this.geography.HeaderText = "جغرافی";
            this.geography.MinimumWidth = 6;
            this.geography.Name = "geography";
            // 
            // ritual
            // 
            this.ritual.DataPropertyName = "ritual";
            this.ritual.HeaderText = "دینی";
            this.ritual.MinimumWidth = 6;
            this.ritual.Name = "ritual";
            // 
            // science
            // 
            this.science.DataPropertyName = "science";
            this.science.HeaderText = "علوم";
            this.science.MinimumWidth = 6;
            this.science.Name = "science";
            // 
            // exercise
            // 
            this.exercise.DataPropertyName = "exercise";
            this.exercise.HeaderText = "ورزش";
            this.exercise.MinimumWidth = 6;
            this.exercise.Name = "exercise";
            // 
            // uname
            // 
            this.uname.DataPropertyName = "uname";
            this.uname.HeaderText = ".";
            this.uname.MinimumWidth = 6;
            this.uname.Name = "uname";
            this.uname.Visible = false;
            // 
            // user_password
            // 
            this.user_password.DataPropertyName = "user_password";
            this.user_password.HeaderText = "..";
            this.user_password.MinimumWidth = 6;
            this.user_password.Name = "user_password";
            this.user_password.Visible = false;
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "...";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Visible = false;
            // 
            // base0
            // 
            this.base0.DataPropertyName = "base0";
            this.base0.HeaderText = "پایه";
            this.base0.MinimumWidth = 6;
            this.base0.Name = "base0";
            this.base0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.base0.Visible = false;
            // 
            // saturday
            // 
            this.saturday.DataPropertyName = "saturday";
            this.saturday.HeaderText = "شنبه";
            this.saturday.MinimumWidth = 6;
            this.saturday.Name = "saturday";
            this.saturday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.saturday.Visible = false;
            // 
            // sunday
            // 
            this.sunday.DataPropertyName = "sunday";
            this.sunday.HeaderText = "یکشنبه";
            this.sunday.MinimumWidth = 6;
            this.sunday.Name = "sunday";
            this.sunday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sunday.Visible = false;
            // 
            // monday
            // 
            this.monday.DataPropertyName = "monday";
            this.monday.HeaderText = "دوشنبه";
            this.monday.MinimumWidth = 6;
            this.monday.Name = "monday";
            this.monday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.monday.Visible = false;
            // 
            // tuesday
            // 
            this.tuesday.DataPropertyName = "tuesday";
            this.tuesday.HeaderText = "سه شنبه";
            this.tuesday.MinimumWidth = 6;
            this.tuesday.Name = "tuesday";
            this.tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tuesday.Visible = false;
            // 
            // wednesday
            // 
            this.wednesday.DataPropertyName = "wednesday";
            this.wednesday.HeaderText = "چهارشنبه";
            this.wednesday.MinimumWidth = 6;
            this.wednesday.Name = "wednesday";
            this.wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wednesday.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(983, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = ": ثبت نمرات";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "نمایش/بروزرسانی اطلاعات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = ": علوم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = ": ورزش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = ": دینی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1018, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = ": جغرافی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1018, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = ": ادبیات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1010, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = ": ریاضی";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtexercise
            // 
            this.txtexercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexercise.Location = new System.Drawing.Point(597, 500);
            this.txtexercise.Multiline = true;
            this.txtexercise.Name = "txtexercise";
            this.txtexercise.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtexercise.Size = new System.Drawing.Size(123, 45);
            this.txtexercise.TabIndex = 31;
            // 
            // txtscience
            // 
            this.txtscience.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscience.Location = new System.Drawing.Point(597, 398);
            this.txtscience.Multiline = true;
            this.txtscience.Name = "txtscience";
            this.txtscience.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtscience.Size = new System.Drawing.Size(123, 45);
            this.txtscience.TabIndex = 32;
            // 
            // txtritual
            // 
            this.txtritual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtritual.Location = new System.Drawing.Point(597, 309);
            this.txtritual.Multiline = true;
            this.txtritual.Name = "txtritual";
            this.txtritual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtritual.Size = new System.Drawing.Size(123, 45);
            this.txtritual.TabIndex = 33;
            // 
            // txtgeography
            // 
            this.txtgeography.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgeography.Location = new System.Drawing.Point(880, 502);
            this.txtgeography.Multiline = true;
            this.txtgeography.Name = "txtgeography";
            this.txtgeography.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtgeography.Size = new System.Drawing.Size(123, 45);
            this.txtgeography.TabIndex = 34;
            // 
            // txtpersian
            // 
            this.txtpersian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersian.Location = new System.Drawing.Point(880, 398);
            this.txtpersian.Multiline = true;
            this.txtpersian.Name = "txtpersian";
            this.txtpersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpersian.Size = new System.Drawing.Size(123, 45);
            this.txtpersian.TabIndex = 35;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmath.Location = new System.Drawing.Point(880, 315);
            this.txtmath.Multiline = true;
            this.txtmath.Name = "txtmath";
            this.txtmath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmath.Size = new System.Drawing.Size(123, 45);
            this.txtmath.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(413, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 70);
            this.button2.TabIndex = 37;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(260, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 70);
            this.button4.TabIndex = 38;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Score_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 559);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txtpersian);
            this.Controls.Add(this.txtgeography);
            this.Controls.Add(this.txtritual);
            this.Controls.Add(this.txtscience);
            this.Controls.Add(this.txtexercise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Score_Registration";
            this.Text = "ثبت نمرات";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtexercise;
        private System.Windows.Forms.TextBox txtscience;
        private System.Windows.Forms.TextBox txtritual;
        private System.Windows.Forms.TextBox txtgeography;
        private System.Windows.Forms.TextBox txtpersian;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn math;
        private System.Windows.Forms.DataGridViewTextBoxColumn persian;
        private System.Windows.Forms.DataGridViewTextBoxColumn geography;
        private System.Windows.Forms.DataGridViewTextBoxColumn ritual;
        private System.Windows.Forms.DataGridViewTextBoxColumn science;
        private System.Windows.Forms.DataGridViewTextBoxColumn exercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn base0;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
    }
}
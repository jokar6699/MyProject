namespace WindowsFormsApp2
{
    partial class Presence_Absence
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
            this.base0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geography = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ritual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.science = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtwednesday = new System.Windows.Forms.TextBox();
            this.txttuesday = new System.Windows.Forms.TextBox();
            this.txtsunday = new System.Windows.Forms.TextBox();
            this.txtmonday = new System.Windows.Forms.TextBox();
            this.txtsaturday = new System.Windows.Forms.TextBox();
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
            this.base0,
            this.saturday,
            this.sunday,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.math,
            this.geography,
            this.exercise,
            this.ritual,
            this.persian,
            this.science,
            this.uname,
            this.user_password,
            this.phone_number});
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 250);
            this.dataGridView1.TabIndex = 0;
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
            // base0
            // 
            this.base0.DataPropertyName = "base0";
            this.base0.HeaderText = "پایه";
            this.base0.MinimumWidth = 6;
            this.base0.Name = "base0";
            // 
            // saturday
            // 
            this.saturday.DataPropertyName = "saturday";
            this.saturday.HeaderText = "شنبه";
            this.saturday.MinimumWidth = 6;
            this.saturday.Name = "saturday";
            // 
            // sunday
            // 
            this.sunday.DataPropertyName = "sunday";
            this.sunday.HeaderText = "یکشنبه";
            this.sunday.MinimumWidth = 6;
            this.sunday.Name = "sunday";
            // 
            // monday
            // 
            this.monday.DataPropertyName = "monday";
            this.monday.HeaderText = "دوشنبه";
            this.monday.MinimumWidth = 6;
            this.monday.Name = "monday";
            // 
            // tuesday
            // 
            this.tuesday.DataPropertyName = "tuesday";
            this.tuesday.HeaderText = "سه شنبه";
            this.tuesday.MinimumWidth = 6;
            this.tuesday.Name = "tuesday";
            // 
            // wednesday
            // 
            this.wednesday.DataPropertyName = "wednesday";
            this.wednesday.HeaderText = "چهارشنبه";
            this.wednesday.MinimumWidth = 6;
            this.wednesday.Name = "wednesday";
            // 
            // math
            // 
            this.math.DataPropertyName = "math";
            this.math.HeaderText = "..";
            this.math.MinimumWidth = 6;
            this.math.Name = "math";
            this.math.Visible = false;
            // 
            // geography
            // 
            this.geography.DataPropertyName = "geography";
            this.geography.HeaderText = "....";
            this.geography.MinimumWidth = 6;
            this.geography.Name = "geography";
            this.geography.Visible = false;
            // 
            // exercise
            // 
            this.exercise.DataPropertyName = "exercise";
            this.exercise.HeaderText = ".......";
            this.exercise.MinimumWidth = 6;
            this.exercise.Name = "exercise";
            this.exercise.Visible = false;
            // 
            // ritual
            // 
            this.ritual.DataPropertyName = "ritual";
            this.ritual.HeaderText = ".....";
            this.ritual.MinimumWidth = 6;
            this.ritual.Name = "ritual";
            this.ritual.Visible = false;
            // 
            // persian
            // 
            this.persian.DataPropertyName = "persian";
            this.persian.HeaderText = "......";
            this.persian.MinimumWidth = 6;
            this.persian.Name = "persian";
            this.persian.Visible = false;
            // 
            // science
            // 
            this.science.DataPropertyName = "science";
            this.science.HeaderText = ".......";
            this.science.MinimumWidth = 6;
            this.science.Name = "science";
            this.science.Visible = false;
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "نمایش/بروزرسانی اطلاعات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(888, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = ": حضور و غیاب این هفته";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1020, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = ": دوشنبه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1031, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = ": شنبه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1022, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = ": یکشنبه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(783, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = ": سه شنبه";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(772, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = ": چهارشنبه";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 70);
            this.button2.TabIndex = 25;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtwednesday
            // 
            this.txtwednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwednesday.Location = new System.Drawing.Point(643, 423);
            this.txtwednesday.Multiline = true;
            this.txtwednesday.Name = "txtwednesday";
            this.txtwednesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtwednesday.Size = new System.Drawing.Size(123, 45);
            this.txtwednesday.TabIndex = 26;
            // 
            // txttuesday
            // 
            this.txttuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttuesday.Location = new System.Drawing.Point(643, 341);
            this.txttuesday.Multiline = true;
            this.txttuesday.Name = "txttuesday";
            this.txttuesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttuesday.Size = new System.Drawing.Size(123, 45);
            this.txttuesday.TabIndex = 27;
            // 
            // txtsunday
            // 
            this.txtsunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsunday.Location = new System.Drawing.Point(893, 423);
            this.txtsunday.Multiline = true;
            this.txtsunday.Name = "txtsunday";
            this.txtsunday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsunday.Size = new System.Drawing.Size(123, 45);
            this.txtsunday.TabIndex = 28;
            // 
            // txtmonday
            // 
            this.txtmonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonday.Location = new System.Drawing.Point(893, 532);
            this.txtmonday.Multiline = true;
            this.txtmonday.Name = "txtmonday";
            this.txtmonday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmonday.Size = new System.Drawing.Size(123, 45);
            this.txtmonday.TabIndex = 29;
            // 
            // txtsaturday
            // 
            this.txtsaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaturday.Location = new System.Drawing.Point(893, 341);
            this.txtsaturday.Multiline = true;
            this.txtsaturday.Name = "txtsaturday";
            this.txtsaturday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsaturday.Size = new System.Drawing.Size(123, 45);
            this.txtsaturday.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(336, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 70);
            this.button4.TabIndex = 32;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Presence_Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 601);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtsaturday);
            this.Controls.Add(this.txtmonday);
            this.Controls.Add(this.txtsunday);
            this.Controls.Add(this.txttuesday);
            this.Controls.Add(this.txtwednesday);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Presence_Absence";
            this.Text = "حضور و غیاب";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtwednesday;
        private System.Windows.Forms.TextBox txttuesday;
        private System.Windows.Forms.TextBox txtsunday;
        private System.Windows.Forms.TextBox txtmonday;
        private System.Windows.Forms.TextBox txtsaturday;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn base0;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn math;
        private System.Windows.Forms.DataGridViewTextBoxColumn geography;
        private System.Windows.Forms.DataGridViewTextBoxColumn exercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ritual;
        private System.Windows.Forms.DataGridViewTextBoxColumn persian;
        private System.Windows.Forms.DataGridViewTextBoxColumn science;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
    }
}
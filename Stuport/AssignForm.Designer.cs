namespace Stuport
{
    partial class AssignForm
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
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVenueList = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCounsellor = new System.Windows.Forms.ComboBox();
            this.radioAcademicHelp = new System.Windows.Forms.RadioButton();
            this.radioPersonalAndPsych = new System.Windows.Forms.RadioButton();
            this.btnSetAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.radioAcademicHelp);
            this.flowLayoutPanel5.Controls.Add(this.radioPersonalAndPsych);
            this.flowLayoutPanel5.Controls.Add(this.btnSetAppointment);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(356, 72);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(299, 470);
            this.flowLayoutPanel5.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Appointment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.datePicker);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(46, 3);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(218, 20);
            this.datePicker.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.TimePicker);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 85);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel3.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time:";
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(48, 3);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(218, 20);
            this.TimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.cbVenueList);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 125);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Venue:";
            // 
            // cbVenueList
            // 
            this.cbVenueList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVenueList.FormattingEnabled = true;
            this.cbVenueList.Location = new System.Drawing.Point(52, 3);
            this.cbVenueList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbVenueList.Name = "cbVenueList";
            this.cbVenueList.Size = new System.Drawing.Size(210, 21);
            this.cbVenueList.TabIndex = 15;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label7);
            this.flowLayoutPanel6.Controls.Add(this.cbCounsellor);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(5, 165);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Counsellor:";
            // 
            // cbCounsellor
            // 
            this.cbCounsellor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCounsellor.FormattingEnabled = true;
            this.cbCounsellor.Location = new System.Drawing.Point(76, 3);
            this.cbCounsellor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbCounsellor.Name = "cbCounsellor";
            this.cbCounsellor.Size = new System.Drawing.Size(190, 21);
            this.cbCounsellor.TabIndex = 15;
            // 
            // radioAcademicHelp
            // 
            this.radioAcademicHelp.AutoSize = true;
            this.radioAcademicHelp.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAcademicHelp.ForeColor = System.Drawing.Color.White;
            this.radioAcademicHelp.Location = new System.Drawing.Point(3, 247);
            this.radioAcademicHelp.Name = "radioAcademicHelp";
            this.radioAcademicHelp.Size = new System.Drawing.Size(98, 17);
            this.radioAcademicHelp.TabIndex = 29;
            this.radioAcademicHelp.TabStop = true;
            this.radioAcademicHelp.Text = "AcademicHelp";
            this.radioAcademicHelp.UseVisualStyleBackColor = true;
            // 
            // radioPersonalAndPsych
            // 
            this.radioPersonalAndPsych.AutoSize = true;
            this.radioPersonalAndPsych.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPersonalAndPsych.ForeColor = System.Drawing.Color.White;
            this.radioPersonalAndPsych.Location = new System.Drawing.Point(3, 270);
            this.radioPersonalAndPsych.Name = "radioPersonalAndPsych";
            this.radioPersonalAndPsych.Size = new System.Drawing.Size(205, 17);
            this.radioPersonalAndPsych.TabIndex = 30;
            this.radioPersonalAndPsych.TabStop = true;
            this.radioPersonalAndPsych.Text = "personal and psychological services";
            this.radioPersonalAndPsych.UseVisualStyleBackColor = true;
            // 
            // btnSetAppointment
            // 
            this.btnSetAppointment.Location = new System.Drawing.Point(3, 293);
            this.btnSetAppointment.Name = "btnSetAppointment";
            this.btnSetAppointment.Size = new System.Drawing.Size(290, 23);
            this.btnSetAppointment.TabIndex = 27;
            this.btnSetAppointment.Text = "Set Appointment";
            this.btnSetAppointment.UseVisualStyleBackColor = true;
            this.btnSetAppointment.Click += new System.EventHandler(this.btnSetAppointment_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Service Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.flowLayoutPanel5);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "AssignForm";
            this.Text = "AssignForm";
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVenueList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCounsellor;
        private System.Windows.Forms.RadioButton radioAcademicHelp;
        private System.Windows.Forms.RadioButton radioPersonalAndPsych;
        private System.Windows.Forms.Button btnSetAppointment;
        private System.Windows.Forms.Label label1;
    }
}
namespace Stuport
{
    partial class StudentAppointment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.serviceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.services = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnStudSetAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioResidence = new System.Windows.Forms.RadioButton();
            this.radioFinancialHelp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGroupList = new System.Windows.Forms.ComboBox();
            this.btnJoinGroup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.serviceLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.serviceLayout, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(147, 59);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 495);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel2.Controls.Add(this.lblDescription);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(368, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(360, 489);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(10, 10);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(345, 400);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serviceLayout
            // 
            this.serviceLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.serviceLayout.Controls.Add(this.services);
            this.serviceLayout.Controls.Add(this.flowLayoutPanel1);
            this.serviceLayout.Controls.Add(this.flowLayoutPanel3);
            this.serviceLayout.Controls.Add(this.btnStudSetAppointment);
            this.serviceLayout.Controls.Add(this.label1);
            this.serviceLayout.Controls.Add(this.radioResidence);
            this.serviceLayout.Controls.Add(this.radioFinancialHelp);
            this.serviceLayout.Controls.Add(this.label2);
            this.serviceLayout.Controls.Add(this.label3);
            this.serviceLayout.Controls.Add(this.cbGroupList);
            this.serviceLayout.Controls.Add(this.btnJoinGroup);
            this.serviceLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serviceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.serviceLayout.Location = new System.Drawing.Point(3, 3);
            this.serviceLayout.Name = "serviceLayout";
            this.serviceLayout.Size = new System.Drawing.Size(359, 489);
            this.serviceLayout.TabIndex = 1;
            this.serviceLayout.WrapContents = false;
            // 
            // services
            // 
            this.services.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.ForeColor = System.Drawing.Color.White;
            this.services.Location = new System.Drawing.Point(0, 10);
            this.services.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(345, 22);
            this.services.TabIndex = 3;
            this.services.Text = "Services";
            this.services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.datePicker);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 35);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(25, 75);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(272, 34);
            this.flowLayoutPanel3.TabIndex = 16;
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
            // btnStudSetAppointment
            // 
            this.btnStudSetAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudSetAppointment.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudSetAppointment.Location = new System.Drawing.Point(28, 128);
            this.btnStudSetAppointment.Margin = new System.Windows.Forms.Padding(28, 16, 3, 3);
            this.btnStudSetAppointment.Name = "btnStudSetAppointment";
            this.btnStudSetAppointment.Size = new System.Drawing.Size(172, 23);
            this.btnStudSetAppointment.TabIndex = 5;
            this.btnStudSetAppointment.Text = "Set Appointments";
            this.btnStudSetAppointment.UseVisualStyleBackColor = true;
            this.btnStudSetAppointment.Click += new System.EventHandler(this.btnStudSetAppointment_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Other Services";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioResidence
            // 
            this.radioResidence.AutoSize = true;
            this.radioResidence.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioResidence.ForeColor = System.Drawing.Color.White;
            this.radioResidence.Location = new System.Drawing.Point(25, 202);
            this.radioResidence.Margin = new System.Windows.Forms.Padding(25, 16, 3, 3);
            this.radioResidence.Name = "radioResidence";
            this.radioResidence.Size = new System.Drawing.Size(86, 17);
            this.radioResidence.TabIndex = 7;
            this.radioResidence.TabStop = true;
            this.radioResidence.Text = "Residence";
            this.radioResidence.UseVisualStyleBackColor = true;
            this.radioResidence.CheckedChanged += new System.EventHandler(this.radioResidence_CheckedChanged);
            // 
            // radioFinancialHelp
            // 
            this.radioFinancialHelp.AutoSize = true;
            this.radioFinancialHelp.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFinancialHelp.ForeColor = System.Drawing.Color.White;
            this.radioFinancialHelp.Location = new System.Drawing.Point(25, 238);
            this.radioFinancialHelp.Margin = new System.Windows.Forms.Padding(25, 16, 3, 3);
            this.radioFinancialHelp.Name = "radioFinancialHelp";
            this.radioFinancialHelp.Size = new System.Drawing.Size(110, 17);
            this.radioFinancialHelp.TabIndex = 8;
            this.radioFinancialHelp.TabStop = true;
            this.radioFinancialHelp.Text = "Financial Help";
            this.radioFinancialHelp.UseVisualStyleBackColor = true;
            this.radioFinancialHelp.CheckedChanged += new System.EventHandler(this.radioFinancialHelp_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Groups";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select a group to join and press join group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGroupList
            // 
            this.cbGroupList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupList.FormattingEnabled = true;
            this.cbGroupList.Location = new System.Drawing.Point(25, 325);
            this.cbGroupList.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.cbGroupList.Name = "cbGroupList";
            this.cbGroupList.Size = new System.Drawing.Size(180, 21);
            this.cbGroupList.TabIndex = 14;
            this.cbGroupList.SelectedIndexChanged += new System.EventHandler(this.cbGroupList_SelectedIndexChanged);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinGroup.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGroup.Location = new System.Drawing.Point(28, 365);
            this.btnJoinGroup.Margin = new System.Windows.Forms.Padding(28, 16, 3, 3);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(172, 23);
            this.btnJoinGroup.TabIndex = 12;
            this.btnJoinGroup.Text = "Join Group";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // StudentAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "StudentAppointment";
            this.Text = "StudentAppointment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.serviceLayout.ResumeLayout(false);
            this.serviceLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStudSetAppointment;
        private System.Windows.Forms.FlowLayoutPanel serviceLayout;
        private System.Windows.Forms.Label services;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioResidence;
        private System.Windows.Forms.RadioButton radioFinancialHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGroupList;
        private System.Windows.Forms.Button btnJoinGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePicker;
    }
}
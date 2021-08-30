namespace Stuport
{
    partial class StudentMainPage
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
            this.appointmentLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.appointmentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.appointmentLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProfile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 182);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // appointmentLayout
            // 
            this.appointmentLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.appointmentLayout.Controls.Add(this.pictureBox2);
            this.appointmentLayout.Controls.Add(this.label1);
            this.appointmentLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.appointmentLayout.Location = new System.Drawing.Point(236, 3);
            this.appointmentLayout.Name = "appointmentLayout";
            this.appointmentLayout.Size = new System.Drawing.Size(227, 258);
            this.appointmentLayout.TabIndex = 2;
            this.appointmentLayout.WrapContents = false;
            this.appointmentLayout.Click += new System.EventHandler(this.appointmentLayout_Click);
            this.appointmentLayout.MouseEnter += new System.EventHandler(this.appointmentLayout_MouseEnter);
            this.appointmentLayout.MouseLeave += new System.EventHandler(this.appointmentLayout_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Stuport.Properties.Resources.PinClipart_com_reminder_images_clip_art_464107;
            this.pictureBox2.Location = new System.Drawing.Point(52, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15, 30, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.appointmentLayout_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.appointmentLayout_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.appointmentLayout_MouseLeave);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.appointmentLayout_Click);
            this.label1.MouseEnter += new System.EventHandler(this.appointmentLayout_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.appointmentLayout_MouseLeave);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.btnProfile.Controls.Add(this.pictureBox1);
            this.btnProfile.Controls.Add(this.lblStudentName);
            this.btnProfile.Controls.Add(this.lblStudEmail);
            this.btnProfile.Controls.Add(this.lblPhoneNumber);
            this.btnProfile.Controls.Add(this.label2);
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfile.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.btnProfile.Location = new System.Drawing.Point(3, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(227, 258);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.WrapContents = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Stuport.Properties.Resources.user_512;
            this.pictureBox1.Location = new System.Drawing.Point(44, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 16, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnProfile_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(0, 157);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(227, 22);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Student";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentName.Click += new System.EventHandler(this.btnProfile_Click);
            this.lblStudentName.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.lblStudentName.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // lblStudEmail
            // 
            this.lblStudEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudEmail.AutoSize = true;
            this.lblStudEmail.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudEmail.ForeColor = System.Drawing.Color.White;
            this.lblStudEmail.Location = new System.Drawing.Point(91, 189);
            this.lblStudEmail.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblStudEmail.Name = "lblStudEmail";
            this.lblStudEmail.Size = new System.Drawing.Size(44, 17);
            this.lblStudEmail.TabIndex = 6;
            this.lblStudEmail.Text = "Email";
            this.lblStudEmail.Click += new System.EventHandler(this.btnProfile_Click);
            this.lblStudEmail.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.lblStudEmail.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(63, 216);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 17);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "PhoneNumber";
            this.lblPhoneNumber.Click += new System.EventHandler(this.btnProfile_Click);
            this.lblPhoneNumber.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.lblPhoneNumber.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "(click to update profile)";
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "StudentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.appointmentLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnProfile.ResumeLayout(false);
            this.btnProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel btnProfile;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.FlowLayoutPanel appointmentLayout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStudEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
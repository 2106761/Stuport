namespace Stuport
{
    partial class Counsellors
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCounsellor = new System.Windows.Forms.Button();
            this.counsellorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTxtBoxPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.counsellorFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.3542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.6458F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.counsellorFlowLayout, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(221, 115);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 398);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtBoxFirstName);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtBoxLastName);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtBoxEmail);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.maskedTxtBoxPhoneNum);
            this.flowLayoutPanel2.Controls.Add(this.btnAddCounsellor);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(338, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(266, 392);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Counsellor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCounsellor
            // 
            this.btnAddCounsellor.Location = new System.Drawing.Point(37, 276);
            this.btnAddCounsellor.Margin = new System.Windows.Forms.Padding(37, 16, 3, 3);
            this.btnAddCounsellor.Name = "btnAddCounsellor";
            this.btnAddCounsellor.Size = new System.Drawing.Size(190, 30);
            this.btnAddCounsellor.TabIndex = 10;
            this.btnAddCounsellor.Text = "Add Counsellor";
            this.btnAddCounsellor.UseVisualStyleBackColor = true;
            this.btnAddCounsellor.Click += new System.EventHandler(this.btnAddCounsellor_Click);
            // 
            // counsellorFlowLayout
            // 
            this.counsellorFlowLayout.AutoScroll = true;
            this.counsellorFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.counsellorFlowLayout.Controls.Add(this.lblStudentName);
            this.counsellorFlowLayout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.counsellorFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counsellorFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.counsellorFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.counsellorFlowLayout.Name = "counsellorFlowLayout";
            this.counsellorFlowLayout.Size = new System.Drawing.Size(329, 392);
            this.counsellorFlowLayout.TabIndex = 1;
            this.counsellorFlowLayout.WrapContents = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(0, 10);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(310, 22);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Counsellors";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(38, 16, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "First name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(38, 66);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(190, 20);
            this.txtBoxFirstName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(38, 16, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last name:";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(38, 123);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(190, 20);
            this.txtBoxLastName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(38, 16, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(38, 180);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(190, 20);
            this.txtBoxEmail.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(38, 16, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone number:";
            // 
            // maskedTxtBoxPhoneNum
            // 
            this.maskedTxtBoxPhoneNum.Location = new System.Drawing.Point(38, 237);
            this.maskedTxtBoxPhoneNum.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.maskedTxtBoxPhoneNum.Mask = "(999) 000-0000";
            this.maskedTxtBoxPhoneNum.Name = "maskedTxtBoxPhoneNum";
            this.maskedTxtBoxPhoneNum.Size = new System.Drawing.Size(190, 20);
            this.maskedTxtBoxPhoneNum.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Counsellors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "Counsellors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counsellors";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.counsellorFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCounsellor;
        private System.Windows.Forms.FlowLayoutPanel counsellorFlowLayout;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPhoneNum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
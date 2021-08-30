namespace Stuport
{
    partial class AdminAppointments
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
            this.counsellorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.counsellorFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.3542F));
            this.tableLayoutPanel1.Controls.Add(this.counsellorFlowLayout, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 57);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(466, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 495);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // counsellorFlowLayout
            // 
            this.counsellorFlowLayout.AutoScroll = true;
            this.counsellorFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.counsellorFlowLayout.Controls.Add(this.lblStudentName);
            this.counsellorFlowLayout.Controls.Add(this.dataGridView1);
            this.counsellorFlowLayout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.counsellorFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counsellorFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.counsellorFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.counsellorFlowLayout.Name = "counsellorFlowLayout";
            this.counsellorFlowLayout.Size = new System.Drawing.Size(981, 489);
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
            this.lblStudentName.Size = new System.Drawing.Size(981, 22);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Appointments";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(975, 450);
            this.dataGridView1.TabIndex = 5;
            // 
            // AdminAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "AdminAppointments";
            this.Text = "AdminAppointments";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.counsellorFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel counsellorFlowLayout;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
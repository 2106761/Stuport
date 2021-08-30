namespace Stuport
{
    partial class StudentView
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
            this.studentFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.studentFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.3542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.6458F));
            this.tableLayoutPanel1.Controls.Add(this.studentFlowLayout, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(371, 44);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(304, 420);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 539);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // studentFlowLayout
            // 
            this.studentFlowLayout.AutoScroll = true;
            this.studentFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(29)))), ((int)(((byte)(78)))));
            this.studentFlowLayout.Controls.Add(this.lblStudentName);
            this.studentFlowLayout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.studentFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.studentFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.studentFlowLayout.Name = "studentFlowLayout";
            this.studentFlowLayout.Size = new System.Drawing.Size(366, 533);
            this.studentFlowLayout.TabIndex = 1;
            this.studentFlowLayout.WrapContents = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(20, 10);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(305, 22);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Students";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stuport.Properties.Resources._1251284;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1064, 668);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.studentFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel studentFlowLayout;
        private System.Windows.Forms.Label lblStudentName;
    }
}
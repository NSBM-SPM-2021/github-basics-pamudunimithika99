﻿namespace LeaveManagementSystem1._1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsFind = new System.Windows.Forms.ToolStripButton();
            this.tsLeave = new System.Windows.Forms.ToolStripButton();
            this.tsMaintenance = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsFind,
            this.tsLeave,
            this.tsMaintenance,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(158, 872);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEmployee
            // 
            this.tsEmployee.ForeColor = System.Drawing.Color.Black;
            this.tsEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsEmployee.Image")));
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(149, 119);
            this.tsEmployee.Text = "Employees";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsFind
            // 
            this.tsFind.ForeColor = System.Drawing.Color.Black;
            this.tsFind.Image = ((System.Drawing.Image)(resources.GetObject("tsFind.Image")));
            this.tsFind.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsFind.Name = "tsFind";
            this.tsFind.Size = new System.Drawing.Size(141, 119);
            this.tsFind.Text = "Find Employees";
            this.tsFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFind.Click += new System.EventHandler(this.tsFind_Click);
            // 
            // tsLeave
            // 
            this.tsLeave.ForeColor = System.Drawing.Color.Black;
            this.tsLeave.Image = ((System.Drawing.Image)(resources.GetObject("tsLeave.Image")));
            this.tsLeave.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsLeave.Name = "tsLeave";
            this.tsLeave.Size = new System.Drawing.Size(154, 119);
            this.tsLeave.Text = "Leave of Absence";
            this.tsLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLeave.Click += new System.EventHandler(this.tsLeave_Click);
            // 
            // tsMaintenance
            // 
            this.tsMaintenance.ForeColor = System.Drawing.Color.Black;
            this.tsMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("tsMaintenance.Image")));
            this.tsMaintenance.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsMaintenance.Name = "tsMaintenance";
            this.tsMaintenance.Size = new System.Drawing.Size(116, 119);
            this.tsMaintenance.Text = "Maintenance";
            this.tsMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsMaintenance.Click += new System.EventHandler(this.tsMaintenance_Click);
            // 
            // tsUser
            // 
            this.tsUser.ForeColor = System.Drawing.Color.Black;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(128, 119);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.ForeColor = System.Drawing.Color.Black;
            this.tsLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsLogin.Image")));
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(94, 119);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(187, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(177, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(605, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(174, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1852, 872);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Management System | Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsEmployee;
        private System.Windows.Forms.ToolStripButton tsLeave;
        private System.Windows.Forms.ToolStripButton tsMaintenance;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}


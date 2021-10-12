namespace LeaveManagementSystem1._1
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
            this.tsLeave = new System.Windows.Forms.ToolStripButton();
            this.tsMaintenance = new System.Windows.Forms.ToolStripButton();
            this.tsFind = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
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
            this.tsLeave,
            this.tsMaintenance,
            this.tsFind,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(212, 872);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsEmployee
            // 
            this.tsEmployee.BackColor = System.Drawing.Color.Transparent;
            this.tsEmployee.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEmployee.ForeColor = System.Drawing.Color.White;
            this.tsEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsEmployee.Image")));
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(203, 122);
            this.tsEmployee.Text = "Employees";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsLeave
            // 
            this.tsLeave.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLeave.ForeColor = System.Drawing.Color.White;
            this.tsLeave.Image = ((System.Drawing.Image)(resources.GetObject("tsLeave.Image")));
            this.tsLeave.ImageTransparentColor = System.Drawing.Color.White;
            this.tsLeave.Name = "tsLeave";
            this.tsLeave.Size = new System.Drawing.Size(203, 122);
            this.tsLeave.Text = "Leave of Absence";
            this.tsLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsLeave.Click += new System.EventHandler(this.tsLeave_Click);
            // 
            // tsMaintenance
            // 
            this.tsMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.tsMaintenance.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMaintenance.ForeColor = System.Drawing.Color.White;
            this.tsMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("tsMaintenance.Image")));
            this.tsMaintenance.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsMaintenance.Name = "tsMaintenance";
            this.tsMaintenance.Size = new System.Drawing.Size(203, 122);
            this.tsMaintenance.Text = "Maintenance";
            this.tsMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsMaintenance.Click += new System.EventHandler(this.tsMaintenance_Click);
            // 
            // tsFind
            // 
            this.tsFind.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFind.ForeColor = System.Drawing.Color.White;
            this.tsFind.Image = ((System.Drawing.Image)(resources.GetObject("tsFind.Image")));
            this.tsFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsFind.Name = "tsFind";
            this.tsFind.Size = new System.Drawing.Size(203, 122);
            this.tsFind.Text = "Find Employees";
            this.tsFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsFind.Click += new System.EventHandler(this.tsFind_Click);
            // 
            // tsUser
            // 
            this.tsUser.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsUser.ForeColor = System.Drawing.Color.White;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(203, 122);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.BackColor = System.Drawing.Color.Transparent;
            this.tsLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsLogin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.tsLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsLogin.Image")));
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsLogin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.tsLogin.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(203, 127);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // timer1
            // 
<<<<<<< HEAD
           
=======
<<<<<<< HEAD
=======
           
>>>>>>> main
>>>>>>> main
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1852, 872);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Management System | Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
    }
}


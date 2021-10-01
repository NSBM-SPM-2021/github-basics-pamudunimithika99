namespace LeaveManagementSystem1._1
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstripList = new System.Windows.Forms.ToolStripButton();
            this.tstripAdd = new System.Windows.Forms.ToolStripButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.chkShowpass = new System.Windows.Forms.CheckBox();
            this.txtrpass = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.ToolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripList,
            this.tstripAdd});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStrip1.Size = new System.Drawing.Size(938, 57);
            this.ToolStrip1.TabIndex = 7;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tstripList
            // 
            this.tstripList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstripList.BackgroundImage")));
            this.tstripList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tstripList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstripList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstripList.Image = ((System.Drawing.Image)(resources.GetObject("tstripList.Image")));
            this.tstripList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripList.Name = "tstripList";
            this.tstripList.Size = new System.Drawing.Size(34, 52);
            this.tstripList.Text = "List";
            this.tstripList.Click += new System.EventHandler(this.tstripList_Click);
            // 
            // tstripAdd
            // 
            this.tstripAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstripAdd.BackgroundImage")));
            this.tstripAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tstripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstripAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstripAdd.Image = ((System.Drawing.Image)(resources.GetObject("tstripAdd.Image")));
            this.tstripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripAdd.Name = "tstripAdd";
            this.tstripAdd.Size = new System.Drawing.Size(34, 52);
            this.tstripAdd.Text = "Add User";
            this.tstripAdd.Click += new System.EventHandler(this.tstripAdd_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txtsearch);
            this.Panel1.Controls.Add(this.btnUpdate);
            this.Panel1.Controls.Add(this.btndelete);
            this.Panel1.Controls.Add(this.dtglist);
            this.Panel1.Location = new System.Drawing.Point(18, 323);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(907, 328);
            this.Panel1.TabIndex = 8;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(780, 189);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 46);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(16, 11);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(333, 61);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "List of Users";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(22, 477);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Search :";
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(123, 482);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(646, 39);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(780, 78);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 46);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(780, 134);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 46);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(27, 78);
            this.dtglist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.RowHeadersWidth = 62;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(744, 394);
            this.dtglist.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.lblTitle);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.btnsave);
            this.Panel2.Location = new System.Drawing.Point(18, 103);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(54, 116);
            this.Panel2.TabIndex = 9;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(160, 454);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(129, 69);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 61);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New User";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.chkShowpass);
            this.GroupBox1.Controls.Add(this.txtrpass);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtusername);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtname);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.cboType);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(16, 77);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(746, 368);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "User Information";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(33, 268);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(188, 24);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Retype Password :";
            // 
            // chkShowpass
            // 
            this.chkShowpass.AutoSize = true;
            this.chkShowpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowpass.Location = new System.Drawing.Point(226, 215);
            this.chkShowpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowpass.Name = "chkShowpass";
            this.chkShowpass.Size = new System.Drawing.Size(187, 28);
            this.chkShowpass.TabIndex = 12;
            this.chkShowpass.Text = "Show Password";
            this.chkShowpass.UseVisualStyleBackColor = true;
            // 
            // txtrpass
            // 
            this.txtrpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrpass.Location = new System.Drawing.Point(226, 258);
            this.txtrpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrpass.Name = "txtrpass";
            this.txtrpass.Size = new System.Drawing.Size(462, 30);
            this.txtrpass.TabIndex = 6;
            this.txtrpass.UseSystemPasswordChar = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(33, 182);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(116, 24);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Password :";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(226, 172);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(462, 30);
            this.txtpass.TabIndex = 8;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(33, 138);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 24);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Username :";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(226, 129);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(462, 30);
            this.txtusername.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(33, 95);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 24);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(226, 86);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(462, 30);
            this.txtname.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 52);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "User Id :";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(226, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(292, 30);
            this.txtId.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(36, 306);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(119, 24);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "User Type :";
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Administrator",
            "HR Personnel"});
            this.cboType.Location = new System.Drawing.Point(226, 302);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(462, 32);
            this.cboType.TabIndex = 10;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(16, 454);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 69);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 654);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tstripList;
        internal System.Windows.Forms.ToolStripButton tstripAdd;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox chkShowpass;
        internal System.Windows.Forms.TextBox txtrpass;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.Button btnsave;
    }
}
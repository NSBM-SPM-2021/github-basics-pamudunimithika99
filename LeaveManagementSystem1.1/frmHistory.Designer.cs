namespace LeaveManagementSystem1._1
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtapprovesearch = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtremainingdays = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtgapprovedlist = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbalanceleave = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtnodaysapplied = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgapprovedlist)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(18, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(550, 61);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "List of Pending Leave";
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(178, 40);
            this.Label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(86, 25);
            this.Label46.TabIndex = 25;
            this.Label46.Text = "Search :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(874, 54);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(86, 25);
            this.Label7.TabIndex = 64;
            this.Label7.Text = "Search :";
            // 
            // txtapprovesearch
            // 
            this.txtapprovesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapprovesearch.Location = new System.Drawing.Point(975, 35);
            this.txtapprovesearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapprovesearch.Multiline = true;
            this.txtapprovesearch.Name = "txtapprovesearch";
            this.txtapprovesearch.Size = new System.Drawing.Size(349, 39);
            this.txtapprovesearch.TabIndex = 63;
            this.txtapprovesearch.TextChanged += new System.EventHandler(this.txtapprovesearch_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 14);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(687, 73);
            this.Label6.TabIndex = 62;
            this.Label6.Text = "List of Approved Leave";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(33, 123);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(202, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Number of days applied for:";
            // 
            // txtempname
            // 
            this.txtempname.Enabled = false;
            this.txtempname.Location = new System.Drawing.Point(248, 31);
            this.txtempname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(487, 26);
            this.txtempname.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(39, 165);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(199, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Remaining day(s) of leave :";
            // 
            // txtremainingdays
            // 
            this.txtremainingdays.Enabled = false;
            this.txtremainingdays.Location = new System.Drawing.Point(248, 160);
            this.txtremainingdays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtremainingdays.Name = "txtremainingdays";
            this.txtremainingdays.Size = new System.Drawing.Size(487, 26);
            this.txtremainingdays.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(92, 35);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Employee\'s Name : ";
            // 
            // dtgapprovedlist
            // 
            this.dtgapprovedlist.AllowUserToAddRows = false;
            this.dtgapprovedlist.AllowUserToDeleteRows = false;
            this.dtgapprovedlist.AllowUserToResizeColumns = false;
            this.dtgapprovedlist.AllowUserToResizeRows = false;
            this.dtgapprovedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgapprovedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgapprovedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgapprovedlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgapprovedlist.Location = new System.Drawing.Point(8, 98);
            this.dtgapprovedlist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtgapprovedlist.Name = "dtgapprovedlist";
            this.dtgapprovedlist.RowHeadersWidth = 62;
            this.dtgapprovedlist.RowTemplate.Height = 24;
            this.dtgapprovedlist.Size = new System.Drawing.Size(1318, 652);
            this.dtgapprovedlist.TabIndex = 61;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(18, 372);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(136, 58);
            this.btnApprove.TabIndex = 56;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(164, 372);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 58);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtbalanceleave
            // 
            this.txtbalanceleave.Enabled = false;
            this.txtbalanceleave.Location = new System.Drawing.Point(248, 71);
            this.txtbalanceleave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbalanceleave.Name = "txtbalanceleave";
            this.txtbalanceleave.Size = new System.Drawing.Size(487, 26);
            this.txtbalanceleave.TabIndex = 7;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(48, 75);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(193, 20);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Balance of days(s)  leave :";
            // 
            // txtnodaysapplied
            // 
            this.txtnodaysapplied.Location = new System.Drawing.Point(248, 118);
            this.txtnodaysapplied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnodaysapplied.Name = "txtnodaysapplied";
            this.txtnodaysapplied.Size = new System.Drawing.Size(487, 26);
            this.txtnodaysapplied.TabIndex = 5;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtbalanceleave);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtnodaysapplied);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtempname);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtremainingdays);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label46);
            this.GroupBox1.Location = new System.Drawing.Point(696, 111);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(232, 106);
            this.GroupBox1.TabIndex = 60;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Set the number of leave to the employee";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(186, 562);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(270, 58);
            this.Button2.TabIndex = 66;
            this.Button2.Text = "Print to Preview";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // txtempsearch
            // 
            this.txtempsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsearch.Location = new System.Drawing.Point(944, 186);
            this.txtempsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtempsearch.Multiline = true;
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(349, 41);
            this.txtempsearch.TabIndex = 54;
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.Location = new System.Drawing.Point(8, 111);
            this.dtgemplist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.RowHeadersWidth = 62;
            this.dtgemplist.RowTemplate.Height = 24;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(1308, 265);
            this.dtgemplist.TabIndex = 53;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnview.Location = new System.Drawing.Point(944, 668);
            this.btnview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(134, 58);
            this.btnview.TabIndex = 58;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(519, 598);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(270, 58);
            this.btnadd.TabIndex = 65;
            this.btnadd.Text = "Application Form";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(798, 598);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(165, 58);
            this.Button1.TabIndex = 59;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1358, 771);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtapprovesearch);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtgapprovedlist);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txtempsearch);
            this.Controls.Add(this.dtgemplist);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History Form";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgapprovedlist)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtapprovesearch;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtempname;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtremainingdays;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dtgapprovedlist;
        internal System.Windows.Forms.Button btnApprove;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtbalanceleave;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtnodaysapplied;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.Button btnview;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Button Button1;
    }
}
namespace LeaveManagementSystem1._1
{
    partial class frmMaintenance
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
            this.dtgdeptlist = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpositionload = new System.Windows.Forms.Button();
            this.dtglistposition = new System.Windows.Forms.DataGridView();
            this.npositiondelete = new System.Windows.Forms.Button();
            this.npositionupdate = new System.Windows.Forms.Button();
            this.npositionsave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btndeptLoad = new System.Windows.Forms.Button();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btndeptDelete = new System.Windows.Forms.Button();
            this.btndeptUpdate = new System.Windows.Forms.Button();
            this.btndeptSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdeptlist)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistposition)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgdeptlist
            // 
            this.dtgdeptlist.AllowUserToAddRows = false;
            this.dtgdeptlist.AllowUserToDeleteRows = false;
            this.dtgdeptlist.AllowUserToResizeColumns = false;
            this.dtgdeptlist.AllowUserToResizeRows = false;
            this.dtgdeptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgdeptlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgdeptlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgdeptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdeptlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgdeptlist.Location = new System.Drawing.Point(9, 94);
            this.dtgdeptlist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtgdeptlist.Name = "dtgdeptlist";
            this.dtgdeptlist.RowHeadersWidth = 62;
            this.dtgdeptlist.Size = new System.Drawing.Size(370, 446);
            this.dtgdeptlist.TabIndex = 1;
            this.dtgdeptlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdeptlist_CellClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox1.Controls.Add(this.btnpositionload);
            this.GroupBox1.Controls.Add(this.dtglistposition);
            this.GroupBox1.Controls.Add(this.npositiondelete);
            this.GroupBox1.Controls.Add(this.npositionupdate);
            this.GroupBox1.Controls.Add(this.npositionsave);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtposition);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(18, 20);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox1.Size = new System.Drawing.Size(477, 552);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Position of the Employee";
            // 
            // btnpositionload
            // 
            this.btnpositionload.BackColor = System.Drawing.SystemColors.Info;
            this.btnpositionload.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpositionload.Location = new System.Drawing.Point(356, 168);
            this.btnpositionload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnpositionload.Name = "btnpositionload";
            this.btnpositionload.Size = new System.Drawing.Size(112, 62);
            this.btnpositionload.TabIndex = 6;
            this.btnpositionload.Text = "Load";
            this.btnpositionload.UseVisualStyleBackColor = false;
            this.btnpositionload.Click += new System.EventHandler(this.btnpositionload_Click);
            // 
            // dtglistposition
            // 
            this.dtglistposition.AllowUserToAddRows = false;
            this.dtglistposition.AllowUserToDeleteRows = false;
            this.dtglistposition.AllowUserToResizeColumns = false;
            this.dtglistposition.AllowUserToResizeRows = false;
            this.dtglistposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglistposition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglistposition.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtglistposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglistposition.Location = new System.Drawing.Point(9, 94);
            this.dtglistposition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtglistposition.Name = "dtglistposition";
            this.dtglistposition.RowHeadersWidth = 62;
            this.dtglistposition.Size = new System.Drawing.Size(338, 446);
            this.dtglistposition.TabIndex = 1;
            this.dtglistposition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistposition_CellClick);
            // 
            // npositiondelete
            // 
            this.npositiondelete.BackColor = System.Drawing.SystemColors.Info;
            this.npositiondelete.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositiondelete.Location = new System.Drawing.Point(356, 315);
            this.npositiondelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.npositiondelete.Name = "npositiondelete";
            this.npositiondelete.Size = new System.Drawing.Size(112, 62);
            this.npositiondelete.TabIndex = 5;
            this.npositiondelete.Text = "Delete";
            this.npositiondelete.UseVisualStyleBackColor = false;
            this.npositiondelete.Click += new System.EventHandler(this.npositiondelete_Click);
            // 
            // npositionupdate
            // 
            this.npositionupdate.BackColor = System.Drawing.SystemColors.Info;
            this.npositionupdate.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositionupdate.Location = new System.Drawing.Point(356, 242);
            this.npositionupdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.npositionupdate.Name = "npositionupdate";
            this.npositionupdate.Size = new System.Drawing.Size(112, 62);
            this.npositionupdate.TabIndex = 4;
            this.npositionupdate.Text = "Update";
            this.npositionupdate.UseVisualStyleBackColor = false;
            this.npositionupdate.Click += new System.EventHandler(this.npositionupdate_Click);
            // 
            // npositionsave
            // 
            this.npositionsave.BackColor = System.Drawing.SystemColors.Info;
            this.npositionsave.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositionsave.Location = new System.Drawing.Point(356, 94);
            this.npositionsave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.npositionsave.Name = "npositionsave";
            this.npositionsave.Size = new System.Drawing.Size(112, 62);
            this.npositionsave.TabIndex = 3;
            this.npositionsave.Text = "Save";
            this.npositionsave.UseVisualStyleBackColor = false;
            this.npositionsave.Click += new System.EventHandler(this.npositionsave_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(9, 46);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Position :";
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(118, 42);
            this.txtposition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtposition.Multiline = true;
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(348, 38);
            this.txtposition.TabIndex = 2;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox2.Controls.Add(this.btndeptLoad);
            this.GroupBox2.Controls.Add(this.dtgdeptlist);
            this.GroupBox2.Controls.Add(this.txtdepartment);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btndeptDelete);
            this.GroupBox2.Controls.Add(this.btndeptUpdate);
            this.GroupBox2.Controls.Add(this.btndeptSave);
            this.GroupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(519, 20);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox2.Size = new System.Drawing.Size(510, 552);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Department of the Employee";
            // 
            // btndeptLoad
            // 
            this.btndeptLoad.BackColor = System.Drawing.SystemColors.Info;
            this.btndeptLoad.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptLoad.Location = new System.Drawing.Point(388, 168);
            this.btndeptLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndeptLoad.Name = "btndeptLoad";
            this.btndeptLoad.Size = new System.Drawing.Size(112, 62);
            this.btndeptLoad.TabIndex = 6;
            this.btndeptLoad.Text = "Load";
            this.btndeptLoad.UseVisualStyleBackColor = false;
            this.btndeptLoad.Click += new System.EventHandler(this.btndeptLoad_Click);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(171, 42);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(314, 38);
            this.txtdepartment.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(27, 46);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Department :";
            // 
            // btndeptDelete
            // 
            this.btndeptDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btndeptDelete.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptDelete.Location = new System.Drawing.Point(388, 315);
            this.btndeptDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndeptDelete.Name = "btndeptDelete";
            this.btndeptDelete.Size = new System.Drawing.Size(112, 62);
            this.btndeptDelete.TabIndex = 5;
            this.btndeptDelete.Text = "Delete";
            this.btndeptDelete.UseVisualStyleBackColor = false;
            this.btndeptDelete.Click += new System.EventHandler(this.btndeptDelete_Click);
            // 
            // btndeptUpdate
            // 
            this.btndeptUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btndeptUpdate.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptUpdate.Location = new System.Drawing.Point(388, 242);
            this.btndeptUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndeptUpdate.Name = "btndeptUpdate";
            this.btndeptUpdate.Size = new System.Drawing.Size(112, 62);
            this.btndeptUpdate.TabIndex = 4;
            this.btndeptUpdate.Text = "Update";
            this.btndeptUpdate.UseVisualStyleBackColor = false;
            this.btndeptUpdate.Click += new System.EventHandler(this.btndeptUpdate_Click);
            // 
            // btndeptSave
            // 
            this.btndeptSave.BackColor = System.Drawing.SystemColors.Info;
            this.btndeptSave.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptSave.Location = new System.Drawing.Point(388, 94);
            this.btndeptSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndeptSave.Name = "btndeptSave";
            this.btndeptSave.Size = new System.Drawing.Size(112, 62);
            this.btndeptSave.TabIndex = 3;
            this.btndeptSave.Text = "Save";
            this.btndeptSave.UseVisualStyleBackColor = false;
            this.btndeptSave.Click += new System.EventHandler(this.btndeptSave_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1044, 594);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Form";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdeptlist)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistposition)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgdeptlist;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnpositionload;
        internal System.Windows.Forms.DataGridView dtglistposition;
        internal System.Windows.Forms.Button npositiondelete;
        internal System.Windows.Forms.Button npositionupdate;
        internal System.Windows.Forms.Button npositionsave;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btndeptLoad;
        internal System.Windows.Forms.TextBox txtdepartment;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btndeptDelete;
        internal System.Windows.Forms.Button btndeptUpdate;
        internal System.Windows.Forms.Button btndeptSave;
    }
}
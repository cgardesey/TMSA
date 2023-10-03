namespace TMSA
{
    partial class frmBackupAndRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupAndRestore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupLocBrowse = new System.Windows.Forms.Button();
            this.backupLocTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestoreLocBrowse = new System.Windows.Forms.Button();
            this.restoreLoctextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBackupLocBrowse);
            this.groupBox1.Controls.Add(this.backupLocTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(19, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database backup";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Location = new System.Drawing.Point(401, 63);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupLocBrowse
            // 
            this.btnBackupLocBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackupLocBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupLocBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackupLocBrowse.Location = new System.Drawing.Point(401, 34);
            this.btnBackupLocBrowse.Name = "btnBackupLocBrowse";
            this.btnBackupLocBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBackupLocBrowse.TabIndex = 2;
            this.btnBackupLocBrowse.Text = "Browse";
            this.btnBackupLocBrowse.UseVisualStyleBackColor = false;
            this.btnBackupLocBrowse.Click += new System.EventHandler(this.btnBackupLocBrowse_Click);
            // 
            // backupLocTextBox
            // 
            this.backupLocTextBox.Location = new System.Drawing.Point(90, 41);
            this.backupLocTextBox.Name = "backupLocTextBox";
            this.backupLocTextBox.Size = new System.Drawing.Size(288, 20);
            this.backupLocTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnRestoreLocBrowse);
            this.groupBox2.Controls.Add(this.restoreLoctextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(19, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database restore";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestore.Location = new System.Drawing.Point(401, 63);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestoreLocBrowse
            // 
            this.btnRestoreLocBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestoreLocBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreLocBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestoreLocBrowse.Location = new System.Drawing.Point(401, 34);
            this.btnRestoreLocBrowse.Name = "btnRestoreLocBrowse";
            this.btnRestoreLocBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreLocBrowse.TabIndex = 2;
            this.btnRestoreLocBrowse.Text = "Browse";
            this.btnRestoreLocBrowse.UseVisualStyleBackColor = false;
            this.btnRestoreLocBrowse.Click += new System.EventHandler(this.btnRestoreLocBrowse_Click);
            // 
            // restoreLoctextBox
            // 
            this.restoreLoctextBox.Location = new System.Drawing.Point(90, 41);
            this.restoreLoctextBox.Name = "restoreLoctextBox";
            this.restoreLoctextBox.Size = new System.Drawing.Size(288, 20);
            this.restoreLoctextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL Server Database Backup and Restore      ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(469, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 174;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmBackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(536, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackupAndRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup and Restore";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BackupAndRestore_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBackupLocBrowse;
        private System.Windows.Forms.TextBox backupLocTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestoreLocBrowse;
        private System.Windows.Forms.TextBox restoreLoctextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnMinimize;
    }
}
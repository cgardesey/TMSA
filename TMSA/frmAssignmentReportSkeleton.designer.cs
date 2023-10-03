namespace TMSA
{
    partial class frmAssignmentsReportSkeleton
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
            System.Windows.Forms.Label Label1;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.assignment_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TMSADataSet = new TMSA.TMSADataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToMask = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFromMask = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.assignment_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.assignment_viewTableAdapter();
            this.tmsaDataSet1 = new TMSA.TMSADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMSADataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmsaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.White;
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.Location = new System.Drawing.Point(1, 1);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(344, 48);
            Label1.TabIndex = 157;
            Label1.Text = "  Assignments Report";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown_1);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove_1);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp_1);
            // 
            // assignment_viewBindingSource
            // 
            this.assignment_viewBindingSource.DataMember = "assignment_view";
            this.assignment_viewBindingSource.DataSource = this.TMSADataSet;
            // 
            // TMSADataSet
            // 
            this.TMSADataSet.DataSetName = "TMSADataSet";
            this.TMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 695);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(345, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 695);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 696);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(297, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 339;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 111);
            this.panel6.TabIndex = 341;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbToMask);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFromMask);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 108);
            this.groupBox1.TabIndex = 195;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Week starting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 349;
            this.label2.Text = "to:";
            // 
            // tbToMask
            // 
            this.tbToMask.BackColor = System.Drawing.Color.White;
            this.tbToMask.ForeColor = System.Drawing.Color.White;
            this.tbToMask.Location = new System.Drawing.Point(65, 43);
            this.tbToMask.Name = "tbToMask";
            this.tbToMask.Size = new System.Drawing.Size(199, 23);
            this.tbToMask.TabIndex = 348;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(65, 43);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.toDateTimePicker.TabIndex = 347;
            this.toDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.CloseUp += new System.EventHandler(this.toDateTimePicker_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 345;
            this.label4.Text = "from:";
            // 
            // tbFromMask
            // 
            this.tbFromMask.BackColor = System.Drawing.Color.White;
            this.tbFromMask.ForeColor = System.Drawing.Color.White;
            this.tbFromMask.Location = new System.Drawing.Point(65, 19);
            this.tbFromMask.Name = "tbFromMask";
            this.tbFromMask.Size = new System.Drawing.Size(199, 23);
            this.tbFromMask.TabIndex = 346;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(65, 19);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.fromDateTimePicker.TabIndex = 344;
            this.fromDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.CloseUp += new System.EventHandler(this.fromDateTimePicker_CloseUp);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Orange;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(174, 68);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(89, 28);
            this.btnClearFilter.TabIndex = 343;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Orange;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(79, 68);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 28);
            this.btnFilter.TabIndex = 342;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(377, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(9, 24);
            this.textBox1.TabIndex = 159;
            this.textBox1.Text = "        Filter by InvoiceID, Drug, Customer, User";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 80);
            this.panel5.TabIndex = 342;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(25, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 57);
            this.groupBox2.TabIndex = 195;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by publisher name";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(21, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 23);
            this.txtSearch.TabIndex = 159;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // assignment_viewTableAdapter
            // 
            this.assignment_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tmsaDataSet1
            // 
            this.tmsaDataSet1.DataSetName = "TMSADataSet";
            this.tmsaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.assignment_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMSA.AssignmentReportSkeleton.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 240);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(344, 456);
            this.reportViewer1.TabIndex = 343;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAssignmentsReportSkeleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(346, 697);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(Label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssignmentsReportSkeleton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAssignmentsReportSkeleton_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeeReport_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMSADataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmsaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource assignment_viewBindingSource;
        private TMSADataSet TMSADataSet;
        private TMSADataSetTableAdapters.assignment_viewTableAdapter assignment_viewTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private TMSADataSet tmsaDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToMask;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFromMask;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
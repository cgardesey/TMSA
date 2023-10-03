namespace TMSA
{
    partial class frmTabularAssignmentsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.assignment_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchAssistantName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchPublisherName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToMask = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFromMask = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assignmentviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.assignment_viewTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentviewBindingSource)).BeginInit();
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
            Label1.Size = new System.Drawing.Size(1004, 48);
            Label1.TabIndex = 156;
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown_1);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove_1);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp_1);
            // 
            // assignment_viewBindingSource
            // 
            this.assignment_viewBindingSource.DataMember = "assignment_view";
            this.assignment_viewBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Orange;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1, 720);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Orange;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1005, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1, 720);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 150);
            this.panel3.TabIndex = 158;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtSearchAssistantName);
            this.groupBox3.Location = new System.Drawing.Point(478, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 57);
            this.groupBox3.TabIndex = 196;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter by assistant name";
            // 
            // txtSearchAssistantName
            // 
            this.txtSearchAssistantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchAssistantName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAssistantName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchAssistantName.Location = new System.Drawing.Point(21, 22);
            this.txtSearchAssistantName.Multiline = true;
            this.txtSearchAssistantName.Name = "txtSearchAssistantName";
            this.txtSearchAssistantName.Size = new System.Drawing.Size(252, 23);
            this.txtSearchAssistantName.TabIndex = 159;
            this.txtSearchAssistantName.TextChanged += new System.EventHandler(this.txtSearchAssistantName_TextChanged);
            this.txtSearchAssistantName.Enter += new System.EventHandler(this.txtSearchAssistantName_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtSearchPublisherName);
            this.groupBox2.Location = new System.Drawing.Point(145, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 57);
            this.groupBox2.TabIndex = 195;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by publisher name";
            // 
            // txtSearchPublisherName
            // 
            this.txtSearchPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPublisherName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPublisherName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchPublisherName.Location = new System.Drawing.Point(21, 22);
            this.txtSearchPublisherName.Multiline = true;
            this.txtSearchPublisherName.Name = "txtSearchPublisherName";
            this.txtSearchPublisherName.Size = new System.Drawing.Size(252, 23);
            this.txtSearchPublisherName.TabIndex = 159;
            this.txtSearchPublisherName.TextChanged += new System.EventHandler(this.txtSearchPublisherName_TextChanged);
            this.txtSearchPublisherName.Enter += new System.EventHandler(this.txtSearchPublisherName_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbToMask);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFromMask);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(80, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 49);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Week starting:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Orange;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(740, 14);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(89, 28);
            this.btnClearFilter.TabIndex = 354;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Orange;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(645, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 28);
            this.btnFilter.TabIndex = 353;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(384, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 352;
            this.label2.Text = "to:";
            // 
            // tbToMask
            // 
            this.tbToMask.BackColor = System.Drawing.Color.White;
            this.tbToMask.ForeColor = System.Drawing.Color.White;
            this.tbToMask.Location = new System.Drawing.Point(417, 17);
            this.tbToMask.Name = "tbToMask";
            this.tbToMask.Size = new System.Drawing.Size(199, 23);
            this.tbToMask.TabIndex = 351;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(417, 17);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.toDateTimePicker.TabIndex = 350;
            this.toDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.CloseUp += new System.EventHandler(this.toDateTimePicker_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 348;
            this.label4.Text = "from:";
            // 
            // tbFromMask
            // 
            this.tbFromMask.BackColor = System.Drawing.Color.White;
            this.tbFromMask.ForeColor = System.Drawing.Color.White;
            this.tbFromMask.Location = new System.Drawing.Point(119, 17);
            this.tbFromMask.Name = "tbFromMask";
            this.tbFromMask.Size = new System.Drawing.Size(199, 23);
            this.tbFromMask.TabIndex = 349;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(119, 17);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(217, 23);
            this.fromDateTimePicker.TabIndex = 347;
            this.fromDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.CloseUp += new System.EventHandler(this.fromDateTimePicker_CloseUp);
            // 
            // assignmentviewBindingSource
            // 
            this.assignmentviewBindingSource.DataMember = "assignment_view";
            this.assignmentviewBindingSource.DataSource = this.tMSADataSet;
            // 
            // assignment_viewTableAdapter
            // 
            this.assignment_viewTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(966, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 339;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.assignment_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TMSA.TabularAssignmentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 199);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1004, 520);
            this.reportViewer1.TabIndex = 340;
            this.reportViewer1.Hyperlink += new Microsoft.Reporting.WinForms.HyperlinkEventHandler(this.reportViewer1_Hyperlink);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTabularAssignmentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 720);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(Label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTabularAssignmentsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTabularAssignmentsReport_FormClosed);
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private TMSA.TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource assignmentviewBindingSource;
        private TMSA.TMSADataSetTableAdapters.assignment_viewTableAdapter assignment_viewTableAdapter;
        private System.Windows.Forms.BindingSource assignment_viewBindingSource;
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFromMask;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToMask;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearchAssistantName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchPublisherName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
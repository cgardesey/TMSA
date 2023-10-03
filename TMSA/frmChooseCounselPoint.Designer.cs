namespace TMSA
{
    partial class frmChooseCounselPoint
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
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label study_numberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseCounselPoint));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.getPublisherCounselPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.study_numberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.getPublisherCounselPointsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getPublisherCounselPointsTableAdapter = new TMSA.TMSADataSetTableAdapters.GetPublisherCounselPointsTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.getPublisherCounselPointsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counselpointidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isreadingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdemonstrationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdiscourseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            countLabel = new System.Windows.Forms.Label();
            study_numberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsBindingNavigator)).BeginInit();
            this.getPublisherCounselPointsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(54, 167);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 25;
            countLabel.Text = "Count:";
            this.toolTip1.SetToolTip(countLabel, "Number of times publisher has completed assignment for the selected study number");
            // 
            // study_numberLabel
            // 
            study_numberLabel.AutoSize = true;
            study_numberLabel.Location = new System.Drawing.Point(54, 129);
            study_numberLabel.Name = "study_numberLabel";
            study_numberLabel.Size = new System.Drawing.Size(75, 13);
            study_numberLabel.TabIndex = 29;
            study_numberLabel.Text = "Study number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(54, 204);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 31;
            descriptionLabel.Text = "Description:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(countLabel);
            this.splitContainer1.Panel1.Controls.Add(this.countTextBox);
            this.splitContainer1.Panel1.Controls.Add(study_numberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.study_numberTextBox);
            this.splitContainer1.Panel1.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.btnDone);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(689, 505);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getPublisherCounselPointsBindingSource, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(146, 159);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(104, 20);
            this.countTextBox.TabIndex = 26;
            // 
            // getPublisherCounselPointsBindingSource
            // 
            this.getPublisherCounselPointsBindingSource.DataMember = "GetPublisherCounselPoints";
            this.getPublisherCounselPointsBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // study_numberTextBox
            // 
            this.study_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getPublisherCounselPointsBindingSource, "study_number", true));
            this.study_numberTextBox.Location = new System.Drawing.Point(146, 126);
            this.study_numberTextBox.Name = "study_numberTextBox";
            this.study_numberTextBox.ReadOnly = true;
            this.study_numberTextBox.Size = new System.Drawing.Size(104, 20);
            this.study_numberTextBox.TabIndex = 30;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getPublisherCounselPointsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(146, 192);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 60);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(175, 452);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 25;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.getPublisherCounselPointsDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(418, 505);
            this.splitContainer2.SplitterDistance = 122;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(62, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 57);
            this.groupBox2.TabIndex = 194;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by counsel point description";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(22, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 173;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            // 
            // getPublisherCounselPointsDataGridView
            // 
            this.getPublisherCounselPointsDataGridView.AllowUserToAddRows = false;
            this.getPublisherCounselPointsDataGridView.AllowUserToDeleteRows = false;
            this.getPublisherCounselPointsDataGridView.AllowUserToResizeColumns = false;
            this.getPublisherCounselPointsDataGridView.AllowUserToResizeRows = false;
            this.getPublisherCounselPointsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.getPublisherCounselPointsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.getPublisherCounselPointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getPublisherCounselPointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3});
            this.getPublisherCounselPointsDataGridView.DataSource = this.getPublisherCounselPointsBindingSource;
            this.getPublisherCounselPointsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getPublisherCounselPointsDataGridView.Location = new System.Drawing.Point(30, 0);
            this.getPublisherCounselPointsDataGridView.Name = "getPublisherCounselPointsDataGridView";
            this.getPublisherCounselPointsDataGridView.ReadOnly = true;
            this.getPublisherCounselPointsDataGridView.ShowCellToolTips = false;
            this.getPublisherCounselPointsDataGridView.Size = new System.Drawing.Size(358, 349);
            this.getPublisherCounselPointsDataGridView.TabIndex = 7;
            this.getPublisherCounselPointsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPublisherCounselPointsDataGridView_CellDoubleClick);
            this.getPublisherCounselPointsDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPublisherCounselPointsDataGridView_CellMouseEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn1.HeaderText = "count";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "counsel_point_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "counsel_point_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "study_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Study Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 196;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "is_reading";
            this.dataGridViewCheckBoxColumn1.HeaderText = "is_reading";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "is_demonstration";
            this.dataGridViewCheckBoxColumn2.HeaderText = "is_demonstration";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "is_discourse";
            this.dataGridViewCheckBoxColumn3.HeaderText = "is_discourse";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(388, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 349);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 349);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 30);
            this.panel2.TabIndex = 5;
            // 
            // getPublisherCounselPointsTableAdapter
            // 
            this.getPublisherCounselPointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.counsel_pointTableAdapter = null;
            this.tableAdapterManager.publisher_assignmentTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getPublisherCounselPointsBindingNavigator
            // 
            this.getPublisherCounselPointsBindingNavigator.AddNewItem = null;
            this.getPublisherCounselPointsBindingNavigator.BindingSource = this.getPublisherCounselPointsBindingSource;
            this.getPublisherCounselPointsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getPublisherCounselPointsBindingNavigator.DeleteItem = null;
            this.getPublisherCounselPointsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.getPublisherCounselPointsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getPublisherCounselPointsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getPublisherCounselPointsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getPublisherCounselPointsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getPublisherCounselPointsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getPublisherCounselPointsBindingNavigator.Name = "getPublisherCounselPointsBindingNavigator";
            this.getPublisherCounselPointsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getPublisherCounselPointsBindingNavigator.Size = new System.Drawing.Size(689, 25);
            this.getPublisherCounselPointsBindingNavigator.TabIndex = 0;
            this.getPublisherCounselPointsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // counselpointidDataGridViewTextBoxColumn
            // 
            this.counselpointidDataGridViewTextBoxColumn.DataPropertyName = "counsel_point_id";
            this.counselpointidDataGridViewTextBoxColumn.HeaderText = "counsel_point_id";
            this.counselpointidDataGridViewTextBoxColumn.Name = "counselpointidDataGridViewTextBoxColumn";
            this.counselpointidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studynumberDataGridViewTextBoxColumn
            // 
            this.studynumberDataGridViewTextBoxColumn.DataPropertyName = "study_number";
            this.studynumberDataGridViewTextBoxColumn.HeaderText = "study_number";
            this.studynumberDataGridViewTextBoxColumn.Name = "studynumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // isreadingDataGridViewCheckBoxColumn
            // 
            this.isreadingDataGridViewCheckBoxColumn.DataPropertyName = "is_reading";
            this.isreadingDataGridViewCheckBoxColumn.HeaderText = "is_reading";
            this.isreadingDataGridViewCheckBoxColumn.Name = "isreadingDataGridViewCheckBoxColumn";
            // 
            // isdemonstrationDataGridViewCheckBoxColumn
            // 
            this.isdemonstrationDataGridViewCheckBoxColumn.DataPropertyName = "is_demonstration";
            this.isdemonstrationDataGridViewCheckBoxColumn.HeaderText = "is_demonstration";
            this.isdemonstrationDataGridViewCheckBoxColumn.Name = "isdemonstrationDataGridViewCheckBoxColumn";
            // 
            // isdiscourseDataGridViewCheckBoxColumn
            // 
            this.isdiscourseDataGridViewCheckBoxColumn.DataPropertyName = "is_discourse";
            this.isdiscourseDataGridViewCheckBoxColumn.HeaderText = "is_discourse";
            this.isdiscourseDataGridViewCheckBoxColumn.Name = "isdiscourseDataGridViewCheckBoxColumn";
            // 
            // frmChooseCounselPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 505);
            this.Controls.Add(this.getPublisherCounselPointsBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmChooseCounselPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counsel Point";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChooseCounselPoint_FormClosed);
            this.Load += new System.EventHandler(this.frmChooseCounselPoint_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPublisherCounselPointsBindingNavigator)).EndInit();
            this.getPublisherCounselPointsBindingNavigator.ResumeLayout(false);
            this.getPublisherCounselPointsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView getPublisherCounselPointsDataGridView;
        private System.Windows.Forms.BindingSource getPublisherCounselPointsBindingSource;
        private TMSADataSet tMSADataSet;
        private TMSADataSetTableAdapters.GetPublisherCounselPointsTableAdapter getPublisherCounselPointsTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getPublisherCounselPointsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counselpointidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isreadingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdemonstrationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdiscourseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox study_numberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
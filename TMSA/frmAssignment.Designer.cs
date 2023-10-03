using System;

namespace TMSA
{
    partial class frmAssignments
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
            System.Windows.Forms.Label week_start_dateLabel;
            System.Windows.Forms.Label week_end_dateLabel;
            System.Windows.Forms.Label date_assignedLabel;
            System.Windows.Forms.Label assignment_typeLabel;
            System.Windows.Forms.Label hallLabel;
            System.Windows.Forms.Label publisher_idLabel;
            System.Windows.Forms.Label assistant_idLabel;
            System.Windows.Forms.Label counsel_point_idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignments));
            this.btnDeleteAssistant = new System.Windows.Forms.Button();
            this.tbCounselPoint = new System.Windows.Forms.TextBox();
            this.counsel_point_idTextBox = new System.Windows.Forms.TextBox();
            this.publisher_assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.btnChooseCounselPoint = new System.Windows.Forms.Button();
            this.tbPublisherName = new System.Windows.Forms.TextBox();
            this.btnChooseAssistant = new System.Windows.Forms.Button();
            this.btnchoosePublisher = new System.Windows.Forms.Button();
            this.week_start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.week_end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_assignedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assignment_typeComboBox = new System.Windows.Forms.ComboBox();
            this.hallComboBox = new System.Windows.Forms.ComboBox();
            this.tbAssinstantName = new System.Windows.Forms.TextBox();
            this.assistant_idTextBox = new System.Windows.Forms.TextBox();
            this.publisher_assignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistant_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsel_point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_other_names = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisher_last_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assistant_other_names = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assistant_last_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.study_number = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.counselpointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.description = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assignment_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateassignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishercontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisheraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisheractiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.publisherpictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.publishergenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherprivilegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherpublisertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishergroupnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.assistantpictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.assistantgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantprivilegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantpublisertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantgroupnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isreadingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdemonstrationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdiscourseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.publisher_assignmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.publisher_assignmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToMask = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbFromMask = new System.Windows.Forms.TextBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.publisher_assignmentTableAdapter = new TMSA.TMSADataSetTableAdapters.publisher_assignmentTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.assignment_viewTableAdapter = new TMSA.TMSADataSetTableAdapters.assignment_viewTableAdapter();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.publisher_idComboBox = new System.Windows.Forms.ComboBox();
            this.assistant_idComboBox = new System.Windows.Forms.ComboBox();
            this.publisherTableAdapter = new TMSA.TMSADataSetTableAdapters.publisherTableAdapter();
            this.counsel_pointTableAdapter = new TMSA.TMSADataSetTableAdapters.counsel_pointTableAdapter();
            week_start_dateLabel = new System.Windows.Forms.Label();
            week_end_dateLabel = new System.Windows.Forms.Label();
            date_assignedLabel = new System.Windows.Forms.Label();
            assignment_typeLabel = new System.Windows.Forms.Label();
            hallLabel = new System.Windows.Forms.Label();
            publisher_idLabel = new System.Windows.Forms.Label();
            assistant_idLabel = new System.Windows.Forms.Label();
            counsel_point_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselpointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentBindingNavigator)).BeginInit();
            this.publisher_assignmentBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // week_start_dateLabel
            // 
            week_start_dateLabel.AutoSize = true;
            week_start_dateLabel.Location = new System.Drawing.Point(36, 259);
            week_start_dateLabel.Name = "week_start_dateLabel";
            week_start_dateLabel.Size = new System.Drawing.Size(86, 13);
            week_start_dateLabel.TabIndex = 46;
            week_start_dateLabel.Text = "Week start date:";
            // 
            // week_end_dateLabel
            // 
            week_end_dateLabel.AutoSize = true;
            week_end_dateLabel.Location = new System.Drawing.Point(36, 287);
            week_end_dateLabel.Name = "week_end_dateLabel";
            week_end_dateLabel.Size = new System.Drawing.Size(84, 13);
            week_end_dateLabel.TabIndex = 48;
            week_end_dateLabel.Text = "Week end date:";
            // 
            // date_assignedLabel
            // 
            date_assignedLabel.AutoSize = true;
            date_assignedLabel.Location = new System.Drawing.Point(36, 322);
            date_assignedLabel.Name = "date_assignedLabel";
            date_assignedLabel.Size = new System.Drawing.Size(78, 13);
            date_assignedLabel.TabIndex = 50;
            date_assignedLabel.Text = "Date assigned:";
            // 
            // assignment_typeLabel
            // 
            assignment_typeLabel.AutoSize = true;
            assignment_typeLabel.Location = new System.Drawing.Point(36, 377);
            assignment_typeLabel.Name = "assignment_typeLabel";
            assignment_typeLabel.Size = new System.Drawing.Size(87, 13);
            assignment_typeLabel.TabIndex = 54;
            assignment_typeLabel.Text = "Assignment type:";
            // 
            // hallLabel
            // 
            hallLabel.AutoSize = true;
            hallLabel.Location = new System.Drawing.Point(36, 347);
            hallLabel.Name = "hallLabel";
            hallLabel.Size = new System.Drawing.Size(28, 13);
            hallLabel.TabIndex = 56;
            hallLabel.Text = "Hall:";
            // 
            // publisher_idLabel
            // 
            publisher_idLabel.AutoSize = true;
            publisher_idLabel.Location = new System.Drawing.Point(35, 144);
            publisher_idLabel.Name = "publisher_idLabel";
            publisher_idLabel.Size = new System.Drawing.Size(53, 13);
            publisher_idLabel.TabIndex = 58;
            publisher_idLabel.Text = "Publisher:";
            // 
            // assistant_idLabel
            // 
            assistant_idLabel.AutoSize = true;
            assistant_idLabel.Location = new System.Drawing.Point(36, 228);
            assistant_idLabel.Name = "assistant_idLabel";
            assistant_idLabel.Size = new System.Drawing.Size(52, 13);
            assistant_idLabel.TabIndex = 60;
            assistant_idLabel.Text = "Assistant:";
            // 
            // counsel_point_idLabel
            // 
            counsel_point_idLabel.AutoSize = true;
            counsel_point_idLabel.Location = new System.Drawing.Point(36, 184);
            counsel_point_idLabel.Name = "counsel_point_idLabel";
            counsel_point_idLabel.Size = new System.Drawing.Size(74, 13);
            counsel_point_idLabel.TabIndex = 62;
            counsel_point_idLabel.Text = "Counsel point:";
            // 
            // btnDeleteAssistant
            // 
            this.btnDeleteAssistant.Location = new System.Drawing.Point(362, 222);
            this.btnDeleteAssistant.Name = "btnDeleteAssistant";
            this.btnDeleteAssistant.Size = new System.Drawing.Size(43, 23);
            this.btnDeleteAssistant.TabIndex = 70;
            this.btnDeleteAssistant.Text = "DEL";
            this.btnDeleteAssistant.UseVisualStyleBackColor = true;
            this.btnDeleteAssistant.Click += new System.EventHandler(this.btnDeleteAssistant_Click);
            // 
            // tbCounselPoint
            // 
            this.tbCounselPoint.Location = new System.Drawing.Point(162, 172);
            this.tbCounselPoint.Multiline = true;
            this.tbCounselPoint.Name = "tbCounselPoint";
            this.tbCounselPoint.ReadOnly = true;
            this.tbCounselPoint.Size = new System.Drawing.Size(168, 40);
            this.tbCounselPoint.TabIndex = 69;
            // 
            // counsel_point_idTextBox
            // 
            this.counsel_point_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_assignmentBindingSource, "counsel_point_id", true));
            this.counsel_point_idTextBox.Location = new System.Drawing.Point(284, 224);
            this.counsel_point_idTextBox.Name = "counsel_point_idTextBox";
            this.counsel_point_idTextBox.Size = new System.Drawing.Size(25, 20);
            this.counsel_point_idTextBox.TabIndex = 63;
            // 
            // publisher_assignmentBindingSource
            // 
            this.publisher_assignmentBindingSource.DataMember = "publisher_assignment";
            this.publisher_assignmentBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChooseCounselPoint
            // 
            this.btnChooseCounselPoint.Location = new System.Drawing.Point(330, 170);
            this.btnChooseCounselPoint.Name = "btnChooseCounselPoint";
            this.btnChooseCounselPoint.Size = new System.Drawing.Size(32, 23);
            this.btnChooseCounselPoint.TabIndex = 68;
            this.btnChooseCounselPoint.Text = "...";
            this.btnChooseCounselPoint.UseVisualStyleBackColor = true;
            this.btnChooseCounselPoint.Click += new System.EventHandler(this.btnChooseCounselPoint_Click);
            // 
            // tbPublisherName
            // 
            this.tbPublisherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbPublisherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPublisherName.Location = new System.Drawing.Point(161, 141);
            this.tbPublisherName.Name = "tbPublisherName";
            this.tbPublisherName.ReadOnly = true;
            this.tbPublisherName.Size = new System.Drawing.Size(168, 20);
            this.tbPublisherName.TabIndex = 64;
            // 
            // btnChooseAssistant
            // 
            this.btnChooseAssistant.Location = new System.Drawing.Point(329, 222);
            this.btnChooseAssistant.Name = "btnChooseAssistant";
            this.btnChooseAssistant.Size = new System.Drawing.Size(32, 23);
            this.btnChooseAssistant.TabIndex = 67;
            this.btnChooseAssistant.Text = "...";
            this.btnChooseAssistant.UseVisualStyleBackColor = true;
            this.btnChooseAssistant.Click += new System.EventHandler(this.btnChooseAssistant_Click);
            // 
            // btnchoosePublisher
            // 
            this.btnchoosePublisher.Location = new System.Drawing.Point(329, 139);
            this.btnchoosePublisher.Name = "btnchoosePublisher";
            this.btnchoosePublisher.Size = new System.Drawing.Size(32, 23);
            this.btnchoosePublisher.TabIndex = 65;
            this.btnchoosePublisher.Text = "...";
            this.btnchoosePublisher.UseVisualStyleBackColor = true;
            this.btnchoosePublisher.Click += new System.EventHandler(this.btnchoosePublisher_Click);
            // 
            // week_start_dateDateTimePicker
            // 
            this.week_start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_assignmentBindingSource, "week_start_date", true));
            this.week_start_dateDateTimePicker.Location = new System.Drawing.Point(161, 254);
            this.week_start_dateDateTimePicker.Name = "week_start_dateDateTimePicker";
            this.week_start_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.week_start_dateDateTimePicker.TabIndex = 47;
            this.week_start_dateDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // week_end_dateDateTimePicker
            // 
            this.week_end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_assignmentBindingSource, "week_end_date", true));
            this.week_end_dateDateTimePicker.Location = new System.Drawing.Point(161, 283);
            this.week_end_dateDateTimePicker.Name = "week_end_dateDateTimePicker";
            this.week_end_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.week_end_dateDateTimePicker.TabIndex = 49;
            this.week_end_dateDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // date_assignedDateTimePicker
            // 
            this.date_assignedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisher_assignmentBindingSource, "date_assigned", true));
            this.date_assignedDateTimePicker.Location = new System.Drawing.Point(161, 315);
            this.date_assignedDateTimePicker.Name = "date_assignedDateTimePicker";
            this.date_assignedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_assignedDateTimePicker.TabIndex = 51;
            this.date_assignedDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // assignment_typeComboBox
            // 
            this.assignment_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_assignmentBindingSource, "assignment_type", true));
            this.assignment_typeComboBox.FormattingEnabled = true;
            this.assignment_typeComboBox.Items.AddRange(new object[] {
            "1. Bible reading",
            "2. Initial call",
            "3. First return visit",
            "4. Second return visit",
            "5. Third return visit",
            "6. Bible study",
            "7. Talk"});
            this.assignment_typeComboBox.Location = new System.Drawing.Point(161, 378);
            this.assignment_typeComboBox.Name = "assignment_typeComboBox";
            this.assignment_typeComboBox.Size = new System.Drawing.Size(200, 21);
            this.assignment_typeComboBox.TabIndex = 55;
            this.assignment_typeComboBox.Click += new System.EventHandler(this.assignment_typeComboBox_Click);
            // 
            // hallComboBox
            // 
            this.hallComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_assignmentBindingSource, "hall", true));
            this.hallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hallComboBox.FormattingEnabled = true;
            this.hallComboBox.Items.AddRange(new object[] {
            "1. Main hall",
            "2. Auxiliary classroom 1",
            "3. Auxiliary classroom 2"});
            this.hallComboBox.Location = new System.Drawing.Point(161, 346);
            this.hallComboBox.Name = "hallComboBox";
            this.hallComboBox.Size = new System.Drawing.Size(200, 21);
            this.hallComboBox.TabIndex = 57;
            // 
            // tbAssinstantName
            // 
            this.tbAssinstantName.Location = new System.Drawing.Point(161, 224);
            this.tbAssinstantName.Name = "tbAssinstantName";
            this.tbAssinstantName.ReadOnly = true;
            this.tbAssinstantName.Size = new System.Drawing.Size(168, 20);
            this.tbAssinstantName.TabIndex = 66;
            // 
            // assistant_idTextBox
            // 
            this.assistant_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_assignmentBindingSource, "assistant_id", true));
            this.assistant_idTextBox.Location = new System.Drawing.Point(237, 224);
            this.assistant_idTextBox.Name = "assistant_idTextBox";
            this.assistant_idTextBox.Size = new System.Drawing.Size(24, 20);
            this.assistant_idTextBox.TabIndex = 61;
            // 
            // publisher_assignmentDataGridView
            // 
            this.publisher_assignmentDataGridView.AllowUserToAddRows = false;
            this.publisher_assignmentDataGridView.AllowUserToDeleteRows = false;
            this.publisher_assignmentDataGridView.AllowUserToResizeColumns = false;
            this.publisher_assignmentDataGridView.AllowUserToResizeRows = false;
            this.publisher_assignmentDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_assignmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.publisher_assignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisher_assignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.date_completed,
            this.dataGridViewTextBoxColumn9,
            this.hall,
            this.publisher_name,
            this.assistant_name,
            this.counsel_point,
            this.publisher_other_names,
            this.publisher_last_name,
            this.assistant_other_names,
            this.assistant_last_name,
            this.study_number,
            this.description});
            this.publisher_assignmentDataGridView.DataSource = this.publisher_assignmentBindingSource;
            this.publisher_assignmentDataGridView.Location = new System.Drawing.Point(442, 139);
            this.publisher_assignmentDataGridView.Name = "publisher_assignmentDataGridView";
            this.publisher_assignmentDataGridView.ReadOnly = true;
            this.publisher_assignmentDataGridView.Size = new System.Drawing.Size(440, 393);
            this.publisher_assignmentDataGridView.TabIndex = 7;
            this.publisher_assignmentDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.publisher_assignmentDataGridView_DataError);
            this.publisher_assignmentDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisher_assignmentDataGridView_RowEnter);
            this.publisher_assignmentDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.publisher_assignmentDataGridView_RowsAdded);
            this.publisher_assignmentDataGridView.SelectionChanged += new System.EventHandler(this.publisher_assignmentDataGridView_SelectionChanged);
            this.publisher_assignmentDataGridView.Sorted += new System.EventHandler(this.publisher_assignmentDataGridView_Sorted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "publisher_assignment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "publisher_assignment_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "publisher_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "publisher_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "assistant_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "assistant_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "counsel_point_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "counsel_point_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "week_start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Week Start Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "week_end_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Week End Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_assigned";
            this.dataGridViewTextBoxColumn7.HeaderText = "date_assigned";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // date_completed
            // 
            this.date_completed.DataPropertyName = "date_completed";
            this.date_completed.HeaderText = "date_completed";
            this.date_completed.Name = "date_completed";
            this.date_completed.ReadOnly = true;
            this.date_completed.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "assignment_type";
            this.dataGridViewTextBoxColumn9.HeaderText = "assignment_type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // hall
            // 
            this.hall.DataPropertyName = "hall";
            this.hall.HeaderText = "hall";
            this.hall.Name = "hall";
            this.hall.ReadOnly = true;
            this.hall.Visible = false;
            // 
            // publisher_name
            // 
            this.publisher_name.HeaderText = "Publisher Name";
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.ReadOnly = true;
            this.publisher_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.publisher_name.Width = 200;
            // 
            // assistant_name
            // 
            this.assistant_name.HeaderText = "Assistant Name";
            this.assistant_name.Name = "assistant_name";
            this.assistant_name.ReadOnly = true;
            this.assistant_name.Visible = false;
            // 
            // counsel_point
            // 
            this.counsel_point.HeaderText = "Counsel Point";
            this.counsel_point.Name = "counsel_point";
            this.counsel_point.ReadOnly = true;
            this.counsel_point.Visible = false;
            // 
            // publisher_other_names
            // 
            this.publisher_other_names.DataPropertyName = "publisher_id";
            this.publisher_other_names.DataSource = this.publisherBindingSource;
            this.publisher_other_names.DisplayMember = "other_names";
            this.publisher_other_names.HeaderText = "publisher_id";
            this.publisher_other_names.Name = "publisher_other_names";
            this.publisher_other_names.ReadOnly = true;
            this.publisher_other_names.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_other_names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisher_other_names.ValueMember = "publisher_id";
            this.publisher_other_names.Visible = false;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.tMSADataSet;
            // 
            // publisher_last_name
            // 
            this.publisher_last_name.DataPropertyName = "publisher_id";
            this.publisher_last_name.DataSource = this.publisherBindingSource;
            this.publisher_last_name.DisplayMember = "last_name";
            this.publisher_last_name.HeaderText = "publisher_id";
            this.publisher_last_name.Name = "publisher_last_name";
            this.publisher_last_name.ReadOnly = true;
            this.publisher_last_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_last_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisher_last_name.ValueMember = "publisher_id";
            this.publisher_last_name.Visible = false;
            // 
            // assistant_other_names
            // 
            this.assistant_other_names.DataPropertyName = "assistant_id";
            this.assistant_other_names.DataSource = this.publisherBindingSource;
            this.assistant_other_names.DisplayMember = "other_names";
            this.assistant_other_names.HeaderText = "assistant_id";
            this.assistant_other_names.Name = "assistant_other_names";
            this.assistant_other_names.ReadOnly = true;
            this.assistant_other_names.ValueMember = "publisher_id";
            this.assistant_other_names.Visible = false;
            // 
            // assistant_last_name
            // 
            this.assistant_last_name.DataPropertyName = "assistant_id";
            this.assistant_last_name.DataSource = this.publisherBindingSource;
            this.assistant_last_name.DisplayMember = "last_name";
            this.assistant_last_name.HeaderText = "assistant_id";
            this.assistant_last_name.Name = "assistant_last_name";
            this.assistant_last_name.ReadOnly = true;
            this.assistant_last_name.ValueMember = "publisher_id";
            this.assistant_last_name.Visible = false;
            // 
            // study_number
            // 
            this.study_number.DataPropertyName = "counsel_point_id";
            this.study_number.DataSource = this.counselpointBindingSource;
            this.study_number.DisplayMember = "study_number";
            this.study_number.HeaderText = "counsel_point_id";
            this.study_number.Name = "study_number";
            this.study_number.ReadOnly = true;
            this.study_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.study_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.study_number.ValueMember = "counsel_point_id";
            this.study_number.Visible = false;
            // 
            // counselpointBindingSource
            // 
            this.counselpointBindingSource.DataMember = "counsel_point";
            this.counselpointBindingSource.DataSource = this.tMSADataSet;
            // 
            // description
            // 
            this.description.DataPropertyName = "counsel_point_id";
            this.description.DataSource = this.counselpointBindingSource;
            this.description.DisplayMember = "description";
            this.description.HeaderText = "counsel_point_id";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.ValueMember = "counsel_point_id";
            this.description.Visible = false;
            // 
            // assignment_viewBindingSource
            // 
            this.assignment_viewBindingSource.DataMember = "assignment_view";
            this.assignment_viewBindingSource.DataSource = this.tMSADataSet;
            // 
            // weekstartdateDataGridViewTextBoxColumn
            // 
            this.weekstartdateDataGridViewTextBoxColumn.DataPropertyName = "week_start_date";
            this.weekstartdateDataGridViewTextBoxColumn.HeaderText = "week_start_date";
            this.weekstartdateDataGridViewTextBoxColumn.Name = "weekstartdateDataGridViewTextBoxColumn";
            // 
            // weekenddateDataGridViewTextBoxColumn
            // 
            this.weekenddateDataGridViewTextBoxColumn.DataPropertyName = "week_end_date";
            this.weekenddateDataGridViewTextBoxColumn.HeaderText = "week_end_date";
            this.weekenddateDataGridViewTextBoxColumn.Name = "weekenddateDataGridViewTextBoxColumn";
            // 
            // dateassignedDataGridViewTextBoxColumn
            // 
            this.dateassignedDataGridViewTextBoxColumn.DataPropertyName = "date_assigned";
            this.dateassignedDataGridViewTextBoxColumn.HeaderText = "date_assigned";
            this.dateassignedDataGridViewTextBoxColumn.Name = "dateassignedDataGridViewTextBoxColumn";
            // 
            // datecompletedDataGridViewTextBoxColumn
            // 
            this.datecompletedDataGridViewTextBoxColumn.DataPropertyName = "date_completed";
            this.datecompletedDataGridViewTextBoxColumn.HeaderText = "date_completed";
            this.datecompletedDataGridViewTextBoxColumn.Name = "datecompletedDataGridViewTextBoxColumn";
            // 
            // assignmenttypeDataGridViewTextBoxColumn
            // 
            this.assignmenttypeDataGridViewTextBoxColumn.DataPropertyName = "assignment_type";
            this.assignmenttypeDataGridViewTextBoxColumn.HeaderText = "assignment_type";
            this.assignmenttypeDataGridViewTextBoxColumn.Name = "assignmenttypeDataGridViewTextBoxColumn";
            // 
            // hallDataGridViewTextBoxColumn
            // 
            this.hallDataGridViewTextBoxColumn.DataPropertyName = "hall";
            this.hallDataGridViewTextBoxColumn.HeaderText = "hall";
            this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
            // 
            // publishernameDataGridViewTextBoxColumn
            // 
            this.publishernameDataGridViewTextBoxColumn.DataPropertyName = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.HeaderText = "publisher_name";
            this.publishernameDataGridViewTextBoxColumn.Name = "publishernameDataGridViewTextBoxColumn";
            this.publishernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherdobDataGridViewTextBoxColumn
            // 
            this.publisherdobDataGridViewTextBoxColumn.DataPropertyName = "publisher_dob";
            this.publisherdobDataGridViewTextBoxColumn.HeaderText = "publisher_dob";
            this.publisherdobDataGridViewTextBoxColumn.Name = "publisherdobDataGridViewTextBoxColumn";
            // 
            // publishercontactDataGridViewTextBoxColumn
            // 
            this.publishercontactDataGridViewTextBoxColumn.DataPropertyName = "publisher_contact";
            this.publishercontactDataGridViewTextBoxColumn.HeaderText = "publisher_contact";
            this.publishercontactDataGridViewTextBoxColumn.Name = "publishercontactDataGridViewTextBoxColumn";
            // 
            // publisheraddressDataGridViewTextBoxColumn
            // 
            this.publisheraddressDataGridViewTextBoxColumn.DataPropertyName = "publisher_address";
            this.publisheraddressDataGridViewTextBoxColumn.HeaderText = "publisher_address";
            this.publisheraddressDataGridViewTextBoxColumn.Name = "publisheraddressDataGridViewTextBoxColumn";
            // 
            // publisheractiveDataGridViewCheckBoxColumn
            // 
            this.publisheractiveDataGridViewCheckBoxColumn.DataPropertyName = "publisher_active";
            this.publisheractiveDataGridViewCheckBoxColumn.HeaderText = "publisher_active";
            this.publisheractiveDataGridViewCheckBoxColumn.Name = "publisheractiveDataGridViewCheckBoxColumn";
            // 
            // publisherpictureDataGridViewImageColumn
            // 
            this.publisherpictureDataGridViewImageColumn.DataPropertyName = "publisher_picture";
            this.publisherpictureDataGridViewImageColumn.HeaderText = "publisher_picture";
            this.publisherpictureDataGridViewImageColumn.Name = "publisherpictureDataGridViewImageColumn";
            // 
            // publishergenderDataGridViewTextBoxColumn
            // 
            this.publishergenderDataGridViewTextBoxColumn.DataPropertyName = "publisher_gender";
            this.publishergenderDataGridViewTextBoxColumn.HeaderText = "publisher_gender";
            this.publishergenderDataGridViewTextBoxColumn.Name = "publishergenderDataGridViewTextBoxColumn";
            // 
            // publisherprivilegeDataGridViewTextBoxColumn
            // 
            this.publisherprivilegeDataGridViewTextBoxColumn.DataPropertyName = "publisher_privilege";
            this.publisherprivilegeDataGridViewTextBoxColumn.HeaderText = "publisher_privilege";
            this.publisherprivilegeDataGridViewTextBoxColumn.Name = "publisherprivilegeDataGridViewTextBoxColumn";
            // 
            // publisherpublisertypeDataGridViewTextBoxColumn
            // 
            this.publisherpublisertypeDataGridViewTextBoxColumn.DataPropertyName = "publisher_publiser_type";
            this.publisherpublisertypeDataGridViewTextBoxColumn.HeaderText = "publisher_publiser_type";
            this.publisherpublisertypeDataGridViewTextBoxColumn.Name = "publisherpublisertypeDataGridViewTextBoxColumn";
            // 
            // publishergroupnumberDataGridViewTextBoxColumn
            // 
            this.publishergroupnumberDataGridViewTextBoxColumn.DataPropertyName = "publisher_group_number";
            this.publishergroupnumberDataGridViewTextBoxColumn.HeaderText = "publisher_group_number";
            this.publishergroupnumberDataGridViewTextBoxColumn.Name = "publishergroupnumberDataGridViewTextBoxColumn";
            // 
            // assistantnameDataGridViewTextBoxColumn
            // 
            this.assistantnameDataGridViewTextBoxColumn.DataPropertyName = "assistant_name";
            this.assistantnameDataGridViewTextBoxColumn.HeaderText = "assistant_name";
            this.assistantnameDataGridViewTextBoxColumn.Name = "assistantnameDataGridViewTextBoxColumn";
            this.assistantnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistantdobDataGridViewTextBoxColumn
            // 
            this.assistantdobDataGridViewTextBoxColumn.DataPropertyName = "assistant_dob";
            this.assistantdobDataGridViewTextBoxColumn.HeaderText = "assistant_dob";
            this.assistantdobDataGridViewTextBoxColumn.Name = "assistantdobDataGridViewTextBoxColumn";
            // 
            // assistantcontactDataGridViewTextBoxColumn
            // 
            this.assistantcontactDataGridViewTextBoxColumn.DataPropertyName = "assistant_contact";
            this.assistantcontactDataGridViewTextBoxColumn.HeaderText = "assistant_contact";
            this.assistantcontactDataGridViewTextBoxColumn.Name = "assistantcontactDataGridViewTextBoxColumn";
            // 
            // assistantaddressDataGridViewTextBoxColumn
            // 
            this.assistantaddressDataGridViewTextBoxColumn.DataPropertyName = "assistant_address";
            this.assistantaddressDataGridViewTextBoxColumn.HeaderText = "assistant_address";
            this.assistantaddressDataGridViewTextBoxColumn.Name = "assistantaddressDataGridViewTextBoxColumn";
            // 
            // assistantactiveDataGridViewCheckBoxColumn
            // 
            this.assistantactiveDataGridViewCheckBoxColumn.DataPropertyName = "assistant_active";
            this.assistantactiveDataGridViewCheckBoxColumn.HeaderText = "assistant_active";
            this.assistantactiveDataGridViewCheckBoxColumn.Name = "assistantactiveDataGridViewCheckBoxColumn";
            // 
            // assistantpictureDataGridViewImageColumn
            // 
            this.assistantpictureDataGridViewImageColumn.DataPropertyName = "assistant_picture";
            this.assistantpictureDataGridViewImageColumn.HeaderText = "assistant_picture";
            this.assistantpictureDataGridViewImageColumn.Name = "assistantpictureDataGridViewImageColumn";
            // 
            // assistantgenderDataGridViewTextBoxColumn
            // 
            this.assistantgenderDataGridViewTextBoxColumn.DataPropertyName = "assistant_gender";
            this.assistantgenderDataGridViewTextBoxColumn.HeaderText = "assistant_gender";
            this.assistantgenderDataGridViewTextBoxColumn.Name = "assistantgenderDataGridViewTextBoxColumn";
            // 
            // assistantprivilegeDataGridViewTextBoxColumn
            // 
            this.assistantprivilegeDataGridViewTextBoxColumn.DataPropertyName = "assistant_privilege";
            this.assistantprivilegeDataGridViewTextBoxColumn.HeaderText = "assistant_privilege";
            this.assistantprivilegeDataGridViewTextBoxColumn.Name = "assistantprivilegeDataGridViewTextBoxColumn";
            // 
            // assistantpublisertypeDataGridViewTextBoxColumn
            // 
            this.assistantpublisertypeDataGridViewTextBoxColumn.DataPropertyName = "assistant_publiser_type";
            this.assistantpublisertypeDataGridViewTextBoxColumn.HeaderText = "assistant_publiser_type";
            this.assistantpublisertypeDataGridViewTextBoxColumn.Name = "assistantpublisertypeDataGridViewTextBoxColumn";
            // 
            // assistantgroupnumberDataGridViewTextBoxColumn
            // 
            this.assistantgroupnumberDataGridViewTextBoxColumn.DataPropertyName = "assistant_group_number";
            this.assistantgroupnumberDataGridViewTextBoxColumn.HeaderText = "assistant_group_number";
            this.assistantgroupnumberDataGridViewTextBoxColumn.Name = "assistantgroupnumberDataGridViewTextBoxColumn";
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
            // publisher_assignmentBindingNavigator
            // 
            this.publisher_assignmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publisher_assignmentBindingNavigator.BindingSource = this.publisher_assignmentBindingSource;
            this.publisher_assignmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publisher_assignmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publisher_assignmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.publisher_assignmentBindingNavigatorSaveItem});
            this.publisher_assignmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publisher_assignmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publisher_assignmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publisher_assignmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publisher_assignmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publisher_assignmentBindingNavigator.Name = "publisher_assignmentBindingNavigator";
            this.publisher_assignmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publisher_assignmentBindingNavigator.Size = new System.Drawing.Size(912, 25);
            this.publisher_assignmentBindingNavigator.TabIndex = 1;
            this.publisher_assignmentBindingNavigator.Text = "bindingNavigator1";
            this.publisher_assignmentBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.publisher_assignmentBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.EnabledChanged += new System.EventHandler(this.bindingNavigatorDeleteItem_EnabledChanged);
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
            this.bindingNavigatorSeparator.Click += new System.EventHandler(this.bindingNavigatorSeparator_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Click += new System.EventHandler(this.bindingNavigatorSeparator1_Click);
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
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // publisher_assignmentBindingNavigatorSaveItem
            // 
            this.publisher_assignmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publisher_assignmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publisher_assignmentBindingNavigatorSaveItem.Image")));
            this.publisher_assignmentBindingNavigatorSaveItem.Name = "publisher_assignmentBindingNavigatorSaveItem";
            this.publisher_assignmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.publisher_assignmentBindingNavigatorSaveItem.Text = "Save Data";
            this.publisher_assignmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.publisher_assignmentBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbToMask);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.tbFromMask);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(38, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 49);
            this.groupBox1.TabIndex = 193;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Week starting:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(355, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 344;
            this.label1.Text = "to:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(736, 13);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(89, 28);
            this.btnClearFilter.TabIndex = 343;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(641, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 28);
            this.btnFilter.TabIndex = 342;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 176;
            this.label4.Text = "from:";
            // 
            // tbToMask
            // 
            this.tbToMask.BackColor = System.Drawing.Color.White;
            this.tbToMask.ForeColor = System.Drawing.Color.White;
            this.tbToMask.Location = new System.Drawing.Point(388, 18);
            this.tbToMask.Name = "tbToMask";
            this.tbToMask.Size = new System.Drawing.Size(169, 20);
            this.tbToMask.TabIndex = 191;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(388, 18);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 53;
            this.toDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.CloseUp += new System.EventHandler(this.toDateTimePicker_CloseUp);
            // 
            // tbFromMask
            // 
            this.tbFromMask.BackColor = System.Drawing.Color.White;
            this.tbFromMask.ForeColor = System.Drawing.Color.White;
            this.tbFromMask.Location = new System.Drawing.Point(102, 18);
            this.tbFromMask.Name = "tbFromMask";
            this.tbFromMask.Size = new System.Drawing.Size(169, 20);
            this.tbFromMask.TabIndex = 191;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(102, 18);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 53;
            this.fromDateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.CloseUp += new System.EventHandler(this.fromDateTimePicker_CloseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // publisher_assignmentTableAdapter
            // 
            this.publisher_assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.counsel_pointTableAdapter = null;
            this.tableAdapterManager.publisher_assignmentTableAdapter = this.publisher_assignmentTableAdapter;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assignment_viewTableAdapter
            // 
            this.assignment_viewTableAdapter.ClearBeforeFill = true;
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisher_assignmentBindingSource, "publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(237, 141);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(24, 20);
            this.publisher_idTextBox.TabIndex = 59;
            this.publisher_idTextBox.TextChanged += new System.EventHandler(this.publisher_idTextBox_TextChanged);
            // 
            // publisher_idComboBox
            // 
            this.publisher_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment_viewBindingSource, "publisher_name", true));
            this.publisher_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publisher_assignmentBindingSource, "publisher_assignment_id", true));
            this.publisher_idComboBox.DataSource = this.assignment_viewBindingSource;
            this.publisher_idComboBox.DisplayMember = "publisher_name";
            this.publisher_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.publisher_idComboBox.FormattingEnabled = true;
            this.publisher_idComboBox.Location = new System.Drawing.Point(582, 278);
            this.publisher_idComboBox.Name = "publisher_idComboBox";
            this.publisher_idComboBox.Size = new System.Drawing.Size(168, 20);
            this.publisher_idComboBox.TabIndex = 194;
            this.publisher_idComboBox.ValueMember = "publisher_assignment_id";
            // 
            // assistant_idComboBox
            // 
            this.assistant_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignment_viewBindingSource, "publisher_name", true));
            this.assistant_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publisher_assignmentBindingSource, "publisher_assignment_id", true));
            this.assistant_idComboBox.DataSource = this.assignment_viewBindingSource;
            this.assistant_idComboBox.DisplayMember = "assistant_name";
            this.assistant_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.assistant_idComboBox.FormattingEnabled = true;
            this.assistant_idComboBox.Location = new System.Drawing.Point(581, 252);
            this.assistant_idComboBox.Name = "assistant_idComboBox";
            this.assistant_idComboBox.Size = new System.Drawing.Size(168, 20);
            this.assistant_idComboBox.TabIndex = 195;
            this.assistant_idComboBox.ValueMember = "publisher_assignment_id";
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // counsel_pointTableAdapter
            // 
            this.counsel_pointTableAdapter.ClearBeforeFill = true;
            // 
            // frmAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.publisher_assignmentDataGridView);
            this.Controls.Add(this.tbPublisherName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(counsel_point_idLabel);
            this.Controls.Add(this.tbAssinstantName);
            this.Controls.Add(this.btnChooseCounselPoint);
            this.Controls.Add(this.publisher_assignmentBindingNavigator);
            this.Controls.Add(this.btnDeleteAssistant);
            this.Controls.Add(this.assistant_idTextBox);
            this.Controls.Add(this.btnChooseAssistant);
            this.Controls.Add(this.hallComboBox);
            this.Controls.Add(this.btnchoosePublisher);
            this.Controls.Add(hallLabel);
            this.Controls.Add(publisher_idLabel);
            this.Controls.Add(this.assignment_typeComboBox);
            this.Controls.Add(assistant_idLabel);
            this.Controls.Add(assignment_typeLabel);
            this.Controls.Add(week_start_dateLabel);
            this.Controls.Add(this.week_start_dateDateTimePicker);
            this.Controls.Add(week_end_dateLabel);
            this.Controls.Add(this.date_assignedDateTimePicker);
            this.Controls.Add(this.week_end_dateDateTimePicker);
            this.Controls.Add(date_assignedLabel);
            this.Controls.Add(this.tbCounselPoint);
            this.Controls.Add(this.counsel_point_idTextBox);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(this.assistant_idComboBox);
            this.Controls.Add(this.publisher_idComboBox);
            this.Name = "frmAssignments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publisher Assignments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAssignments_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAssignments_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselpointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisher_assignmentBindingNavigator)).EndInit();
            this.publisher_assignmentBindingNavigator.ResumeLayout(false);
            this.publisher_assignmentBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn weekstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateassignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecompletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishercontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisheraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn publisheractiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn publisherpictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishergenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherprivilegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherpublisertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishergroupnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn assistantactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn assistantpictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantprivilegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantpublisertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantgroupnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isreadingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdemonstrationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdiscourseDataGridViewCheckBoxColumn;
        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource publisher_assignmentBindingSource;
        private TMSADataSetTableAdapters.publisher_assignmentTableAdapter publisher_assignmentTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publisher_assignmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton publisher_assignmentBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnChooseCounselPoint;
        private System.Windows.Forms.Button btnChooseAssistant;
        private System.Windows.Forms.TextBox tbAssinstantName;
        private System.Windows.Forms.Button btnchoosePublisher;
        private System.Windows.Forms.TextBox tbPublisherName;
        private System.Windows.Forms.TextBox assistant_idTextBox;
        private System.Windows.Forms.TextBox tbCounselPoint;
        private System.Windows.Forms.TextBox counsel_point_idTextBox;
        private System.Windows.Forms.DateTimePicker week_start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker week_end_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_assignedDateTimePicker;
        private System.Windows.Forms.ComboBox assignment_typeComboBox;
        private System.Windows.Forms.ComboBox hallComboBox;
        private System.Windows.Forms.DataGridView publisher_assignmentDataGridView;
        private System.Windows.Forms.Button btnDeleteAssistant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFromMask;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbToMask;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.BindingSource assignment_viewBindingSource;
        private TMSADataSetTableAdapters.assignment_viewTableAdapter assignment_viewTableAdapter;
        private System.Windows.Forms.TextBox publisher_idTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox publisher_idComboBox;
        private System.Windows.Forms.ComboBox assistant_idComboBox;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private TMSADataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource counselpointBindingSource;
        private TMSADataSetTableAdapters.counsel_pointTableAdapter counsel_pointTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistant_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsel_point;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisher_other_names;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisher_last_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn assistant_other_names;
        private System.Windows.Forms.DataGridViewComboBoxColumn assistant_last_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn study_number;
        private System.Windows.Forms.DataGridViewComboBoxColumn description;
    }
}
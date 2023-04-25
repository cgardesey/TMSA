namespace TMSA
{
    partial class frmPublishers
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
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label publisher_typeLabel;
            System.Windows.Forms.Label privilegeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label other_namesLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublishers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.publisheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othernamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherTableAdapter = new TMSA.TMSADataSetTableAdapters.publisherTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.publisherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.publisherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteAssignments = new System.Windows.Forms.ToolStripButton();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.publisher_typeComboBox = new System.Windows.Forms.ComboBox();
            this.privilegeComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.other_namesTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.btnDob = new System.Windows.Forms.Button();
            this.tbDobMask = new System.Windows.Forms.TextBox();
            this.publisherDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbPubliserType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupLabel = new System.Windows.Forms.Label();
            publisher_typeLabel = new System.Windows.Forms.Label();
            privilegeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            other_namesLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).BeginInit();
            this.publisherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(57, 517);
            groupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(52, 17);
            groupLabel.TabIndex = 187;
            groupLabel.Text = "Group:";
            // 
            // publisher_typeLabel
            // 
            publisher_typeLabel.AutoSize = true;
            publisher_typeLabel.Location = new System.Drawing.Point(57, 481);
            publisher_typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisher_typeLabel.Name = "publisher_typeLabel";
            publisher_typeLabel.Size = new System.Drawing.Size(102, 17);
            publisher_typeLabel.TabIndex = 185;
            publisher_typeLabel.Text = "Publisher type:";
            // 
            // privilegeLabel
            // 
            privilegeLabel.AutoSize = true;
            privilegeLabel.Location = new System.Drawing.Point(57, 446);
            privilegeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            privilegeLabel.Name = "privilegeLabel";
            privilegeLabel.Size = new System.Drawing.Size(66, 17);
            privilegeLabel.TabIndex = 183;
            privilegeLabel.Text = "Privilege:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(57, 410);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 181;
            genderLabel.Text = "Gender:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(57, 338);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 177;
            addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(57, 303);
            contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(60, 17);
            contactLabel.TabIndex = 175;
            contactLabel.Text = "Contact:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(57, 267);
            dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(90, 17);
            dobLabel.TabIndex = 173;
            dobLabel.Text = "Date of birth:";
            // 
            // other_namesLabel
            // 
            other_namesLabel.AutoSize = true;
            other_namesLabel.Location = new System.Drawing.Point(57, 231);
            other_namesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            other_namesLabel.Name = "other_namesLabel";
            other_namesLabel.Size = new System.Drawing.Size(104, 17);
            other_namesLabel.TabIndex = 171;
            other_namesLabel.Text = "Other name(s):";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(57, 196);
            last_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(78, 17);
            last_nameLabel.TabIndex = 169;
            last_nameLabel.Text = "Last name:";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "publisher";
            this.publisherBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // publisheridDataGridViewTextBoxColumn
            // 
            this.publisheridDataGridViewTextBoxColumn.DataPropertyName = "publisher_id";
            this.publisheridDataGridViewTextBoxColumn.HeaderText = "publisher_id";
            this.publisheridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisheridDataGridViewTextBoxColumn.Name = "publisheridDataGridViewTextBoxColumn";
            this.publisheridDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisheridDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // othernamesDataGridViewTextBoxColumn
            // 
            this.othernamesDataGridViewTextBoxColumn.DataPropertyName = "other_names";
            this.othernamesDataGridViewTextBoxColumn.HeaderText = "other_names";
            this.othernamesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.othernamesDataGridViewTextBoxColumn.Name = "othernamesDataGridViewTextBoxColumn";
            this.othernamesDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // privilegeDataGridViewTextBoxColumn
            // 
            this.privilegeDataGridViewTextBoxColumn.DataPropertyName = "privilege";
            this.privilegeDataGridViewTextBoxColumn.HeaderText = "privilege";
            this.privilegeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privilegeDataGridViewTextBoxColumn.Name = "privilegeDataGridViewTextBoxColumn";
            this.privilegeDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishertypeDataGridViewTextBoxColumn
            // 
            this.publishertypeDataGridViewTextBoxColumn.DataPropertyName = "publisher_type";
            this.publishertypeDataGridViewTextBoxColumn.HeaderText = "publisher_type";
            this.publishertypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishertypeDataGridViewTextBoxColumn.Name = "publishertypeDataGridViewTextBoxColumn";
            this.publishertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.counsel_pointTableAdapter = null;
            this.tableAdapterManager.publisher_assignmentTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = this.publisherTableAdapter;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publisherBindingNavigator
            // 
            this.publisherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publisherBindingNavigator.BindingSource = this.publisherBindingSource;
            this.publisherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publisherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publisherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publisherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.publisherBindingNavigatorSaveItem,
            this.tsDeleteAssignments});
            this.publisherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publisherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publisherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publisherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publisherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publisherBindingNavigator.Name = "publisherBindingNavigator";
            this.publisherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publisherBindingNavigator.Size = new System.Drawing.Size(1319, 27);
            this.publisherBindingNavigator.TabIndex = 1;
            this.publisherBindingNavigator.Text = "bindingNavigator1";
            this.publisherBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.publisherBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator.Click += new System.EventHandler(this.bindingNavigatorSeparator_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator1.Click += new System.EventHandler(this.bindingNavigatorSeparator1_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // publisherBindingNavigatorSaveItem
            // 
            this.publisherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publisherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publisherBindingNavigatorSaveItem.Image")));
            this.publisherBindingNavigatorSaveItem.Name = "publisherBindingNavigatorSaveItem";
            this.publisherBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.publisherBindingNavigatorSaveItem.Text = "Save Data";
            this.publisherBindingNavigatorSaveItem.Click += new System.EventHandler(this.publisherBindingNavigatorSaveItem_Click);
            // 
            // tsDeleteAssignments
            // 
            this.tsDeleteAssignments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteAssignments.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteAssignments.Image")));
            this.tsDeleteAssignments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteAssignments.Name = "tsDeleteAssignments";
            this.tsDeleteAssignments.Size = new System.Drawing.Size(29, 24);
            this.tsDeleteAssignments.Text = "Delete publiser assignments";
            this.tsDeleteAssignments.ToolTipText = "Delete assignments";
            this.tsDeleteAssignments.Click += new System.EventHandler(this.tsDeleteAssignments_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.publisherBindingSource, "picture", true));
            this.picturePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.Image")));
            this.picturePictureBox.Location = new System.Drawing.Point(507, 192);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(223, 219);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 167;
            this.picturePictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Location = new System.Drawing.Point(507, 418);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(224, 46);
            this.btnBrowse.TabIndex = 165;
            this.btnBrowse.Text = "&Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemoveImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveImage.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveImage.Location = new System.Drawing.Point(507, 473);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(227, 46);
            this.btnRemoveImage.TabIndex = 166;
            this.btnRemoveImage.Text = "&Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "group", true));
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Group 1",
            "Group 2",
            "Group 3",
            "Group 4",
            "Group 5",
            "Group 6",
            "Group 7",
            "Group 8",
            "Group 9",
            "Group 10"});
            this.groupComboBox.Location = new System.Drawing.Point(165, 511);
            this.groupComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(265, 24);
            this.groupComboBox.TabIndex = 188;
            this.groupComboBox.Click += new System.EventHandler(this.groupComboBox_Click);
            // 
            // publisher_typeComboBox
            // 
            this.publisher_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "publisher_type", true));
            this.publisher_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisher_typeComboBox.FormattingEnabled = true;
            this.publisher_typeComboBox.Items.AddRange(new object[] {
            "Non-Publisher",
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.publisher_typeComboBox.Location = new System.Drawing.Point(165, 475);
            this.publisher_typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisher_typeComboBox.Name = "publisher_typeComboBox";
            this.publisher_typeComboBox.Size = new System.Drawing.Size(265, 24);
            this.publisher_typeComboBox.TabIndex = 186;
            // 
            // privilegeComboBox
            // 
            this.privilegeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "privilege", true));
            this.privilegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegeComboBox.FormattingEnabled = true;
            this.privilegeComboBox.Items.AddRange(new object[] {
            "n/a",
            "Elder",
            "Ministerial Servant"});
            this.privilegeComboBox.Location = new System.Drawing.Point(165, 439);
            this.privilegeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.privilegeComboBox.Name = "privilegeComboBox";
            this.privilegeComboBox.Size = new System.Drawing.Size(265, 24);
            this.privilegeComboBox.TabIndex = 184;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(165, 404);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(265, 24);
            this.genderComboBox.TabIndex = 182;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.publisherBindingSource, "active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(165, 364);
            this.activeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(267, 30);
            this.activeCheckBox.TabIndex = 180;
            this.activeCheckBox.Text = "To be skipped";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(165, 330);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(265, 22);
            this.addressTextBox.TabIndex = 178;
            this.addressTextBox.Click += new System.EventHandler(this.addressTextBox_Click);
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(165, 295);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(265, 22);
            this.contactTextBox.TabIndex = 176;
            this.contactTextBox.Click += new System.EventHandler(this.contactTextBox_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publisherBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(165, 261);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dobDateTimePicker.TabIndex = 174;
            this.dobDateTimePicker.Value = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            // 
            // other_namesTextBox
            // 
            this.other_namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "other_names", true));
            this.other_namesTextBox.Location = new System.Drawing.Point(165, 226);
            this.other_namesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.other_namesTextBox.Name = "other_namesTextBox";
            this.other_namesTextBox.Size = new System.Drawing.Size(265, 22);
            this.other_namesTextBox.TabIndex = 172;
            this.other_namesTextBox.Click += new System.EventHandler(this.other_namesTextBox_Click);
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(165, 192);
            this.last_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(265, 22);
            this.last_nameTextBox.TabIndex = 170;
            this.last_nameTextBox.Click += new System.EventHandler(this.last_nameTextBox_Click);
            // 
            // btnDob
            // 
            this.btnDob.Location = new System.Drawing.Point(439, 258);
            this.btnDob.Margin = new System.Windows.Forms.Padding(4);
            this.btnDob.Name = "btnDob";
            this.btnDob.Size = new System.Drawing.Size(57, 28);
            this.btnDob.TabIndex = 189;
            this.btnDob.Text = "DEL";
            this.btnDob.UseVisualStyleBackColor = true;
            this.btnDob.Click += new System.EventHandler(this.btnDob_Click);
            // 
            // tbDobMask
            // 
            this.tbDobMask.BackColor = System.Drawing.Color.White;
            this.tbDobMask.ForeColor = System.Drawing.Color.White;
            this.tbDobMask.Location = new System.Drawing.Point(164, 261);
            this.tbDobMask.Margin = new System.Windows.Forms.Padding(4);
            this.tbDobMask.Name = "tbDobMask";
            this.tbDobMask.Size = new System.Drawing.Size(224, 22);
            this.tbDobMask.TabIndex = 190;
            this.tbDobMask.Visible = false;
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AllowUserToAddRows = false;
            this.publisherDataGridView.AllowUserToDeleteRows = false;
            this.publisherDataGridView.AllowUserToOrderColumns = true;
            this.publisherDataGridView.AllowUserToResizeColumns = false;
            this.publisherDataGridView.AllowUserToResizeRows = false;
            this.publisherDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dob,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.publisherDataGridView.DataSource = this.publisherBindingSource;
            this.publisherDataGridView.Location = new System.Drawing.Point(784, 192);
            this.publisherDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.publisherDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.publisherDataGridView.Size = new System.Drawing.Size(480, 558);
            this.publisherDataGridView.TabIndex = 4;
            this.publisherDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.publisherDataGridView_RowEnter);
            this.publisherDataGridView.SelectionChanged += new System.EventHandler(this.publisherDataGridView_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(31, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cmbPubliserType);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.cmbPrivilege);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1208, 68);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(1069, 20);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(119, 34);
            this.btnClearFilter.TabIndex = 345;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(943, 21);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 34);
            this.btnFilter.TabIndex = 344;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbPubliserType
            // 
            this.cmbPubliserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubliserType.FormattingEnabled = true;
            this.cmbPubliserType.Items.AddRange(new object[] {
            "",
            "Non - Publisher",
            "Unbaptized Publisher",
            "Baptized Publisher"});
            this.cmbPubliserType.Location = new System.Drawing.Point(565, 26);
            this.cmbPubliserType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPubliserType.Name = "cmbPubliserType";
            this.cmbPubliserType.Size = new System.Drawing.Size(164, 24);
            this.cmbPubliserType.TabIndex = 177;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(69, 27);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(96, 24);
            this.cmbGender.TabIndex = 173;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Publisher type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 170;
            this.label1.Text = "Privilege :";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "",
            "Group 1",
            "Group 2",
            "Group 3",
            "Group 4",
            "Group 5",
            "Group 6",
            "Group 7",
            "Group 8",
            "Group 9",
            "Group 10"});
            this.cmbGroup.Location = new System.Drawing.Point(821, 27);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(95, 24);
            this.cmbGroup.TabIndex = 175;
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilege.FormattingEnabled = true;
            this.cmbPrivilege.Items.AddRange(new object[] {
            "",
            "n/a",
            "Elder",
            "Ministerial Servant"});
            this.cmbPrivilege.Location = new System.Drawing.Point(265, 26);
            this.cmbPrivilege.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(164, 24);
            this.cmbPrivilege.TabIndex = 171;
            this.cmbPrivilege.Click += new System.EventHandler(this.cmbGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 174;
            this.label4.Text = "Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 172;
            this.label2.Text = " Gender :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(833, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(393, 62);
            this.groupBox2.TabIndex = 192;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter by publisher";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "publisher_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "publisher_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "other_names";
            this.dataGridViewTextBoxColumn3.HeaderText = "Other Name(s)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 186;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "dob";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.Visible = false;
            this.dob.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact";
            this.dataGridViewTextBoxColumn5.HeaderText = "contact";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "To be skipped";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "picture";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "gender";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "privilege";
            this.dataGridViewTextBoxColumn8.HeaderText = "privilege";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "publisher_type";
            this.dataGridViewTextBoxColumn9.HeaderText = "publisher_type";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "group";
            this.dataGridViewTextBoxColumn10.HeaderText = "group";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 790);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.publisherDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDobMask);
            this.Controls.Add(this.publisherBindingNavigator);
            this.Controls.Add(this.btnDob);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(other_namesLabel);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.other_namesTextBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(dobLabel);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.publisher_typeComboBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(publisher_typeLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.privilegeComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(privilegeLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPublishers_FormClosed);
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).EndInit();
            this.publisherBindingNavigator.ResumeLayout(false);
            this.publisherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othernamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private TMSADataSetTableAdapters.publisherTableAdapter publisherTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publisherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton publisherBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton tsDeleteAssignments;
        private System.Windows.Forms.PictureBox picturePictureBox;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox publisher_typeComboBox;
        private System.Windows.Forms.ComboBox privilegeComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox other_namesTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.Button btnDob;
        private System.Windows.Forms.TextBox tbDobMask;
        private System.Windows.Forms.DataGridView publisherDataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPubliserType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}


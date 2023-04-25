namespace TMSA
{
    partial class frmCounselPoints
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label study_numberLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCounselPoints));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counselpointidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isreadingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdemonstrationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isdiscourseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counsel_pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSADataSet = new TMSA.TMSADataSet();
            this.counsel_pointTableAdapter = new TMSA.TMSADataSetTableAdapters.counsel_pointTableAdapter();
            this.tableAdapterManager = new TMSA.TMSADataSetTableAdapters.TableAdapterManager();
            this.counsel_pointBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.counsel_pointBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.counsel_pointDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.study_numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            study_numberLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointBindingNavigator)).BeginInit();
            this.counsel_pointBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study_numberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(42, 169);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 31;
            descriptionLabel.Text = "Description:";
            // 
            // study_numberLabel1
            // 
            study_numberLabel1.AutoSize = true;
            study_numberLabel1.Location = new System.Drawing.Point(42, 124);
            study_numberLabel1.Name = "study_numberLabel1";
            study_numberLabel1.Size = new System.Drawing.Size(75, 13);
            study_numberLabel1.TabIndex = 193;
            study_numberLabel1.Text = "Study number:";
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
            // counsel_pointBindingSource
            // 
            this.counsel_pointBindingSource.DataMember = "counsel_point";
            this.counsel_pointBindingSource.DataSource = this.tMSADataSet;
            // 
            // tMSADataSet
            // 
            this.tMSADataSet.DataSetName = "TMSADataSet";
            this.tMSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counsel_pointTableAdapter
            // 
            this.counsel_pointTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.counsel_pointTableAdapter = this.counsel_pointTableAdapter;
            this.tableAdapterManager.publisher_assignmentTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TMSA.TMSADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // counsel_pointBindingNavigator
            // 
            this.counsel_pointBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.counsel_pointBindingNavigator.BindingSource = this.counsel_pointBindingSource;
            this.counsel_pointBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.counsel_pointBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.counsel_pointBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.counsel_pointBindingNavigatorSaveItem});
            this.counsel_pointBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.counsel_pointBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.counsel_pointBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.counsel_pointBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.counsel_pointBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.counsel_pointBindingNavigator.Name = "counsel_pointBindingNavigator";
            this.counsel_pointBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.counsel_pointBindingNavigator.Size = new System.Drawing.Size(689, 25);
            this.counsel_pointBindingNavigator.TabIndex = 4;
            this.counsel_pointBindingNavigator.Text = "bindingNavigator1";
            this.counsel_pointBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.counsel_pointBindingNavigator_ItemClicked);
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
            // counsel_pointBindingNavigatorSaveItem
            // 
            this.counsel_pointBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.counsel_pointBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("counsel_pointBindingNavigatorSaveItem.Image")));
            this.counsel_pointBindingNavigatorSaveItem.Name = "counsel_pointBindingNavigatorSaveItem";
            this.counsel_pointBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.counsel_pointBindingNavigatorSaveItem.Text = "Save Data";
            this.counsel_pointBindingNavigatorSaveItem.Click += new System.EventHandler(this.counsel_pointBindingNavigatorSaveItem_Click);
            // 
            // counsel_pointDataGridView
            // 
            this.counsel_pointDataGridView.AllowUserToAddRows = false;
            this.counsel_pointDataGridView.AllowUserToDeleteRows = false;
            this.counsel_pointDataGridView.AllowUserToResizeColumns = false;
            this.counsel_pointDataGridView.AllowUserToResizeRows = false;
            this.counsel_pointDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.counsel_pointDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.counsel_pointDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.counsel_pointDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3});
            this.counsel_pointDataGridView.DataSource = this.counsel_pointBindingSource;
            this.counsel_pointDataGridView.Location = new System.Drawing.Point(288, 121);
            this.counsel_pointDataGridView.Name = "counsel_pointDataGridView";
            this.counsel_pointDataGridView.ReadOnly = true;
            this.counsel_pointDataGridView.Size = new System.Drawing.Size(356, 349);
            this.counsel_pointDataGridView.TabIndex = 7;
            this.counsel_pointDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.counsel_pointDataGridView_RowEnter);
            this.counsel_pointDataGridView.SelectionChanged += new System.EventHandler(this.counsel_pointDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "counsel_point_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "counsel_point_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "study_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Study Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 196;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(327, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 57);
            this.groupBox2.TabIndex = 193;
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
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.counsel_pointBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(134, 157);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 60);
            this.descriptionTextBox.TabIndex = 32;
            this.descriptionTextBox.Click += new System.EventHandler(this.descriptionTextBox_Click);
            // 
            // study_numberNumericUpDown
            // 
            this.study_numberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.counsel_pointBindingSource, "study_number", true));
            this.study_numberNumericUpDown.Location = new System.Drawing.Point(134, 122);
            this.study_numberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.study_numberNumericUpDown.Name = "study_numberNumericUpDown";
            this.study_numberNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.study_numberNumericUpDown.TabIndex = 194;
            this.study_numberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCounselPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 505);
            this.Controls.Add(study_numberLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.counsel_pointDataGridView);
            this.Controls.Add(this.counsel_pointBindingNavigator);
            this.Controls.Add(this.study_numberNumericUpDown);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "frmCounselPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counsel Points";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCounselPoints_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCounselPoints_FormClosed);
            this.Load += new System.EventHandler(this.frmCounselPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointBindingNavigator)).EndInit();
            this.counsel_pointBindingNavigator.ResumeLayout(false);
            this.counsel_pointBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counsel_pointDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study_numberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counselpointidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isreadingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdemonstrationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdiscourseDataGridViewCheckBoxColumn;
        private TMSADataSet tMSADataSet;
        private System.Windows.Forms.BindingSource counsel_pointBindingSource;
        private TMSADataSetTableAdapters.counsel_pointTableAdapter counsel_pointTableAdapter;
        private TMSADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator counsel_pointBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton counsel_pointBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView counsel_pointDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown study_numberNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace TMSA
{
    public partial class frmAssignments : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        bool isDirty = false;
        bool rowsDeleted = false;
        bool bindingNavigator_ItemClicked = false;
        bool focus_set = false;
        int position = -1;

        public frmAssignments(string id)
        {
            assignmentid = id;
            InitializeComponent();

            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            tbFromMask.BackColor = Color.White;
            tbFromMask.ForeColor = Color.White;
            tbFromMask.ReadOnly = true;

            tbToMask.BackColor = Color.White;
            tbToMask.ForeColor = Color.White;
            tbToMask.ReadOnly = true;

            tbFromMask.Visible = true;
            tbToMask.Visible = true;
        }

        public String assignmentid
        {
            get;
            set;
        }

        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tMSADataSet.counsel_point' table. You can move, or remove it, as needed.
            this.counsel_pointTableAdapter.Fill(this.tMSADataSet.counsel_point);
            // TODO: This line of code loads data into the 'tMSADataSet.publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.tMSADataSet.publisher);
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisher_assignmentTableAdapter.Fill(this.tMSADataSet.publisher_assignment);
                this.assignment_viewTableAdapter.Fill(this.tMSADataSet.assignment_view);
                publisher_assignmentDataGridView.Sort(this.publisher_assignmentDataGridView.Columns[4], ListSortDirection.Ascending);

                if (assignmentid != null)
                {
                    int index = publisher_assignmentBindingSource.Find("publisher_assignment_id", assignmentid);

                    if (index >= 0)
                    {
                        publisher_assignmentBindingSource.Position = index;
                    }                   
                }
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            loadDgv();

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();
        }

        private void loadDgv()
        {            
            foreach (DataGridViewRow row in publisher_assignmentDataGridView.Rows)
            {
                //assignment_viewBindingSource.Position = assignment_viewBindingSource.Find("publisher_assignment_id", row.Cells[0].Value);
                //row.Cells[10].Value = ((DataRowView)assignment_viewBindingSource.Current)["publisher_name"];
                //row.Cells[11].Value = ((DataRowView)assignment_viewBindingSource.Current)["assistant_name"];
                //row.Cells[12].Value = ((DataRowView)assignment_viewBindingSource.Current)["study_number"] + ". " + ((DataRowView)assignment_viewBindingSource.Current)["description"];

                row.Cells["publisher_name"].Value = row.Cells["publisher_other_names"].FormattedValue.ToString().Trim() + " " + row.Cells["publisher_last_name"].FormattedValue.ToString().Trim();
                row.Cells["assistant_name"].Value = row.Cells["assistant_other_names"].FormattedValue.ToString().Trim() + " " + row.Cells["assistant_last_name"].FormattedValue.ToString().Trim();
                row.Cells["counsel_point"].Value = row.Cells["study_number"].FormattedValue.ToString().Trim() + ". " + row.Cells["description"].FormattedValue.ToString().Trim();
            }
            if (publisher_assignmentDataGridView.CurrentRow != null)
            {
                if (publisher_assignmentDataGridView.CurrentRow.Cells[10].Value != null)
                {
                    tbPublisherName.Text = publisher_assignmentDataGridView.CurrentRow.Cells[10].Value.ToString();
                }
                else
                {
                    tbPublisherName.Clear();
                }

                if (publisher_assignmentDataGridView.CurrentRow.Cells[11].Value != null)
                {
                    tbAssinstantName.Text = publisher_assignmentDataGridView.CurrentRow.Cells[11].Value.ToString();
                }
                else
                {
                    tbAssinstantName.Clear();
                }

                if (publisher_assignmentDataGridView.CurrentRow.Cells[12].Value != null)
                {
                    tbCounselPoint.Text = publisher_assignmentDataGridView.CurrentRow.Cells[12].Value.ToString();
                }
                else
                {
                    tbCounselPoint.Clear();
                }
            }
            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void publisher_assignmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveDocument();
        }

        public bool SaveDocument()
        {
            try
            {
                this.Validate();
                this.publisher_assignmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tMSADataSet);
                _dirtyTracker.MarkAsClean();
                rowsDeleted = false;
                return true;
            }
            catch (Exception ex)
            {
                ex.sqlexception();
                return false;
            }
        }
       
        private void btnchoosePublisher_Click(object sender, EventArgs e)
        {
            if (position != -1)
            {                
                publisher_assignmentBindingSource.Position = position;
                position = -1;
            }
            Cursor.Current = Cursors.WaitCursor;            
            Singleton.ShowChoosePublisher();            
        }       

        private void btnChooseAssistant_Click(object sender, EventArgs e)
        {
            if (position != -1)
            {
                publisher_assignmentBindingSource.Position = position;
                position = -1;
            }
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowChooseAssistant();
        }

        private void btnChooseCounselPoint_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowChooseCounselPoints(Convert.ToInt32(publisher_idTextBox.Text));
        }

        public void onChoosePublisherCloseInit(String id)
        {               
            publisher_assignmentDataGridView.CurrentRow.Cells["publisher_other_names"].Value = id;
            publisher_assignmentDataGridView.CurrentRow.Cells["publisher_last_name"].Value = id;
            String name = publisher_assignmentDataGridView.CurrentRow.Cells["publisher_other_names"].FormattedValue.ToString().Trim() + " " + publisher_assignmentDataGridView.CurrentRow.Cells["publisher_last_name"].FormattedValue.ToString().Trim(); 

            publisher_assignmentDataGridView.CurrentRow.Cells["publisher_name"].Value = name;
            tbPublisherName.Text = name;

            publisher_idTextBox.Text = id;           
        }

        public void onChooseAssistantCloseInit(String id)
        {
            publisher_assignmentDataGridView.CurrentRow.Cells["assistant_other_names"].Value = id;
            publisher_assignmentDataGridView.CurrentRow.Cells["assistant_last_name"].Value = id;
            String name = publisher_assignmentDataGridView.CurrentRow.Cells["assistant_other_names"].FormattedValue.ToString().Trim() + " " + publisher_assignmentDataGridView.CurrentRow.Cells["assistant_last_name"].FormattedValue.ToString().Trim();

            publisher_assignmentDataGridView.CurrentRow.Cells["assistant_name"].Value = name;
            tbAssinstantName.Text = name;

            assistant_idTextBox.Text = id;
        }

        public void onChooseCounselPointCloseInit(String id)
        {
            publisher_assignmentDataGridView.CurrentRow.Cells["study_number"].Value = id;
            publisher_assignmentDataGridView.CurrentRow.Cells["description"].Value = id;
            String counselpoint = publisher_assignmentDataGridView.CurrentRow.Cells["study_number"].FormattedValue.ToString().Trim() + ". " + publisher_assignmentDataGridView.CurrentRow.Cells["description"].FormattedValue.ToString().Trim();

            publisher_assignmentDataGridView.CurrentRow.Cells["counsel_point"].Value = counselpoint;
            tbCounselPoint.Text = counselpoint;

            counsel_point_idTextBox.Text = id;
        }

        private void publisher_idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(publisher_idTextBox.Text))
            {
                tbCounselPoint.Visible = true;
                btnChooseCounselPoint.Visible = true;
            }
            else
            {
                tbCounselPoint.Visible = false;
                btnChooseCounselPoint.Visible = false;
            }
        }

        private void publisher_assignmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (publisher_assignmentDataGridView.CurrentRow == null)
            {
                return;
            }

            List<String> halls = new List<string>();
            halls.Add("1. Main hall");
            halls.Add("2. Auxiliary classroom 1");
            halls.Add("3. Auxiliary classoom 2");
            hallComboBox.SelectedIndex = halls.IndexOf(publisher_assignmentDataGridView.CurrentRow.Cells[9].Value.ToString().Trim());

            if (publisher_assignmentDataGridView.CurrentRow.Cells[10].Value == null)
            {
                tbPublisherName.Clear();
            }
            else
            {
                tbPublisherName.Text = publisher_assignmentDataGridView.CurrentRow.Cells[10].Value.ToString();
            }
            if (publisher_assignmentDataGridView.CurrentRow.Cells[11].Value == null)
            {
                tbAssinstantName.Clear();
            }
            else
            {
                tbAssinstantName.Text = publisher_assignmentDataGridView.CurrentRow.Cells[11].Value.ToString();
            }
            if (publisher_assignmentDataGridView.CurrentRow.Cells[12].Value == null)
            {
                tbCounselPoint.Clear();
            }
            else
            {
                tbCounselPoint.Text = publisher_assignmentDataGridView.CurrentRow.Cells[12].Value.ToString();
            }

            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void btnDeleteAssistant_Click(object sender, EventArgs e)
        {
            publisher_assignmentDataGridView.CurrentRow.Cells[2].Value = DBNull.Value;
            tbAssinstantName.Clear();
        }

        private void assignment_typeComboBox_Click(object sender, EventArgs e)
        {
            assignment_typeComboBox.Text = assignment_typeComboBox.Text.Trim();
        }       

        private void frmAssignments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.assignments = null;
        }

        private void publisher_assignmentDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (publisher_assignmentDataGridView.CurrentRow == null)
            {
                return;
            }

            for (int index = e.RowIndex; index <= e.RowIndex + e.RowCount - 1; index++)
            {
                //publisher_assignmentDataGridView.Rows[index].Cells[4].Value = week_start_dateDateTimePicker.Value;
                //publisher_assignmentDataGridView.Rows[index].Cells[5].Value = week_end_dateDateTimePicker.Value;
                //publisher_assignmentDataGridView.Rows[index].Cells[6].Value = date_assignedDateTimePicker.Value;
                //publisher_assignmentDataGridView.Rows[index].Cells[7].Value = date_completedDateTimePicker.Value;
            }
        }
        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {            
            bindingNavigator_ItemClicked = false;
            position = publisher_assignmentBindingSource.Position;
            publisher_assignmentDataGridView.CurrentRow.Cells[4].Value = week_start_dateDateTimePicker.Value;
            publisher_assignmentDataGridView.CurrentRow.Cells[5].Value = week_end_dateDateTimePicker.Value;
            publisher_assignmentDataGridView.CurrentRow.Cells[6].Value = date_assignedDateTimePicker.Value;        
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            bool validated = true;
            if (tbFromMask.Visible == true)
            {
                errorProvider1.SetError(tbFromMask, "Please choose date.");
                validated = false;
            }
             if (tbToMask.Visible == true)
            {
                errorProvider1.SetError(tbToMask, "Please choose date.");
                validated = false;
            }
            if (validated)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.publisher_assignmentTableAdapter.FillByDate(this.tMSADataSet.publisher_assignment, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.AddDays(1).ToString());
                    loadDgv();
                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                } 
            }
            else
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Please correct error(s).");
                messageBox.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
            tbFromMask.Visible = true;
            tbToMask.Visible = true;
            errorProvider1.Clear();
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisher_assignmentTableAdapter.Fill(this.tMSADataSet.publisher_assignment);
                this.assignment_viewTableAdapter.Fill(this.tMSADataSet.assignment_view);
                publisher_assignmentDataGridView.Sort(this.publisher_assignmentDataGridView.Columns[4], ListSortDirection.Ascending);

                if (assignmentid != null)
                {
                    int index = publisher_assignmentBindingSource.Find("publisher_assignment_id", assignmentid);

                    if (index >= 0)
                    {
                        publisher_assignmentBindingSource.Position = index;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }

            loadDgv();
        }

        private void frmAssignments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (publisher_assignmentDataGridView.RowCount < 1)
            {
                if (isDirty)
                {
                    savePropt(e);
                }
            }
            else if (rowsDeleted || (_dirtyTracker != null && _dirtyTracker.IsDirty))
            {
                savePropt(e);
            }
        }

        public bool saved()
        {
            bool all_saved = true;
            if (publisher_assignmentDataGridView.RowCount < 1)
            {
                if (isDirty)
                {
                    all_saved = false;
                }
            }
            else if (rowsDeleted || (_dirtyTracker != null && _dirtyTracker.IsDirty))
            {
                all_saved = false;
            }
            return all_saved;
        }

        private void savePropt(FormClosingEventArgs e)
        {
            frmMessageBoxForm messageBox = new frmMessageBoxForm("Save changes before closing?");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.cancel = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();

            switch (result)
            {
                case DialogResult.Yes:
                    Cursor.Current = Cursors.WaitCursor;
                    if (!SaveDocument())
                    {
                        e.Cancel = true;
                    }
                    break;

                case DialogResult.No:
                    // just allow the form to close
                    // without saving
                    break;

                case DialogResult.Cancel:
                    // cancel the close
                    e.Cancel = true;
                    break;
            }
        }

        internal void focusRow(String id)
        {
            int index = publisher_assignmentBindingSource.Find("publisher_assignment_id", id);

            if (index >= 0)
            {
                if (_dirtyTracker != null)
                {
                    focus_set = true;
                    isDirty = _dirtyTracker.IsDirty ? true : false;
                }
                publisher_assignmentBindingSource.Position = index;
            }
        }

        private void fromDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbFromMask.Visible = false;
        }

        private void toDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbToMask.Visible = false;
        }

        private void bindingNavigatorDeleteItem_LocationChanged(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = false;

        }

        private void bindingNavigatorDeleteItem_EnabledChanged(object sender, EventArgs e)
        {
            if (publisher_assignmentDataGridView.CurrentRow == null)
            {
                return;
            }
            if (bindingNavigatorDeleteItem.Enabled == false)
            {
                tbCounselPoint.Clear();
                tbAssinstantName.Clear();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            rowsDeleted = true;
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void publisher_assignmentBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void publisher_assignmentDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (focus_set || bindingNavigator_ItemClicked || publisher_assignmentDataGridView.CurrentRow == null)
            {
                bindingNavigator_ItemClicked = false;
                focus_set = false;
                return;
            }

            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        string oldValue = "";
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && bindingNavigatorPositionItem.Text != oldValue)
            {
                oldValue = bindingNavigatorPositionItem.Text;
                if (_dirtyTracker != null)
                {
                    bindingNavigator_ItemClicked = true;
                    isDirty = _dirtyTracker.IsDirty ? true : false;
                }
            }
        }

        private void publisher_assignmentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void publisher_assignmentDataGridView_Sorted(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
            loadDgv();
        }
    }
}

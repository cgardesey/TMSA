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
    public partial class frmPublishers : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        bool isDirty = false;
        bool rowsDeleted = false;
        bool bindingNavigator_ItemClicked = false;

        public frmPublishers()
        {
            InitializeComponent();
            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            tbDobMask.BackColor = Color.White;
            tbDobMask.ForeColor = Color.White;
            tbDobMask.ReadOnly = true;
        }

        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;
        private void frmPublisher_Load(object sender, EventArgs e)
        {

            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.publisherTableAdapter.Fill(this.tMSADataSet.publisher);
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();
        }

        private void loadDeletableStatus()
        {
            try
            {
                con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                con.Open();
                sqlstr = "SELECT [publisher_id] FROM [dbo].[publisher_assignment] WHERE [publisher_id] IS NOT NULL UNION SELECT [assistant_id] FROM [dbo].[publisher_assignment] WHERE [assistant_id] IS NOT NULL";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int index = publisherBindingSource.Find("publisher_id", dr["publisher_id"].ToString());
                    if (index > -1)
                    {
                        publisherDataGridView.Rows[index].Cells[12].Value = true; 
                    }
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Select Image";
                openFileDialog1.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    picturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturePictureBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picturePictureBox.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                publisherBindingSource.Filter = "last_name LIKE '%" + searchstring + "%' OR other_names LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void publisherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveDocument();
        }

        public bool SaveDocument()
        {
            try
            {
                this.Validate();
                this.publisherBindingSource.EndEdit();
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

        private void publisherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }        

            if (publisherDataGridView.CurrentRow.Cells[3].Value == DBNull.Value)
            {
                tbDobMask.Visible = true;
            }
            else
            {
                tbDobMask.Visible = false;
            }


            List<String> genders = new List<string>();
            genders.Add("Male");
            genders.Add("Female");
            
            List<String> privileges = new List<string>();
            privileges.Add("n/a");
            privileges.Add("Elder");
            privileges.Add("Ministerial Servant");
            
            List<String> publisher_types = new List<string>();
            publisher_types.Add("Non - Publisher");
            publisher_types.Add("Unbaptized Publisher");
            publisher_types.Add("Baptized Publisher");

            List<String> groups = new List<string>();
            groups.Add("Group 1");
            groups.Add("Group 2");
            groups.Add("Group 3");
            groups.Add("Group 4");
            groups.Add("Group 5");
            groups.Add("Group 6");
            groups.Add("Group 7");
            groups.Add("Group 8");
            groups.Add("Group 9");
            groups.Add("Group 10");

            genderComboBox.SelectedIndex = genders.IndexOf(publisherDataGridView.CurrentRow.Cells[8].Value.ToString().Trim());
            privilegeComboBox.SelectedIndex = privileges.IndexOf(publisherDataGridView.CurrentRow.Cells[9].Value.ToString().Trim());
            publisher_typeComboBox.SelectedIndex = publisher_types.IndexOf(publisherDataGridView.CurrentRow.Cells[10].Value.ToString().Trim());
            groupComboBox.SelectedIndex = groups.IndexOf(publisherDataGridView.CurrentRow.Cells[11].Value.ToString().Trim());

            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void tsDeleteAssignments_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            frmMessageBoxForm messageBox = new frmMessageBoxForm("Delete all assignments for " + other_namesTextBox.Text.Trim() + " " + last_nameTextBox.Text.Trim() + " ?");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "DELETE FROM publisher_assignment WHERE publisher_id = " + publisherDataGridView.CurrentRow.Cells[0].Value.ToString() + " OR assistant_id = " + publisherDataGridView.CurrentRow.Cells[0].Value.ToString();
                    cmd = new SqlCommand(sqlstr, con);
                    dr = cmd.ExecuteReader();
                    //this.getPublisherCounselPointsTableAdapter.Fill(this.tMSADataSet.GetPublisherCounselPoints, publisherId);

                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                return;
            }         
        }

        private void last_nameTextBox_Click(object sender, EventArgs e)
        {
            last_nameTextBox.Text = last_nameTextBox.Text.Trim();
        }

        private void other_namesTextBox_Click(object sender, EventArgs e)
        {
            other_namesTextBox.Text = other_namesTextBox.Text.Trim();
        }

        private void contactTextBox_Click(object sender, EventArgs e)
        {
            contactTextBox.Text = contactTextBox.Text.Trim();
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = addressTextBox.Text.Trim();
        }

        private void groupComboBox_Click(object sender, EventArgs e)
        {
            groupComboBox.Text = groupComboBox.Text.Trim();
        }

        private void cmbGroup_Click(object sender, EventArgs e)
        {
            cmbPrivilege.Text = cmbPrivilege.Text.Trim();
        }

        private void btnDob_Click(object sender, EventArgs e)
        {
            publisherDataGridView.CurrentRow.Cells["dob"].Value = DBNull.Value;
            tbDobMask.Visible = true;
        }

        private void frmPublishers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.publishers = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            tbDobMask.Visible = true;
            publisherDataGridView.CurrentRow.Cells["dob"].Value = DBNull.Value;
            //publisherDataGridView.CurrentRow.Cells["baptisam_date"].Value = DBNull.Value;
            activeCheckBox.Checked = false;
        }        

        private void frmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (publisherDataGridView.RowCount < 1)
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
            if (publisherDataGridView.RowCount < 1)
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            txtSearch.Text = "";
            try
            {
                string filter = "";

                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    filter += "gender = '" + cmbGender.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPrivilege.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "privilege = '" + cmbPrivilege.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPubliserType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "publisher_type = '" + cmbPubliserType.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbGroup.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "group = '" + cmbGroup.Text + "' ";
                }
                publisherBindingSource.Filter = filter;

            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }

            publisherBindingSource.Filter = "";
            txtSearch.Clear();
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void bindingNavigatorDeleteItem_EnabledChanged(object sender, EventArgs e)
        {
            if (publisherDataGridView.CurrentRow == null)
            {
                return;
            }
            if (bindingNavigatorDeleteItem.Enabled == false)
            {
                tbDobMask.Visible = true;
                dobDateTimePicker.Visible = true;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            rowsDeleted = true;
            bindingNavigator_ItemClicked = false;
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

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }     

        private void publisherDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingNavigator_ItemClicked || publisherDataGridView.CurrentRow == null)
            {
                bindingNavigator_ItemClicked = false;
                return;
            }

            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void publisherBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
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

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                toolTip1.SetToolTip(txtSearch, "Double-click to clear text.");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (_dirtyTracker != null)
            {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }
    }
}

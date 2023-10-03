using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSA
{
    public partial class frmCounselPoints : Form
    {
        bool isDirty = false;
        bool rowsDeleted = false;
        bool bindingNavigator_ItemClicked = false;

        public frmCounselPoints()
        {
            InitializeComponent();
            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void counsel_pointBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SaveDocument();
        }

        public bool SaveDocument()
        {
            try
            {
                this.Validate();
                this.counsel_pointBindingSource.EndEdit();
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

        public SlightlyMoreSophisticatedDirtyTracker _dirtyTracker;
        private void frmCounselPoint_Load(object sender, EventArgs e)
        {
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.counsel_pointTableAdapter.Fill(this.tMSADataSet.counsel_point);
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }

            _dirtyTracker = new SlightlyMoreSophisticatedDirtyTracker(this);
            _dirtyTracker.MarkAsClean();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                counsel_pointBindingSource.Filter = " description LIKE '%" + searchstring + "%' ";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void descriptionTextBox_Click(object sender, EventArgs e)
        {
            descriptionTextBox.Text = descriptionTextBox.Text.Trim();
        }

        private void frmCounselPoints_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.counselpoints = null;
        }

        private void frmCounselPoints_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (counsel_pointDataGridView.RowCount < 1)
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
            if (counsel_pointDataGridView.RowCount < 1)
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

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void counsel_pointDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (counsel_pointDataGridView.CurrentRow == null)
            {
                return;
            }
            if (_dirtyTracker != null)
            {
                if (!isDirty)
                {
                    _dirtyTracker.MarkAsClean();
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            rowsDeleted = true;
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
            study_numberNumericUpDown.Value = 1;
            counsel_pointDataGridView.CurrentRow.Cells[0].Value = study_numberNumericUpDown.Value;
        }

        private void counsel_pointDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingNavigator_ItemClicked || counsel_pointDataGridView.CurrentRow == null)
            {
                bindingNavigator_ItemClicked = false;
                return;
            }

            if (_dirtyTracker != null)
           {
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void counsel_pointBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (_dirtyTracker != null)
            {
                bindingNavigator_ItemClicked = true;
                isDirty = _dirtyTracker.IsDirty ? true : false;
            }
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            bindingNavigator_ItemClicked = false;
        }

        string oldValue = "";
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
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

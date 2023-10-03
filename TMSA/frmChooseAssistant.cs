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
    public partial class frmChooseAssistant : Form
    {
        public frmChooseAssistant()
        {
            InitializeComponent();
        }

        private void frmChooseAssistant_Load(object sender, EventArgs e)
        {
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.assistant_last_assignment_viewTableAdapter.Fill(this.tMSADataSet.assistant_last_assignment_view);
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filterString = cmbGroup.Text;
                assistant_last_assignment_viewBindingSource.Filter = "assistant_group LIKE '%" + filterString + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            done();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            //txtSearch.Focus();
        }

        private void cmbGroup_Click(object sender, EventArgs e)
        {

        }

        private void tsReload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.assistant_last_assignment_viewTableAdapter.Fill(this.tMSADataSet.assistant_last_assignment_view);
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void frmChooseAssistant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.chooseassistant = null;
        }      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                assistant_last_assignment_viewBindingSource.Filter = "assistant_name LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            try
            {
                string filter = "";

                if (!string.IsNullOrEmpty(cmbGender.Text))
                {
                    filter += "assistant_gender = '" + cmbGender.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPrivilege.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "assistant_privilege = '" + cmbPrivilege.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbPubliserType.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "assistant_publisher_type = '" + cmbPubliserType.Text + "' ";
                }
                if (!string.IsNullOrEmpty(cmbGroup.Text))
                {
                    if (filter.Length > 0) filter += "AND ";
                    filter += "assistant_group = '" + cmbGroup.Text + "' ";
                }
                assistant_last_assignment_viewBindingSource.Filter = filter;

            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            assistant_last_assignment_viewBindingSource.Filter = "";
            txtSearch.Clear();
        }

        private void tsPublishers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublishers();
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void assistant_last_assignment_viewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            done();
        }

        private void done()
        {
            if (assistant_last_assignment_viewDataGridView.CurrentRow != null)
            {
                Singleton.assignments.onChooseAssistantCloseInit(assistant_last_assignment_viewDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            this.Close();
        }

        private void assistant_last_assignment_viewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1.SetToolTip(assistant_last_assignment_viewDataGridView, "Double-click row to select assistant.");
        }
    }
}

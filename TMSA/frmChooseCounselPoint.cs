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
    public partial class frmChooseCounselPoint : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        int publisherId;
        public frmChooseCounselPoint(int id)
        {
            InitializeComponent();

            publisherId = id;
        }

        private void frmChooseCounselPoint_Load(object sender, EventArgs e)
        {
            try
            {
                this.tMSADataSet.EnforceConstraints = false;
                this.getPublisherCounselPointsTableAdapter.Fill(this.tMSADataSet.GetPublisherCounselPoints, publisherId);
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                getPublisherCounselPointsBindingSource.Filter = " description LIKE '%" + searchstring + "%' ";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            done();
        }

        private void frmChooseCounselPoint_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.choosecounselpoint = null;
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void getPublisherCounselPointsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            done();
        }

        private void done()
        {
            if (getPublisherCounselPointsDataGridView.CurrentRow != null)
            {
                Singleton.assignments.onChooseCounselPointCloseInit(getPublisherCounselPointsDataGridView.CurrentRow.Cells[1].Value.ToString());
            }
            this.Close();
        }

        private void getPublisherCounselPointsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1.SetToolTip(getPublisherCounselPointsDataGridView, "Double-click row to select counsel point.");
        }
    }
}

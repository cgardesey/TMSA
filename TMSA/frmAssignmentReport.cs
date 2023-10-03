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
    public partial class frmAssignmentsReport : Form
    {
        public frmAssignmentsReport()
        {
            InitializeComponent();

            tbFromMask.BackColor = Color.White;
            tbFromMask.ForeColor = Color.White;
            tbFromMask.ReadOnly = true;

            tbToMask.BackColor = Color.White;
            tbToMask.ForeColor = Color.White;
            tbToMask.ReadOnly = true;

            tbFromMask.Visible = true;
            tbToMask.Visible = true;
        }
        #region Form Properties
        private const int CS_DROPSHADOW = 0x00020000;

        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void EmployeeReport_Paint(object sender, PaintEventArgs e)
        {
           // ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion
        public bool EnforceConstraints { get; set; }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            try
            {
                TMSADataSet.EnforceConstraints = false;
                this.assignment_viewTableAdapter.Fill(this.TMSADataSet.assignment_view);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.Close();
                ex.sqlexception();
            }
        }

        private void Label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearch.Text;
                assignment_viewBindingSource.Filter = "publisher_name LIKE '%" + searchString + "%'";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void frmAssignmentsReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.assignmentsreport = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool validated = true;
            if (tbFromMask.Visible == true)
            {
                errorProvider1.SetError(tbFromMask, "Please choose date.");
                errorProvider1.SetIconPadding(this.tbFromMask, -15);

                validated = false;
            }
            if (tbToMask.Visible == true)
            {
                errorProvider1.SetError(tbToMask, "Please choose date.");
                errorProvider1.SetIconPadding(this.tbToMask, -15);
                validated = false;
            }
            if (validated)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.assignment_viewTableAdapter.FillByDate(this.TMSADataSet.assignment_view, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.AddDays(1).ToString());
                    this.reportViewer1.RefreshReport();
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

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            tbFromMask.Visible = true;
            tbToMask.Visible = true;
            errorProvider1.Clear();
            txtSearch.Clear();

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                TMSADataSet.EnforceConstraints = false;
                this.assignment_viewTableAdapter.Fill(this.TMSADataSet.assignment_view);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void fromDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbFromMask.Visible = false;
        }

        private void toDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            tbToMask.Visible = false;
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                toolTip1.SetToolTip(txtSearch, "Double-click to clear text.");
            }
        }
    }
}

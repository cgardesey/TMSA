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
    public partial class frmTabularAssignmentsReport : Form
    {


        public frmTabularAssignmentsReport()
        {
            InitializeComponent();

            fromDateTimePicker.Format = DateTimePickerFormat.Long;
            toDateTimePicker.Format = DateTimePickerFormat.Long;
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
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        #endregion

        public bool EnforceConstraints { get; set; }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                tMSADataSet.EnforceConstraints = false;
                this.assignment_viewTableAdapter.Fill(this.tMSADataSet.assignment_view);
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

        private void Label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Today;
                toDateTimePicker.Value = DateTime.Today;
                this.assignment_viewTableAdapter.FillByDate(this.tMSADataSet.assignment_view, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.AddDays(1).ToString());
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Hyperlink(object sender, Microsoft.Reporting.WinForms.HyperlinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Uri link = new Uri(e.Hyperlink);

            if (link.Authority == "theocraticministryschoolassistant")
            {
                e.Cancel = true; //Cancel the event to avoid opening the browser
                char[] sep = new char[] { '=' };
                var param = link.Query.Split(sep);
                string assignmentId = param[1];
                Singleton.ShowAssignments(assignmentId);
            }
        }

        private void frmTabularAssignmentsReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.tabularassignmetsreport = null;
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
                    this.assignment_viewTableAdapter.FillByDate(this.tMSADataSet.assignment_view, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.AddDays(1).ToString());
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

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tMSADataSet.EnforceConstraints = false;
                this.assignment_viewTableAdapter.Fill(this.tMSADataSet.assignment_view);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
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
        
        private void txtSearchPublisherName_TextChanged(object sender, EventArgs e)
        {

            //txtSearchAssistantName.Text = "";
            try
            {
                string searchString = txtSearchPublisherName.Text;
                assignment_viewBindingSource.Filter = "publisher_name LIKE '%" + searchString + "%'";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }
        
        private void txtSearchAssistantName_TextChanged(object sender, EventArgs e)
        {
            //txtSearchPublisherName.Text = "";
            try
            {
                string searchString = txtSearchAssistantName.Text;
                assignment_viewBindingSource.Filter = "assistant_name LIKE '%" + searchString + "%'";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearchPublisherName_Enter(object sender, EventArgs e)
        {
            txtSearchPublisherName.Clear();
            txtSearchAssistantName.Clear();
        }

        private void txtSearchAssistantName_Enter(object sender, EventArgs e)
        {
            txtSearchPublisherName.Clear();
            txtSearchAssistantName.Clear();
        }
    }
}

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
    public partial class frmMain : Form
    {
        string save_msg = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowPublishers();
        }

        private void btnPublisherAssignments_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowAssignments(null);
        }

        private void btnCounselPoints_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowCounselPoints();
        }

        private void btnPAReports_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowAssignmentsReport();
        }

        private void btnARSkeleton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowAssignmentsReportSkeleton();
        }

        private void btnAssignmentTabularReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowTabularAssignmentsReport();
        }

        private void btnPublishers_MouseEnter(object sender, EventArgs e)
        {
            btnPublishers.ForeColor = Color.White;
        }

        private void btnPublishers_MouseLeave(object sender, EventArgs e)
        {
            btnPublishers.ForeColor = Color.Black;
        }

        private void btnCounselPoints_MouseEnter(object sender, EventArgs e)
        {
            btnCounselPoints.ForeColor = Color.White;
        }

        private void btnCounselPoints_MouseLeave(object sender, EventArgs e)
        {
            btnCounselPoints.ForeColor = Color.Black;
        }

        private void btnPublisherAssignments_MouseEnter(object sender, EventArgs e)
        {
            btnPublisherAssignments.ForeColor = Color.White;
        }

        private void btnPublisherAssignments_MouseLeave(object sender, EventArgs e)
        {
            btnPublisherAssignments.ForeColor = Color.Black;
        }

        private void btnPAReports_MouseEnter(object sender, EventArgs e)
        {
            btnPAReports.ForeColor = Color.White;
        }

        private void btnPAReports_MouseLeave(object sender, EventArgs e)
        {
            btnPAReports.ForeColor = Color.Black;
        }

        private void btnARSkeleton_MouseEnter(object sender, EventArgs e)
        {
            btnARSkeleton.ForeColor = Color.White;
        }

        private void btnARSkeleton_MouseLeave(object sender, EventArgs e)
        {
            btnARSkeleton.ForeColor = Color.Black;
        }

        private void btnAssignmentTabularReport_MouseEnter(object sender, EventArgs e)
        {
            btnAssignmentTabularReport.ForeColor = Color.White;
        }

        private void btnAssignmentTabularReport_MouseLeave(object sender, EventArgs e)
        {
            btnAssignmentTabularReport.ForeColor = Color.Black;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // upon closing, check if the form is dirty; if so, prompt
            // to save changes
            if (!changesSaved())
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm(save_msg);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.cancel = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();

                switch (result)
                {
                    case DialogResult.Yes:
                        Cursor.Current = Cursors.WaitCursor;
                        if (Singleton.publishers != null)
                        {
                            Singleton.publishers.SaveDocument(); 
                        }
                        if (Singleton.counselpoints != null)
                        {
                            Singleton.counselpoints.SaveDocument();
                        }
                        if (Singleton.assignments != null)
                        {
                            Singleton.assignments.SaveDocument();
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
        }

        private bool changesSaved()
        {
            bool saved = true;
            save_msg = "Save changes to the following items?";
            if (Singleton.publishers != null && !Singleton.publishers.saved())
            {
                saved = false;
                save_msg += "\nPublishers*";
            }
            if (Singleton.counselpoints != null && !Singleton.counselpoints.saved())
            {
                saved = false;
                save_msg += "\nCounsel Points*";
            }
            if (Singleton.assignments != null && ! Singleton.assignments.saved())
            {
                saved = false;
                save_msg += "\nAssignments*";
            }
            return saved;
        }

        private void btnApplicationSettings_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowApplicationSettings();
        }

        private void btnApplicationSettings_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Singleton.ShowApplicationSettings();
        }

        private void btnApplicationSettings_MouseEnter(object sender, EventArgs e)
        {
            btnApplicationSettings.ForeColor = Color.White;
        }

        private void btnApplicationSettings_MouseLeave(object sender, EventArgs e)
        {
            btnApplicationSettings.ForeColor = Color.Black;
        }
    }
}

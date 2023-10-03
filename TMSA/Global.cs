using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSA
{
    public static class Extension
    {
        public static int sqlexception (this Exception ex, String text = "")
        {
            var sql2 = ex.GetType();
            var sql = ex.GetBaseException() as SqlException;
            if(sql != null)
            {
                switch (sql.Number)
                {
                    case 2:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm("Cannot Connect to Server");
                            messageBox.ShowDialog();
                            break;
                        }

                    case 2601:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm(text + " Already Exists!");
                            messageBox.ShowDialog();
                            //productNameTextBox.Focus();
                            break;
                        }

                    case 547: // Foreign Key violation
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm(" This operation failed because another data entry uses this entry.");
                            messageBox.ShowDialog();
                            break;
                        }                       
                                          
                    default:
                        {
                            frmMessageBoxForm messageBox = new frmMessageBoxForm("Error code: " + sql.Number.ToString() + ". " + sql.Message);
                            messageBox.ShowDialog();
                            break;
                        }
                }
                return sql.Number;
            }
            else
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm(ex.InnerException.Message);
                messageBox.ShowDialog();
            }
            return 0;
        }        
    }

    public static class Singleton
    {
        public static frmPublishers publishers = null;
        public static frmCounselPoints counselpoints = null;
        public static frmAssignments assignments = null;
        public static frmAssignmentsReport assignmentsreport = null;
        public static frmAssignmentsReportSkeleton assignmentsreportskeleton = null;
        public static frmTabularAssignmentsReport tabularassignmetsreport = null;
        public static frmChoosePublisher choosepublisher = null;
        public static frmChooseAssistant chooseassistant = null;
        public static frmChooseCounselPoint choosecounselpoint = null;
        public static frmApplicationSettings applicationSettings = null;

        public static void ShowPublishers()
        {
            
            if (publishers != null)
            {
                publishers.BringToFront();
                publishers.WindowState = FormWindowState.Normal;
            }
            else
            {
                publishers = new frmPublishers();
                publishers.Show();
            }
        }

        public static void ShowAssignments(String id)
        {

            if (assignments != null)
            {
                assignments.BringToFront();
                assignments.focusRow(id);
                assignments.WindowState = FormWindowState.Normal;
            }
            else
            {
                assignments = new frmAssignments(id);
                assignments.Show();
            }
        }

        public static void ShowCounselPoints()
        {

            if (counselpoints != null)
            {
                counselpoints.BringToFront();
                counselpoints.WindowState = FormWindowState.Normal;
            }
            else
            {
                counselpoints = new frmCounselPoints();
                counselpoints.Show();
            }
        }

        public static void ShowAssignmentsReport()
        {

            if (assignmentsreport != null)
            {
                assignmentsreport.BringToFront();
                assignmentsreport.WindowState = FormWindowState.Normal;
            }
            else
            {
                assignmentsreport = new frmAssignmentsReport();
                assignmentsreport.Show();
            }
        }

        public static void ShowAssignmentsReportSkeleton()
        {

            if (assignmentsreportskeleton != null)
            {
                assignmentsreportskeleton.BringToFront();
                assignmentsreportskeleton.WindowState = FormWindowState.Normal;
            }
            else
            {
                assignmentsreportskeleton = new frmAssignmentsReportSkeleton();
                assignmentsreportskeleton.Show();
            }
        }

        public static void ShowTabularAssignmentsReport()
        {

            if (tabularassignmetsreport != null)
            {
                tabularassignmetsreport.BringToFront();
                tabularassignmetsreport.WindowState = FormWindowState.Normal;
            }
            else
            {
                tabularassignmetsreport = new frmTabularAssignmentsReport();
                tabularassignmetsreport.Show();
            }
        }

        public static void ShowChoosePublisher()
        {

            if (choosepublisher != null)
            {
                choosepublisher.BringToFront();
                choosepublisher.WindowState = FormWindowState.Normal;
            }
            else
            {
                choosepublisher = new frmChoosePublisher();
                choosepublisher.Show();
            }
        }

        public static void ShowChooseAssistant()
        {

            if (chooseassistant != null)
            {
                chooseassistant.BringToFront();
                chooseassistant.WindowState = FormWindowState.Normal;
            }
            else
            {
                chooseassistant = new frmChooseAssistant();
                chooseassistant.Show();
            }
        }

        public static void ShowChooseCounselPoints(int publisherid)
        {

            if (choosecounselpoint != null)
            {
                choosecounselpoint.BringToFront();
                choosecounselpoint.WindowState = FormWindowState.Normal;
            }
            else
            {
                choosecounselpoint = new frmChooseCounselPoint(publisherid);
                choosecounselpoint.Show();
            }
        }

        public static void ShowApplicationSettings()
        {

            if (applicationSettings != null)
            {
                applicationSettings.BringToFront();
                applicationSettings.WindowState = FormWindowState.Normal;
            }
            else
            {
                applicationSettings = new frmApplicationSettings();
                applicationSettings.Show();
            }
        }
    }
}

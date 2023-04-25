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
    public partial class frmBackupAndRestore : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public frmBackupAndRestore()
        {
            InitializeComponent();
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

        private void AddSale_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void AddSale_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void AddSale_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void AddSale_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
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

        private void btnBackupLocBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                backupLocTextBox.Text = dlg.SelectedPath;
            }
        }

        private void btnRestoreLocBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restoreLoctextBox.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(restoreLoctextBox.Text))
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Please specify backup file path.");
                messageBox.ShowDialog();
            }
            else
            {
                try
                {
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "Alter Database TMSA Set SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                    sqlstr += "Restore Database TMSA FROM Disk='" + restoreLoctextBox.Text + "' WITH REPLACE";
                    cmd = new SqlCommand(sqlstr, con);
                    dr = cmd.ExecuteReader();
                    frmMessageBoxForm messageBox = new frmMessageBoxForm("Database successfully restored!");
                    messageBox.ShowDialog();
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
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(backupLocTextBox.Text))
            {
                frmMessageBoxForm messageBox = new frmMessageBoxForm("Please specify backup location.");
                messageBox.ShowDialog();
            }
            else
            {
                try
                {
                    con = new SqlConnection(Properties.Settings.Default.TMSAConnectionString);
                    con.Open();
                    sqlstr = "BACKUP DATABASE TMSA TO DISK = '" + backupLocTextBox.Text + "\\TMSA-" + DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss") + ".bak'";
                    cmd = new SqlCommand(sqlstr, con);
                    dr = cmd.ExecuteReader();
                    frmMessageBoxForm messageBox = new frmMessageBoxForm("Database Backup Successfully Completed!");
                    messageBox.ShowDialog();
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void BackupAndRestore_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }
    }
}

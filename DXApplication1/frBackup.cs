using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frBackup : Form
    {
        public frBackup()
        {
            InitializeComponent();
            if (File.Exists("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\DEVICE_QLDSV_TC.bak"))
            {
                btnDifferent_Backup.Enabled = true;
                btnRestore.Enabled = true;
                checkIsDifferentialRestore.Enabled = true;
            }
            else
            {
                btnDifferent_Backup.Enabled = false;
                btnRestore.Enabled = false;
                checkIsDifferentialRestore.Enabled = false; 
            }
        }

        private void btnDiffBackup_Click(object sender, EventArgs e)
        {
            string cmd = "BACKUP DATABASE [QLDSV_TC] TO  [DEVICE_QLDSV_TC] WITH DIFFERENTIAL, NOFORMAT, NOINIT,  NAME = N'QLDSV_TC-Differential Database Backup " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "'" +
                  ", SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            DialogResult result = MessageBox.Show("Bạn có muốn backup bản differential database?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Backup database thành công");
                    txtBackup.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup";
                }

                else
                {
                    MessageBox.Show("Backup thất bại");
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string cmd = "BACKUP DATABASE [QLDSV_TC] TO  [DEVICE_QLDSV_TC] WITH NOFORMAT, INIT,  NAME = N'QLDSV_TC-Full Database Backup " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "'" +
              ", SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            DialogResult result = MessageBox.Show("Bạn có muốn backup full database?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Backup database thành công");
                    txtBackup.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup";
                    btnFull_Backup.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Backup thất bại");
                }
            }
            if (File.Exists("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\DEVICE_QLDSV_TC.bak"))
            {
                btnDifferent_Backup.Enabled = true;
                btnRestore.Enabled = true;
                checkIsDifferentialRestore.Enabled = true;
            }
            else
            {
                btnDifferent_Backup.Enabled = false;
                btnRestore.Enabled = false;
                checkIsDifferentialRestore.Enabled = false;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (checkIsDifferentialRestore.Checked)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn Restore database differential mới nhất?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {

                    string cmd1 = string.Format("ALTER DATABASE [QLDSV_TC] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    Program.ExecSqlNonQuery(cmd1);

                    string cmd2 = "USE MASTER RESTORE DATABASE [QLDSV_TC] FROM [DEVICE_QLDSV_TC] WITH REPLACE, FILE = 1, NORECOVERY,  NOUNLOAD,  STATS = 5" +
                        "USE MASTER RESTORE DATABASE [QLDSV_TC] FROM  [DEVICE_QLDSV_TC] WITH  FILE = 1,  NORECOVERY,  NOUNLOAD,  REPLACE,  STATS = 5" +
                                    "RESTORE DATABASE [QLDSV_TC] FROM  [DEVICE_QLDSV_TC] WITH  FILE = 2,  NOUNLOAD,  STATS = 5";
                    Program.ExecSqlNonQuery(cmd2);

                    string cmd3 = string.Format("ALTER DATABASE [QLDSV_TC] SET MULTI_USER ");
                    Program.ExecSqlNonQuery(cmd3);

                    txtRestore.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup";

                    MessageBox.Show("Restore database thành công");

                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn Restore database full?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {

                        string cmd1 = string.Format("ALTER DATABASE [QLDSV_TC] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        Program.ExecSqlNonQuery(cmd1);

                        string cmd2 = "USE MASTER RESTORE DATABASE [QLDSV_TC] FROM [DEVICE_QLDSV_TC] WITH REPLACE, FILE = 1,  NOUNLOAD,  STATS = 5";
                        Program.ExecSqlNonQuery(cmd2);

                        string cmd3 = string.Format("ALTER DATABASE [QLDSV_TC] SET MULTI_USER ");
                        Program.ExecSqlNonQuery(cmd3);

                        txtRestore.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup";

                        MessageBox.Show("Restore database thành công");

                    }
                    catch
                    {
                        MessageBox.Show("Restore thất bại");
                    }
                }
            }
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}


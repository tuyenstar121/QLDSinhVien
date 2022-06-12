using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frCapRole : Form
    {
        public frCapRole()
        {
            InitializeComponent();
            cbRoleLoad();
            cbMaUserLoad();
        }

        private void cbRoleLoad()
        {
            DataTable dt = new DataTable();
            string cmd = "Select name From sys.database_principals Where type = 'R' and principal_id < 16384 and principal_id != 0";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbRole.DataSource = bdsgv;
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "name";
        }

        private void cbMaUserLoad()
        {
            DataTable dt = new DataTable();
            string cmd = "with DanhSachUserChuaCoRole (user_name) as " +
                "(SELECT user_name = name FROM sysusers WHERE sysusers.name NOT IN(SELECT members.[name] " +
                "FROM sys.database_role_members " +
                "JOIN sys.database_principals roles ON database_role_members.role_principal_id = roles.principal_id " +
                "JOIN sys.database_principals members ON database_role_members.member_principal_id = members.principal_id)) " +
                "SELECT name = MASV FROM dbo.SINHVIEN,SYS.sysusers " +
                "WHERE MASV = NAME and name in (SELECT user_name from DanhSachUserChuaCoRole) " +
                "UNION SELECT name = MAGV FROM dbo.GIANGVIEN, SYS.sysusers WHERE MAGV = NAME and name in (SELECT user_name from DanhSachUserChuaCoRole)";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaUser.DataSource = bdsgv;
            cbMaUser.DisplayMember = "name";
            cbMaUser.ValueMember = "name";
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = cbRole.Text;
            string cmd = "SELECT roles.[name] as role, members.[name] as member " +
                "FROM sys.database_role_members  " +
                "JOIN sys.database_principals roles ON database_role_members.role_principal_id = roles.principal_id " +
                "JOIN sys.database_principals members ON database_role_members.member_principal_id = members.principal_id " +
                "WHERE members.[name] = '" + role + "'";

            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;

            List<string> listRole = new List<string>();

            if (Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                    listRole.Add(Program.myReader.GetString(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            bool ownerAlreadyExist = listRole.Contains("db_owner");
            bool accessAlreadyExist = listRole.Contains("db_accessadmin");
            bool writerAlreadyExist = listRole.Contains("db_datawriter");
            bool readerAlreadyExist = listRole.Contains("db_datareader");
            bool backupAlreadyExist = listRole.Contains("db_backupoperator");

            foreach (string item in listRole)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            if (ownerAlreadyExist) checkOwner.Checked = true;
            else checkOwner.Checked = false;

            if (accessAlreadyExist) checkAccessAdmin.Checked = true;
            else checkAccessAdmin.Checked = false;

            if (writerAlreadyExist) checkWriter.Checked = true;
            else checkWriter.Checked = false;

            if (readerAlreadyExist) checkReader.Checked = true;
            else checkReader.Checked = false;

            if (backupAlreadyExist) checkBackup.Checked = true;
            else checkBackup.Checked = false;

            Program.myReader.Close();
            listRole.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string cmd = "ALTER ROLE [" + cbRole.Text + "] ADD MEMBER  [" + cbMaUser.Text + "]";
            if (cbMaUser.Text.Equals(Program.mlogin))
            {
                MessageBox.Show("Không thể thêm User vào Role vì đang đăng nhập vào User này", "Lỗi");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm user này vào role đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                    {
                        MessageBox.Show("Thêm user vào role thành công", "Thông báo");
                        cbMaUserLoad();
                    }
                    else
                        MessageBox.Show("Thêm user vào role thất bại !!!", "Lỗi");
                }
            }
        }
    }
}

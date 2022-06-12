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
    public partial class frXoaCapNhatRole : Form
    {
        public frXoaCapNhatRole()
        {
            InitializeComponent();
            comboBoxload();
        }
        private void comboBoxload()
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

        private void cbRole_SelectionChangeCommitted(object sender, EventArgs e)
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
            string cmd = "DROP ROLE [" + cbRole.Text + "]";
            if (cbRole.Text.Equals(Program.mGroup))
            {
                MessageBox.Show("Không thể xóa role này vì đang đăng nhập tài khoản có role này", "Lỗi");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa role đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                    {
                        MessageBox.Show("Xóa role thành công", "Thông báo");
                        comboBoxload();
                    }
                    else
                        MessageBox.Show("Xóa role thất bại !!!", "Lỗi");
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string cmd1 = "";
            string cmd2 = "";
            string cmd3 = "";
            string cmd4 = "";
            string cmd5 = "";

            if (checkOwner.Checked) cmd1 = " ALTER ROLE[db_owner] ADD MEMBER[" + cbRole.Text + "]";
            else cmd1 = "ALTER ROLE [db_owner] DROP MEMBER [" + cbRole.Text + "]";

            if (checkAccessAdmin.Checked) cmd2 = " ALTER ROLE[db_accessadmin] ADD MEMBER[" + cbRole.Text + "]";
            else cmd2 = "ALTER ROLE [db_accessadmin] DROP MEMBER [" + cbRole.Text + "]";

            if (checkWriter.Checked) cmd3 = " ALTER ROLE[db_datawriter] ADD MEMBER[" + cbRole.Text + "]";
            else cmd3 = "ALTER ROLE [db_datawriter] DROP MEMBER [" + cbRole.Text + "]";

            if (checkReader.Checked) cmd4 = " ALTER ROLE[db_datareader] ADD MEMBER[" + cbRole.Text + "]";
            else cmd4 = "ALTER ROLE [db_datareader] DROP MEMBER [" + cbRole.Text + "]";

            if (checkBackup.Checked) cmd5 = " ALTER ROLE[db_backupoperator] ADD MEMBER[" + cbRole.Text + "]";
            else cmd5 = "ALTER ROLE [db_backupoperator] DROP MEMBER [" + cbRole.Text + "]";

            string cmd = cmd1 + cmd2 + cmd3 + cmd4 + cmd5;

            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật role đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Cập nhật role thành công", "Thông báo");
                    comboBoxload();
                    this.Close();
                    frXoaCapNhatRole f = new frXoaCapNhatRole();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show();
                }
                else
                    MessageBox.Show("Cập nhật role thất bại !!!", "Lỗi");
            }

        }
    }
}

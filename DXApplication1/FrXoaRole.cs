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
    public partial class FrXoaRole : Form
    {
        public FrXoaRole()
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
    }
}

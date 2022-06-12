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
    public partial class frThuHoiCapNhatRole : Form
    {
        string role = "";
        public frThuHoiCapNhatRole()
        {
            InitializeComponent();
            loadCombobox();
            loadCbRole();

        }

        private void loadCombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT name= MASV FROM dbo.SINHVIEN,SYS.sysusers WHERE MASV=NAME UNION SELECT name=MAGV FROM dbo.GIANGVIEN, SYS.sysusers WHERE MAGV=NAME";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaUser.DataSource = bdsgv;
            cbMaUser.DisplayMember = "name";
            cbMaUser.ValueMember = "name";
        }

        private void loadCbRole()
        {

            DataTable dt1 = new DataTable();
            string cmd2 = "Select name From sys.database_principals Where type = 'R' and principal_id < 16384 and principal_id != 0";
            dt1 = Program.ExecSqlDataTable(cmd2);
            BindingSource bdsgv2 = new BindingSource();
            bdsgv2.DataSource = dt1;
            cbRole.DataSource = bdsgv2;
            cbRole.DisplayMember = "name";
            cbRole.ValueMember = "name";
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maUser = cbMaUser.Text;
            string cmd = "SELECT roles.[name] as role_name, members.[name] as user_name " +
                "FROM sys.database_role_members " +
                "JOIN sys.database_principals roles ON database_role_members.role_principal_id = roles.principal_id " +
                "JOIN sys.database_principals members ON database_role_members.member_principal_id = members.principal_id " +
                "WHERE members.[name] = '" + maUser + "'";

            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
            if (Program.myReader.HasRows)
            {
                cbRole.Text = Program.myReader.GetString(0);
                role = Program.myReader.GetString(0);
                btnXacNhan.Enabled = btnCapNhat.Enabled = true;
            }
            else
            {
                MessageBox.Show("User này chưa thuộc role nào", "Thông báo");
                btnXacNhan.Enabled = btnCapNhat.Enabled = false;
            }

            Program.myReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "EXECUTE sp_droprolemember '" + cbRole.Text + "' ,  '" + cbMaUser.Text + "'";
            if (cbMaUser.Text.Equals(Program.mlogin))
            {
                MessageBox.Show("Không thể xóa User ra khỏi Role vì đang đăng nhập vào User này", "Lỗi");
            }
            if (!cbRole.Text.Equals(role))
            {
                MessageBox.Show("Chọn sai role để xóa, vui lòng chọn đúng role của user cần xóa", "Lỗi");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa user ra khỏi role đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                        MessageBox.Show("Xóa user ra khỏi role thành công", "Thông báo");
                    else
                        MessageBox.Show("Xóa user ra khỏi role thất bại !!!", "Lỗi");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string cmd = "ALTER ROLE [" + cbRole.Text + "] ADD MEMBER  [" + cbMaUser.Text + "]"
                + " ALTER ROLE [" + role + "] DROP MEMBER [" + cbMaUser.Text + "]";
            if (!cbRole.Text.Equals(role))
            {
                DialogResult result = MessageBox.Show("Role vừa chọn khác với role hiện tại của user, bạn có chắn chắn muốn chuyển role cho user?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                    {
                        MessageBox.Show("Cập nhật role user thành công", "Thông báo");
                        this.Close();
                        frThuHoiCapNhatRole f = new frThuHoiCapNhatRole();
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.Show();
                    }
                    else
                        MessageBox.Show("Cập nhật role user thất bại !!!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không có gì để cập nhật", "Thông báo");
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}

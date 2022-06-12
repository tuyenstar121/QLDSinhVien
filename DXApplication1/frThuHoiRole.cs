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
    public partial class frThuHoiRole : Form
    {
        public frThuHoiRole()
        {
            InitializeComponent();
            loadCombobox();
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
                txtRole.Text = Program.myReader.GetString(0);
            }
            else
            {
                MessageBox.Show("User này chưa thuộc role nào", "Thông báo");
            }

            Program.myReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "EXECUTE sp_droprolemember '" + txtRole.Text + "' ,  '" + cbMaUser.Text + "'";
            if (cbMaUser.Text.Equals(Program.mlogin))
            {
                MessageBox.Show("Không thể xóa User ra khỏi Role vì đang đăng nhập vào User này", "Lỗi");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa user ra khỏi role đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                    {
                        MessageBox.Show("Xóa user ra khỏi role thành công", "Thông báo");
                        loadCombobox();
                    }
                    else
                        MessageBox.Show("Xóa user ra khỏi role thất bại !!!", "Lỗi");
                }
            }
        }
    }
}

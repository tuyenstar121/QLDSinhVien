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
    public partial class frtaoTK : Form
    {
        public frtaoTK()
        {
            InitializeComponent();
        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT MAGV FROM GIANGVIEN WHERE MAGV NOT IN (SELECT sysusers.name from sysusers)";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbbMAGV.DataSource = bdsgv;
            cbbMAGV.DisplayMember = "MAGV";
            cbbMAGV.ValueMember = "MAGV";
        }
        void loadsvcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT SINHVIEN.MASV FROM SINHVIEN WHERE SINHVIEN.MASV NOT IN (SELECT sysusers.name from sysusers)";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbbMAGV.DataSource = bdsgv;
            cbbMAGV.DisplayMember = "MASV";
            cbbMAGV.ValueMember = "MASV";
        }

        private void rdKHOA_CheckedChanged(object sender, EventArgs e)
        {
            loadGVcombobox();
            cbbMAGV.SelectedIndex = 0;
            txbTenLogin.Enabled = txbMatKhau.Enabled = cbbMAGV.Enabled = txbXacNhanMK.Enabled = true;
        }

        private void rdSV_CheckedChanged(object sender, EventArgs e)
        {
            loadsvcombobox();
            cbbMAGV.SelectedIndex = 0;
            txbTenLogin.Enabled = txbMatKhau.Enabled = cbbMAGV.Enabled = txbXacNhanMK.Enabled = true;
        }

        private void PGV_CheckedChanged(object sender, EventArgs e)
        {
            loadGVcombobox();
            txbTenLogin.Enabled = txbMatKhau.Enabled = cbbMAGV.Enabled = txbXacNhanMK.Enabled = true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txbTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
                txbTenLogin.Focus();
                return;
            }
            if (txbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbMatKhau.Focus();
                return;
            }
            if (txbXacNhanMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (txbXacNhanMK.Text != txbMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (rdKHOA.Checked == false && rdSV.Checked == false && PGV.Checked == false)
            {
                MessageBox.Show("Nhóm quyền không được thiếu!", "", MessageBoxButtons.OK);
                rdKHOA.Focus();
                return;
            }
            string login = txbTenLogin.Text;
            string matkhau = txbMatKhau.Text;
            string user = cbbMAGV.SelectedValue.ToString();
            string role = "";
            if (rdKHOA.Checked) role = "KHOA";
            if (rdSV.Checked) role = "SinhVien";
            if (PGV.Checked) role = "PGV";

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + matkhau + "', " +
                           " @USERNAME = N'" + cbbMAGV.Text.Trim() + "', " +
                           " @ROLE = N'"+role+"' ";

            /* if (role == "PKT" && Program.severname == ((DataRowView)Program.bds_dspm[0])["TENSERVER"].ToString())
             {
                 // site 1 ---> sử dụng LINK2
                 subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +
                             " @LGNAME = N'" + login + "', " +
                             " @PASS = N'" + matkhau + "', " +
                             " @USERNAME = N'" + user + "', " +
                             " @ROLE = N'" + role + "' ";
             }
             else if (role == "PKT" && Program.severname == ((DataRowView)Program.bds_dspm[1])["TENSERVER"].ToString())
             {
                 subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +
                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + matkhau + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
             }*/
            string strLenh = " DECLARE @return_value int " + subLenh +
                    " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Program.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
               MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
               MessageBox.Show("Login bị trùng . Mời bạn nhập login khác !", "", MessageBoxButtons.OK);

            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("Giảng viên đã có tài khoản rồi !", "", MessageBoxButtons.OK);


            }
            else if (resultCheckLogin == 3)
            {
               MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
               MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

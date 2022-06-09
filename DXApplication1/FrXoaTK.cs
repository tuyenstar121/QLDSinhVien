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
    public partial class FrXoaTK : Form
    {
        public FrXoaTK()
        {
            InitializeComponent();
            loadMaNV();
          
        }

        void loadMaNV()
        {

            DataTable dt = new DataTable();
            string cmd = "SELECT MASV FROM dbo.SINHVIEN,SYS.sysusers WHERE MASV=NAME UNION SELECT MAGV FROM dbo.GIANGVIEN, SYS.sysusers WHERE MAGV=NAME";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaNV.DataSource = bdsgv;
            cbMaNV.DisplayMember = "MASV";
            cbMaNV.ValueMember = "MASV";
        }

        void loadTxtLoginName()
        {

        }

        private void rdSV_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT MASV FROM dbo.SINHVIEN,SYS.sysusers WHERE MASV=NAME";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaNV.DataSource = bdsgv;
            cbMaNV.DisplayMember = "MASV";
            cbMaNV.ValueMember = "MASV";
        }

        private void PGV_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cmd = "declare @uid int select @uid = uid from SYS.sysusers where name = 'PGV' select name from SYS.sysusers where uid IN(select memberuid from sysmembers where groupuid = @uid)";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaNV.DataSource = bdsgv;
            cbMaNV.DisplayMember = "name";
            cbMaNV.ValueMember = "name";
        }

        private void rdKHOA_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cmd = "declare @uid int select @uid = uid from SYS.sysusers where name = 'Khoa' select name from SYS.sysusers where uid IN(select memberuid from sysmembers where groupuid = @uid)";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaNV.DataSource = bdsgv;
            cbMaNV.DisplayMember = "name";
            cbMaNV.ValueMember = "name";
        }

        private void cbMaNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (PGV.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();

            }
            else if (rdSV.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, SINHVIEN WHERE NAME=MASV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();
            }
            else if (rdKHOA.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();
            }
        }


        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (PGV.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();

            }
            else if (rdSV.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, SINHVIEN WHERE NAME=MASV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();
            }
            else if (rdKHOA.Checked)
            {
                string maNV = cbMaNV.Text;
                string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                txtLogin.Text = Program.myReader.GetString(0);

                Program.myReader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cmd = "EXEC dbo.Xoa_Login '" + txtLogin.Text + "'";
            if (txtLogin.Text.Equals(Program.mlogin))
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập", "Lỗi");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản đang chọn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (Program.ExecSqlNonQuery(cmd) == 0)
                        MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                    else
                        MessageBox.Show("Xóa tài khoản thất bại !!!", "Lỗi");
                }
            }
        }

       

        //private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (PGV.Checked)
        //    {
        //        string maNV = cbMaNV.Text;
        //        string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

        //        Program.myReader = Program.ExecSqlDataReader(cmd);
        //        if (Program.myReader == null) return;
        //        Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
        //        txtLogin.Text = Program.myReader.GetString(0);

        //        Program.myReader.Close();

        //    }
        //    else if (rdSV.Checked)
        //    {
        //        string maNV = cbMaNV.Text;
        //        string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, SINHVIEN WHERE NAME=MASV AND NAME='" + maNV + "'";

        //        Program.myReader = Program.ExecSqlDataReader(cmd);
        //        if (Program.myReader == null) return;
        //        Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
        //        txtLogin.Text = Program.myReader.GetString(0);

        //        Program.myReader.Close();
        //    }
        //    else if (rdKHOA.Checked)
        //    {
        //        string maNV = cbMaNV.Text;
        //        string cmd = "SELECT SUSER_SNAME(sid) FROM SYS.sysusers, GIANGVIEN WHERE NAME=MAGV AND NAME='" + maNV + "'";

        //        Program.myReader = Program.ExecSqlDataReader(cmd);
        //        if (Program.myReader == null) return;
        //        Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
        //        txtLogin.Text = Program.myReader.GetString(0);

        //        Program.myReader.Close();
        //    }
        //}
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public frDangNhap()
        {

            InitializeComponent();
        }

        private void frDangNhap_Load(object sender, EventArgs e)
        {
            cbbRole.SelectedIndex = 0;

        }
       

            private void button1_Click(object sender, EventArgs e)
            {

                if (txbTaiKhoan.Text.Trim() == "" || txbMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mlogin = txbTaiKhoan.Text; Program.password = txbMatKhau.Text;
                if (Program.KetNoi() == 0) return;



                if (cbbRole.Text == "PGV")
                {
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;

                    string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.username = Program.myReader.GetString(0);
                    Program.myReader.Close();

                    if (Program.mGroup != "PGV")
                    {
                        MessageBox.Show("bạn Chọn sai Role Vui Lòng Kiểm Tra Lại");
                        return;
                    }



                }
                else if (cbbRole.Text == "Khoa")
                {
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;

                    string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                    Program.mGroup = Program.myReader.GetString(2);

                    Program.mHoten = Program.myReader.GetString(1);
                    Program.username = Program.myReader.GetString(0);
                    Program.myReader.Close();
                    if (Program.mGroup != "Khoa")
                    {
                        MessageBox.Show("bạn Chọn sai Role Vui Lòng Kiểm Tra Lai");
                        return;
                    }



                }
                else
                {
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;

                    string strLenh = "EXEC dbo.sp_LAYTTSVTULOGIN '" + Program.mlogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.username = Program.myReader.GetString(0);
                    Program.myReader.Close();
                    if (Program.mGroup != "SinhVien")
                    {
                        MessageBox.Show("bạn Chọn sai Role Vui Lòng Kiểm Tra Lai", "", MessageBoxButtons.OK);
                        return;
                    }


                }
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

            Program.conn.Close();

            MessageBox.Show("Đăng nhập thành công !!!");
            Form frm = this.CheckExists(typeof(main));
            if (frm != null) frm.Activate();
            else
            {

                Form f = new main();
                f.ShowDialog();
            }
            }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void button2_Click(object sender, EventArgs e)
            {
                Close();

            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

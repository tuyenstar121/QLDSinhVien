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
            comboBoxload();
        }

        private void frDangNhap_Load(object sender, EventArgs e)
        {
            cbbRole.SelectedIndex = 0;

        }

        private void comboBoxload()
        {
            SqlConnection conn = new SqlConnection();
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" +
                    Program.severname +
                    ";Initial Catalog=" +
                    Program.database +
                    ";User ID= sa" +
                    ";password= sa";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password." + e);
            }

            DataTable dt = new DataTable();
            string cmd = "Select name From sys.database_principals Where type = 'R' and principal_id < 16384 and principal_id != 0";
            dt = Program.ExecSqlDataTable(cmd);
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            //da.Fill(dt);

            conn.Close();

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbbRole.DataSource = bdsgv;
            cbbRole.DisplayMember = "name";
            cbbRole.ValueMember = "name";
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

           // string maUser = "tuyen";
            string cmd2 ="DECLARE @NAME NVARCHAR(10)"+ 
                "SELECT @NAME=name FROM sys.sysusers WHERE sid = SUSER_SID('"+txbTaiKhoan.Text.Trim()+"')" +
                "SELECT roles.[name] as role_name, members.[name] as user_name " +
                "FROM sys.database_role_members " +
                "JOIN sys.database_principals roles ON database_role_members.role_principal_id = roles.principal_id " +
                "JOIN sys.database_principals members ON database_role_members.member_principal_id = members.principal_id " +
                "WHERE members.[name] =@NAME";

            Program.myReader = Program.ExecSqlDataReader2(cmd2);

            if (Program.myReader == null) return;
            Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
            if (Program.myReader.HasRows)
            {
                String Text = Program.myReader.GetString(0);
               
            }
            else
            {
                MessageBox.Show("User này chưa thuộc role nào", "Thông báo");
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
            else if(cbbRole.Text=="SinhVien")
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
            else
            {
                MessageBox.Show("role này không có quyền đăng nhập vào chương trinh", "", MessageBoxButtons.OK);
                return;
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

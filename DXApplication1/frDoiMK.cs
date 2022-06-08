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
    public partial class frDoiMK : Form
    {
        public frDoiMK()
        {
            InitializeComponent();
        }

        private void txbTenLogin_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frDoiMK_Load(object sender, EventArgs e)
        {
            txbTenLogin.Text = Program.mlogin;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            string mkCu = txtMKCu.Text;
            string mkMoi = txtMKMoi.Text;
            String xacNhanMk = txtXacNhanMKMoi.Text;
            string cmd = "ALTER LOGIN [" + Program.mlogin + "] WITH PASSWORD=N'" + mkMoi + "' OLD_PASSWORD=N'" + mkCu + "'";

            if (mkCu.Equals(Program.password))
            {
                if (xacNhanMk.Equals(mkMoi))
                {
                    if (!mkMoi.Equals(Program.password))
                    {
                        if (Program.ExecSqlNonQuery(cmd) == 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại", "Lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới phải trùng nhau", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ sai !!! Vui lòng nhập lại", "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


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
    public partial class frTaoRole : Form
    {
        public frTaoRole()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string cmd1 = "";
            string cmd2 = "";
            string cmd3 = "";
            string cmd4 = "";
            string cmd5 = "";
            if (checkOwner.Checked)
            {
                cmd1 = " ALTER ROLE [db_owner] ADD MEMBER [" + txtTenRole.Text + "]";
            }
            if (checkReader.Checked)
            {
                cmd2 = " ALTER ROLE [db_datareader] ADD MEMBER [" + txtTenRole.Text + "]";
            }
            if (checkWriter.Checked)
            {
                cmd3 = " ALTER ROLE [db_datawriter] ADD MEMBER [" + txtTenRole.Text + "]";
            }
            if (checkBackup.Checked)
            {
                cmd4 = " ALTER ROLE [db_backupoperator] ADD MEMBER [" + txtTenRole.Text + "]";
            }
            if (checkAccessAdmin.Checked)
            {
                cmd5 = " ALTER ROLE [db_accessadmin] ADD MEMBER [" + txtTenRole.Text + "]";
            }
            string cmd = "CREATE ROLE " + txtTenRole.Text + cmd1 + cmd2 + cmd3 + cmd4 + cmd5;
            DialogResult result = MessageBox.Show("Bạn có muốn tạo role?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Tạo role thành công");
                }
                else
                {
                    MessageBox.Show("Tạo role thất bại");
                }
            }
        }
    }
}

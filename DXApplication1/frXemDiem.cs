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
    public partial class frXemDiem : Form
    {
        private BindingSource bds = new BindingSource();
        public frXemDiem()
        {
            InitializeComponent();
        }

        private void frXemDiem_Load(object sender, EventArgs e)
        {
            loadcbNienkhoa();
            cbbNienKhoa.SelectedIndex = 0;
          
            loadTTSV();
            loaddiem();

        }
        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbbNienKhoa.DataSource = bdsNienKhoa;
            cbbNienKhoa.DisplayMember = "NIENKHOA";
            cbbNienKhoa.ValueMember = "NIENKHOA";
        }
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbbHocKy.DataSource = bdsHocKi;
            cbbHocKy.DisplayMember = "HOCKY";
            cbbHocKy.ValueMember = "HOCKY";
        }
        private void loadTTSV()
        {
            txtMaSV.Text =  Program.username;
            txtTenSV.Text = Program.mHoten;



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loaddiem() { 

        DataTable BangDiem = new DataTable();
          string cmd = "EXEC dbo.SP_FULLMARK '" + txtMaSV.Text + "','"+cbbNienKhoa.Text+"','"+cbbHocKy.Text+"'";
            BangDiem = Program.ExecSqlDataTable(cmd);
            this.bds.DataSource = BangDiem;
            this.xemdiem.DataSource = this.bds;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            DataTable BangDiem = new DataTable();
            string cmd = "EXEC dbo.SP_FULLMARK '" + txtMaSV.Text + "','" + cbbNienKhoa.Text + "','" + cbbHocKy.Text + "'";
            BangDiem = Program.ExecSqlDataTable(cmd);
            this.bds.DataSource = BangDiem;
            this.xemdiem.DataSource = this.bds;
        }

        private void cbbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbbNienKhoa.Text);

        }
    }
}

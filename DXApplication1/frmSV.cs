using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmSV : Form
    {
        int chucnang=0;
        private BindingSource bds = new BindingSource();
        private string _oldMaSV;
        public frmSV()
        {
            InitializeComponent();
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSV();
        }
        void loadKhoacomobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT MaKhoa FROM KHOA ";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            MaKhoa.DataSource = bdsgv;
            MaKhoa.DisplayMember = "MaKhoa";
            MaKhoa.ValueMember = "MaKhoa";
        }
        void loadLopcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT MALOP FROM LOP WHERE MAKHOA= '" + MaKhoa.Text + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMalop.DataSource = bdsgv;
            cbMalop.DisplayMember = "MALOP";
            cbMalop.ValueMember = "MALOP";
        }
        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet1);

        }
        private void loadSV()
        {
            DataTable svTable = new DataTable();
            string cmd = "SELECT *FROM SINHVIEN WHERE MALOP= '" + cbMalop.Text + "'";
            svTable = Program.ExecSqlDataTable(cmd);
            this.bds.DataSource = svTable;
            this.dataGridView1.DataSource = this.bds;

        }
        //private void loadttsv (){

        //    DataRowView drv = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.]);
        //   cbMaSV.Text = drv["MASV"].ToString();
        //}
        private void frmSV_Load(object sender, EventArgs e)
        {
            //if (Program.mGroup.Equals("PGV") == false)
            //    MaKhoa.Enabled = false;
            if (Program.mGroup.Equals("khoa")){
                btnThem.Enabled = btnxoa.Enabled = btnsua.Enabled= btncapnhat.Enabled = btnluu.Enabled = btnthoat.Enabled = false; 
            }
            loadKhoacomobox();
         
            loadLopcombobox();
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet3.SINHVIEN' table. You can move, or remove it, as needed.
            // this.sINHVIENTableAdapter1.Fill(this.qDSV_TCDataSet3.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            loadSV();
            panelControl3.Enabled = false;

       
        }

        private void MaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLopcombobox();
        }
        
        private void labelControl4_Click(object sender, EventArgs e)
        {
            
        }
        private void loadttsv()
        {
            //string strLenh = "EXEC dbo.LayTTLopTheoMaLop '" + cbMaLop.Text + "'";
            //Program.myReader = Program.ExecSqlDataReader(strLenh);
            //if (Program.myReader == null) return;
            //Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break

            //txtLop.Text = Program.myReader.GetString(1);
            //txtKhoahoc.Text = Program.myReader.GetString(2);


            //Program.myReader.Close();



        }

    


        private void bntthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 1;
            mALOPTextEdit.Text = cbMalop.Text;
            mALOPTextEdit.Enabled = true;
            //string sql= "INSERT INTO SINHVIEN VALUES('"+comboBox1.Text+"','"+hOTextEdit.Text+"','" + tENTextEdit.Text+ "','"+ pHAICheckEdit.Checked + "','"
            //   + dIACHITextEdit.Text + "','"+Ngaysinh.Text + "','"+mALOPTextEdit.Text+"','"+""+ "')  ";
            //if (Program.ExecSqlNonQuery(sql) ==0)
            //    MessageBox.Show("Them Thành Công");
            //Đưa dữ liệu vào textbox
            comboBox1.Text = "";
            hOTextEdit.Text = "";
            tENTextEdit.Text = "";
            dIACHITextEdit.Text = "";
            // row.Cells[4].Value.ToString;  
            pHAICheckEdit.Checked = false;
            Ngaysinh.Text = "";
           

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { if (checkedit() == true)
            {
                if (chucnang == 1)
                {
                    string sql = "INSERT INTO SINHVIEN VALUES('" + comboBox1.Text.ToUpper() + "',N'" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hOTextEdit.Text.ToLower()) + "',N'" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tENTextEdit.Text.ToLower()) + "','" + pHAICheckEdit.Checked + "',N'"
                    + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dIACHITextEdit.Text.ToLower()) + "','" + Ngaysinh.Text + "','" + mALOPTextEdit.Text + "','" + "" + "')  ";
                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        btnThem.Enabled = btnsua.Enabled = btnxoa.Enabled = MaKhoa.Enabled = cbMalop.Enabled = mALOPTextEdit.Enabled = false ;
                        panelControl3.Enabled = true;
                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại! Vui lòng Xem lại Mã Sinh Viên");
                    }
                }
                if (chucnang == 2)
                {
                    string sql = "EXEC SP_UPDATESV'" + comboBox1.Text.ToUpper() + "',N'" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hOTextEdit.Text.ToLower()) + "',N'" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hOTextEdit.Text.ToLower()) + "','" + pHAICheckEdit.Text + "',N'"
                    + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dIACHITextEdit.Text.ToLower()) + "','" + Ngaysinh.Text + "','" + mALOPTextEdit.Text +"'";


                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        btnThem.Enabled = btnsua.Enabled = btnxoa.Enabled = MaKhoa.Enabled = cbMalop.Enabled = mALOPTextEdit.Enabled = false;
                        panelControl3.Enabled = true;
                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại! Vui lòng Xem lại Mã Sinh Viên");
                    }
                }
            }
        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    cb
        //    MaSV.Text =
        //}

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
             comboBox1.Text = row.Cells[0].Value.ToString();
               hOTextEdit.Text = row.Cells[1].Value.ToString();
                tENTextEdit.Text= row.Cells[2].Value.ToString();
                dIACHITextEdit.Text = row.Cells[3].Value.ToString();
                // row.Cells[4].Value.ToString;  
                pHAICheckEdit.Checked=(bool)row.Cells[4].Value;
                Ngaysinh.Text= row.Cells[5].Value.ToString();
                mALOPTextEdit.Text = row.Cells[6].Value.ToString();


            }
        }

      private  bool checkedit()
        {
            if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                comboBox1.Focus();
                return false;
            }
            if (hOTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                hOTextEdit.Focus();
                return false;
            }
            if (tENTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                tENTextEdit.Focus();
                return false;
            }
            if (dIACHITextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                dIACHITextEdit.Focus();
                return false;
            }
            if (mALOPTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                mALOPTextEdit.Focus();
                return false;
            }
            if (pHAICheckEdit.Checked == null)
            {
                MessageBox.Show("Phái không được thiếu!", "", MessageBoxButtons.OK);
                pHAICheckEdit.Focus();
                return false;
            }
            if (chucnang == 1)
            {
                string query1 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + comboBox1.Text + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                   MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                  MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
             
            }
            if (chucnang == 2)
            {
                if (!this.comboBox1.Text.Trim().ToString().Equals(_oldMaSV))
                {
                    string query2 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + comboBox1.Text + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query2);
                    if (resultMa == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                   
                }

            }
            
            return true;
        }

  

        private void panelControl3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnxoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sql = "DELETE FROM SINHVIEN WHERE MASV='" + comboBox1.Text + "'";
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show(" Xóa Thành Công");
            }
            else
            {
                MessageBox.Show("Sinh Viên Đã Tồn Tại ở Bảng Khác");
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 1;

            //  string sql = "INSERT INTO SINHVIEN VALUES('" + comboBox1.Text + "','" + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + pHAICheckEdit.Checked + "','"
            //+ dIACHITextEdit.Text + "','" + Ngaysinh.Text + "','" + mALOPTextEdit.Text + "','" + "" + "')  ";
            //  if (Program.ExecSqlNonQuery(sql) == 0)
            //      MessageBox.Show("Them Thành Công");
            btnThem.Enabled = btnsua.Enabled = btnxoa.Enabled =MaKhoa.Enabled=cbMalop.Enabled=mALOPTextEdit.Enabled= false;
            panelControl3.Enabled = true;
            comboBox1.Text = " ";
            mALOPTextEdit.Text = cbMalop.Text;
            hOTextEdit.Text = "";
            tENTextEdit.Text = "";
            Ngaysinh.Text = "";
            dIACHITextEdit.Text = "";



        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadSV();
        }



        private void btnsua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 2;

            //  string sql = "INSERT INTO SINHVIEN VALUES('" + comboBox1.Text + "','" + hOTextEdit.Text + "','" + tENTextEdit.Text + "','" + pHAICheckEdit.Checked + "','"
            //+ dIACHITextEdit.Text + "','" + Ngaysinh.Text + "','" + mALOPTextEdit.Text + "','" + "" + "')  ";
            //  if (Program.ExecSqlNonQuery(sql) == 0)
            //      MessageBox.Show("Them Thành Công");
            btnThem.Enabled = btnsua.Enabled = btnxoa.Enabled = MaKhoa.Enabled = comboBox1.Enabled = false;
            panelControl3.Enabled = true;

            DataTable dt = new DataTable();
            string cmd = "SELECT MALOP FROM LOP WHERE MAKHOA='" + MaKhoa.Text.Trim() + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            mALOPTextEdit.DataSource = bdsgv;
            mALOPTextEdit.DisplayMember = "MALOP";
            mALOPTextEdit.ValueMember = "MALOP"; 
        }

        private void btnthoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnsua.Enabled = btnxoa.Enabled = MaKhoa.Enabled = cbMalop.Enabled = mALOPTextEdit.Enabled = true;
            panelControl3.Enabled = false;
            comboBox1.Text = " ";
            mALOPTextEdit.Text = cbMalop.Text;
            hOTextEdit.Text = "";
            tENTextEdit.Text = "";
            Ngaysinh.Text = "";
            dIACHITextEdit.Text = "";
            chucnang = 0;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }
    }
}

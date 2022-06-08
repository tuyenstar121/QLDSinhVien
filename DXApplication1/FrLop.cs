using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FrLop : Form
    {
        private BindingSource bds = new BindingSource();
        public FrLop()
        {
            InitializeComponent();
        }
        int chucnang = 0;
        private string _oldMaLop = "";
        private string _oldTenLop = "";




        void loadttLop()
        {


            try
            {
                this.sP_LAYTTLOPTheoKhoaTableAdapter.Fill(this.qLDSV_TCDataSet3.SP_LAYTTLOPTheoKhoa, MaKhoa.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


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

        private void FrLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet3.SP_LAYTTLOP' table. You can move, or remove it, as needed.


            loadKhoacomobox();
            MaKhoa.SelectedIndex = 0;
            try
            {
                this.sP_LAYTTLOPTheoKhoaTableAdapter.Fill(this.qLDSV_TCDataSet3.SP_LAYTTLOPTheoKhoa, MaKhoa.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            panelControl4.Enabled = false;


        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkma() == true)
            {
                if (chucnang == 1)
                {
                    string sql = "INSERT INTO LOP VALUES('" + txtMalop.Text + "',N'" + txtLop.Text + "',N'" + txtKhoahoc.Text + "','" + cbbMaKhoa.Text + "') ";
                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = false;

                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại! Vui lòng Xem lại Mã Lớp");
                    }
                }
                if (chucnang == 2)
                {
                    string sql = "EXEC UDATELOP'" + txtMalop.Text + "',N'" + txtLop.Text + "',N'" + txtKhoahoc.Text + "','" + cbbMaKhoa.Text + "' ";
                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = false;

                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại! Vui lòng Xem lại Mã Sinh Viên");
                    }

                }
            }

        }
        private bool checkma()
        {
            if (txtMalop.Text == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMalop.Focus();
                return false;
            }
            if (txtMalop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtLop.Focus();
                return false;
            }
            if (txtKhoahoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "", MessageBoxButtons.OK);
                txtKhoahoc.Focus();
                return false;
            }
            if (chucnang == 1)
            {

                string query1 = "DECLARE  @return_value int \n"
                                + "EXEC  @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMalop.Text + "',@Type = N'MALOP' \n"
                                + "SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở Khoa hiên tại !", "", MessageBoxButtons.OK);

                    return false;
                }
                string query2 = "DECLARE @return_value int \n"
                              + "EXEC @return_value = SP_CHECKNAME \n"
                              + "@Name = N'" + txtLop.Text + "', @Type = N'TENLOP' \n"
                              + "SELECT 'Return Value' = @return_value ";
                int resultTen = Program.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                   MessageBox.Show("Tên lớp đã có rồi !", "", MessageBoxButtons.OK);

                    return false;
                }

            }
            if (chucnang == 2)
            {
       
                if (!this.txtLop.Text.Trim().ToString().Equals(_oldTenLop))
                {
                    // TODO : Check tên lớp có tồn tại chưa
                    string query2 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txtLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                    int resultTen = Program.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                       MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        MessageBox.Show("Tên lớp đã có rồi !", "", MessageBoxButtons.OK);
                        return false;
                    }
                  
                }
            }

            return true;
        }

        private void MaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAYTTLOPTheoKhoaTableAdapter.Fill(this.qLDSV_TCDataSet3.SP_LAYTTLOPTheoKhoa, MaKhoa.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

           
          
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadttLop();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm Lớp học ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                chucnang = 1;
                panelControl4.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                txtMalop.Text = string.Empty;
                txtLop.Text = string.Empty;
                txtKhoahoc.Text = string.Empty;
                cbbMaKhoa.Text = MaKhoa.Text;
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "DELETE FROM LOP WHERE MALOP='" + txtMalop.Text + "'";
                if (Program.ExecSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show(" Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Lớp Đã Tồn Tại ở Bảng Khác");
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sữa lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (txtMalop.Text != "")
                {
                    chucnang = 2;
                    panelControl4.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtMalop.Enabled = false;

                    cbbMaKhoa.Text = MaKhoa.Text;
                }
                else
                {
                    MessageBox.Show("vui lòng chọn lớp muốn sữa");
                    return;
                }
            }
        }

     

      
      

        private void sP_TTLOPTCTHEOKHOAGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (sP_LAYTTLOPTheoKhoaBindingSource.Count > 0)
            {
                txtMalop.Text = ((DataRowView)sP_LAYTTLOPTheoKhoaBindingSource[sP_LAYTTLOPTheoKhoaBindingSource.Position])["MALOP"].ToString();
                txtLop.Text = ((DataRowView)sP_LAYTTLOPTheoKhoaBindingSource[sP_LAYTTLOPTheoKhoaBindingSource.Position])["TENLOP"].ToString();

                txtKhoahoc.Text = ((DataRowView)sP_LAYTTLOPTheoKhoaBindingSource[sP_LAYTTLOPTheoKhoaBindingSource.Position])["KHOAHOC"].ToString();
                cbbMaKhoa.Text = ((DataRowView)sP_LAYTTLOPTheoKhoaBindingSource[sP_LAYTTLOPTheoKhoaBindingSource.Position])["MAKHOA"].ToString();




            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = txtMalop.Enabled = true;
            panelControl4.Enabled = false;
            chucnang = 0;
            txtMalop.Text = string.Empty;
            txtLop.Text = string.Empty;
            txtKhoahoc.Text = string.Empty;
            cbbMaKhoa.Text = MaKhoa.Text;
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadttLop();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }
    }
 }


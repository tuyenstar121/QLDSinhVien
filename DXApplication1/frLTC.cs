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
    public partial class frLTC : Form
    {
        int chucnang = 0;
        private BindingSource bdsSinhVien = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsDSLTC_HUY = new BindingSource();
        public frLTC()
        {
            InitializeComponent();
        }
        private void loadcbxkhoa()
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
        void loadloptcc()
        {

            string cmd = "SELECT*FROM LOPTINCHI WHERE MAKHOA='" + MaKhoa.Text + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.lOPTINCHIGridControl.DataSource = this.bdsLopTinchi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet3.LOPTINCHI' table. You can move, or remove it, as needed.
            loadcbxkhoa();
            loadloptcc();
            panelControl3.Enabled = false;
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet3);

        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT*FROM GIANGVIEN";
            dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaGV.DataSource = bdsgv;
            cbMaGV.DisplayMember = "MAGV";
            cbMaGV.ValueMember = "MAGV";
        }
        void loadMHcbb()
        {
            DataTable dt = new DataTable();
            string cmd = "SELECT*FROM MONHOC ";
            dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbMaMH.DataSource = bdsgv;
            cbMaMH.DisplayMember = "MAMH";
            cbMaMH.ValueMember = "MAMH";
        }


        private void lOPTINCHIGridControl_MouseClick(object sender, MouseEventArgs e)
        {

            if (bdsLopTinchi.Count > 0)
            {
                mALTCSpinEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
                cbMaGV.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MAGV"].ToString();
                cbKhoa.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MAKHOA"].ToString();
                nIENKHOATextEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["NIENKHOA"].ToString();
                nHOMSpinEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["NHOM"].ToString();
                cbMaMH.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MAMH"].ToString();
                hOCKYSpinEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["HOCKY"].ToString();
                sOSVTOITHIEUSpinEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["SOSVTOITHIEU"].ToString();
                //HU  = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }
        }
        private bool checknhaplieu()
        {


            if (hOCKYSpinEdit.Value == 0)
            {
                MessageBox.Show("Học kì không được thiếu!", "", MessageBoxButtons.OK);
                hOCKYSpinEdit.Focus();
                return false;
            }
            if (sOSVTOITHIEUSpinEdit.Value == 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK);
                sOSVTOITHIEUSpinEdit.Focus();
                return false;
            }
            if (nHOMSpinEdit.Value == 0)
            {
                MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK);
                sOSVTOITHIEUSpinEdit.Focus();
                return false;
            }
            if (cbKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                cbKhoa.Focus();
                return false;
            }
            if (cbMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                cbMaMH.Focus();
                return false;
            }
            if (cbMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được thiếu!", "", MessageBoxButtons.OK);
                cbMaGV.Focus();
                return false;
            }
            if (nIENKHOATextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK);
                nIENKHOATextEdit.Focus();
                return false;
            }
            return true;
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            chucnang = 1;

            loadGVcombobox();
            loadMHcbb();
            btnThem.Enabled = btnsua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = mALTCSpinEdit.Enabled = false;
            panelControl3.Enabled = true;
            mALTCSpinEdit.Text = "";
            nIENKHOATextEdit.Text = "";
            nHOMSpinEdit.Text = "";
            hOCKYSpinEdit.Text = "";
            sOSVTOITHIEUSpinEdit.Text = "";
            cbKhoa.Text = MaKhoa.Text;
            cbKhoa.Enabled = false;



        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checknhaplieu() == true)
            {
                if (chucnang == 1)
                {
                    string sql = "INSERT INTO LOPTINCHI(NIENKHOA,HOCKY,MAMH,NHOM,MAGV,MAKHOA,SOSVTOITHIEU,HUYLOP) VALUES('" + nIENKHOATextEdit.Text.Trim() + "'," + hOCKYSpinEdit.Text.Trim() + ",'" + cbMaMH.Text.Trim() + "',"
                      + nHOMSpinEdit.Text + ",'" + cbMaGV.Text.Trim() + "','" + MaKhoa.Text.Trim() + "'," + sOSVTOITHIEUSpinEdit.Text + ",'" + hUYLOPCheckEdit.Checked + "') ";

                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        btnThem.Enabled = btnsua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = mALTCSpinEdit.Enabled = true;
                        panelControl3.Enabled = false;
                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại! Vui lòng Xem lại Mã Sinh Viên");
                    }
                }
                if (chucnang == 2)
                {
                    string sql = "EXEC UPDATELOPTC " + mALTCSpinEdit.Text + ",'" + nIENKHOATextEdit.Text + "'," + hOCKYSpinEdit.Text + ",'" + cbKhoa.Text.Trim() + "','" + cbMaMH.Text.Trim() + "','" + cbMaGV.Text.Trim() + "'," + sOSVTOITHIEUSpinEdit.Text + "," + nHOMSpinEdit.Text + "";
                    MessageBox.Show(sql);
                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("UPDATE Thành Công");
                        btnThem.Enabled = btnsua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = mALTCSpinEdit.Enabled = true;
                        panelControl3.Enabled = false;
                        chucnang = 0;
                    }
                    else
                    {
                        MessageBox.Show("UPDATE Thất Thất bại!");
                    }
                }
            }
        }

        private void MaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadloptcc();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnsua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = mALTCSpinEdit.Enabled = true;
            panelControl3.Enabled = false;
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALTCSpinEdit.Value != 0)
            {

                chucnang = 2;

                loadGVcombobox();
                loadMHcbb();
                btnThem.Enabled = btnsua.Enabled = btnXoa.Enabled = MaKhoa.Enabled = mALTCSpinEdit.Enabled = false;
                panelControl3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Lớp Bạn Muốn Thay Đổi Thông Tin");
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadloptcc();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (mALTCSpinEdit.Value != 0)
            {
                string sql = "DELETE LOPTINCHI WHERE MALTC='" + mALTCSpinEdit.Text + "'";
              
                if (Program.ExecSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show("Xóa Thành Công");

                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Lớp Bạn Muốn Thay Đổi Thông Tin");
            }

        }
    }
}

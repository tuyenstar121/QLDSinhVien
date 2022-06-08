﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrDiem : Form
    {
        private BindingSource bdsDiem = new BindingSource();
        public FrDiem()
        {
            InitializeComponent();
        }
        void loadBDMH()
        {
            string cmd = "EXEC [dbo].[SP_BDMH] '" + cbNienKhoa.Text + "', " + cbHocKi.Text + ", " + cbNhom.Text + ", N'" + cbMonHoc.SelectedValue.ToString() + "'";
            DataTable diemTable = Program.ExecSqlDataTable(cmd);
            this.bdsDiem.DataSource = diemTable;
            this.DiemGridControl.DataSource = this.bdsDiem;
        }
        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrDiem_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet3.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet3.MONHOC);
            cbMonHoc.DataSource = mONHOCBindingSource;
            cbMonHoc.DisplayMember = "TENMH";
            cbMonHoc.ValueMember = "TENMH";

            loadcbNienkhoa();
          

        }

        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbNienKhoa.DataSource = bdsNienKhoa;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
        }
        void loadNhom(string nienkhoa, string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '" + nienkhoa + "', " + hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbNhom.DataSource = bdsNhom;
            cbNhom.DisplayMember = "NHOM";
            cbNhom.ValueMember = "NHOM";
        }
        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadNhom(cbNienKhoa.Text, cbHocKi.Text);
            cbNhom.SelectedIndex = 0;
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadcbHocKi(cbNienKhoa.Text);
          
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            loadBDMH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                BindingSource bdsTemp = (BindingSource)this.DiemGridControl.DataSource;
                if (bdsTemp == null)
                {
                    MessageBox.Show("Chưa có thông tin để ghi điểm!", "", MessageBoxButtons.OK);
                    return;
                }

                bdsTemp.EndEdit();
                SqlConnection conn = new SqlConnection(Program.connstr);
                // bắt đầu transaction
                SqlTransaction tran;

                conn.Open();
                tran = conn.BeginTransaction();
                try
                {


                    for (int i = 0; i < bdsTemp.Count; i++)
                    {

                        SqlCommand cmd = new SqlCommand("SP_XULY_DIEM", conn);
                        cmd.Connection = conn;
                        cmd.Transaction = tran;



                        cmd.CommandType = CommandType.StoredProcedure;
                        string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                        cmd.Parameters.Add(new SqlParameter("@MSSV", masv));
                        cmd.Parameters.Add(new SqlParameter("@MALTC", ((DataRowView)bdsTemp[i])["MALC"].ToString()));
                        float diemcc = 0;
                        float diemgk = 0;
                        float diemck = 0;
                        if (((DataRowView)bdsTemp[i])["DIEM_CC"].ToString() != "")
                        {
                            diemcc = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CC"].ToString());
                        }
                        if (((DataRowView)bdsTemp[i])["DIEM_GK"].ToString() != "")
                        {
                            diemgk = float.Parse(((DataRowView)bdsTemp[i])["DIEM_GK"].ToString());
                        }
                        if (((DataRowView)bdsTemp[i])["DIEM_CK"].ToString() != "")
                        {
                            diemck = float.Parse(((DataRowView)bdsTemp[i])["DIEM_CK"].ToString());
                        }
                        if (diemcc < 0 || diemcc > 10 || diemck < 0 || diemck > 10 || diemgk < 0 || diemgk > 10)
                        {
                            tran.Rollback();
                            XtraMessageBox.Show("Điểm số chỉ được nhập từ 0 đến 10! Xin vui lòng nhập lại");
                            conn.Close();
                            loadBDMH();
                            return;
                        }
                        cmd.Parameters.Add(new SqlParameter("@DIEMCC", diemcc));
                        cmd.Parameters.Add(new SqlParameter("@DIEMGK", diemgk));
                        cmd.Parameters.Add(new SqlParameter("@DIEMCK", diemck));
                        cmd.ExecuteNonQuery();


                    }


                    tran.Commit();
                }
                catch (SqlException sqlex)
                {
                    try
                    {

                        tran.Rollback();
                        MessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);
                        loadBDMH();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    conn.Close();
                    return;
                }
                finally
                {
                    conn.Close();
                }
                XtraMessageBox.Show("Thao tác thành công!", "", MessageBoxButtons.OK);
                string cmd1 = "EXEC [dbo].[SP_BDMH] '" + cbNienKhoa.Text + "', " + cbHocKi.Text + ", " + cbNhom.Text + ", N'" + cbMonHoc.SelectedValue.ToString() + "'";
                DataTable diemTable = Program.ExecSqlDataTable(cmd1);
                this.bdsDiem.DataSource = diemTable;
                this.DiemGridControl.DataSource = this.bdsDiem;
                return;
    
        }
    }
}

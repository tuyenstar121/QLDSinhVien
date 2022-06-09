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
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
        }
        private BindingSource bdsDK = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        //private BindingSource bdsDSLTC_HUY = new BindingSource();
        private void labelControl1_Click(object sender, EventArgs e)
        {

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
        //void LOADDSDK()
        //{
        //    string cmd1 = "EXEC [dbo].[sp_LayTTDK]'" + mASVTextEdit.Text + "'";
        //    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
        //    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
        //    this.dANGKYGridControl.DataSource = this.bdsDSLTC_HUY;
        //}
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbbHocki.DataSource = bdsHocKi;
            cbbHocki.DisplayMember = "HOCKY";
            cbbHocki.ValueMember = "HOCKY";
        }
        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.lOPTINCHIBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet3);

        }

        private void Dangki_Load(object sender, EventArgs e)
        {
            txtmsv.Text = Program.username;
            LoadtableDK();
            txtHT.Text = Program.mHoten;
            mASVTextEdit.Text = Program.username;
            loadcbNienkhoa();
            cbbNienKhoa.SelectedIndex = 0;

            //  LOADDSDK();

        }





        private void LOPTINCHIgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                mALTCSpinEdit.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }

        }
        private void BtnTK_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_TTLTCTableAdapter.Fill(this.qLDSV_TCDataSet3.SP_TTLTC, cbbNienKhoa.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(cbbHocki.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void LoadtableDK()
        {
            try
            {
                this.sp_LayTTDKTableAdapter.Fill(this.qLDSV_TCDataSet3.sp_LayTTDK, txtmsv.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btkDK_Click(object sender, EventArgs e)
        {
            if (mASVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                mASVTextEdit.Focus();
                return;
            }
            if (mALTCSpinEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                mALTCSpinEdit.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + mASVTextEdit.Text + "' , '" + mALTCSpinEdit.Text + "', " + 1;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    try
                    {
                        this.sp_LayTTDKTableAdapter.Fill(this.qLDSV_TCDataSet3.sp_LayTTDK, txtmsv.Text);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void cbbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadtableDK();
            loadcbHocKi(cbbNienKhoa.Text);
            //cbbHocki.SelectedIndex = 0;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void sP_TTLTCGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (sP_TTLTCBindingSource.Count > 0)
            {
                mALTCSpinEdit.Text = ((DataRowView)sP_TTLTCBindingSource[sP_TTLTCBindingSource.Position])["MALTC"].ToString();

            }

        }

        private void sp_LayTTDKGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            if (mALTCSpinEdit.Value == 0)
            {
                MessageBox.Show("Mã Lớp Tín Chỉ không được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txtmsv.Text + "' , '" + mALTCSpinEdit.Text + "', " + 2;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }


            }
        }

        private void sp_LayTTDKGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (((DataRowView)sp_LayTTDKBindingSource[sp_LayTTDKBindingSource.Position])["MALTC"] != null)
            {
                mALTCSpinEdit.Text = ((DataRowView)sp_LayTTDKBindingSource[sp_LayTTDKBindingSource.Position])["MALTC"].ToString();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sp_LayTTDKTableAdapter.Fill(this.qLDSV_TCDataSet3.sp_LayTTDK, txtmsv.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            txtmsv.Text = Program.username;
            LoadtableDK();
            txtHT.Text = Program.mHoten;
            mASVTextEdit.Text = Program.username;
            loadcbNienkhoa();
            cbbNienKhoa.SelectedIndex = 0;
        }
    }
}
using System;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1
{
    
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            phanquyen();
            this.Ma.Text = "MA " + Program.username;
            this.HoTen.Text = "HOTEN " + Program.mHoten;
            this.nhom.Text = "NHOM " + Program.mGroup;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frDangNhap f = new frDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Form frmDangNhap = new frDangNhap();

            this.Close();
        }
        private void phanquyen()
        {
            if (Program.mGroup.Equals("SinhVien"))
            {
                btnDangNhap.Enabled = false;
                btnDangxuat.Enabled = true;
                btnDK.Enabled = false;
                BtnXemdiem.Enabled = true;
                btnDK.Enabled = true;


            }
            if (Program.mGroup.Equals("Khoa"))
            {
                btnDangNhap.Enabled = false;
                btnDangxuat.Enabled = true;
                btnNhapDiem.Enabled = btnSV.Enabled = btnLop.Enabled = true;
            }
            if (Program.mGroup.Equals("PGV"))
            {
                btnDangNhap.Enabled = false;
                btnDangxuat.Enabled = true;
                btnBackup.Enabled = btnLop.Enabled = btnLopTC.Enabled = btnThemTK.Enabled = btnXoaTK.Enabled = btnLopTC.Enabled = btnMH.Enabled = btnSV.Enabled = true;

            }
        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSV));
            if (frm != null) frm.Activate();
            else
            {
                frmSV f = new frmSV();
                f.MdiParent = this;
                f.Show();


            }
        }

        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FrMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FrMonHoc f = new FrMonHoc();
                f.MdiParent = this;

                f.Show();
            }

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrLop));
            if (frm != null) frm.Activate();
            else
            {
                FrLop f = new FrLop();
                f.MdiParent = this;

                f.Show();
            }

        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrDiem));
            if (frm != null) frm.Activate();
            else
            {
                FrDiem f = new FrDiem();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frBackup));
            if (frm != null) frm.Activate();
            else
            {
                frBackup f = new frBackup();
                f.MdiParent = this;

                f.Show();
            }


        }

        private void BtnXemdiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                frXemDiem f = new frXemDiem();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void btnThemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frtaoTK));
            if (frm != null) frm.Activate();
            else
            {
                frtaoTK f = new frtaoTK();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void btnLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frLTC));
            if (frm != null) frm.Activate();
            else
            {
                frLTC f = new frLTC();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void btnDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Dangki));
            if (frm != null) frm.Activate();
            else
            {
             Dangki f = new Dangki();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frDoiMK));
            if (frm != null) frm.Activate();
            else
            {
                frDoiMK f = new frDoiMK();
                f.MdiParent = this;

                f.Show();
            }
        }

        private void btnXoaTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FrXoaTK));
            if (frm != null) frm.Activate();
            else
            {
               FrXoaTK f = new FrXoaTK();
                f.MdiParent = this;

                f.Show();
            }
        }
    }
}
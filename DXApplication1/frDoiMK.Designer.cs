
namespace DXApplication1
{
    partial class frDoiMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sinhvienTableAdapter1 = new DXApplication1.QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter();
            this.txtXacNhanMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txbTenLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.x = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.x.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(367, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(644, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 41);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(370, 391);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(141, 41);
            this.btnXacNhan.TabIndex = 42;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(330, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Xác Nhân Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(375, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(383, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mật Khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // sinhvienTableAdapter1
            // 
            this.sinhvienTableAdapter1.ClearBeforeFill = true;
            // 
            // txtXacNhanMKMoi
            // 
            this.txtXacNhanMKMoi.Location = new System.Drawing.Point(579, 277);
            this.txtXacNhanMKMoi.Name = "txtXacNhanMKMoi";
            this.txtXacNhanMKMoi.Size = new System.Drawing.Size(162, 22);
            this.txtXacNhanMKMoi.TabIndex = 49;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(579, 215);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(162, 22);
            this.txtMKMoi.TabIndex = 48;
            // 
            // txbTenLogin
            // 
            this.txbTenLogin.Enabled = false;
            this.txbTenLogin.Location = new System.Drawing.Point(579, 85);
            this.txbTenLogin.Name = "txbTenLogin";
            this.txbTenLogin.Size = new System.Drawing.Size(162, 22);
            this.txbTenLogin.TabIndex = 47;
            this.txbTenLogin.EditValueChanged += new System.EventHandler(this.txbTenLogin_EditValueChanged);
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(579, 147);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(162, 22);
            this.txtMKCu.TabIndex = 50;
            // 
            // x
            // 
            this.x.Controls.Add(this.btnXacNhan);
            this.x.Controls.Add(this.btnThoat);
            this.x.Controls.Add(this.txtMKCu);
            this.x.Controls.Add(this.label1);
            this.x.Controls.Add(this.txtXacNhanMKMoi);
            this.x.Controls.Add(this.label6);
            this.x.Controls.Add(this.txtMKMoi);
            this.x.Controls.Add(this.label3);
            this.x.Controls.Add(this.label4);
            this.x.Controls.Add(this.label2);
            this.x.Controls.Add(this.txbTenLogin);
            this.x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x.Location = new System.Drawing.Point(0, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(1065, 599);
            this.x.TabIndex = 51;
            // 
            // frDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 599);
            this.Controls.Add(this.x);
            this.Name = "frDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu ";
            this.Load += new System.EventHandler(this.frDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.x.ResumeLayout(false);
            this.x.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter sinhvienTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMKMoi;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.TextEdit txbTenLogin;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.PanelControl x;
    }
}
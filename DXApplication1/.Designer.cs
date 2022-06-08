
namespace DXApplication1
{
    partial class frtaoTK
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdSV = new System.Windows.Forms.RadioButton();
            this.rdKHOA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PGV = new System.Windows.Forms.RadioButton();
            this.sinhvienTableAdapter1 = new DXApplication1.QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter();
            this.cbbMAGV = new System.Windows.Forms.ComboBox();
            this.txbTenLogin = new DevExpress.XtraEditors.TextEdit();
            this.txbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txbXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.virtualServerModeSource2 = new DevExpress.Data.VirtualServerModeSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txbTenLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(450, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(738, 478);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 41);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(464, 478);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(141, 41);
            this.btnXacNhan.TabIndex = 26;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // rdSV
            // 
            this.rdSV.AutoSize = true;
            this.rdSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdSV.Location = new System.Drawing.Point(708, 408);
            this.rdSV.Name = "rdSV";
            this.rdSV.Size = new System.Drawing.Size(89, 21);
            this.rdSV.TabIndex = 25;
            this.rdSV.TabStop = true;
            this.rdSV.Text = "Sinh Vien";
            this.rdSV.UseVisualStyleBackColor = true;
            this.rdSV.CheckedChanged += new System.EventHandler(this.rdSV_CheckedChanged);
            // 
            // rdKHOA
            // 
            this.rdKHOA.AutoSize = true;
            this.rdKHOA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdKHOA.Location = new System.Drawing.Point(608, 406);
            this.rdKHOA.Name = "rdKHOA";
            this.rdKHOA.Size = new System.Drawing.Size(62, 21);
            this.rdKHOA.TabIndex = 24;
            this.rdKHOA.TabStop = true;
            this.rdKHOA.Text = "Khoa";
            this.rdKHOA.UseVisualStyleBackColor = true;
            this.rdKHOA.CheckedChanged += new System.EventHandler(this.rdKHOA_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(514, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vai Trò";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(413, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Xác Nhân Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(496, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(460, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // PGV
            // 
            this.PGV.AutoSize = true;
            this.PGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PGV.Location = new System.Drawing.Point(815, 406);
            this.PGV.Name = "PGV";
            this.PGV.Size = new System.Drawing.Size(94, 21);
            this.PGV.TabIndex = 30;
            this.PGV.TabStop = true;
            this.PGV.Text = "Phòng GV";
            this.PGV.UseVisualStyleBackColor = true;
            this.PGV.CheckedChanged += new System.EventHandler(this.PGV_CheckedChanged);
            // 
            // sinhvienTableAdapter1
            // 
            this.sinhvienTableAdapter1.ClearBeforeFill = true;
            // 
            // cbbMAGV
            // 
            this.cbbMAGV.Enabled = false;
            this.cbbMAGV.FormattingEnabled = true;
            this.cbbMAGV.Location = new System.Drawing.Point(621, 197);
            this.cbbMAGV.Name = "cbbMAGV";
            this.cbbMAGV.Size = new System.Drawing.Size(162, 24);
            this.cbbMAGV.TabIndex = 31;
            // 
            // txbTenLogin
            // 
            this.txbTenLogin.Enabled = false;
            this.txbTenLogin.Location = new System.Drawing.Point(621, 132);
            this.txbTenLogin.Name = "txbTenLogin";
            this.txbTenLogin.Size = new System.Drawing.Size(162, 22);
            this.txbTenLogin.TabIndex = 32;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(621, 264);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(162, 22);
            this.txbMatKhau.TabIndex = 33;
            // 
            // txbXacNhanMK
            // 
            this.txbXacNhanMK.Location = new System.Drawing.Point(621, 335);
            this.txbXacNhanMK.Name = "txbXacNhanMK";
            this.txbXacNhanMK.Size = new System.Drawing.Size(162, 22);
            this.txbXacNhanMK.TabIndex = 34;
            // 
            // frtaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 624);
            this.Controls.Add(this.txbXacNhanMK);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenLogin);
            this.Controls.Add(this.cbbMAGV);
            this.Controls.Add(this.PGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.rdSV);
            this.Controls.Add(this.rdKHOA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frtaoTK";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.txbTenLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.RadioButton rdSV;
        private System.Windows.Forms.RadioButton rdKHOA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PGV;
        private QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter sinhvienTableAdapter1;
        private System.Windows.Forms.ComboBox cbbMAGV;
        private DevExpress.XtraEditors.TextEdit txbTenLogin;
        private DevExpress.XtraEditors.TextEdit txbMatKhau;
        private DevExpress.XtraEditors.TextEdit txbXacNhanMK;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource2;
    }
}
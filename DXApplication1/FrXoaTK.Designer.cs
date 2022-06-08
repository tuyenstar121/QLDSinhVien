
namespace DXApplication1
{
    partial class FrXoaTK
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
            this.rdSV = new System.Windows.Forms.RadioButton();
            this.PGV = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.rdKHOA = new System.Windows.Forms.RadioButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdSV
            // 
            this.rdSV.AutoSize = true;
            this.rdSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdSV.Location = new System.Drawing.Point(347, 95);
            this.rdSV.Name = "rdSV";
            this.rdSV.Size = new System.Drawing.Size(89, 21);
            this.rdSV.TabIndex = 1;
            this.rdSV.TabStop = true;
            this.rdSV.Text = "Sinh Viên";
            this.rdSV.UseVisualStyleBackColor = true;
            this.rdSV.CheckedChanged += new System.EventHandler(this.rdSV_Click);
            // 
            // PGV
            // 
            this.PGV.AutoSize = true;
            this.PGV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PGV.Location = new System.Drawing.Point(475, 95);
            this.PGV.Name = "PGV";
            this.PGV.Size = new System.Drawing.Size(144, 21);
            this.PGV.TabIndex = 2;
            this.PGV.TabStop = true;
            this.PGV.Text = "Phòng Giảng Viên";
            this.PGV.UseVisualStyleBackColor = true;
            this.PGV.CheckedChanged += new System.EventHandler(this.PGV_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(100, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Vai Trò";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(100, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mã Nhân Viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(320, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 25);
            this.labelControl3.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(91, 244);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tên Đăng Nhập";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(261, 169);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(281, 24);
            this.cbMaNV.TabIndex = 7;
            this.cbMaNV.SelectionChangeCommitted += new System.EventHandler(this.cbMaNV_SelectionChangeCommitted);
            this.cbMaNV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(261, 235);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(281, 22);
            this.txtLogin.TabIndex = 8;
            // 
            // rdKHOA
            // 
            this.rdKHOA.AutoSize = true;
            this.rdKHOA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdKHOA.Location = new System.Drawing.Point(248, 95);
            this.rdKHOA.Name = "rdKHOA";
            this.rdKHOA.Size = new System.Drawing.Size(62, 21);
            this.rdKHOA.TabIndex = 0;
            this.rdKHOA.TabStop = true;
            this.rdKHOA.Text = "Khoa";
            this.rdKHOA.UseVisualStyleBackColor = true;
            this.rdKHOA.CheckedChanged += new System.EventHandler(this.rdKHOA_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(301, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(173, 29);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Xóa Tài Khoản";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(331, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 497);
            this.panelControl1.TabIndex = 11;
            // 
            // FrXoaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PGV);
            this.Controls.Add(this.rdSV);
            this.Controls.Add(this.rdKHOA);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrXoaTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrXoaTK";
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdSV;
        private System.Windows.Forms.RadioButton PGV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbMaNV;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private System.Windows.Forms.RadioButton rdKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
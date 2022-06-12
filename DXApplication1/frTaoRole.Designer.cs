
namespace DXApplication1
{
    partial class frTaoRole
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTenRole = new DevExpress.XtraEditors.TextEdit();
            this.checkReader = new DevExpress.XtraEditors.CheckEdit();
            this.checkWriter = new DevExpress.XtraEditors.CheckEdit();
            this.checkBackup = new DevExpress.XtraEditors.CheckEdit();
            this.checkAccessAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.checkOwner = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkReader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAccessAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(150, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tên Role";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(135, 200);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Các Quyền";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(331, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 29);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Tạo Role";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXacNhan.Location = new System.Drawing.Point(252, 395);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 51);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Tạo Role";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(410, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTenRole
            // 
            this.txtTenRole.Location = new System.Drawing.Point(252, 92);
            this.txtTenRole.Name = "txtTenRole";
            this.txtTenRole.Size = new System.Drawing.Size(240, 22);
            this.txtTenRole.TabIndex = 5;
            // 
            // checkReader
            // 
            this.checkReader.Location = new System.Drawing.Point(252, 287);
            this.checkReader.Name = "checkReader";
            this.checkReader.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkReader.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkReader.Properties.Appearance.Options.UseFont = true;
            this.checkReader.Properties.Appearance.Options.UseForeColor = true;
            this.checkReader.Properties.Caption = "Đọc được toàn bộ dữ liệu";
            this.checkReader.Size = new System.Drawing.Size(345, 24);
            this.checkReader.TabIndex = 4;
            // 
            // checkWriter
            // 
            this.checkWriter.Location = new System.Drawing.Point(252, 241);
            this.checkWriter.Name = "checkWriter";
            this.checkWriter.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkWriter.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkWriter.Properties.Appearance.Options.UseFont = true;
            this.checkWriter.Properties.Appearance.Options.UseForeColor = true;
            this.checkWriter.Properties.Caption = "Thêm, xóa hoặc chỉnh sửa dữ liệu trong bảng";
            this.checkWriter.Size = new System.Drawing.Size(401, 24);
            this.checkWriter.TabIndex = 3;
            // 
            // checkBackup
            // 
            this.checkBackup.Location = new System.Drawing.Point(252, 331);
            this.checkBackup.Name = "checkBackup";
            this.checkBackup.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBackup.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBackup.Properties.Appearance.Options.UseFont = true;
            this.checkBackup.Properties.Appearance.Options.UseForeColor = true;
            this.checkBackup.Properties.Caption = "Sao lưu cơ sở dữ liệu";
            this.checkBackup.Size = new System.Drawing.Size(345, 24);
            this.checkBackup.TabIndex = 2;
            // 
            // checkAccessAdmin
            // 
            this.checkAccessAdmin.Location = new System.Drawing.Point(252, 198);
            this.checkAccessAdmin.Name = "checkAccessAdmin";
            this.checkAccessAdmin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkAccessAdmin.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkAccessAdmin.Properties.Appearance.Options.UseFont = true;
            this.checkAccessAdmin.Properties.Appearance.Options.UseForeColor = true;
            this.checkAccessAdmin.Properties.Caption = "Quản Lý Tài Khoản SQL Đăng Nhập";
            this.checkAccessAdmin.Size = new System.Drawing.Size(414, 24);
            this.checkAccessAdmin.TabIndex = 1;
            // 
            // checkOwner
            // 
            this.checkOwner.Location = new System.Drawing.Point(252, 151);
            this.checkOwner.Name = "checkOwner";
            this.checkOwner.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkOwner.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOwner.Properties.Appearance.Options.UseFont = true;
            this.checkOwner.Properties.Appearance.Options.UseForeColor = true;
            this.checkOwner.Properties.Caption = "Full-access";
            this.checkOwner.Size = new System.Drawing.Size(234, 24);
            this.checkOwner.TabIndex = 0;
            // 
            // frTaoRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTenRole);
            this.Controls.Add(this.checkReader);
            this.Controls.Add(this.checkWriter);
            this.Controls.Add(this.checkBackup);
            this.Controls.Add(this.checkAccessAdmin);
            this.Controls.Add(this.checkOwner);
            this.Name = "frTaoRole";
            this.Text = "Tạo Role";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkReader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAccessAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkOwner;
        private DevExpress.XtraEditors.CheckEdit checkAccessAdmin;
        private DevExpress.XtraEditors.CheckEdit checkBackup;
        private DevExpress.XtraEditors.CheckEdit checkWriter;
        private DevExpress.XtraEditors.CheckEdit checkReader;
        private DevExpress.XtraEditors.TextEdit txtTenRole;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button button1;
    }
}
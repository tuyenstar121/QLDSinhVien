﻿
namespace DXApplication1
{
    partial class frCapRole
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbMaUser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkReader = new DevExpress.XtraEditors.CheckEdit();
            this.checkWriter = new DevExpress.XtraEditors.CheckEdit();
            this.checkBackup = new DevExpress.XtraEditors.CheckEdit();
            this.checkAccessAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.checkOwner = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkReader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAccessAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(237, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(289, 29);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Cấp Role Cho Tài Khoản";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(173, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Mã Nhân Viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(173, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Tên Role";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(286, 117);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(240, 24);
            this.cbRole.TabIndex = 19;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbMaUser
            // 
            this.cbMaUser.FormattingEnabled = true;
            this.cbMaUser.Location = new System.Drawing.Point(286, 68);
            this.cbMaUser.Name = "cbMaUser";
            this.cbMaUser.Size = new System.Drawing.Size(240, 24);
            this.cbMaUser.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(385, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXacNhan.Location = new System.Drawing.Point(226, 385);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 51);
            this.btnXacNhan.TabIndex = 31;
            this.btnXacNhan.Text = "Cấp Role";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(158, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 17);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Các Quyền";
            // 
            // checkReader
            // 
            this.checkReader.Enabled = false;
            this.checkReader.Location = new System.Drawing.Point(286, 295);
            this.checkReader.Name = "checkReader";
            this.checkReader.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkReader.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkReader.Properties.Appearance.Options.UseFont = true;
            this.checkReader.Properties.Appearance.Options.UseForeColor = true;
            this.checkReader.Properties.Caption = "Đọc được toàn bộ dữ liệu";
            this.checkReader.Size = new System.Drawing.Size(284, 24);
            this.checkReader.TabIndex = 41;
            // 
            // checkWriter
            // 
            this.checkWriter.Enabled = false;
            this.checkWriter.Location = new System.Drawing.Point(286, 249);
            this.checkWriter.Name = "checkWriter";
            this.checkWriter.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkWriter.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkWriter.Properties.Appearance.Options.UseFont = true;
            this.checkWriter.Properties.Appearance.Options.UseForeColor = true;
            this.checkWriter.Properties.Caption = "Thêm, xóa hoặc chỉnh sửa dữ liệu trong bảng";
            this.checkWriter.Size = new System.Drawing.Size(413, 24);
            this.checkWriter.TabIndex = 40;
            // 
            // checkBackup
            // 
            this.checkBackup.Enabled = false;
            this.checkBackup.Location = new System.Drawing.Point(286, 339);
            this.checkBackup.Name = "checkBackup";
            this.checkBackup.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBackup.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBackup.Properties.Appearance.Options.UseFont = true;
            this.checkBackup.Properties.Appearance.Options.UseForeColor = true;
            this.checkBackup.Properties.Caption = "Sao lưu cơ sở dữ liệu";
            this.checkBackup.Size = new System.Drawing.Size(205, 24);
            this.checkBackup.TabIndex = 39;
            // 
            // checkAccessAdmin
            // 
            this.checkAccessAdmin.Enabled = false;
            this.checkAccessAdmin.Location = new System.Drawing.Point(286, 206);
            this.checkAccessAdmin.Name = "checkAccessAdmin";
            this.checkAccessAdmin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkAccessAdmin.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkAccessAdmin.Properties.Appearance.Options.UseFont = true;
            this.checkAccessAdmin.Properties.Appearance.Options.UseForeColor = true;
            this.checkAccessAdmin.Properties.Caption = "Quản Lý Tài Khoản SQL Đăng Nhập";
            this.checkAccessAdmin.Size = new System.Drawing.Size(387, 24);
            this.checkAccessAdmin.TabIndex = 38;
            // 
            // checkOwner
            // 
            this.checkOwner.Enabled = false;
            this.checkOwner.Location = new System.Drawing.Point(286, 159);
            this.checkOwner.Name = "checkOwner";
            this.checkOwner.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkOwner.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOwner.Properties.Appearance.Options.UseFont = true;
            this.checkOwner.Properties.Appearance.Options.UseForeColor = true;
            this.checkOwner.Properties.Caption = "Full-access";
            this.checkOwner.Size = new System.Drawing.Size(158, 24);
            this.checkOwner.TabIndex = 37;
            // 
            // frCapRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.checkReader);
            this.Controls.Add(this.checkWriter);
            this.Controls.Add(this.checkBackup);
            this.Controls.Add(this.checkAccessAdmin);
            this.Controls.Add(this.checkOwner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbMaUser);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "frCapRole";
            this.Text = "Cấp Role";
            this.Load += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.checkReader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAccessAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbMaUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkReader;
        private DevExpress.XtraEditors.CheckEdit checkWriter;
        private DevExpress.XtraEditors.CheckEdit checkBackup;
        private DevExpress.XtraEditors.CheckEdit checkAccessAdmin;
        private DevExpress.XtraEditors.CheckEdit checkOwner;
    }
}

namespace DXApplication1
{
    partial class frThuHoiCapNhatRole
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
            this.cbMaUser = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(195, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 16);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Mã Nhân Viên";
            this.labelControl1.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbMaUser
            // 
            this.cbMaUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMaUser.FormattingEnabled = true;
            this.cbMaUser.Location = new System.Drawing.Point(308, 140);
            this.cbMaUser.Name = "cbMaUser";
            this.cbMaUser.Size = new System.Drawing.Size(240, 24);
            this.cbMaUser.TabIndex = 25;
            this.cbMaUser.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.cbMaUser.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(195, 189);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Tên Role";
            this.labelControl4.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(153, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(488, 29);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Thu Hồi và Cập Nhật Tài Khoản Khỏi Role\r\n";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            this.labelControl3.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(457, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXacNhan.Location = new System.Drawing.Point(326, 254);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 51);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Thu Hồi ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            this.btnXacNhan.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbRole
            // 
            this.cbRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(308, 189);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(240, 24);
            this.cbRole.TabIndex = 29;
            this.cbRole.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(195, 254);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 51);
            this.btnCapNhat.TabIndex = 30;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.btnCapNhat.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // frThuHoiCapNhatRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbMaUser);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "frThuHoiCapNhatRole";
            this.Text = "Thu Hồi và Cập Nhật Tài Khoản Khỏi Role";
            this.Load += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.Move += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbMaUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
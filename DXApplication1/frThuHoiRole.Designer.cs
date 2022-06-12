
namespace DXApplication1
{
    partial class frThuHoiRole
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
            this.txtRole = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(181, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 16);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Mã Nhân Viên";
            // 
            // cbMaUser
            // 
            this.cbMaUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMaUser.FormattingEnabled = true;
            this.cbMaUser.Location = new System.Drawing.Point(294, 140);
            this.cbMaUser.Name = "cbMaUser";
            this.cbMaUser.Size = new System.Drawing.Size(240, 24);
            this.cbMaUser.TabIndex = 25;
            this.cbMaUser.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(181, 189);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Tên Role";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(194, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(340, 29);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Thu Hồi Role Khỏi Tài Khoản";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(294, 189);
            this.txtRole.Name = "txtRole";
            this.txtRole.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRole.Properties.Appearance.Options.UseForeColor = true;
            this.txtRole.Size = new System.Drawing.Size(240, 22);
            this.txtRole.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(383, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXacNhan.Location = new System.Drawing.Point(225, 254);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 51);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Thu Hồi ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // frThuHoiRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.cbMaUser);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "frThuHoiRole";
            this.Text = "Thu Hồi Role Khỏi Tài Khoản";
            this.Load += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbMaUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
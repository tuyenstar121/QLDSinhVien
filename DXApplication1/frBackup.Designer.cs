
namespace DXApplication1
{
    partial class frBackup
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
            this.txtBackup = new DevExpress.XtraEditors.TextEdit();
            this.txtRestore = new DevExpress.XtraEditors.TextEdit();
            this.btnDifferent_Backup = new System.Windows.Forms.Button();
            this.btnFull_Backup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.checkIsDifferentialRestore = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsDifferentialRestore.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(152, 84);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(380, 22);
            this.txtBackup.TabIndex = 0;
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(152, 53);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(380, 22);
            this.txtRestore.TabIndex = 1;
            // 
            // btnDifferent_Backup
            // 
            this.btnDifferent_Backup.BackColor = System.Drawing.Color.Lime;
            this.btnDifferent_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDifferent_Backup.ForeColor = System.Drawing.Color.Black;
            this.btnDifferent_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDifferent_Backup.Location = new System.Drawing.Point(405, 125);
            this.btnDifferent_Backup.Name = "btnDifferent_Backup";
            this.btnDifferent_Backup.Size = new System.Drawing.Size(188, 29);
            this.btnDifferent_Backup.TabIndex = 2;
            this.btnDifferent_Backup.Text = "Differentinal Backup";
            this.btnDifferent_Backup.UseVisualStyleBackColor = false;
            this.btnDifferent_Backup.Click += new System.EventHandler(this.btnDiffBackup_Click);
            // 
            // btnFull_Backup
            // 
            this.btnFull_Backup.BackColor = System.Drawing.Color.Lime;
            this.btnFull_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFull_Backup.ForeColor = System.Drawing.Color.Black;
            this.btnFull_Backup.Location = new System.Drawing.Point(177, 125);
            this.btnFull_Backup.Name = "btnFull_Backup";
            this.btnFull_Backup.Size = new System.Drawing.Size(176, 28);
            this.btnFull_Backup.TabIndex = 4;
            this.btnFull_Backup.Text = "Backup Bản Full";
            this.btnFull_Backup.UseVisualStyleBackColor = false;
            this.btnFull_Backup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Lime;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(177, 100);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(154, 25);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore Bản Full";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(279, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Backup";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(276, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 22);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Resotre";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnDifferent_Backup);
            this.panelControl1.Controls.Add(this.txtBackup);
            this.panelControl1.Controls.Add(this.btnFull_Backup);
            this.panelControl1.Location = new System.Drawing.Point(167, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(733, 176);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 17);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Vị Trí File Backup";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkIsDifferentialRestore);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtRestore);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.btnRestore);
            this.panelControl2.Location = new System.Drawing.Point(167, 227);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(733, 170);
            this.panelControl2.TabIndex = 11;
            // 
            // checkIsDifferentialRestore
            // 
            this.checkIsDifferentialRestore.Location = new System.Drawing.Point(405, 103);
            this.checkIsDifferentialRestore.Name = "checkIsDifferentialRestore";
            this.checkIsDifferentialRestore.Properties.Caption = "ReStore Bản Full Và Differen";
            this.checkIsDifferentialRestore.Size = new System.Drawing.Size(227, 21);
            this.checkIsDifferentialRestore.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Vị Trí File Restore";
            // 
            // frBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 557);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frBackup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsDifferentialRestore.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBackup;
        private DevExpress.XtraEditors.TextEdit txtRestore;
        private System.Windows.Forms.Button btnDifferent_Backup;
        private System.Windows.Forms.Button btnFull_Backup;
        private System.Windows.Forms.Button btnRestore;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkIsDifferentialRestore;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
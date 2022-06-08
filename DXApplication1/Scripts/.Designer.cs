
namespace DXApplication1.Scripts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qLDSV_TCDataSet3 = new DXApplication1.QLDSV_TCDataSet3();
            this.sP_LayLOTCTHEOMAGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LayLOTCTHEOMAGVTableAdapter = new DXApplication1.QLDSV_TCDataSet3TableAdapters.SP_LayLOTCTHEOMAGVTableAdapter();
            this.tableAdapterManager = new DXApplication1.QLDSV_TCDataSet3TableAdapters.TableAdapterManager();
            this.sP_LayLOTCTHEOMAGVBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.maGVToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maGVToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sP_LayLOTCTHEOMAGVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVBindingNavigator)).BeginInit();
            this.sP_LayLOTCTHEOMAGVBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSV_TCDataSet3
            // 
            this.qLDSV_TCDataSet3.DataSetName = "QLDSV_TCDataSet3";
            this.qLDSV_TCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LayLOTCTHEOMAGVBindingSource
            // 
            this.sP_LayLOTCTHEOMAGVBindingSource.DataMember = "SP_LayLOTCTHEOMAGV";
            this.sP_LayLOTCTHEOMAGVBindingSource.DataSource = this.qLDSV_TCDataSet3;
            // 
            // sP_LayLOTCTHEOMAGVTableAdapter
            // 
            this.sP_LayLOTCTHEOMAGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication1.QLDSV_TCDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LayLOTCTHEOMAGVBindingNavigator
            // 
            this.sP_LayLOTCTHEOMAGVBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.BindingSource = this.sP_LayLOTCTHEOMAGVBindingSource;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sP_LayLOTCTHEOMAGVBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem});
            this.sP_LayLOTCTHEOMAGVBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sP_LayLOTCTHEOMAGVBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.Name = "sP_LayLOTCTHEOMAGVBindingNavigator";
            this.sP_LayLOTCTHEOMAGVBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.sP_LayLOTCTHEOMAGVBindingNavigator.TabIndex = 0;
            this.sP_LayLOTCTHEOMAGVBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem
            // 
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Enabled = false;
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Image")));
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Name = "sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem";
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maGVToolStripLabel,
            this.maGVToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 31);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 31);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // maGVToolStripLabel
            // 
            this.maGVToolStripLabel.Name = "maGVToolStripLabel";
            this.maGVToolStripLabel.Size = new System.Drawing.Size(52, 24);
            this.maGVToolStripLabel.Text = "MaGV:";
            // 
            // maGVToolStripTextBox
            // 
            this.maGVToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maGVToolStripTextBox.Name = "maGVToolStripTextBox";
            this.maGVToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sP_LayLOTCTHEOMAGVGridControl
            // 
            this.sP_LayLOTCTHEOMAGVGridControl.DataSource = this.sP_LayLOTCTHEOMAGVBindingSource;
            this.sP_LayLOTCTHEOMAGVGridControl.Location = new System.Drawing.Point(86, 97);
            this.sP_LayLOTCTHEOMAGVGridControl.MainView = this.gridView1;
            this.sP_LayLOTCTHEOMAGVGridControl.Name = "sP_LayLOTCTHEOMAGVGridControl";
            this.sP_LayLOTCTHEOMAGVGridControl.Size = new System.Drawing.Size(592, 262);
            this.sP_LayLOTCTHEOMAGVGridControl.TabIndex = 2;
            this.sP_LayLOTCTHEOMAGVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_LayLOTCTHEOMAGVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sP_LayLOTCTHEOMAGVGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sP_LayLOTCTHEOMAGVBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVBindingNavigator)).EndInit();
            this.sP_LayLOTCTHEOMAGVBindingNavigator.ResumeLayout(false);
            this.sP_LayLOTCTHEOMAGVBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LayLOTCTHEOMAGVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSV_TCDataSet3 qLDSV_TCDataSet3;
        private System.Windows.Forms.BindingSource sP_LayLOTCTHEOMAGVBindingSource;
        private QLDSV_TCDataSet3TableAdapters.SP_LayLOTCTHEOMAGVTableAdapter sP_LayLOTCTHEOMAGVTableAdapter;
        private QLDSV_TCDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sP_LayLOTCTHEOMAGVBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sP_LayLOTCTHEOMAGVBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel maGVToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maGVToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sP_LayLOTCTHEOMAGVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
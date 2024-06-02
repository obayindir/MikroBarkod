namespace MikroBarkod.Forms
{
    partial class FrmStokSecim
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sto_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sto_isim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sto_birim1_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(799, 806);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sto_kod,
            this.sto_isim,
            this.sto_birim1_ad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // sto_kod
            // 
            this.sto_kod.Caption = "Kod";
            this.sto_kod.FieldName = "sto_kod";
            this.sto_kod.MinWidth = 30;
            this.sto_kod.Name = "sto_kod";
            this.sto_kod.Visible = true;
            this.sto_kod.VisibleIndex = 0;
            this.sto_kod.Width = 201;
            // 
            // sto_isim
            // 
            this.sto_isim.Caption = "İsim";
            this.sto_isim.FieldName = "sto_isim";
            this.sto_isim.MinWidth = 30;
            this.sto_isim.Name = "sto_isim";
            this.sto_isim.Visible = true;
            this.sto_isim.VisibleIndex = 1;
            this.sto_isim.Width = 433;
            // 
            // sto_birim1_ad
            // 
            this.sto_birim1_ad.Caption = "1. Birimi";
            this.sto_birim1_ad.FieldName = "sto_birim1_ad";
            this.sto_birim1_ad.MinWidth = 30;
            this.sto_birim1_ad.Name = "sto_birim1_ad";
            this.sto_birim1_ad.Visible = true;
            this.sto_birim1_ad.VisibleIndex = 2;
            this.sto_birim1_ad.Width = 129;
            // 
            // FrmStokSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 806);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seçim";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn sto_kod;
        private DevExpress.XtraGrid.Columns.GridColumn sto_isim;
        private DevExpress.XtraGrid.Columns.GridColumn sto_birim1_ad;
    }
}
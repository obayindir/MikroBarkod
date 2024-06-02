namespace MikroBarkod.Forms.Evraklar
{
    partial class FrmFasonHareketFoyu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFasonHareketFoyu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateSonTarih = new DevExpress.XtraEditors.DateEdit();
            this.dateIlkTarih = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAYIT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARİH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SERI_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SIRA_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAK_TİPİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HAREKET_CİNSİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TİPİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HAREKET_KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOPLAM_SİPARİŞ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KALAN_MALZEME_ADEDİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ÜRETİLEN_MİKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEVK_EDİLEN_MALZEME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AÇIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FASONCU_KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FASONCU_UNVANI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSonTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSonTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIlkTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIlkTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExcel);
            this.groupControl1.Controls.Add(this.dateSonTarih);
            this.groupControl1.Controls.Add(this.dateIlkTarih);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1868, 136);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // dateSonTarih
            // 
            this.dateSonTarih.EditValue = null;
            this.dateSonTarih.EnterMoveNextControl = true;
            this.dateSonTarih.Location = new System.Drawing.Point(110, 58);
            this.dateSonTarih.Name = "dateSonTarih";
            this.dateSonTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSonTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSonTarih.Size = new System.Drawing.Size(314, 26);
            this.dateSonTarih.TabIndex = 2;
            // 
            // dateIlkTarih
            // 
            this.dateIlkTarih.EditValue = null;
            this.dateIlkTarih.EnterMoveNextControl = true;
            this.dateIlkTarih.Location = new System.Drawing.Point(110, 12);
            this.dateIlkTarih.Name = "dateIlkTarih";
            this.dateIlkTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIlkTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIlkTarih.Size = new System.Drawing.Size(314, 26);
            this.dateIlkTarih.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(464, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 75);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Çalıştır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Son Tarih";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "İlk Tarih";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 136);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1868, 932);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1864, 928);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEPO,
            this.KAYIT_NO,
            this.TARİH,
            this.AY,
            this.SERI_NO,
            this.SIRA_NO,
            this.EVRAK_TİPİ,
            this.HAREKET_CİNSİ,
            this.TİPİ,
            this.HAREKET_KODU,
            this.TOPLAM_SİPARİŞ,
            this.KALAN_MALZEME_ADEDİ,
            this.ÜRETİLEN_MİKTAR,
            this.SEVK_EDİLEN_MALZEME,
            this.AÇIKLAMA,
            this.FASONCU_KODU,
            this.FASONCU_UNVANI});
            this.gridView1.DetailHeight = 349;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFormat = "{1}";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.FASONCU_UNVANI, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.HAREKET_KODU, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // DEPO
            // 
            this.DEPO.Caption = "DEPO";
            this.DEPO.FieldName = "msg_S_0159";
            this.DEPO.MinWidth = 30;
            this.DEPO.Name = "DEPO";
            this.DEPO.OptionsColumn.ReadOnly = true;
            this.DEPO.Visible = true;
            this.DEPO.VisibleIndex = 2;
            this.DEPO.Width = 112;
            // 
            // KAYIT_NO
            // 
            this.KAYIT_NO.Caption = "KAYIT_NO";
            this.KAYIT_NO.FieldName = "#msg_S_0088";
            this.KAYIT_NO.MinWidth = 30;
            this.KAYIT_NO.Name = "KAYIT_NO";
            this.KAYIT_NO.OptionsColumn.ReadOnly = true;
            this.KAYIT_NO.Width = 112;
            // 
            // TARİH
            // 
            this.TARİH.Caption = "TARİH";
            this.TARİH.FieldName = "msg_S_0089";
            this.TARİH.MinWidth = 30;
            this.TARİH.Name = "TARİH";
            this.TARİH.OptionsColumn.ReadOnly = true;
            this.TARİH.Visible = true;
            this.TARİH.VisibleIndex = 0;
            this.TARİH.Width = 112;
            // 
            // AY
            // 
            this.AY.Caption = "AY";
            this.AY.FieldName = "msg_S_0223";
            this.AY.MinWidth = 30;
            this.AY.Name = "AY";
            this.AY.OptionsColumn.ReadOnly = true;
            this.AY.Visible = true;
            this.AY.VisibleIndex = 1;
            this.AY.Width = 112;
            // 
            // SERI_NO
            // 
            this.SERI_NO.Caption = "SERI";
            this.SERI_NO.FieldName = "msg_S_0090";
            this.SERI_NO.MinWidth = 30;
            this.SERI_NO.Name = "SERI_NO";
            this.SERI_NO.OptionsColumn.ReadOnly = true;
            this.SERI_NO.Visible = true;
            this.SERI_NO.VisibleIndex = 3;
            this.SERI_NO.Width = 112;
            // 
            // SIRA_NO
            // 
            this.SIRA_NO.Caption = "SIRA NO";
            this.SIRA_NO.FieldName = "msg_S_0157";
            this.SIRA_NO.MinWidth = 30;
            this.SIRA_NO.Name = "SIRA_NO";
            this.SIRA_NO.OptionsColumn.ReadOnly = true;
            this.SIRA_NO.Visible = true;
            this.SIRA_NO.VisibleIndex = 4;
            this.SIRA_NO.Width = 112;
            // 
            // EVRAK_TİPİ
            // 
            this.EVRAK_TİPİ.Caption = "EVRAK TİPİ";
            this.EVRAK_TİPİ.FieldName = "msg_S_0094";
            this.EVRAK_TİPİ.MinWidth = 30;
            this.EVRAK_TİPİ.Name = "EVRAK_TİPİ";
            this.EVRAK_TİPİ.OptionsColumn.ReadOnly = true;
            this.EVRAK_TİPİ.Width = 112;
            // 
            // HAREKET_CİNSİ
            // 
            this.HAREKET_CİNSİ.Caption = "HAREKET CİNSİ";
            this.HAREKET_CİNSİ.FieldName = "msg_S_0158";
            this.HAREKET_CİNSİ.MinWidth = 30;
            this.HAREKET_CİNSİ.Name = "HAREKET_CİNSİ";
            this.HAREKET_CİNSİ.OptionsColumn.ReadOnly = true;
            this.HAREKET_CİNSİ.Width = 112;
            // 
            // TİPİ
            // 
            this.TİPİ.Caption = "TİPİ";
            this.TİPİ.FieldName = "msg_S_0077";
            this.TİPİ.MinWidth = 30;
            this.TİPİ.Name = "TİPİ";
            this.TİPİ.OptionsColumn.ReadOnly = true;
            this.TİPİ.Width = 112;
            // 
            // HAREKET_KODU
            // 
            this.HAREKET_KODU.Caption = "HAREKET_KODU";
            this.HAREKET_KODU.FieldName = "HAREKET_KODU";
            this.HAREKET_KODU.MinWidth = 30;
            this.HAREKET_KODU.Name = "HAREKET_KODU";
            this.HAREKET_KODU.OptionsColumn.ReadOnly = true;
            this.HAREKET_KODU.Visible = true;
            this.HAREKET_KODU.VisibleIndex = 8;
            this.HAREKET_KODU.Width = 112;
            // 
            // TOPLAM_SİPARİŞ
            // 
            this.TOPLAM_SİPARİŞ.Caption = "TOPLAM SİPARİŞ";
            this.TOPLAM_SİPARİŞ.FieldName = "TOPLAM_SİPARİŞ";
            this.TOPLAM_SİPARİŞ.MinWidth = 30;
            this.TOPLAM_SİPARİŞ.Name = "TOPLAM_SİPARİŞ";
            this.TOPLAM_SİPARİŞ.OptionsColumn.ReadOnly = true;
            this.TOPLAM_SİPARİŞ.Visible = true;
            this.TOPLAM_SİPARİŞ.VisibleIndex = 5;
            this.TOPLAM_SİPARİŞ.Width = 112;
            // 
            // KALAN_MALZEME_ADEDİ
            // 
            this.KALAN_MALZEME_ADEDİ.Caption = "KALAN MALZEME ADEDİ";
            this.KALAN_MALZEME_ADEDİ.FieldName = "KALAN_MALZEME_ADEDİ";
            this.KALAN_MALZEME_ADEDİ.MinWidth = 30;
            this.KALAN_MALZEME_ADEDİ.Name = "KALAN_MALZEME_ADEDİ";
            this.KALAN_MALZEME_ADEDİ.OptionsColumn.ReadOnly = true;
            this.KALAN_MALZEME_ADEDİ.Visible = true;
            this.KALAN_MALZEME_ADEDİ.VisibleIndex = 6;
            this.KALAN_MALZEME_ADEDİ.Width = 112;
            // 
            // ÜRETİLEN_MİKTAR
            // 
            this.ÜRETİLEN_MİKTAR.Caption = "ÜRETİLEN MİKTAR";
            this.ÜRETİLEN_MİKTAR.FieldName = "msg_S_0080\\T";
            this.ÜRETİLEN_MİKTAR.MinWidth = 30;
            this.ÜRETİLEN_MİKTAR.Name = "ÜRETİLEN_MİKTAR";
            this.ÜRETİLEN_MİKTAR.OptionsColumn.ReadOnly = true;
            this.ÜRETİLEN_MİKTAR.Visible = true;
            this.ÜRETİLEN_MİKTAR.VisibleIndex = 7;
            this.ÜRETİLEN_MİKTAR.Width = 112;
            // 
            // SEVK_EDİLEN_MALZEME
            // 
            this.SEVK_EDİLEN_MALZEME.Caption = "SEVK EDİLEN MALZEME";
            this.SEVK_EDİLEN_MALZEME.FieldName = "msg_S_1292\\T";
            this.SEVK_EDİLEN_MALZEME.MinWidth = 30;
            this.SEVK_EDİLEN_MALZEME.Name = "SEVK_EDİLEN_MALZEME";
            this.SEVK_EDİLEN_MALZEME.OptionsColumn.ReadOnly = true;
            this.SEVK_EDİLEN_MALZEME.Visible = true;
            this.SEVK_EDİLEN_MALZEME.VisibleIndex = 8;
            this.SEVK_EDİLEN_MALZEME.Width = 112;
            // 
            // AÇIKLAMA
            // 
            this.AÇIKLAMA.Caption = "AÇIKLAMA";
            this.AÇIKLAMA.FieldName = "msg_S_0085";
            this.AÇIKLAMA.MinWidth = 30;
            this.AÇIKLAMA.Name = "AÇIKLAMA";
            this.AÇIKLAMA.OptionsColumn.ReadOnly = true;
            this.AÇIKLAMA.Visible = true;
            this.AÇIKLAMA.VisibleIndex = 9;
            this.AÇIKLAMA.Width = 112;
            // 
            // FASONCU_KODU
            // 
            this.FASONCU_KODU.Caption = "FASONCU_KODU";
            this.FASONCU_KODU.FieldName = "msg_S_0200";
            this.FASONCU_KODU.MinWidth = 30;
            this.FASONCU_KODU.Name = "FASONCU_KODU";
            this.FASONCU_KODU.OptionsColumn.ReadOnly = true;
            this.FASONCU_KODU.Width = 112;
            // 
            // FASONCU_UNVANI
            // 
            this.FASONCU_UNVANI.Caption = "FASONCU";
            this.FASONCU_UNVANI.FieldName = "msg_S_0201";
            this.FASONCU_UNVANI.MinWidth = 30;
            this.FASONCU_UNVANI.Name = "FASONCU_UNVANI";
            this.FASONCU_UNVANI.OptionsColumn.ReadOnly = true;
            this.FASONCU_UNVANI.Visible = true;
            this.FASONCU_UNVANI.VisibleIndex = 10;
            this.FASONCU_UNVANI.Width = 112;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1720, 87);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(136, 43);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmFasonHareketFoyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1068);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFasonHareketFoyu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fason Hareket Föyü";
            this.Load += new System.EventHandler(this.FrmFasonHareketFoyu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSonTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSonTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIlkTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateIlkTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateSonTarih;
        private DevExpress.XtraEditors.DateEdit dateIlkTarih;
        private DevExpress.XtraGrid.Columns.GridColumn DEPO;
        private DevExpress.XtraGrid.Columns.GridColumn KAYIT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn TARİH;
        private DevExpress.XtraGrid.Columns.GridColumn AY;
        private DevExpress.XtraGrid.Columns.GridColumn SERI_NO;
        private DevExpress.XtraGrid.Columns.GridColumn SIRA_NO;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAK_TİPİ;
        private DevExpress.XtraGrid.Columns.GridColumn HAREKET_CİNSİ;
        private DevExpress.XtraGrid.Columns.GridColumn TİPİ;
        private DevExpress.XtraGrid.Columns.GridColumn HAREKET_KODU;
        private DevExpress.XtraGrid.Columns.GridColumn TOPLAM_SİPARİŞ;
        private DevExpress.XtraGrid.Columns.GridColumn KALAN_MALZEME_ADEDİ;
        private DevExpress.XtraGrid.Columns.GridColumn ÜRETİLEN_MİKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn SEVK_EDİLEN_MALZEME;
        private DevExpress.XtraGrid.Columns.GridColumn AÇIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn FASONCU_KODU;
        private DevExpress.XtraGrid.Columns.GridColumn FASONCU_UNVANI;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
    }
}
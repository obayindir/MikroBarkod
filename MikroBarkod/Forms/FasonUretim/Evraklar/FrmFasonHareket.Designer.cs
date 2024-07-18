namespace MikroBarkod.Forms.Evraklar
{
    partial class FrmFasonHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFasonHareket));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.dateSonTarih = new DevExpress.XtraEditors.DateEdit();
            this.dateIlkTarih = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
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
            this.repoItemInfoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.repoItemInfoEdit)).BeginInit();
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
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1245, 93);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1147, 60);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 29);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dateSonTarih
            // 
            this.dateSonTarih.EditValue = null;
            this.dateSonTarih.EnterMoveNextControl = true;
            this.dateSonTarih.Location = new System.Drawing.Point(73, 40);
            this.dateSonTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dateSonTarih.Name = "dateSonTarih";
            this.dateSonTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSonTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSonTarih.Size = new System.Drawing.Size(209, 20);
            this.dateSonTarih.TabIndex = 2;
            // 
            // dateIlkTarih
            // 
            this.dateIlkTarih.EditValue = null;
            this.dateIlkTarih.EnterMoveNextControl = true;
            this.dateIlkTarih.Location = new System.Drawing.Point(73, 8);
            this.dateIlkTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dateIlkTarih.Name = "dateIlkTarih";
            this.dateIlkTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIlkTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateIlkTarih.Size = new System.Drawing.Size(209, 20);
            this.dateIlkTarih.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(309, 10);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 51);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Çalıştır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 45);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Son Tarih";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "İlk Tarih";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 93);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1245, 638);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(2, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(21, 20);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoItemInfoEdit});
            this.gridControl1.Size = new System.Drawing.Size(1241, 634);
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
            this.gridView1.DetailHeight = 239;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFormat = "{1}";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.FASONCU_UNVANI, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.HAREKET_KODU, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // DEPO
            // 
            this.DEPO.Caption = "DEPO";
            this.DEPO.FieldName = "msg_S_0159";
            this.DEPO.Name = "DEPO";
            this.DEPO.OptionsColumn.ReadOnly = true;
            this.DEPO.Visible = true;
            this.DEPO.VisibleIndex = 1;
            // 
            // KAYIT_NO
            // 
            this.KAYIT_NO.Caption = "KAYIT_NO";
            this.KAYIT_NO.FieldName = "#msg_S_0088";
            this.KAYIT_NO.Name = "KAYIT_NO";
            this.KAYIT_NO.OptionsColumn.ReadOnly = true;
            // 
            // TARİH
            // 
            this.TARİH.Caption = "TARİH";
            this.TARİH.FieldName = "msg_S_0089";
            this.TARİH.Name = "TARİH";
            this.TARİH.OptionsColumn.ReadOnly = true;
            this.TARİH.Visible = true;
            this.TARİH.VisibleIndex = 0;
            // 
            // AY
            // 
            this.AY.Caption = "AY";
            this.AY.FieldName = "msg_S_0223";
            this.AY.Name = "AY";
            this.AY.OptionsColumn.ReadOnly = true;
            // 
            // SERI_NO
            // 
            this.SERI_NO.Caption = "SERI";
            this.SERI_NO.FieldName = "msg_S_0090";
            this.SERI_NO.Name = "SERI_NO";
            this.SERI_NO.OptionsColumn.ReadOnly = true;
            this.SERI_NO.Visible = true;
            this.SERI_NO.VisibleIndex = 2;
            // 
            // SIRA_NO
            // 
            this.SIRA_NO.Caption = "SIRA NO";
            this.SIRA_NO.FieldName = "msg_S_0157";
            this.SIRA_NO.Name = "SIRA_NO";
            this.SIRA_NO.OptionsColumn.ReadOnly = true;
            this.SIRA_NO.Visible = true;
            this.SIRA_NO.VisibleIndex = 3;
            // 
            // EVRAK_TİPİ
            // 
            this.EVRAK_TİPİ.Caption = "EVRAK TİPİ";
            this.EVRAK_TİPİ.FieldName = "msg_S_0094";
            this.EVRAK_TİPİ.Name = "EVRAK_TİPİ";
            this.EVRAK_TİPİ.OptionsColumn.ReadOnly = true;
            // 
            // HAREKET_CİNSİ
            // 
            this.HAREKET_CİNSİ.Caption = "HAREKET CİNSİ";
            this.HAREKET_CİNSİ.FieldName = "msg_S_0158";
            this.HAREKET_CİNSİ.Name = "HAREKET_CİNSİ";
            this.HAREKET_CİNSİ.OptionsColumn.ReadOnly = true;
            // 
            // TİPİ
            // 
            this.TİPİ.Caption = "TİPİ";
            this.TİPİ.FieldName = "msg_S_0077";
            this.TİPİ.Name = "TİPİ";
            this.TİPİ.OptionsColumn.ReadOnly = true;
            // 
            // HAREKET_KODU
            // 
            this.HAREKET_KODU.Caption = "HAREKET_KODU";
            this.HAREKET_KODU.FieldName = "HAREKET_KODU";
            this.HAREKET_KODU.Name = "HAREKET_KODU";
            this.HAREKET_KODU.OptionsColumn.ReadOnly = true;
            this.HAREKET_KODU.Visible = true;
            this.HAREKET_KODU.VisibleIndex = 8;
            // 
            // TOPLAM_SİPARİŞ
            // 
            this.TOPLAM_SİPARİŞ.Caption = "TOPLAM SİPARİŞ";
            this.TOPLAM_SİPARİŞ.DisplayFormat.FormatString = "N2";
            this.TOPLAM_SİPARİŞ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TOPLAM_SİPARİŞ.FieldName = "TOPLAM_SİPARİŞ";
            this.TOPLAM_SİPARİŞ.Name = "TOPLAM_SİPARİŞ";
            this.TOPLAM_SİPARİŞ.OptionsColumn.ReadOnly = true;
            this.TOPLAM_SİPARİŞ.Visible = true;
            this.TOPLAM_SİPARİŞ.VisibleIndex = 4;
            // 
            // KALAN_MALZEME_ADEDİ
            // 
            this.KALAN_MALZEME_ADEDİ.Caption = "KALAN MALZEME ADEDİ";
            this.KALAN_MALZEME_ADEDİ.FieldName = "KALAN_MALZEME_ADEDİ";
            this.KALAN_MALZEME_ADEDİ.Name = "KALAN_MALZEME_ADEDİ";
            this.KALAN_MALZEME_ADEDİ.OptionsColumn.ReadOnly = true;
            // 
            // ÜRETİLEN_MİKTAR
            // 
            this.ÜRETİLEN_MİKTAR.Caption = "ÜRETİLEN MİKTAR";
            this.ÜRETİLEN_MİKTAR.DisplayFormat.FormatString = "N2";
            this.ÜRETİLEN_MİKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ÜRETİLEN_MİKTAR.FieldName = "msg_S_0080\\T";
            this.ÜRETİLEN_MİKTAR.Name = "ÜRETİLEN_MİKTAR";
            this.ÜRETİLEN_MİKTAR.OptionsColumn.ReadOnly = true;
            this.ÜRETİLEN_MİKTAR.Visible = true;
            this.ÜRETİLEN_MİKTAR.VisibleIndex = 5;
            // 
            // SEVK_EDİLEN_MALZEME
            // 
            this.SEVK_EDİLEN_MALZEME.Caption = "SEVK EDİLEN MALZEME";
            this.SEVK_EDİLEN_MALZEME.DisplayFormat.FormatString = "N2";
            this.SEVK_EDİLEN_MALZEME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SEVK_EDİLEN_MALZEME.FieldName = "msg_S_1292\\T";
            this.SEVK_EDİLEN_MALZEME.Name = "SEVK_EDİLEN_MALZEME";
            this.SEVK_EDİLEN_MALZEME.OptionsColumn.ReadOnly = true;
            this.SEVK_EDİLEN_MALZEME.Visible = true;
            this.SEVK_EDİLEN_MALZEME.VisibleIndex = 6;
            // 
            // AÇIKLAMA
            // 
            this.AÇIKLAMA.Caption = "AÇIKLAMA";
            this.AÇIKLAMA.FieldName = "msg_S_0085";
            this.AÇIKLAMA.Name = "AÇIKLAMA";
            this.AÇIKLAMA.OptionsColumn.ReadOnly = true;
            this.AÇIKLAMA.Visible = true;
            this.AÇIKLAMA.VisibleIndex = 7;
            // 
            // FASONCU_KODU
            // 
            this.FASONCU_KODU.Caption = "FASONCU_KODU";
            this.FASONCU_KODU.FieldName = "msg_S_0200";
            this.FASONCU_KODU.Name = "FASONCU_KODU";
            this.FASONCU_KODU.OptionsColumn.ReadOnly = true;
            // 
            // FASONCU_UNVANI
            // 
            this.FASONCU_UNVANI.Caption = "FASONCU";
            this.FASONCU_UNVANI.FieldName = "msg_S_0201";
            this.FASONCU_UNVANI.Name = "FASONCU_UNVANI";
            this.FASONCU_UNVANI.OptionsColumn.ReadOnly = true;
            this.FASONCU_UNVANI.Visible = true;
            this.FASONCU_UNVANI.VisibleIndex = 10;
            // 
            // repoItemInfoEdit
            // 
            this.repoItemInfoEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repoItemInfoEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoItemInfoEdit.Name = "repoItemInfoEdit";
            // 
            // FrmFasonHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 731);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFasonHareket";
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
            ((System.ComponentModel.ISupportInitialize)(this.repoItemInfoEdit)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoItemInfoEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
namespace MikroBarkod
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSiparisUretim = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFasonaCikisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnFasondanGirisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFasonHareketFoyu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnManuelEtiket = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrimHakedisRaporu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtnSiparisUretim,
            this.barBtnFasonaCikisFisi,
            this.skinPaletteDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1,
            this.barListItem1,
            this.barStaticItem1,
            this.barBtnFasondanGirisFisi,
            this.barBtnFasonHareketFoyu,
            this.barBtnManuelEtiket,
            this.btnPrimHakedisRaporu});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1874, 231);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnSiparisUretim
            // 
            this.barBtnSiparisUretim.Caption = "Sipariş Üretim";
            this.barBtnSiparisUretim.Id = 1;
            this.barBtnSiparisUretim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSiparisUretim.ImageOptions.SvgImage")));
            this.barBtnSiparisUretim.Name = "barBtnSiparisUretim";
            this.barBtnSiparisUretim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSiparisUretim_ItemClick);
            // 
            // barBtnFasonaCikisFisi
            // 
            this.barBtnFasonaCikisFisi.Caption = "Fasona Çıkış Fişi";
            this.barBtnFasonaCikisFisi.Id = 2;
            this.barBtnFasonaCikisFisi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnFasonaCikisFisi.ImageOptions.SvgImage")));
            this.barBtnFasonaCikisFisi.Name = "barBtnFasonaCikisFisi";
            this.barBtnFasonaCikisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFasonaCikisFisi_ItemClick);
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 3;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 5;
            this.barListItem1.Name = "barListItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Plasgen © 2024";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtnFasondanGirisFisi
            // 
            this.barBtnFasondanGirisFisi.Caption = "Fasondan Giriş Fişi";
            this.barBtnFasondanGirisFisi.Id = 7;
            this.barBtnFasondanGirisFisi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnFasondanGirisFisi.ImageOptions.SvgImage")));
            this.barBtnFasondanGirisFisi.Name = "barBtnFasondanGirisFisi";
            this.barBtnFasondanGirisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFasondanGirisFisi_ItemClick);
            // 
            // barBtnFasonHareketFoyu
            // 
            this.barBtnFasonHareketFoyu.Caption = "Fason Hareket Föyü";
            this.barBtnFasonHareketFoyu.Id = 8;
            this.barBtnFasonHareketFoyu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnFasonHareketFoyu.ImageOptions.Image")));
            this.barBtnFasonHareketFoyu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnFasonHareketFoyu.ImageOptions.LargeImage")));
            this.barBtnFasonHareketFoyu.Name = "barBtnFasonHareketFoyu";
            this.barBtnFasonHareketFoyu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFasonHareketFoyu_ItemClick);
            // 
            // barBtnManuelEtiket
            // 
            this.barBtnManuelEtiket.Caption = "Manuel Etiket Basımı";
            this.barBtnManuelEtiket.Id = 9;
            this.barBtnManuelEtiket.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnManuelEtiket.ImageOptions.SvgImage")));
            this.barBtnManuelEtiket.Name = "barBtnManuelEtiket";
            this.barBtnManuelEtiket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnManuelEtiket_ItemClick);
            // 
            // btnPrimHakedisRaporu
            // 
            this.btnPrimHakedisRaporu.Caption = "Prim Hakediş Raporu";
            this.btnPrimHakedisRaporu.Id = 10;
            this.btnPrimHakedisRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimHakedisRaporu.ImageOptions.Image")));
            this.btnPrimHakedisRaporu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrimHakedisRaporu.ImageOptions.LargeImage")));
            this.btnPrimHakedisRaporu.Name = "btnPrimHakedisRaporu";
            this.btnPrimHakedisRaporu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrimHakedisRaporu_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSiparisUretim, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnManuelEtiket);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sipariş";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnFasonaCikisFisi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnFasondanGirisFisi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnFasonHareketFoyu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Fason";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPrimHakedisRaporu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Prim";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1063);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1874, 36);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 1099);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMainMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnSiparisUretim;
        private DevExpress.XtraBars.BarButtonItem barBtnFasonaCikisFisi;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnFasondanGirisFisi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnFasonHareketFoyu;
        private DevExpress.XtraBars.BarButtonItem barBtnManuelEtiket;
        private DevExpress.XtraBars.BarButtonItem btnPrimHakedisRaporu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}
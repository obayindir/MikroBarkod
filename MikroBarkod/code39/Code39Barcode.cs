using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace MikroBarkod.code39
{
    public partial class Code39Barcode : DevExpress.XtraReports.UI.XtraReport
    {
        public Code39Barcode(string cariAdi, string stokAdi, int koliIciAdet, DateTime uretimTarihi, DateTime SonKT, string barkod)
        {

            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;

            this.PageWidth = 393;
            this.PageHeight = 590;
            this.Landscape = true;




            xrKoliIciAdet.Text = koliIciAdet.ToString();
            xrUrun.Text = cariAdi.ToString();
            xrUrunAdi.Text = stokAdi.ToString();
            xrUrTarihi.Text = uretimTarihi.ToString("dd.MM.yyyy");
            xrSkt.Text = SonKT.ToString("dd.MM.yyyy");

            xrBarCode1.Text = barkod.ToString();



        }

    }
}

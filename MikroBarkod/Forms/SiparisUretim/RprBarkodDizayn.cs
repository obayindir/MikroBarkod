using DevExpress.Office.Design.Internal;
using DevExpress.Office.Utils;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace MikroBarkod
{
    public partial class RprBarkodDizayn : DevExpress.XtraReports.UI.XtraReport
    {
        
        public RprBarkodDizayn(string cariAdi,string stokAdi,int koliIciAdet,DateTime uretimTarihi,DateTime SonKT,string barkod)
        {
        
            InitializeComponent();
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;

            this.PageWidth = 393; 
            this.PageHeight = 590;
            this.Landscape = true;
            



            xrKoliIciAdet.Text= koliIciAdet.ToString();
            xrUrun.Text= cariAdi.ToString();
            xrUrunAdi.Text= stokAdi.ToString();
            xrUrTarihi.Text = uretimTarihi.ToString("dd.MM.yyyy");
            xrSkt.Text = SonKT.ToString("dd.MM.yyyy");

            xrBarCode1.Text = barkod.ToString();

            

        }

    }
}

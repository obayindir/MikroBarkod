using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports;
using System.Drawing.Printing;
using DevExpress.DocumentView;
using System.IO;


namespace MikroBarkod
{
    public partial class FrmTarihSecim : DevExpress.XtraEditors.XtraForm
    {
        string cari;
        string stok;
        int koli;
        string barkodu;
        

        public FrmTarihSecim(string cariAdi,string stokAdi,int KoliIciAdet,string barkod)
        {
            InitializeComponent();
            cari = cariAdi;
            stok = stokAdi;
            koli=KoliIciAdet;
            barkodu = barkod;
        }
        private void btnBarkodBas_Click(object sender, EventArgs e)
        {
            RprBarkodDizayn rprBarkodDizayn = new RprBarkodDizayn(cari, stok, koli, dateUretimTarihi.DateTime, dateSKT.DateTime, barkodu);


            using (ReportPrintTool printTool = new ReportPrintTool(rprBarkodDizayn))
            {
                printTool.ShowPreviewDialog();
            }






        }

        private void FrmTarihSecim_Load(object sender, EventArgs e)
        {
            DateTime simdikiTarih= DateTime.Now;
            dateUretimTarihi.DateTime = simdikiTarih;
            dateSKT.DateTime=simdikiTarih.AddYears(1);

        }

        
    }
}
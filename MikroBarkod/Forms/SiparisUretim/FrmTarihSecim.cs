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
using MikroBarkod.code39;

namespace MikroBarkod
{
    public partial class FrmTarihSecim : DevExpress.XtraEditors.XtraForm
    {
        string _cari;
        string _stok;
        string _barkodu;
        string barkodMiktar;
        int _miktar;
      

        public FrmTarihSecim(string cariAdi,string stokAdi,int miktar,string barkod)
        {
            InitializeComponent();
            _cari = cariAdi;
            _miktar = miktar;
            _stok = stokAdi;
            _barkodu = barkod;



        }
        private void btnBarkodBas_Click(object sender, EventArgs e)
        {
            //RprBarkodDizayn rprBarkodDizayn = new RprBarkodDizayn(cari, stok, koli, dateUretimTarihi.DateTime, dateSKT.DateTime, barkodu);

            //using (ReportPrintTool printTool = new ReportPrintTool(rprBarkodDizayn))
            //{8
            //    printTool.ShowPreviewDialog();
            //}
           

            if (spnAdet.Text.Length == 8)
            {
                barkodMiktar = spnAdet.Text;
            }
            else
            {
                string spn = spnAdet.Text.PadLeft(8, '0');
                barkodMiktar=spn;
            }
            

            string code39Barcode = $"{_barkodu}{barkodMiktar}";


            Code39Barcode rprBarkodDizayn = new Code39Barcode(_cari, _stok, Convert.ToInt32(spnAdet.Text), dateUretimTarihi.DateTime,
                dateSKT.DateTime, code39Barcode);

            using (ReportPrintTool printTool = new ReportPrintTool(rprBarkodDizayn))
            {
                printTool.ShowPreviewDialog();
            }






        }

        private void FrmTarihSecim_Load(object sender, EventArgs e)
        {
            DateTime simdikiTarih= DateTime.Now;
            dateUretimTarihi.DateTime = simdikiTarih;
            spnAdet.EditValue = _miktar;
            dateSKT.DateTime=simdikiTarih.AddYears(1);

        }

        
    }
}
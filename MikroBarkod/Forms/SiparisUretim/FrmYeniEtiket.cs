﻿using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MikroBarkod.code39;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod
{
    public partial class FrmYeniEtiket : DevExpress.XtraEditors.XtraForm
    {
        string _barkodu;
        string barkodMiktar;
        public FrmYeniEtiket()
        {
            InitializeComponent();
        }

        private void btnStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var form = new FrmStokList())
            {
                if (form.ShowDialog()==DialogResult.OK)
                {
                    btnStokKodu.Text=form.SelectedData.stoKod.ToString();
                    txtStokAdi.Text=form.SelectedData.stoIsim.ToString();
                    txtBarkod.Text=form.SelectedData.stoBarkod.ToString();
                }

            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            //RprBarkodDizayn rprBarkodDizayn = new RprBarkodDizayn("", txtStokAdi.Text, 0, dateUretimTarihi.DateTime, dateSKT.DateTime, txtBarkod.Text);

            if (spnAdet.Text.Length == 8)
            {
                barkodMiktar = spnAdet.Text;
            }
            else
            {
                string spn = spnAdet.Text.PadLeft(8, '0');
                barkodMiktar = spn;
            }

            string code39Barcode = $"{txtBarkod.Text}{barkodMiktar}";


            Code39Barcode rprBarkodDizayn = new Code39Barcode("", txtStokAdi.Text, Convert.ToInt32(spnAdet.Text), dateUretimTarihi.DateTime,
                dateSKT.DateTime, code39Barcode);


           


            using (ReportPrintTool printTool = new ReportPrintTool(rprBarkodDizayn))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void FrmYeniEtiket_Load(object sender, EventArgs e)
        {
            DateTime simdikiTarih=DateTime.Now;
            dateUretimTarihi.DateTime = simdikiTarih;
            dateSKT.DateTime = simdikiTarih.AddYears(1);


            this.KeyPreview = true;
        }

        private void FrmYeniEtiket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
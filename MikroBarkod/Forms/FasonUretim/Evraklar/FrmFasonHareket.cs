using DevExpress.Data;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using MikroBarkod.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod.Forms.Evraklar
{
    public partial class FrmFasonHareket : DevExpress.XtraEditors.XtraForm
    {
        StokHareketleriRepository repository = new StokHareketleriRepository();
        public FrmFasonHareket()
        {
            InitializeComponent();
            dateIlkTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            dateSonTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Tahoma", 11); // Yeni yazı tipi ve boyut
            gridView1.Appearance.Row.Font = newFont; // Satırlar için
            gridView1.Appearance.HeaderPanel.Font = newFont; // Sütun başlıkları için
            gridView1.Appearance.GroupRow.Font = newFont; // Grup satırları için
            gridView1.Appearance.FocusedRow.Font = newFont; // Odaklanmış satırlar için
            gridView1.Appearance.GroupFooter.Font = newFont; // Grup altbilgileri için
            gridView1.Appearance.FooterPanel.Font = newFont; // Altbilgi paneli için
            gridControl1.DataSource = repository.GetAllFasonHareketleri(dateIlkTarih.DateTime, dateSonTarih.DateTime);

            gridView1.BestFitColumns();



        }

        private void FrmFasonHareketFoyu_Load(object sender, EventArgs e)
        {
            dateIlkTarih.DateTime = DateTime.Now;
            dateSonTarih.DateTime = DateTime.Now;



        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && gridView1.GetFocusedRowCellValue(TİPİ).ToString() == "Çıkış")
            {
                FrmFasonaCikis frmFasonCikis = new FrmFasonaCikis(gridView1.GetFocusedRowCellValue(SERI_NO).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(SIRA_NO)));
                frmFasonCikis.ShowDialog();
            }

            if (view != null && view.FocusedRowHandle >= 0 && gridView1.GetFocusedRowCellValue(TİPİ).ToString() == "Giriş")
            {
                FrmFasondanGiris frmFasonGiris = new FrmFasondanGiris(gridView1.GetFocusedRowCellValue(SERI_NO).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(SIRA_NO)));
                frmFasonGiris.ShowDialog();
            }
        }



        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;

           
            if (info.GroupText.Contains("KALAN SİPARİŞ MİKTARI") == false && info != null && view.GetRowLevel(e.RowHandle) == 1)
            {
                
                decimal total = 0;
                decimal toplamSiparis = 0;
                decimal uretilenMiktar = 0;

                int childRowCount = view.GetChildRowCount(e.RowHandle);
                string urMik = @"msg_S_0080\T";

               
                for (int i = 0; i < childRowCount; i++)
                {
                    int childRowHandle = view.GetChildRowHandle(e.RowHandle, i);
                    uretilenMiktar = uretilenMiktar + Convert.ToDecimal(view.GetRowCellValue(childRowHandle, urMik));
                    toplamSiparis = toplamSiparis + Convert.ToDecimal(view.GetRowCellValue(childRowHandle, "TOPLAM_SİPARİŞ"));
                   
                }

                total = toplamSiparis - uretilenMiktar;
                info.GroupText = info.GroupText + $"<b><u><color=red> ~ KALAN SİPARİŞ MİKTARI #{total.ToString("N0")}#</color></u></b>";
            }


           



        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"FasonHareketleri_{DateTime.Now.Date.ToString("yyyyMMdd")}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.ExportToXlsx(saveFileDialog.FileName, new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });

                        MessageBox.Show("Excel dosyası başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                string sthSpecial2Value = view.GetRowCellValue(e.RowHandle, "msg_S_0077") as string;

                if (sthSpecial2Value == "Giriş")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
                if (sthSpecial2Value == "Çıkış")
                {
                    e.Appearance.BackColor = Color.PaleVioletRed;
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.ShowCustomization();
        }
    }
}
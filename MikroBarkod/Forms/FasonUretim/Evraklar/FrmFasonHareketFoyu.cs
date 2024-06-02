using DevExpress.Export;
using DevExpress.XtraEditors;
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
    public partial class FrmFasonHareketFoyu : DevExpress.XtraEditors.XtraForm
    {
        StokHareketleriRepository repository = new StokHareketleriRepository();
        public FrmFasonHareketFoyu()
        {
            InitializeComponent();
            dateIlkTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            dateSonTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = repository.GetAllFasonHareketleri(dateIlkTarih.DateTime, dateSonTarih.DateTime);
            //gridView1.BestFitColumns();
            
            
           
        }

        private void FrmFasonHareketFoyu_Load(object sender, EventArgs e)
        {
            dateIlkTarih.DateTime = DateTime.Now;
            dateSonTarih.DateTime = DateTime.Now;
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && gridView1.GetFocusedRowCellValue(SERI_NO).ToString() == "FC")
            {
                FrmFasonaCikis frmFasonCikis = new FrmFasonaCikis(gridView1.GetFocusedRowCellValue(SERI_NO).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(SIRA_NO)));
                frmFasonCikis.ShowDialog();
            }

            if (view != null && view.FocusedRowHandle >= 0 && gridView1.GetFocusedRowCellValue(SERI_NO).ToString() == "FG")
            {
                FrmFasondanGiris frmFasonGiris = new FrmFasondanGiris(gridView1.GetFocusedRowCellValue(SERI_NO).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(SIRA_NO)));
                frmFasonGiris.ShowDialog();
            }
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            
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
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MikroBarkod.Entities.Repositories;
using DevExpress.Data;
using DevExpress.Export;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MikroBarkod.Forms.Prim
{
    public partial class FrmPrimAnaEkran : DevExpress.XtraEditors.XtraForm
    {
        PrimRepository primRepository = new PrimRepository();
        public FrmPrimAnaEkran()
        {
            InitializeComponent();
            
            lookupPlasiyer.Properties.DataSource = primRepository.GetCariPersoneller();
            lookupPlasiyer.Properties.DisplayMember = "cari_per_adi";
            lookupPlasiyer.Properties.ValueMember = "cari_per_kod";
            
        }
        void loadGrids()
        {

            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {

                grid1Doldur();

            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }


        }

        void grid1Doldur()
        {
            try
            {
                gridControl1.DataSource = primRepository.GetPrimReportAsync(lookupPlasiyer.EditValue.ToString(), dateIlkTarih.DateTime, dateSonTarih.DateTime);

                gridView1.Columns["Temsilci_Kodu"].Caption = "Plasiyer";
                gridView1.Columns["Temsilci_Adi"].Visible = true;
                //gridView1.Columns["Proje_Prim_Orani"].Visible = false;
                gridView1.Columns["Plasiyer_Kodu"].Visible = false;
                gridView1.Columns["Temsilci_Kodu"].Visible = false;
                gridView1.Columns["Toplam_Satis_Kumule"].Visible = false;
                gridView1.Columns["Kumule_Prim"].Visible = false;
                gridView1.Columns["sth_special2"].Visible = false;
                //gridView1.Columns["Cari_Kod"].Visible = false;
                gridView1.Columns["cha_Guid"].Visible = false;
                //gridView1.Columns["Stok_Prim_Orani"].Visible = false;

                gridView1.Columns["sth_Guid"].Visible = false;


                GridColumn faturaMeblagColumn = gridView1.Columns["Fatura_Meblag"];
                faturaMeblagColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                faturaMeblagColumn.DisplayFormat.FormatString = "N2";

                GridColumn kapananTutarColumn = gridView1.Columns["Kapanan_Tutar"];
                kapananTutarColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                kapananTutarColumn.DisplayFormat.FormatString = "N2";

                GridColumn kapananYuzde = gridView1.Columns["Kapanan_Yuzde"];
                kapananYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                kapananYuzde.DisplayFormat.FormatString = "N";

                GridColumn fullPrimColumn = gridView1.Columns["Full_Prim"];
                fullPrimColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                fullPrimColumn.DisplayFormat.FormatString = "N2";


                GridColumn kazanilanPrimColumn = gridView1.Columns["Kazanilan_Prim"];
                kazanilanPrimColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                kazanilanPrimColumn.DisplayFormat.FormatString = "N2";

                GridColumn kumulePrimColumn = gridView1.Columns["Kumule_Prim"];
                kumulePrimColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                kumulePrimColumn.DisplayFormat.FormatString = "N2";

                GridColumn Toplam_Satis_KumuleColumn = gridView1.Columns["Toplam_Satis_Kumule"];
                Toplam_Satis_KumuleColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                Toplam_Satis_KumuleColumn.DisplayFormat.FormatString = "N2";

                GridColumn Tutar_TLColumn = gridView1.Columns["Tutar_TL"];
                Tutar_TLColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                Tutar_TLColumn.DisplayFormat.FormatString = "N2";


                GridColumn dateColumn = gridView1.Columns["Fatura_Tarihi"]; // Tarih sütununun adını buraya yazın
                                                                            //GridColumn chaGuid = gridView1.Columns["cha_Guid"];//cha guid alanı

                dateColumn.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
                dateColumn.DisplayFormat.FormatString = "yyyy-MM"; // Grup başlıklarında tarih formatını ay ve yıl olarak ayarlar
                dateColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

                gridView1.BeginSort();

                try
                {
                    dateColumn.GroupIndex = 0; // Gruplama sırasını 0 olarak ayarlar
                                               //chaGuid.GroupIndex = 1;

                    dateColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending; // Grupları tersten sırala
                                                                                       //gridView1.OptionsView.ShowGroupPanel = false;
                    gridView1.OptionsView.ShowGroupPanel = true;
                    gridView1.BestFitColumns();
                }
                finally
                {
                    gridView1.EndSort();
                }

                //gridView1.ExpandAllGroups();
                gridView1.OptionsView.ShowAutoFilterRow = true;


                gridView1.OptionsView.ColumnAutoWidth = false;
                gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
                gridView1.GroupSummary.Clear();
                GridGroupSummaryItem summaryItemValue = new GridGroupSummaryItem();
                GridGroupSummaryItem summaryItemValue2 = new GridGroupSummaryItem();




                summaryItemValue.FieldName = "Tutar_TL";
                summaryItemValue2.FieldName = "Kazanilan_Prim";

                summaryItemValue.ShowInGroupColumnFooter = gridView1.Columns["Tutar_TL"];
                summaryItemValue2.ShowInGroupColumnFooter = gridView1.Columns["Kazanilan_Prim"];
                summaryItemValue.SummaryType = SummaryItemType.Sum;
                summaryItemValue2.SummaryType = SummaryItemType.Sum;
                summaryItemValue.DisplayFormat = "{0:N2}";
                summaryItemValue2.DisplayFormat = "{0:N2}";
                gridView1.GroupSummary.Add(summaryItemValue);
                gridView1.GroupSummary.Add(summaryItemValue2);

            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private async void btnOdemeIptal_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Lütfen ödeme iptali yapmak istediğiniz satırları seçin.", "Seçili Satır Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                if (gridView1.IsGroupRow(rowHandle))
                    continue;
                Guid sthGuid = (Guid)gridView1.GetRowCellValue(rowHandle, "sth_Guid");
                await primRepository.UpdateSthSpecial2Async(sthGuid,0);
            }
            loadGrids();
        }

        private async void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Lütfen ödeme yapmak istediğiniz satırları seçin.", "Seçili Satır Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                if (gridView1.IsGroupRow(rowHandle))
                    continue;
                Guid sthGuid = (Guid)gridView1.GetRowCellValue(rowHandle, "sth_Guid");
                await primRepository.UpdateSthSpecial2Async(sthGuid,1);


            }
            loadGrids();
        }

        private void UpdateTotalAmountLabel()
        {
            // Seçilen satırların toplamını hesaplayın ve Label'a yazdırın
            decimal totalAmount = 0;

            foreach (int selectedRowHandle in gridView1.GetSelectedRows())
            {
                object amountValue = gridView1.GetRowCellValue(selectedRowHandle, "Kazanilan_Prim");
                if (amountValue != DBNull.Value && amountValue != null)
                {
                    totalAmount += Convert.ToDecimal(amountValue);
                }

            }

            labelTotalAmount.Text = "*" + totalAmount.ToString("N2");
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "grid_export.xlsx";

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

        private void FrmPrimAnaEkran_Load(object sender, EventArgs e)
        {
            if (File.Exists("layout.xml"))
            {
                gridView1.RestoreLayoutFromXml("layout.xml");
            }
        }

        private void btnGoruntuAyarlariniKaydet_Click(object sender, EventArgs e)
        {
            gridView1.SaveLayoutToXml("layout.xml");
            XtraMessageBox.Show("Görünüm kaydedildi");
        }

        private void gridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labelTotalAmount.Visible = true;

            UpdateTotalAmountLabel();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0 || e.Column.FieldName != "Kapanan_Yuzde") return;

            var cellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column.FieldName);
            if (cellValue == null || cellValue == DBNull.Value) return;

            decimal sthSpecial2Value;
            if (!decimal.TryParse(cellValue.ToString(), out sthSpecial2Value)) return;

            if (sthSpecial2Value >= 99)
            {
                e.Appearance.ForeColor = Color.Green;
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                string sthSpecial2Value = view.GetRowCellValue(e.RowHandle, "sth_special2") as string;

                if (sthSpecial2Value == "1")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }


            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                gridView1.ShowCustomization();
            }
            else
            {
                gridView1.HideCustomization();
            }
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;

            if (info != null)
            {
                // Belirli bir grup indeksine sahip grupları kontrol etmek
                if (view.GetRowLevel(e.RowHandle) == 1)
                {
                    info.GroupText = ""; // Belirli bir grup indeksine sahip gruplar için hiçbir şey gösterme
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loadGrids();
        }
    }
}

using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MikroBarkod
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {

        public FrmMain()
        {
            InitializeComponent();


        }





        private void FrmMain_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
            this.KeyPreview = true;

        }

        void comboboxDoldur()
        {
            // Dosya yolu
            string dosyaYolu = Path.Combine(Application.StartupPath, "years.txt");

            // Eğer dosya varsa
            if (File.Exists(dosyaYolu))
            {
                // Dosyadan yılları oku
                List<int> years = new List<int>();
                foreach (string line in File.ReadLines(dosyaYolu))
                {
                    if (int.TryParse(line, out int year))
                    {
                        years.Add(year);
                    }
                }

                // ComboBox'ı doldur
                comboBoxYears.DataSource = years;
            }
            else
            {
                MessageBox.Show("years.txt dosyası bulunamadı.");
            }
        }

        void gridAyarlari()
        {
            gridView1.BestFitColumns();
            //gridView1.Columns["SERİ"].Width = 50;
            gridView1.Columns["SIRA"].Width = 70;
            gridView1.Columns["BARKODU"].Width = 100;
            gridView1.Columns["CARİ İSMİ"].Width = 140;
            gridView1.Columns["A/K"].Width = 30;

            gridView1.Columns["MİKTAR"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["MİKTAR"].DisplayFormat.FormatString = "N0";
           
   
            gridView1.Columns["KALAN MİKTAR"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["KALAN MİKTAR"].DisplayFormat.FormatString = "N0";

            GridView gridView = gridView1;
            foreach (GridColumn column in gridView.Columns)
            {
                column.AppearanceHeader.BackColor = System.Drawing.Color.AliceBlue; // Tüm kolon başlıklarının arka plan rengini ayarla
            }
            //gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.AliceBlue;
            //GridColumn koliColumn = gridView1.Columns["KOLİ İÇİ ADET"];
            //koliColumn.AppearanceCell.BackColor = Color.LightYellow;
            //gridView.Columns["EVRAK SERİ"].GroupIndex = 0;
            //gridView.Columns["EVRAK SIRA"].GroupIndex = 0;

            gridView1.Columns["MİKTAR"].AppearanceCell.BackColor = Color.LightBlue;
            gridView.ExpandAllGroups();
            
        }


        void gridAyarlariview2()
        {
            gridView2.BestFitColumns();
            //gridView1.Columns["SERİ"].Width = 50;
            gridView2.Columns["SIRA"].Width = 70;
            gridView2.Columns["BARKODU"].Width = 100;
            gridView2.Columns["CARİ İSMİ"].Width = 140;
            gridView2.Columns["A/K"].Width = 30;

            gridView2.Columns["MİKTAR"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView2.Columns["MİKTAR"].DisplayFormat.FormatString = "N0";


            gridView2.Columns["KALAN MİKTAR"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView2.Columns["KALAN MİKTAR"].DisplayFormat.FormatString = "N0";

            GridView gridView = gridView2;
            foreach (GridColumn column in gridView.Columns)
            {
                column.AppearanceHeader.BackColor = System.Drawing.Color.AliceBlue; // Tüm kolon başlıklarının arka plan rengini ayarla
            }
            //gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.AliceBlue;
            //GridColumn koliColumn = gridView1.Columns["KOLİ İÇİ ADET"];
            //koliColumn.AppearanceCell.BackColor = Color.LightYellow;
            //gridView.Columns["EVRAK SERİ"].GroupIndex = 0;
            //gridView.Columns["EVRAK SIRA"].GroupIndex = 0;

            gridView2.Columns["MİKTAR"].AppearanceCell.BackColor = Color.LightBlue;
            gridView.ExpandAllGroups();

        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            ShowWaitForm();
            gridYukle();
            gridYukleView2();
            CloseWaitForm();

        }

        void ShowWaitForm()
        {
            // SplashScreenManager ile WaitForm'u göster
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
        }

        void CloseWaitForm()
        {
            // SplashScreenManager ile WaitForm'u kapat
            SplashScreenManager.CloseForm(false);
        }
        void gridYukle()
        {
            SqlBaglanti bgl = new SqlBaglanti();

            string dizin = AppDomain.CurrentDomain.BaseDirectory;

            string dosyaYolu = Path.Combine(dizin, "command.txt");

            string sqlSorgusu = File.ReadAllText(dosyaYolu);


            using (SqlCommand comand = new SqlCommand(sqlSorgusu, bgl.baglan()))
            {
                comand.Parameters.AddWithValue("@param1", comboBoxYears.Text);
                // SqlDataAdapter ve DataTable oluşturun
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
                DataTable dataTable = new DataTable();

                // DataTable'ı doldurun
                dataAdapter.Fill(dataTable);

                // DataTable'ı eğer UI thread'inden ulaşılmak üzere iş parçacığına post et
                Invoke(new MethodInvoker(delegate
                {
                    gridControl1.DataSource = dataTable;
                }));
            }
            gridAyarlari();


        }

        void gridYukleView2()
        {
            SqlBaglanti bgl = new SqlBaglanti();

            string dizin = AppDomain.CurrentDomain.BaseDirectory;

            string dosyaYolu = Path.Combine(dizin, "commandView2.txt");

            string sqlSorgusu = File.ReadAllText(dosyaYolu);


            using (SqlCommand comand = new SqlCommand(sqlSorgusu, bgl.baglan()))
            {
                comand.Parameters.AddWithValue("@param1", comboBoxYears.Text);
                // SqlDataAdapter ve DataTable oluşturun
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
                DataTable dataTable = new DataTable();

                // DataTable'ı doldurun
                dataAdapter.Fill(dataTable);

                // DataTable'ı eğer UI thread'inden ulaşılmak üzere iş parçacığına post et
                Invoke(new MethodInvoker(delegate
                {
                    gridControl2.DataSource = dataTable;
                }));
            }
            gridAyarlariview2();


        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }



        private void seciliSatiriYazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Code39EtiketBas();

        }


        public static int CalculateCheckDigit(string barcodeWithoutCheckDigit)
        {
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < barcodeWithoutCheckDigit.Length; i++)
            {
                // Karakterin sayı olup olmadığını kontrol et
                if (char.IsDigit(barcodeWithoutCheckDigit[i]))
                {
                    int digit = int.Parse(barcodeWithoutCheckDigit[i].ToString());

                    if ((i + 1) % 2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }
                }
            }

            // Çift basamakların iki katını al ve topla
            int total = (sumOdd * 3) + sumEven;

            // Kontrol basamağını hesapla
            int checkDigit = 10 - (total % 10);
            if (checkDigit == 10)
            {
                checkDigit = 0;
            }

            return checkDigit;
        }

        

        void Code39EtiketBas()
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle >= 0)
            {

                int selectedRowHandle = gridView1.FocusedRowHandle;


                string cariAdi = gridView1.GetRowCellValue(selectedRowHandle, "CARİ İSMİ").ToString();
                string stokAdi = gridView1.GetRowCellValue(selectedRowHandle, "STOK İSMİ").ToString();
                string gridBarkodu = gridView1.GetRowCellValue(selectedRowHandle, "BARKODU").ToString();
                decimal gridMiktar = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "MİKTAR"));

                string barcodeValue = gridBarkodu;

                FrmTarihSecim frmTarihSecim = new FrmTarihSecim(cariAdi, stokAdi, (int)gridMiktar, barcodeValue);
                DialogResult result = frmTarihSecim.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Code39EtiketBas();
           
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "TAMAMLANAN MİKTAR" && e.CellValue != null && Convert.ToDouble(e.CellValue) > 0)
            {
                e.Appearance.BackColor = System.Drawing.Color.LightGreen; // Yeşil renk
                //e.Appearance.ForeColor = System.Drawing.Color.White; // Beyaz renkte metin örneği
            }
            if (e.Column.FieldName == "KALAN MİKTAR" && e.CellValue != null && Convert.ToDouble(e.CellValue) > 0)
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {


        }

        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        }

        private void yeniEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniEtiket frmYeniEtiket = new FrmYeniEtiket();
            frmYeniEtiket.ShowDialog();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                FrmYeniEtiket frmYeniEtiket = new FrmYeniEtiket();
                frmYeniEtiket.ShowDialog();
            }
        }

        private void yeniEtiketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmYeniEtiket frmYeniEtiket = new FrmYeniEtiket();
            frmYeniEtiket.ShowDialog();

        }

        private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            
            if (e.Column.FieldName == "TAMAMLANAN MİKTAR" && e.CellValue != null && Convert.ToDouble(e.CellValue) > 0)
            {
                e.Appearance.BackColor = System.Drawing.Color.LightGreen; // Yeşil renk
                //e.Appearance.ForeColor = System.Drawing.Color.White; // Beyaz renkte metin örneği
            }

            if (e.Column.FieldName == "KALAN MİKTAR" && e.CellValue != null && Convert.ToDouble(e.CellValue) > 0)
            {
                e.Appearance.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
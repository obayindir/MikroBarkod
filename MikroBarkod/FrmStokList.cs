using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
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

namespace MikroBarkod
{
    public partial class FrmStokList : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public SelectedDataModel SelectedData { get; private set; }
        public FrmStokList()
        {
            InitializeComponent();
        }

        public class SelectedDataModel
        {
            public string stoKod { get; set; }
            public string stoIsim { get; set; }
            public string stoBarkod { get; set; }

        }

        void loadData()
        {
            string query = "SELECT sto_kod,sto_isim,bar_kodu from STOKLAR LEFT OUTER JOIN BARKOD_TANIMLARI BT ON BT.bar_stokkodu=sto_kod where BT.bar_kodu IS NOT NULL";


            try
            {

                bgl.baglan();
                SqlCommand command = new SqlCommand(query, bgl.baglan());

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                gridControl1.DataSource = dataTable;
                bgl.bglkapat();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                SelectedData = new SelectedDataModel
                {
                    stoKod = gridView1.GetFocusedRowCellValue("sto_kod").ToString(),
                    stoIsim = gridView1.GetFocusedRowCellValue("sto_isim").ToString(),
                    stoBarkod = gridView1.GetFocusedRowCellValue("bar_kodu").ToString()

                };
                Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedData = new SelectedDataModel
            {
                stoKod = gridView1.GetFocusedRowCellValue("sto_kod").ToString(),
                stoIsim = gridView1.GetFocusedRowCellValue("sto_isim").ToString(),
                stoBarkod = gridView1.GetFocusedRowCellValue("bar_kodu").ToString()

            };

            Close();
        }

        private void FrmStokList_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
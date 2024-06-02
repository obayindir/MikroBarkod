using DevExpress.XtraEditors;
using MikroBarkod.Entities.Repositories;
using MikroBarkod.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod.Forms.SecimEkranlari
{
    public partial class FrmCariSecim : DevExpress.XtraEditors.XtraForm
    {
        CariRepository cariRepository= new CariRepository();
        public CARI_HESAPLAR secilenCari { get; private set; }
        public event EventHandler CariSecildi;
        public FrmCariSecim()
        {
            InitializeComponent();
            gridControl1.DataSource = cariRepository.GetAllCari();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && e.Column != null)
            {
                e.Appearance.BackColor = Color.LightYellow;
                e.Appearance.Options.UseBackColor = true;
            }
        }
        void SecimIslemi()
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                secilenCari = new CARI_HESAPLAR
                {
                    cari_kod = gridView1.GetRowCellValue(selectedRowHandle, "cari_kod").ToString(),
                    cari_unvan1 = gridView1.GetRowCellValue(selectedRowHandle, "cari_unvan1").ToString(),


                };
                CariSecildi?.Invoke(this, EventArgs.Empty);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SecimIslemi();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SecimIslemi();
            }
        }

        private void FrmCariSecim_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FrmCariSecim_Load(object sender, EventArgs e)
        {
            
        }
    }
}
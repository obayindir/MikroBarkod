
using MikroBarkod.Entities.Repositories;
using MikroBarkod.Entities.Tables;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MikroBarkod.Forms
{
    public partial class FrmStokSecim : DevExpress.XtraEditors.XtraForm
    {
        StokRepository stokRepository = new StokRepository();
        public STOKLAR SecilenStok { get; private set; }
        public event EventHandler StokSecildi;
        public FrmStokSecim()
        {
            InitializeComponent();
            gridControl1.DataSource = stokRepository.GetStoklar();

        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                SecilenStok = new STOKLAR
                {
                    sto_isim = gridView1.GetRowCellValue(selectedRowHandle, "sto_isim").ToString(),
                    sto_kod = gridView1.GetRowCellValue(selectedRowHandle, "sto_kod").ToString(),
                    

                };
                StokSecildi?.Invoke(this, EventArgs.Empty);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && e.Column != null)
            {
                e.Appearance.BackColor = Color.LightYellow;
                e.Appearance.Options.UseBackColor = true;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int selectedRowHandle = gridView1.FocusedRowHandle;
                if (selectedRowHandle >= 0)
                {
                    SecilenStok = new STOKLAR
                    {
                        sto_isim = gridView1.GetRowCellValue(selectedRowHandle, "sto_isim").ToString(),
                        sto_kod = gridView1.GetRowCellValue(selectedRowHandle, "sto_kod").ToString(),


                    };
                    StokSecildi?.Invoke(this, EventArgs.Empty);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }


}
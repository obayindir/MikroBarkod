using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MikroBarkod.Entities;
using MikroBarkod.Entities.Repositories;
using MikroBarkod.Entities.Tables;
using MikroBarkod.Forms.SecimEkranlari;
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
    public partial class FrmFasonaCikis : DevExpress.XtraEditors.XtraForm
    {
        StokHareketleriRepository repository = new StokHareketleriRepository();
        DepoRepository depoRepository = new DepoRepository();
        HareketGrupRepository hareketGrupRepository = new HareketGrupRepository();
        CariRepository cariRepository = new CariRepository();
        StokRepository stokRepository = new StokRepository();
        private List<FasonGrid> degisenKayitlar = new List<FasonGrid>();
        private List<FasonGrid> silinenKayitlar = new List<FasonGrid>();
        private string _evrakTip = "0";
        public BindingList<FasonGrid> grid = new BindingList<FasonGrid>();
       

        STOK_HAREKETLERI _sth = new STOK_HAREKETLERI();

        public FrmFasonaCikis()
        {
            InitializeComponent();
            gridControl1.DataSource = grid;
            //SİRA NO ALANI
            btnSira.Text = SonEvrakSiraNoBul(txtSeri.Text).ToString();
            dateEvrakTarihi.DateTime = DateTime.Now;
            dateTeslimTarihi.DateTime = DateTime.Now;
            dateHedefSure.DateTime = DateTime.Now;

        }

        public FrmFasonaCikis(string evrakSeri,int evrakSira)
        {
            InitializeComponent();
            gridControl1.DataSource = grid;

            if (repository.CheckKayitVarmi(evrakSeri, evrakSira, "0"))
            {
                STOK_HAREKETLERI ss = repository.GetSthSeriSira(evrakSeri, evrakSira, "0");
                btnSira.Text=evrakSira.ToString();
                dateEvrakTarihi.DateTime = ss.sth_tarih.HasValue ? ss.sth_tarih.Value : DateTime.Now;

                spnToplamTalep.EditValue = ss.sth_Olcu1.HasValue ? ss.sth_Olcu1.Value : 0;

                btnFasoncuKodu.Text = !string.IsNullOrEmpty(ss.sth_cari_kodu) ? ss.sth_cari_kodu : string.Empty;


                dateTeslimTarihi.DateTime = ss.sth_teslim_tarihi.HasValue ? ss.sth_teslim_tarihi.Value : DateTime.Now;
                dateHedefSure.DateTime = ss.sth_belge_tarih.HasValue ? ss.sth_belge_tarih.Value : DateTime.Now;
                grid.Clear();
                List<STOK_HAREKETLERI> gridItem = (List<STOK_HAREKETLERI>)repository.GetAllSthWSeriSira(evrakSeri, evrakSira, "0");


                foreach (STOK_HAREKETLERI item in gridItem)
                {
                    gridView1.AddNewRow();
                    int newRowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                    //int newRowHandle = Convert.ToInt32(item.tkl_satirno);
                    gridView1.SetRowCellValue(newRowHandle, sth_Guid, item.sth_Guid.ToString());
                    gridView1.SetRowCellValue(newRowHandle, sth_stok_kod, item.sth_stok_kod);
                    gridView1.SetRowCellValue(newRowHandle, sth_miktar, item.sth_miktar);
                    gridView1.SetRowCellValue(newRowHandle, sth_HareketGrupKodu1, item.sth_HareketGrupKodu1);
                    gridView1.SetRowCellValue(newRowHandle, depo_no, item.sth_cikis_depo_no);
                    gridView1.SetRowCellValue(newRowHandle, sth_aciklama, item.sth_aciklama);
                }
            }

        }

        private void btnFasoncuKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FrmCariSecim frmCariSecim = new FrmCariSecim())
            {
                if (frmCariSecim.ShowDialog() == DialogResult.OK)
                {
                    btnFasoncuKodu.Text = frmCariSecim.secilenCari.cari_kod;
                    btnFasoncuAdi.Text = frmCariSecim.secilenCari.cari_unvan1;
                }

            }
        }
        private void btnFasoncuAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FrmCariSecim frmCariSecim = new FrmCariSecim())
            {
                if (frmCariSecim.ShowDialog() == DialogResult.OK)
                {
                    btnFasoncuKodu.Text = frmCariSecim.secilenCari.cari_kod;
                    btnFasoncuAdi.Text = frmCariSecim.secilenCari.cari_unvan1;
                }

            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı kaydetmek istediğinizden emin misiniz?", "Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EvrakKayit();
                this.Close();
            }
        }
        private int SonEvrakSiraNoBul(string seri)
        {
            var sonEvrak = repository.GetSthSonSiraNo(txtSeri.Text, _evrakTip);
            if (sonEvrak != null)
            {
                return sonEvrak + 1;
            }
            else { return 1; }
        }

        private void txtSeri_Leave(object sender, EventArgs e)
        {

        }

        private void repoBtnStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var frmStokSec = new FrmStokSecim())
            {
                if (frmStokSec.ShowDialog() == DialogResult.OK)
                {
                    STOKLAR secilenStok = frmStokSec.SecilenStok;
                    int focusedRowHandle = gridView1.FocusedRowHandle;
                    object tklStokKodValue = gridView1.GetRowCellValue(focusedRowHandle, "sth_stok_kod");

                    if (!string.IsNullOrEmpty(tklStokKodValue as string))
                    {
                        // Mevcut satırı güncelle
                        //gridView1.SetRowCellValue(focusedRowHandle, "sto_isim", secilenStok.sto_isim);
                        gridView1.SetRowCellValue(focusedRowHandle, "sth_stok_kod", secilenStok.sto_kod);
                    }
                    else
                    {
                        // Yeni bir satır ekleyin
                        gridView1.AddNewRow();
                        focusedRowHandle = gridView1.FocusedRowHandle; // Yeni satırın indeksini al
                        //gridView1.SetRowCellValue(focusedRowHandle, "sto_isim", secilenStok.sto_isim);
                        gridView1.SetRowCellValue(focusedRowHandle, "sth_stok_kod", secilenStok.sto_kod);
                    }
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "sth_stok_kod")
            {
                string stokKodu = view.GetRowCellValue(e.RowHandle, e.Column).ToString();
                //var dt = _context.STOKLAR.FirstOrDefault(x=>x.sto_kod == stokKodu);
                var dt = stokRepository.GetStoklarByKod(stokKodu);

                if (dt != null)
                {
                    view.SetRowCellValue(e.RowHandle, "sto_isim", dt.sto_isim);
                    view.SetRowCellValue(e.RowHandle, "sto_birim1_ad", dt.sto_birim1_ad);
                    view.SetRowCellValue(e.RowHandle, "depo_no", 1);
                }


            }
            if (e.RowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle )
            {
                FasonGrid row = view.GetRow(e.RowHandle) as FasonGrid;
                if (!degisenKayitlar.Contains(row))
                {
                    degisenKayitlar.Add(row);
                }
            }
        }

        private void FrmFasonaCikis_Load(object sender, EventArgs e)
        {
            btnFasoncuKodu.Focus();

            this.KeyPreview = true;
            this.KeyDown += btnKaydet_KeyDown;
            this.KeyDown += btnSatirSil_KeyDown;

            //tarih dateedit ayarı
            dateEvrakTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            dateHedefSure.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            dateTeslimTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;

            //gridde ki depo no larını doldur
            repoLookUpDepolar.DisplayMember = "dep_adi";
            repoLookUpDepolar.ValueMember = "dep_no";
            repoLookUpDepolar.DataSource = depoRepository.GetDepo();
            //gridde ki hareket grup kodlarını doldur
            repoLookUpHareketGrupKodu1.DisplayMember = "hg1_isim";
            repoLookUpHareketGrupKodu1.ValueMember = "hg1_kod";
            repoLookUpHareketGrupKodu1.DataSource = hareketGrupRepository.GetHareketGruplari();
            
        }



        private void btnSira_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnSira_Leave(object sender, EventArgs e)
        {
            if (repository.CheckKayitVarmi(txtSeri.Text, Convert.ToInt32(btnSira.Text), _evrakTip))
            {
                STOK_HAREKETLERI ss = repository.GetSthSeriSira(txtSeri.Text, Convert.ToInt32(btnSira.Text), _evrakTip);
                dateEvrakTarihi.DateTime = ss.sth_tarih.HasValue ? ss.sth_tarih.Value : DateTime.Now;

                spnToplamTalep.EditValue = ss.sth_Olcu1.HasValue ? ss.sth_Olcu1.Value : 0;

                btnFasoncuKodu.Text = !string.IsNullOrEmpty(ss.sth_cari_kodu) ? ss.sth_cari_kodu : string.Empty;


                dateTeslimTarihi.DateTime = ss.sth_teslim_tarihi.HasValue ? ss.sth_teslim_tarihi.Value : DateTime.Now;
                dateHedefSure.DateTime = ss.sth_belge_tarih.HasValue ? ss.sth_belge_tarih.Value : DateTime.Now;
                grid.Clear();
                List<STOK_HAREKETLERI> gridItem = (List<STOK_HAREKETLERI>)repository.GetAllSthWSeriSira(txtSeri.Text, Convert.ToInt32(btnSira.Text), _evrakTip);


                foreach (STOK_HAREKETLERI item in gridItem)
                {
                    gridView1.AddNewRow();
                    int newRowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                    //int newRowHandle = Convert.ToInt32(item.tkl_satirno);
                    gridView1.SetRowCellValue(newRowHandle, sth_Guid, item.sth_Guid.ToString());
                    gridView1.SetRowCellValue(newRowHandle, sth_stok_kod, item.sth_stok_kod);
                    gridView1.SetRowCellValue(newRowHandle, sth_miktar, item.sth_miktar);
                    gridView1.SetRowCellValue(newRowHandle, sth_HareketGrupKodu1, item.sth_HareketGrupKodu1);
                    gridView1.SetRowCellValue(newRowHandle, depo_no, item.sth_cikis_depo_no);
                    gridView1.SetRowCellValue(newRowHandle, sth_aciklama, item.sth_aciklama);
                }
            }
        }

        private void btnFasoncuKodu_EditValueChanged(object sender, EventArgs e)
        {
            btnFasoncuAdi.Text = cariRepository.GetCariUnvanByCode(btnFasoncuKodu.Text);
        }
        private void btnKaydet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.S)
            {
                DialogResult result = MessageBox.Show("Kaydı kaydetmek istediğinizden emin misiniz?", "Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EvrakKayit();
                    this.Close();


                }
            }
        }

        private void EvrakKayit()
        {
            try
            {
                if (repository.CheckKayitVarmi(txtSeri.Text, Convert.ToInt32(btnSira.Text), _evrakTip))
                {
                    guncelle();

                }
                else
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        _sth.sth_Guid = Guid.NewGuid();
                        _sth.sth_evrakno_seri = txtSeri.Text;
                        _sth.sth_satirno = i;
                        _sth.sth_evraktip = 0;
                        _sth.sth_tip = 1;
                        _sth.sth_isemri_gider_kodu = "genel";
                        _sth.sth_cins = 8;
                        _sth.sth_Olcu1 = Convert.ToDouble(spnToplamTalep.EditValue);
                        _sth.sth_evrakno_sira = Convert.ToInt32(btnSira.Text);
                        _sth.sth_teslim_tarihi = dateTeslimTarihi.DateTime;
                        _sth.sth_tarih = dateEvrakTarihi.DateTime.Date;
                        _sth.sth_belge_tarih = dateHedefSure.DateTime;
                        _sth.sth_cari_kodu = btnFasoncuKodu.Text;
                        _sth.sth_stok_kod = gridView1.GetRowCellValue(i, sth_stok_kod).ToString();
                        _sth.sth_miktar = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));
                        _sth.sth_miktar2 = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));
                        _sth.sth_cikis_depo_no = Convert.ToInt32(gridView1.GetRowCellValue(i, depo_no));
                        _sth.sth_giris_depo_no = Convert.ToInt32(gridView1.GetRowCellValue(i, depo_no));
                        _sth.sth_HareketGrupKodu1 = gridView1.GetRowCellValue(i, sth_HareketGrupKodu1) != null ? gridView1.GetRowCellValue(i, sth_HareketGrupKodu1).ToString() : "";
                        _sth.sth_aciklama = gridView1.GetRowCellValue(i, sth_aciklama) != null ? gridView1.GetRowCellValue(i, sth_aciklama).ToString() : "";
                        repository.InsertSth(_sth);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }


        private void guncelle()
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                Guid satirGuid = (Guid)gridView1.GetRowCellValue(i, sth_Guid);

                STOK_HAREKETLERI ss = repository.GetSthById(satirGuid);

                foreach (var item in silinenKayitlar)
                {
                    Guid silinenGuid = item.sth_Guid;
                    repository.DeleteSth(silinenGuid);
                }

                if (satirGuid != null && satirGuid.ToString() != "00000000-0000-0000-0000-000000000000")
                {
                    ss.sth_evrakno_seri = txtSeri.Text;
                    ss.sth_evrakno_sira = Convert.ToInt32(btnSira.Text);
                    ss.sth_satirno = i;
                    ss.sth_tarih = dateEvrakTarihi.DateTime.Date;
                    ss.sth_belge_tarih = dateHedefSure.DateTime;
                    ss.sth_teslim_tarihi = dateTeslimTarihi.DateTime;
                    ss.sth_cari_kodu = btnFasoncuKodu.Text;
                    ss.sth_lastup_date = DateTime.Now;
                    ss.sth_Olcu1 = Convert.ToDouble(spnToplamTalep.EditValue);
                    ss.sth_evraktip = 0;
                    ss.sth_tip = 1;
                    ss.sth_cins = 8;
                    ss.sth_isemri_gider_kodu = "genel";

                    ss.sth_stok_kod = gridView1.GetRowCellValue(i, sth_stok_kod).ToString();
                    ss.sth_miktar = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));
                    ss.sth_miktar2 = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));

                    ss.sth_cikis_depo_no = Convert.ToInt32(gridView1.GetRowCellValue(i, depo_no));
                    ss.sth_cikis_depo_no = Convert.ToInt32(gridView1.GetRowCellValue(i, depo_no));
                    ss.sth_HareketGrupKodu1 = gridView1.GetRowCellValue(i, sth_HareketGrupKodu1).ToString();
                    ss.sth_aciklama = gridView1.GetRowCellValue(i, sth_aciklama) != null ? gridView1.GetRowCellValue(i, sth_aciklama).ToString() : "";
                    repository.UpdateSth(ss);

                }
                else if (satirGuid == null || satirGuid.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    _sth.sth_Guid = Guid.NewGuid();
                    _sth.sth_evrakno_seri = txtSeri.Text;
                    _sth.sth_satirno = i;
                    _sth.sth_evrakno_sira = Convert.ToInt32(btnSira.Text);
                    _sth.sth_tarih = dateEvrakTarihi.DateTime.Date;
                    _sth.sth_belge_tarih = dateHedefSure.DateTime;
                    _sth.sth_Olcu1 = Convert.ToDouble(spnToplamTalep.EditValue);
                    _sth.sth_cari_kodu = btnFasoncuKodu.Text;
                    _sth.sth_isemri_gider_kodu = "genel";

                    _sth.sth_teslim_tarihi = dateTeslimTarihi.DateTime;
                    _sth.sth_stok_kod = gridView1.GetRowCellValue(i, sth_stok_kod).ToString();
                    _sth.sth_miktar = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));
                    _sth.sth_miktar2 = Convert.ToInt32(gridView1.GetRowCellValue(i, sth_miktar));
                    _sth.sth_cikis_depo_no = (int)gridView1.GetRowCellValue(i, depo_no);
                    _sth.sth_giris_depo_no = (int)gridView1.GetRowCellValue(i, depo_no);
                    _sth.sth_HareketGrupKodu1 = gridView1.GetRowCellValue(i, sth_HareketGrupKodu1).ToString();
                    _sth.sth_aciklama = gridView1.GetRowCellValue(i, sth_aciklama) != null ? gridView1.GetRowCellValue(i, sth_aciklama).ToString() : "";
                    repository.InsertSth(_sth);
                }

            }
        }


        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            GridView view = sender as GridView;
            FasonGrid row = view.GetRow(e.RowHandle) as FasonGrid;

            if (row != null && row.sth_Guid != null)
            {
                // Satır silindiğinde ve tkl_Guid değeri null değilse işlem yap
                // Örneğin, bu satırı silinenKayitlar listesine ekle
                if (!silinenKayitlar.Contains(row))
                {
                    silinenKayitlar.Add(row);
                }
            }
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void btnSatirSil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        private void repoBtnHareketGrupKodu1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                repository.DeleteSthWSeriSira(txtSeri.Text, Convert.ToInt32(btnSira.Text), _evrakTip);

                this.Close();


            }
        }
    }
}
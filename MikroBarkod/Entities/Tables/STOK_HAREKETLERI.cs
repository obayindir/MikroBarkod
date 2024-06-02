using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikroBarkod.Entities.Tables
{
    public class STOK_HAREKETLERI
    {
        public System.Guid sth_Guid { get; set; }
        public short sth_DBCno { get; set; } = 0;
        public Nullable<int> sth_SpecRECno { get; set; } = 0;
        public Nullable<bool> sth_iptal { get; set; } = false;
        public Nullable<short> sth_fileid { get; set; } = 16;
        public Nullable<bool> sth_hidden { get; set; } = false;
        public Nullable<bool> sth_kilitli { get; set; } = false;
        public Nullable<bool> sth_degisti { get; set; } = false;
        public Nullable<int> sth_checksum { get; set; } = 0;
        public Nullable<short> sth_create_user { get; set; } = 1;
        public System.DateTime sth_create_date { get; set; } = DateTime.Now;
        public Nullable<short> sth_lastup_user { get; set; } = 1;
        public Nullable<System.DateTime> sth_lastup_date { get; set; }
        public string sth_special1 { get; set; } = "BY";
        public string sth_special2 { get; set; } = "";
        public string sth_special3 { get; set; } = "";
        public Nullable<int> sth_firmano { get; set; } = 0;
        public Nullable<int> sth_subeno { get; set; } = 0;
        public Nullable<System.DateTime> sth_tarih { get; set; }
        public Nullable<byte> sth_tip { get; set; }
        public Nullable<byte> sth_cins { get; set; }
        public Nullable<byte> sth_normal_iade { get; set; } = 0;
        public Nullable<byte> sth_evraktip { get; set; }
        public string sth_evrakno_seri { get; set; }
        public Nullable<int> sth_evrakno_sira { get; set; }
        public Nullable<int> sth_satirno { get; set; }
        public string sth_belge_no { get; set; } = "";
        public Nullable<System.DateTime> sth_belge_tarih { get; set; }
        public string sth_stok_kod { get; set; }
        public Nullable<byte> sth_isk_mas1 { get; set; } = 0;
        public Nullable<byte> sth_isk_mas2 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas3 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas4 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas5 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas6 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas7 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas8 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas9 { get; set; } = 1;
        public Nullable<byte> sth_isk_mas10 { get; set; } = 1;
        public Nullable<bool> sth_sat_iskmas1 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas2 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas3 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas4 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas5 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas6 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas7 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas8 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas9 { get; set; } = false;
        public Nullable<bool> sth_sat_iskmas10 { get; set; } = false;
        public Nullable<byte> sth_pos_satis { get; set; } = 0;
        public Nullable<bool> sth_promosyon_fl { get; set; } = false;
        public Nullable<byte> sth_cari_cinsi { get; set; } = 0;
        public string sth_cari_kodu { get; set; }
        public Nullable<byte> sth_cari_grup_no { get; set; } = 0;
        public string sth_isemri_gider_kodu { get; set; } = "";
        public string sth_plasiyer_kodu { get; set; } = "";
        public Nullable<byte> sth_har_doviz_cinsi { get; set; } = 0;
        public Nullable<double> sth_har_doviz_kuru { get; set; } = 1;
        public Nullable<double> sth_alt_doviz_kuru { get; set; } = 1;
        public Nullable<byte> sth_stok_doviz_cinsi { get; set; } = 0;
        public Nullable<double> sth_stok_doviz_kuru { get; set; } = 1;
        public Nullable<double> sth_miktar { get; set; }
        public Nullable<double> sth_miktar2 { get; set; }
        public Nullable<byte> sth_birim_pntr { get; set; } = 1;
        public Nullable<double> sth_tutar { get; set; } = 0;

        public Nullable<double> sth_iskonto1 { get; set; } = 0;
        public Nullable<double> sth_iskonto2 { get; set; } = 0;
        public Nullable<double> sth_iskonto3 { get; set; } = 0;
        public Nullable<double> sth_iskonto4 { get; set; } = 0;
        public Nullable<double> sth_iskonto5 { get; set; } = 0;
        public Nullable<double> sth_iskonto6 { get; set; } = 0;
        public Nullable<double> sth_masraf1 { get; set; } = 0;
        public Nullable<double> sth_masraf2 { get; set; } = 0;
        public Nullable<double> sth_masraf3 { get; set; } = 0;
        public Nullable<double> sth_masraf4 { get; set; } = 0;
        public Nullable<byte> sth_vergi_pntr { get; set; } = 4;
        public Nullable<double> sth_vergi { get; set; } = 0;
        public Nullable<byte> sth_masraf_vergi_pntr { get; set; } = 0;
        public Nullable<double> sth_masraf_vergi { get; set; } = 0;
        public Nullable<double> sth_netagirlik { get; set; } = 0;
        public Nullable<int> sth_odeme_op { get; set; } = 0;
        public string sth_aciklama { get; set; }
        public Nullable<System.Guid> sth_sip_uid { get; set; } = Guid.Empty;
        public Nullable<System.Guid> sth_fat_uid { get; set; } = Guid.Empty;
        public Nullable<int> sth_giris_depo_no { get; set; } 
        public Nullable<int> sth_cikis_depo_no { get; set; }
        public Nullable<System.DateTime> sth_malkbl_sevk_tarihi { get; set; } = Convert.ToDateTime("1899-12-30 00:00:00.000");
        public string sth_cari_srm_merkezi { get; set; } = "";
        public string sth_stok_srm_merkezi { get; set; } = "";
        public Nullable<System.DateTime> sth_fis_tarihi { get; set; } = Convert.ToDateTime("1899-12-30 00:00:00.000");
        public Nullable<int> sth_fis_sirano { get; set; } = 0;
        public Nullable<bool> sth_vergisiz_fl { get; set; } = false;
        public Nullable<double> sth_maliyet_ana { get; set; } = 0;
        public Nullable<double> sth_maliyet_alternatif { get; set; } = 0;
        public Nullable<double> sth_maliyet_orjinal { get; set; } = 0;
        public Nullable<int> sth_adres_no { get; set; } = 1;
        public string sth_parti_kodu { get; set; } = "";
        public Nullable<int> sth_lot_no { get; set; } = 0;
        public Nullable<System.Guid> sth_kons_uid { get; set; } = Guid.Empty;
        public string sth_proje_kodu { get; set; } = "";
        public string sth_exim_kodu { get; set; } = "";
        public Nullable<byte> sth_otv_pntr { get; set; } = 0;
        public Nullable<double> sth_otv_vergi { get; set; } = 0;
        public Nullable<double> sth_brutagirlik { get; set; } = 0;
        public Nullable<byte> sth_disticaret_turu { get; set; } = 0;
        public Nullable<double> sth_otvtutari { get; set; } = 0;
        public Nullable<bool> sth_otvvergisiz_fl { get; set; } = false;
        public Nullable<byte> sth_oiv_pntr { get; set; } = 0;
        public Nullable<double> sth_oiv_vergi { get; set; } = 0;
        public Nullable<bool> sth_oivvergisiz_fl { get; set; } = false;
        public Nullable<int> sth_fiyat_liste_no { get; set; } = 0;
        public Nullable<double> sth_oivtutari { get; set; } = 0;
        public Nullable<byte> sth_Tevkifat_turu { get; set; } = 0;
        public Nullable<int> sth_nakliyedeposu { get; set; } = 0;
        public Nullable<byte> sth_nakliyedurumu { get; set; } = 0;
        public Nullable<System.Guid> sth_yetkili_uid { get; set; } =Guid.Empty;
        public Nullable<bool> sth_taxfree_fl { get; set; } = false;
        public Nullable<double> sth_ilave_edilecek_kdv { get; set; } = 0;
        public string sth_ismerkezi_kodu { get; set; } = "";
        public string sth_HareketGrupKodu1 { get; set; }
        public string sth_HareketGrupKodu2 { get; set; } = "";
        public string sth_HareketGrupKodu3 { get; set; } = "";
        public Nullable<double> sth_Olcu1 { get; set; } = 0;
        public Nullable<double> sth_Olcu2 { get; set; } = 0;
        public Nullable<double> sth_Olcu3 { get; set; } = 0;
        public Nullable<double> sth_Olcu4 { get; set; } = 0;
        public Nullable<double> sth_Olcu5 { get; set; } = 0;
        public Nullable<byte> sth_FormulMiktarNo { get; set; } = 0;
        public Nullable<double> sth_FormulMiktar { get; set; } = 0;
        public Nullable<byte> sth_eirs_senaryo { get; set; } = 0;
        public Nullable<byte> sth_eirs_tipi { get; set; } = 0;
        public Nullable<System.DateTime> sth_teslim_tarihi { get; set; }
        public Nullable<bool> sth_matbu_fl { get; set; } = false;
        public Nullable<byte> sth_satis_fiyat_doviz_cinsi { get; set; } = 0;
        public Nullable<double> sth_satis_fiyat_doviz_kuru { get; set; } = 0;
        public string sth_eticaret_kanal_kodu { get; set; } = "";
    }
}

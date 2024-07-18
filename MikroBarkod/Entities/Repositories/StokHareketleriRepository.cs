using MikroBarkod.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikroBarkod.Entities.Tables;
using Dapper;

namespace MikroBarkod.Entities.Repositories
{
    public class StokHareketleriRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();

        public StokHareketleriRepository()
        {
            
        }
        public void InsertSth(STOK_HAREKETLERI sth)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO STOK_HAREKETLERI " +
                    "(sth_Guid, sth_DBCno, sth_SpecRECno, sth_iptal, sth_fileid, sth_hidden, sth_kilitli, sth_degisti, sth_checksum, sth_create_user, sth_create_date, sth_lastup_user, sth_lastup_date, sth_special1, sth_special2, sth_special3, sth_firmano, sth_subeno, sth_tarih, sth_tip, sth_cins, sth_normal_iade, sth_evraktip, sth_evrakno_seri, sth_evrakno_sira, sth_satirno, sth_belge_no, sth_belge_tarih, sth_stok_kod, sth_isk_mas1, sth_isk_mas2, sth_isk_mas3, sth_isk_mas4, sth_isk_mas5, sth_isk_mas6, sth_isk_mas7, sth_isk_mas8, sth_isk_mas9, sth_isk_mas10, sth_sat_iskmas1, sth_sat_iskmas2, sth_sat_iskmas3, sth_sat_iskmas4, sth_sat_iskmas5, sth_sat_iskmas6, sth_sat_iskmas7, sth_sat_iskmas8, sth_sat_iskmas9, sth_sat_iskmas10, sth_pos_satis, sth_promosyon_fl, sth_cari_cinsi, sth_cari_kodu, sth_cari_grup_no, sth_isemri_gider_kodu, sth_plasiyer_kodu, sth_har_doviz_cinsi, sth_har_doviz_kuru, sth_alt_doviz_kuru, sth_stok_doviz_cinsi, sth_stok_doviz_kuru, sth_miktar, sth_miktar2, sth_birim_pntr, sth_tutar, sth_iskonto1, sth_iskonto2, sth_iskonto3, sth_iskonto4, sth_iskonto5, sth_iskonto6, sth_masraf1, sth_masraf2, sth_masraf3, sth_masraf4, sth_vergi_pntr, sth_vergi, sth_masraf_vergi_pntr, sth_masraf_vergi, sth_netagirlik, sth_odeme_op, sth_aciklama, sth_sip_uid, sth_fat_uid, sth_giris_depo_no, sth_cikis_depo_no, sth_malkbl_sevk_tarihi, sth_cari_srm_merkezi, sth_stok_srm_merkezi, sth_fis_tarihi, sth_fis_sirano, sth_vergisiz_fl, sth_maliyet_ana, sth_maliyet_alternatif, sth_maliyet_orjinal, sth_adres_no, sth_parti_kodu, sth_lot_no, sth_kons_uid, sth_proje_kodu, sth_exim_kodu, sth_otv_pntr, sth_otv_vergi, sth_brutagirlik, sth_disticaret_turu, sth_otvtutari, sth_otvvergisiz_fl, sth_oiv_pntr, sth_oiv_vergi, sth_oivvergisiz_fl, sth_fiyat_liste_no, sth_oivtutari, sth_Tevkifat_turu, sth_nakliyedeposu, sth_nakliyedurumu, sth_yetkili_uid, sth_taxfree_fl, sth_ilave_edilecek_kdv, sth_ismerkezi_kodu, sth_HareketGrupKodu1, sth_HareketGrupKodu2, sth_HareketGrupKodu3, sth_Olcu1, sth_Olcu2, sth_Olcu3, sth_Olcu4, sth_Olcu5, sth_FormulMiktarNo, sth_FormulMiktar, sth_eirs_senaryo, sth_eirs_tipi, sth_teslim_tarihi, sth_matbu_fl, sth_satis_fiyat_doviz_cinsi, sth_satis_fiyat_doviz_kuru, sth_eticaret_kanal_kodu)" +
                    "VALUES " +
                    "(@sth_Guid, @sth_DBCno, @sth_SpecRECno, @sth_iptal, @sth_fileid, @sth_hidden, @sth_kilitli, @sth_degisti, @sth_checksum, @sth_create_user, @sth_create_date, @sth_lastup_user, @sth_lastup_date, @sth_special1, @sth_special2, @sth_special3, @sth_firmano, @sth_subeno, @sth_tarih, @sth_tip, @sth_cins, @sth_normal_iade, @sth_evraktip, @sth_evrakno_seri, @sth_evrakno_sira, @sth_satirno, @sth_belge_no, @sth_belge_tarih, @sth_stok_kod, @sth_isk_mas1, @sth_isk_mas2, @sth_isk_mas3, @sth_isk_mas4, @sth_isk_mas5, @sth_isk_mas6, @sth_isk_mas7, @sth_isk_mas8, @sth_isk_mas9, @sth_isk_mas10, @sth_sat_iskmas1, @sth_sat_iskmas2, @sth_sat_iskmas3, @sth_sat_iskmas4, @sth_sat_iskmas5, @sth_sat_iskmas6, @sth_sat_iskmas7, @sth_sat_iskmas8, @sth_sat_iskmas9, @sth_sat_iskmas10, @sth_pos_satis, @sth_promosyon_fl, @sth_cari_cinsi, @sth_cari_kodu, @sth_cari_grup_no, @sth_isemri_gider_kodu, @sth_plasiyer_kodu, @sth_har_doviz_cinsi, @sth_har_doviz_kuru, @sth_alt_doviz_kuru, @sth_stok_doviz_cinsi, @sth_stok_doviz_kuru, @sth_miktar, @sth_miktar2, @sth_birim_pntr, @sth_tutar, @sth_iskonto1, @sth_iskonto2, @sth_iskonto3, @sth_iskonto4, @sth_iskonto5, @sth_iskonto6, @sth_masraf1, @sth_masraf2, @sth_masraf3, @sth_masraf4, @sth_vergi_pntr, @sth_vergi, @sth_masraf_vergi_pntr, @sth_masraf_vergi, @sth_netagirlik, @sth_odeme_op, @sth_aciklama, @sth_sip_uid, @sth_fat_uid, @sth_giris_depo_no, @sth_cikis_depo_no, @sth_malkbl_sevk_tarihi, @sth_cari_srm_merkezi, @sth_stok_srm_merkezi, @sth_fis_tarihi, @sth_fis_sirano, @sth_vergisiz_fl, @sth_maliyet_ana, @sth_maliyet_alternatif, @sth_maliyet_orjinal, @sth_adres_no, @sth_parti_kodu, @sth_lot_no, @sth_kons_uid, @sth_proje_kodu, @sth_exim_kodu, @sth_otv_pntr, @sth_otv_vergi, @sth_brutagirlik, @sth_disticaret_turu, @sth_otvtutari, @sth_otvvergisiz_fl, @sth_oiv_pntr, @sth_oiv_vergi, @sth_oivvergisiz_fl, @sth_fiyat_liste_no, @sth_oivtutari, @sth_Tevkifat_turu, @sth_nakliyedeposu, @sth_nakliyedurumu, @sth_yetkili_uid, @sth_taxfree_fl, @sth_ilave_edilecek_kdv, @sth_ismerkezi_kodu, @sth_HareketGrupKodu1, @sth_HareketGrupKodu2, @sth_HareketGrupKodu3, @sth_Olcu1, @sth_Olcu2, @sth_Olcu3, @sth_Olcu4, @sth_Olcu5, @sth_FormulMiktarNo, @sth_FormulMiktar, @sth_eirs_senaryo, @sth_eirs_tipi, @sth_teslim_tarihi, @sth_matbu_fl, @sth_satis_fiyat_doviz_cinsi, @sth_satis_fiyat_doviz_kuru, @sth_eticaret_kanal_kodu)";
                dbConnection.Execute(query, sth);
            }

        }
        public bool CheckKayitVarmi(string seri, int sira, string evrakTip)
        {

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT sth_evrakno_seri FROM STOK_HAREKETLERI WHERE sth_evrakno_seri = '{seri}' and sth_evrakno_sira='{sira}' and sth_evraktip='{evrakTip}'";
                var item = dbConnection.QueryFirstOrDefault<STOK_HAREKETLERI>(query);
                if (item != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public STOK_HAREKETLERI GetSthById(Guid id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM STOK_HAREKETLERI WHERE sth_Guid=@Id";
                return dbConnection.QueryFirstOrDefault<STOK_HAREKETLERI>(query, new { Id = id });

            }
        }

        public STOK_HAREKETLERI GetSthSeriSira(string seri, int sira, string evrakTip)
        {
            //txt sira no dan leave methodu için yazılmıştır.
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM STOK_HAREKETLERI WHERE sth_evrakno_seri='{seri}' and sth_evrakno_sira='{sira}' and sth_evraktip='{evrakTip}'";
                return dbConnection.QueryFirstOrDefault<STOK_HAREKETLERI>(query);

            }
        }
        public object GetAllSthWSeriSira(string seri, int sira, string evrakTip)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM STOK_HAREKETLERI WHERE sth_evrakno_seri = '{seri}' and sth_evrakno_sira = '{sira}' and sth_evraktip='{evrakTip}' ";
                return dbConnection.Query<STOK_HAREKETLERI>(query).ToList();

            }
        }

        public int GetSthSonSiraNo(string seri,string evrakTip)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT sth_evrakno_sira FROM STOK_HAREKETLERI WHERE sth_evrakno_seri='{seri}' and sth_evraktip='{evrakTip}' order by sth_evrakno_sira desc";


                if (dbConnection.QueryFirstOrDefault(query) == null)
                {
                    return 0;
                }
                else
                {
                    return dbConnection.QueryFirstOrDefault(query).sth_evrakno_sira;
                }




            }
        }
        public void UpdateSth(STOK_HAREKETLERI sth)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "UPDATE STOK_HAREKETLERI SET " +
                    "sth_Guid = @sth_Guid, sth_DBCno = @sth_DBCno, sth_SpecRECno = @sth_SpecRECno, sth_iptal = @sth_iptal, sth_fileid = @sth_fileid, sth_hidden = @sth_hidden, sth_kilitli = @sth_kilitli, sth_degisti = @sth_degisti, sth_checksum = @sth_checksum, sth_create_user = @sth_create_user, sth_create_date = @sth_create_date, sth_lastup_user = @sth_lastup_user, sth_lastup_date = @sth_lastup_date, sth_special1 = @sth_special1, sth_special2 = @sth_special2, sth_special3 = @sth_special3, sth_firmano = @sth_firmano, sth_subeno = @sth_subeno, sth_tarih = @sth_tarih, sth_tip = @sth_tip, sth_cins = @sth_cins, sth_normal_iade = @sth_normal_iade, sth_evraktip = @sth_evraktip, sth_evrakno_seri = @sth_evrakno_seri, sth_evrakno_sira = @sth_evrakno_sira, sth_satirno = @sth_satirno, sth_belge_no = @sth_belge_no, sth_belge_tarih = @sth_belge_tarih, sth_stok_kod = @sth_stok_kod, sth_isk_mas1 = @sth_isk_mas1, sth_isk_mas2 = @sth_isk_mas2, sth_isk_mas3 = @sth_isk_mas3, sth_isk_mas4 = @sth_isk_mas4, sth_isk_mas5 = @sth_isk_mas5, sth_isk_mas6 = @sth_isk_mas6, sth_isk_mas7 = @sth_isk_mas7, sth_isk_mas8 = @sth_isk_mas8, sth_isk_mas9 = @sth_isk_mas9, sth_isk_mas10 = @sth_isk_mas10, sth_sat_iskmas1 = @sth_sat_iskmas1, sth_sat_iskmas2 = @sth_sat_iskmas2, sth_sat_iskmas3 = @sth_sat_iskmas3, sth_sat_iskmas4 = @sth_sat_iskmas4, sth_sat_iskmas5 = @sth_sat_iskmas5, sth_sat_iskmas6 = @sth_sat_iskmas6, sth_sat_iskmas7 = @sth_sat_iskmas7, sth_sat_iskmas8 = @sth_sat_iskmas8, sth_sat_iskmas9 = @sth_sat_iskmas9, sth_sat_iskmas10 = @sth_sat_iskmas10, sth_pos_satis = @sth_pos_satis, sth_promosyon_fl = @sth_promosyon_fl, sth_cari_cinsi = @sth_cari_cinsi, sth_cari_kodu = @sth_cari_kodu, sth_cari_grup_no = @sth_cari_grup_no, sth_isemri_gider_kodu = @sth_isemri_gider_kodu, sth_plasiyer_kodu = @sth_plasiyer_kodu, sth_har_doviz_cinsi = @sth_har_doviz_cinsi, sth_har_doviz_kuru = @sth_har_doviz_kuru, sth_alt_doviz_kuru = @sth_alt_doviz_kuru, sth_stok_doviz_cinsi = @sth_stok_doviz_cinsi, sth_stok_doviz_kuru = @sth_stok_doviz_kuru, sth_miktar = @sth_miktar, sth_miktar2 = @sth_miktar2, sth_birim_pntr = @sth_birim_pntr, sth_tutar = @sth_tutar, sth_iskonto1 = @sth_iskonto1, sth_iskonto2 = @sth_iskonto2, sth_iskonto3 = @sth_iskonto3, sth_iskonto4 = @sth_iskonto4, sth_iskonto5 = @sth_iskonto5, sth_iskonto6 = @sth_iskonto6, sth_masraf1 = @sth_masraf1, sth_masraf2 = @sth_masraf2, sth_masraf3 = @sth_masraf3, sth_masraf4 = @sth_masraf4, sth_vergi_pntr = @sth_vergi_pntr, sth_vergi = @sth_vergi, sth_masraf_vergi_pntr = @sth_masraf_vergi_pntr, sth_masraf_vergi = @sth_masraf_vergi, sth_netagirlik = @sth_netagirlik, sth_odeme_op = @sth_odeme_op, sth_aciklama = @sth_aciklama, sth_sip_uid = @sth_sip_uid, sth_fat_uid = @sth_fat_uid, sth_giris_depo_no = @sth_giris_depo_no, sth_cikis_depo_no = @sth_cikis_depo_no, sth_malkbl_sevk_tarihi = @sth_malkbl_sevk_tarihi, sth_cari_srm_merkezi = @sth_cari_srm_merkezi, sth_stok_srm_merkezi = @sth_stok_srm_merkezi, sth_fis_tarihi = @sth_fis_tarihi, sth_fis_sirano = @sth_fis_sirano, sth_vergisiz_fl = @sth_vergisiz_fl, sth_maliyet_ana = @sth_maliyet_ana, sth_maliyet_alternatif = @sth_maliyet_alternatif, sth_maliyet_orjinal = @sth_maliyet_orjinal, sth_adres_no = @sth_adres_no, sth_parti_kodu = @sth_parti_kodu, sth_lot_no = @sth_lot_no, sth_kons_uid = @sth_kons_uid, sth_proje_kodu = @sth_proje_kodu, sth_exim_kodu = @sth_exim_kodu, sth_otv_pntr = @sth_otv_pntr, sth_otv_vergi = @sth_otv_vergi, sth_brutagirlik = @sth_brutagirlik, sth_disticaret_turu = @sth_disticaret_turu, sth_otvtutari = @sth_otvtutari, sth_otvvergisiz_fl = @sth_otvvergisiz_fl, sth_oiv_pntr = @sth_oiv_pntr, sth_oiv_vergi = @sth_oiv_vergi, sth_oivvergisiz_fl = @sth_oivvergisiz_fl, sth_fiyat_liste_no = @sth_fiyat_liste_no, sth_oivtutari = @sth_oivtutari, sth_Tevkifat_turu = @sth_Tevkifat_turu, sth_nakliyedeposu = @sth_nakliyedeposu, sth_nakliyedurumu = @sth_nakliyedurumu, sth_yetkili_uid = @sth_yetkili_uid, sth_taxfree_fl = @sth_taxfree_fl, sth_ilave_edilecek_kdv = @sth_ilave_edilecek_kdv, sth_ismerkezi_kodu = @sth_ismerkezi_kodu, sth_HareketGrupKodu1 = @sth_HareketGrupKodu1, sth_HareketGrupKodu2 = @sth_HareketGrupKodu2, sth_HareketGrupKodu3 = @sth_HareketGrupKodu3, sth_Olcu1 = @sth_Olcu1, sth_Olcu2 = @sth_Olcu2, sth_Olcu3 = @sth_Olcu3, sth_Olcu4 = @sth_Olcu4, sth_Olcu5 = @sth_Olcu5, sth_FormulMiktarNo = @sth_FormulMiktarNo, sth_FormulMiktar = @sth_FormulMiktar, sth_eirs_senaryo = @sth_eirs_senaryo, sth_eirs_tipi = @sth_eirs_tipi, sth_teslim_tarihi = @sth_teslim_tarihi, sth_matbu_fl = @sth_matbu_fl, sth_satis_fiyat_doviz_cinsi = @sth_satis_fiyat_doviz_cinsi, sth_satis_fiyat_doviz_kuru = @sth_satis_fiyat_doviz_kuru, sth_eticaret_kanal_kodu = @sth_eticaret_kanal_kodu" +
                    " WHERE sth_Guid = @sth_Guid";

                dbConnection.Execute(query, sth);
            }
        }

        public void DeleteSth(Guid id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM STOK_HAREKETLERI WHERE sth_Guid = @Id";
                dbConnection.Execute(query, new { Id = id });
            }
        }

        public void DeleteSthWSeriSira(string seri , int sira, string evrakTip)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"DELETE FROM STOK_HAREKETLERI WHERE sth_evrakno_seri = '{seri}' and sth_evrakno_sira = '{sira}' and sth_evraktip = '{evrakTip}'";
                dbConnection.Execute(query);
            }
        }

        public object GetAllFasonHareketleri(DateTime ilkTarih, DateTime sonTarih)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                //string query = $"Select * from fn_Bayindir_Fason_Hareket_Foyu('{ilkTarih.ToString("yyyy-MM-dd")}','{sonTarih.ToString("yyyy-MM-dd")}')";
                string query = $"Select * from fn_IsemriStokHareketFoyu( N'genel',N'genel','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}',0)";
               
                return dbConnection.Query(query).ToList();
            }

        }
       
    }
}

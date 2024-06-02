using MikroBarkod.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MikroBarkod.Entities.Repositories
{
    public class SiparislerRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();

        public SiparislerRepository()
        {
            
        }

        public object GetSiparisler()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT sip_evrakno_seri AS 'SERİ', sip_evrakno_sira AS 'SIRA', sip_tarih AS 'SİPARİŞ_TARİHİ', bar_kodu as 'BARKODU',sip_aciklama as 'ACIKLAMA',sip_musteri_kod AS 'CARİ KODU',dbo.fn_CarininIsminiBul(0, sip_musteri_kod) AS 'CARİ İSMİ',  sip_stok_kod as 'STOK KOD', dbo.fn_StokIsmi(sip_stok_kod) as 'STOK İSMİ', sip_miktar AS 'MİKTAR', sip_teslim_miktar AS 'TAMAMLANAN MİKTAR', dbo.fn_Evrak_Kalan_Miktar(sip_miktar, sip_teslim_miktar, sip_kapat_fl) AS 'KALAN MİKTAR', dbo.fn_SiparisAcikKapali(sip_kapat_fl, sip_miktar, sip_teslim_miktar) AS 'A/K' FROM dbo.SIPARISLER LEFT OUTER JOIN BARKOD_TANIMLARI ON bar_stokkodu = sip_stok_kod LEFT OUTER JOIN  STOKLAR ON sto_kod = sip_stok_kod WHERE sip_tip = 0 AND sip_evrakno_seri <> 'F' ORDER BY sip_tarih DESC, sip_tip, sip_cins, sip_evrakno_seri, sip_evrakno_sira, sip_musteri_kod, sip_kapat_fl, sip_firmano, sip_depono";

                return dbConnection.Query(query).ToList();
            }

        }

        public object GetSiparislerView2()
        {
            using (IDbConnection dbConnection  = new SqlConnection(connectionString))
            {
                string query = "SELECT sip_evrakno_seri AS 'SERİ', sip_evrakno_sira AS 'SIRA', sip_tarih AS 'SİPARİŞ TARİHİ', bar_kodu as 'BARKODU',\r\nsip_aciklama as 'ACIKLAMA',\r\n    sip_musteri_kod AS 'CARİ KODU',\r\n    dbo.fn_CarininIsminiBul(0, sip_musteri_kod) AS 'CARİ İSMİ',\r\n    sip_stok_kod as 'STOK KOD',\r\n    dbo.fn_StokIsmi(sip_stok_kod) as 'STOK İSMİ',  \r\n --   CASE \r\n --   WHEN ISNULL(sto_birim2_katsayi, 0) = 0 THEN 0\r\n --   ELSE dbo.fn_VerilenBirimMiktarHesapla(sto_kod, sip_miktar, 2)\r\n --   END AS 'KOLİ İÇİ ADET',\r\n    sip_miktar AS 'MİKTAR',   \r\n    sip_teslim_miktar AS 'TAMAMLANAN MİKTAR',\r\n    dbo.fn_Evrak_Kalan_Miktar(sip_miktar, sip_teslim_miktar, sip_kapat_fl) AS 'KALAN MİKTAR',\r\n    dbo.fn_SiparisAcikKapali(sip_kapat_fl, sip_miktar, sip_teslim_miktar) AS 'A/K' \r\nFROM \r\n    dbo.SIPARISLER\r\nLEFT OUTER JOIN \r\n    BARKOD_TANIMLARI ON bar_stokkodu = sip_stok_kod \r\nLEFT OUTER JOIN \r\n    STOKLAR ON sto_kod = sip_stok_kod\r\nWHERE \r\n    sip_tip = 0 and sip_evrakno_seri='F'\r\nORDER BY \r\n    sip_tarih DESC, \r\n    sip_tip, \r\n    sip_cins, \r\n    sip_evrakno_seri, \r\n    sip_evrakno_sira, \r\n    sip_musteri_kod, \r\n    sip_kapat_fl, \r\n    sip_firmano, \r\n    sip_depono;\r\n";
                return dbConnection.Query(query).ToList();
            }
        }

    }
}

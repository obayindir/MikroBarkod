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
    public class PrimRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();

        public PrimRepository()
        {
            
        }

        public object GetPrimReport(string plasiyerKodu,DateTime ilkTarih, DateTime sonTarih)
        {

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                //string query = $"Select * from fn_IsemriStokHareketFoyu( N'genel',N'genel','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}',0)";
                string query = $"exec dbo.Bayindir_Kur_Farki_Hesapla '{plasiyerKodu}','{plasiyerKodu}','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}'";
                return dbConnection.Query(query).ToList();
            }
        }
        public async Task<List<object>> GetPrimReportAsync(string plasiyerKodu, DateTime ilkTarih, DateTime sonTarih)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"exec dbo.Bayindir_Kur_Farki_Hesapla @plasiyerKodu1, @plasiyerKodu2, @ilkTarih, @sonTarih";

                var parameters = new
                {
                    plasiyerKodu1 = plasiyerKodu,
                    plasiyerKodu2 = plasiyerKodu,
                    ilkTarih = ilkTarih.ToString("yyyyMMdd"),
                    sonTarih = sonTarih.ToString("yyyyMMdd")
                };

                var result = await dbConnection.QueryAsync<object>(query, parameters);
                return result.ToList();
            }
        }


        public async Task UpdateSthSpecial2Async(Guid sthGuid, int newValue)
        {
            await Task.Run(() =>
            {
                

                using (IDbConnection dbConnection = new SqlConnection(connectionString))
                {
                    string query = $"UPDATE STOK_HAREKETLERI SET sth_special2 = {newValue} WHERE sth_Guid = {sthGuid}";

                    dbConnection.ExecuteAsync(query);

                }
            });
        }

        public List<CariPersonelTanımlari> GetCariPersoneller()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "Select cari_per_kod,cari_per_adi FROM CARI_PERSONEL_TANIMLARI ";
                return dbConnection.Query<CariPersonelTanımlari>(query).ToList();
            }
        }

    }

    public class CariPersonelTanımlari
    {
        public string cari_per_kod { get; set; }
        public string cari_per_adi { get; set; }
    }
}

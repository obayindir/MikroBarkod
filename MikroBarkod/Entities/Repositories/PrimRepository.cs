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
                string query = $"Select * from fn_IsemriStokHareketFoyu( N'genel',N'genel','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}',0)";
                string sqlQuery = $"exec dbo.Bayindir_Kur_Farki_Hesapla '{plasiyerKodu}','{plasiyerKodu}','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}'";
                return dbConnection.Query(query).ToList();
            }
        }
        public async Task<List<dynamic>> GetPrimReportAsync(string plasiyerKodu, DateTime ilkTarih, DateTime sonTarih)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"Select * from fn_IsemriStokHareketFoyu( N'genel',N'genel','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}',0)";
                string sqlQuery = $"exec dbo.Bayindir_Kur_Farki_Hesapla '{plasiyerKodu}','{plasiyerKodu}','{ilkTarih.ToString("yyyyMMdd")}','{sonTarih.ToString("yyyyMMdd")}'";

                var results = new List<dynamic>();

                var queryTask = dbConnection.QueryAsync(query);
                var sqlQueryTask = dbConnection.QueryAsync(sqlQuery);

                await Task.WhenAll(queryTask, sqlQueryTask);

                results.AddRange(await queryTask);
                results.AddRange(await sqlQueryTask);

                return results;
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

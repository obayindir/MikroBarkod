using MikroBarkod.Entities.Tables;
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
    public class StokRepository
    {
        //private readonly string connectionString = "Data Source=OMER;Initial Catalog=MikroDB_V16_REFLEKS_AS_2022;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly string connectionString = DosyaOku.DbOku();
        public StokRepository()
        {

        }

        public object GetStoklar()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT sto_kod, sto_isim, sto_birim1_ad from STOKLAR";
                return dbConnection.Query(query).ToList();
            }

        }
       
        public STOKLAR GetStoklarByKod(string stokKodu)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM STOKLAR WHERE sto_kod='{stokKodu}'";
                return dbConnection.QueryFirstOrDefault<STOKLAR>(query);
            }

        }

        public object GetStoklarWBarkod()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT sto_kod,sto_isim,bar_kodu from STOKLAR LEFT OUTER JOIN BARKOD_TANIMLARI BT ON BT.bar_stokkodu=sto_kod where BT.bar_kodu IS NOT NULL";
                return dbConnection.Query(query).ToList();

            }
        }
    }
}

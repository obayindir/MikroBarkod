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
    public class HareketGrupRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();
        public List<HAREKET_GRUBU_1> GetHareketGruplari()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT hg1_isim,hg1_kod FROM HAREKET_GRUBU_1 ORDER BY hg1_kod ASC";
                return dbConnection.Query<HAREKET_GRUBU_1>(query).ToList();
            }
        }
    }
}

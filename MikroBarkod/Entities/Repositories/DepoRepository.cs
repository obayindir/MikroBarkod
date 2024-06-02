using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikroBarkod.Services;
using Dapper;
using MikroBarkod.Entities.Tables;

namespace MikroBarkod.Entities.Repositories
{
    public class DepoRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();
        public List<DEPOLAR> GetDepo()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT dep_no, dep_adi FROM DEPOLAR ORDER BY dep_no ASC";
                return dbConnection.Query<DEPOLAR>(query).ToList();
            }
        }
    }
}

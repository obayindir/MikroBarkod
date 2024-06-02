using MikroBarkod.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MikroBarkod.Services;

namespace MikroBarkod.Entities.Repositories
{
    public class CariRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();
        public CariRepository()
        {

        }
        public object GetAllCari()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT cari_kod,cari_unvan1 FROM CARI_HESAPLAR";
                return dbConnection.Query(query).ToList();
            }

        }

        public bool CheckKayitVarmi(string cariKodu, string unvan)
        {

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT cari_kod,cari_unvan1 FROM CARI_HESAPLAR WHERE cari_kod = '{cariKodu}' or cari_unvan1 = '{unvan}'";
                var item = dbConnection.QueryFirstOrDefault<CARI_HESAPLAR>(query);
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

        public AutoCompleteStringCollection GetCariForAutoComp()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT cari_unvan1 FROM CARI_HESAPLAR";
                var results = dbConnection.Query<string>(query).AsList();

                foreach (var result in results)
                {
                    autoCompleteCollection.Add(result);
                }
            }

            return autoCompleteCollection;
        }

        public CARI_HESAPLAR GetCariByUnvan(string unvan)
        {
            //txt sira no dan leave methodu için yazılmıştır.
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT cari_kod,cari_unvan1 FROM CARI_HESAPLAR WHERE cari_unvan1='{unvan}'";
                return dbConnection.QueryFirstOrDefault<CARI_HESAPLAR>(query);

            }
        }
        public string GetCariUnvanByCode(string code)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"SELECT cari_unvan1 FROM CARI_HESAPLAR WHERE cari_kod='{code}'";


                if (dbConnection.QueryFirstOrDefault(query) == null)
                {
                    return string.Empty;
                }
                else
                {
                    return dbConnection.QueryFirstOrDefault(query).cari_unvan1;
                }




            }
        }
    }
}

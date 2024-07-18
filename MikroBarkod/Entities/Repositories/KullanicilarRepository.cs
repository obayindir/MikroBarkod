using MikroBarkod.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MikroBarkod.Entities.Repositories
{
    public class KullanicilarRepository
    {
        private readonly string connectionString = DosyaOku.DbOku();

        public KullanicilarRepository()
        {

        }

        public object GetKullanicilar()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = "USE MikroDB_V16 SELECT User_name,User_LongName FROM KULLANICILAR order by User_name asc";
                return dbConnection.Query(query).ToList();
            }


        }

        public bool GetAuthenticateUser(string username, string password)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"USE MikroDB_V16 SELECT User_name FROM KULLANICILAR WHERE User_name = '{username}' AND User_PrevPW1 = '{password}'";
                if (dbConnection.QueryFirstOrDefault(query).User_name == username)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void UpdateKullaniSifresi(string username, string newPassword)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = $"USE MikroDB_V16 UPDATE KULLANICILAR SET User_PrevPW1 = '{newPassword}' WHERE User_name = '{username}'";
                dbConnection.Execute(query);
            }


        }
    }
}

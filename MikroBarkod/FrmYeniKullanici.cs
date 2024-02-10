using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod
{
    public partial class FrmYeniKullanici : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmYeniKullanici()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {

                // SQL sorgusu
                string sqlQuery = "USE MikroDB_V16 SELECT User_name FROM KULLANICILAR";

                using (SqlCommand command = new SqlCommand(sqlQuery, bgl.baglan()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // ComboBox'ı temizle
                        cmbKullanicilar.Items.Clear();

                        // Verileri ComboBox'a ekle
                        while (reader.Read())
                        {
                            cmbKullanicilar.Items.Add(reader["User_name"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string hashedPassword=HashPassword(txtSifre.Text);
            UpdatePassword(cmbKullanicilar.Text, hashedPassword) ;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

        }

        private void UpdatePassword(string username, string newPassword)
        {
            try
            {


                // SQL sorgusu
                string sqlQuery = $"USE MikroDB_V16 UPDATE KULLANICILAR SET User_PrevPW1 = '{newPassword}' WHERE User_name = '{username}'";

                using (SqlCommand command = new SqlCommand(sqlQuery, bgl.baglan()))
                {
                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();

                    MessageBox.Show("Şifre başarıyla güncellendi.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
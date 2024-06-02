using DevExpress.XtraEditors;
using MikroBarkod.Entities.Repositories;
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

namespace MikroBarkod.Forms.AnaMenu
{
    public partial class FrmYeniKullanici : DevExpress.XtraEditors.XtraForm
    {
        KullanicilarRepository kullanicilarRepository = new KullanicilarRepository();
        public FrmYeniKullanici()
        {
            InitializeComponent();
            lookUpEdit1.Properties.DataSource = kullanicilarRepository.GetKullanicilar();
            lookUpEdit1.Properties.ValueMember = "User_name";
            lookUpEdit1.Properties.DisplayMember = "User_name";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string hashedPassword = HashPassword(txtSifre.Text);
            UpdatePassword(lookUpEdit1.Text, hashedPassword);
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

                kullanicilarRepository.UpdateKullaniSifresi(username, newPassword);
                MessageBox.Show("Şifre başarıyla güncellendi.");




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
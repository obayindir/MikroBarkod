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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Şifreyi hashle
            string hashedPassword = HashPassword(password);

            // Kullanıcıyı doğrula
            if (AuthenticateUser(username, hashedPassword))
            {
                //MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

        }


        private bool AuthenticateUser(string username, string password)
        {

            // Kullanıcı adı ve şifreyi kontrol et
            string query = "USE MikroDB_V16 SELECT COUNT(1) FROM KULLANICILAR WHERE User_name = @Username AND User_PrevPW1 = @Password";
            using (SqlCommand command = new SqlCommand(query, bgl.baglan()))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
           

        }

        private void yeniKullanıcıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniKullanici frmYeniKullanici = new FrmYeniKullanici();
            frmYeniKullanici.ShowDialog();
        }
    }
}
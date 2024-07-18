﻿using DevExpress.XtraEditors;
using MikroBarkod.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod.Forms.AnaMenu
{
    public partial class FrmLogin2 : DevExpress.XtraEditors.XtraForm
    {
        KullanicilarRepository kullanicilarRepository = new KullanicilarRepository();
        bool supervisor = false;
        public FrmLogin2()
        {
            InitializeComponent();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                string hashedPassword = HashPassword(txtSifre.Text);

                if (kullanicilarRepository.GetAuthenticateUser(lookUpKullanicilar.EditValue.ToString(), hashedPassword))
                {
                    this.Hide();
                    if (lookUpKullanicilar.EditValue.ToString() == "SRV")
                    {
                        FrmMainMenu main = new FrmMainMenu(true);
                        main.Show();
                    }
                    else
                    {
                        FrmMainMenu main = new FrmMainMenu(false);
                        main.Show();
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Şifre hatalı veya yetkilendirme yapılmadı. Sistem yöneticisine başvurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmLogin2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FrmYeniKullanici f = new FrmYeniKullanici();
                f.Show();
            }
        }

        private void FrmLogin2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            lookUpKullanicilar.Properties.DataSource = kullanicilarRepository.GetKullanicilar();
            lookUpKullanicilar.Properties.DisplayMember = "User_name";
            lookUpKullanicilar.Properties.ValueMember = "User_name";
        }
    }
}
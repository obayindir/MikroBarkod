using DevExpress.XtraBars;
using MikroBarkod.Forms.Evraklar;
using MikroBarkod.Forms.Prim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod
{
    public partial class FrmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool _supervisor;
        public FrmMainMenu(bool supervisor)
        {
            InitializeComponent();
            _supervisor = supervisor;
            if (_supervisor == false) 
            {
                ribbonPageGroup3.Visible = false;
            }
        }

        private void barBtnSiparisUretim_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSiparisUretim frmMain = new FrmSiparisUretim();
            frmMain.MdiParent = this;
            frmMain.Show();
        }


        private void barBtnFasonaCikisFisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmFasonaCikis frmFason = new FrmFasonaCikis();
            frmFason.MdiParent = this;
            frmFason.Show();

        }

        private void barBtnFasondanGirisFisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmFasondanGiris frmFasondanGiris = new FrmFasondanGiris();
            frmFasondanGiris.MdiParent = this;
            frmFasondanGiris.Show();
        }

        private void barBtnFasonHareketFoyu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmFasonHareket frmFasonHareketFoyu = new FrmFasonHareket();
            //FrmFasonHareket2 frmFasonHareketFoyu = new FrmFasonHareket2();
            frmFasonHareketFoyu.MdiParent = this;
            frmFasonHareketFoyu.Show();
        }

        private void barBtnManuelEtiket_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmYeniEtiket frmYeniEtiket = new FrmYeniEtiket();
            frmYeniEtiket.MdiParent = this;
            frmYeniEtiket.Show();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrimHakedisRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmPrimAnaEkran frmPrimRaporu = new FrmPrimAnaEkran();
            frmPrimRaporu.MdiParent = this;
            frmPrimRaporu.Show();
        }
    }
}
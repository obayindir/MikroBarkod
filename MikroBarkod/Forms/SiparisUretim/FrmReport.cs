using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FrmReport : DevExpress.XtraEditors.XtraForm
    {
        public FrmReport(XtraReport barkod)
        {
            InitializeComponent();
            documentViewer1.DocumentSource= barkod;

        }
    }
}
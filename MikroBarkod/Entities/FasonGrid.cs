using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikroBarkod.Entities
{
    public class FasonGrid
    {
        public Guid sth_Guid { get; set; }
        public string sth_stok_kod { get; set; }
        public string sto_isim { get; set; }
        public int sth_miktar { get; set; }
        public string sto_birim1_ad { get; set; }
        
        public string sth_HareketGrupKodu1 { get; set; }
        public string depo_no { get; set; }
        public string sth_aciklama { get; set; }
    }
}

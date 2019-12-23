using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class TransferListContract
    {
        //h.dosyano,
        //h.ad,
        //h.soyad,
        //k.ad as doktor,
        //s.sevktarihi as baslangictarihi,
        //c.cikistarihi as bitistarihi,
        //p.poliklinikadi,
        //s.taburcu,
        //c.odeme,
        //c.toplamtutar

        public int DosyaNo { get; set; }
        public string HastaAdı { get; set; }
        public string HastaSoyadı { get; set; }
        public string DoktorAdı { get; set; }
        public DateTime SevkTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string PoliklinikAdi { get; set; }
        public string Taburcu { get; set; }
        public string odeme { get; set; }
        public double ToplamTutar { get; set; }
        public string Tckimlikno { get; set; }
    }
}

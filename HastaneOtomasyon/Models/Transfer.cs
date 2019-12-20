using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class Transfer
    {
        #region private members
        private DateTime sevkTarihi;
        private int dosyaNo;
        private string poliklinik;
        private DateTime saat;
        private string yapilanIslem;
        private int drKod;
        private int miktar;
        private int birimFiyat;
        private int sira;
        private int toplamTutar;
        private string taburcu;
        #endregion
        #region public members
        public DateTime SevkTarihi
        {
            get
            {
                return sevkTarihi;
            }
            set
            {
                sevkTarihi = value;
            }
        }
        public int DosyaNo
        {
            get
            {
                return dosyaNo;
            }
            set
            {
                dosyaNo = value;
            }
        }
        public string Poliklinik
        {
            get
            {
                return poliklinik;
            }
            set
            {
                poliklinik = value;
            }
        }
        public DateTime Saat
        {
            get
            {
                return saat;
            }
            set
            {
                saat = value;
            }
        }
        public string YapilanIslem
        {
            get
            {
                return yapilanIslem;
            }
            set
            {
                yapilanIslem = value;
            }
        }
        public int DrKod
        {
            get
            {
                return drKod;
            }
            set
            {
                drKod = value;
            }
        }
        public int Miktar
        {
            get
            {
                return miktar;
            }
            set
            {
                miktar = value;
            }
        }
        public int BirimFiyat
        {
            get
            {
                return birimFiyat;
            }
            set
            {
                birimFiyat = value;
            }
        }
        public int Sira
        {
            get
            {
                return sira;
            }
            set
            {
                sira = value;
            }
        }
        public int ToplamTutar
        {
            get
            {
                return toplamTutar;
            }
            set
            {
                toplamTutar = value;
            }
        }
        public string Taburcu
        {
            get
            {
                return taburcu;
            }
            set
            {
                taburcu = value;
            }
        }
        #endregion
    }
}

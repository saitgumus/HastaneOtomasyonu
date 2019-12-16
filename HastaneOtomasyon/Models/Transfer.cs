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
        private string sevkTarihi;
        private string dosyaNo;
        private string poliklinik;
        private string saat;
        private string yapilanIslem;
        private string drKod;
        private string miktar;
        private string birimFiyat;
        private string sira;
        private string toplamTutar;
        private string taburcu;
        #endregion
        #region public members
        public string SevkTarihi
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
        public string DosyaNo
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
        public string Saat
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
        public string DrKod
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
        public string Miktar
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
        public string BirimFiyat
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
        public string Sira
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
        public string ToplamTutar
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

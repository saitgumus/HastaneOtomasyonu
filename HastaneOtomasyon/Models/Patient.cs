using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
   public class Patient
    {

        #region private members
        private string tcKimlikNo;
        private string dosyaNo;
        private string ad;
        private string soyad;
        private string dogumYeri;
        private DateTime dogumTarihi;
        private string babaAdi;
        private string anneAdi;
        private string cinsiyet;
        private string kanGrubu;
        private string medeniHal;
        private string adres;
        private string tel;
        private string kurumSicilNo;
        private string kurumAdi;
        private string yakinTel;
        private string yakinKurumSicilNo;
        private string yakinKurumAdi;
        #endregion
        #region Public members
        public string TcKimlikNo
        {
            get
            {
                return tcKimlikNo;
            }
            set
            {
                tcKimlikNo = value;
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
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string DogumYeri
        {
            get
            {
                return dogumYeri;
            }
            set
            {
                dogumYeri = value;
            }
        }
        public DateTime DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                dogumTarihi = value;
            }
        }
        public string BabaAdi
        {
            get
            {
                return babaAdi;
            }
            set
            {
                babaAdi = value;
            }
        }
        public string AnneAdi
        {
            get
            {
                return anneAdi;
            }
            set
            {
                anneAdi = value;
            }
        }
        public string Cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public string KanGrubu
        {
            get
            {
                return kanGrubu;
            }
            set
            {
                kanGrubu = value;
            }
        }
        public string MedeniHal
        {
            get
            {
                return medeniHal;
            }
            set
            {
                medeniHal = value;
            }
        }
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }
        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }
        public string KurumSicilNo
        {
            get
            {
                return kurumSicilNo;
            }
            set
            {
                kurumSicilNo = value;
            }
        }
        public string KurumAdi
        {
            get
            {
                return kurumAdi;
            }
            set
            {
                kurumAdi = value;
            }
        }
        public string YakinTel
        {
            get
            {
                return yakinTel;
            }
            set
            {
                yakinTel = value;
            }
        }
        public string YakinKurumSicilNo
        {
            get
            {
                return yakinKurumSicilNo;
            }
            set
            {
                yakinKurumSicilNo = value;
            }
        }
        public string YakinKurumAdi
        {
            get
            {
                return yakinKurumAdi;
            }
            set
            {
                yakinKurumAdi = value;
            }
        }
        #endregion
    }
}

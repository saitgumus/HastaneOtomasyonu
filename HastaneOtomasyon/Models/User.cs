using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
   public class User
    {
        #region private members
        private string kodu;
        private string ad;
        private string soyad;
        private string sifre;
        private string yetki;
        private string evtel;
        private string ceptel;
        private string adres;
        private string unvan;
        private DateTime iseBaslama;
        private string maas;
        private string dogumYeri;
        private string anneAd;
        private string babaAd;
        private string cinsiyet;
        private string kanGrubu;
        private string medeniHal;
        private DateTime dogumTarihi;
        private string tcKimlikNo;
        private string userName;
        #endregion

        #region Public Members
        public String Kodu
        {
            get
            {
                return kodu;
            }
            set
            {
                kodu = value;
            }
        }
        public String Ad
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
        public String Soyad
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
        public String Sifre
        {
            get
            {
                return sifre;
            }
            set
            {
                sifre = value;
            }
        }
        public String Yetki
        {
            get
            {
                return yetki;
            }
            set
            {
                yetki = value;
            }
        }
        public String Evtel
        {
            get
            {
                return evtel;
            }
            set
            {
                evtel = value;
            }
        }
        public String CepTel
        {
            get
            {
                return ceptel;
            }
            set
            {
                ceptel = value;
            }
        }
        public String Adres
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
        public String Unvan
        {
            get
            {
                return unvan;
            }
            set
            {
                unvan = value;
            }
        }
        public DateTime IseBaslama
        {
            get
            {
                return iseBaslama;
            }
            set
            {
                iseBaslama = value;
            }
        }
        public String Maas
        {
            get
            {
                return maas;
            }
            set
            {
                maas = value;
            }
        }
        public String DogumYeri
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
        public String AnneAd
        {
            get
            {
                return anneAd;
            }
            set
            {
                anneAd = value;
            }
        }
        public String BabaAd
        {
            get
            {
                return babaAd;
            }
            set
            {
                babaAd = value;
            }
        }
        public String Cinsiyet
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
        public String KanGrubu
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
        public String MedeniHal
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
        public String TcKimlikNo
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
        public String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        #endregion
    }
}

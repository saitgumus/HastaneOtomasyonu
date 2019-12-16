using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class Discharged
    {

        #region private members
        private string dosyaNo;
        private string sevkTarihi;
        private DateTime cikisTarihi;
        private string odeme;
        private string toplamTutar;
        #endregion
        #region public members
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

        public DateTime CikisTarihi
        {
            get
            {
                return cikisTarihi;
            }
            set
            {
                cikisTarihi = value;
            }
        }

        public string Odeme
        {
            get
            {
                return odeme;
            }
            set
            {
                odeme = value;
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
        #endregion
    }
}

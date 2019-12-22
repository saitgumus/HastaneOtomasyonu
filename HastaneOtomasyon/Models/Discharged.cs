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
        private int dosyaNo;
        private DateTime sevkTarihi;
        private DateTime cikisTarihi;
        private string odeme;
        private int toplamTutar;
        #endregion
        #region public members
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
        #endregion
    }
}

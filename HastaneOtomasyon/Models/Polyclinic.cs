using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class Polyclinic
    {

        #region private members

        private string poliklinikAdi;
        private string durum;
        private string aciklama;
        #endregion
        #region public members
        public string PoliklinikAdi
        {
            get
            {
                return poliklinikAdi;
            }
            set
            {
                poliklinikAdi = value;
            }
        }
        public string Durum
        {
            get
            {
                return durum;
            }
            set
            {
                durum = value;
            }
        }
        public string Aciklama
        {
            get
            {
                return aciklama;
            }
            set
            {
                aciklama = value;
            }
        }
        #endregion
    }
}

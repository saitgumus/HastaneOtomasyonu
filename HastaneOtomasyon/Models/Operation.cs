﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
   public class Operation
    {
        #region private members

        private string islemAdi;
        private int birimFiyat;
        #endregion
        
        #region Public members

        public string IslemAdi
        {
            get
            {
                return islemAdi;
            }
            set
            {
                islemAdi = value;
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
        #endregion
    }
}

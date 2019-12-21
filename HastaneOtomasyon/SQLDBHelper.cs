using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    public static class SQLDBHelper
    {
        public static int GetIntValue(object o)
        {
            if (o == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return (int) o;
            }
        }

        public static DateTime GetDateTimeValue(object o)
        {
            if (o == DBNull.Value)
            {
                return new DateTime();
            }
            else
            {
                return (DateTime) o;
            }
        }

        public static string GetStringValue(object o)
        {
            return o.ToString();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class GenericResponse
    {
        public bool Success;
        public object Value;
        public string ErrorMessage;

        public GenericResponse(object obj)
        {
            this.Value = obj;
        }
    }
}

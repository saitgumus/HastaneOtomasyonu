using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    public class GenericResponse<T>
    {
        public bool Success;
        public T Value;
        public string ErrorMessage;

        public GenericResponse()
        {
        }
        public GenericResponse(T obj)
        {
            this.Value = obj;
        }
    }
}

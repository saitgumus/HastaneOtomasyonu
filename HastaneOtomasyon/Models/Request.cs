using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HastaneOtomasyon.Models
{
    public class Request<T,R>
    {
        public T DataContract { get; set; }
        private MethodInfo method;
        private Type mtype;
        private string methodName;
        private DBServices db;
        public string MethodName
        {
            get { return methodName; }
            set {
                mtype = typeof(DBServices);
                mtype = db.GetType();
                method = mtype.GetMethod(value);
                }
        }

        public Request()
        {
            db = DBServices.ConnectToService();
        }

        /// <summary>
        /// geri değer döndüren
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public GenericResponse<R> Execute(Object[] o)
        {
            return (GenericResponse<R>)method.Invoke(db,o);
        }

        /// <summary>
        /// değer döndürmeyen method
        /// </summary>
        /// <returns></returns>
        public GenericResponse<R> Execute()
        {
            return (GenericResponse<R>)method.Invoke(db,null);
        }

    }
}

using MyEvernote.DataAcessLayer.dll.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.EntityFreamwork
{
    public class RepostoryBase
    {
        private static DatabaseContex _db;
        private static object _obj = new object();
        protected RepostoryBase()
        {
          
        }

        public static DatabaseContex CreateContex()
        {
            if (_db == null)
            {
                lock (_obj)
                {
                    if (_db == null)
                    {
                        _db = new DatabaseContex();
                    }
                }
            }
            return _db;
            
        }
    }
}

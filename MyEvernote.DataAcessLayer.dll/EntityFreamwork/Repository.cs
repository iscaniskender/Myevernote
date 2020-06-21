using MyEvernote.DataAcessLayer.dll.Abstrack;
using MyEvernote.DataAcessLayer.dll.EntityFreamwork;
using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.EntityFreamwork
{
    public class Repository<T> : IRepostory<T> where T : class
    {
        private DatabaseContex db;
        private DbSet<T> _objectSet;

        public Repository()
        {
            db=RepostoryBase.CreateContex();
            _objectSet = db.Set<T>();
        }
        public List<T> List() 
        {  
           
            return _objectSet.ToList();
        }
        public List<T> List(Expression<Func<T,bool>> where)
        {
          return  _objectSet.Where(where).ToList();
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }
        public int Update(T obj)
        {
            return Save();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}

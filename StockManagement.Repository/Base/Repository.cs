using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockeManagement.Models.DatabaseContext;
using StockManagement.Models.Contracts;

namespace StockManagement.Repository.Base
{
    public abstract class Repository<T>:IDisposable where T:class 
    {
        protected StockDBContext db = new StockDBContext();
        public virtual bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Remove(IDeletable entity)
        {
            entity.IsDeleted = true;
            return Update((T)entity);
        }

        public virtual bool Remove(ICollection<IDeletable> entitys)
        {
            int removeCount = 0;
            foreach (var deleteEntity in entitys)
            {
                bool isRemoved = Remove(entitys);
                if (isRemoved)
                {
                    removeCount++;
                }
            }
            return entitys.Count ==  removeCount;
        }

        public virtual ICollection<T> GetAll(bool withDeleted = false)
        {
            return db.Set<T>().ToList();
        }

        public virtual ICollection<T> Get(Expression<Func<T, bool>> query)
        {
            return db.Set<T>().Where(query).ToList();
        }

        public virtual T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public virtual void Dispose()
        {
            db?.Dispose();
        }
    }

    public abstract class DeletableRepository<T>:Repository<T> where T : class, IDeletable
    {
        public override ICollection<T> GetAll(bool withDeleted = false)
        {
            return db.Set<T>().Where(c => c.IsDeleted == false || c.IsDeleted == withDeleted).ToList();
        } 
    }
}

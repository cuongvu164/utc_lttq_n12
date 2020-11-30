using LTTQ_BTL_N12.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_BTL_N12.Core.Repos
{
    public abstract class BaseRepo<E> where E : class
    {
        QuanLyThueBangDiaEntities context;

        protected BaseRepo()
        {
            context = new QuanLyThueBangDiaEntities();
        }

        public bool Add(E entity)
        {
            context.Set<E>().Add(entity);
            return Commit();
        }

        public bool AddAll(IEnumerable<E> entities)
        {
            foreach (var entity in entities)
            {
                context.Set<E>().Add(entity);
            }

            return Commit();
        }

        public bool Delete(object id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var ent = Find(id);
                    context.Set<E>().Remove(ent);
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }

            }
        }

        public E Find(object id)
        {
            return context.Set<E>().Find(id);
        }

        public IEnumerable<E> FindAll()
        {
            return context.Set<E>().ToList();
        }

        public bool Update(E entity)
        {
            context.Set<E>().AddOrUpdate(entity);
            return Commit();
        }

        private bool Commit()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

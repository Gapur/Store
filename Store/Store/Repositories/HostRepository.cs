/*
 * Created by: Kassym Gapur
 * Created: 26.01.2015
 */

using System;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Collections.Generic;

namespace Store.Repositories
{
    using EntityModels;

    public class HostRepository : IHostRepository
    {
        private Entities context;

        private Entities Context
        {
            get
            {
                return context ?? (context = new Entities());
            }
        }

        #region Set's

        public IEnumerable<T> Set<T>(Expression<Func<T, bool>> lamda) where T : class
        {
            return Context.Set<T>().Where(lamda.Compile());
        }

        public IEnumerable<TE> Set<T, TE>(Expression<Func<T, bool>> lamda)
            where T : class
            where TE : class
        {
            return (IEnumerable<TE>)Context.Set<T>().Where(lamda.Compile());
        }

        public IEnumerable<TE> Set<T, TE>(Expression<Func<T, TE>> lamda)
            where T : class
            where TE : class
        {
            return (IEnumerable<TE>)Context.Set<T>().Select(lamda.Compile());
        }

        public T Entity<T>(Expression<Func<T, bool>> lamda) where T : class
        {
            return Context.Set<T>().SingleOrDefault(lamda.Compile());
        }

        #endregion

        public T Add<T>(T entity) where T : class
        {
            var e = Context.Set<T>().Add(entity);
            SaveChanges();
            return e;
        }

        public bool Add<T, TS, TT>(T firstEntity, TS secondEntity, TT thirdEntity)
            where T : class
            where TS : class
            where TT : class
        {
            Context.Set<T>().Add(firstEntity);
            Context.Set<TS>().Add(secondEntity);
            Context.Set<TT>().Add(thirdEntity);
            return SaveChanges();
        }

        public bool Add<T>(ref T entity) where T : class
        {
            Context.Set<T>().Add(entity);
            return SaveChanges();
        }

        public T Update<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
            return entity;
        }

        public bool Update<T>(ref T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        IDisposable IHostRepository.Context()
        {
            return Context;
        }

        private bool SaveChanges()
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();

                var dbException = ex as DbEntityValidationException;

                if (dbException == null) throw;

                foreach (var failure in dbException.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" + sb, ex);
            }
        }
    }
}

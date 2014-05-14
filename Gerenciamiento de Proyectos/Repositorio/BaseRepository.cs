using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AccesoaDatos;
using Dominio;
using Log;


namespace Repositorio.Interfaces
{
    public abstract class BaseRepository<T> : IRepository<T> 
        where T : BaseModel
    {
        private GerencimientoProyectosContext _gerencimientoProyectosContext;

        protected virtual GerencimientoProyectosContext GerencimientoProyectosContext
        {
            get
            {
                if (_gerencimientoProyectosContext == null)
                {
                    _gerencimientoProyectosContext = new GerencimientoProyectosContext();
                }
                return _gerencimientoProyectosContext;
            }
        }

        public List<T> GetAll()
        {
            try
            {
                return (List<T>)GerencimientoProyectosContext.Set<T>().ToList();
            }
            catch (Exception e)
            {
                var log = new Logger();
                log.WriteLog(e.ToString());
                return null;
            }  
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return GerencimientoProyectosContext.Set<T>().FirstOrDefault(predicate);
            }
            catch (Exception e)
            {
                var log = new Logger();
                log.WriteLog(e.ToString());
                return null;
            }
        }

        public int Create(T entity)
        {
            try
            {
                GerencimientoProyectosContext.Set<T>().Add(entity);
                return GerencimientoProyectosContext.SaveChanges();
            }
            catch (Exception e)
            {
                var log = new Logger();
                log.WriteLog(e.ToString());
                return 0;
            }
        }

        public int Update(T entity)
        {
            try
            {
                GerencimientoProyectosContext.Entry(entity).State = EntityState.Modified;
                return GerencimientoProyectosContext.SaveChanges();
            }
            catch (Exception e)
            {
                var log = new Logger();
                log.WriteLog(e.ToString());
                return 0;
            }
        }

        public int Delete(T entity)
        {
            try
            {
                GerencimientoProyectosContext.Entry(entity).State = EntityState.Deleted;
                return GerencimientoProyectosContext.SaveChanges();
            }
            catch (Exception e)
            {
                var log = new Logger();
                log.WriteLog(e.ToString());
                return 0;
            }
        }

    }
}

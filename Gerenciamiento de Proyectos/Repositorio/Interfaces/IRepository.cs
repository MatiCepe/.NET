using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AccesoaDatos;
using Dominio;

namespace Repositorio
{
    interface IRepository<T> 
        where T : BaseModel
    {
        List<T> GetAll();
        T Single(Expression<Func<T, bool>> predicate);
        int Create( T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}

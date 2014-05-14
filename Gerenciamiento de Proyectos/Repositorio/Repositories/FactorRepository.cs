using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Repositorio.Interfaces;
using Dominio;
using AccesoaDatos;

namespace Repositorio
{
    public class FactorRepository : BaseRepository<Factor>, IFactorRepository
    {
        public Factor GetByID(int id)
        {
            return GerencimientoProyectosContext.Set<Factor>()
                .FirstOrDefault(x => x.FactorId == id);
        }
    }
}

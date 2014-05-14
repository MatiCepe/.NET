using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoaDatos;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class GerenteRepository : BaseRepository<Gerente>, IGerenteRepository
    {
        public Gerente GetByID(int id)
        {
            return GerencimientoProyectosContext.Set<Gerente>()
                .FirstOrDefault(x => x.GerenteId == id);
            
        }
    }
}

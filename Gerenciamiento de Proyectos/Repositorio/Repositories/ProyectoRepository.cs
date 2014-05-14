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
    public class ProyectoRepository : BaseRepository<Proyecto>, IProyectoRepository
    {
        public Proyecto GetByID(int id)
        {
                return GerencimientoProyectosContext.Set<Proyecto>()
                    .FirstOrDefault(x => x.ProyectoId == id);
        }
    }
}
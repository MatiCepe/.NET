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
    public class ValorRepository : BaseRepository<Valor>, IValorRepository
    {
        public Valor GetByID(int id)
        {
            return GerencimientoProyectosContext.Set<Valor>()
                .FirstOrDefault(x => x.ValorId == id);

        }
    }
}
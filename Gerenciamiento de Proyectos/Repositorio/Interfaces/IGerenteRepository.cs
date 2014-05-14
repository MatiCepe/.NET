using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio.Interfaces
{
    public interface IGerenteRepository
    {
        Gerente GetByID(int id);
    }
}
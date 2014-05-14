using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProyectoFactor
    {
        public int ProyectoFactorId { get; set; }

        public virtual Factor Factor { get; set; }

        public virtual Valor ValorSeleccionado { get; set; }
    }
}

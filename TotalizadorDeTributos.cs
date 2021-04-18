using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumular(ITributacao t)
        {
            Total += t.CalcularTributo();           
        }
    }
}

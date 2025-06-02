using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class Kilo : TipoTamaño
    {
        public Kilo(string tamaño, double preciotamaño) : base(tamaño, preciotamaño)
        {
        }

        public override double PrecioTamanio() 
        {
             return PrecioTamaño;
        }
    }
}

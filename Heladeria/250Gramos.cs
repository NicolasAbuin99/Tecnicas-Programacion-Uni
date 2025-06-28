using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class DosCincuentaGramos : TipoTamaño
    {
        public DosCincuentaGramos(string tamaño, double preciotamaño) : base(tamaño, preciotamaño) // Constructor de la clase, llama al constructor de la clase base (TipoTamaño).
        {
            // ': base(tamaño, preciotamaño)' llama al constructor de la clase base (TipoTamaño)
            // y le pasa los valores de 'tamaño' y 'preciotamaño'.
            // Esto asegura que las propiedades _tamaño y _precioTamaño de la clase base se inicialicen correctamente.
        }
        public override double PrecioTamanio() // Sobrescribe el método PrecioTamanio de la clase base.
        {
            return PrecioTamaño;
        }
    }
}

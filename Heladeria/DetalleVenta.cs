using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class DetalleVenta
    {
		private TipoTamaño _tipoTamaños;

		public TipoTamaño TipoTamaños
		{
			get { return _tipoTamaños; }  // Obtiene el valor de _tipoTamaños.
            set { _tipoTamaños = value; } // Establece el valor de _tipoTamaños.
        }

		private Helado _helados;

		public Helado Helados
		{
			get { return _helados; } // Obtiene el valor de _helados
            set { _helados = value; } // Establece el valor de _helados
        }

		public double PrecioTotal() 
		{
            return Helados.PrecioHelado(); // Retorna el precio calculado por el método PrecioHelado() del objeto Helado asociado a este detalle.
        }

	}
}

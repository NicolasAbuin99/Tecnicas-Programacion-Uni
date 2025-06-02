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
			get { return _tipoTamaños; }
			set { _tipoTamaños = value; }
		}

		private Helado _helados;

		public Helado Helados
		{
			get { return _helados; }
			set { _helados = value; }
		}

		public double PrecioTotal() 
		{
            return Helados.PrecioHelado();
        }

	}
}

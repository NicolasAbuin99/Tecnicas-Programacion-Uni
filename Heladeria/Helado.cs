using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class Helado
    {
		private TipoTamaño _tipoTamaño;

		public TipoTamaño tipoTamaño
		{
			get { return _tipoTamaño; }
			set { _tipoTamaño = value; }
		}

		private string _sabor;

		public string Sabor
		{
			get { return _sabor; }
			set { _sabor = value; }
		}

		private double _precio;

		public double Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		

		public Helado (TipoTamaño tipotamaño,string sabor, double precio)
		{
			this._tipoTamaño = tipotamaño;
			this._sabor = sabor;
            this._precio = precio;
        }

		public double PrecioHelado()
		{
			return Precio + _tipoTamaño.PrecioTamaño;
		}
	}
}

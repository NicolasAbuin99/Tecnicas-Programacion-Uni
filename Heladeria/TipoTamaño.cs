using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public abstract class TipoTamaño
    {
		private string _tamaño;

		public string Tamaño
		{
			get { return _tamaño; }
			set { _tamaño = value; }
		}

		private double _precioTamaño;

		public double PrecioTamaño
		{
			get { return _precioTamaño; }
			set { _precioTamaño = value; }
		}
		public TipoTamaño(string tamaño,double preciotamaño)
		{
			this._tamaño = tamaño;
			this._precioTamaño = preciotamaño;
		}
		public virtual double PrecioTamanio() 
		{
			return PrecioTamaño;
		}

	}
}

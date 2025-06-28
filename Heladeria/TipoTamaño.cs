using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    //Es una clase abstract porque representa un concepto general ("tipo de tamaño")
	//pero no un tamaño específico en sí mismo;
	//los tamaños específicos heredarán de ella.
    public abstract class TipoTamaño // Abstracta significa que no se pueden crear instancias directamente de ella,
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
		public TipoTamaño(string tamaño,double preciotamaño) // Se llama cuando se crea una nueva instancia de una clase que hereda de TipoTamaño.
        {
			this._tamaño = tamaño;
			this._precioTamaño = preciotamaño;
		}
		public virtual double PrecioTamanio() // Método virtual que puede ser sobrescrito por las clases derivadas.
        {
			return PrecioTamaño;
		}
        // 'virtual' permite que las clases hijas lo "override" (sobrescriban)
    }
}

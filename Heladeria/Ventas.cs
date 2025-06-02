using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class Ventas
    {
		private string _nombreCliente;

		public string NombreCliente
		{
			get { return _nombreCliente; }
			set { _nombreCliente = value; }
		}

		private string _ticket;

		public string Ticket
		{
			get { return _ticket; }
			set { _ticket = value; }
		}
		
		public List<DetalleVenta> DetallesVentas = new List<DetalleVenta>();

		private DateTime _fechaVenta;

		public DateTime FechaVenta
		{
			get { return _fechaVenta; }
			set { _fechaVenta = value; }
		}

		public Ventas(string nombrecliente, string ticket, DateTime fechaventa)
		{
			this._nombreCliente = nombrecliente;
			this._ticket = ticket;
			this._fechaVenta = fechaventa;
		}
		public void FechaVentas()
		{
			FechaVenta = DateTime.Now;
		}
	}
}

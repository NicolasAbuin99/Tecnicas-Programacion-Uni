using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    public class MiHeladeria : Iheladeria
    {
		public List<Helado> ListaHelados = new List<Helado>();
        public List<Ventas> ListaVentas = new List<Ventas>();
        public List<string> ListaSabores = new List<string>();

        public List<Ventas> ObtenerTodasLasVentas()
        {
            return ListaVentas;
        }
        public void AgregarSabor(string nuevoSabor)
        {
            ListaSabores.Add(nuevoSabor);
        }

        public void CargarSaboresIniciales()
        {
            ListaSabores.Add("Chocolate");
            ListaSabores.Add("Vainilla");
            ListaSabores.Add("Frutilla");
            ListaSabores.Add("Crema Granizada");
            ListaSabores.Add("Menta");
            ListaSabores.Add("Banana");
        }
        public void AgregarHelado(TipoTamaño tipoTamaño,string sabor,double precio)
        {
            ListaHelados.Add(new Helado(tipoTamaño, sabor, precio));
        }

        public Ventas RegistrarVenta(string nombrecliente)
        {
            Ventas nuevaVenta = new Ventas(nombrecliente, DateTime.Now.ToString("yyyyMMddHHmmss"), DateTime.Now);
            ListaVentas.Add(nuevaVenta);
            return nuevaVenta;
        }

        public void AgregarDetalleVenta(Ventas venta, Helado helado, TipoTamaño tipoTamaño)
        {
            DetalleVenta detalle = new DetalleVenta() { Helados = helado, TipoTamaños = tipoTamaño};
            venta.DetallesVentas.Add(detalle);
        }

        public double TotalRecaudado()
        {
            double totalRecaudado = 0;

            foreach (Ventas venta in ListaVentas)
            {
                foreach (DetalleVenta detalle in venta.DetallesVentas)
                {
                    totalRecaudado += detalle.PrecioTotal(); //acumula el precio
                }
            }

            return totalRecaudado;
        }

        public List<Ventas> ListaPedidos()
        {
            return ListaVentas;
        }

        public string SaborMasPedidio()
        {
            List<string> sabores = new List<string>();
            List<int> conteoSabores = new List<int>();
            foreach (Ventas venta in ListaVentas)
            {
                foreach (DetalleVenta detalle in venta.DetallesVentas)
                {
                    string sabor = detalle.Helados.Sabor;

                    int indiceSabor = sabores.IndexOf(sabor);

                    if (indiceSabor != -1)
                    {
                        conteoSabores[indiceSabor]++;
                    }
                    else
                    {
                        sabores.Add(sabor); // Agregar el sabor a la lista
                        conteoSabores.Add(1);
                    }
                }
            }

            int indiceMax = 0;
            int Max = conteoSabores[0];

            for (int i = 1; i < conteoSabores.Count; i++)
            {
                if (conteoSabores[i]> Max)
                {
                    Max = conteoSabores[i];
                    indiceMax = i;
                }
            }

            return sabores[indiceMax];
        }

        public string TamañoMasVendido()
        {
            List<string> tamaños = new List<string>();
            List<int> conteoTamaños = new List<int>();

            foreach (Ventas venta in ListaVentas)
            {
                foreach (DetalleVenta detalle in venta.DetallesVentas)
                {
                    string tamaño = detalle.TipoTamaños.Tamaño;

                    int indiceTamaño = tamaños.IndexOf(tamaño);

                    if (indiceTamaño != -1)
                    {
                        conteoTamaños[indiceTamaño]++;
                    }else
                    {
                        tamaños.Add(tamaño); //Esta lista almacena los nombres de los diferentes tamaños de helado que se han vendido
                        conteoTamaños.Add(1); //Esta lista almacena la cantidad de veces que se ha vendido cada tamaño de helado
                    }
                }
            }

            int indiceMax = 0;
            int MaxConteo = conteoTamaños[0];

            for(int i = 0; i < conteoTamaños.Count; i++)
            {
                if (conteoTamaños[i] > MaxConteo)
                {
                    MaxConteo = conteoTamaños[i];
                    indiceMax = i;
                }
            }

            return tamaños[indiceMax];
        }
        
        public double ticketPromedio()
        {
            double total = 0;
            foreach (Ventas venta in ListaVentas)
            {
                double totalVenta = 0;
                foreach (DetalleVenta detalle in venta.DetallesVentas)
                {
                    totalVenta = totalVenta + detalle.PrecioTotal();
                }
                total = total + totalVenta;
            }

            return total / ListaVentas.Count;
        }
    }
}

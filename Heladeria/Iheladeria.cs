using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria
{
    internal interface Iheladeria
    {
        public List<Ventas> ObtenerTodasLasVentas();
     
        public void AgregarSabor(string nuevoSabor);

        public void CargarSaboresIniciales();
       
        public void AgregarHelado(TipoTamaño tipoTamaño, string sabor, double precio);

        public Ventas RegistrarVenta(string nombrecliente);

        public double TotalRecaudado();

        public string SaborMasPedidio();

        public string TamañoMasPedido();

        public double ticketPromedio();

    }
}

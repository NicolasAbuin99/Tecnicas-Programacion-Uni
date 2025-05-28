using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocecionariosCoches
{
    public interface Icoches
    {
        void AgregarLista(string modelo, string color, int precio);
        List<Coches> ObtenerLista();
        void ComprarCoches(int indice);
    }
}

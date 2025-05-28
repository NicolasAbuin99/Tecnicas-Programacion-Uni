using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocecionariosCoches
{
    public class GestorCoche : Icoches
    {
        private List<Coches> _coches= new List<Coches> ();
       
        public void AgregarLista(string modelo, string color, int precio)
        {
            _coches.Add(new Coches(modelo, color, precio));
        }

        public void ComprarCoches(int indice)
        {
            if(indice>=00 && indice<= _coches.Count)
            {
                _coches.RemoveAt(indice);
            }
        }

        public List<Coches> ObtenerLista()
        {
            return _coches;
        }
    }
}

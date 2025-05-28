using CocecionariosCoches;
using System.Collections.Generic; // Asegúrate de que esta línea esté presente
using System.Windows.Forms; // Asegúrate de que esta línea esté presente
namespace ConcecionarioCoches
{
    public partial class Form1 : Form
    {
        GestorCoche gestor = new GestorCoche();
        //la declaro fuera del form1 para que cada metodo la pueda usar
        public Form1()
        {
            InitializeComponent(); 
        }

        private void txtAgregar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLista_Click(object sender, EventArgs e)
        {


            List<Coches> coche = gestor.ObtenerLista();
            if (coche.Count == 0)
            {
                MessageBox.Show("No hay coches");
            }
            else
            {
                MessageBox.Show("La lista de coches: ");
                for (int i = 0; i < coche.Count; i++)
                {
                    MessageBox.Show(coche[i].Modelo, coche[i].Color, (MessageBoxButtons)coche[i].Precio);
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seleccionador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //debo primero declarar variables y despues les asigno el txt
                string modelo = txtModelo.Text;
                string color = txtColor.Text;
                int precio = int.Parse(txtPrecio.Text); //parseo el txt a entero
                gestor.AgregarLista(modelo, color, precio);
                MessageBox.Show("Coche agregado");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error");
                throw;
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = int.Parse(Seleccionador.Text);
                gestor.ComprarCoches(indice);
                MessageBox.Show("La compra se realizo");
            }
            catch (IndexOutOfRangeException rf)
            {
                MessageBox.Show("Error, no tenemos ese auto");
                throw;
            }
        }
    }
}
//MessageBox.Show se usa para mostrar mensajes cortos y confirmaciones, no para listar datos.
//Si lo usas en un bucle, te aparecerá una ventana emergente por cada coche, lo cual es muy molesto para el usuario.
//La mejor manera de mostrar una lista de elementos en una aplicación de Windows Forms es usando un control ListBox
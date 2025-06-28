using Heladeria;
using System.Collections.Generic; 
using System.Windows.Forms; 
namespace ProyectoHelados
{
    public partial class Form1 : Form
    {
        MiHeladeria miHeladeria = new MiHeladeria();
        //public List<DetalleVenta> pedidoActual = new List<DetalleVenta>();
        public List<string> ListaSabores = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
            CargarTipoTamaños();
            miHeladeria.CargarSaboresIniciales();
            CargarSabores();
        }

        private void CargarTipoTamaños() // Método privado para poblar el ComboBox de tamaños.
        {
            cmbTamaño.Items.Add(new DosCincuentaGramos("250 Gramos", 200));
            cmbTamaño.Items.Add(new MedioKilo("Medio Kilo", 350));
            cmbTamaño.Items.Add(new Kilo("Kilos", 500));
            cmbTamaño.DisplayMember = "Tamaño";
        }
        
        private void CargarSabores() // Método privado para poblar el CheckedListBox de sabores.
        {
            clbSabores.Items.Clear(); 
            foreach (var sabor in miHeladeria.ListaSabores)
            {
                clbSabores.Items.Add(sabor);
            }
        }

        public void MostrarPedidos()
        {
            try
            {
                List<Ventas> todaslasventas = miHeladeria.ObtenerTodasLasVentas(); // Obtiene la lista de todas las ventas de miHeladeria.
                // Limpiar el DataGridView
                 dataGridView1.Rows.Clear();
       
                dataGridView1.Columns.Add("Cliente", "Cliente");
                dataGridView1.Columns.Add("Fecha", "Fecha");
                dataGridView1.Columns.Add("Ticket", "Ticket");
                dataGridView1.Columns.Add("Tamaños", "Tamaños");
                dataGridView1.Columns.Add("Sabores", "Sabores");
                dataGridView1.Columns.Add("Total", "Total");

                foreach (Ventas venta in todaslasventas)
                {
                    string tamaño = ""; // Acumulo los tamaños de los helados en esta venta.
                    string sabores = "";
                    double totalventa = 0;

                    foreach (DetalleVenta detalle in venta.DetallesVentas)
                    {
                        tamaño += detalle.TipoTamaños.Tamaño + ", "; //Acumula el tamaño 
                        sabores += detalle.Helados.Sabor + ", ";
                        totalventa += detalle.PrecioTotal();
                    }
                    dataGridView1.Rows.Add(venta.NombreCliente, venta.FechaVenta, venta.Ticket, tamaño, sabores, totalventa);
                    //Agrega una nueva fila al DataGridView con los datos que has calculado para cada venta
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar pedidios");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string nombre = txtNombre.Text;

                TipoTamaño tamañoSeleccionado = (TipoTamaño)cmbTamaño.SelectedItem; // Obtiene el elemento seleccionado del ComboBox y lo convierte a TipoTamaño.

                Ventas nuevaVenta = miHeladeria.RegistrarVenta(nombre); // Registra una nueva venta en miHeladeria con el nombre del cliente y obtiene la venta creada.


                foreach (string SaborElegido in clbSabores.CheckedItems) // Itera a través de los sabores seleccionados en el CheckedListBox.
                {
                    Helado helado = new Helado(tamañoSeleccionado, SaborElegido, 1000); // Crea una nueva instancia de Helado con el tamaño seleccionado, el sabor elegido y un precio base de 1000.
                                                                                        
                    DetalleVenta detalleVenta = new DetalleVenta() { Helados = helado }; // Crea un nuevo DetalleVenta asociando el helado y el tamaño.

                    nuevaVenta.DetallesVentas.Add(detalleVenta);// Agrega el detalle de venta a la lista de detalles de la nueva venta.
                    
                }
                //miHeladeria.ListaVentas.Add(nuevaVenta);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se guardo");
            }
        }
        
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MostrarPedidos();
        }

        private void btnTotalRecaudado_Click(object sender, EventArgs e)
        {
            try
            {
                double TotalReacudado = miHeladeria.TotalRecaudado();
                MessageBox.Show("Total recaudado: "+ TotalReacudado);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay nada recaudado");
            }
        }

        private void btnSaborMaspedido_Click(object sender, EventArgs e)
        {
            try
            {
                string SaborMasPedido = miHeladeria.SaborMasPedidio();
                MessageBox.Show("El sabor mas pedido es " + SaborMasPedido);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo sacar el sabor mas pedido porque no hubo compras");
            }
        }

        private void btnTamañoMasPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string TamañoMasPedido = miHeladeria.TamañoMasVendido();
                MessageBox.Show("El tamaño mas vendido es " + TamañoMasPedido);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo sacar el tamaño mas pedido porque no hubo compras");
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                double PromedioTicket = miHeladeria.ticketPromedio();
                MessageBox.Show("El promedio es " + PromedioTicket);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo sacar el promedio del ticket mas pedido porque no hubo compras");
            } 
        }
    }
}

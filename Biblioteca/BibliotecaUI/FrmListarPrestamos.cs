using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidades.Entidades;
using BibliotecaNegocio;

namespace BibliotecaUI
{
    public partial class FrmListarPrestamos : Form
    {
        private List<Prestamo> _prestamos;
        private PrestamoServicio _servicioPrestamo;
        private ClienteServicio _clienteServicio;
        private EjemplarServicio _ejemplarServicio;
        private LibroServicio _libroServicio;
        public FrmListarPrestamos(Form pcpal)
        {
            InitializeComponent();
            this.Owner = pcpal;
            _servicioPrestamo = new PrestamoServicio();
            _clienteServicio = new ClienteServicio();
            _ejemplarServicio = new EjemplarServicio();
            _libroServicio = new LibroServicio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _cbPrestamo.SelectedIndex =-1;
            foreach(Control control in Controls)
            {
                if(control is TextBox)
                {
                    control.Text = string.Empty;
                }
                if (control is ListBox)
                {
                    ((ListBox)control).SelectedIndex = 0;
                }
                if(control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
        private void CargarComboPrestamo()
        {
            _cbPrestamo.DataSource = null;
            _prestamos = _servicioPrestamo.TraerPrestamos();
            _cbPrestamo.DataSource = _prestamos;
            _cbPrestamo.DisplayMember = "Id";

        }

        private void FrmListarPrestamos_Load(object sender, EventArgs e)
        {
            CargarComboPrestamo();
            CargarLista();
        }


        private void _btnBuscar_Click(object sender, EventArgs e)
        {
            Validaciones();
            Prestamo prestamo = ((Prestamo)_cbPrestamo.SelectedItem);
            CargarDatos(prestamo);
            
            //prestamo.IdCliente = ((Prestamo)_cbPrestamo.SelectedItem).IdCliente;
            //prestamo.IdEjemplar = ((Prestamo)_cbPrestamo.SelectedItem).IdEjemplar;
            

            

        }

        private void CargarDatos(Prestamo prestamo)
        {
            prestamo.Cliente = _clienteServicio.TraerClientePorID(prestamo.IdCliente);
            prestamo.Ejemplar = _ejemplarServicio.DevolverEjemplar(prestamo.IdEjemplar);
            _txtPrecioEjemplar.Text = prestamo.Ejemplar.Precio.ToString("0.00");
            _txtAutor.Text = _libroServicio.TraerLibroPorId(prestamo.Ejemplar.IdLibro).Autor;
            _txtNombreCliente.Text = prestamo.Cliente.Nombre + " " + prestamo.Cliente.Apellido;
            _txtTitulo.Text = prestamo.Ejemplar.Libros.Titulo;
        }

        private void Validaciones()
        {
            if (_cbPrestamo.SelectedItem == null)
            {
                throw new Exception("Debe seleccionar un id de prestamo");
            }
        }

        private void CargarLista()
        {
            _lstPrestamos.DataSource = null;
            _lstPrestamos.DataSource = _servicioPrestamo.TraerPrestamos();
            _lstPrestamos.DisplayMember = "MostrarEnLista";
        }
    }
}

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
using BibliotecaEntidades.Modelos;
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
            _prestamos = new List<Prestamo>();
          
        }

        #region"Botones"
        private void _btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Owner.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void _btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                Cliente cliente = (Cliente)_cbClientes.SelectedItem;
                List<Prestamo> _prestamosporCli = new List<Prestamo>();
                _prestamosporCli = TraerPrestamosporCliente(cliente);
                RefrescarLista(_prestamosporCli);
                SeleccionarPrestamo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion"Botones"

       
        #region"Eventos"
        private void FrmListarPrestamos_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            InhabilitarCampos();
            CargarLista();
            Calculos(_prestamos);
        }
        private void _lstPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {

            SeleccionarPrestamo();

        }

        #endregion"Eventos"


        #region"Metodos"
        private void SeleccionarPrestamo()
        {
            Prestamo prestamo =(Prestamo)_lstPrestamos.SelectedItem;                   
            if (prestamo != null)
            {
                _txtPrecioEjemplar.Text = prestamo.Ejemplar.Precio.ToString("0.00");
                _txtFecPrestamo.Text = prestamo.FechaPrestamo.ToString("dd-MM-yyyy");
                _txtObservaciones.Text = prestamo.Ejemplar.Observaciones;
                _txtTitulo.Text = prestamo.Ejemplar.Libros.Titulo;
                _txtAutor.Text = prestamo.Ejemplar.Libros.Autor;
                _txtDniCli.Text = prestamo.Cliente.Dni.ToString();
                _txtEstado.Text = prestamo.ActivoString;
            }
        }

        private List<Prestamo> TraerPrestamosporCliente(Cliente cliente)
        {
            List<Prestamo> _prestamos = _servicioPrestamo.TraerPrestamosConEjemplares();
            List<Prestamo> _prestamosPorCliente = new List<Prestamo>();
            foreach(Prestamo prestamo in _prestamos)
            {
                if(prestamo.IdCliente==cliente.Id)
                {
                    _prestamosPorCliente.Add(prestamo);
                }
            }
            if (_prestamosPorCliente.Count==0)
            {
                throw new Exception("Cliente sin prestamos");
            }
            return _prestamosPorCliente;
        }

        private void Validaciones()
        {
            if (_cbClientes.SelectedItem == null)
            {
                throw new Exception("Debe seleccionar un Cliente");
            }
        }

        private void RefrescarLista(List<Prestamo>prestamos)
        {
            _lstPrestamos.DataSource = null;
            _lstPrestamos.DataSource = prestamos;
            _lstPrestamos.DisplayMember = "MostrarEnListaPrestamos";
            Calculos(prestamos);
        }
        private void CargarLista()
        {
            _prestamos = _servicioPrestamo.TraerPrestamosConEjemplares();
            _lstPrestamos.DataSource = null;
            _lstPrestamos.DataSource = _prestamos;
            _lstPrestamos.DisplayMember = "MostrarEnListaPrestamos";
        }

 
        private void InhabilitarCampos()
        {
            _txtPrecioEjemplar.Enabled = false;
             _txtFecPrestamo.Enabled = false;
            _txtObservaciones.Enabled = false;
            _txtTitulo.Enabled = false;
            _txtAutor.Enabled = false;
            _txtDniCli.Enabled = false;
            _txtEstado.Enabled = false;
        }
        private void Calculos(List<Prestamo> prestamos)
        {
            OperacionModel operacion = new OperacionModel(prestamos);
            groupBox2.Text =$" Cantidad de Préstamos: { operacion.CantidadPrestamos.ToString()}";
        }
        private void Limpiar()
        {
            _cbClientes.SelectedIndex = -1;
            _txtEstado.Clear();
            _txtPrecioEjemplar.Clear();
            _txtFecPrestamo.Clear();
            _txtObservaciones.Clear();
            _txtTitulo.Clear();
            _txtAutor.Clear();
            _txtDniCli.Clear();
            _lstPrestamos.DataSource = _prestamos;
            Calculos(_prestamos);
        }
        private void CargarComboClientes()
        {
            _cbClientes.DataSource = null;
            List<Cliente> _clientes = _clienteServicio.TraerClientes();
            _cbClientes.DataSource = _clientes;
            _cbClientes.DisplayMember = "MostrarCombo";
        }
        #endregion"Metodos"

      
    }
}

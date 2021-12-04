using BibliotecaEntidades.Entidades;
using BibliotecaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUI
{
    public partial class Clientes : Form

    {
        private ClienteServicio _clienteServicio;
        List<Cliente> _clientes = new List<Cliente>();
        public Clientes(Form principal)
        {
            _clienteServicio = new ClienteServicio();
            _clientes = new List<Cliente>();
            this.Owner = principal;
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)

        {
            
            _clientes = _clienteServicio.TraerClientes();
            cmbIDClientes.DataSource = _clientes;
            cmbIDClientes.DisplayMember = "MostrarCombo";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Cliente _cliente = BuscarCliente();
                CargarDatos(_cliente);
                MessageBox.Show("Datos Cargados");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error En la carga");
            }
            


        }


        private void CargarDatos(Cliente _cliente)
        {
         
            txbApellido.Text = _cliente.Apellido;
            txbNombre.Text = _cliente.Nombre;
            txbDNI.Text = _cliente.Dni.ToString();
            txbFechaAlta.Text = _cliente.FechaAlta.ToString("dd/mm/yyyy");
            txbDireccion.Text = _cliente.Direccion;
            txbMail.Text = _cliente.Mail;
            txbTelefono.Text = _cliente.Telefono;
            txbUsuario.Text = _cliente.Usuario;
            if (_cliente.Activo)
            {
                chbActivo.Checked = true;
            }
            else
            {
                chbActivo.Checked = false;
            }


        }

        private Cliente  BuscarCliente()
        {
            Cliente _cliente = new Cliente();
            int _id = ((Cliente)cmbIDClientes.SelectedItem).Id;
            _cliente = _clienteServicio.TraerClientePorID(_id);
          
            return _cliente;

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            { Limpiar(); }
            catch
            {
                MessageBox.Show("Error al limpiar los campos");
            }
        }

        private void Limpiar()
        {
            txbApellido.Clear();
            txbDireccion.Clear();
            txbDNI.Clear();
            txbID.Clear();
            txbMail.Clear();
            txbNombre.Clear();
            txbFechaAlta.Clear();
            txbUsuario.Clear();
            chbActivo.Checked = false;
            ChbNoActivo.Checked = false;
            txbTelefono.Clear();


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Owner.Show();
            }
            catch
            {
                MessageBox.Show("Error al volver al formulario principal");
            }
        }
    }
 }

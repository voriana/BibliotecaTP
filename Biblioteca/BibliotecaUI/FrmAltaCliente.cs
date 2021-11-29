using BibliotecaEntidades.Entidades;
using BibliotecaEntidades.Exceptions;
using BibliotecaEntidades.Modelos;
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
    public partial class FrmAltaCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmAltaCliente(Form principal)
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

            GenerarIdCliente();
        }

        private void GenerarIdCliente()
        {
            int _idCliente = _clienteServicio.GenerarIDCliente();
            txbID.Text = _idCliente.ToString();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
             

            try
            {
                ValidacionesAlta();
                Cliente _cliente = CargarCliente();
                TransactionResult _resultado = _clienteServicio.AltaCliente(_cliente);
                MessageBox.Show("Cliente Cargado");
                Refrescar();

            }
            catch (ErrorAlta ex)
            {
                MessageBox.Show(ex.Message);
                Limpiar();
            }
            catch (ClienteRegistradoException ex)
            {
                MessageBox.Show(ex.Message);
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
        
            }
            
        }

        private void ValidacionesAlta()
        {
            if (txbApellido.Text == "" || txbDireccion.Text == "" || txbDNI.Text == "" || txbMail.Text == "null" || txbNombre.Text == "" || txbTelefono.Text == ""||txbMail.Text=="")
            {
                throw new Exception("Complete todos los campos"); 
            }
            if (rbuttonCarolina.Checked == false && rbuttonOriana.Checked == false)
            {
                throw new Exception("Debe seleccionar un usuario");
            }

            if (dateTimePicker1.Checked == false)
            {

                throw new Exception("Debe seleccionar una fecha de alta");
            }

            if (!int.TryParse(txbDNI.Text, out int salida))
            {
                throw new Exception("El campo dni debe ser numerico y positivo");
            }
           
           
        
        }

        private Cliente CargarCliente()
        {
            Cliente _cliente = new Cliente();

            _cliente.Nombre = txbNombre.Text;
            _cliente.Apellido = txbApellido.Text;
            _cliente.Direccion = txbDireccion.Text;
            _cliente.Telefono= txbTelefono.Text;
            _cliente.Dni = int.Parse(txbDNI.Text);
            _cliente.Id = int.Parse(txbID.Text);
            _cliente.Activo = chbActivo.Checked;
            _cliente.FechaAlta= dateTimePicker1.Value;         
            if (rbuttonCarolina.Checked)
            {
               _cliente.Usuario = "36903477";
            }
            if (rbuttonOriana.Checked)
            {
                _cliente.Usuario = "890175";
            }

            return _cliente;

        }

        private void Refrescar()
        {
            lstbClientes.DataSource = null;
           List<Cliente> _clientes = _clienteServicio.TraerClientes();
            lstbClientes.DataSource = _clientes;


        }

        private void Limpiar()
        {
            txbApellido.Clear();
            txbDireccion.Clear();
            txbDNI.Clear();
            txbID.Clear();
            txbMail.Clear();
            txbNombre.Clear();
            rbuttonCarolina.Checked=false;
            rbuttonOriana.Checked = false;
            chbActivo.Checked = false; 
            txbTelefono.Clear();
            GenerarIdCliente();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Owner.Show();
        }
    }
}

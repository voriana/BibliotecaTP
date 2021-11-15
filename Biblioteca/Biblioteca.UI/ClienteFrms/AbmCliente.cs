using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades.Negocio;
using Biblioteca.Negocio.Clientes;

namespace Biblioteca.UI.ClienteFrms
{
    public partial class AbmCliente : Form
    {
        private AltaCliente _altaCliente;
        private ModificarCliente _modificarCliente;
        private ClienteServicio _clienteServicio;

        //Constructor
        public AbmCliente(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.Owner = frmPrincipal;
            //inicializo mis atributos
            _altaCliente = new AltaCliente(this);
            _modificarCliente = new ModificarCliente(this);
            _clienteServicio = new ClienteServicio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnAgregar_Click(object sender, EventArgs e)
        {
            _altaCliente.Show();
            this.Hide();
        }

        private void _btnModificar_Click(object sender, EventArgs e)
        {
            _modificarCliente.Show();
            this.Hide();
        }

        private void Recargar() 
        {
            _lstClientes.DataSource = null;
            _lstClientes.DataSource = _clienteServicio.PedirClientes();
            _lstClientes.DisplayMember =ToString();
        }

        private void AbmCliente_Load(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}

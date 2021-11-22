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
    public partial class FrmPrestamo : Form
    {
        
        private ClienteServicio _servicioCli;
        private EjemplarServicio _ejemplarServicio;
        private List<Cliente> _clientes;
        private List<Ejemplar> _ejemplares;


        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
            _servicioCli = new ClienteServicio();
            _ejemplarServicio = new EjemplarServicio();
            _clientes = new List<Cliente>();
            _ejemplares = new List<Ejemplar>();


        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            CargaComboCliente();
            CargarComboEjemplar();


        }

        private void CargaComboCliente()
        {
            _clientes=_servicioCli.TraerClientes();
            cbClientes.DataSource = null;
            cbClientes.DataSource = _clientes;
            cbClientes.DisplayMember = "MostrarCombo";
        }
        private void CargarComboEjemplar()
        {
            _ejemplares = _ejemplarServicio.TraerEjemplares();
            cbEjemplar.DataSource = null;
            cbEjemplar.DataSource = _ejemplares;
            cbEjemplar.DisplayMember = "MostrarEnCombo";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            foreach (Control control in gbDatosAltaPrestamo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
    }
}

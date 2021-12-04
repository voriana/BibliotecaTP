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
    public partial class FrmPrestamo : Form
    {
        
        private ClienteServicio _servicioCli;
        private EjemplarServicio _ejemplarServicio;
        private PrestamoServicio _prestamoServicio;
        private List<Cliente> _clientes;
        private List<Ejemplar> _ejemplares;
        private List<Prestamo> _prestamos;


        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
            _servicioCli = new ClienteServicio();
            _ejemplarServicio = new EjemplarServicio();
            _prestamoServicio= new PrestamoServicio();
            _clientes = new List<Cliente>();
            _ejemplares = new List<Ejemplar>();
            _prestamos = new List<Prestamo>();


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
            CargarLista();
            InhabilitarCampos();


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
            _ejemplares = _ejemplarServicio.TraerEjemplaresConLibros();
            cbEjemplar.DataSource = null;
            cbEjemplar.DataSource = _ejemplares;
            cbEjemplar.DisplayMember = "MostrarEnCombo";
            cbEjemplar.ValueMember = "Id";
        }
        private void CargarLista()
        {
            _prestamos = _prestamoServicio.TraerPrestamos();
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = _prestamos;
            lstPrestamos.DisplayMember = "MostrarEnLista";
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

       private void Validaciones()
       {
            if (cbClientes.SelectedIndex == -1)
            {
                throw new Exception("Debe seleccionar un cliente");
            }
            if (cbEjemplar.SelectedIndex == -1)
            {
                throw new Exception("Debe seleccionar un ejemplar");
            }
            if (tbPlazo.Text != "")
            {
                if(!int.TryParse(tbPlazo.Text,out int salida))
                {
                    throw new Exception("el plazo de dias debe ser numerico");
                }

                tbfecEntrega.Text = (DateTime.Now.AddDays(double.Parse(tbPlazo.Text))).ToString();
                tbfecEntrega.Enabled = false;
                tbFecReal.Enabled = false;

            }
            else
            {
                throw new Exception("El plazo es obligatorio");
            }
            
          
       }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Cliente)cbClientes.SelectedItem).Id != -1)
            {
               
                tbIdCliente.Text = ((Cliente)cbClientes.SelectedItem).Id.ToString();

            }
        }

        private void cbEjemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Ejemplar)cbEjemplar.SelectedItem).Id != -1)
            {
                
                tbIdEjemplar.Text = ((Ejemplar)cbEjemplar.SelectedItem).Id.ToString();

            }
        }

        private void InhabilitarCampos()
        {
            txtIdPrestamo.Enabled = false;
            tbIdCliente.Enabled = false;
            tbIdEjemplar.Enabled = false;
            tbfechPrestamo.Enabled = false;
            tbfechPrestamo.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

      

        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                int idCliente = ((Cliente)cbClientes.SelectedItem).Id;
                int idEjemplar = ((Ejemplar)cbEjemplar.SelectedItem).Id;
                bool activo = _checkActivo.Checked;
                int plazo = Convert.ToInt32(tbPlazo.Text);
                DateTime fechaPres = Convert.ToDateTime(tbfechPrestamo.Text);

                TransactionResult resultadoAlta = _prestamoServicio.EnviarPrestamo(idCliente, idEjemplar, activo, plazo, fechaPres);
                MessageBox.Show("Prestamo agregado correctamente");
                CargarLista();
                Limpiar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkActivo.Checked == true)
            {
                tbFecReal.Enabled = false;
                tbFecReal.Text = "sin devolucion";
            }
        }
    }
}
 
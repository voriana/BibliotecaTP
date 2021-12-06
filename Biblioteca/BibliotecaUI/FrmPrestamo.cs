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
        private ClienteServicio _clienteServicio;
        private EjemplarServicio _ejemplarServicio;
        private PrestamoServicio _prestamoServicio;
        private List<Cliente> _clientes;
        private List<Ejemplar> _ejemplares;
        private List<Prestamo> _prestamos;


        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
            _clienteServicio = new ClienteServicio();
            _ejemplarServicio = new EjemplarServicio();
            _prestamoServicio= new PrestamoServicio();
            _clientes = new List<Cliente>();
            _ejemplares = new List<Ejemplar>();
            _prestamos = new List<Prestamo>();
        }
        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargaComboCliente();
            CargarComboEjemplar();
            CargarLista();
            Calculos();
            InhabilitarCampos();
        }
        #region"BOTONES"
        //boton volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                this.Hide();
                this.Owner.Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton guardar
        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                int idCliente = ((Cliente)cbClientes.SelectedItem).Id;
                int idEjemplar = ((Ejemplar)cbEjemplar.SelectedItem).Id;
                bool activo = _checkActivo.Checked;
                int plazo = int.Parse(tbPlazo.Text);
                DateTime fechaPres = DateTime.Parse(tbfechPrestamo.Text);
                DateTime fechaTentativa = DateTime.Parse(tbfecEntrega.Text);
                DateTime fechareal = DateTime.Parse(tbfecEntrega.Text);

                TransactionResult resultadoAlta = _prestamoServicio.EnviarPrestamo((int)idCliente, (int)idEjemplar, activo, plazo, fechaPres, fechaTentativa, fechareal);
                if (!resultadoAlta.IsOk)
                {
                    throw new Exception(resultadoAlta.Error);

                }
                MessageBox.Show("Prestamo agregado correctamente");
                CargarLista();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion"BOTONES"


        #region"EVENTOS"

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cbClientes.SelectedItem;

            if (cliente.Id != 0)
            {

                tbIdCliente.Text = cliente.Id.ToString();

            }
        }

        private void cbEjemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ejemplar ejemplar = (Ejemplar)cbEjemplar.SelectedItem;
            if (ejemplar.Id != 0)
            {

                tbIdEjemplar.Text = ((Ejemplar)cbEjemplar.SelectedItem).Id.ToString();

            }
        }

        private void _checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkActivo.Checked)
            {
                tbFecReal.Enabled = false;
                tbFecReal.Text = "sin devolucion";
            }

        }
        private void tbPlazo_TextChanged(object sender, EventArgs e)
        {
            DateTime fecDevol = DateTime.Parse(tbfechPrestamo.Text);
            var dias = 0;
            if (int.TryParse(tbPlazo.Text, out dias))
                if (tbPlazo.Text != "")
                {
                    tbfecEntrega.Text = fecDevol.AddDays(dias).ToString("yyyy-MM-dd");
                    tbFecReal.Text = fecDevol.AddDays(dias).ToString("yyyy-MM-dd");
                }
        }
        #endregion"EVENTOS"


        #region"METODOS"
        private void CargaComboCliente()
        {
            //_clientes = new List<Cliente>();
            _clientes = _clienteServicio.TraerClientes();
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
        }
        private void CargarLista()
        {
            _prestamos = _prestamoServicio.TraerPrestamosConEjemplares();
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = _prestamos;
            lstPrestamos.DisplayMember = "MostrarEnListaPrestamos";
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
            _checkActivo.Checked = false;
        }
        private void InhabilitarCampos()
        {
            txtIdPrestamo.Enabled = false;
            tbIdCliente.Enabled = false;
            tbIdEjemplar.Enabled = false;
            tbfechPrestamo.Enabled = false;
            tbfechPrestamo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbfecEntrega.Enabled = false;
            tbFecReal.Enabled = false;
        }
        private void Validaciones()
        {
            Cliente cliente = (Cliente)cbClientes.SelectedItem;
            Ejemplar ejemplar = (Ejemplar)cbEjemplar.SelectedItem;
            if ((cliente == null))
            {
                throw new Exception("Debe seleccionar un cliente");
            }
            if (ejemplar == null)
            {
                throw new Exception("Debe seleccionar un ejemplar");
            }
            if (tbPlazo.Text != "")
            {
                if (!int.TryParse(tbPlazo.Text, out int salida))
                {
                    throw new Exception("el plazo de dias debe ser numerico");
                }
            }
            else
            {
                throw new Exception("El plazo es obligatorio");
            }
        }
        //Cantidad de prestamos existentes
        private void Calculos()
        {
            OperacionModel operacion = new OperacionModel(_prestamoServicio.TraerPrestamosConEjemplares());
            groupBox2.Text += $" {operacion.CantidadPrestamos.ToString()}";
        }
        #endregion"METODOS"

     
    }
}

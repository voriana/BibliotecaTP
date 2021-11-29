using BibliotecaDatos;
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
    public partial class Alta_Ejemplar : Form
    {
        private LibroMapper _libroMapper;
        private EjemplarServicio _ejemplarServicio;
        private EjemplarMapper _ejemplarMapper;
        private LibroServicio _libroServicio;
        private List<Ejemplar> _ejemplares;
        
        
        public Alta_Ejemplar()
        {
            _libroMapper = new LibroMapper();
            _ejemplarServicio = new EjemplarServicio();
            _ejemplarMapper = new EjemplarMapper();
            _libroServicio = new LibroServicio();
            _ejemplares = new List<Ejemplar>();
           
            InitializeComponent();
         
        }

        private void Alta_Ejemplar_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void CargarLibros()
        {
            List<Libro> _libros = _libroMapper.GetLibros();
            cmbLibros.DataSource = _libros;
            cmbLibros.DisplayMember = "MostrarComboAltaEjemplar";


        }


        private void VerificacionesAlta()
        {
            if (cmbLibros.SelectedItem == null)
            {
                throw new Exception("Seleccione un Libro");
            }
            if (txbPrecio.Text == "" || txbObservaciones.Text == "")
            {
                throw new Exception("Complete todos los campos");
            }
            if (dtpFechaAlta.Value == null)
            {
                throw new Exception("Seleccione una fecha de alta");
            }
            if (!double.TryParse(txbPrecio.Text,out double salida))
            {
                throw new Exception("El precio debe ser un campo numerico y positivo");
            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            try
            {
                VerificacionesAlta();
                TransactionResult _resultado = _ejemplarServicio.AltaEjemplar(CargarEjemplar());
                MessageBox.Show("El Ejemplar se agrego correctamente");
                Refrescar();

            }
            catch (TransactionErrorException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Ejemplar CargarEjemplar()
        {
            Ejemplar _nuevoEjemplar = new Ejemplar();
            Libro libro = (Libro)cmbLibros.SelectedItem;
            _nuevoEjemplar.IdLibro = libro.Id;
            _nuevoEjemplar.Observaciones = txbObservaciones.Text;
            _nuevoEjemplar.Precio = double.Parse(txbPrecio.Text);
            return _nuevoEjemplar;

        }

        private void Refrescar()
        {
            LstbEjemplares.DataSource = null;
            _ejemplares= _ejemplarMapper.GetEjemplares();
            LstbEjemplares.DataSource = _ejemplares;
        }

    }
}

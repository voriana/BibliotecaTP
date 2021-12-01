
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
    public partial class FrmListarEjemplar : Form
    {
       
        private LibroServicio _libroServicio;
        private EjemplarServicio _ejemplarServicio;
        private List<Libro> _libros;
        public FrmListarEjemplar(Form principal)
        {
            
            _libroServicio = new LibroServicio();
            _ejemplarServicio = new EjemplarServicio();
            _libros = new List<Libro>();
            InitializeComponent();
            this.Owner = principal;
        }

        private void FrmListarEjemplar_Load(object sender, EventArgs e)
        {
            CargarLibros();
           
        }

        private void CargarLibros()
        {

            _libros = _libroServicio.TraerLibros();
            cmbLibros.DataSource = _libros;
            cmbLibros.DisplayMember = "MostrarBusquedaLibro";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesBotonBuscar();
                CargarListBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  
        }

        private void ValidacionesBotonBuscar()
        {
            if (cmbLibros.SelectedItem == null)
            {
                throw new Exception("Debe seleccionar un Libro");
            }

        }

        private void CargarListBox()
        {
            lstbEjemplares.DataSource = null;
            Libro _libro = (Libro)cmbLibros.SelectedItem;
            List<Ejemplar> _ejemplares = _ejemplarServicio.TraerEjemplaresPorIdLibro(_libro.Id);
            lstbEjemplares.DataSource = _ejemplares;
            lstbEjemplares.DisplayMember = "MostrarEnCombo";
            


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbLibros.SelectedItem = null;
            lstbEjemplares.DataSource = null;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}

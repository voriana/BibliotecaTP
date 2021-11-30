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
    public partial class FrmListarLibros : Form
    {
        private LibroServicio _libroServicio;
        private List<Libro> _libros;
        public FrmListarLibros(Form principal)
        {
            InitializeComponent();
            this.Owner = principal;
            _libroServicio = new LibroServicio();
            _libros = new List<Libro>();
        }

        private void Volver_click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmListarLibros_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarComboId();
            
        }

        private void CargarComboId()
        {
            CbIdLibro.DataSource = _libros;
            CbIdLibro.ValueMember = "Id";
        }

        private void CargarLista()
        {
            _lstLibros.DataSource = null;
            _libros = _libroServicio.TraerLibros();
            _lstLibros.DataSource = _libros;
            _lstLibros.DisplayMember = "MostrarEnlista";
            _lstLibros.SelectedIndex = -1;
        }

        private void _btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                string autor = _txtAutor.Text;
                string titulo = _txtTitulo.Text;
                int id = ((Libro)CbIdLibro.SelectedItem).Id;
              
                List <Libro> nuevaLista = new List<Libro>();

                if (autor != null&& titulo=="" && CbIdLibro.SelectedIndex==0)
                {
                    foreach (Libro libro in _libros)
                    {
                        if (libro.Autor == autor)
                        {
                            nuevaLista.Add(libro);
                        }
                    }
                }
                if (autor == "" && titulo != "" && CbIdLibro.SelectedIndex == 0)
                {
                    foreach (Libro libro in _libros)
                    {
                        if (libro.Titulo == titulo)
                        {
                            nuevaLista.Add(libro);
                        }
                    }
                }
                if (autor == "" && titulo == "" && CbIdLibro.SelectedIndex != 0)
                {
                    foreach (Libro libro in _libros)
                    {
                        if (libro.Id == id)
                        {
                            nuevaLista.Add(libro);
                        }
                    }
                }
                if(autor != "" && titulo != "" && CbIdLibro.SelectedIndex != 0)
                {
                    throw new Exception("Solo puede escoger un criterio de busqueda");
                }
                RecargarLista(nuevaLista);
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RecargarLista(List<Libro> librosXPorAutor)
        {
            _lstLibros.DataSource = librosXPorAutor;
            _lstLibros.DisplayMember = "MostrarBusquedaLibro";
        }

        private void Validaciones()
        {
            if (_txtAutor.Text == ""&&_txtTitulo.Text=="" && CbIdLibro.SelectedIndex == 0)
            {
                throw new Exception("Debe seleccionar un criterio de busqueda");
            }
            
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargarLista();
        }

        private void Limpiar()
        {
            
            _txtAutor.Clear();
            _txtTitulo.Clear();
            CbIdLibro.SelectedIndex = 0;
        }
    }
}

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
    public partial class FrmAltaLibro : Form
    {
        private LibroServicio _libroServicio;
        
     
        public FrmAltaLibro(Form principal )
        {
            InitializeComponent();
            this.Owner = principal;
            _libroServicio = new LibroServicio();
        }
        private void FrmAltaLibro_Load(object sender, EventArgs e)
        {
            RecargarLista();
            txtId.Enabled = false;

        }

        #region"Botones"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                string autor = txtAutor.Text;
                string titulo = txtTitulo.Text;
                string tema = txtTema.Text;
                string editorial = txtEditorial.Text;
                int edicion = int.Parse(txtEdicion.Text);
                int pags = int.Parse(txtPags.Text);

                TransactionResult resutaldo = _libroServicio.AgregarLibro(autor, titulo, tema, editorial, edicion, pags);
                if (!resutaldo.IsOk)
                {
                    throw new Exception($"Erorr{resutaldo.Error}");
                }
                else
                {
                    MessageBox.Show($"libro agregado a la lista");
                    RecargarLista();
                    Limpiar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try{
                this.Hide();
                this.Owner.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                RecargarLista();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        #region"Metodos"
        private void Limpiar()
        {
            txtId.Clear();
            txtAutor.Clear();
            txtEdicion.Clear();
            txtEditorial.Clear();
            txtPags.Clear();
            txtTema.Clear();
            txtTitulo.Clear();
        }

        //validar campos ingresados.
        public void ValidarCampos()
        {
            
            if(string.IsNullOrEmpty(txtAutor.Text) || string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtTema.Text) 
                || string.IsNullOrEmpty(txtEditorial.Text)|| string.IsNullOrEmpty(txtTema.Text) || string.IsNullOrEmpty(txtPags.Text))
            {
                throw new Exception("Todos los campos son obligatorios");
            }
            else
            {
                if(!int.TryParse(txtEdicion.Text,out int edic))
                {
                    throw new Exception("El campo edicion es numerico");
                }
                if(!int.TryParse(txtPags.Text,out int pag))
                {
                    throw new Exception("La cantidad de paginas debe ser un valor numerico");
                }
            }

        }

        

        private void RecargarLista()
        {
            List<Libro> _libros = _libroServicio.TraerLibros();
            lstLibros.DataSource = null;
            lstLibros.DataSource = _libros;
            lstLibros.DisplayMember = "MostrarEnlista";
            Calculos();
        }

       
        private void Calculos()
        {
            OperacionModel operacion = new OperacionModel(_libroServicio.TraerLibros());
            txtCant.Text= operacion.CantidadLibros.ToString();
            txtCant.Enabled = false;
        }
    }
    #endregion="region2"
}

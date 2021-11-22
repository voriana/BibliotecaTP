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
        
        private List<Libro> _libros;
        public FrmAltaLibro(Form principal )
        {
            InitializeComponent();
            this.Owner = principal;
            _libroServicio = new LibroServicio();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            foreach(Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        //validar campos ingresados.
        public void ValidarCampos()
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        switch (control.Name)
                        {
                            case "txtAutor":
                                if (string.IsNullOrEmpty(txtAutor.Text))
                                {
                                    txtAutor.Focus();
                                    throw new Exception($"El campo {control.Name} no puede estar vacio");
                                }

                                break;
                            case "txtTitulo":
                                if (string.IsNullOrEmpty(txtTitulo.Text))
                                {
                                    txtTitulo.Focus();
                                    throw new Exception($"El campo {control.Name} no puede estar vacio");
                                }

                                break;
                            case "txtTema":
                                if (string.IsNullOrEmpty(txtTema.Text))
                                {
                                    txtTema.Focus();
                                    throw new Exception($"El campo {control.Name} no puede estar vacio");
                                }
                                else
                                {
                                }
                                break;
                            case "txtEdicion": //txtEdicion
                                if (string.IsNullOrEmpty(txtEdicion.Text) || !int.TryParse(txtEdicion.Text, out int salida))
                                {
                                    txtEdicion.Focus();
                                    throw new Exception("Debe ingresar un valor numerico o el campo esta vacio");
                                }
                                break;
                            case "txtEditorial":
                                if (string.IsNullOrEmpty(txtEditorial.Text))
                                {
                                    txtEditorial.Focus();
                                    throw new Exception("El campo no puede estar vacio");
                                }
                                break;
                            case "txtPags":
                                if (string.IsNullOrEmpty(txtPags.Text) && !int.TryParse(txtPags.Text, out int paginas))
                                {
                                    txtPags.Focus();
                                    throw new Exception("El campo no puede estar vacio o debe ser numerico");
                                }
                                break;
                        }
                    }
                }

                int id = 0;
                string autor= txtAutor.Text;
                string titulo = txtTitulo.Text;
                string tema = txtTema.Text;
                string editorial = txtEditorial.Text;
                int edicion = int.Parse(txtEdicion.Text);
                int pags = int.Parse(txtPags.Text);

                TransactionResult resutaldo =_libroServicio.AgregarLibro(id, autor, titulo, tema, editorial, edicion, pags);
                MessageBox.Show($"{resutaldo.Id}- usuario agregado");
                RecargarLista();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecargarLista()
        {
            _libros = _libroServicio.TraerLibros();
            lstLibros.DataSource = null;
            lstLibros.DataSource = _libros;
            lstLibros.DisplayMember = "MostrarEnlista";
        }

       

        private void FrmAltaLibro_Load(object sender, EventArgs e)
        {
            RecargarLista();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RecargarLista();
        }
    }
}

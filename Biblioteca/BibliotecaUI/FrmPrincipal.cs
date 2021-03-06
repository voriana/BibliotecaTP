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
    public partial class Principal : Form
    {
        private FrmPrestamo prestamo;
        private FrmListarPrestamos _listarPrestamos;
        private FrmAltaLibro libro;
        private FrmListarLibros _frmListar;

        private Alta_Ejemplar _Ejemplar;
        private FrmListarEjemplar _listarEjemplar;
        private FrmAltaCliente _altaCliente;
        private Clientes _listarClientes;

        //private FrmEjemplar ejemplar;

        public Principal()
        {
            InitializeComponent();
            prestamo = new FrmPrestamo(this);
            libro = new FrmAltaLibro(this);
            _frmListar = new FrmListarLibros(this);

            _Ejemplar = new Alta_Ejemplar(this);
            _listarEjemplar = new FrmListarEjemplar(this);
            _altaCliente = new FrmAltaCliente(this);
            _listarClientes = new Clientes(this);
            _listarPrestamos = new FrmListarPrestamos(this);
        }

  

     

        private void Principal_Load(object sender, EventArgs e)
        {

        }


        private void btnAltaPrestamo_Click(object sender, EventArgs e)
        {
            prestamo.Show();
            this.Hide();
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            libro.Show();
            this.Hide();
        }

        private void btnListarLibros_Click(object sender, EventArgs e)
        {
            _frmListar.Show();
            this.Hide();
            
            
        }

        private void btnAltaEjemplar_Click(object sender, EventArgs e)
        {
            _Ejemplar.Show();
            this.Hide();
        }

        private void btnListarEjemplar_Click(object sender, EventArgs e)
        {
            _listarEjemplar.Show();
            this.Hide();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            _altaCliente.Show();
            this.Hide();

        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            _listarClientes.Show();
            this.Hide();
        }

        private void btnListarPres_Click(object sender, EventArgs e)
        {
            _listarPrestamos.Show();
            this.Hide();
        }
    }
}

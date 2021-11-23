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
        //private FrmCliente cliente;
        private FrmAltaLibro libro;
        private FrmListarLibros _frmListar;
        //private FrmEjemplar ejemplar;
        public Principal()
        {
            InitializeComponent();
            prestamo = new FrmPrestamo(this);
            libro = new FrmAltaLibro(this);
            _frmListar = new FrmListarLibros(this);
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
    }
}

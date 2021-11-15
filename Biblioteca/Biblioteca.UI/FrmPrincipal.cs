using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.UI.ClienteFrms;
using Biblioteca.UI.EjemplarFrms;
using Biblioteca.UI.LibrosFrms;
using Biblioteca.UI.PrestamosFrms;

namespace Biblioteca.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void _btnClientes_Click(object sender, EventArgs e)
        {
            AbmCliente _lienteAbm = new AbmCliente(this);
            _lienteAbm.Show();
            this.Hide();
            
        }

        private void _btnPrestamos_Click(object sender, EventArgs e)
        {
            AbmPrestamo _prestamoAbm = new AbmPrestamo(this);
            _prestamoAbm.Show();
            this.Hide();
            
        }

        private void _btnLibros_Click(object sender, EventArgs e)
        {
            AbmLibro _libroAbm = new AbmLibro(this);
            _libroAbm.Show();
            this.Hide();
            
        }

        private void _btnEjemplares_Click(object sender, EventArgs e)
        {
            AbmEjemplar _ejemplarAbm = new AbmEjemplar(this);
            this.Hide();
            _ejemplarAbm.Show();
        }
    }
}

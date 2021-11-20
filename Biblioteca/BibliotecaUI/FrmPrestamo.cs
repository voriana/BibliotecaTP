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
    public partial class FrmPrestamo : Form
    {
        
        private PrestamoServicio _servicio;
        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
            
            _servicio = new PrestamoServicio();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            try 
            {
                CargaLista();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargaLista()
        {
             
            cbClientes.DataSource = null;
            cbClientes.DataSource = _servicio.TraerClientes();
           
        }
    }
}

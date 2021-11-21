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
        
        private ClienteServicio _servicioCli;
       
        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
            _servicioCli = new ClienteServicio();
           
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            CargaComboCliente();
            //try 
            //{
               
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void CargaComboCliente()
        {
            cbClientes.DataSource = null;
            cbClientes.DataSource = _servicioCli.TraerClientes();


            ;        }
    }
}

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
    public partial class FrmListarLibros : Form
    {
        //private Form _principal;
        public FrmListarLibros(Form principal)
        {
            InitializeComponent();
            this.Owner = principal;
        }

        private void Volver_click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmListarLibros_Load(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades.Excepciones;

namespace Biblioteca.UI.ClienteFrms
{
    public partial class AltaCliente : Form
    {
        public AltaCliente(AbmCliente abmCliente)
        {
            InitializeComponent();
            this.Owner = abmCliente;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
            
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            this._txtId.Enabled = false;
        }

        private void validacionCampos()
        {
            //valida que ningun campo este vacio
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox && item.Text == string.Empty && (item!=_txtId))
                {
                    item.BackColor = Color.Red;
                    throw new VacioException(groupBox1.Text);
                }
            }
            if (!validarTipoDatos()) //si esto devulve false 
            {
                throw new TipoInvalidoException("El tipo de dato ingresado es invalido");
            }
          
            
        }

        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                validacionCampos();//antes de guardar valida que ningun campo este vacio
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //valida tipo  de dato
        private bool validarTipoDatos() 
        {
            long cuit;
            DateTime fechaNac;
            if (!(long.TryParse(_txtCuit.Text, out cuit)))
            {
                _txtCuit.BackColor = Color.Red;
                return false;
            }
            if(!(DateTime.TryParse(_txtFecNac.Text, out fechaNac)))
            {
                _txtFecNac.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            //recorrer grupos de controles,poner blanco los que sean campo de texto
            foreach(Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
    }
}

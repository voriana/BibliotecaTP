﻿using System;
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
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo(Form form)
        {
            InitializeComponent();
            this.Owner = form;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}

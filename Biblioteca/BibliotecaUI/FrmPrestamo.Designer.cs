
namespace BibliotecaUI
{
    partial class FrmPrestamo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.lbIdPrestamo = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEjemplar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecPrestamo = new System.Windows.Forms.Label();
            this.tbfechPrestamo = new System.Windows.Forms.TextBox();
            this.lbFecEntrega = new System.Windows.Forms.Label();
            this.tbfecEntrega = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbPlazo = new System.Windows.Forms.Label();
            this.tbPlazo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDatosAltaPrestamo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFecReal = new System.Windows.Forms.TextBox();
            this.lbFecReal = new System.Windows.Forms.Label();
            this.tbIdEjemplar = new System.Windows.Forms.TextBox();
            this.CheckActivo = new System.Windows.Forms.CheckBox();
            this.lbIdEjemplar = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.gbDatosAltaPrestamo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Enabled = false;

            this.txtIdPrestamo.Location = new System.Drawing.Point(260, 62);
            this.txtIdPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(142, 26);

            this.txtIdPrestamo.Location = new System.Drawing.Point(173, 40);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(96, 20);

            this.txtIdPrestamo.TabIndex = 0;
            // 
            // lbIdPrestamo
            // 
            this.lbIdPrestamo.AutoSize = true;
            this.lbIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lbIdPrestamo.Location = new System.Drawing.Point(12, 72);
            this.lbIdPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdPrestamo.Name = "lbIdPrestamo";
            this.lbIdPrestamo.Size = new System.Drawing.Size(96, 20);
            this.lbIdPrestamo.TabIndex = 1;
            this.lbIdPrestamo.Text = "Nro. Ficha";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;

            this.cbClientes.Location = new System.Drawing.Point(22, 43);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(289, 28);

            this.cbClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar Cliente";
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.FormattingEnabled = true;

            this.cbEjemplar.Location = new System.Drawing.Point(21, 131);
            this.cbEjemplar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(290, 28);

            this.cbEjemplar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Ejemplar";
            // 
            // lbFecPrestamo
            // 
            this.lbFecPrestamo.AutoSize = true;

            this.lbFecPrestamo.Location = new System.Drawing.Point(9, 254);
            this.lbFecPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbFecPrestamo.Name = "lbFecPrestamo";
            this.lbFecPrestamo.Size = new System.Drawing.Size(148, 20);
            this.lbFecPrestamo.TabIndex = 6;
            this.lbFecPrestamo.Text = "Fecha de Préstamo";
            // 
            // tbfechPrestamo
            // 

            this.tbfechPrestamo.Location = new System.Drawing.Point(262, 243);
            this.tbfechPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.tbfechPrestamo.Name = "tbfechPrestamo";
            this.tbfechPrestamo.Size = new System.Drawing.Size(140, 26);
            this.tbfechPrestamo.TabIndex = 7;
            // 
            // lbFecEntrega
            // 
            this.lbFecEntrega.AutoSize = true;

            this.lbFecEntrega.Location = new System.Drawing.Point(12, 305);
            this.lbFecEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbFecEntrega.Name = "lbFecEntrega";
            this.lbFecEntrega.Size = new System.Drawing.Size(229, 20);
            this.lbFecEntrega.TabIndex = 8;
            this.lbFecEntrega.Text = "Fecha de devolución tentantiva";
            // 
            // tbfecEntrega
            // 

            this.tbfecEntrega.Location = new System.Drawing.Point(262, 294);
            this.tbfecEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.tbfecEntrega.Name = "tbfecEntrega";
            this.tbfecEntrega.Size = new System.Drawing.Size(140, 26);
            this.tbfecEntrega.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;

            this.btnLimpiar.Location = new System.Drawing.Point(33, 555);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;

            this.btnVolver.Location = new System.Drawing.Point(606, 555);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 35);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;

            this.radioButton1.Location = new System.Drawing.Point(98, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "36903477";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;

            this.radioButton2.Location = new System.Drawing.Point(230, 20);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 24);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "890175";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbPlazo
            // 
            this.lbPlazo.AutoSize = true;

            this.lbPlazo.Location = new System.Drawing.Point(9, 203);
            this.lbPlazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbPlazo.Name = "lbPlazo";
            this.lbPlazo.Size = new System.Drawing.Size(129, 20);
            this.lbPlazo.TabIndex = 16;
            this.lbPlazo.Text = "Plazo de entrega";
            // 
            // tbPlazo
            // 

            this.tbPlazo.Location = new System.Drawing.Point(262, 194);
            this.tbPlazo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.Size = new System.Drawing.Size(140, 26);
            this.tbPlazo.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;

            this.button1.Location = new System.Drawing.Point(315, 555);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;

            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // gbDatosAltaPrestamo
            // 
            this.gbDatosAltaPrestamo.Controls.Add(this.groupBox1);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbIdEjemplar);
            this.gbDatosAltaPrestamo.Controls.Add(this.CheckActivo);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbIdEjemplar);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbIdCliente);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbPlazo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbPlazo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbIdCliente);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbfechPrestamo);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecPrestamo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbfecEntrega);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecEntrega);
            this.gbDatosAltaPrestamo.Controls.Add(this.txtIdPrestamo);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbIdPrestamo);

            this.gbDatosAltaPrestamo.Location = new System.Drawing.Point(348, 18);
            this.gbDatosAltaPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatosAltaPrestamo.Name = "gbDatosAltaPrestamo";
            this.gbDatosAltaPrestamo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatosAltaPrestamo.Size = new System.Drawing.Size(418, 477);

            this.gbDatosAltaPrestamo.TabIndex = 20;
            this.gbDatosAltaPrestamo.TabStop = false;
            this.gbDatosAltaPrestamo.Text = "Nuevo Préstamo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);

            this.groupBox1.Location = new System.Drawing.Point(8, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(394, 63);

            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // tbFecReal
            // 

            this.tbFecReal.Location = new System.Drawing.Point(261, 345);
            this.tbFecReal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.tbFecReal.Name = "tbFecReal";
            this.tbFecReal.Size = new System.Drawing.Size(140, 26);
            this.tbFecReal.TabIndex = 26;
            // 
            // lbFecReal
            // 
            this.lbFecReal.AutoSize = true;

            this.lbFecReal.Location = new System.Drawing.Point(9, 355);
            this.lbFecReal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbFecReal.Name = "lbFecReal";
            this.lbFecReal.Size = new System.Drawing.Size(192, 20);
            this.lbFecReal.TabIndex = 25;
            this.lbFecReal.Text = "Fecha de devolución Real";
            // 
            // tbIdEjemplar
            // 

            this.tbIdEjemplar.Location = new System.Drawing.Point(262, 148);
            this.tbIdEjemplar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======

            this.tbIdEjemplar.Name = "tbIdEjemplar";
            this.tbIdEjemplar.Size = new System.Drawing.Size(140, 26);
            this.tbIdEjemplar.TabIndex = 24;
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;

            this.CheckActivo.Location = new System.Drawing.Point(321, 15);
            this.CheckActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.Size = new System.Drawing.Size(78, 24);

            this.CheckActivo.TabIndex = 25;
            this.CheckActivo.Text = "Activo";
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // lbIdEjemplar
            // 
            this.lbIdEjemplar.AutoSize = true;

            this.lbIdEjemplar.Location = new System.Drawing.Point(9, 152);
            this.lbIdEjemplar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbIdEjemplar.Name = "lbIdEjemplar";
            this.lbIdEjemplar.Size = new System.Drawing.Size(89, 20);
            this.lbIdEjemplar.TabIndex = 23;
            this.lbIdEjemplar.Text = "Id Ejemplar";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;

            this.lbIdCliente.Location = new System.Drawing.Point(9, 112);
            this.lbIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(76, 20);
            this.lbIdCliente.TabIndex = 22;
            this.lbIdCliente.Text = "Id Cliente";
            // 
            // tbIdCliente
            // 

            this.tbIdCliente.Location = new System.Drawing.Point(262, 102);
            this.tbIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(140, 26);
            this.tbIdCliente.TabIndex = 21;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;

            this.lstPrestamos.ItemHeight = 20;
            this.lstPrestamos.Location = new System.Drawing.Point(21, 186);
            this.lstPrestamos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(290, 304);

            this.lstPrestamos.TabIndex = 21;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;

            this.ClientSize = new System.Drawing.Size(784, 626);

            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.gbDatosAltaPrestamo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrestamo";
            this.Text = "Registro Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.gbDatosAltaPrestamo.ResumeLayout(false);
            this.gbDatosAltaPrestamo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label lbIdPrestamo;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEjemplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecPrestamo;
        private System.Windows.Forms.TextBox tbfechPrestamo;
        private System.Windows.Forms.Label lbFecEntrega;
        private System.Windows.Forms.TextBox tbfecEntrega;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbPlazo;
        private System.Windows.Forms.TextBox tbPlazo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbDatosAltaPrestamo;
        private System.Windows.Forms.TextBox tbFecReal;
        private System.Windows.Forms.Label lbFecReal;
        private System.Windows.Forms.TextBox tbIdEjemplar;
        private System.Windows.Forms.Label lbIdEjemplar;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.CheckBox CheckActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}


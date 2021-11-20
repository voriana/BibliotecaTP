
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbPlazo = new System.Windows.Forms.Label();
            this.tbPlazo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbDatosAltaPrestamo = new System.Windows.Forms.GroupBox();
            this.tbFecReal = new System.Windows.Forms.TextBox();
            this.lbFecReal = new System.Windows.Forms.Label();
            this.tbIdEjemplar = new System.Windows.Forms.TextBox();
            this.lbIdEjemplar = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.CheckActivo = new System.Windows.Forms.CheckBox();
            this.lbListar = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDatosAltaPrestamo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Enabled = false;
            this.txtIdPrestamo.Location = new System.Drawing.Point(122, 31);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamo.TabIndex = 0;
            // 
            // lbIdPrestamo
            // 
            this.lbIdPrestamo.AutoSize = true;
            this.lbIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPrestamo.Location = new System.Drawing.Point(26, 38);
            this.lbIdPrestamo.Name = "lbIdPrestamo";
            this.lbIdPrestamo.Size = new System.Drawing.Size(66, 13);
            this.lbIdPrestamo.TabIndex = 1;
            this.lbIdPrestamo.Text = "Nro. Ficha";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(29, 192);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(178, 21);
            this.cbClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar Cliente";
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.FormattingEnabled = true;
            this.cbEjemplar.Location = new System.Drawing.Point(29, 272);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(178, 21);
            this.cbEjemplar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Ejemplar";
            // 
            // lbFecPrestamo
            // 
            this.lbFecPrestamo.AutoSize = true;
            this.lbFecPrestamo.Location = new System.Drawing.Point(6, 130);
            this.lbFecPrestamo.Name = "lbFecPrestamo";
            this.lbFecPrestamo.Size = new System.Drawing.Size(99, 13);
            this.lbFecPrestamo.TabIndex = 6;
            this.lbFecPrestamo.Text = "Fecha de Préstamo";
            // 
            // tbfechPrestamo
            // 
            this.tbfechPrestamo.Location = new System.Drawing.Point(172, 123);
            this.tbfechPrestamo.Name = "tbfechPrestamo";
            this.tbfechPrestamo.Size = new System.Drawing.Size(95, 20);
            this.tbfechPrestamo.TabIndex = 7;
            // 
            // lbFecEntrega
            // 
            this.lbFecEntrega.AutoSize = true;
            this.lbFecEntrega.Location = new System.Drawing.Point(6, 159);
            this.lbFecEntrega.Name = "lbFecEntrega";
            this.lbFecEntrega.Size = new System.Drawing.Size(157, 13);
            this.lbFecEntrega.TabIndex = 8;
            this.lbFecEntrega.Text = "Fecha de devolución tentantiva";
            // 
            // tbfecEntrega
            // 
            this.tbfecEntrega.Location = new System.Drawing.Point(172, 152);
            this.tbfecEntrega.Name = "tbfecEntrega";
            this.tbfecEntrega.Size = new System.Drawing.Size(95, 20);
            this.tbfecEntrega.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.Location = new System.Drawing.Point(29, 328);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(147, 328);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(287, 328);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "36903477";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "890175";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbPlazo
            // 
            this.lbPlazo.AutoSize = true;
            this.lbPlazo.Location = new System.Drawing.Point(6, 99);
            this.lbPlazo.Name = "lbPlazo";
            this.lbPlazo.Size = new System.Drawing.Size(87, 13);
            this.lbPlazo.TabIndex = 16;
            this.lbPlazo.Text = "Plazo de entrega";
            // 
            // tbPlazo
            // 
            this.tbPlazo.Location = new System.Drawing.Point(172, 96);
            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.Size = new System.Drawing.Size(95, 20);
            this.tbPlazo.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(526, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(671, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ver Detalle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbDatosAltaPrestamo
            // 
            this.gbDatosAltaPrestamo.Controls.Add(this.tbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbIdEjemplar);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbIdEjemplar);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbIdCliente);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbPlazo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbPlazo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbIdCliente);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbfechPrestamo);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecPrestamo);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbfecEntrega);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecEntrega);
            this.gbDatosAltaPrestamo.Location = new System.Drawing.Point(499, 74);
            this.gbDatosAltaPrestamo.Name = "gbDatosAltaPrestamo";
            this.gbDatosAltaPrestamo.Size = new System.Drawing.Size(277, 248);
            this.gbDatosAltaPrestamo.TabIndex = 20;
            this.gbDatosAltaPrestamo.TabStop = false;
            this.gbDatosAltaPrestamo.Text = "Nuevo Préstamo";
            // 
            // tbFecReal
            // 
            this.tbFecReal.Location = new System.Drawing.Point(172, 189);
            this.tbFecReal.Name = "tbFecReal";
            this.tbFecReal.Size = new System.Drawing.Size(95, 20);
            this.tbFecReal.TabIndex = 26;
            // 
            // lbFecReal
            // 
            this.lbFecReal.AutoSize = true;
            this.lbFecReal.Location = new System.Drawing.Point(6, 189);
            this.lbFecReal.Name = "lbFecReal";
            this.lbFecReal.Size = new System.Drawing.Size(132, 13);
            this.lbFecReal.TabIndex = 25;
            this.lbFecReal.Text = "Fecha de devolución Real";
            // 
            // tbIdEjemplar
            // 
            this.tbIdEjemplar.Location = new System.Drawing.Point(172, 70);
            this.tbIdEjemplar.Name = "tbIdEjemplar";
            this.tbIdEjemplar.Size = new System.Drawing.Size(95, 20);
            this.tbIdEjemplar.TabIndex = 24;
            // 
            // lbIdEjemplar
            // 
            this.lbIdEjemplar.AutoSize = true;
            this.lbIdEjemplar.Location = new System.Drawing.Point(6, 73);
            this.lbIdEjemplar.Name = "lbIdEjemplar";
            this.lbIdEjemplar.Size = new System.Drawing.Size(59, 13);
            this.lbIdEjemplar.TabIndex = 23;
            this.lbIdEjemplar.Text = "Id Ejemplar";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(6, 41);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbIdCliente.TabIndex = 22;
            this.lbIdCliente.Text = "Id Cliente";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(172, 38);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(95, 20);
            this.tbIdCliente.TabIndex = 21;
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;
            this.CheckActivo.Location = new System.Drawing.Point(712, 31);
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.Size = new System.Drawing.Size(56, 17);
            this.CheckActivo.TabIndex = 25;
            this.CheckActivo.Text = "Activo";
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // lbListar
            // 
            this.lbListar.AutoSize = true;
            this.lbListar.Location = new System.Drawing.Point(238, 74);
            this.lbListar.Name = "lbListar";
            this.lbListar.Size = new System.Drawing.Size(84, 13);
            this.lbListar.TabIndex = 28;
            this.lbListar.Text = "Listar Prestamos";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(241, 95);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(217, 225);
            this.lstPrestamos.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(24, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 46);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.lbListar);
            this.Controls.Add(this.CheckActivo);
            this.Controls.Add(this.gbDatosAltaPrestamo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lbIdPrestamo);
            this.Controls.Add(this.txtIdPrestamo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbPlazo;
        private System.Windows.Forms.TextBox tbPlazo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbDatosAltaPrestamo;
        private System.Windows.Forms.TextBox tbFecReal;
        private System.Windows.Forms.Label lbFecReal;
        private System.Windows.Forms.TextBox tbIdEjemplar;
        private System.Windows.Forms.Label lbIdEjemplar;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.CheckBox CheckActivo;
        private System.Windows.Forms.Label lbListar;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


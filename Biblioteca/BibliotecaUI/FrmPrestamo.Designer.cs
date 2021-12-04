
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
            this._btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosAltaPrestamo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFecReal = new System.Windows.Forms.TextBox();
            this.lbFecReal = new System.Windows.Forms.Label();
            this.tbIdEjemplar = new System.Windows.Forms.TextBox();
            this._checkActivo = new System.Windows.Forms.CheckBox();
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
            this.txtIdPrestamo.Location = new System.Drawing.Point(204, 40);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(65, 20);
            this.txtIdPrestamo.TabIndex = 0;
            // 
            // lbIdPrestamo
            // 
            this.lbIdPrestamo.AutoSize = true;
            this.lbIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPrestamo.Location = new System.Drawing.Point(8, 47);
            this.lbIdPrestamo.Name = "lbIdPrestamo";
            this.lbIdPrestamo.Size = new System.Drawing.Size(66, 13);
            this.lbIdPrestamo.TabIndex = 1;
            this.lbIdPrestamo.Text = "Nro. Ficha";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(15, 28);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(194, 21);
            this.cbClientes.TabIndex = 2;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar Cliente";
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.FormattingEnabled = true;
            this.cbEjemplar.Location = new System.Drawing.Point(14, 85);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(195, 21);
            this.cbEjemplar.TabIndex = 4;
            this.cbEjemplar.SelectedIndexChanged += new System.EventHandler(this.cbEjemplar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Ejemplar";
            // 
            // lbFecPrestamo
            // 
            this.lbFecPrestamo.AutoSize = true;
            this.lbFecPrestamo.Location = new System.Drawing.Point(6, 165);
            this.lbFecPrestamo.Name = "lbFecPrestamo";
            this.lbFecPrestamo.Size = new System.Drawing.Size(99, 13);
            this.lbFecPrestamo.TabIndex = 6;
            this.lbFecPrestamo.Text = "Fecha de Préstamo";
            // 
            // tbfechPrestamo
            // 
            this.tbfechPrestamo.Location = new System.Drawing.Point(175, 158);
            this.tbfechPrestamo.Name = "tbfechPrestamo";
            this.tbfechPrestamo.Size = new System.Drawing.Size(95, 20);
            this.tbfechPrestamo.TabIndex = 7;
            // 
            // lbFecEntrega
            // 
            this.lbFecEntrega.AutoSize = true;
            this.lbFecEntrega.Location = new System.Drawing.Point(6, 198);
            this.lbFecEntrega.Name = "lbFecEntrega";
            this.lbFecEntrega.Size = new System.Drawing.Size(157, 13);
            this.lbFecEntrega.TabIndex = 8;
            this.lbFecEntrega.Text = "Fecha de devolución tentantiva";
            // 
            // tbfecEntrega
            // 
            this.tbfecEntrega.Location = new System.Drawing.Point(175, 191);
            this.tbfecEntrega.Name = "tbfecEntrega";
            this.tbfecEntrega.Size = new System.Drawing.Size(95, 20);
            this.tbfecEntrega.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(22, 361);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
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
            this.btnVolver.Location = new System.Drawing.Point(404, 361);
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
            this.radioButton1.Location = new System.Drawing.Point(65, 13);
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
            this.radioButton2.Location = new System.Drawing.Point(153, 13);
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
            this.lbPlazo.Location = new System.Drawing.Point(6, 132);
            this.lbPlazo.Name = "lbPlazo";
            this.lbPlazo.Size = new System.Drawing.Size(87, 13);
            this.lbPlazo.TabIndex = 16;
            this.lbPlazo.Text = "Plazo de entrega";
            // 
            // tbPlazo
            // 
            this.tbPlazo.Location = new System.Drawing.Point(175, 126);
            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.Size = new System.Drawing.Size(95, 20);
            this.tbPlazo.TabIndex = 17;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnGuardar.Location = new System.Drawing.Point(210, 361);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(96, 23);
            this._btnGuardar.TabIndex = 18;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = true;
            this._btnGuardar.Click += new System.EventHandler(this._btnGuardar_Click);
            // 
            // gbDatosAltaPrestamo
            // 
            this.gbDatosAltaPrestamo.Controls.Add(this.groupBox1);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.lbFecReal);
            this.gbDatosAltaPrestamo.Controls.Add(this.tbIdEjemplar);
            this.gbDatosAltaPrestamo.Controls.Add(this._checkActivo);
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
            this.gbDatosAltaPrestamo.Location = new System.Drawing.Point(232, 12);
            this.gbDatosAltaPrestamo.Name = "gbDatosAltaPrestamo";
            this.gbDatosAltaPrestamo.Size = new System.Drawing.Size(279, 310);
            this.gbDatosAltaPrestamo.TabIndex = 20;
            this.gbDatosAltaPrestamo.TabStop = false;
            this.gbDatosAltaPrestamo.Text = "Nuevo Préstamo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(5, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 41);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // tbFecReal
            // 
            this.tbFecReal.Location = new System.Drawing.Point(174, 224);
            this.tbFecReal.Name = "tbFecReal";
            this.tbFecReal.Size = new System.Drawing.Size(95, 20);
            this.tbFecReal.TabIndex = 26;
            // 
            // lbFecReal
            // 
            this.lbFecReal.AutoSize = true;
            this.lbFecReal.Location = new System.Drawing.Point(6, 231);
            this.lbFecReal.Name = "lbFecReal";
            this.lbFecReal.Size = new System.Drawing.Size(132, 13);
            this.lbFecReal.TabIndex = 25;
            this.lbFecReal.Text = "Fecha de devolución Real";
            // 
            // tbIdEjemplar
            // 
            this.tbIdEjemplar.Location = new System.Drawing.Point(175, 96);
            this.tbIdEjemplar.Name = "tbIdEjemplar";
            this.tbIdEjemplar.Size = new System.Drawing.Size(95, 20);
            this.tbIdEjemplar.TabIndex = 24;
            // 
            // _checkActivo
            // 
            this._checkActivo.AutoSize = true;
            this._checkActivo.Location = new System.Drawing.Point(214, 10);
            this._checkActivo.Name = "_checkActivo";
            this._checkActivo.Size = new System.Drawing.Size(56, 17);
            this._checkActivo.TabIndex = 25;
            this._checkActivo.Text = "Activo";
            this._checkActivo.UseVisualStyleBackColor = true;
            this._checkActivo.CheckedChanged += new System.EventHandler(this._checkActivo_CheckedChanged);
            // 
            // lbIdEjemplar
            // 
            this.lbIdEjemplar.AutoSize = true;
            this.lbIdEjemplar.Location = new System.Drawing.Point(6, 99);
            this.lbIdEjemplar.Name = "lbIdEjemplar";
            this.lbIdEjemplar.Size = new System.Drawing.Size(59, 13);
            this.lbIdEjemplar.TabIndex = 23;
            this.lbIdEjemplar.Text = "Id Ejemplar";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(6, 73);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbIdCliente.TabIndex = 22;
            this.lbIdCliente.Text = "Id Cliente";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(175, 66);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(95, 20);
            this.tbIdCliente.TabIndex = 21;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(14, 121);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(195, 199);
            this.lstPrestamos.TabIndex = 21;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(523, 407);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.gbDatosAltaPrestamo);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientes);
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbPlazo;
        private System.Windows.Forms.TextBox tbPlazo;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.GroupBox gbDatosAltaPrestamo;
        private System.Windows.Forms.TextBox tbFecReal;
        private System.Windows.Forms.Label lbFecReal;
        private System.Windows.Forms.TextBox tbIdEjemplar;
        private System.Windows.Forms.Label lbIdEjemplar;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.CheckBox _checkActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}


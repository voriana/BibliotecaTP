
namespace Biblioteca.UI.ClienteFrms
{
    partial class AbmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnAgregar = new System.Windows.Forms.Button();
            this._btnModificar = new System.Windows.Forms.Button();
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._lbCantidadClientes = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(46, 273);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(75, 23);
            this._btnVolver.TabIndex = 0;
            this._btnVolver.Text = "VOLVER";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Location = new System.Drawing.Point(185, 273);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(75, 23);
            this._btnAgregar.TabIndex = 1;
            this._btnAgregar.Text = "AGREGAR";
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // _btnModificar
            // 
            this._btnModificar.Location = new System.Drawing.Point(297, 273);
            this._btnModificar.Name = "_btnModificar";
            this._btnModificar.Size = new System.Drawing.Size(75, 23);
            this._btnModificar.TabIndex = 2;
            this._btnModificar.Text = "MODIFICAR";
            this._btnModificar.UseVisualStyleBackColor = true;
            this._btnModificar.Click += new System.EventHandler(this._btnModificar_Click);
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.Location = new System.Drawing.Point(33, 24);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(351, 225);
            this._lstClientes.TabIndex = 3;
            // 
            // _lbCantidadClientes
            // 
            this._lbCantidadClientes.AutoSize = true;
            this._lbCantidadClientes.Location = new System.Drawing.Point(425, 24);
            this._lbCantidadClientes.Name = "_lbCantidadClientes";
            this._lbCantidadClientes.Size = new System.Drawing.Size(104, 13);
            this._lbCantidadClientes.TabIndex = 4;
            this._lbCantidadClientes.Text = "Cantidad de Clientes";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(428, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Clientes Activos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 335);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this._lbCantidadClientes);
            this.Controls.Add(this._lstClientes);
            this.Controls.Add(this._btnModificar);
            this.Controls.Add(this._btnAgregar);
            this.Controls.Add(this._btnVolver);
            this.Name = "AbmCliente";
            this.Text = "FORMULARIO ABM CLIENTES";
            this.Load += new System.EventHandler(this.AbmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.Button _btnModificar;
        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Label _lbCantidadClientes;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
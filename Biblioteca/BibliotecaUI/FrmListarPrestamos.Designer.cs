
namespace BibliotecaUI
{
    partial class FrmListarPrestamos
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
            this._cbPrestamo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lstPrestamos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtPrecioEjemplar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._txtAutor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cbPrestamo
            // 
            this._cbPrestamo.FormattingEnabled = true;
            this._cbPrestamo.Location = new System.Drawing.Point(28, 52);
            this._cbPrestamo.Name = "_cbPrestamo";
            this._cbPrestamo.Size = new System.Drawing.Size(173, 30);
            this._cbPrestamo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de prestamo a buscar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._lstPrestamos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 363);
            this.panel1.TabIndex = 2;
            // 
            // _lstPrestamos
            // 
            this._lstPrestamos.FormattingEnabled = true;
            this._lstPrestamos.ItemHeight = 22;
            this._lstPrestamos.Location = new System.Drawing.Point(22, 42);
            this._lstPrestamos.Name = "_lstPrestamos";
            this._lstPrestamos.Size = new System.Drawing.Size(564, 290);
            this._lstPrestamos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Listado de prestamos existentes";
            // 
            // _txtPrecioEjemplar
            // 
            this._txtPrecioEjemplar.Location = new System.Drawing.Point(510, 43);
            this._txtPrecioEjemplar.Name = "_txtPrecioEjemplar";
            this._txtPrecioEjemplar.Size = new System.Drawing.Size(116, 28);
            this._txtPrecioEjemplar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio del Ejemplar";
            // 
            // _txtTitulo
            // 
            this._txtTitulo.Location = new System.Drawing.Point(510, 89);
            this._txtTitulo.Name = "_txtTitulo";
            this._txtTitulo.Size = new System.Drawing.Size(116, 28);
            this._txtTitulo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Titulo Libro";
            // 
            // _txtNombreCliente
            // 
            this._txtNombreCliente.Location = new System.Drawing.Point(885, 43);
            this._txtNombreCliente.Name = "_txtNombreCliente";
            this._txtNombreCliente.Size = new System.Drawing.Size(116, 28);
            this._txtNombreCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado de busqueda";
            // 
            // _btnVolver
            // 
            this._btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnVolver.Location = new System.Drawing.Point(96, 527);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(118, 39);
            this._btnVolver.TabIndex = 2;
            this._btnVolver.Text = "VOLVER";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnLimpiar.Location = new System.Drawing.Point(473, 527);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(109, 39);
            this._btnLimpiar.TabIndex = 4;
            this._btnLimpiar.Text = "LIMPIAR";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnBuscar.Location = new System.Drawing.Point(829, 527);
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(111, 39);
            this._btnBuscar.TabIndex = 5;
            this._btnBuscar.Text = "BUSCAR";
            this._btnBuscar.UseVisualStyleBackColor = true;
            this._btnBuscar.Click += new System.EventHandler(this._btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Autor del  Libro";
            // 
            // _txtAutor
            // 
            this._txtAutor.Location = new System.Drawing.Point(885, 86);
            this._txtAutor.Name = "_txtAutor";
            this._txtAutor.Size = new System.Drawing.Size(116, 28);
            this._txtAutor.TabIndex = 9;
            // 
            // FrmListarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1059, 583);
            this.Controls.Add(this._txtAutor);
            this.Controls.Add(this._txtPrecioEjemplar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtTitulo);
            this.Controls.Add(this._btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtNombreCliente);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbPrestamo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListarPrestamos";
            this.Text = "FrmListarPrestamos";
            this.Load += new System.EventHandler(this.FrmListarPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox _lstPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtPrecioEjemplar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtAutor;
    }
}
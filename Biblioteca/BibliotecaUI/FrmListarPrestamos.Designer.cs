
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
            this._cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtPrecioEjemplar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._txtDniCli = new System.Windows.Forms.TextBox();
            this._txtTitulo = new System.Windows.Forms.TextBox();
            this._txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtFecPrestamo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lstPrestamos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cbClientes
            // 
            this._cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbClientes.FormattingEnabled = true;
            this._cbClientes.Location = new System.Drawing.Point(41, 58);
            this._cbClientes.Name = "_cbClientes";
            this._cbClientes.Size = new System.Drawing.Size(391, 23);
            this._cbClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // _txtPrecioEjemplar
            // 
            this._txtPrecioEjemplar.Location = new System.Drawing.Point(174, 142);
            this._txtPrecioEjemplar.Name = "_txtPrecioEjemplar";
            this._txtPrecioEjemplar.Size = new System.Drawing.Size(139, 21);
            this._txtPrecioEjemplar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio del Ejemplar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Titulo Libro";
            // 
            // _txtAutor
            // 
            this._txtAutor.Location = new System.Drawing.Point(150, 317);
            this._txtAutor.Name = "_txtAutor";
            this._txtAutor.Size = new System.Drawing.Size(163, 21);
            this._txtAutor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI Cliente";
            // 
            // _btnVolver
            // 
            this._btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnVolver.Location = new System.Drawing.Point(28, 532);
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
            this._btnLimpiar.Location = new System.Drawing.Point(288, 532);
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
            this._btnBuscar.Location = new System.Drawing.Point(539, 532);
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
            this.label6.Location = new System.Drawing.Point(29, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Autor del  Libro";
            // 
            // _txtDniCli
            // 
            this._txtDniCli.Location = new System.Drawing.Point(148, 362);
            this._txtDniCli.Multiline = true;
            this._txtDniCli.Name = "_txtDniCli";
            this._txtDniCli.Size = new System.Drawing.Size(165, 21);
            this._txtDniCli.TabIndex = 9;
            // 
            // _txtTitulo
            // 
            this._txtTitulo.Location = new System.Drawing.Point(150, 252);
            this._txtTitulo.Multiline = true;
            this._txtTitulo.Name = "_txtTitulo";
            this._txtTitulo.Size = new System.Drawing.Size(163, 41);
            this._txtTitulo.TabIndex = 7;
            // 
            // _txtObservaciones
            // 
            this._txtObservaciones.Location = new System.Drawing.Point(150, 187);
            this._txtObservaciones.Multiline = true;
            this._txtObservaciones.Name = "_txtObservaciones";
            this._txtObservaciones.Size = new System.Drawing.Size(163, 41);
            this._txtObservaciones.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Observaciones ";
            // 
            // _txtFecPrestamo
            // 
            this._txtFecPrestamo.Location = new System.Drawing.Point(174, 97);
            this._txtFecPrestamo.Name = "_txtFecPrestamo";
            this._txtFecPrestamo.Size = new System.Drawing.Size(139, 21);
            this._txtFecPrestamo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha de prestamo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtEstado);
            this.groupBox1.Controls.Add(this._txtObservaciones);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._txtTitulo);
            this.groupBox1.Controls.Add(this._txtFecPrestamo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtAutor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._txtDniCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._txtPrecioEjemplar);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(438, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 406);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado prestamo";
            // 
            // _txtEstado
            // 
            this._txtEstado.Location = new System.Drawing.Point(174, 43);
            this._txtEstado.Name = "_txtEstado";
            this._txtEstado.Size = new System.Drawing.Size(139, 21);
            this._txtEstado.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lstPrestamos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(8, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 409);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamos existentes";
            // 
            // _lstPrestamos
            // 
            this._lstPrestamos.FormattingEnabled = true;
            this._lstPrestamos.ItemHeight = 15;
            this._lstPrestamos.Location = new System.Drawing.Point(20, 26);
            this._lstPrestamos.Name = "_lstPrestamos";
            this._lstPrestamos.Size = new System.Drawing.Size(374, 364);
            this._lstPrestamos.TabIndex = 3;
            this._lstPrestamos.SelectedIndexChanged += new System.EventHandler(this._lstPrestamos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(153, -103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado de busqueda por Cliente";
            // 
            // FrmListarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(790, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnBuscar);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListarPrestamos";
            this.Text = "FrmListarPrestamos";
            this.Load += new System.EventHandler(this.FrmListarPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtPrecioEjemplar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtDniCli;
        private System.Windows.Forms.TextBox _txtTitulo;
        private System.Windows.Forms.TextBox _txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtFecPrestamo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox _lstPrestamos;
        private System.Windows.Forms.Label label3;
    }
}
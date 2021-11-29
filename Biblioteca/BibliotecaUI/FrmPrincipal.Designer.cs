
namespace BibliotecaUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarPres = new System.Windows.Forms.Button();
            this.btnAltaPrestamo = new System.Windows.Forms.Button();
            this.gbEjemplares = new System.Windows.Forms.GroupBox();
            this.btnListarEjemplar = new System.Windows.Forms.Button();
            this.btnAltaEjemplar = new System.Windows.Forms.Button();
            this.gbAltaLibro = new System.Windows.Forms.GroupBox();
            this.btnListarLibros = new System.Windows.Forms.Button();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEjemplares.SuspendLayout();
            this.gbAltaLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnListarCliente);
            this.gbClientes.Controls.Add(this.btnAltaCliente);
            this.gbClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.Location = new System.Drawing.Point(25, 89);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbClientes.Size = new System.Drawing.Size(177, 133);
            this.gbClientes.TabIndex = 0;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Módulo Clientes";
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCliente.Location = new System.Drawing.Point(32, 83);
            this.btnListarCliente.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(110, 23);
            this.btnListarCliente.TabIndex = 3;
            this.btnListarCliente.Text = "Listar Clientes";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.Location = new System.Drawing.Point(32, 40);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(110, 23);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarPres);
            this.groupBox1.Controls.Add(this.btnAltaPrestamo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módulo Préstamos";
            // 
            // btnListarPres
            // 
            this.btnListarPres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPres.Location = new System.Drawing.Point(31, 83);
            this.btnListarPres.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnListarPres.Name = "btnListarPres";
            this.btnListarPres.Size = new System.Drawing.Size(110, 23);
            this.btnListarPres.TabIndex = 2;
            this.btnListarPres.Text = "Listar Prestamos";
            this.btnListarPres.UseVisualStyleBackColor = true;
            // 
            // btnAltaPrestamo
            // 
            this.btnAltaPrestamo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaPrestamo.Location = new System.Drawing.Point(31, 40);
            this.btnAltaPrestamo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAltaPrestamo.Name = "btnAltaPrestamo";
            this.btnAltaPrestamo.Size = new System.Drawing.Size(110, 23);
            this.btnAltaPrestamo.TabIndex = 1;
            this.btnAltaPrestamo.Text = "Alta Préstamo";
            this.btnAltaPrestamo.UseVisualStyleBackColor = true;
            this.btnAltaPrestamo.Click += new System.EventHandler(this.btnAltaPrestamo_Click);
            // 
            // gbEjemplares
            // 
            this.gbEjemplares.Controls.Add(this.btnListarEjemplar);
            this.gbEjemplares.Controls.Add(this.btnAltaEjemplar);
            this.gbEjemplares.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEjemplares.Location = new System.Drawing.Point(235, 89);
            this.gbEjemplares.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbEjemplares.Name = "gbEjemplares";
            this.gbEjemplares.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbEjemplares.Size = new System.Drawing.Size(177, 133);
            this.gbEjemplares.TabIndex = 1;
            this.gbEjemplares.TabStop = false;
            this.gbEjemplares.Text = "Módulo Ejemplares";
            // 
            // btnListarEjemplar
            // 
            this.btnListarEjemplar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEjemplar.Location = new System.Drawing.Point(28, 83);
            this.btnListarEjemplar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnListarEjemplar.Name = "btnListarEjemplar";
            this.btnListarEjemplar.Size = new System.Drawing.Size(110, 23);
            this.btnListarEjemplar.TabIndex = 3;
            this.btnListarEjemplar.Text = "Listar Ejemplares";
            this.btnListarEjemplar.UseVisualStyleBackColor = true;
            this.btnListarEjemplar.Click += new System.EventHandler(this.btnListarEjemplar_Click);
            // 
            // btnAltaEjemplar
            // 
            this.btnAltaEjemplar.AutoSize = true;
            this.btnAltaEjemplar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEjemplar.Location = new System.Drawing.Point(28, 40);
            this.btnAltaEjemplar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAltaEjemplar.Name = "btnAltaEjemplar";
            this.btnAltaEjemplar.Size = new System.Drawing.Size(129, 33);
            this.btnAltaEjemplar.TabIndex = 2;
            this.btnAltaEjemplar.Text = "Alta Ejemplar";
            this.btnAltaEjemplar.UseVisualStyleBackColor = true;
            this.btnAltaEjemplar.Click += new System.EventHandler(this.btnAltaEjemplar_Click);
            // 
            // gbAltaLibro
            // 
            this.gbAltaLibro.AutoSize = true;
            this.gbAltaLibro.Controls.Add(this.btnListarLibros);
            this.gbAltaLibro.Controls.Add(this.btnAltaLibro);
            this.gbAltaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAltaLibro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAltaLibro.Location = new System.Drawing.Point(235, 230);
            this.gbAltaLibro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAltaLibro.Name = "gbAltaLibro";
            this.gbAltaLibro.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAltaLibro.Size = new System.Drawing.Size(177, 141);
            this.gbAltaLibro.TabIndex = 1;
            this.gbAltaLibro.TabStop = false;
            this.gbAltaLibro.Text = "Módulo Libro";
            // 
            // btnListarLibros
            // 
            this.btnListarLibros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarLibros.Location = new System.Drawing.Point(32, 83);
            this.btnListarLibros.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnListarLibros.Name = "btnListarLibros";
            this.btnListarLibros.Size = new System.Drawing.Size(110, 23);
            this.btnListarLibros.TabIndex = 4;
            this.btnListarLibros.Text = "Listar Libros";
            this.btnListarLibros.UseVisualStyleBackColor = true;
            this.btnListarLibros.Click += new System.EventHandler(this.btnListarLibros_Click);
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAltaLibro.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAltaLibro.FlatAppearance.BorderSize = 9;
            this.btnAltaLibro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaLibro.Location = new System.Drawing.Point(32, 40);
            this.btnAltaLibro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(110, 23);
            this.btnAltaLibro.TabIndex = 3;
            this.btnAltaLibro.Text = "Alta Libro";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPCIONES DEL SISTEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(448, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAltaLibro);
            this.Controls.Add(this.gbEjemplares);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.Text = "Biblioteca Jeremias SpringField";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gbClientes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbEjemplares.ResumeLayout(false);
            this.gbEjemplares.PerformLayout();
            this.gbAltaLibro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaPrestamo;
        private System.Windows.Forms.GroupBox gbEjemplares;
        private System.Windows.Forms.Button btnAltaEjemplar;
        private System.Windows.Forms.GroupBox gbAltaLibro;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Button btnListarPres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnListarEjemplar;
        private System.Windows.Forms.Button btnListarLibros;
    }
}
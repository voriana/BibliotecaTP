
namespace BibliotecaUI
{
    partial class FrmAltaLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaLibro));
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.lbTema = new System.Windows.Forms.Label();
            this.lbEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lbPag = new System.Windows.Forms.Label();
            this.txtPags = new System.Windows.Forms.TextBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCantidadLibros = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(5, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(46, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id Libro";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 22);
            this.txtId.TabIndex = 1;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(6, 61);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(35, 13);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(95, 58);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(159, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Location = new System.Drawing.Point(6, 224);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(54, 13);
            this.lbEditorial.TabIndex = 4;
            this.lbEditorial.Text = "Editorital";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(95, 91);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(159, 53);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(95, 155);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(159, 22);
            this.txtTema.TabIndex = 6;
            // 
            // lbTema
            // 
            this.lbTema.AutoSize = true;
            this.lbTema.Location = new System.Drawing.Point(6, 158);
            this.lbTema.Name = "lbTema";
            this.lbTema.Size = new System.Drawing.Size(34, 13);
            this.lbTema.TabIndex = 7;
            this.lbTema.Text = "Tema";
            // 
            // lbEdicion
            // 
            this.lbEdicion.AutoSize = true;
            this.lbEdicion.Location = new System.Drawing.Point(5, 191);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(44, 13);
            this.lbEdicion.TabIndex = 8;
            this.lbEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(95, 188);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(159, 22);
            this.txtEdicion.TabIndex = 9;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(6, 94);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(36, 13);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Titulo";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(95, 221);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(159, 22);
            this.txtEditorial.TabIndex = 11;
            // 
            // lbPag
            // 
            this.lbPag.AutoSize = true;
            this.lbPag.Location = new System.Drawing.Point(5, 257);
            this.lbPag.Name = "lbPag";
            this.lbPag.Size = new System.Drawing.Size(78, 13);
            this.lbPag.TabIndex = 12;
            this.lbPag.Text = "Cant.  Páginas";
            // 
            // txtPags
            // 
            this.txtPags.Location = new System.Drawing.Point(95, 254);
            this.txtPags.Name = "txtPags";
            this.txtPags.Size = new System.Drawing.Size(159, 22);
            this.txtPags.TabIndex = 13;
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(17, 4);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(243, 264);
            this.lstLibros.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.BorderSize = 4;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnGuardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Location = new System.Drawing.Point(150, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 4;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(17, 353);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.FlatAppearance.BorderSize = 4;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnVolver.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.Location = new System.Drawing.Point(472, 353);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 4;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRefrescar.Location = new System.Drawing.Point(311, 353);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(103, 23);
            this.btnRefrescar.TabIndex = 21;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lbAutor);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.lbEditorial);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.txtPags);
            this.panel1.Controls.Add(this.txtTema);
            this.panel1.Controls.Add(this.lbPag);
            this.panel1.Controls.Add(this.lbTema);
            this.panel1.Controls.Add(this.txtEditorial);
            this.panel1.Controls.Add(this.lbEdicion);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.txtEdicion);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 308);
            this.panel1.TabIndex = 22;
            // 
            // lbCantidadLibros
            // 
            this.lbCantidadLibros.AutoSize = true;
            this.lbCantidadLibros.Location = new System.Drawing.Point(59, 284);
            this.lbCantidadLibros.Name = "lbCantidadLibros";
            this.lbCantidadLibros.Size = new System.Drawing.Size(155, 13);
            this.lbCantidadLibros.TabIndex = 23;
            this.lbCantidadLibros.Text = "Cantidad de libros Existentes";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(220, 275);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(40, 22);
            this.txtCant.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstLibros);
            this.panel2.Controls.Add(this.txtCant);
            this.panel2.Controls.Add(this.lbCantidadLibros);
            this.panel2.Location = new System.Drawing.Point(294, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 308);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Alta Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Libros Registrados";
            // 
            // FrmAltaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(578, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaLibro";
            this.Text = "Registro Libro";
            this.Load += new System.EventHandler(this.FrmAltaLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lbEditorial;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label lbTema;
        private System.Windows.Forms.Label lbEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lbPag;
        private System.Windows.Forms.TextBox txtPags;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCantidadLibros;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
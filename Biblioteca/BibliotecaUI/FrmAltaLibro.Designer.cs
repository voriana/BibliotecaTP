
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
            this.txPags = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(14, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(46, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id Libro";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(387, 32);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(35, 13);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(456, 25);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Location = new System.Drawing.Point(14, 226);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(54, 13);
            this.lbEditorial.TabIndex = 4;
            this.lbEditorial.Text = "Editorital";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(138, 73);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 45);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(138, 138);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(100, 22);
            this.txtTema.TabIndex = 6;
            // 
            // lbTema
            // 
            this.lbTema.AutoSize = true;
            this.lbTema.Location = new System.Drawing.Point(14, 141);
            this.lbTema.Name = "lbTema";
            this.lbTema.Size = new System.Drawing.Size(34, 13);
            this.lbTema.TabIndex = 7;
            this.lbTema.Text = "Tema";
            // 
            // lbEdicion
            // 
            this.lbEdicion.AutoSize = true;
            this.lbEdicion.Location = new System.Drawing.Point(14, 185);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(44, 13);
            this.lbEdicion.TabIndex = 8;
            this.lbEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(138, 182);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(100, 22);
            this.txtEdicion.TabIndex = 9;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(14, 77);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(36, 13);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Titulo";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(138, 223);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 22);
            this.txtEditorial.TabIndex = 11;
            // 
            // lbPag
            // 
            this.lbPag.AutoSize = true;
            this.lbPag.Location = new System.Drawing.Point(14, 276);
            this.lbPag.Name = "lbPag";
            this.lbPag.Size = new System.Drawing.Size(78, 13);
            this.lbPag.TabIndex = 12;
            this.lbPag.Text = "Cant.  Páginas";
            // 
            // txPags
            // 
            this.txPags.Location = new System.Drawing.Point(138, 269);
            this.txPags.Name = "txPags";
            this.txPags.Size = new System.Drawing.Size(100, 22);
            this.txPags.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(390, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 212);
            this.listBox1.TabIndex = 15;
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListar.FlatAppearance.BorderSize = 4;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListar.Location = new System.Drawing.Point(246, 331);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Guardar cambios";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 4;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Location = new System.Drawing.Point(137, 331);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.FlatAppearance.BorderSize = 4;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.Location = new System.Drawing.Point(383, 331);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmAltaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(648, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txPags);
            this.Controls.Add(this.lbPag);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.lbEdicion);
            this.Controls.Add(this.lbTema);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaLibro";
            this.Text = "Registro Libro";
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
        private System.Windows.Forms.TextBox txPags;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
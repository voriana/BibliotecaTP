
namespace Biblioteca.UI
{
    partial class FrmPrincipal
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
            this._btnClientes = new System.Windows.Forms.Button();
            this._btnPrestamos = new System.Windows.Forms.Button();
            this._btnEjemplares = new System.Windows.Forms.Button();
            this._btnLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnClientes
            // 
            this._btnClientes.Location = new System.Drawing.Point(49, 68);
            this._btnClientes.Name = "_btnClientes";
            this._btnClientes.Size = new System.Drawing.Size(92, 49);
            this._btnClientes.TabIndex = 0;
            this._btnClientes.Text = "MODULO CLIENTES";
            this._btnClientes.UseVisualStyleBackColor = true;
            this._btnClientes.Click += new System.EventHandler(this._btnClientes_Click);
            // 
            // _btnPrestamos
            // 
            this._btnPrestamos.Location = new System.Drawing.Point(177, 68);
            this._btnPrestamos.Name = "_btnPrestamos";
            this._btnPrestamos.Size = new System.Drawing.Size(92, 49);
            this._btnPrestamos.TabIndex = 1;
            this._btnPrestamos.Text = "MODULO PRESTAMOS";
            this._btnPrestamos.UseVisualStyleBackColor = true;
            this._btnPrestamos.Click += new System.EventHandler(this._btnPrestamos_Click);
            // 
            // _btnEjemplares
            // 
            this._btnEjemplares.Location = new System.Drawing.Point(177, 147);
            this._btnEjemplares.Name = "_btnEjemplares";
            this._btnEjemplares.Size = new System.Drawing.Size(92, 49);
            this._btnEjemplares.TabIndex = 2;
            this._btnEjemplares.Text = "MODULO EJEMPLARES";
            this._btnEjemplares.UseVisualStyleBackColor = true;
            this._btnEjemplares.Click += new System.EventHandler(this._btnEjemplares_Click);
            // 
            // _btnLibros
            // 
            this._btnLibros.Location = new System.Drawing.Point(49, 147);
            this._btnLibros.Name = "_btnLibros";
            this._btnLibros.Size = new System.Drawing.Size(92, 49);
            this._btnLibros.TabIndex = 3;
            this._btnLibros.Text = "MODULO LIBROS";
            this._btnLibros.UseVisualStyleBackColor = true;
            this._btnLibros.Click += new System.EventHandler(this._btnLibros_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 315);
            this.Controls.Add(this._btnLibros);
            this.Controls.Add(this._btnEjemplares);
            this.Controls.Add(this._btnPrestamos);
            this.Controls.Add(this._btnClientes);
            this.Name = "FrmPrincipal";
            this.Text = "Biblioteca Jeremias Springfield";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnClientes;
        private System.Windows.Forms.Button _btnPrestamos;
        private System.Windows.Forms.Button _btnEjemplares;
        private System.Windows.Forms.Button _btnLibros;
    }
}


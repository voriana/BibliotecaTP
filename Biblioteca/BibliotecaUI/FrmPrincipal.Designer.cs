
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
            this.btClientes = new System.Windows.Forms.Button();
            this.btPrestamos = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClientes
            // 
            this.btClientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btClientes.Location = new System.Drawing.Point(63, 39);
            this.btClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(168, 39);
            this.btClientes.TabIndex = 0;
            this.btClientes.Text = "Módulo Clientes";
            this.btClientes.UseVisualStyleBackColor = false;
            // 
            // btPrestamos
            // 
            this.btPrestamos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btPrestamos.Location = new System.Drawing.Point(63, 86);
            this.btPrestamos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btPrestamos.Name = "btPrestamos";
            this.btPrestamos.Size = new System.Drawing.Size(168, 39);
            this.btPrestamos.TabIndex = 1;
            this.btPrestamos.Text = "Módulo Préstamos";
            this.btPrestamos.UseVisualStyleBackColor = false;
            this.btPrestamos.Click += new System.EventHandler(this.btPrestamos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLibros.Location = new System.Drawing.Point(63, 133);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(168, 39);
            this.btnLibros.TabIndex = 2;
            this.btnLibros.Text = "Módulo Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEjemplares.Location = new System.Drawing.Point(63, 180);
            this.btnEjemplares.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.Size = new System.Drawing.Size(168, 39);
            this.btnEjemplares.TabIndex = 3;
            this.btnEjemplares.Text = "Módulo Ejemplares";
            this.btnEjemplares.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(298, 277);
            this.Controls.Add(this.btnEjemplares);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btPrestamos);
            this.Controls.Add(this.btClientes);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Principal";
            this.Text = "Biblioteca Jeremias SpringField";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btPrestamos;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnEjemplares;
    }
}
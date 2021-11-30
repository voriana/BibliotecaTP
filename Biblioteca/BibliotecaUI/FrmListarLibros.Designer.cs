
namespace BibliotecaUI
{
    partial class FrmListarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarLibros));
            this._lstLibros = new System.Windows.Forms.ListBox();
            this._btnBuscar = new System.Windows.Forms.Button();
            this._txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtTitulo = new System.Windows.Forms.TextBox();
            this.CbIdLibro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lstLibros
            // 
            this._lstLibros.FormattingEnabled = true;
            this._lstLibros.ItemHeight = 17;
            this._lstLibros.Location = new System.Drawing.Point(13, 50);
            this._lstLibros.Margin = new System.Windows.Forms.Padding(4);
            this._lstLibros.Name = "_lstLibros";
            this._lstLibros.Size = new System.Drawing.Size(375, 225);
            this._lstLibros.TabIndex = 0;
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Location = new System.Drawing.Point(465, 291);
            this._btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(159, 30);
            this._btnBuscar.TabIndex = 1;
            this._btnBuscar.Text = "BUSCAR";
            this._btnBuscar.UseVisualStyleBackColor = true;
            this._btnBuscar.Click += new System.EventHandler(this._btnBuscar_Click);
            // 
            // _txtAutor
            // 
            this._txtAutor.Location = new System.Drawing.Point(465, 63);
            this._txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this._txtAutor.Name = "_txtAutor";
            this._txtAutor.Size = new System.Drawing.Size(157, 25);
            this._txtAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda por Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(16, 291);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(163, 30);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "VOLVER";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this.Volver_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Busqueda por Titulo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _txtTitulo
            // 
            this._txtTitulo.Location = new System.Drawing.Point(465, 145);
            this._txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this._txtTitulo.Name = "_txtTitulo";
            this._txtTitulo.Size = new System.Drawing.Size(157, 25);
            this._txtTitulo.TabIndex = 6;
            // 
            // CbIdLibro
            // 
            this.CbIdLibro.FormattingEnabled = true;
            this.CbIdLibro.Location = new System.Drawing.Point(501, 230);
            this.CbIdLibro.Name = "CbIdLibro";
            this.CbIdLibro.Size = new System.Drawing.Size(121, 25);
            this.CbIdLibro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Listado de Libros Existentes";
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(239, 291);
            this._btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(159, 30);
            this._btnLimpiar.TabIndex = 9;
            this._btnLimpiar.Text = "LIMPIAR";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Busqueda por Id Libro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmListarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(685, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbIdLibro);
            this.Controls.Add(this._txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtAutor);
            this.Controls.Add(this._btnBuscar);
            this.Controls.Add(this._lstLibros);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListarLibros";
            this.Text = "Libros Existentes";
            this.Load += new System.EventHandler(this.FrmListarLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstLibros;
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.TextBox _txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtTitulo;
        private System.Windows.Forms.ComboBox CbIdLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Label label4;
    }
}
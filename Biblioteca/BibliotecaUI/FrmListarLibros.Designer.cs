
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lstLibros
            // 
            this._lstLibros.FormattingEnabled = true;
            this._lstLibros.ItemHeight = 17;
            this._lstLibros.Location = new System.Drawing.Point(51, 24);
            this._lstLibros.Margin = new System.Windows.Forms.Padding(4);
            this._lstLibros.Name = "_lstLibros";
            this._lstLibros.Size = new System.Drawing.Size(332, 191);
            this._lstLibros.TabIndex = 0;
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Location = new System.Drawing.Point(465, 97);
            this._btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(159, 30);
            this._btnBuscar.TabIndex = 1;
            this._btnBuscar.Text = "Buscar";
            this._btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda por Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(51, 238);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(332, 30);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "VOLVER";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this.Volver_click);
            // 
            // FrmListarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(685, 344);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._btnBuscar);
            this.Controls.Add(this._lstLibros);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListarLibros";
            this.Text = "Libros Existentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstLibros;
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnVolver;
    }
}
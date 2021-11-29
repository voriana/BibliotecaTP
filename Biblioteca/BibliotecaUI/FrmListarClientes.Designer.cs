
namespace BibliotecaUI
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIDClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.txbFechaAlta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChbNoActivo = new System.Windows.Forms.CheckBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar Clientes";
            // 
            // cmbIDClientes
            // 
            this.cmbIDClientes.FormattingEnabled = true;
            this.cmbIDClientes.Location = new System.Drawing.Point(45, 134);
            this.cmbIDClientes.Name = "cmbIDClientes";
            this.cmbIDClientes.Size = new System.Drawing.Size(121, 28);
            this.cmbIDClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(45, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(610, 55);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(135, 26);
            this.txbID.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(345, 325);
            this.txbMail.Name = "txbMail";
            this.txbMail.ReadOnly = true;
            this.txbMail.Size = new System.Drawing.Size(128, 26);
            this.txbMail.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mail";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(345, 275);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.ReadOnly = true;
            this.txbTelefono.Size = new System.Drawing.Size(128, 26);
            this.txbTelefono.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(345, 225);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.ReadOnly = true;
            this.txbDireccion.Size = new System.Drawing.Size(128, 26);
            this.txbDireccion.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direccion";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(345, 173);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.ReadOnly = true;
            this.txbApellido.Size = new System.Drawing.Size(128, 26);
            this.txbApellido.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Apellido";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(345, 115);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.ReadOnly = true;
            this.txbNombre.Size = new System.Drawing.Size(128, 26);
            this.txbNombre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(345, 55);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.ReadOnly = true;
            this.txbDNI.Size = new System.Drawing.Size(128, 26);
            this.txbDNI.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "DNI";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(610, 165);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.ReadOnly = true;
            this.txbUsuario.Size = new System.Drawing.Size(135, 26);
            this.txbUsuario.TabIndex = 36;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(513, 165);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 20);
            this.Usuario.TabIndex = 35;
            this.Usuario.Text = "Usuario";
            // 
            // txbFechaAlta
            // 
            this.txbFechaAlta.Location = new System.Drawing.Point(610, 115);
            this.txbFechaAlta.Name = "txbFechaAlta";
            this.txbFechaAlta.ReadOnly = true;
            this.txbFechaAlta.Size = new System.Drawing.Size(135, 26);
            this.txbFechaAlta.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label11.Location = new System.Drawing.Point(513, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Fecha Alta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(580, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 35);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChbNoActivo);
            this.groupBox1.Controls.Add(this.chbActivo);
            this.groupBox1.Location = new System.Drawing.Point(536, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activo";
            // 
            // ChbNoActivo
            // 
            this.ChbNoActivo.AutoSize = true;
            this.ChbNoActivo.Location = new System.Drawing.Point(25, 76);
            this.ChbNoActivo.Name = "ChbNoActivo";
            this.ChbNoActivo.Size = new System.Drawing.Size(102, 24);
            this.ChbNoActivo.TabIndex = 1;
            this.ChbNoActivo.Text = "No Activo";
            this.ChbNoActivo.UseVisualStyleBackColor = true;
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(25, 35);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(78, 24);
            this.chbActivo.TabIndex = 0;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(345, 389);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(108, 35);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txbFechaAlta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIDClientes);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "FrmListarClientes";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIDClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txbFechaAlta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChbNoActivo;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Button btnVolver;
    }
}
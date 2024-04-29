namespace PryPerezFederico
{
    partial class frmMostrarEmpleados
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
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numerodecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(493, 23);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(427, 38);
            this.btnAgregarEmpleado.TabIndex = 45;
            this.btnAgregarEmpleado.Text = "Agregar un nuevo cliente";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCargarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarEmpleado.Location = new System.Drawing.Point(55, 24);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(403, 38);
            this.btnCargarEmpleado.TabIndex = 44;
            this.btnCargarEmpleado.Text = "Cargar todos los clientes";
            this.btnCargarEmpleado.UseVisualStyleBackColor = false;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // grilla
            // 
            this.grilla.AccessibleName = "";
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.DNI,
            this.Sexo,
            this.Direccion,
            this.Telefono,
            this.CodigoPostal,
            this.Numerodecliente});
            this.grilla.Location = new System.Drawing.Point(5, 77);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(943, 418);
            this.grilla.TabIndex = 43;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.HeaderText = "Cod.Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            // 
            // Numerodecliente
            // 
            this.Numerodecliente.HeaderText = "Numero de Empleado";
            this.Numerodecliente.Name = "Numerodecliente";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(765, 518);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(176, 41);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmMostrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmMostrarEmpleados";
            this.Text = "MOSTRAR EMPLEADOS";
            this.Load += new System.EventHandler(this.MOSTRAR_EMPLEADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numerodecliente;
    }
}
namespace FrbaHotel.AbmCliente
{
    partial class ListadoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente_Tipo_ID = new System.Windows.Forms.ComboBox();
            this.txtCliente_Mail = new System.Windows.Forms.TextBox();
            this.txtCliente_ID = new System.Windows.Forms.TextBox();
            this.txtCliente_Apellido = new System.Windows.Forms.TextBox();
            this.txtCliente_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Tabla_Clientes = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Tipo_Docu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Numero_Docu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Calle_Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_País_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Nacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Nuevo_Cliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCantidadTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tabla_Clientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente_Tipo_ID);
            this.groupBox1.Controls.Add(this.txtCliente_Mail);
            this.groupBox1.Controls.Add(this.txtCliente_ID);
            this.groupBox1.Controls.Add(this.txtCliente_Apellido);
            this.groupBox1.Controls.Add(this.txtCliente_Nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // cmbCliente_Tipo_ID
            // 
            this.cmbCliente_Tipo_ID.FormattingEnabled = true;
            this.cmbCliente_Tipo_ID.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE"});
            this.cmbCliente_Tipo_ID.Location = new System.Drawing.Point(181, 83);
            this.cmbCliente_Tipo_ID.Name = "cmbCliente_Tipo_ID";
            this.cmbCliente_Tipo_ID.Size = new System.Drawing.Size(164, 28);
            this.cmbCliente_Tipo_ID.TabIndex = 9;
            // 
            // txtCliente_Mail
            // 
            this.txtCliente_Mail.Location = new System.Drawing.Point(72, 125);
            this.txtCliente_Mail.Name = "txtCliente_Mail";
            this.txtCliente_Mail.Size = new System.Drawing.Size(158, 26);
            this.txtCliente_Mail.TabIndex = 8;
            // 
            // txtCliente_ID
            // 
            this.txtCliente_ID.Location = new System.Drawing.Point(590, 85);
            this.txtCliente_ID.Name = "txtCliente_ID";
            this.txtCliente_ID.Size = new System.Drawing.Size(176, 26);
            this.txtCliente_ID.TabIndex = 7;
            // 
            // txtCliente_Apellido
            // 
            this.txtCliente_Apellido.Location = new System.Drawing.Point(510, 37);
            this.txtCliente_Apellido.Name = "txtCliente_Apellido";
            this.txtCliente_Apellido.Size = new System.Drawing.Size(256, 26);
            this.txtCliente_Apellido.TabIndex = 6;
            // 
            // txtCliente_Nombre
            // 
            this.txtCliente_Nombre.Location = new System.Drawing.Point(89, 40);
            this.txtCliente_Nombre.Name = "txtCliente_Nombre";
            this.txtCliente_Nombre.Size = new System.Drawing.Size(256, 26);
            this.txtCliente_Nombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro. de identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dGV_Tabla_Clientes
            // 
            this.dGV_Tabla_Clientes.AllowUserToAddRows = false;
            this.dGV_Tabla_Clientes.AllowUserToDeleteRows = false;
            this.dGV_Tabla_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Tabla_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.DGV_Nombre,
            this.DGV_Apellido,
            this.DGV_Tipo_Docu,
            this.DGV_Numero_Docu,
            this.DGV_Mail,
            this.DGV_Tel,
            this.DGV_Calle,
            this.DGV_Calle_Nro,
            this.Column3,
            this.Column4,
            this.DGV_Localidad,
            this.DGV_País_Origen,
            this.DGV_Nacion,
            this.DGV_Fecha_Nac,
            this.Column6,
            this.Column1,
            this.Column2});
            this.dGV_Tabla_Clientes.Location = new System.Drawing.Point(20, 30);
            this.dGV_Tabla_Clientes.Name = "dGV_Tabla_Clientes";
            this.dGV_Tabla_Clientes.RowTemplate.Height = 28;
            this.dGV_Tabla_Clientes.Size = new System.Drawing.Size(843, 426);
            this.dGV_Tabla_Clientes.TabIndex = 0;
            this.dGV_Tabla_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Tabla_Clientes_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            // 
            // DGV_Nombre
            // 
            this.DGV_Nombre.HeaderText = "Nombre";
            this.DGV_Nombre.Name = "DGV_Nombre";
            // 
            // DGV_Apellido
            // 
            this.DGV_Apellido.HeaderText = "Apellido";
            this.DGV_Apellido.Name = "DGV_Apellido";
            // 
            // DGV_Tipo_Docu
            // 
            this.DGV_Tipo_Docu.HeaderText = "Tipo de id";
            this.DGV_Tipo_Docu.Name = "DGV_Tipo_Docu";
            // 
            // DGV_Numero_Docu
            // 
            this.DGV_Numero_Docu.HeaderText = "Nro. de identificación";
            this.DGV_Numero_Docu.Name = "DGV_Numero_Docu";
            // 
            // DGV_Mail
            // 
            this.DGV_Mail.HeaderText = "Email";
            this.DGV_Mail.Name = "DGV_Mail";
            // 
            // DGV_Tel
            // 
            this.DGV_Tel.HeaderText = "Teléfono";
            this.DGV_Tel.Name = "DGV_Tel";
            // 
            // DGV_Calle
            // 
            this.DGV_Calle.HeaderText = "Calle";
            this.DGV_Calle.Name = "DGV_Calle";
            // 
            // DGV_Calle_Nro
            // 
            this.DGV_Calle_Nro.HeaderText = "Nro de Calle";
            this.DGV_Calle_Nro.Name = "DGV_Calle_Nro";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Piso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dpto";
            this.Column4.Name = "Column4";
            // 
            // DGV_Localidad
            // 
            this.DGV_Localidad.HeaderText = "Localidad";
            this.DGV_Localidad.Name = "DGV_Localidad";
            // 
            // DGV_País_Origen
            // 
            this.DGV_País_Origen.HeaderText = "País de Origen";
            this.DGV_País_Origen.Name = "DGV_País_Origen";
            // 
            // DGV_Nacion
            // 
            this.DGV_Nacion.HeaderText = "Nacionalidad";
            this.DGV_Nacion.Name = "DGV_Nacion";
            // 
            // DGV_Fecha_Nac
            // 
            this.DGV_Fecha_Nac.HeaderText = "Fecha de Nacimiento";
            this.DGV_Fecha_Nac.Name = "DGV_Fecha_Nac";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modificar";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Nuevo_Cliente
            // 
            this.button_Nuevo_Cliente.Location = new System.Drawing.Point(754, 218);
            this.button_Nuevo_Cliente.Name = "button_Nuevo_Cliente";
            this.button_Nuevo_Cliente.Size = new System.Drawing.Size(142, 36);
            this.button_Nuevo_Cliente.TabIndex = 4;
            this.button_Nuevo_Cliente.Text = "Nuevo Cliente";
            this.button_Nuevo_Cliente.UseVisualStyleBackColor = true;
            this.button_Nuevo_Cliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV_Tabla_Clientes);
            this.groupBox2.Location = new System.Drawing.Point(16, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 462);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // labelCantidadTotal
            // 
            this.labelCantidadTotal.AutoSize = true;
            this.labelCantidadTotal.Location = new System.Drawing.Point(12, 764);
            this.labelCantidadTotal.Name = "labelCantidadTotal";
            this.labelCantidadTotal.Size = new System.Drawing.Size(0, 20);
            this.labelCantidadTotal.TabIndex = 6;
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 871);
            this.Controls.Add(this.labelCantidadTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Nuevo_Cliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoCliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tabla_Clientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente_Mail;
        private System.Windows.Forms.TextBox txtCliente_ID;
        private System.Windows.Forms.TextBox txtCliente_Apellido;
        private System.Windows.Forms.TextBox txtCliente_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Tabla_Clientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCliente_Tipo_ID;
        private System.Windows.Forms.Button button_Nuevo_Cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Tipo_Docu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Numero_Docu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Calle_Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_País_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Nacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
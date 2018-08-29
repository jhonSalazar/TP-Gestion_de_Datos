namespace FrbaHotel.RegistrarConsumible
{
    partial class RegistrarConsumible
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
            this.groupBoxFiltroEstadia = new System.Windows.Forms.GroupBox();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelReserva = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarEstadia = new System.Windows.Forms.Button();
            this.textBoxCodigoEstadia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewConsumibles = new System.Windows.Forms.DataGridView();
            this.ColumnIdConsumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnQuitar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonAgregarConsumible = new System.Windows.Forms.Button();
            this.groupBoxFiltroEstadia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltroEstadia
            // 
            this.groupBoxFiltroEstadia.Controls.Add(this.labelRegimen);
            this.groupBoxFiltroEstadia.Controls.Add(this.label5);
            this.groupBoxFiltroEstadia.Controls.Add(this.labelCliente);
            this.groupBoxFiltroEstadia.Controls.Add(this.label4);
            this.groupBoxFiltroEstadia.Controls.Add(this.labelReserva);
            this.groupBoxFiltroEstadia.Controls.Add(this.label3);
            this.groupBoxFiltroEstadia.Controls.Add(this.buttonBuscarEstadia);
            this.groupBoxFiltroEstadia.Controls.Add(this.textBoxCodigoEstadia);
            this.groupBoxFiltroEstadia.Controls.Add(this.label1);
            this.groupBoxFiltroEstadia.Location = new System.Drawing.Point(13, 13);
            this.groupBoxFiltroEstadia.Name = "groupBoxFiltroEstadia";
            this.groupBoxFiltroEstadia.Size = new System.Drawing.Size(657, 100);
            this.groupBoxFiltroEstadia.TabIndex = 0;
            this.groupBoxFiltroEstadia.TabStop = false;
            this.groupBoxFiltroEstadia.Text = "Seleccionar Estadía";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(486, 66);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(31, 17);
            this.labelRegimen.TabIndex = 8;
            this.labelRegimen.Text = "tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Regimen: ";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(480, 45);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(56, 17);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente: ";
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Location = new System.Drawing.Point(480, 22);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(56, 17);
            this.labelReserva.TabIndex = 4;
            this.labelReserva.Text = "numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reserva: ";
            // 
            // buttonBuscarEstadia
            // 
            this.buttonBuscarEstadia.Location = new System.Drawing.Point(297, 24);
            this.buttonBuscarEstadia.Name = "buttonBuscarEstadia";
            this.buttonBuscarEstadia.Size = new System.Drawing.Size(75, 39);
            this.buttonBuscarEstadia.TabIndex = 2;
            this.buttonBuscarEstadia.Text = "Buscar";
            this.buttonBuscarEstadia.UseVisualStyleBackColor = true;
            this.buttonBuscarEstadia.Click += new System.EventHandler(this.buttonBuscarEstadia_Click);
            // 
            // textBoxCodigoEstadia
            // 
            this.textBoxCodigoEstadia.Location = new System.Drawing.Point(164, 35);
            this.textBoxCodigoEstadia.Name = "textBoxCodigoEstadia";
            this.textBoxCodigoEstadia.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigoEstadia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Estadía: ";
            // 
            // dataGridViewConsumibles
            // 
            this.dataGridViewConsumibles.AllowUserToAddRows = false;
            this.dataGridViewConsumibles.AllowUserToDeleteRows = false;
            this.dataGridViewConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdConsumible,
            this.ColumnConsumible,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnHabitacion,
            this.ColumnModificar,
            this.ColumnQuitar});
            this.dataGridViewConsumibles.Location = new System.Drawing.Point(13, 165);
            this.dataGridViewConsumibles.Name = "dataGridViewConsumibles";
            this.dataGridViewConsumibles.ReadOnly = true;
            this.dataGridViewConsumibles.RowTemplate.Height = 24;
            this.dataGridViewConsumibles.Size = new System.Drawing.Size(933, 313);
            this.dataGridViewConsumibles.TabIndex = 1;
            this.dataGridViewConsumibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsumibles_CellMouseClick);
            this.dataGridViewConsumibles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewConsumibles_RowsAdded);
            this.dataGridViewConsumibles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewConsumibles_RowsRemoved);
            // 
            // ColumnIdConsumible
            // 
            this.ColumnIdConsumible.HeaderText = "IdConsumible";
            this.ColumnIdConsumible.Name = "ColumnIdConsumible";
            this.ColumnIdConsumible.ReadOnly = true;
            this.ColumnIdConsumible.Visible = false;
            // 
            // ColumnConsumible
            // 
            this.ColumnConsumible.HeaderText = "Consumible";
            this.ColumnConsumible.Name = "ColumnConsumible";
            this.ColumnConsumible.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnHabitacion
            // 
            this.ColumnHabitacion.HeaderText = "Habitacion";
            this.ColumnHabitacion.Name = "ColumnHabitacion";
            this.ColumnHabitacion.ReadOnly = true;
            // 
            // ColumnModificar
            // 
            this.ColumnModificar.HeaderText = "Modificar";
            this.ColumnModificar.Name = "ColumnModificar";
            this.ColumnModificar.ReadOnly = true;
            // 
            // ColumnQuitar
            // 
            this.ColumnQuitar.HeaderText = "Quitar";
            this.ColumnQuitar.Name = "ColumnQuitar";
            this.ColumnQuitar.ReadOnly = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(841, 497);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(105, 44);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 497);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 44);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(474, 511);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 17);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "0";
            // 
            // buttonAgregarConsumible
            // 
            this.buttonAgregarConsumible.Location = new System.Drawing.Point(13, 120);
            this.buttonAgregarConsumible.Name = "buttonAgregarConsumible";
            this.buttonAgregarConsumible.Size = new System.Drawing.Size(190, 39);
            this.buttonAgregarConsumible.TabIndex = 6;
            this.buttonAgregarConsumible.Text = "Agregar Consumible";
            this.buttonAgregarConsumible.UseVisualStyleBackColor = true;
            this.buttonAgregarConsumible.Click += new System.EventHandler(this.buttonAgregarConsumible_Click);
            // 
            // RegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 553);
            this.Controls.Add(this.buttonAgregarConsumible);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.dataGridViewConsumibles);
            this.Controls.Add(this.groupBoxFiltroEstadia);
            this.Name = "RegistrarConsumible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarConsumible";
            this.groupBoxFiltroEstadia.ResumeLayout(false);
            this.groupBoxFiltroEstadia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltroEstadia;
        private System.Windows.Forms.Button buttonBuscarEstadia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonAgregarConsumible;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdConsumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHabitacion;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnModificar;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnQuitar;
        public System.Windows.Forms.TextBox textBoxCodigoEstadia;
        public System.Windows.Forms.DataGridView dataGridViewConsumibles;
    }
}
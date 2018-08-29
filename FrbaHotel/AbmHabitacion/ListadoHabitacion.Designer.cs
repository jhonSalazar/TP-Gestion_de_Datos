namespace FrbaHotel.AbmHabitacion
{
    partial class ListadoHabitacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.textUbicacion = new System.Windows.Forms.TextBox();
            this.textTipoHabitacion = new System.Windows.Forms.TextBox();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGvListadoHabitacion = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkLabelBaja = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCantidadTotal = new System.Windows.Forms.Label();
            this.buttonNuevoRegimen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvListadoHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNumeroHabitacion);
            this.groupBox1.Controls.Add(this.textUbicacion);
            this.groupBox1.Controls.Add(this.textTipoHabitacion);
            this.groupBox1.Controls.Add(this.textPiso);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Piso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Habitacion";
            // 
            // textNumeroHabitacion
            // 
            this.textNumeroHabitacion.Location = new System.Drawing.Point(126, 22);
            this.textNumeroHabitacion.Name = "textNumeroHabitacion";
            this.textNumeroHabitacion.Size = new System.Drawing.Size(100, 20);
            this.textNumeroHabitacion.TabIndex = 3;
            // 
            // textUbicacion
            // 
            this.textUbicacion.Location = new System.Drawing.Point(126, 54);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(100, 20);
            this.textUbicacion.TabIndex = 2;
            // 
            // textTipoHabitacion
            // 
            this.textTipoHabitacion.Location = new System.Drawing.Point(584, 58);
            this.textTipoHabitacion.Name = "textTipoHabitacion";
            this.textTipoHabitacion.Size = new System.Drawing.Size(60, 20);
            this.textTipoHabitacion.TabIndex = 1;
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(544, 29);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(100, 20);
            this.textPiso.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(373, 109);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(26, 109);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGvListadoHabitacion);
            this.groupBox2.Location = new System.Drawing.Point(13, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dGvListadoHabitacion
            // 
            this.dGvListadoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvListadoHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.LinkLabelBaja,
            this.Column9,
            this.Column10,
            this.Column1});
            this.dGvListadoHabitacion.Location = new System.Drawing.Point(26, 19);
            this.dGvListadoHabitacion.Name = "dGvListadoHabitacion";
            this.dGvListadoHabitacion.Size = new System.Drawing.Size(624, 255);
            this.dGvListadoHabitacion.TabIndex = 0;
            this.dGvListadoHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dGvListadoHabitacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGvListadoHabitacion_CellMouseClick);
            this.dGvListadoHabitacion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGvListadoHabitacion_CellMouseDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero de Habitacion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Piso";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ubicacion";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo de Habitacion ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descripcion";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Comodidades";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Estado";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // LinkLabelBaja
            // 
            this.LinkLabelBaja.HeaderText = "Baja";
            this.LinkLabelBaja.Name = "LinkLabelBaja";
            this.LinkLabelBaja.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Modificar";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ID_Hotel";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_Habitacion";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // labelCantidadTotal
            // 
            this.labelCantidadTotal.AutoSize = true;
            this.labelCantidadTotal.Location = new System.Drawing.Point(13, 451);
            this.labelCantidadTotal.Name = "labelCantidadTotal";
            this.labelCantidadTotal.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadTotal.TabIndex = 9;
            this.labelCantidadTotal.Text = "label6";
            // 
            // buttonNuevoRegimen
            // 
            this.buttonNuevoRegimen.Location = new System.Drawing.Point(546, 109);
            this.buttonNuevoRegimen.Name = "buttonNuevoRegimen";
            this.buttonNuevoRegimen.Size = new System.Drawing.Size(117, 23);
            this.buttonNuevoRegimen.TabIndex = 10;
            this.buttonNuevoRegimen.Text = "Nueva Habitacion";
            this.buttonNuevoRegimen.UseVisualStyleBackColor = true;
            this.buttonNuevoRegimen.Click += new System.EventHandler(this.buttonNuevoRegimen_Click);
            // 
            // ListadoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 472);
            this.Controls.Add(this.buttonNuevoRegimen);
            this.Controls.Add(this.labelCantidadTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoHabitacion";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvListadoHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroHabitacion;
        private System.Windows.Forms.TextBox textUbicacion;
        private System.Windows.Forms.TextBox textTipoHabitacion;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGvListadoHabitacion;
        private System.Windows.Forms.Label labelCantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewLinkColumn LinkLabelBaja;
        private System.Windows.Forms.DataGridViewLinkColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonNuevoRegimen;
    }
}
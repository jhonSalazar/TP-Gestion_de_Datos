namespace FrbaHotel.GenerarModificacionReserva
{
    partial class ModificarReserva
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
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonReserva = new System.Windows.Forms.Button();
            this.labelCampoNulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCanitdadNoches = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCodigoReserva = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.comboBoxTipoRegimen = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSistema = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Los campos con (*) son obligatorios";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(27, 330);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonReserva
            // 
            this.buttonReserva.Location = new System.Drawing.Point(398, 330);
            this.buttonReserva.Name = "buttonReserva";
            this.buttonReserva.Size = new System.Drawing.Size(138, 23);
            this.buttonReserva.TabIndex = 24;
            this.buttonReserva.Text = "Modificar Reserva";
            this.buttonReserva.UseVisualStyleBackColor = true;
            this.buttonReserva.Click += new System.EventHandler(this.buttonReserva_Click);
            // 
            // labelCampoNulo
            // 
            this.labelCampoNulo.AutoSize = true;
            this.labelCampoNulo.Location = new System.Drawing.Point(18, 290);
            this.labelCampoNulo.Name = "labelCampoNulo";
            this.labelCampoNulo.Size = new System.Drawing.Size(0, 13);
            this.labelCampoNulo.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxCanitdadNoches);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCodigoReserva);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.comboBoxTipoRegimen);
            this.groupBox1.Controls.Add(this.dateTimePickerDesde);
            this.groupBox1.Controls.Add(this.dateTimeHasta);
            this.groupBox1.Controls.Add(this.dateTimePickerSistema);
            this.groupBox1.Controls.Add(this.comboBoxTipoHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 280);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBoxCanitdadNoches
            // 
            this.textBoxCanitdadNoches.Location = new System.Drawing.Point(288, 168);
            this.textBoxCanitdadNoches.Name = "textBoxCanitdadNoches";
            this.textBoxCanitdadNoches.Size = new System.Drawing.Size(100, 20);
            this.textBoxCanitdadNoches.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cantidad de Noches ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Código de Reserva ";
            // 
            // textBoxCodigoReserva
            // 
            this.textBoxCodigoReserva.Enabled = false;
            this.textBoxCodigoReserva.Location = new System.Drawing.Point(288, 219);
            this.textBoxCodigoReserva.Name = "textBoxCodigoReserva";
            this.textBoxCodigoReserva.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoReserva.TabIndex = 23;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(128, 111);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 13);
            this.labelFecha.TabIndex = 22;
            // 
            // comboBoxTipoRegimen
            // 
            this.comboBoxTipoRegimen.FormattingEnabled = true;
            this.comboBoxTipoRegimen.Items.AddRange(new object[] {
            "Pension Completa",
            "Media Pensión",
            "All Inclusive moderado",
            "All inclusive"});
            this.comboBoxTipoRegimen.Location = new System.Drawing.Point(131, 219);
            this.comboBoxTipoRegimen.Name = "comboBoxTipoRegimen";
            this.comboBoxTipoRegimen.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoRegimen.TabIndex = 19;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(131, 80);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 18;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(131, 125);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 17;
            // 
            // dateTimePickerSistema
            // 
            this.dateTimePickerSistema.Enabled = false;
            this.dateTimePickerSistema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSistema.Location = new System.Drawing.Point(131, 35);
            this.dateTimePickerSistema.Name = "dateTimePickerSistema";
            this.dateTimePickerSistema.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSistema.TabIndex = 16;
            // 
            // comboBoxTipoHabitacion
            // 
            this.comboBoxTipoHabitacion.FormattingEnabled = true;
            this.comboBoxTipoHabitacion.Items.AddRange(new object[] {
            "Base Simple",
            "Base Doble",
            "Base Triple",
            "Base Cuadruple",
            "King"});
            this.comboBoxTipoHabitacion.Location = new System.Drawing.Point(131, 167);
            this.comboBoxTipoHabitacion.Name = "comboBoxTipoHabitacion";
            this.comboBoxTipoHabitacion.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoHabitacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Habitación (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Regimen  (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Desde (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha del Sistema";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(131, 253);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 28;
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 385);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonReserva);
            this.Controls.Add(this.labelCampoNulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "ModificarReserva";
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonReserva;
        private System.Windows.Forms.Label labelCampoNulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCanitdadNoches;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCodigoReserva;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox comboBoxTipoRegimen;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerSistema;
        private System.Windows.Forms.ComboBox comboBoxTipoHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label9;
    }
}
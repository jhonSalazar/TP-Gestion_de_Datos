namespace FrbaHotel.AbmHabitacion
{
    partial class AltaHabitacion
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
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNumerico2 = new System.Windows.Forms.Label();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.labelNumerico1 = new System.Windows.Forms.Label();
            this.comboBoxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelCampoNulo = new System.Windows.Forms.Label();
            this.labelHabitacionUnica = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPiso
            // 
            this.textPiso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPiso.Location = new System.Drawing.Point(140, 71);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(100, 20);
            this.textPiso.TabIndex = 0;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(141, 160);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textDescripcion.TabIndex = 2;
            // 
            // textNumeroHabitacion
            // 
            this.textNumeroHabitacion.Location = new System.Drawing.Point(140, 32);
            this.textNumeroHabitacion.Name = "textNumeroHabitacion";
            this.textNumeroHabitacion.Size = new System.Drawing.Size(100, 20);
            this.textNumeroHabitacion.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNumerico2);
            this.groupBox1.Controls.Add(this.comboBoxUbicacion);
            this.groupBox1.Controls.Add(this.labelNumerico1);
            this.groupBox1.Controls.Add(this.comboBoxTipoHabitacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNumeroHabitacion);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textPiso);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelNumerico2
            // 
            this.labelNumerico2.AutoSize = true;
            this.labelNumerico2.Location = new System.Drawing.Point(137, 55);
            this.labelNumerico2.Name = "labelNumerico2";
            this.labelNumerico2.Size = new System.Drawing.Size(0, 13);
            this.labelNumerico2.TabIndex = 18;
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.FormattingEnabled = true;
            this.comboBoxUbicacion.Items.AddRange(new object[] {
            "Vista al exterior",
            "Vista al Interno"});
            this.comboBoxUbicacion.Location = new System.Drawing.Point(140, 102);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(100, 21);
            this.comboBoxUbicacion.TabIndex = 11;
            // 
            // labelNumerico1
            // 
            this.labelNumerico1.AutoSize = true;
            this.labelNumerico1.Location = new System.Drawing.Point(137, 16);
            this.labelNumerico1.Name = "labelNumerico1";
            this.labelNumerico1.Size = new System.Drawing.Size(0, 13);
            this.labelNumerico1.TabIndex = 17;
            // 
            // comboBoxTipoHabitacion
            // 
            this.comboBoxTipoHabitacion.FormattingEnabled = true;
            this.comboBoxTipoHabitacion.Items.AddRange(new object[] {
            "Base Simple",
            "Base Doble",
            "Base Doble twin",
            "Base Tiple",
            "Base Cuádruple"});
            this.comboBoxTipoHabitacion.Location = new System.Drawing.Point(140, 129);
            this.comboBoxTipoHabitacion.Name = "comboBoxTipoHabitacion";
            this.comboBoxTipoHabitacion.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoHabitacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Habitación (*)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Piso (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ubicación (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Habitación (*)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Los campos con (*) son obligatorios";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(28, 284);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(323, 284);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelCampoNulo
            // 
            this.labelCampoNulo.AutoSize = true;
            this.labelCampoNulo.Location = new System.Drawing.Point(22, 247);
            this.labelCampoNulo.Name = "labelCampoNulo";
            this.labelCampoNulo.Size = new System.Drawing.Size(0, 13);
            this.labelCampoNulo.TabIndex = 15;
            // 
            // labelHabitacionUnica
            // 
            this.labelHabitacionUnica.AutoSize = true;
            this.labelHabitacionUnica.Location = new System.Drawing.Point(23, 268);
            this.labelHabitacionUnica.Name = "labelHabitacionUnica";
            this.labelHabitacionUnica.Size = new System.Drawing.Size(0, 13);
            this.labelHabitacionUnica.TabIndex = 16;
            // 
            // AltaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 396);
            this.Controls.Add(this.labelHabitacionUnica);
            this.Controls.Add(this.labelCampoNulo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaHabitacion";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.AltaHabitacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textNumeroHabitacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoHabitacion;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelCampoNulo;
        private System.Windows.Forms.Label labelHabitacionUnica;
        private System.Windows.Forms.Label labelNumerico1;
        private System.Windows.Forms.Label labelNumerico2;
    }
}
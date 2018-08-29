namespace FrbaHotel
{
    partial class Facturar_Estadía
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
            this.txtEstadiaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbForma_Pago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lblTarjeta_Empresa = new System.Windows.Forms.Label();
            this.lblTarjeta_Nro_Tarj = new System.Windows.Forms.Label();
            this.lblTarjeta_Cod_Seguridad = new System.Windows.Forms.Label();
            this.gbDatos_Tarjeta = new System.Windows.Forms.GroupBox();
            this.txtTarjeta_Cod_Seguridad = new System.Windows.Forms.TextBox();
            this.txt_Tarjeta_Nro_Tarj = new System.Windows.Forms.TextBox();
            this.cmb_Tarjeta_Empresa = new System.Windows.Forms.ComboBox();
            this.gbDatos_Tarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEstadiaID
            // 
            this.txtEstadiaID.Location = new System.Drawing.Point(179, 26);
            this.txtEstadiaID.Name = "txtEstadiaID";
            this.txtEstadiaID.Size = new System.Drawing.Size(146, 26);
            this.txtEstadiaID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estadía";
            // 
            // cmbForma_Pago
            // 
            this.cmbForma_Pago.FormattingEnabled = true;
            this.cmbForma_Pago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Débito",
            "Tarjeta de Crédito"});
            this.cmbForma_Pago.Location = new System.Drawing.Point(179, 85);
            this.cmbForma_Pago.Name = "cmbForma_Pago";
            this.cmbForma_Pago.Size = new System.Drawing.Size(122, 28);
            this.cmbForma_Pago.TabIndex = 4;
            this.cmbForma_Pago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Froma de Pago";
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Location = new System.Drawing.Point(415, 371);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(164, 36);
            this.btn_Facturar.TabIndex = 8;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(29, 371);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(164, 36);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lblTarjeta_Empresa
            // 
            this.lblTarjeta_Empresa.AutoSize = true;
            this.lblTarjeta_Empresa.Location = new System.Drawing.Point(23, 37);
            this.lblTarjeta_Empresa.Name = "lblTarjeta_Empresa";
            this.lblTarjeta_Empresa.Size = new System.Drawing.Size(73, 20);
            this.lblTarjeta_Empresa.TabIndex = 10;
            this.lblTarjeta_Empresa.Text = "Empresa";
            this.lblTarjeta_Empresa.Visible = false;
            // 
            // lblTarjeta_Nro_Tarj
            // 
            this.lblTarjeta_Nro_Tarj.AutoSize = true;
            this.lblTarjeta_Nro_Tarj.Location = new System.Drawing.Point(23, 83);
            this.lblTarjeta_Nro_Tarj.Name = "lblTarjeta_Nro_Tarj";
            this.lblTarjeta_Nro_Tarj.Size = new System.Drawing.Size(140, 20);
            this.lblTarjeta_Nro_Tarj.TabIndex = 11;
            this.lblTarjeta_Nro_Tarj.Text = "Número de Tarjeta";
            this.lblTarjeta_Nro_Tarj.Visible = false;
            // 
            // lblTarjeta_Cod_Seguridad
            // 
            this.lblTarjeta_Cod_Seguridad.AutoSize = true;
            this.lblTarjeta_Cod_Seguridad.Location = new System.Drawing.Point(23, 127);
            this.lblTarjeta_Cod_Seguridad.Name = "lblTarjeta_Cod_Seguridad";
            this.lblTarjeta_Cod_Seguridad.Size = new System.Drawing.Size(158, 20);
            this.lblTarjeta_Cod_Seguridad.TabIndex = 12;
            this.lblTarjeta_Cod_Seguridad.Text = "Código de Seguridad";
            this.lblTarjeta_Cod_Seguridad.Visible = false;
            // 
            // gbDatos_Tarjeta
            // 
            this.gbDatos_Tarjeta.Controls.Add(this.txtTarjeta_Cod_Seguridad);
            this.gbDatos_Tarjeta.Controls.Add(this.txt_Tarjeta_Nro_Tarj);
            this.gbDatos_Tarjeta.Controls.Add(this.cmb_Tarjeta_Empresa);
            this.gbDatos_Tarjeta.Controls.Add(this.lblTarjeta_Cod_Seguridad);
            this.gbDatos_Tarjeta.Controls.Add(this.lblTarjeta_Nro_Tarj);
            this.gbDatos_Tarjeta.Controls.Add(this.lblTarjeta_Empresa);
            this.gbDatos_Tarjeta.Location = new System.Drawing.Point(29, 152);
            this.gbDatos_Tarjeta.Name = "gbDatos_Tarjeta";
            this.gbDatos_Tarjeta.Size = new System.Drawing.Size(550, 172);
            this.gbDatos_Tarjeta.TabIndex = 13;
            this.gbDatos_Tarjeta.TabStop = false;
            this.gbDatos_Tarjeta.Text = "Datos de Tarjeta";
            this.gbDatos_Tarjeta.Visible = false;
            // 
            // txtTarjeta_Cod_Seguridad
            // 
            this.txtTarjeta_Cod_Seguridad.Location = new System.Drawing.Point(191, 124);
            this.txtTarjeta_Cod_Seguridad.Name = "txtTarjeta_Cod_Seguridad";
            this.txtTarjeta_Cod_Seguridad.Size = new System.Drawing.Size(59, 26);
            this.txtTarjeta_Cod_Seguridad.TabIndex = 15;
            this.txtTarjeta_Cod_Seguridad.Text = "XXX";
            // 
            // txt_Tarjeta_Nro_Tarj
            // 
            this.txt_Tarjeta_Nro_Tarj.Location = new System.Drawing.Point(191, 83);
            this.txt_Tarjeta_Nro_Tarj.Name = "txt_Tarjeta_Nro_Tarj";
            this.txt_Tarjeta_Nro_Tarj.Size = new System.Drawing.Size(225, 26);
            this.txt_Tarjeta_Nro_Tarj.TabIndex = 14;
            this.txt_Tarjeta_Nro_Tarj.Text = "XXXX-XXXX-XXXX-XXXX";
            this.txt_Tarjeta_Nro_Tarj.Visible = false;
            // 
            // cmb_Tarjeta_Empresa
            // 
            this.cmb_Tarjeta_Empresa.FormattingEnabled = true;
            this.cmb_Tarjeta_Empresa.Items.AddRange(new object[] {
            "MasterCard",
            "VISA"});
            this.cmb_Tarjeta_Empresa.Location = new System.Drawing.Point(191, 34);
            this.cmb_Tarjeta_Empresa.Name = "cmb_Tarjeta_Empresa";
            this.cmb_Tarjeta_Empresa.Size = new System.Drawing.Size(164, 28);
            this.cmb_Tarjeta_Empresa.TabIndex = 13;
            this.cmb_Tarjeta_Empresa.Visible = false;
            // 
            // Facturar_Estadía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 443);
            this.Controls.Add(this.gbDatos_Tarjeta);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbForma_Pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstadiaID);
            this.Name = "Facturar_Estadía";
            this.Text = "Facturación";
            this.gbDatos_Tarjeta.ResumeLayout(false);
            this.gbDatos_Tarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstadiaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbForma_Pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label lblTarjeta_Empresa;
        private System.Windows.Forms.Label lblTarjeta_Nro_Tarj;
        private System.Windows.Forms.Label lblTarjeta_Cod_Seguridad;
        private System.Windows.Forms.GroupBox gbDatos_Tarjeta;
        private System.Windows.Forms.TextBox txtTarjeta_Cod_Seguridad;
        private System.Windows.Forms.TextBox txt_Tarjeta_Nro_Tarj;
        private System.Windows.Forms.ComboBox cmb_Tarjeta_Empresa;
    }
}
namespace FrbaHotel
{
    partial class Registrar_Estadía
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEstadia_Info_Obligatoria = new System.Windows.Forms.Label();
            this.btnEstadia_Siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Reserva (*)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 1;
            // 
            // txtEstadia_Info_Obligatoria
            // 
            this.txtEstadia_Info_Obligatoria.AutoSize = true;
            this.txtEstadia_Info_Obligatoria.Location = new System.Drawing.Point(27, 128);
            this.txtEstadia_Info_Obligatoria.Name = "txtEstadia_Info_Obligatoria";
            this.txtEstadia_Info_Obligatoria.Size = new System.Drawing.Size(260, 20);
            this.txtEstadia_Info_Obligatoria.TabIndex = 2;
            this.txtEstadia_Info_Obligatoria.Text = "Los campos con (*) son obligatorios";
            // 
            // btnEstadia_Siguiente
            // 
            this.btnEstadia_Siguiente.Location = new System.Drawing.Point(468, 151);
            this.btnEstadia_Siguiente.Name = "btnEstadia_Siguiente";
            this.btnEstadia_Siguiente.Size = new System.Drawing.Size(130, 31);
            this.btnEstadia_Siguiente.TabIndex = 3;
            this.btnEstadia_Siguiente.Text = "Siguiente";
            this.btnEstadia_Siguiente.UseVisualStyleBackColor = true;
            // 
            // Registrar_Estadía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 193);
            this.Controls.Add(this.btnEstadia_Siguiente);
            this.Controls.Add(this.txtEstadia_Info_Obligatoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Registrar_Estadía";
            this.Text = "Registrar_Estadía";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtEstadia_Info_Obligatoria;
        private System.Windows.Forms.Button btnEstadia_Siguiente;
    }
}
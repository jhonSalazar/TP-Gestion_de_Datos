namespace FrbaHotel.AbmRol
{
    partial class Modificar
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
            this.checkedListBoxFuncionalidadesRol = new System.Windows.Forms.CheckedListBox();
            this.checkBoxRolHabilitado = new System.Windows.Forms.CheckBox();
            this.textBoxNombreRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxFuncionalidadesRol);
            this.groupBox1.Controls.Add(this.checkBoxRolHabilitado);
            this.groupBox1.Controls.Add(this.textBoxNombreRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Rol";
            // 
            // checkedListBoxFuncionalidadesRol
            // 
            this.checkedListBoxFuncionalidadesRol.FormattingEnabled = true;
            this.checkedListBoxFuncionalidadesRol.Location = new System.Drawing.Point(35, 95);
            this.checkedListBoxFuncionalidadesRol.Name = "checkedListBoxFuncionalidadesRol";
            this.checkedListBoxFuncionalidadesRol.Size = new System.Drawing.Size(282, 208);
            this.checkedListBoxFuncionalidadesRol.TabIndex = 3;
            // 
            // checkBoxRolHabilitado
            // 
            this.checkBoxRolHabilitado.AutoSize = true;
            this.checkBoxRolHabilitado.Location = new System.Drawing.Point(35, 323);
            this.checkBoxRolHabilitado.Name = "checkBoxRolHabilitado";
            this.checkBoxRolHabilitado.Size = new System.Drawing.Size(93, 21);
            this.checkBoxRolHabilitado.TabIndex = 2;
            this.checkBoxRolHabilitado.Text = "Habilitado";
            this.checkBoxRolHabilitado.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreRol
            // 
            this.textBoxNombreRol.Location = new System.Drawing.Point(150, 38);
            this.textBoxNombreRol.Name = "textBoxNombreRol";
            this.textBoxNombreRol.Size = new System.Drawing.Size(167, 22);
            this.textBoxNombreRol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Rol: ";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(321, 415);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(97, 44);
            this.buttonActualizar.TabIndex = 3;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFuncionalidadesRol;
        private System.Windows.Forms.CheckBox checkBoxRolHabilitado;
        private System.Windows.Forms.TextBox textBoxNombreRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonActualizar;
    }
}
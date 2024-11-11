
namespace WorkOfficeApp
{
    partial class FormPrincipal
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(456, 286);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(189, 45);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(456, 222);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(189, 45);
            this.btnReservas.TabIndex = 8;
            this.btnReservas.Text = "Gestionar Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.Location = new System.Drawing.Point(456, 159);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(189, 45);
            this.btnSalas.TabIndex = 7;
            this.btnSalas.Text = "Gestionar Salas";
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido al Sistema de Gestión";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(456, 95);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(189, 45);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Gestionar Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnSalas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
    }
}

namespace WorkOfficeApp
{
    partial class FormReservas
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
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadMenu1 = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.cmbIdSala = new System.Windows.Forms.ComboBox();
            this.txtCantidadMenu1 = new System.Windows.Forms.TextBox();
            this.txtCantidadMenu3 = new System.Windows.Forms.TextBox();
            this.lblCantidadMenu3 = new System.Windows.Forms.Label();
            this.txtCantidadMenu2 = new System.Windows.Forms.TextBox();
            this.lblCantidadMenu2 = new System.Windows.Forms.Label();
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnMostrarReservas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.Location = new System.Drawing.Point(884, 98);
            this.btnGuardarReserva.Name = "btnGuardarReserva";
            this.btnGuardarReserva.Size = new System.Drawing.Size(111, 48);
            this.btnGuardarReserva.TabIndex = 33;
            this.btnGuardarReserva.Text = "Guardar Reserva";
            this.btnGuardarReserva.UseVisualStyleBackColor = true;
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Location = new System.Drawing.Point(748, 98);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(111, 48);
            this.btnCalcularTotal.TabIndex = 32;
            this.btnCalcularTotal.Text = "Calcular Costo Total";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(828, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 20);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // lblCantidadMenu1
            // 
            this.lblCantidadMenu1.AutoSize = true;
            this.lblCantidadMenu1.Location = new System.Drawing.Point(52, 202);
            this.lblCantidadMenu1.Name = "lblCantidadMenu1";
            this.lblCantidadMenu1.Size = new System.Drawing.Size(125, 20);
            this.lblCantidadMenu1.TabIndex = 26;
            this.lblCantidadMenu1.Text = "Menú 1 ($10.00)";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Location = new System.Drawing.Point(344, 136);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(307, 26);
            this.dtpHorario.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(344, 83);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 26);
            this.txtNombreCliente.TabIndex = 22;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(52, 89);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(260, 20);
            this.lblNombreCliente.TabIndex = 21;
            this.lblNombreCliente.Text = "Nombre de la Persona que Reserva";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(52, 147);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(61, 20);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Horario";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(52, 40);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(62, 20);
            this.lblSala.TabIndex = 18;
            this.lblSala.Text = "ID Sala";
            // 
            // cmbIdSala
            // 
            this.cmbIdSala.FormattingEnabled = true;
            this.cmbIdSala.Items.AddRange(new object[] {
            "Sala 1 Edificio 1",
            "Sala 2 Edificio 1",
            "Sala 1 Edificio 2",
            "Sala 2 Edificio 2",
            "Sala 3 Edificio 2",
            "Sala 1 Edificio 3",
            "Sala 2 Edificio 3",
            "Sala 3 Edificio 3"});
            this.cmbIdSala.Location = new System.Drawing.Point(344, 32);
            this.cmbIdSala.Name = "cmbIdSala";
            this.cmbIdSala.Size = new System.Drawing.Size(121, 28);
            this.cmbIdSala.TabIndex = 35;
            // 
            // txtCantidadMenu1
            // 
            this.txtCantidadMenu1.Location = new System.Drawing.Point(344, 197);
            this.txtCantidadMenu1.Name = "txtCantidadMenu1";
            this.txtCantidadMenu1.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadMenu1.TabIndex = 36;
            // 
            // txtCantidadMenu3
            // 
            this.txtCantidadMenu3.Location = new System.Drawing.Point(344, 277);
            this.txtCantidadMenu3.Name = "txtCantidadMenu3";
            this.txtCantidadMenu3.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadMenu3.TabIndex = 38;
            // 
            // lblCantidadMenu3
            // 
            this.lblCantidadMenu3.AutoSize = true;
            this.lblCantidadMenu3.Location = new System.Drawing.Point(52, 282);
            this.lblCantidadMenu3.Name = "lblCantidadMenu3";
            this.lblCantidadMenu3.Size = new System.Drawing.Size(125, 20);
            this.lblCantidadMenu3.TabIndex = 37;
            this.lblCantidadMenu3.Text = "Menú 3 ($15.00)";
            // 
            // txtCantidadMenu2
            // 
            this.txtCantidadMenu2.Location = new System.Drawing.Point(344, 240);
            this.txtCantidadMenu2.Name = "txtCantidadMenu2";
            this.txtCantidadMenu2.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadMenu2.TabIndex = 40;
            // 
            // lblCantidadMenu2
            // 
            this.lblCantidadMenu2.AutoSize = true;
            this.lblCantidadMenu2.Location = new System.Drawing.Point(52, 245);
            this.lblCantidadMenu2.Name = "lblCantidadMenu2";
            this.lblCantidadMenu2.Size = new System.Drawing.Size(125, 20);
            this.lblCantidadMenu2.TabIndex = 39;
            this.lblCantidadMenu2.Text = "Menú 2 ($12.00)";
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.AutoSize = true;
            this.lblTotalMonto.Location = new System.Drawing.Point(940, 34);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(0, 20);
            this.lblTotalMonto.TabIndex = 41;
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(657, 171);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 62;
            this.dgvReservas.RowTemplate.Height = 28;
            this.dgvReservas.Size = new System.Drawing.Size(503, 226);
            this.dgvReservas.TabIndex = 42;
            // 
            // btnMostrarReservas
            // 
            this.btnMostrarReservas.Location = new System.Drawing.Point(1022, 98);
            this.btnMostrarReservas.Name = "btnMostrarReservas";
            this.btnMostrarReservas.Size = new System.Drawing.Size(111, 48);
            this.btnMostrarReservas.TabIndex = 43;
            this.btnMostrarReservas.Text = "Mostrar Reservas";
            this.btnMostrarReservas.UseVisualStyleBackColor = true;
            this.btnMostrarReservas.Click += new System.EventHandler(this.btnMostrarReservas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(233, 349);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 48);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 588);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrarReservas);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.lblTotalMonto);
            this.Controls.Add(this.txtCantidadMenu2);
            this.Controls.Add(this.lblCantidadMenu2);
            this.Controls.Add(this.txtCantidadMenu3);
            this.Controls.Add(this.lblCantidadMenu3);
            this.Controls.Add(this.txtCantidadMenu1);
            this.Controls.Add(this.cmbIdSala);
            this.Controls.Add(this.btnGuardarReserva);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidadMenu1);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblSala);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarReserva;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadMenu1;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cmbIdSala;
        private System.Windows.Forms.TextBox txtCantidadMenu1;
        private System.Windows.Forms.TextBox txtCantidadMenu3;
        private System.Windows.Forms.Label lblCantidadMenu3;
        private System.Windows.Forms.TextBox txtCantidadMenu2;
        private System.Windows.Forms.Label lblCantidadMenu2;
        private System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnMostrarReservas;
        private System.Windows.Forms.Button btnVolver;
    }
}
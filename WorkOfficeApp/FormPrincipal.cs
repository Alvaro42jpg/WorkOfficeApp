using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOfficeApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Evento para abrir el formulario de Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UserManagementForm frmUsuarios = new UserManagementForm();
            frmUsuarios.Show();
        }

        // Evento para abrir el formulario de Salas
        private void btnSalas_Click(object sender, EventArgs e)
        {
            FormSalas frmSalas = new FormSalas();
            frmSalas.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas frmReservas = new FormReservas();
            frmReservas.Show();
        }
    }
}

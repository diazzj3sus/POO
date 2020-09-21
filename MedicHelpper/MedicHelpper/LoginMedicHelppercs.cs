using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class LoginMedicHelppercs : Form
    {
        ConexionSqlServer conectarbdd = new ConexionSqlServer();
        public LoginMedicHelppercs()
        {
            InitializeComponent();
        }
        private void LoginMedicHelppercs_Load(object sender, EventArgs e)
        {
            conectarbdd.abrir();
        }
        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txbUsuario.Text = "Usuario:";
            txbContraseña.Text = "Contraseña:";
            txbContraseña.UseSystemPasswordChar = false;
        }
        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "Usuario:")
            {
                txbUsuario.Clear();
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "Usuario:";
            }
        }

        private void txbContraseña_Enter(object sender, EventArgs e)
        {
            if (txbContraseña.Text == "Contraseña:")
            {
                txbContraseña.Clear();
                txbContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txbContraseña_Leave(object sender, EventArgs e)
        {
            if (txbContraseña.Text == "")
            {
                txbContraseña.Text = "Contraseña:";
                txbContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


    }
}

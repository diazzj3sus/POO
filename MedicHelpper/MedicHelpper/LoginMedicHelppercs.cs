using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        public void iniciarSesion(string usuario, string contraseña)
        {
            try
            {
                conectarbdd.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE IdUsuario = @usuario AND Contraseña = @contraseña", conectarbdd.conexion);
                comando.Parameters.AddWithValue("usuario", usuario);
                comando.Parameters.AddWithValue("contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conectarbdd.cerrar();
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][6].ToString() == "0")
                    {
                        this.Hide();
                        string nombre = (dt.Rows[0][2] + " " + dt.Rows[0][3]);
                        MenuAdministrador menu = new MenuAdministrador(nombre);
                        menu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Usuario no encontrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbUsuario.Text) && !string.IsNullOrEmpty(txbContraseña.Text))
            {
                try
                {
                    iniciarSesion(txbUsuario.Text,txbContraseña.Text);
                }
                catch
                {
                    MessageBox.Show("ERROR: Revise los datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("ERROR: Revise los datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

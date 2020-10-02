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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador(string nombre)
        {
            InitializeComponent();
            lbluser.Text = nombre;
            
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMedicHelppercs login = new LoginMedicHelppercs();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMedicHelppercs login = new LoginMedicHelppercs();
            login.Show();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Base citas = new Base();
            citas.Show();
        }
    }
}

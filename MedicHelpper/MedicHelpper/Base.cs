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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMedicHelppercs login = new LoginMedicHelppercs();
            login.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtApellido.Visible = true;
            txtFechaBirth.Visible = true;
            txtNombre.Visible = true;
            pictureBox2.Visible = true;
            lblBirth.Visible = true;            
            lblLastName.Visible = true;
            lblName.Visible = true;
        }
    }
}

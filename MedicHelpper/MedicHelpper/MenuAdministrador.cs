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
            lblusuario.Text = nombre;
            
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

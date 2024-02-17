using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            /*TODO*/
            this.Close(); // Cierra el formulario actual (Inicio)
            Login loginForm = new Login();
            loginForm.Show(); // Muestra el formulario de inicio de sesión
        }

    }
}

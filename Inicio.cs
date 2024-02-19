using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
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
        private static Usuario UsuarioActual;
        private static IconMenuItem currentMenu = null;
        private static Form currentForm = null;
        public Inicio(Usuario oUsuario)
        {
            UsuarioActual = oUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(UsuarioActual.IdUsuario);
            foreach (IconMenuItem iconMenu in menuPrincipal.Items)
            {
                bool encontrado = ListaPermisos.Any(x => x.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            labelNombreUsuario.Text = UsuarioActual.NombreCompleto;
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

        private void OpenForm(IconMenuItem menu, Form formulario)
        {
            if (currentMenu != null)
            {
                currentMenu.BackColor = Color.White;
            }

            menu.BackColor = Color.FromArgb(240, 130, 59);
            currentMenu = menu;

            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(84, 84, 84);

            contenedorPrincipal.Controls.Add(formulario);
            contenedorPrincipal.Tag = formulario;
            formulario.Show();
        }

        private void iconMenuUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formUsuarios());
        }

        private void iconMenuItemCategoria_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuMantenedor, new formCategoria());
        }

        private void iconMenuItemProducto_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuMantenedor, new formProducto());
        }

        private void iconMenuItemRegistrar_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuVentas, new formVentas());
        }

        private void iconMenuItemVerDetalleVenta_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuVentas, new formDetalleVenta());
        }

        private void iconMenuItemRegistrarCompra_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuCompras, new formCompras());
        }

        private void iconMenuItemVerDetalleCompra_Click(object sender, EventArgs e)
        {
            OpenForm(iconMenuCompras, new formDetalleCompra());
        }

        private void iconMenuCliente_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formClientes());
        }

        private void iconMenuProveedores_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formClientes());
        }

        private void iconMenuReportes_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formReportes());
        }
    }
}

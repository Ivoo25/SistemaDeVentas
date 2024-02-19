using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace SistemaDeVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            Usuario oUsuario =
                new CN_Usuario()
                    .Listar()
                    .Where(u => u.Documento == textBoxUsuario.Text && u.Contraseña == textBoxContraseña.Text)
                    .FirstOrDefault();
            if (oUsuario != null)
            {
                Inicio inicioForm = new Inicio(oUsuario);
                inicioForm.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuario o contraseña incorrectos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Dentro del evento FormClosing del formulario Login
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0); // Cierra la aplicación completamente
                System.Windows.Forms.Application.Exit(); // Cierra la aplicación completamente
            }
        }

        // Dentro del evento Load del formulario Login
        private void Login_Carga(object sender, EventArgs e)
        {
            LimpiarInputs();
        }

        // Método para limpiar los inputs
        private void LimpiarInputs()
        {
            textBoxUsuario.Clear(); // Suponiendo que txtUsuario es el nombre del TextBox para el nombre de usuario
            textBoxContraseña.Clear(); // Suponiendo que txtContraseña es el nombre del TextBox para la contraseña
        }

    }
}

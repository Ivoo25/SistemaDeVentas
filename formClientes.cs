using CapaEntidad;
using CapaNegocio;
using SistemaDeVentas.Utilities;
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
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            //comboBoxEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dataGridViewDataUser.Columns)
            {
                if (column.Visible == true && column.Name != "buttonSeleccionar")
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }

            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            //Show all users
            List<Cliente> listaCliente = new CN_Cliente().Listar();
            foreach (Cliente u in listaCliente)
            {
                dataGridViewDataUser.Rows.Add(
                    new object[]
                    {
                    "",
                    u.IdCliente,
                    u.NombreCompleto,
                    u.Documento,
                    u.Correo,
                    u.Telefono,
                    u.Estado == true ? 1 : 0,
                    u.Estado == true ? "Activo" : "No activo"
                    }
                    );
            }
        }

        private void iconButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool editado = false;

            Cliente u = new Cliente()
            {
                IdCliente = Convert.ToInt32(textBoxId.Text),
                Documento = textBoxDocumento.Text,
                NombreCompleto = textBoxNombreCompleto.Text,
                Correo = textBoxCorreo.Text,
                Telefono = textBoxTelefono.Text,
                Estado = Convert.ToString((OpcionCombo)comboBoxEstado.SelectedItem) == "Activo" ? true : false
            };

            if (u.IdCliente == 0)
            {
                int idClienteGenerado = new CN_Cliente().Registrar(u, out mensaje);
                if (idClienteGenerado != 0)
                {
                    dataGridViewDataUser.Rows.Add(
                   new object[]
                   {
                    "",
                    idClienteGenerado,
                    textBoxNombreCompleto.Text,
                    textBoxDocumento.Text,
                    textBoxCorreo.Text,
                    textBoxTelefono.Text,
                    ((OpcionCombo) comboBoxEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo) comboBoxEstado.SelectedItem).Texto.ToString()
    }
                   );
                    MessageBox.Show("Cliente creado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al crear el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarFormulario();
            }
            else
            {
                editado = new CN_Cliente().Editar(u, out mensaje);
                if (editado)
                {
                    DataGridViewRow row = dataGridViewDataUser.Rows[Convert.ToInt32(textBoxIndiceGrid.Text)];
                    row.Cells["IdCliente"].Value = textBoxId.Text;
                    row.Cells["NombreCompleto"].Value = textBoxNombreCompleto.Text;
                    row.Cells["Documento"].Value = textBoxDocumento.Text;
                    row.Cells["Correo"].Value = textBoxCorreo.Text;
                    row.Cells["Telefono"].Value = textBoxTelefono.Text;
                    row.Cells["Estado"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();
                    MessageBox.Show("Cliente editado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarFormulario();
            }
        }

        private void iconButtonLimpiarCampos_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            limpiarFormulario();
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente u = new Cliente()
            {
                IdCliente = Convert.ToInt32(textBoxId.Text),
                Documento = textBoxDocumento.Text,
                NombreCompleto = textBoxNombreCompleto.Text,
                Correo = textBoxCorreo.Text,
                Telefono = textBoxTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false,
            };
            bool eliminado = new CN_Cliente().Eliminar(u, out mensaje);
            if (eliminado)
            {
                dataGridViewDataUser.Rows.RemoveAt(Convert.ToInt32(textBoxIndiceGrid.Text));
                MessageBox.Show("Cliente eliminado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            textBoxNombreCompleto.Clear();
            textBoxDocumento.Clear();
            textBoxCorreo.Clear();
            textBoxTelefono.Clear();
            comboBoxEstado.SelectedIndex = -1;
            textBoxDocumento.Select();
            textBoxId.Text = "0";
            textBoxIndiceGrid.Text = "-1";
        }

        private void dataGridViewDataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDataUser.Columns[e.ColumnIndex].Name == "buttonSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    textBoxIndiceGrid.Text = index.ToString();
                    textBoxId.Text = dataGridViewDataUser.Rows[index].Cells["IdCliente"].Value.ToString();
                    textBoxNombreCompleto.Text = dataGridViewDataUser.Rows[index].Cells["NombreCompleto"].Value.ToString();
                    textBoxDocumento.Text = dataGridViewDataUser.Rows[index].Cells["Documento"].Value.ToString();
                    textBoxCorreo.Text = dataGridViewDataUser.Rows[index].Cells["Correo"].Value.ToString();
                    textBoxTelefono.Text = dataGridViewDataUser.Rows[index].Cells["Telefono"].Value.ToString();
                    foreach (OpcionCombo item in comboBoxEstado.Items)
                    {
                        if (item.Valor.ToString() == dataGridViewDataUser.Rows[index].Cells["Estado"].Value.ToString())
                        {
                            comboBoxEstado.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void dataGridViewDataUser_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 20;
                var h = 20;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.cheque, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();
            if (dataGridViewDataUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewDataUser.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToLower().Contains(textBoxBusqueda.Text.ToLower()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void iconButtonLimpiarFiltros_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            comboBoxBusqueda.SelectedIndex = -1;
            foreach (DataGridViewRow row in dataGridViewDataUser.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

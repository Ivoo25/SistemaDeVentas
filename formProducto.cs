using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
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
    public partial class formProducto : Form
    {
        public formProducto()
        {
            InitializeComponent();
        }

        private void formProducto_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            //comboBoxEstado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria categoria in listaCategoria)
            {
                comboBoxCategoria.Items.Add(new OpcionCombo() { Valor = categoria.IdCategoria, Texto = categoria.Descripcion });
            }
            comboBoxCategoria.DisplayMember = "Texto";
            comboBoxCategoria.ValueMember = "Valor";

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
            List<Producto> listaProducto = new CN_Producto().Listar();
            foreach (Producto u in listaProducto)
            {
                dataGridViewDataUser.Rows.Add(
                    new object[]
                    {
                    "",
                    u.IdProducto,
                    u.Nombre,
                    u.Codigo,
                    u.Descripcion,
                    u.oCategoria.IdCategoria,
                    u.oCategoria.Descripcion,
                    u.Stock,
                    u.PrecioCompra,
                    u.PrecioVenta,
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

            Producto u = new Producto()
            {
                IdProducto = Convert.ToInt32(textBoxId.Text),
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombreProducto.Text,
                Descripcion = textBoxDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)comboBoxCategoria.SelectedItem).Valor) },
                Estado = Convert.ToString((OpcionCombo)comboBoxEstado.SelectedItem) == "Activo" ? true : false
            };

            if (u.IdProducto == 0)
            {
                int idProductoGenerado = new CN_Producto().Registrar(u, out mensaje);
                if (idProductoGenerado != 0)
                {
                    dataGridViewDataUser.Rows.Add(
                   new object[]
                   {
                    "",
                    idProductoGenerado,
                    textBoxNombreProducto.Text,
                    textBoxCodigo.Text,
                    textBoxDescripcion.Text,
                    ((OpcionCombo) comboBoxCategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo) comboBoxCategoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
                    ((OpcionCombo) comboBoxEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo) comboBoxEstado.SelectedItem).Texto.ToString()
    }
                   );
                    MessageBox.Show("Producto creado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al crear el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarFormulario();
            }
            else
            {
                editado = new CN_Producto().Editar(u, out mensaje);
                if (editado)
                {
                    DataGridViewRow row = dataGridViewDataUser.Rows[Convert.ToInt32(textBoxIndiceGrid.Text)];
                    row.Cells["Id"].Value = textBoxId.Text;
                    row.Cells["Nombre"].Value = textBoxNombreProducto.Text;
                    row.Cells["Codigo"].Value = textBoxCodigo.Text;
                    row.Cells["Descripcion"].Value = textBoxDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)comboBoxCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)comboBoxCategoria.SelectedItem).Texto.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();
                    MessageBox.Show("Producto editado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Producto u = new Producto()
            {
                IdProducto = Convert.ToInt32(textBoxId.Text),
            };
            bool eliminado = new CN_Producto().Eliminar(u, out mensaje);
            if (eliminado)
            {
                dataGridViewDataUser.Rows.RemoveAt(Convert.ToInt32(textBoxIndiceGrid.Text));
                MessageBox.Show("Producto eliminado con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            textBoxBusqueda.Text = "";
            textBoxNombreProducto.Text = "";
            textBoxCodigo.Text = "";
            textBoxDescripcion.Text = "";
            textBoxId.Text = "0";
            textBoxIndiceGrid.Text = "-1";
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
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

        private void dataGridViewDataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDataUser.Columns[e.ColumnIndex].Name == "buttonSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    textBoxIndiceGrid.Text = index.ToString();
                    textBoxId.Text = dataGridViewDataUser.Rows[index].Cells["Id"].Value.ToString();
                    textBoxNombreProducto.Text = dataGridViewDataUser.Rows[index].Cells["Nombre"].Value.ToString();
                    textBoxDescripcion.Text = dataGridViewDataUser.Rows[index].Cells["Descripcion"].Value.ToString();
                    textBoxCodigo.Text = dataGridViewDataUser.Rows[index].Cells["Codigo"].Value.ToString();

                    foreach (OpcionCombo item in comboBoxCategoria.Items)
                    {
                        if (item.Valor.ToString() == dataGridViewDataUser.Rows[index].Cells["IdCategoria"].Value.ToString())
                        {
                            comboBoxCategoria.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (OpcionCombo item in comboBoxEstado.Items)
                    {
                        var cellValue = dataGridViewDataUser.Rows[index].Cells["Estado"].Value;
                        if (cellValue != null && item.Valor.ToString() == cellValue.ToString())
                        {
                            comboBoxEstado.SelectedItem = item;
                            break;
                        }
                    }
                }
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

        private void iconButtonLimpiarFiltro_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            comboBoxBusqueda.SelectedIndex = -1;
            foreach (DataGridViewRow row in dataGridViewDataUser.Rows)
            {
                row.Visible = true;
            }
        }

        private void iconButtonExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewDataUser.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dataGridViewDataUser.Columns)
                {
                    if (column.Visible == true && !string.IsNullOrEmpty(column.HeaderText))
                    {
                        dt.Columns.Add(column.HeaderText, typeof(string));
                    }
                }
                foreach (DataGridViewRow row in dataGridViewDataUser.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewColumn column in dataGridViewDataUser.Columns)
                    {
                        if (column.Visible == true && dt.Columns.Contains(column.HeaderText))
                        {
                            dRow[column.HeaderText] = row.Cells[column.Index].Value;
                        }
                    }
                    dt.Rows.Add(dRow);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //Save file name with current date in DD-MM-YYYY format
                saveFileDialog.FileName = "Productos_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        wb.Worksheets.Add(dt, "Productos");
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Datos exportados con exito.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

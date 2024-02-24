namespace SistemaDeVentas
{
    partial class formProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxIndiceGrid = new System.Windows.Forms.TextBox();
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.toolTipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.toolTipBuscarLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEditar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonLimpiarFiltro = new FontAwesome.Sharp.IconButton();
            this.iconButtonLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDataUser = new System.Windows.Forms.DataGridView();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.labelNroDocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIndiceGrid
            // 
            this.textBoxIndiceGrid.Location = new System.Drawing.Point(517, 14);
            this.textBoxIndiceGrid.Name = "textBoxIndiceGrid";
            this.textBoxIndiceGrid.Size = new System.Drawing.Size(56, 22);
            this.textBoxIndiceGrid.TabIndex = 53;
            this.textBoxIndiceGrid.Text = "-1";
            this.textBoxIndiceGrid.Visible = false;
            // 
            // iconButtonEliminar
            // 
            this.iconButtonEliminar.AccessibleDescription = "Eliminar";
            this.iconButtonEliminar.AccessibleName = "Eliminar";
            this.iconButtonEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.iconButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonEliminar.IconColor = System.Drawing.Color.White;
            this.iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEliminar.IconSize = 40;
            this.iconButtonEliminar.Location = new System.Drawing.Point(166, 752);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Size = new System.Drawing.Size(65, 65);
            this.iconButtonEliminar.TabIndex = 43;
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEliminar.SetToolTip(this.iconButtonEliminar, "Eliminar registro");
            this.iconButtonEliminar.UseVisualStyleBackColor = false;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.AccessibleDescription = "Guardar";
            this.iconButtonBuscar.AccessibleName = "Guardar";
            this.iconButtonBuscar.BackColor = System.Drawing.Color.White;
            this.iconButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.Black;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.Black;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 30;
            this.iconButtonBuscar.Location = new System.Drawing.Point(1233, 14);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButtonBuscar.Size = new System.Drawing.Size(30, 30);
            this.iconButtonBuscar.TabIndex = 52;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipGuardar.SetToolTip(this.iconButtonBuscar, "Buscar");
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // iconButtonGuardarCambios
            // 
            this.iconButtonGuardarCambios.AccessibleDescription = "Guardar";
            this.iconButtonGuardarCambios.AccessibleName = "Guardar";
            this.iconButtonGuardarCambios.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.iconButtonGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButtonGuardarCambios.IconColor = System.Drawing.Color.White;
            this.iconButtonGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGuardarCambios.IconSize = 40;
            this.iconButtonGuardarCambios.Location = new System.Drawing.Point(11, 752);
            this.iconButtonGuardarCambios.Name = "iconButtonGuardarCambios";
            this.iconButtonGuardarCambios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButtonGuardarCambios.Size = new System.Drawing.Size(65, 65);
            this.iconButtonGuardarCambios.TabIndex = 44;
            this.iconButtonGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipGuardar.SetToolTip(this.iconButtonGuardarCambios, "Guardar registro");
            this.iconButtonGuardarCambios.UseVisualStyleBackColor = false;
            this.iconButtonGuardarCambios.Click += new System.EventHandler(this.iconButtonGuardarCambios_Click);
            // 
            // iconButtonLimpiarFiltro
            // 
            this.iconButtonLimpiarFiltro.AccessibleDescription = "Editar";
            this.iconButtonLimpiarFiltro.AccessibleName = "Editar";
            this.iconButtonLimpiarFiltro.BackColor = System.Drawing.Color.White;
            this.iconButtonLimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLimpiarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLimpiarFiltro.ForeColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButtonLimpiarFiltro.IconColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLimpiarFiltro.IconSize = 30;
            this.iconButtonLimpiarFiltro.Location = new System.Drawing.Point(1269, 14);
            this.iconButtonLimpiarFiltro.Name = "iconButtonLimpiarFiltro";
            this.iconButtonLimpiarFiltro.Size = new System.Drawing.Size(30, 30);
            this.iconButtonLimpiarFiltro.TabIndex = 51;
            this.iconButtonLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarFiltro, "Limpiar filtros");
            this.iconButtonLimpiarFiltro.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarFiltro.Click += new System.EventHandler(this.iconButtonLimpiarFiltro_Click);
            // 
            // iconButtonLimpiarCampos
            // 
            this.iconButtonLimpiarCampos.AccessibleDescription = "Editar";
            this.iconButtonLimpiarCampos.AccessibleName = "Editar";
            this.iconButtonLimpiarCampos.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.iconButtonLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButtonLimpiarCampos.IconColor = System.Drawing.Color.White;
            this.iconButtonLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLimpiarCampos.IconSize = 40;
            this.iconButtonLimpiarCampos.Location = new System.Drawing.Point(89, 752);
            this.iconButtonLimpiarCampos.Name = "iconButtonLimpiarCampos";
            this.iconButtonLimpiarCampos.Size = new System.Drawing.Size(65, 65);
            this.iconButtonLimpiarCampos.TabIndex = 42;
            this.iconButtonLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarCampos, "Limpiar campos");
            this.iconButtonLimpiarCampos.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarCampos.Click += new System.EventHandler(this.iconButtonLimpiarCampos_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(1007, 20);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(220, 22);
            this.textBoxBusqueda.TabIndex = 50;
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(781, 20);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(220, 24);
            this.comboBoxBusqueda.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(680, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Buscar por:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(163, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(56, 22);
            this.textBoxId.TabIndex = 47;
            this.textBoxId.Text = "0";
            this.textBoxId.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1100, 52);
            this.label2.TabIndex = 46;
            this.label2.Text = "Lista de Productos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewDataUser
            // 
            this.dataGridViewDataUser.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonSeleccionar,
            this.Id,
            this.Nombre,
            this.Codigo,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Estado,
            this.EstadoValor});
            this.dataGridViewDataUser.Location = new System.Drawing.Point(243, 50);
            this.dataGridViewDataUser.MultiSelect = false;
            this.dataGridViewDataUser.Name = "dataGridViewDataUser";
            this.dataGridViewDataUser.ReadOnly = true;
            this.dataGridViewDataUser.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDataUser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDataUser.RowTemplate.Height = 28;
            this.dataGridViewDataUser.Size = new System.Drawing.Size(1100, 800);
            this.dataGridViewDataUser.TabIndex = 45;
            this.dataGridViewDataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataUser_CellContentClick);
            this.dataGridViewDataUser.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewDataUser_CellPainting);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(11, 286);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(220, 24);
            this.comboBoxEstado.TabIndex = 41;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(11, 223);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(220, 24);
            this.comboBoxCategoria.TabIndex = 40;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(11, 34);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(220, 22);
            this.textBoxCodigo.TabIndex = 39;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(11, 160);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(220, 22);
            this.textBoxDescripcion.TabIndex = 38;
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Location = new System.Drawing.Point(11, 97);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(220, 22);
            this.textBoxNombreProducto.TabIndex = 35;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(8, 204);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 16);
            this.labelCategoria.TabIndex = 34;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(8, 267);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 16);
            this.labelEstado.TabIndex = 33;
            this.labelEstado.Text = "Estado:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(8, 141);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelDescripcion.TabIndex = 30;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.BackColor = System.Drawing.Color.White;
            this.labelNombreProducto.Location = new System.Drawing.Point(8, 78);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(138, 16);
            this.labelNombreProducto.TabIndex = 29;
            this.labelNombreProducto.Text = "Nombre del Producto:";
            // 
            // labelNroDocumento
            // 
            this.labelNroDocumento.AutoSize = true;
            this.labelNroDocumento.BackColor = System.Drawing.Color.White;
            this.labelNroDocumento.Location = new System.Drawing.Point(8, 15);
            this.labelNroDocumento.Name = "labelNroDocumento";
            this.labelNroDocumento.Size = new System.Drawing.Size(130, 16);
            this.labelNroDocumento.TabIndex = 28;
            this.labelNroDocumento.Text = "Código del Producto";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 843);
            this.label1.TabIndex = 27;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.MinimumWidth = 6;
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.MinimumWidth = 6;
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 180;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Width = 180;
            // 
            // formProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 843);
            this.Controls.Add(this.textBoxIndiceGrid);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.iconButtonLimpiarFiltro);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDataUser);
            this.Controls.Add(this.iconButtonGuardarCambios);
            this.Controls.Add(this.iconButtonEliminar);
            this.Controls.Add(this.iconButtonLimpiarCampos);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombreProducto);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombreProducto);
            this.Controls.Add(this.labelNroDocumento);
            this.Controls.Add(this.label1);
            this.Name = "formProducto";
            this.Text = "formProducto";
            this.Load += new System.EventHandler(this.formProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIndiceGrid;
        private System.Windows.Forms.ToolTip toolTipEliminar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.ToolTip toolTipGuardar;
        private FontAwesome.Sharp.IconButton iconButtonGuardarCambios;
        private System.Windows.Forms.ToolTip toolTipBuscarLimpiar;
        private System.Windows.Forms.ToolTip toolTipEditar;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarFiltro;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarCampos;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDataUser;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.Label labelNroDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}
namespace SistemaDeVentas
{
    partial class formClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTipBuscarLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridViewDataUser = new System.Windows.Forms.DataGridView();
            this.textBoxIndiceGrid = new System.Windows.Forms.TextBox();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.iconButtonLimpiarFiltro = new FontAwesome.Sharp.IconButton();
            this.iconButtonLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelNroDocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipEditar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonLimpiarFiltros = new FontAwesome.Sharp.IconButton();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).BeginInit();
            this.SuspendLayout();
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
            this.iconButtonEliminar.Location = new System.Drawing.Point(157, 747);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Size = new System.Drawing.Size(65, 65);
            this.iconButtonEliminar.TabIndex = 43;
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEliminar.SetToolTip(this.iconButtonEliminar, "Eliminar registro");
            this.iconButtonEliminar.UseVisualStyleBackColor = false;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
            // 
            // dataGridViewDataUser
            // 
            this.dataGridViewDataUser.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buttonSeleccionar,
            this.IdCliente,
            this.NombreCompleto,
            this.Documento,
            this.Correo,
            this.Telefono,
            this.Estado,
            this.EstadoValor});
            this.dataGridViewDataUser.Location = new System.Drawing.Point(241, 47);
            this.dataGridViewDataUser.MultiSelect = false;
            this.dataGridViewDataUser.Name = "dataGridViewDataUser";
            this.dataGridViewDataUser.ReadOnly = true;
            this.dataGridViewDataUser.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDataUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDataUser.RowTemplate.Height = 28;
            this.dataGridViewDataUser.Size = new System.Drawing.Size(1100, 800);
            this.dataGridViewDataUser.TabIndex = 45;
            this.dataGridViewDataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataUser_CellContentClick);
            this.dataGridViewDataUser.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewDataUser_CellPainting);
            // 
            // textBoxIndiceGrid
            // 
            this.textBoxIndiceGrid.Location = new System.Drawing.Point(508, 9);
            this.textBoxIndiceGrid.Name = "textBoxIndiceGrid";
            this.textBoxIndiceGrid.Size = new System.Drawing.Size(56, 22);
            this.textBoxIndiceGrid.TabIndex = 53;
            this.textBoxIndiceGrid.Text = "-1";
            this.textBoxIndiceGrid.Visible = false;
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(1224, 9);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconButtonBuscar.Size = new System.Drawing.Size(30, 30);
            this.iconButtonBuscar.TabIndex = 52;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipGuardar.SetToolTip(this.iconButtonBuscar, "Buscar");
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(998, 15);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(220, 22);
            this.textBoxBusqueda.TabIndex = 50;
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(772, 15);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(220, 24);
            this.comboBoxBusqueda.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(671, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Buscar por:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(154, 4);
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
            this.label2.Location = new System.Drawing.Point(234, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1094, 52);
            this.label2.TabIndex = 46;
            this.label2.Text = "Lista de Clientes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.iconButtonGuardarCambios.Location = new System.Drawing.Point(2, 747);
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
            this.iconButtonLimpiarFiltro.Location = new System.Drawing.Point(1260, 9);
            this.iconButtonLimpiarFiltro.Name = "iconButtonLimpiarFiltro";
            this.iconButtonLimpiarFiltro.Size = new System.Drawing.Size(30, 30);
            this.iconButtonLimpiarFiltro.TabIndex = 51;
            this.iconButtonLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarFiltro, "Limpiar filtros");
            this.iconButtonLimpiarFiltro.UseVisualStyleBackColor = false;
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
            this.iconButtonLimpiarCampos.Location = new System.Drawing.Point(80, 747);
            this.iconButtonLimpiarCampos.Name = "iconButtonLimpiarCampos";
            this.iconButtonLimpiarCampos.Size = new System.Drawing.Size(65, 65);
            this.iconButtonLimpiarCampos.TabIndex = 42;
            this.iconButtonLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarCampos, "Limpiar campos");
            this.iconButtonLimpiarCampos.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarCampos.Click += new System.EventHandler(this.iconButtonLimpiarCampos_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(2, 281);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(220, 24);
            this.comboBoxEstado.TabIndex = 41;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(2, 29);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(220, 22);
            this.textBoxDocumento.TabIndex = 39;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(2, 155);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(220, 22);
            this.textBoxCorreo.TabIndex = 38;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(2, 218);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(220, 22);
            this.textBoxTelefono.TabIndex = 37;
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(2, 92);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(220, 22);
            this.textBoxNombreCompleto.TabIndex = 35;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(-1, 199);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(64, 16);
            this.labelRol.TabIndex = 34;
            this.labelRol.Text = "Teléfono:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(-1, 262);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 16);
            this.labelEstado.TabIndex = 33;
            this.labelEstado.Text = "Estado:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.White;
            this.labelCorreo.Location = new System.Drawing.Point(-1, 136);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(51, 16);
            this.labelCorreo.TabIndex = 30;
            this.labelCorreo.Text = "Correo:";
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.BackColor = System.Drawing.Color.White;
            this.labelNombreCompleto.Location = new System.Drawing.Point(-1, 73);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(120, 16);
            this.labelNombreCompleto.TabIndex = 29;
            this.labelNombreCompleto.Text = "Nombre Completo:";
            // 
            // labelNroDocumento
            // 
            this.labelNroDocumento.AutoSize = true;
            this.labelNroDocumento.BackColor = System.Drawing.Color.White;
            this.labelNroDocumento.Location = new System.Drawing.Point(-1, 10);
            this.labelNroDocumento.Name = "labelNroDocumento";
            this.labelNroDocumento.Size = new System.Drawing.Size(149, 16);
            this.labelNroDocumento.TabIndex = 28;
            this.labelNroDocumento.Text = "Numero de Documento:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 843);
            this.label1.TabIndex = 27;
            // 
            // iconButtonLimpiarFiltros
            // 
            this.iconButtonLimpiarFiltros.AccessibleDescription = "Editar";
            this.iconButtonLimpiarFiltros.AccessibleName = "Editar";
            this.iconButtonLimpiarFiltros.BackColor = System.Drawing.Color.White;
            this.iconButtonLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLimpiarFiltros.ForeColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltros.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButtonLimpiarFiltros.IconColor = System.Drawing.Color.Black;
            this.iconButtonLimpiarFiltros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLimpiarFiltros.IconSize = 30;
            this.iconButtonLimpiarFiltros.Location = new System.Drawing.Point(1260, 9);
            this.iconButtonLimpiarFiltros.Name = "iconButtonLimpiarFiltros";
            this.iconButtonLimpiarFiltros.Size = new System.Drawing.Size(30, 30);
            this.iconButtonLimpiarFiltros.TabIndex = 54;
            this.iconButtonLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarFiltros, "Limpiar filtros");
            this.iconButtonLimpiarFiltros.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarFiltros.Click += new System.EventHandler(this.iconButtonLimpiarFiltros_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.MinimumWidth = 6;
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            this.IdCliente.Width = 125;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Numero de Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 200;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 200;
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
            this.EstadoValor.Width = 200;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 843);
            this.Controls.Add(this.iconButtonLimpiarFiltros);
            this.Controls.Add(this.dataGridViewDataUser);
            this.Controls.Add(this.textBoxIndiceGrid);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButtonLimpiarFiltro);
            this.Controls.Add(this.iconButtonGuardarCambios);
            this.Controls.Add(this.iconButtonEliminar);
            this.Controls.Add(this.iconButtonLimpiarCampos);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombreCompleto);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.labelNroDocumento);
            this.Controls.Add(this.label1);
            this.Name = "formClientes";
            this.Text = "formClientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipBuscarLimpiar;
        private System.Windows.Forms.ToolTip toolTipEliminar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewDataUser;
        private System.Windows.Forms.TextBox textBoxIndiceGrid;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.ToolTip toolTipGuardar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonGuardarCambios;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarFiltro;
        private System.Windows.Forms.ToolTip toolTipEditar;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarCampos;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelNroDocumento;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarFiltros;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}
using System;

namespace SistemaDeVentas
{
    partial class formUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNroDocumento = new System.Windows.Forms.Label();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelConfirmarContraseña = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.textBoxNombreCompleto = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarClave = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.iconButtonLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.iconButtonGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.toolTipEditar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonLimpiarFiltro = new FontAwesome.Sharp.IconButton();
            this.toolTipGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewDataUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.toolTipBuscarLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxIndiceGrid = new System.Windows.Forms.TextBox();
            this.buttonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 843);
            this.label1.TabIndex = 0;
            // 
            // labelNroDocumento
            // 
            this.labelNroDocumento.AutoSize = true;
            this.labelNroDocumento.BackColor = System.Drawing.Color.White;
            this.labelNroDocumento.Location = new System.Drawing.Point(8, 15);
            this.labelNroDocumento.Name = "labelNroDocumento";
            this.labelNroDocumento.Size = new System.Drawing.Size(149, 16);
            this.labelNroDocumento.TabIndex = 1;
            this.labelNroDocumento.Text = "Numero de Documento:";
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.BackColor = System.Drawing.Color.White;
            this.labelNombreCompleto.Location = new System.Drawing.Point(8, 78);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(120, 16);
            this.labelNombreCompleto.TabIndex = 2;
            this.labelNombreCompleto.Text = "Nombre Completo:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.White;
            this.labelCorreo.Location = new System.Drawing.Point(8, 141);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(51, 16);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo:";
            // 
            // labelConfirmarContraseña
            // 
            this.labelConfirmarContraseña.AutoSize = true;
            this.labelConfirmarContraseña.BackColor = System.Drawing.Color.White;
            this.labelConfirmarContraseña.Location = new System.Drawing.Point(8, 393);
            this.labelConfirmarContraseña.Name = "labelConfirmarContraseña";
            this.labelConfirmarContraseña.Size = new System.Drawing.Size(139, 16);
            this.labelConfirmarContraseña.TabIndex = 4;
            this.labelConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.BackColor = System.Drawing.Color.White;
            this.labelContraseña.Location = new System.Drawing.Point(8, 330);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(79, 16);
            this.labelContraseña.TabIndex = 5;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(8, 267);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 16);
            this.labelEstado.TabIndex = 6;
            this.labelEstado.Text = "Estado:";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(8, 204);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(31, 16);
            this.labelRol.TabIndex = 7;
            this.labelRol.Text = "Rol:";
            // 
            // textBoxNombreCompleto
            // 
            this.textBoxNombreCompleto.Location = new System.Drawing.Point(11, 97);
            this.textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            this.textBoxNombreCompleto.Size = new System.Drawing.Size(220, 22);
            this.textBoxNombreCompleto.TabIndex = 8;
            // 
            // textBoxConfirmarClave
            // 
            this.textBoxConfirmarClave.Location = new System.Drawing.Point(11, 412);
            this.textBoxConfirmarClave.Name = "textBoxConfirmarClave";
            this.textBoxConfirmarClave.PasswordChar = '*';
            this.textBoxConfirmarClave.Size = new System.Drawing.Size(220, 22);
            this.textBoxConfirmarClave.TabIndex = 9;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(11, 349);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(220, 22);
            this.textBoxContraseña.TabIndex = 10;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(11, 160);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(220, 22);
            this.textBoxCorreo.TabIndex = 11;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(11, 34);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(220, 22);
            this.textBoxDocumento.TabIndex = 12;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(11, 223);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(220, 24);
            this.comboBoxRol.TabIndex = 13;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(11, 286);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(220, 24);
            this.comboBoxEstado.TabIndex = 14;
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
            this.iconButtonLimpiarCampos.TabIndex = 15;
            this.iconButtonLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarCampos, "Limpiar campos");
            this.iconButtonLimpiarCampos.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarCampos.Click += new System.EventHandler(this.iconButtonLimpiarCampos_Click);
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
            this.iconButtonEliminar.TabIndex = 16;
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEliminar.SetToolTip(this.iconButtonEliminar, "Eliminar registro");
            this.iconButtonEliminar.UseVisualStyleBackColor = false;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
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
            this.iconButtonGuardarCambios.TabIndex = 17;
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
            this.iconButtonLimpiarFiltro.TabIndex = 24;
            this.iconButtonLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipEditar.SetToolTip(this.iconButtonLimpiarFiltro, "Limpiar filtros");
            this.iconButtonLimpiarFiltro.UseVisualStyleBackColor = false;
            this.iconButtonLimpiarFiltro.Click += new System.EventHandler(this.iconButtonLimpiarFiltro_Click);
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
            this.iconButtonBuscar.TabIndex = 25;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipGuardar.SetToolTip(this.iconButtonBuscar, "Buscar");
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
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
            this.IdUsuario,
            this.NombreCompleto,
            this.Documento,
            this.Correo,
            this.Contraseña,
            this.IdRol,
            this.Rol,
            this.Estado,
            this.EstadoValor});
            this.dataGridViewDataUser.Location = new System.Drawing.Point(250, 52);
            this.dataGridViewDataUser.MultiSelect = false;
            this.dataGridViewDataUser.Name = "dataGridViewDataUser";
            this.dataGridViewDataUser.ReadOnly = true;
            this.dataGridViewDataUser.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDataUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDataUser.RowTemplate.Height = 28;
            this.dataGridViewDataUser.Size = new System.Drawing.Size(1100, 800);
            this.dataGridViewDataUser.TabIndex = 18;
            this.dataGridViewDataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataUser_CellContentClick);
            this.dataGridViewDataUser.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewDataUser_CellPainting);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1094, 52);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lista de Usuarios:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(163, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(56, 22);
            this.textBoxId.TabIndex = 20;
            this.textBoxId.Text = "0";
            this.textBoxId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(680, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Buscar por:";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(781, 20);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(220, 24);
            this.comboBoxBusqueda.TabIndex = 22;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(1007, 20);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(220, 22);
            this.textBoxBusqueda.TabIndex = 23;
            // 
            // textBoxIndiceGrid
            // 
            this.textBoxIndiceGrid.Location = new System.Drawing.Point(517, 14);
            this.textBoxIndiceGrid.Name = "textBoxIndiceGrid";
            this.textBoxIndiceGrid.Size = new System.Drawing.Size(56, 22);
            this.textBoxIndiceGrid.TabIndex = 26;
            this.textBoxIndiceGrid.Text = "-1";
            this.textBoxIndiceGrid.Visible = false;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.HeaderText = "";
            this.buttonSeleccionar.MinimumWidth = 6;
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.ReadOnly = true;
            this.buttonSeleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 125;
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
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Visible = false;
            this.Contraseña.Width = 200;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 200;
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
            // formUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
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
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxConfirmarClave);
            this.Controls.Add(this.textBoxNombreCompleto);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelConfirmarContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.labelNroDocumento);
            this.Controls.Add(this.label1);
            this.Name = "formUsuarios";
            this.Text = "formUsuarios";
            this.Load += new System.EventHandler(this.formUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNroDocumento;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelConfirmarContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.TextBox textBoxNombreCompleto;
        private System.Windows.Forms.TextBox textBoxConfirmarClave;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarCampos;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonGuardarCambios;
        private System.Windows.Forms.ToolTip toolTipEditar;
        private System.Windows.Forms.ToolTip toolTipGuardar;
        private System.Windows.Forms.ToolTip toolTipEliminar;
        private System.Windows.Forms.DataGridView dataGridViewDataUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private FontAwesome.Sharp.IconButton iconButtonLimpiarFiltro;
        private System.Windows.Forms.ToolTip toolTipBuscarLimpiar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIndiceGrid;
        private System.Windows.Forms.DataGridViewButtonColumn buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}
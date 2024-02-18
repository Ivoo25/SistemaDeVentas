namespace SistemaDeVentas
{
    partial class Inicio
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iconMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemProducto = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCliente = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.contenedorPrincipal = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.iconMenuItemRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuUsuarios,
            this.iconMenuMantenedor,
            this.iconMenuVentas,
            this.iconMenuCompras,
            this.iconMenuCliente,
            this.iconMenuProveedores,
            this.iconMenuReportes,
            this.iconMenuAcercaDe,
            this.iconMenuCerrarSesion});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 60);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1324, 73);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // iconMenuUsuarios
            // 
            this.iconMenuUsuarios.AutoSize = false;
            this.iconMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconMenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.iconMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuUsuarios.IconSize = 50;
            this.iconMenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuUsuarios.Name = "iconMenuUsuarios";
            this.iconMenuUsuarios.Size = new System.Drawing.Size(152, 69);
            this.iconMenuUsuarios.Text = "Usuarios";
            this.iconMenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuUsuarios.Click += new System.EventHandler(this.iconMenuUsuarios_Click);
            // 
            // iconMenuMantenedor
            // 
            this.iconMenuMantenedor.AutoSize = false;
            this.iconMenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemCategoria,
            this.iconMenuItemProducto});
            this.iconMenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconMenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.iconMenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuMantenedor.IconSize = 50;
            this.iconMenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuMantenedor.Name = "iconMenuMantenedor";
            this.iconMenuMantenedor.Size = new System.Drawing.Size(145, 69);
            this.iconMenuMantenedor.Text = "Mantenedor";
            this.iconMenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItemCategoria
            // 
            this.iconMenuItemCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemCategoria.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemCategoria.Name = "iconMenuItemCategoria";
            this.iconMenuItemCategoria.Size = new System.Drawing.Size(163, 26);
            this.iconMenuItemCategoria.Text = "Categorías";
            this.iconMenuItemCategoria.Click += new System.EventHandler(this.iconMenuItemCategoria_Click);
            // 
            // iconMenuItemProducto
            // 
            this.iconMenuItemProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemProducto.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemProducto.Name = "iconMenuItemProducto";
            this.iconMenuItemProducto.Size = new System.Drawing.Size(163, 26);
            this.iconMenuItemProducto.Text = "Productos";
            this.iconMenuItemProducto.Click += new System.EventHandler(this.iconMenuItemProducto_Click);
            // 
            // iconMenuVentas
            // 
            this.iconMenuVentas.AutoSize = false;
            this.iconMenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemRegistrar,
            this.iconMenuItemVerDetalleVenta});
            this.iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconMenuVentas.IconColor = System.Drawing.Color.Black;
            this.iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuVentas.IconSize = 50;
            this.iconMenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuVentas.Name = "iconMenuVentas";
            this.iconMenuVentas.Size = new System.Drawing.Size(145, 69);
            this.iconMenuVentas.Text = "Ventas";
            this.iconMenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuCompras
            // 
            this.iconMenuCompras.AutoSize = false;
            this.iconMenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemRegistrarCompra,
            this.iconMenuItemVerDetalleCompra});
            this.iconMenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconMenuCompras.IconColor = System.Drawing.Color.Black;
            this.iconMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCompras.IconSize = 50;
            this.iconMenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCompras.Name = "iconMenuCompras";
            this.iconMenuCompras.Size = new System.Drawing.Size(145, 69);
            this.iconMenuCompras.Text = "Compras";
            this.iconMenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuCliente
            // 
            this.iconMenuCliente.AutoSize = false;
            this.iconMenuCliente.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconMenuCliente.IconColor = System.Drawing.Color.Black;
            this.iconMenuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCliente.IconSize = 50;
            this.iconMenuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCliente.Name = "iconMenuCliente";
            this.iconMenuCliente.Size = new System.Drawing.Size(145, 69);
            this.iconMenuCliente.Text = "Clientes";
            this.iconMenuCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuCliente.Click += new System.EventHandler(this.iconMenuCliente_Click);
            // 
            // iconMenuProveedores
            // 
            this.iconMenuProveedores.AutoSize = false;
            this.iconMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconMenuProveedores.IconColor = System.Drawing.Color.Black;
            this.iconMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProveedores.IconSize = 50;
            this.iconMenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuProveedores.Name = "iconMenuProveedores";
            this.iconMenuProveedores.Size = new System.Drawing.Size(145, 69);
            this.iconMenuProveedores.Text = "Proveedores";
            this.iconMenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuProveedores.Click += new System.EventHandler(this.iconMenuProveedores_Click);
            // 
            // iconMenuReportes
            // 
            this.iconMenuReportes.AutoSize = false;
            this.iconMenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconMenuReportes.IconColor = System.Drawing.Color.Black;
            this.iconMenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuReportes.IconSize = 50;
            this.iconMenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuReportes.Name = "iconMenuReportes";
            this.iconMenuReportes.Size = new System.Drawing.Size(145, 69);
            this.iconMenuReportes.Text = "Reportes";
            this.iconMenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuReportes.Click += new System.EventHandler(this.iconMenuReportes_Click);
            // 
            // iconMenuAcercaDe
            // 
            this.iconMenuAcercaDe.AutoSize = false;
            this.iconMenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.iconMenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuAcercaDe.IconSize = 50;
            this.iconMenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuAcercaDe.Name = "iconMenuAcercaDe";
            this.iconMenuAcercaDe.Size = new System.Drawing.Size(145, 69);
            this.iconMenuAcercaDe.Text = "Acerca de";
            this.iconMenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuCerrarSesion
            // 
            this.iconMenuCerrarSesion.AutoSize = false;
            this.iconMenuCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconMenuCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.iconMenuCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCerrarSesion.IconSize = 50;
            this.iconMenuCerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCerrarSesion.Name = "iconMenuCerrarSesion";
            this.iconMenuCerrarSesion.Size = new System.Drawing.Size(145, 69);
            this.iconMenuCerrarSesion.Text = "Cerrar Sesión";
            this.iconMenuCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuCerrarSesion.Click += new System.EventHandler(this.iconMenuCerrarSesion_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1324, 60);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(262, 36);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Sistema de Ventas";
            // 
            // contenedorPrincipal
            // 
            this.contenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPrincipal.Location = new System.Drawing.Point(0, 133);
            this.contenedorPrincipal.Name = "contenedorPrincipal";
            this.contenedorPrincipal.Size = new System.Drawing.Size(1324, 820);
            this.contenedorPrincipal.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(1030, 18);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(85, 25);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(1121, 18);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(64, 25);
            this.labelNombreUsuario.TabIndex = 6;
            this.labelNombreUsuario.Text = "label2";
            // 
            // iconMenuItemRegistrar
            // 
            this.iconMenuItemRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemRegistrar.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemRegistrar.Name = "iconMenuItemRegistrar";
            this.iconMenuItemRegistrar.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItemRegistrar.Text = "Registrar";
            this.iconMenuItemRegistrar.Click += new System.EventHandler(this.iconMenuItemRegistrar_Click);
            // 
            // iconMenuItemVerDetalleVenta
            // 
            this.iconMenuItemVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemVerDetalleVenta.Name = "iconMenuItemVerDetalleVenta";
            this.iconMenuItemVerDetalleVenta.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItemVerDetalleVenta.Text = "Ver detalle";
            this.iconMenuItemVerDetalleVenta.Click += new System.EventHandler(this.iconMenuItemVerDetalleVenta_Click);
            // 
            // iconMenuItemRegistrarCompra
            // 
            this.iconMenuItemRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemRegistrarCompra.Name = "iconMenuItemRegistrarCompra";
            this.iconMenuItemRegistrarCompra.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItemRegistrarCompra.Text = "Registrar compra";
            this.iconMenuItemRegistrarCompra.Click += new System.EventHandler(this.iconMenuItemRegistrarCompra_Click);
            // 
            // iconMenuItemVerDetalleCompra
            // 
            this.iconMenuItemVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemVerDetalleCompra.Name = "iconMenuItemVerDetalleCompra";
            this.iconMenuItemVerDetalleCompra.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItemVerDetalleCompra.Text = "Ver detalle";
            this.iconMenuItemVerDetalleCompra.Click += new System.EventHandler(this.iconMenuItemVerDetalleCompra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 953);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.contenedorPrincipal);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuCerrarSesion;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
        private FontAwesome.Sharp.IconMenuItem iconMenuCompras;
        private FontAwesome.Sharp.IconMenuItem iconMenuCliente;
        private FontAwesome.Sharp.IconMenuItem iconMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem iconMenuReportes;
        private System.Windows.Forms.Panel contenedorPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuAcercaDe;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemCategoria;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProducto;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemRegistrar;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemVerDetalleCompra;
    }
}


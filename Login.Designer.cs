namespace SistemaDeVentas
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.iconButtonIngresar = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 298);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE VENTA";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 245;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(251, 245);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(287, 47);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(149, 16);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Numero de Documento:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(287, 66);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(501, 22);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(287, 174);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(501, 22);
            this.textBoxContraseña.TabIndex = 5;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(287, 155);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(79, 16);
            this.labelContraseña.TabIndex = 6;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // iconButtonIngresar
            // 
            this.iconButtonIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIngresar.ForeColor = System.Drawing.Color.White;
            this.iconButtonIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonIngresar.IconColor = System.Drawing.Color.White;
            this.iconButtonIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIngresar.IconSize = 35;
            this.iconButtonIngresar.Location = new System.Drawing.Point(400, 246);
            this.iconButtonIngresar.Name = "iconButtonIngresar";
            this.iconButtonIngresar.Size = new System.Drawing.Size(130, 40);
            this.iconButtonIngresar.TabIndex = 7;
            this.iconButtonIngresar.Text = "Ingresar";
            this.iconButtonIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonIngresar.UseVisualStyleBackColor = false;
            this.iconButtonIngresar.Click += new System.EventHandler(this.iconButtonIngresar_Click);
            // 
            // iconButtonCancelar
            // 
            this.iconButtonCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.iconButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelar.ForeColor = System.Drawing.Color.White;
            this.iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonCancelar.IconColor = System.Drawing.Color.White;
            this.iconButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelar.IconSize = 35;
            this.iconButtonCancelar.Location = new System.Drawing.Point(536, 246);
            this.iconButtonCancelar.Name = "iconButtonCancelar";
            this.iconButtonCancelar.Size = new System.Drawing.Size(130, 40);
            this.iconButtonCancelar.TabIndex = 8;
            this.iconButtonCancelar.Text = "Cancelar";
            this.iconButtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancelar.UseVisualStyleBackColor = false;
            this.iconButtonCancelar.Click += new System.EventHandler(this.iconButtonCancelar_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.iconButtonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.iconButtonCancelar);
            this.Controls.Add(this.iconButtonIngresar);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private FontAwesome.Sharp.IconButton iconButtonIngresar;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
    }
}
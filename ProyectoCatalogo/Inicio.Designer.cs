namespace ProyectoCatalogo
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.picBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblDescripDetalle = new System.Windows.Forms.Label();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.lblMarcaDetalle = new System.Windows.Forms.Label();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.Location = new System.Drawing.Point(348, 201);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(473, 262);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // picBoxImagen
            // 
            this.picBoxImagen.Location = new System.Drawing.Point(951, 479);
            this.picBoxImagen.Name = "picBoxImagen";
            this.picBoxImagen.Size = new System.Drawing.Size(355, 257);
            this.picBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImagen.TabIndex = 1;
            this.picBoxImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(393, 558);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 50);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(537, 558);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(92, 50);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(681, 558);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(546, 143);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(184, 30);
            this.txtFiltroRapido.TabIndex = 5;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(388, 145);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(152, 28);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtro rapido:";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCaracteristicas.Location = new System.Drawing.Point(1017, 130);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(222, 28);
            this.lblCaracteristicas.TabIndex = 7;
            this.lblCaracteristicas.Text = "Detalle del articulo";
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreDetalle.Location = new System.Drawing.Point(931, 189);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(76, 19);
            this.lblNombreDetalle.TabIndex = 8;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // lblDescripDetalle
            // 
            this.lblDescripDetalle.AutoSize = true;
            this.lblDescripDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescripDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripDetalle.Location = new System.Drawing.Point(931, 240);
            this.lblDescripDetalle.Name = "lblDescripDetalle";
            this.lblDescripDetalle.Size = new System.Drawing.Size(106, 19);
            this.lblDescripDetalle.TabIndex = 9;
            this.lblDescripDetalle.Text = "Descripcion:";
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrecioDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(931, 291);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(64, 19);
            this.lblPrecioDetalle.TabIndex = 10;
            this.lblPrecioDetalle.Text = "Precio:";
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.AutoSize = true;
            this.lblCategoriaDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategoriaDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(931, 393);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(88, 19);
            this.lblCategoriaDetalle.TabIndex = 11;
            this.lblCategoriaDetalle.Text = "Categoria:";
            // 
            // lblMarcaDetalle
            // 
            this.lblMarcaDetalle.AutoSize = true;
            this.lblMarcaDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMarcaDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarcaDetalle.Location = new System.Drawing.Point(931, 342);
            this.lblMarcaDetalle.Name = "lblMarcaDetalle";
            this.lblMarcaDetalle.Size = new System.Drawing.Size(63, 19);
            this.lblMarcaDetalle.TabIndex = 12;
            this.lblMarcaDetalle.Text = "Marca:";
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigoDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(931, 444);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(68, 19);
            this.lblCodigoDetalle.TabIndex = 13;
            this.lblCodigoDetalle.Text = "Codigo:";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.ForeColor = System.Drawing.Color.White;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1347, 96);
            this.panelTitulo.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(462, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administrador de articulos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1347, 759);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.lblCodigoDetalle);
            this.Controls.Add(this.lblMarcaDetalle);
            this.Controls.Add(this.lblCategoriaDetalle);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblDescripDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picBoxImagen);
            this.Controls.Add(this.dgvArticulos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de articulos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox picBoxImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblDescripDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.Label lblMarcaDetalle;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}


namespace terscapasSi.UI
{
    partial class ProductoForm
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
            lblId = new Label();
            nubId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCodigoDeBarras = new Label();
            txtCodigoDeBarras = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblStock = new Label();
            nubStock = new NumericUpDown();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            bntIrUsuarios = new Button();
            bntIrCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)nubId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nubStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(102, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // nubId
            // 
            nubId.Location = new Point(151, 16);
            nubId.Name = "nubId";
            nubId.Size = new Size(125, 27);
            nubId.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblCodigoDeBarras
            // 
            lblCodigoDeBarras.AutoSize = true;
            lblCodigoDeBarras.Location = new Point(2, 115);
            lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            lblCodigoDeBarras.Size = new Size(124, 20);
            lblCodigoDeBarras.TabIndex = 4;
            lblCodigoDeBarras.Text = "Codigo de barras";
            // 
            // txtCodigoDeBarras
            // 
            txtCodigoDeBarras.Location = new Point(151, 108);
            txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            txtCodigoDeBarras.Size = new Size(277, 27);
            txtCodigoDeBarras.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(39, 156);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(151, 153);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(277, 111);
            txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(76, 286);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(151, 279);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(277, 27);
            txtPrecio.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(52, 336);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label1_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(151, 328);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(76, 386);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // nubStock
            // 
            nubStock.Location = new Point(151, 379);
            nubStock.Name = "nubStock";
            nubStock.Size = new Size(150, 27);
            nubStock.TabIndex = 13;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.Highlight;
            btnCrear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCrear.ForeColor = SystemColors.ControlLight;
            btnCrear.Location = new Point(536, 137);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(177, 56);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLight;
            btnActualizar.Location = new Point(536, 199);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(177, 56);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(536, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 56);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ControlLight;
            btnBuscar.Location = new Point(536, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 59);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 426);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(701, 309);
            dgvProductos.TabIndex = 18;
            // 
            // bntIrUsuarios
            // 
            bntIrUsuarios.BackColor = SystemColors.HotTrack;
            bntIrUsuarios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrUsuarios.ForeColor = SystemColors.ControlLightLight;
            bntIrUsuarios.Location = new Point(578, 75);
            bntIrUsuarios.Name = "bntIrUsuarios";
            bntIrUsuarios.Size = new Size(135, 47);
            bntIrUsuarios.TabIndex = 28;
            bntIrUsuarios.Text = "Ir a Usuarios";
            bntIrUsuarios.UseVisualStyleBackColor = false;
            bntIrUsuarios.Click += bntIrUsuarios_Click;
            // 
            // bntIrCategoria
            // 
            bntIrCategoria.BackColor = SystemColors.HotTrack;
            bntIrCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrCategoria.ForeColor = SystemColors.ControlLightLight;
            bntIrCategoria.Location = new Point(578, 16);
            bntIrCategoria.Name = "bntIrCategoria";
            bntIrCategoria.Size = new Size(135, 47);
            bntIrCategoria.TabIndex = 27;
            bntIrCategoria.Text = "Ir a Categoria";
            bntIrCategoria.UseVisualStyleBackColor = false;
            bntIrCategoria.Click += bntIrProductos_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 747);
            Controls.Add(bntIrUsuarios);
            Controls.Add(bntIrCategoria);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(nubStock);
            Controls.Add(lblStock);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtCodigoDeBarras);
            Controls.Add(lblCodigoDeBarras);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(nubId);
            Controls.Add(lblId);
            Name = "ProductoForm";
            Text = "ProductoForm";
            ((System.ComponentModel.ISupportInitialize)nubId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nubStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private NumericUpDown nubId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCodigoDeBarras;
        private TextBox txtCodigoDeBarras;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblStock;
        private NumericUpDown nubStock;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private Button bntIrUsuarios;
        private Button bntIrCategoria;
    }
}
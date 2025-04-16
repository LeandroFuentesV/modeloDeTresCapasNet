namespace terscapasSi.UI
{
    partial class CategoriaForm
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
            nudId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            chkActiva = new CheckBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCrear = new Button();
            lblId = new Label();
            dgvCategorias = new DataGridView();
            btnRefrescar = new Button();
            bntIrProductos = new Button();
            bntIrUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // nudId
            // 
            nudId.Location = new Point(111, 44);
            nudId.Name = "nudId";
            nudId.Size = new Size(150, 27);
            nudId.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 2;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(411, 91);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(72, 24);
            chkActiva.TabIndex = 4;
            chkActiva.Text = "Activa";
            chkActiva.UseVisualStyleBackColor = true;
            chkActiva.CheckedChanged += chkActiva_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ControlLight;
            btnBuscar.Location = new Point(514, 425);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(206, 43);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(514, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(206, 49);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLight;
            btnActualizar.Location = new Point(514, 315);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(206, 49);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.Highlight;
            btnCrear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCrear.ForeColor = SystemColors.ControlLight;
            btnCrear.Location = new Point(514, 260);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(206, 49);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(74, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 22;
            lblId.Text = "ID";
            lblId.Click += label2_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(35, 155);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(448, 362);
            dgvCategorias.TabIndex = 23;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = SystemColors.Highlight;
            btnRefrescar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnRefrescar.ForeColor = SystemColors.ControlLight;
            btnRefrescar.Location = new Point(514, 474);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(206, 43);
            btnRefrescar.TabIndex = 24;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // bntIrProductos
            // 
            bntIrProductos.BackColor = SystemColors.HotTrack;
            bntIrProductos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrProductos.ForeColor = SystemColors.ControlLightLight;
            bntIrProductos.Location = new Point(585, 24);
            bntIrProductos.Name = "bntIrProductos";
            bntIrProductos.Size = new Size(135, 47);
            bntIrProductos.TabIndex = 25;
            bntIrProductos.Text = "Ir a Productos";
            bntIrProductos.UseVisualStyleBackColor = false;
            bntIrProductos.Click += bntIrProductos_Click;
            // 
            // bntIrUsuarios
            // 
            bntIrUsuarios.BackColor = SystemColors.HotTrack;
            bntIrUsuarios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrUsuarios.ForeColor = SystemColors.ControlLightLight;
            bntIrUsuarios.Location = new Point(585, 83);
            bntIrUsuarios.Name = "bntIrUsuarios";
            bntIrUsuarios.Size = new Size(135, 47);
            bntIrUsuarios.TabIndex = 26;
            bntIrUsuarios.Text = "Ir a Usuarios";
            bntIrUsuarios.UseVisualStyleBackColor = false;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(732, 553);
            Controls.Add(bntIrUsuarios);
            Controls.Add(bntIrProductos);
            Controls.Add(btnRefrescar);
            Controls.Add(dgvCategorias);
            Controls.Add(lblId);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(chkActiva);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(nudId);
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private CheckBox chkActiva;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCrear;
        private Label lblId;
        private DataGridView dgvCategorias;
        private Button btnRefrescar;
        private Button bntIrProductos;
        private Button bntIrUsuarios;
    }
}
namespace terscapasSi.UI
{
    partial class UserForm
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
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            chkActivo = new CheckBox();
            lblId = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            bntIrUsuarios = new Button();
            bntIrCategoria = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCrear = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // nudId
            // 
            nudId.Location = new Point(192, 19);
            nudId.Name = "nudId";
            nudId.Size = new Size(150, 27);
            nudId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(192, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(192, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 27);
            txtPassword.TabIndex = 3;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(193, 218);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(79, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Numero ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(79, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(79, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(79, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // bntIrUsuarios
            // 
            bntIrUsuarios.BackColor = SystemColors.HotTrack;
            bntIrUsuarios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrUsuarios.ForeColor = SystemColors.ControlLightLight;
            bntIrUsuarios.Location = new Point(609, 71);
            bntIrUsuarios.Name = "bntIrUsuarios";
            bntIrUsuarios.Size = new Size(135, 47);
            bntIrUsuarios.TabIndex = 34;
            bntIrUsuarios.Text = "Ir a Producto";
            bntIrUsuarios.UseVisualStyleBackColor = false;
            bntIrUsuarios.Click += bntIrUsuarios_Click;
            // 
            // bntIrCategoria
            // 
            bntIrCategoria.BackColor = SystemColors.HotTrack;
            bntIrCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            bntIrCategoria.ForeColor = SystemColors.ControlLightLight;
            bntIrCategoria.Location = new Point(609, 12);
            bntIrCategoria.Name = "bntIrCategoria";
            bntIrCategoria.Size = new Size(135, 47);
            bntIrCategoria.TabIndex = 33;
            bntIrCategoria.Text = "Ir a Categoria";
            bntIrCategoria.UseVisualStyleBackColor = false;
            bntIrCategoria.Click += bntIrCategoria_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ControlLight;
            btnBuscar.Location = new Point(567, 326);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 59);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(567, 257);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 56);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLight;
            btnActualizar.Location = new Point(567, 195);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(177, 56);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.Highlight;
            btnCrear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCrear.ForeColor = SystemColors.ControlLight;
            btnCrear.Location = new Point(567, 133);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(177, 56);
            btnCrear.TabIndex = 29;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(21, 257);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(524, 384);
            dgvUsuarios.TabIndex = 35;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 653);
            Controls.Add(dgvUsuarios);
            Controls.Add(bntIrUsuarios);
            Controls.Add(bntIrCategoria);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(chkActivo);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(nudId);
            Name = "UserForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudId;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox chkActivo;
        private Label lblId;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblPassword;
        private Button bntIrUsuarios;
        private Button bntIrCategoria;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCrear;
        private DataGridView dgvUsuarios;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic.Logging;
using terscapasSi.Controllers;
using terscapasSi.Model.Entities;

namespace terscapasSi.UI
{
    public partial class UserForm : Form
    {

        //acoplarse al controler de producto
        //instancia privada de solo lectura
        private readonly UserControllers _controller;

        public UserForm()
        {
            InitializeComponent();
            //inicializamos el controlador que maneja la logica 
            _controller = new UserControllers();



            this.StartPosition = FormStartPosition.CenterScreen;
            RefrescarTabla();
        }

        private void bntIrCategoria_Click(object sender, EventArgs e)
        {
            CategoriaForm categoriaFrm = new CategoriaForm();

            categoriaFrm.Show();
        }

        private void bntIrUsuarios_Click(object sender, EventArgs e)
        {
            ProductoForm productoFrm = new ProductoForm();

            productoFrm.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //instancia del ob producto -- sellenara y se enviara para ser guardado
            var nuevoUsuario = new User();

            // valores ingresados en los campos -
            //asigmanos los datos del formulario a las propiedades del objeto
            nuevoUsuario.Name = txtNombre.Text;
            nuevoUsuario.Email = txtEmail.Text;
            nuevoUsuario.Password = txtPassword.Text;
            nuevoUsuario.Activo = chkActivo.Checked;

            //guadamos con el controlador
            bool resultado = _controller.CrearUsuario(nuevoUsuario);


            //validamos
            if (resultado)
            {
                MessageBox.Show("Usuario creado con exito");
                RefrescarTabla();
            }
            else
            {
                MessageBox.Show("error al crear usuario");

            }




        }

        //actualiza la grilla con la bbdd
        private void RefrescarTabla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _controller.ObtenerTodos();
            dgvUsuarios.Update();
            dgvUsuarios.Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var usuarioActualizado = new User();

            //num desde id
            usuarioActualizado.Id = (int)nudId.Value;

            usuarioActualizado.Name = txtNombre.Text;
            usuarioActualizado.Email = txtEmail.Text;
            usuarioActualizado.Activo = chkActivo.Checked;
            usuarioActualizado.Password = txtPassword.Text;

            //llamamos al contyrolador
            bool resultado = _controller.ActualizarUsuario(usuarioActualizado.Id, usuarioActualizado);

            if (resultado)
            {
                MessageBox.Show("usuario actualizado correctamente");
                RefrescarTabla();
            }
            else
            {
                MessageBox.Show("error a actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //mensaje de confirmacion
            var eliminar = MessageBox.Show(
                "realmente quieres eliminar este registro?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //respuesta del mesaje por el usuario
            if (eliminar == DialogResult.Yes)
            {
                //obtenemos el id
                int usuarioId = (int)nudId.Value;

                //******************************************************************

                //invocando al controler de categorias almacenaremos en la base de datos el objeto

                bool result = _controller.EliminarUsuario(usuarioId);


                if (result)
                {


                    MessageBox.Show("usuario Eliminado correctamente");
                    RefrescarTabla();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error eliminar usuario");
                }
                //******************************************************************
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idBuscado = (int)nudId.Value;
            var usuario = _controller.ObtenerPorID(idBuscado);

            if (usuario != null)
            {
                txtNombre.Text = usuario.Name;
                txtEmail.Text = usuario.Email;
                txtPassword.Text = usuario.Password;
                chkActivo.Checked = usuario.Activo;
                MessageBox.Show("Usuario encontrado");
            }
            else
            {
                MessageBox.Show("usuario no encontrado");

                //limpiar
                txtNombre.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                chkActivo.Checked = false;
            }
        }
    }
}

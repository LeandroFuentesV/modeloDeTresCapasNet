using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using terscapasSi.Controllers;
using terscapasSi.Model.Entities;

namespace terscapasSi.UI
{
    public partial class ProductoForm : Form
    {

        //acoplarse al controler de categoria
        //instancia privada de solo lectura
        private readonly CategoriaControllers _categoriaController;


        //acoplarse al controler de producto
        //instancia privada de solo lectura
        private readonly ProductoControllers _controller;


        public ProductoForm()
        {
            InitializeComponent();

            //inicializamos el controlador que maneja la logica 
            _controller = new ProductoControllers();
            _categoriaController = new CategoriaControllers();

            this.StartPosition = FormStartPosition.CenterScreen;

            //carga de categorias al cmb
            CargarCategorias();
            Refrescartabla();
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //instancia del ob producto -- sellenara y se enviara para ser guardado
            var nuevoProducto = new Producto();

            //valores ingresados en los campos -
            //asigmanos los datos del formulario a las propiedades del objeto
            nuevoProducto.Name = txtNombre.Text;
            nuevoProducto.CodigoBarras = txtCodigoDeBarras.Text;
            nuevoProducto.Descripcion = txtDescripcion.Text;

            //*******************************

            //convertir precio que esta como campo de texto a double 
            if (double.TryParse(txtPrecio.Text, out double precio))
                nuevoProducto.Precio = precio;
            else
            {
                MessageBox.Show("el pecio no es valido");
                return;
            }
            //*******************************

            //asignamos la cat desde el cmb
            
            nuevoProducto.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);


            //stock desde nubId y lo convierte en int
            nuevoProducto.Stock = (int)nubStock.Value;


            //guardar loq ue se acaba de crear , llamamos al contrrolador
            bool resultado = _controller.CrearProducto(nuevoProducto);

            //revificacion si se guardo correctamente
            if (resultado)
            {
                MessageBox.Show("Se guardo correctamente");
                Refrescartabla();
            }
            else
            {
                MessageBox.Show("Error al guadar");
            }




        }

        //actualiza la grilla
        public void Refrescartabla()
        {
            dgvProductos.DataSource = null; // limpiamos anterior
            dgvProductos.DataSource = _controller.ObtenerTodos(); //nueva fuente
            dgvProductos.Update(); //actualizamos
            dgvProductos.Refresh(); // refrescamos
        }

        private void CargarCategorias()
        {
            //obtener los nombres desde la base de datos
            var categorias = _categoriaController.ObtenerNombresCategorias();

            //enviar al cmbcategorias
            cmbCategoria.DataSource = categorias;

        }

        private void bntIrProductos_Click(object sender, EventArgs e)
        {
            CategoriaForm categoriaFrm = new CategoriaForm();

            categoriaFrm.Show();

        }

        private void bntIrUsuarios_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();

            userForm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //objeto actualizado
            var productoActualizado = new Producto();

            //asigamos el Id 
            productoActualizado.Id = (int)nubId.Value;

            //cargamos los datos desde los controladores
            productoActualizado.Name = txtNombre.Text;
            productoActualizado.CodigoBarras = txtCodigoDeBarras.Text;
            productoActualizado.Descripcion = txtDescripcion.Text;


            //convertir precio que esta como campo de texto a double 
            if (double.TryParse(txtPrecio.Text, out double precio))
                productoActualizado.Precio = precio;
            else
            {
                MessageBox.Show("el pecio no es valido");
                return;
            }
            //*******************************

            //asignamos la cat desde el cmb
            productoActualizado.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);


            //stock desde nubId y lo convierte en int
            productoActualizado.Stock = (int)nubStock.Value;


            //guardar loq ue se acaba de crear , llamamos al contrrolador
            bool resultado = _controller.ActualizarProducto(productoActualizado.Id, productoActualizado);

            //revificacion si se actualizo correctamente
            if (resultado)
            {
                MessageBox.Show("Se actualizo correctamente");
                Refrescartabla();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
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
                int productoId = (int)nubId.Value;

                //******************************************************************

                //invocando al controler de categorias almacenaremos en la base de datos el objeto

                bool result = _controller.EliminarProducto(productoId);


                if (result)
                {


                    MessageBox.Show("Registro Eliminado correctamente");
                    Refrescartabla();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al tratar de Eliminar");
                }
                //******************************************************************
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //obtener id
            int productoId = (int)nubId.Value;

            //buscar el producto usando el controlador
            var producto = _controller.ObtenerPorId(productoId);

            //verifica,mmos si el producto fue encontraado
            if (producto != null)
            {
                txtNombre.Text = producto.Name;
                txtCodigoDeBarras.Text = producto.CodigoBarras;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                //cmbCategoria.Text = producto.Categoria;
                nubStock.Value = producto.Stock;

                MessageBox.Show("producto encontrado");


            }else
            {
                MessageBox.Show("producto no encontrado");

                //limpiar 
                txtNombre.Clear();
                txtCodigoDeBarras.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                cmbCategoria.SelectedIndex = -1;
                nubStock.Value = 0;

            }

        }
    }
}

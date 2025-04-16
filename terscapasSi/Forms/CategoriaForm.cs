using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using terscapasSi.Controllers;
using terscapasSi.Model.Entities;

namespace terscapasSi.UI
{
    public partial class CategoriaForm : Form
    {


        //acoplarse al controler
        //instancia privada de solo lectura
        private readonly CategoriaControllers _controller;


        private void RefrescarTabla()
        {

            //actualizar grilla - indicamos cual es el origen de los datos a mostrar
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = _controller.ObtenerTodas();
            dgvCategorias.Update();
            dgvCategorias.Refresh();

        }

        public CategoriaForm()
        {
            //crear una instancia de deo controlles
            //se encarga de validar los datos antes de enviarlos
            _controller = new CategoriaControllers(); //prepara la logica
            InitializeComponent();//pinta la interfaz

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //creamos una instacia del objeto cat
            var newCat = new Categoria();

            newCat.Name = txtNombre.Text;
            newCat.Activa = chkActiva.Checked;
            //******************************************************************

            //invocando al controler de categorias almacenaremos en la base de datos el objeto

            bool result = _controller.CrearCategoria(newCat);
            if (result == true)
            {

                RefrescarTabla();
                MessageBox.Show("Registro guardado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al tratar de guardar");
            }
            //******************************************************************
        }

        private void chkActiva_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //creamos una instacia del objeto cat
            var newCat = new Categoria();
            newCat.Id = Convert.ToInt32(nudId.Value);
            newCat.Name = txtNombre.Text;
            newCat.Activa = chkActiva.Checked;
            //******************************************************************

            //invocando al controler de categorias almacenaremos en la base de datos el objeto

            bool result = _controller.ActualizarCategoria(newCat.Id, newCat);
            if (result == true)
            {

                RefrescarTabla();
                MessageBox.Show("Registro Actaulizado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al tratar de actualizar");
            }
            //******************************************************************
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //mensaje de confirmacion
            var eliminar = MessageBox.Show(
                "realmente quieres eliminar este registro?",
                "Categorias",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //respuesta del mesaje por el usuario
            if (eliminar == DialogResult.Yes)
            {
                //creamos una instacia del objeto cat
                var catId = Convert.ToInt32(nudId.Value);

                //******************************************************************

                //invocando al controler de categorias almacenaremos en la base de datos el objeto

                bool result = _controller.EliminarCategoria(catId);
                if (result == true)
                {

                    RefrescarTabla();
                    MessageBox.Show("Registro Eliminado correctamente");
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
            int id = Convert.ToInt32(nudId.Value);

            //llamar controlador para buscar categoria, le pasamos el id
            var categoria = _controller.ObtenerPorID(id);//busca por id
            string nombre = txtNombre.Text.Trim();//busca por nombre

            if (id > 0)
            {
                //verificar si se encontro el id o no
                if (categoria != null)
                {
                    //si existe mostramos los datos en los controllers
                    txtNombre.Text = categoria.Name;
                    chkActiva.Checked = categoria.Activa;

                    //mostrar resultado
                    txtNombre.Text = categoria.Name;
                    chkActiva.Checked = categoria.Activa;
                    dgvCategorias.DataSource = new List<Categoria> { categoria }; //mostrar cat encontrada

                }
                else
                {
                    //si no se encuentra
                    MessageBox.Show("Categoria no encontrada", "Buscar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!string.IsNullOrWhiteSpace(nombre))
            {
                //busca por nombre y coincidencias
                var resultados = _controller.ObtenerTodas()
                    .Where(c => c.Name.ToLower().Contains(nombre.ToLower()))
                    .ToList();

                if (resultados.Any())
                {
                    dgvCategorias.DataSource = resultados;
                }
                else
                {
                    MessageBox.Show("No se encontraron categorias con ese nombre",
                        "Buscar por nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un ID o un nombre",
                    "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            nudId.Value = 0;
            txtNombre.Clear();
            chkActiva.Checked = false;
            RefrescarTabla();
        }

        private void bntIrProductos_Click(object sender, EventArgs e)
        {
            ProductoForm productoFrm = new ProductoForm();

            productoFrm.Show();
        }
    }
}

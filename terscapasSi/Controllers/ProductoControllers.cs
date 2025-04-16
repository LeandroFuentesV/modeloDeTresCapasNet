using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;
using terscapasSi.Model.Services;

namespace terscapasSi.Controllers
{
    public class ProductoControllers
    {
        //isntancia del serv que accede a la capa de datos
        private ProductoService _productoService;

        //constructor inicializa la instancia del serv
        public ProductoControllers()
        {
            _productoService = new ProductoService();
        }
        //***********************
        //crear nuevo producto
        public bool CrearProducto(Producto nuevoProducto) 
        {
            //valicadion nombre y descripcion mno deben estar vacios
            if(string.IsNullOrWhiteSpace(nuevoProducto.Name) || string.IsNullOrWhiteSpace(nuevoProducto.Descripcion))
                return false;

            return _productoService.CrearProducto(nuevoProducto);

        }

        //***********************
        //obtener todo los productos
        public List<Producto> ObtenerTodos()
        {
            return _productoService.ObtenerTodos();
        }

        //***********************
        //bsucar productos por id
        public Producto ObtenerPorId(int id)
        {
            return _productoService.ObtenerPorId(id);
        }
        //***********************
        //actualizar producto
        public bool ActualizarProducto(int id, Producto productoActualizado)
        {
            return _productoService.ActualizarProducto(id, productoActualizado);
        }
        //***********************
        //eliminar prodcuto por id
        public bool EliminarProducto(int id)
        {
            return _productoService.EliminarProducto(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;
using System.Reflection.Metadata.Ecma335;
using terscapasSi.Model.Services;

namespace terscapasSi.Controllers
{
    public class CategoriaControllers
    {
        //instancia del servico para accder a las op con la tabla de cat
        private CategoriaService _categoriaService;

        //constructor, se inicia el sercio
        public CategoriaControllers()
        {
            _categoriaService = new CategoriaService();
        }

        //*****************************
        //crear nueva categoria
        public bool CrearCategoria(Categoria nuevaCategoria)
        {
            //validacion , nombre no debe estar vacio
            if (string.IsNullOrWhiteSpace(nuevaCategoria.Name))
                return false;

            return _categoriaService.CrearCategoria(nuevaCategoria);


        }
        //*****************************
        //obtener todas las categorias
        public List<Categoria> ObtenerTodas()
        {
            return _categoriaService.ObtenerTodas();
        }
        //*****************************
        //buscar categoria por id
        public Categoria ObtenerPorID(int id)
        {
            return _categoriaService.ObtenerPorID(id);
        }

        //*****************************
        //actualizar categoria
        public bool ActualizarCategoria(int id, Categoria actualizada)
        {
            return _categoriaService.ActualizarCategoria(id, actualizada);
        }

        //*****************************
        //eliminar categoria
        public bool EliminarCategoria(int id)
        {
            return _categoriaService.EliminarCategoria(id);
        }

        public List<string> ObtenerNombresCategorias()
        {
            return _categoriaService.ObtenerCategorias();

        }

    }
}

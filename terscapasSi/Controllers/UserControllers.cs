using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;
using terscapasSi.Model.Services;

namespace terscapasSi.Controllers
{
    public class UserControllers
    {

        //propiedad privada que re´+presenta el servicio de usuario
        private UserService _userService;

        //cosntr, al isntancias UserController tambien instanciamos el servicio
        public UserControllers()
        {
            _userService = new UserService();
        }

        //***************************
        //metodo para crear un usuario con validadcion
        public bool CrearUsuario(User nuevoUsuario)
        {
            //validacion de negocio , contraseña con almenos 8 caracteres
            if (nuevoUsuario.Password.Length < 8)
            {
                return false; //no pasa la validacion
            }

            //si pasa la validacion llamamos al sercio para guadar
            return _userService.CrearUsuario(nuevoUsuario);
        }

        //***************************
        //metodo para obtener todo los usuarios
        public List<User> ObtenerTodos()
        {
            return _userService.ObtenerTodos();

        }

        //***************************
        //obtener un usuario por su id
        public User ObtenerPorID(int id)
        {
            return _userService.ObtenerPorID(id);

        }
        //***************************
        //actualizar un usuario po id 
        public bool ActualizarUsuario(int id, User actualizado)
        {
            return _userService.ActualizarUsuario(id, actualizado);

        }

        //***************************
        //Eliminar un usuario por id
        public bool EliminarUsuario(int id)
        {
            return _userService.EliminarUsuario(id);
        }





    }
}

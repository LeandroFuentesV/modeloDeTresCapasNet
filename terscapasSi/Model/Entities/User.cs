using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terscapasSi.Model.Entities
{

    //decorador - DataAnnotations
    [Table("Usuarios")]
    public class User



    {
        [Key] //clkave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementado
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres para el nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres para la contraseña")]

        public string Password { get; set; }
        public bool Activo { get; set; }
            
    }
}

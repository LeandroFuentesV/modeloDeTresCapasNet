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
    [Table("Producto")]

    public class Producto
    {

        

        [Key] //clkave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementado
        public int Id { get; set; }

        [Required(ErrorMessage = "el nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "maximo 50 caracteres")]
        public string CodigoBarras { get; set; }

        [MaxLength(500, ErrorMessage = "maximo 500 caracteres")]
        public string Descripcion { get; set; }

        [Range(0,double.MaxValue, ErrorMessage = "debe ser un numero positivo" )]
        public double Precio { get; set; }

        [MaxLength(50, ErrorMessage = "Maximo 50 catracteres")]
        public string Categoria { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un valor positivo")]
        public int Stock { get; set; }

    }
}

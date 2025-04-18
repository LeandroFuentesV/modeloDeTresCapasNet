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
    [Table("Categoria")]



    public class Categoria
    {
        //documentacion en microosoft learm
        //annnotations[]
        //con el atributo key indicamos que es una clave primaeria
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementado
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public bool Activa {  get; set; }

       public virtual List<Producto> Productos { get; set; }





    }
}

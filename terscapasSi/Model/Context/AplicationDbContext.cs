using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using terscapasSi.Model.Entities;

namespace terscapasSi.Model.Context
{
    //definimos el contexto (estructura) de la base de datos
    
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
       : base(options)
        { 
        }

        //indicar a la app cuales clases (entities) corresponde a tablas 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<User> User { get; set; }
    }
}

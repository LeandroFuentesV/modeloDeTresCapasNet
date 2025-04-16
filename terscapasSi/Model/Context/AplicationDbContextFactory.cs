using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace terscapasSi.Model.Context
{
    //creando la clase AplicationDbContextFactory
    ////que implementa la interfaz IDesignTimeDbContextFactory<TContext>
    public class AplicationDbContextFactory : IDesignTimeDbContextFactory<AplicationDbContext>
    {
        public AplicationDbContext CreateDbContext(string[] args)
        {
            //Se crea un constructor de opciones de configuracion del DbContext,
            ////que va a incluir los datos de la conexion a la base de datos
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductosNUEVO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //Esta línea configura la conexión a SQL Server. Aquí defines
            //la cadena de conexión completa para conectar tu app con
            //la base de datos AppEjemplo en tu servidor local ((localdb)\\MSSQLLocalDB)

            // retorna una instancia de la clase AplicationDbContext,
            // pasandole las opciones configuradas (cadena de conexion incluida)
            return new AplicationDbContext(optionsBuilder.Options);
        }
    }

}

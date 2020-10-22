using Microsoft.EntityFrameworkCore;
namespace Kevinapi.Models{
    class Conexion : DbContext{
       public Conexion (DbContextOptions<Conexion> options) : base(options){}
       public DbSet<Empleados> Empleados {get; set;}

    }
     class Conectar{
         private const string cadenaConexion="server=localhost;port=3306;database=dbempresa;userid=user_dbempresa;pwd=Nomerecuerdo12@";
          public static Conexion Create(){
              var constructor = new DbContextOptionsBuilder<Conexion>();
              constructor.UseMySQL(cadenaConexion);
              var Conexion = new Conexion (constructor.Options);
              return Conexion;
          }              

}
    }

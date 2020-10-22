using System.ComponentModel.DataAnnotations;

namespace Kevinapi.Models{
       public class Empleados{

           [Key]
           public int id_empleado {get; set;}
           public string nombres {get; set;}
           public string apellidos {get; set;}
           public string direccion {get; set;}
           public string telefono {get; set;}
           public string DPI {get; set;}
           public int genero {get; set;}
           public string  fecha_nacimiento  {get; set;}
           public  int id_puesto {get; set;}
           public string fecha_inicion_labores {get; set;}
           public string fecha_ingreso {get; set;}


       }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23cv.Entities
{
    public class Empleado
    {
        [Key]// aqui representamos que estamos utilizando la llave primaria.

        public int PkEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }
    }
}

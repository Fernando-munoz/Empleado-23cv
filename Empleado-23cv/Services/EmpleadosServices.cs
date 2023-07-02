using Empleado_23cv.Context;
using Empleado_23cv.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23cv.Services
{
    class EmpleadosServices
    {
        public void Add(Empleado request)// recibe el parametro del objeto creado llamando al empleado  y se asigna una variable que se llama request
        {
            try
            {
                  

                using (var _context = new ApplicationDbContext()) // usa la cadena de conexxion de 
                {
                    Empleado empleado = new Empleado()
                    {
                        
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        FechaRegistro = DateTime.Now,

                        Correo = request.Correo,
                };
                    _context.Empleados.Add(empleado); //cerrrar y delimitar las bases
                    _context.SaveChanges();

                }
               
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un errror" +ex.Message);// declaramos una variable
            }
        }
         
        public Empleado Read(int id)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Empleado empleado = _context.Empleados.Find(id);
                    return empleado;
                }
            }
            catch (Exception ex)
            
            {

                throw new Exception("sucedio un error" + ex.Message);
            }
        }
         
    }
}

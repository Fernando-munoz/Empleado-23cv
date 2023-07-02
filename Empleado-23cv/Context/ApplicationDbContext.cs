using Empleado_23cv.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23cv.Context
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(" Server = localhost; database = 23cv; user= root; password=; ");
        }

        public DbSet<Empleado> Empleados { get; set; }
    }



}


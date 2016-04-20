using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PortalDelTrabajador2.Models
{
    public class Trabajador
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string area { get; set; }
    }
    public class TrabajadorDBContext : DbContext
    {
       public DbSet<Trabajador> Trabajadores { get; set; }
    }

}
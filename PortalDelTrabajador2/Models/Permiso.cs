using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PortalDelTrabajador2.Models
{
    public class Permiso
    {
        public int id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha:")]
        public DateTime fecha { get; set; }

        //[DataType(DataType.DateTime)]
        [Display(Name = "Desde:")]
        public DateTime desde { get; set; }

        //[DataType(DataType.DateTime)]
        [Display(Name = "Hasta:")]
        public DateTime hasta { get; set; }

        [Required(ErrorMessage = "Debe llenar este campo")]
        [Display(Name="Trabajo a realizar:")]
        public string trabajo { get; set; }

        public bool firmadeljefe { get; set; }

        public bool firmadelgerente { get; set; }

        [Display(Name = "Tipo de Autorización:")]
        public int tipodeautorizacion { get; set; }

        public int idtrabajador { get; set; }

    }
    public class PermisoDBContext : DbContext
    {
        public DbSet<Permiso> Permisos { get; set; }
    }
}
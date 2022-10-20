namespace SISTEMAGCS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Miembro_Elemento
    {
        [Key]
        public int Id_miembroelemento { get; set; }

        public int Id_miembro { get; set; }

        public int Id_elementoconfiguracion { get; set; }

        [StringLength(50)]
        public string Url { get; set; }

        [StringLength(50)]
        public string FechaInicio { get; set; }

        [StringLength(50)]
        public string Fechafin { get; set; }

        public virtual Elemento_Configuracion Elemento_Configuracion { get; set; }

        public virtual Miembro_Proyecto Miembro_Proyecto { get; set; }
    }
}

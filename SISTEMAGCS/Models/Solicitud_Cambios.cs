namespace SISTEMAGCS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Solicitud_Cambios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitud_Cambios()
        {
            Proyecto = new HashSet<Proyecto>();
        }

        [Key]
        public int Id_solicitud_cambios { get; set; }

        [StringLength(50)]
        public string Fecha { get; set; }

        [StringLength(50)]
        public string Objetivo { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Respuesta { get; set; }

        public int Id_solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyecto { get; set; }

        public virtual Solicitud Solicitud { get; set; }
    }
}

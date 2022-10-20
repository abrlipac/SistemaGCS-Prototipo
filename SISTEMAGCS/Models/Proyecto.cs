namespace SISTEMAGCS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proyecto")]
    public partial class Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proyecto()
        {
            Miembro_Proyecto = new HashSet<Miembro_Proyecto>();
        }

        [Key]
        public int Id_proyecto { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string FechaInicio { get; set; }

        [StringLength(50)]
        public string FechaTermino { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public int Id_metodologia { get; set; }

        public int Id_solicitud_cambios { get; set; }

        public virtual Metodologia Metodologia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miembro_Proyecto> Miembro_Proyecto { get; set; }

        public virtual Solicitud_Cambios Solicitud_Cambios { get; set; }
    }
}

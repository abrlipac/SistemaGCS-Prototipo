namespace SISTEMAGCS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Miembro_Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Miembro_Proyecto()
        {
            Miembro_Elemento = new HashSet<Miembro_Elemento>();
        }

        [Key]
        public int Id_miembro { get; set; }

        public int Id_usuario { get; set; }

        public int Id_rol { get; set; }

        public int Id_proyecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miembro_Elemento> Miembro_Elemento { get; set; }

        public virtual Proyecto Proyecto { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

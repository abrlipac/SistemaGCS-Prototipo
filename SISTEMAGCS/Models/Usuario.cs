namespace SISTEMAGCS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Miembro_Proyecto = new HashSet<Miembro_Proyecto>();
        }

        [Key]
        public int Id_usuario { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public int Id_tipousuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Miembro_Proyecto> Miembro_Proyecto { get; set; }

        public virtual Tipo_Usuario Tipo_Usuario { get; set; }

        ModeloGCS bd = new ModeloGCS();

        public List<Usuario> Listar()
        {
            var usuarios=new List<Usuario>();
            try
            {
                using (var db = new ModeloGCS())
                {
                    usuarios = db.Usuario.Include("Tipo_Usuario").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return usuarios;

        }

    }
}

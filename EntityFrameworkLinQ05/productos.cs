namespace EntityFrameworkLinQ05
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productos()
        {
            movimientos = new HashSet<movimientos>();
        }

        [Key]
        public int idproducto { get; set; }

        [Required]
        [StringLength(200)]
        public string titulo { get; set; }

        public int? stock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal precioCompra { get; set; }

        [Column(TypeName = "numeric")]
        public decimal precioVenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimientos> movimientos { get; set; }
    }
}

namespace EntityFrameworkLinQ05
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movimientos
    {
        [Key]
        public int idmovimiento { get; set; }

        public int idproducto { get; set; }

        public int cantidad { get; set; }

        public virtual productos productos { get; set; }
    }
}

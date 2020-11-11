namespace PizzaApplication.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pizza")]
    public partial class Pizza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pizza()
        {
            PizzaSizes = new HashSet<PizzaSize>();
        }

        public int PizzaId { get; set; }

        [Required]
        [StringLength(50)]
        public string PizzaName { get; set; }

        [Required]
        [StringLength(200)]
        public string PizzaDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaSize> PizzaSizes { get; set; }
    }
}

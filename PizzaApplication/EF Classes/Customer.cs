namespace PizzaApplication.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerPhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

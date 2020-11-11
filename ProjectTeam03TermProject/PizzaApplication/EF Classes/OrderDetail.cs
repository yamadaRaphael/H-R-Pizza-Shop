namespace PizzaApplication.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailOrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailPizzaId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DetailPizzaSize { get; set; }

        public int PizzaQty { get; set; }

        public float DetailPizzaPrice { get; set; }

        public virtual PizzaSize PizzaSize { get; set; }
    }
}

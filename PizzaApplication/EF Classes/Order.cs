namespace PizzaApplication.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public float TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

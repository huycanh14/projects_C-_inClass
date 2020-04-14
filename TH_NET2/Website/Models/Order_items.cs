namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_items
    {
        public int id { get; set; }

        public int order_id { get; set; }

        public int product_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string code { get; set; }

        public int qty { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        [Column(TypeName = "money")]
        public decimal total { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [StringLength(50)]
        public string color { get; set; }

        [Column(TypeName = "text")]
        public string note { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }
    }
}

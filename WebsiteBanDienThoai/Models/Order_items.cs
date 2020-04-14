namespace WebsiteBanDienThoai.Models
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

        [Required]
        [StringLength(100)]
        public string code { get; set; }

        public int qty { get; set; }

        public double price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double total { get; set; }

        [StringLength(100)]
        public string size { get; set; }

        [StringLength(200)]
        public string color { get; set; }

        public string note { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }
    }
}

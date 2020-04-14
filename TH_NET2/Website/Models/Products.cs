namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Order_items = new HashSet<Order_items>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int product_category_id { get; set; }

        public int brand_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public int? qty { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [StringLength(50)]
        public string color { get; set; }

        [Column(TypeName = "text")]
        public string img { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public int? status { get; set; }

        public virtual Brands Brands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_items> Order_items { get; set; }

        public virtual Product_categories Product_categories { get; set; }
    }
}

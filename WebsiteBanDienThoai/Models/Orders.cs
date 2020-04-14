namespace WebsiteBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            Order_items = new HashSet<Order_items>();
        }

        public int id { get; set; }

        public int qty { get; set; }

        public double price { get; set; }

        public int customer_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        [Required]
        [StringLength(200)]
        public string address { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public int status { get; set; }

        public virtual Customers Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_items> Order_items { get; set; }
    }
}

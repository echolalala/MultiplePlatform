namespace MultiplePlatform.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_BaseGoods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_BaseGoods()
        {
            T_Orders = new HashSet<T_Orders>();
        }

        [Key]
        public int G_BaseGoodID { get; set; }

        [Required]
        [StringLength(50)]
        public string G_GoodName { get; set; }

        [StringLength(50)]
        public string G_GoodCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Orders> T_Orders { get; set; }
    }
}

namespace MultiplePlatform.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Orders
    {
        [Key]
        [StringLength(50)]
        public string O_OrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string O_SubOrderID { get; set; }

        public decimal O_OrderValue { get; set; }

        public decimal O_SuccessValue { get; set; }

        public int O_State { get; set; }

        public DateTime O_SubTime { get; set; }

        public DateTime? O_TreatTime { get; set; }

        [StringLength(50)]
        public string O_Source { get; set; }

        public int? O_BuyUserID { get; set; }

        public int? O_SupUserID { get; set; }

        [Required]
        [StringLength(50)]
        public string O_Account { get; set; }

        [Column(TypeName = "ntext")]
        public string O_Log { get; set; }

        public int O_GoodID { get; set; }

        public virtual T_BaseGoods T_BaseGoods { get; set; }
    }
}

namespace MultiplePlatform.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CapitalChanges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_ID { get; set; }

        [StringLength(50)]
        public string C_OrderID { get; set; }

        public int C_ChangeType { get; set; }

        public decimal? C_Value { get; set; }

        public decimal? C_BeforeValue { get; set; }

        public decimal? C_AfterValue { get; set; }

        [StringLength(200)]
        public string C_Mes { get; set; }

        public DateTime C_Time { get; set; }

        public int C_UserID { get; set; }

        public virtual T_Users T_Users { get; set; }
    }
}

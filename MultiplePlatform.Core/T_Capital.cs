namespace MultiplePlatform.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Capital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_UserID { get; set; }

        public decimal C_Amount { get; set; }

        public virtual T_Users T_Users { get; set; }
    }
}

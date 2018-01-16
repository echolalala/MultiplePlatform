namespace MultiplePlatform.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Users()
        {
            T_CapitalChanges = new HashSet<T_CapitalChanges>();
        }

        [Key]
        public int U_UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string U_LoginName { get; set; }

        [Required]
        [StringLength(100)]
        public string U_PassWord { get; set; }

        public int U_IsValidate { get; set; }

        [Required]
        [StringLength(100)]
        public string U_Key { get; set; }

        public DateTime U_RegisterTime { get; set; }

        [StringLength(50)]
        public string U_Email { get; set; }

        [StringLength(20)]
        public string U_PhoneNum { get; set; }

        [StringLength(20)]
        public string U_CardNo { get; set; }

        [StringLength(100)]
        public string U_CardImg { get; set; }

        public DateTime? U_LastLoginTime { get; set; }

        public virtual T_Capital T_Capital { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CapitalChanges> T_CapitalChanges { get; set; }
    }
}

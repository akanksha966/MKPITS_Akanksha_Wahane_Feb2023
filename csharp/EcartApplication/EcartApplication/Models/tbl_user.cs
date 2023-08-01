namespace EcartApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            tbl_Product = new HashSet<tbl_Product>();
        }

        [Key]
        public int userId { get; set; }

        [Required]
        [StringLength(90)]
        public string Username { get; set; }

        [Required]
        [StringLength(200)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(200)]
        public string UserPassword { get; set; }

        [Required]
        public string Userimage { get; set; }

        [Required]
        [StringLength(50)]
        public string UserContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Product> tbl_Product { get; set; }
    }
}

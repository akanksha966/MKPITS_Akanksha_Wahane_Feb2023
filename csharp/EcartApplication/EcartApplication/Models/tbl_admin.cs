namespace EcartApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_admin()
        {
            tbl_Categorry1 = new HashSet<tbl_Categorry1>();
        }

        [Key]
        public int AdminId { get; set; }

        [Required]
        [StringLength(400)]
        public string AdminUsername { get; set; }

        [StringLength(400)]
        public string AdminPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Categorry1> tbl_Categorry1 { get; set; }
    }
}

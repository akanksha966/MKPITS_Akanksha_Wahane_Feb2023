namespace AdmissionRegistraton.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BatchTable")]
    public partial class BatchTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchTable()
        {
            RegistrationTables = new HashSet<RegistrationTable>();
        }

        [Key]
        public int BatchId { get; set; }

        [StringLength(40)]
        public string Batch { get; set; }

        [StringLength(45)]
        public string Year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationTable> RegistrationTables { get; set; }
    }
}

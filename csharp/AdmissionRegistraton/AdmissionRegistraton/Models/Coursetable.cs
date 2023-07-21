namespace AdmissionRegistraton.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coursetable")]
    public partial class Coursetable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coursetable()
        {
            RegistrationTables = new HashSet<RegistrationTable>();
        }

        [Key]
        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        public int? Duration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationTable> RegistrationTables { get; set; }
    }
}

namespace AdmissionRegistraton.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistrationTable")]
    public partial class RegistrationTable
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(70)]
        public string Nic { get; set; }

        public int? CourseId { get; set; }

        public int? batchId { get; set; }

        public int? Phoneno { get; set; }

        public virtual BatchTable BatchTable { get; set; }

        public virtual Coursetable Coursetable { get; set; }
    }
}

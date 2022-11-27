namespace Student_GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGHOC")]
    public partial class PHONGHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGHOC()
        {
            TINHTRANGPHONG = new HashSet<TINHTRANGPHONG>();
            THI = new HashSet<THI>();
        }

        [Key]
        [StringLength(5)]
        public string MAPHONG { get; set; }

        [Required]
        [StringLength(30)]
        public string TENPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINHTRANGPHONG> TINHTRANGPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THI> THI { get; set; }
    }
}

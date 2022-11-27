namespace Student_GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPHOC")]
    public partial class LOPHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPHOC()
        {
            PHANCONG = new HashSet<PHANCONG>();
            TINHTRANGPHONG = new HashSet<TINHTRANGPHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MALOPHOC { get; set; }

        [Required]
        [StringLength(5)]
        public string MAMON { get; set; }

        [Required]
        [StringLength(50)]
        public string SOLUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYKT { get; set; }

        [Required]
        [StringLength(50)]
        public string DAKHOA { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINHTRANGPHONG> TINHTRANGPHONG { get; set; }
    }
}

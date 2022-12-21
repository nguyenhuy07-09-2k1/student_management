namespace Student_GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOC_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOC_VIEN()
        {
            THIs = new HashSet<THI>();
            BIEN_LAI = new HashSet<BIEN_LAI>();
        }

        [Key]
        [StringLength(5)]
        public string MAHOCVIEN { get; set; }

        [Required]
        [StringLength(20)]
        public string HOHOCVIEN { get; set; }

        [Required]
        [StringLength(20)]
        public string TENHOCVIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        public int SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string NGHENGHIEP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THI> THIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIEN_LAI> BIEN_LAI { get; set; }
    }
}

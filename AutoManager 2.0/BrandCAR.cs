namespace AutoManager_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrandCAR")]
    public partial class BrandCAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrandCAR()
        {
            VinCode = new HashSet<VinCode>();
        }

        [Key]
        public int IdBrandCar { get; set; }

        [Required]
        [StringLength(30)]
        public string NameBrandCar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinCode> VinCode { get; set; }
    }
}

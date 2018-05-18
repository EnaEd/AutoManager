namespace AutoManager_2._0.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelAuto")]
    public partial class ModelAuto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelAuto()
        {
            VinCode = new HashSet<VinCode>();
        }

        [Key]
        public int IdModelAuto { get; set; }

        [Required]
        [StringLength(50)]
        public string NameModelAuto { get; set; }

        public int? CountryCreaterId { get; set; }

        public virtual CountryCreater CountryCreater { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinCode> VinCode { get; set; }
    }
}

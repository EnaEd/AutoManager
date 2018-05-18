namespace AutoManager_2._0.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryCreater")]
    public partial class CountryCreater
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CountryCreater()
        {
            ModelAuto = new HashSet<ModelAuto>();
        }

        [Key]
        public int IdCountryCreater { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCountryCreater { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelAuto> ModelAuto { get; set; }
    }
}

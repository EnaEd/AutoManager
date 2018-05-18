namespace AutoManager_2._0.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VinCode")]
    public partial class VinCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VinCode()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        [StringLength(30)]
        public string IdVinCode { get; set; }

        public int BrandCarId { get; set; }

        public int CapacityId { get; set; }

        public int FuelId { get; set; }

        public int ModelAutoId { get; set; }

        public virtual BrandCAR BrandCAR { get; set; }

        public virtual Capacity Capacity { get; set; }

        public virtual Fuel Fuel { get; set; }

        public virtual ModelAuto ModelAuto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}

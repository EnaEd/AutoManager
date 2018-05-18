namespace AutoManager_2._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceIn { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceOut { get; set; }

        [StringLength(30)]
        public string VinCodeId { get; set; }

        public int CountryCreateComponentId { get; set; }

        public virtual CountryCreateComponent CountryCreateComponent { get; set; }

        public virtual VinCode VinCode { get; set; }
    }
}

namespace AutoManager_2._0.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbAutoManager : DbContext
    {
        public DbAutoManager()
            : base("name=DbAutoManager")
        {
        }

        public virtual DbSet<BrandCAR> BrandCAR { get; set; }
        public virtual DbSet<Capacity> Capacity { get; set; }
        public virtual DbSet<CountryCreateComponent> CountryCreateComponent { get; set; }
        public virtual DbSet<CountryCreater> CountryCreater { get; set; }
        public virtual DbSet<Fuel> Fuel { get; set; }
        public virtual DbSet<ModelAuto> ModelAuto { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<VinCode> VinCode { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandCAR>()
                .Property(e => e.NameBrandCar)
                .IsUnicode(false);

            modelBuilder.Entity<BrandCAR>()
                .HasMany(e => e.VinCode)
                .WithRequired(e => e.BrandCAR)
                .HasForeignKey(e => e.BrandCarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Capacity>()
                .HasMany(e => e.VinCode)
                .WithRequired(e => e.Capacity)
                .HasForeignKey(e => e.CapacityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryCreateComponent>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.CountryCreateComponent)
                .HasForeignKey(e => e.CountryCreateComponentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryCreater>()
                .HasMany(e => e.ModelAuto)
                .WithOptional(e => e.CountryCreater)
                .HasForeignKey(e => e.CountryCreaterId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Fuel>()
                .HasMany(e => e.VinCode)
                .WithRequired(e => e.Fuel)
                .HasForeignKey(e => e.FuelId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModelAuto>()
                .Property(e => e.NameModelAuto)
                .IsUnicode(false);

            modelBuilder.Entity<ModelAuto>()
                .HasMany(e => e.VinCode)
                .WithRequired(e => e.ModelAuto)
                .HasForeignKey(e => e.ModelAutoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PriceIn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.PriceOut)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.VinCodeId)
                .IsUnicode(false);

            modelBuilder.Entity<VinCode>()
                .Property(e => e.IdVinCode)
                .IsUnicode(false);

            modelBuilder.Entity<VinCode>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.VinCode)
                .HasForeignKey(e => e.VinCodeId);
        }
    }
}

namespace Data.Context
{
   #region Usings
   using Dto;
   using Configurations;
   using System.Data.Entity;
    #endregion

    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            Database.SetInitializer(new SeedDB());
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}

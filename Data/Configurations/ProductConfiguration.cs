namespace Data.Configurations
{
    #region Usings
    using Dto;
    using System.Data.Entity.ModelConfiguration;
    #endregion

    //Configuration Class

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Price).IsRequired().HasPrecision(8, 2);
            Property(p => p.CategoryID).IsRequired();
        }
    }
}

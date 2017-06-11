namespace Data.Configurations
{
    #region Usings
    using Dto;
    using System.Data.Entity.ModelConfiguration;
    #endregion

    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}

namespace Presentation.Mappings
{
    #region Usings
    using AutoMapper;
    using Dto;
    using ViewModels;
    #endregion
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
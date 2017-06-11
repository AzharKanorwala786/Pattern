namespace Presentation.Mappings
{
    #region Usings
    using AutoMapper;
    using Dto;
    using ViewModels;
    #endregion
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductFormViewModel, Product>()
                 .ForMember(p => p.Name, map => map.MapFrom(vm => vm.ProductTitle))
                 .ForMember(p => p.Description, map => map.MapFrom(vm => vm.ProductDescription))
                 .ForMember(p => p.Price, map => map.MapFrom(vm => vm.ProductPrice))
                 .ForMember(p => p.Image, map => map.MapFrom(vm => vm.File.FileName))
                 .ForMember(p => p.CategoryID, map => map.MapFrom(vm => vm.ProductCategory));
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
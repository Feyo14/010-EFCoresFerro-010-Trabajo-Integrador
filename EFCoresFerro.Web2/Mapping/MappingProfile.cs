using AutoMapper;
using EFCore3.Entidades;
using EFCoreFerro2.Datos;
using EFCoresFerro.Web2.ViewModels.Brand.BrandEditVm;
using EFCoresFerro.Web2.ViewModels.Shoe.ShoeEditVm;

namespace EFCoresFerro.Web2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Shoes, ShoeEditVm>().ReverseMap();

            CreateMap<Brands, BrandEditVm>().ReverseMap();
            
        }
    }
}

using AutoMapper;
using EFCore3.Entidades;
using EFCoreFerro2.Datos;
using EFCoresFerro.Web2.ViewModels.Brand.BrandEditVm;
using EFCoresFerro.Web2.ViewModels.Brand.BrandListVm;
using EFCoresFerro.Web2.ViewModels.Shoe.ShoeEditVm;

namespace EFCoresFerro.Web2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            LoadBrandMapping();
            LoadShoeMapping();

            
        }

        private void LoadShoeMapping()
        {
            CreateMap<Shoes, ShoeEditVm>().ReverseMap();
        }

        private void LoadBrandMapping()
        {
            CreateMap<Brand, BrandListVm>();

            CreateMap<Brand, BrandEditVm>().ReverseMap();
        }
    }
}

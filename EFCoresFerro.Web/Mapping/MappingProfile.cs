using AutoMapper;
using EFCoreFerro2.Datos;
using EFCoresFerro.Web.ViewModels.Categories;

namespace Garden2024.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Marca, MarcaEditVm>().ReverseMap();
            
        }
    }
}

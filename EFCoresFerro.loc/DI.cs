using EFCore3.DATOS.Interfaces;
using EFCore3.DATOS.Repositorio;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos.Repositorio;
using EFCoresFerro.Datos;
using EFCoresFerro.DATOS.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoresFerro.loc;
public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IRepositorioBrands,
                RepositorioBrands>();
            servicios.AddScoped<IRepositorioGenre, 
                RepositorioGenre>(); 
            servicios.AddScoped<IRepositorioSports,RepositorioSports>();
        servicios.AddScoped<IRepositorioColors, RepositorioColors>();
        servicios.AddScoped<IRepositorioShoes, RepositorioShoes>();

        servicios.AddScoped<IMarcaRepo,
             MarcaRepo>();
        servicios.AddScoped<IGeneroRepo,
            GeneroRepo>();
        servicios.AddScoped<IDeporteRep, DeporteRepo>();
        servicios.AddScoped<IZapatillaRepository, ZapatillaRepository>();



        servicios.AddScoped<IServicioBrands,
                ServicioBrands>();
            servicios.AddScoped<IServicioGenre, ServicioGenre>();
            servicios.AddScoped<IServicioSports, ServicioSports>();
        servicios.AddScoped<IServicioColors, ServicioColors>();
        servicios.AddScoped<IServicioShoes, ServicioShoes>();


        servicios.AddScoped<IServicioDeporte,
                ServicioDeporte>();
        servicios.AddScoped<IServicioMarca,
               ServicioMarca>();
        servicios.AddScoped<IServicioGenero, ServicioGenero>();
        servicios.AddScoped<IServicioZapatilla, ServicioZapatilla>();


        servicios.AddScoped<IUnitOfWork, UnitOfWork>();


        servicios.AddDbContext<EFCoresDbContext>(optiones =>
            {
                optiones.UseSqlServer(@"Data Source=.; 
                        Initial Catalog=EFCoresFerro; 
                        Trusted_Connection=true; 
                        TrustServerCertificate=true;");
            });

            return servicios.BuildServiceProvider();
        }

    }


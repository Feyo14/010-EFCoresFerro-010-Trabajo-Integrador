using EFCore3.DATOS.Interfaces;
using EFCore3.DATOS.Repositorio;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.Datos;

namespace EFCore3.Servicios.Servicios
{
    public class ServicioSize : IServicioSize
    {
        private readonly EFCoresDbContext context;
        private readonly IRepositorioSize repo;
        public ServicioSize()
        {
            context=new EFCoresDbContext();
            repo = new RepositorioSize(context);
        }
       
        public List<Size> GetLista()
        {
            
                return repo.GetLista(); 
            


        }

        public Size? GetPorName(decimal descrip)
        {
            return repo.GetPorName(descrip);
        }
    }

     //   public Paise GetPaisporId(int paisId)
      //  {
          //  throw new NotImplementedException();
       // }
    }

using EFCore3.DATOS.Interfaces;
using EFCore3.Entidades;
using EFCoresFerro.Datos;

namespace EFCore3.DATOS.Repositorio
{
    public class RepositorioSize : IRepositorioSize
    {
        private readonly EFCoresDbContext context;

        public RepositorioSize(EFCoresDbContext context)
        {
            this.context = context;
        }
       
        public List<Size> GetLista()
        {
            return context.Size
            //    .OrderBy(p=>p.size)
                .ToList();
        }

        public Size? GetPorName(decimal descrip)
        {
            return context.Size
                                                .FirstOrDefault(te => te.sizeNumber == descrip);
        }
    }
}

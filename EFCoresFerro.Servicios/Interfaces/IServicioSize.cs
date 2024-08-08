





using EFCore3.Entidades;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioSize
    {
        List<Size> GetLista();
        Size? GetPorName(decimal descrip);

    }
}

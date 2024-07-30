






using EFCore3.Entidades;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioColors
    {
        List<Colors> GetLista();
        void Agregar(Colors color);
        void Borrar(Colors color);
        void Editar(Colors color);
        public bool existe(Colors b);
        Colors? GetColorsPorId(int b);
    }
}

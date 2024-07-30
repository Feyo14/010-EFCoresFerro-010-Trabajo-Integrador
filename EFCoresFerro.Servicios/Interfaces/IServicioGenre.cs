





using EFCore3.Entidades;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioGenre
    {
        List<Genre> GetLista();
        void Agregar(Genre genre);
        void Borrar(Genre genre);
        void Editar(Genre genre);
        public bool existe(Genre b);
        Genre? GetGenrePorId(int b);
        Genre? GetPorName(string nombre);

    }
}

using EFCore3.Entidades;

namespace EFCore3.DATOS.Interfaces
{
    public interface IRepositorioGenre
    {
        List<Genre> GetLista();
        void Agregar(Genre genre);
        void Borrar(Genre genre);
        void Editar(Genre genre);
        public bool existe(Genre genre);
        Genre? GetGenrePorId(int genreid);
        Genre? GetPorName(string nombre);


    }
}

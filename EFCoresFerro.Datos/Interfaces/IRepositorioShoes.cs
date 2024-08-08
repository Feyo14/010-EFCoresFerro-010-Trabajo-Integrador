

using EFCore3.Entidades;
using EFCoreFerro2.Datos;

namespace EFCore3.DATOS.Interfaces
{
    public interface IRepositorioShoes
    {
        List<Shoes> GetLista();
        void Agregar(Shoes shoe);
        void Borrar(Shoes shoe);
        void Editar(Shoes shoe);
        Shoes? GetShoePorId(int id);
        public bool existe(Shoes d);
        Shoes? GetPorName(string descrip);
        public bool existeShoeSize(int s);



    }
}

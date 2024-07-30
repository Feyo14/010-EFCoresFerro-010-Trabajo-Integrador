using EFCore3.Entidades;

namespace EFCore3.DATOS.Interfaces
{
    public interface IRepositorioBrands
    {
        List<Brands> GetLista();
        void Agregar(Brands brands);
        void Borrar(Brands brands);
        void Editar(Brands brands);
        public bool existe(Brands brands);
        Brands? GetBrandsPorId(int BrandsId);
        Brands? GetPorName(string nombre);

    }
}

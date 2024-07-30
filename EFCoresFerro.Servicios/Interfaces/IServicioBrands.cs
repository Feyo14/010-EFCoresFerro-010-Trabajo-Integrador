using EFCore3.Entidades;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioBrands
    {
        List<Brands> GetLista();
        void Agregar(Brands brands);
        void Borrar(Brands brands);
        void Editar(Brands brands);
        public bool existe(Brands b);
        Brands? GetBrandsPorId(int b);
        Brands? GetPorName(string nombre);

    }
}

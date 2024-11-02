





using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using System.Text.RegularExpressions;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioShoes
    {
        List<Shoes> GetLista();
        void Agregar(Shoes shoe);
        void Borrar(Shoes shoe);
        void Editar(Shoes shoe);
        Shoes? GetShoePorId(int id);
        public bool existe(Shoes d);
        Shoes? GetPorName(string descrip);
        public bool existeShoeSize(int s);
        List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page,
    int pageSize, Brand? marcafiltro = null, Genre? GeneroFiltro = null, Sports? deportefiltro = null, decimal? max = null,
        decimal? min = null);

        int GetCantidad(Func<Shoes, bool>? filtro = null, Brand? m = null, Genre? g = null, Sports? d = null, decimal? max = null, decimal? min = null);
    }
}


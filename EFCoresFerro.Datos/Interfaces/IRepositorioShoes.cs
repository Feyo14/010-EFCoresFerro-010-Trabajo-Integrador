

using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using System.Text.RegularExpressions;

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

        List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page,
   int pageSize, Brand? marcafiltro = null, Genre? generofiltro = null, Sports? Deportefiltro = null, decimal? max = null, decimal? min = null);
        int GetCantidad(Func<Shoes, bool>? filtro = null, Brand? m = null, Genre? g = null, Sports? d = null, decimal? max = null, decimal? min = null);




    }
}

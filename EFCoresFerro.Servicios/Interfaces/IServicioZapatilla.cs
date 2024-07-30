using EFCoreFerro2.Datos;
using EFCoreFerro2.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFCoreFerro.Services.Services
{
    public interface IServicioZapatilla
    {
        void Agregar(Zapatilla z);
        void Borrar(Zapatilla z);
        void Editar(Zapatilla z);
        Zapatilla? GetZapatillaPorId(int id);
        public bool existe(Zapatilla d);
        List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page,
      int pageSize, Marca? marcafiltro = null, Genero? GeneroFiltro = null, Deporte? deportefiltro = null, decimal? max = null,
      decimal? min=null);

        int GetCantidad(Func<Zapatilla, bool>? filtro = null, Marca? m=null, Genero? g = null, Deporte? d = null,decimal? max = null, decimal? min = null);
    }
}

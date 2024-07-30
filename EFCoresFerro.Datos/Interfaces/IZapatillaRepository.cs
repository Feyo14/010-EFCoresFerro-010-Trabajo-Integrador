using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Datos.Repositorio
{
    public interface IZapatillaRepository
    {
        void Agregar(Zapatilla z);
        void Borrar(Zapatilla z);
        void Editar(Zapatilla z);
        Zapatilla? GetZapatillaPorId(int id);
        public bool existe(Zapatilla d);
        List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page,
      int pageSize, Marca? marcafiltro = null, Genero? generofiltro = null, Deporte? Deportefiltro = null,decimal? max=null,decimal? min = null);
        int GetCantidad(Func<Zapatilla, bool>? filtro = null,Marca? m=null,Genero? g=null, Deporte? d=null,decimal? max=null,decimal? min=null);


    }
}

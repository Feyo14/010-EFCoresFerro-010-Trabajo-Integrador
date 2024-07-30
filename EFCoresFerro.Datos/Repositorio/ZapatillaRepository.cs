using Azure;
using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Datos.Repositorio
{
    public class ZapatillaRepository : IZapatillaRepository
    {
        private readonly EFCoresDbContext _context;
        public ZapatillaRepository(EFCoresDbContext _context)
        {
            this._context = _context;
        }

        public void Agregar(Zapatilla z)
        {
            _context.Zapatillas.Add(z);
        }

        public void Borrar(Zapatilla z)
        {
            _context.Zapatillas.Remove(z);
        }

        public void Editar(Zapatilla z)
        {
            string descprip = z.NombreZapatilla;
            decimal val = z.Price;
            var s = _context.Zapatillas
        .FirstOrDefault(t => t.ZapatillaId == z.ZapatillaId);
            var sport = _context.Deportes
              .FirstOrDefault(t => t.DeporteId == z.DeporteId);
            var genre = _context.Generos
              .FirstOrDefault(t => t.GeneroId == z.GeneroId);
            var brand = _context.Marcas
            .FirstOrDefault(t => t.MarcaId == z.MarcaId);
  
            if (s != null)
            {
                _context.Attach(s);
                z = s;

            }
            if (sport != null)
            {   
                _context.Attach(sport);
                s.Deporte = sport;

            }
            if (genre != null)
            {
                _context.Attach(genre);
                s.Genero = genre;

            }
            if (brand != null)
            {
                _context.Attach(brand);
                s.Marca = brand;

            }


            s.NombreZapatilla = descprip;
            s.Price = val;

            _context.Zapatillas.Update(z);
        }

        public bool existe(Zapatilla d)
        {
   if (d.ZapatillaId == 0)
            {
                return _context.Zapatillas.Any(
                    p => p.NombreZapatilla == d.NombreZapatilla &&
                    p.MarcaId == d.MarcaId &&
                    p.GeneroId == d.GeneroId &&
                    p.DeporteId == d.DeporteId);
            }
            return _context.Zapatillas.Any(
                p => p.NombreZapatilla == d.NombreZapatilla &&
                    p.MarcaId == d.MarcaId &&
                    p.GeneroId == d.GeneroId &&
                    p.DeporteId == d.DeporteId &&
            p.ZapatillaId != p.ZapatillaId);
        }

        public int GetCantidad(Func<Zapatilla, bool>? filtro = null, Marca? m = null, Genero? g = null, Deporte? d = null, decimal? max = null, decimal? min = null)
        {
            IQueryable<Zapatilla> query = _context.Zapatillas
         .Include(p => p.Marca)
                   .Include(p => p.Genero)
                               .Include(p => p.Deporte)
         .AsNoTracking();

            // Aplicar filtro si se proporciona un tipo de planta
            if (m != null)
            {
                query = query
                    .Where(p => p.MarcaId == m.MarcaId);
            }
            if (g != null)
            {
                query = query
                    .Where(p => p.GeneroId == g.GeneroId);
            }
            if (d != null)
            {
                query = query
                    .Where(p => p.DeporteId == d.DeporteId);
            }
            // Aplicar filtrado entre 2 precios cualquiera si se proporciona
            if (max > 0 && min > 0)
            {
                query = query.Where(p => p.Price >= min && p.Price <= max);
            }

            List<Zapatilla> listaPaginada = query
               .AsNoTracking()
               .ToList();

            return listaPaginada.Count;
            
         
        }

        public Zapatilla? GetZapatillaPorId(int id)
        {
            return _context.Zapatillas
                           .FirstOrDefault(t => t.ZapatillaId == id);
        }

        List<ZapatillalistDto> IZapatillaRepository.GetListaPaginadaOrdenadaFiltradaporCombos(int page, int pageSize, Marca? marcafiltro,
            Genero? generofiltro, Deporte? deportefiltro, decimal? max ,decimal? min )
        {
            IQueryable<Zapatilla> query = _context.Zapatillas
           .Include(p => p.Marca)
                     .Include(p => p.Genero)
                                 .Include(p => p.Deporte)
           .AsNoTracking();

            // Aplicar filtro si se proporciona un tipo de planta
            if (marcafiltro != null)
            {
                query = query
                    .Where(p => p.MarcaId == marcafiltro.MarcaId);
            }
            if (generofiltro != null)
            {
                query = query
                    .Where(p => p.GeneroId == generofiltro.GeneroId);
            }
            if (deportefiltro != null)
            {
                query = query
                    .Where(p => p.DeporteId == deportefiltro.DeporteId);
            }


            // Aplicar filtrado entre 2 precios cualquiera si se proporciona
            if (max > 0 && min > 0)
            {
                query = query.Where(p => p.Price>=min && p.Price<=max);
            }
            // Paginar los resultados
            List<Zapatilla> listaPaginada = query
                .AsNoTracking()
               .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            // Mapear los resultados a PlantaListDto
            List<ZapatillalistDto> listaDto = listaPaginada
                .Select(p => new ZapatillalistDto
                {
                    ZapatillaId = p.ZapatillaId,
                    NombreZapatilla = p.NombreZapatilla,
                    Generon = p.Genero.GeneroName,
                    Deporten = p.Deporte.DeporteName,
                    Marcan = p.Marca.MarcaName,
                    Precion = p.Price
                })
                .ToList();

            return listaDto;
        }
    }
}

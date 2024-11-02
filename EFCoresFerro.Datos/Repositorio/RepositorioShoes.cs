using EFCore3.DATOS.Interfaces;
using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFCore3.DATOS.Repositorio
{
    public class RepositorioShoes : IRepositorioShoes
    {
        private readonly EFCoresDbContext context;

        public RepositorioShoes(EFCoresDbContext _context)
        {
           context = _context;
        }
      
        public void Agregar(Shoes shoe)
        {
            context.Shoes.Add(shoe);
        }

        public void Borrar(Shoes shoe)
        {
            context.Shoes.Remove(shoe);
        }

        public void Editar(Shoes shoe)
        {
            string descprip = shoe.Descripcion;
            decimal val = shoe.Price;
            string model = shoe.Model;
            var s = context.Shoes
        .FirstOrDefault(t => t.ShoeId == shoe.ShoeId);
            var sport = context.Sports
              .FirstOrDefault(t => t.SportId == shoe.SportId);
            var genre= context.Genres
              .FirstOrDefault(t => t.GenreId == shoe.GenreId);
            var brand = context.Brands
            .FirstOrDefault(t => t.BrandId == shoe.BrandId);
            /*
        
            */
            if (s != null)
            {
                context.Attach(s);
                shoe = s;

            }
            if (sport != null)
            {
                context.Attach(sport);
                s.sport = sport;

            }
            if (genre != null)
            {
                context.Attach(genre);
                s.genre = genre;

            }
            if (brand != null)
            {
                context.Attach(brand);
                s.brand = brand;

            }
          

            s.Descripcion =descprip;
          s.Price =val;
            s.Model = model;

            context.Shoes.Update(s);      
        }

        public bool existe(Shoes d)
        {
            if (d.ShoeId == 0)
            {
                return context.Shoes.Any(
                    p => p.Descripcion == d.Descripcion &&
                    p.BrandId == d.BrandId &&
                    p.GenreId == d.GenreId &&
                    p.Model == d.Model &&
                    p.SportId == d.SportId);
            }
            return context.Shoes.Any(
                p => p.Descripcion == d.Descripcion &&
                    p.BrandId == d.BrandId &&
                    p.GenreId == d.GenreId &&
                    p.Model == d.Model &&
                    p.SportId == d.SportId &&
            p.ShoeId != p.ShoeId);
        }

        public bool existeShoeSize(int s)
        {
            return context.ShoeSize.Any(
                  p => p.ShoeId == s);
        }

        public int GetCantidad(Func<Shoes, bool>? filtro = null, Brand? m = null, Genre? g = null, Sports? d = null, decimal? max = null, decimal? min = null)
        {
            IQueryable<Shoes> query = context.Shoes
                   .Include(p => p.brand)
                             .Include(p => p.genre)
                                         .Include(p => p.sport)
                   .AsNoTracking();

            // Aplicar filtro si se proporciona un tipo de planta
            if (m != null)
            {
                query = query
                    .Where(p => p.BrandId == m.BrandId);
            }
            if (g != null)
            {
                query = query
                    .Where(p => p.GenreId == g.GenreId);
            }
            if (d != null)
            {
                query = query
                    .Where(p => p.SportId == d.SportId);
            }
            // Aplicar filtrado entre 2 precios cualquiera si se proporciona
            if (max > 0 && min > 0)
            {
                query = query.Where(p => p.Price >= min && p.Price <= max);
            }

            List<Shoes> listaPaginada = query
               .AsNoTracking()
               .ToList();

            return listaPaginada.Count;
        }

        public List<Shoes> GetLista()
        {
            return context.Shoes
                .Include(p => p.brand)
                .Include(p => p.sport)
                .Include(p => p.genre)
                      //.OrderBy(p => p.Model)
                          .AsNoTracking()
                .ToList();
             //  .OrderBy(p=>p.Price)
        
        }

        public List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page, int pageSize, Brand? marcafiltro = null, Genre? generofiltro = null, Sports? Deportefiltro = null, decimal? max = null, decimal? min = null)
        {
     
                IQueryable<Shoes> query = context.Shoes
               .Include(p => p.brand)
                         .Include(p => p.genre)
                                     .Include(p => p.sport)
               .AsNoTracking();

                // Aplicar filtro si se proporciona un tipo de planta
                if (marcafiltro != null)
                {
                    query = query
                        .Where(p => p.BrandId == marcafiltro.BrandId);
                }
                if (generofiltro != null)
                {
                    query = query
                        .Where(p => p.GenreId == generofiltro.GenreId);
                }
                if (Deportefiltro != null)
                {
                    query = query
                        .Where(p => p.SportId == Deportefiltro.SportId);
                }


                // Aplicar filtrado entre 2 precios cualquiera si se proporciona
                if (max > 0 && min > 0)
                {
                    query = query.Where(p => p.Price >= min && p.Price <= max);
                }
                // Paginar los resultados
                List<Shoes> listaPaginada = query
                    .AsNoTracking()
                   .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Mapear los resultados a PlantaListDto
                List<ZapatillalistDto> listaDto = listaPaginada
                    .Select(p => new ZapatillalistDto
                    {
                        ZapatillaId = p.ShoeId,
                        NombreZapatilla = p.Descripcion,
                        Generon = p.genre.GenreName,
                        Deporten = p.sport.SportName,
                        Marcan = p.brand.BrandName,
                        Precion = p.Price
                    })
                    .ToList();

                return listaDto;
            
        }

        public Shoes? GetPorName(string descrip)
        {
            return context.Shoes
                                     .FirstOrDefault(t => t.Descripcion == descrip);
        }

        public Shoes? GetShoePorId(int id)
        {
            return context.Shoes
                                .FirstOrDefault(t => t.ShoeId == id);
        }
    }
}

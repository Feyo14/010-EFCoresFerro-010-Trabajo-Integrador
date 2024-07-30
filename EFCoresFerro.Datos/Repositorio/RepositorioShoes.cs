﻿using EFCore3.DATOS.Interfaces;
using EFCore3.Entidades;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;

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

        public Shoes? GetShoePorId(int id)
        {
            return context.Shoes
                                .FirstOrDefault(t => t.ShoeId == id);
        }
    }
}

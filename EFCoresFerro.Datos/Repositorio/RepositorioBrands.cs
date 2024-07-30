﻿using EFCoresFerro.Datos;
using EFCore3.DATOS.Interfaces;
using Microsoft.EntityFrameworkCore;
using EFCore3.Entidades;

namespace EFCoresFerro.DATOS.Repositorio
{
    public class RepositorioBrands : IRepositorioBrands
    {
        private readonly EFCoresDbContext context;

        public RepositorioBrands(EFCoresDbContext context)
        {
            this.context = context;
        }
      
        public void Agregar(Brands brands)
        {
            context.Brands.Add(brands);
        }

        public void Borrar(Brands brands)
        {
            context.Brands.Remove(brands);
        }
        public bool existe(Brands brand)
        {
            if (brand.BrandId == 0)
            {
                return context.Brands.Any(p => p.BrandName == brand.BrandName);
            }
            else
            {
                return context.Brands.Any(p => p.BrandName == brand.BrandName && p.BrandId != brand.BrandId);
            }

        }
        public void Editar(Brands brands)
        {
            context.Brands.Update(brands);      
        }

        
        public List<Brands> GetLista()
        {
            return context.Brands
                .OrderBy(p=>p.BrandName)
                                .AsNoTracking()

                .ToList();
        }
        public Brands? GetBrandsPorId(int b)
        {
            return context.Brands
                 .FirstOrDefault(t => t.BrandId == b);
        }
        public Brands? GetPorName(string nombre)
        {
            return context.Brands
                         .FirstOrDefault(te => te.BrandName == nombre);
        }


    }
}
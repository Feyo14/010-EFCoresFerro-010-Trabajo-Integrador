﻿using EFCore3.DATOS.Interfaces;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.Datos;
using EFCoresFerro.DATOS.Repositorio;

namespace EFCore3.Servicios.Servicios
{
    public class ServicioBrands : IServicioBrands
    {
        private readonly EFCoresDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IRepositorioBrands repo;
        public ServicioBrands()
        {
            context=new EFCoresDbContext();
            repo = new RepositorioBrands(context);
        }
        public void Agregar(Brands brands)
        {
            try
            {
                if (brands.BrandId == 0)
                {
                    repo.Agregar(brands);
                }
                else
                {
                    repo.Editar(brands);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(Brands Brand)
        {
            var BrandInDb = context.Brands.Find(Brand.BrandId);
            if (BrandInDb != null)
            {
                context.Brands.Remove(BrandInDb);
                context.SaveChanges();
                Console.WriteLine($"Autor {BrandInDb.BrandName} borrado!!!");
            }
            else
            {
                Console.WriteLine("ID de autor no existente!!!");
            }
        }

        public void Editar(Brands pais)
        {
            throw new NotImplementedException();
        }
        public bool existe(Brands b)
        {
            try
            {
                return repo.existe(b);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Brands> GetLista()
        {
            
                return repo.GetLista(); 
            


        }
        public Brands? GetBrandsPorId(int b)
        {
            return repo.GetBrandsPorId(b);
        }

        public Brands? GetPorName(string nombre)
        {
            return repo.GetPorName(nombre);
        }
    }

     //   public Paise GetPaisporId(int paisId)
      //  {
          //  throw new NotImplementedException();
       // }
    }
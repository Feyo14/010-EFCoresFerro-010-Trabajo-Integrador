﻿using EFCore3.DATOS.Interfaces;
using EFCore3.DATOS.Repositorio;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.Datos;

namespace EFCore3.Servicios.Servicios
{
    public class ServicioSports : IServicioSports
    {
        private readonly EFCoresDbContext context;
        private readonly IRepositorioSports repo;
        public ServicioSports()
        {
            context=new EFCoresDbContext();
            repo = new RepositorioSports(context);
        }
        public void Agregar(Sports sport)
        {
            try
            {
                if (sport.SportId == 0)
                {
                    repo.Agregar(sport);
                }
                else
                {
                    repo.Editar(sport);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(Sports Brand)
        {
            var SportInDb = context.Sports.Find(Brand.SportId);
            if (SportInDb != null)
            {
                context.Sports.Remove(SportInDb);
                context.SaveChanges();
                Console.WriteLine($"Sport {SportInDb.SportName} borrado!!!");
            }
            else
            {
                Console.WriteLine("ID de Sport no existente!!!");
            }
        }

        public void Editar(Sports pais)
        {
            throw new NotImplementedException();
        }

        public bool existe(Sports b)
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

        public List<Sports> GetLista()
        {
            
                return repo.GetLista(); 
            


        }

        public Sports? GetPorName(string nombre)
        {
            return repo.GetPorName(nombre);
        }

        public Sports? GetSportsPorId(int b)
        {
            return repo.GetSportsPorId(b);
        }
    }

     //   public Paise GetPaisporId(int paisId)
      //  {
          //  throw new NotImplementedException();
       // }
    }

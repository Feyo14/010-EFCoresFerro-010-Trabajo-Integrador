﻿using EFCore3.DATOS.Interfaces;
using EFCore3.DATOS.Repositorio;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.Datos;

namespace EFCore3.Servicios.Servicios
{
    public class ServicioGenre : IServicioGenre
    {
        private readonly EFCoresDbContext context;
        private readonly IRepositorioGenre repo;
        public ServicioGenre()
        {
            context=new EFCoresDbContext();
            repo = new RepositorioGenre(context);
        }
        public void Agregar(Genre g)
        {
            try
            {
                if (g.GenreId == 0)
                {
                    repo.Agregar(g);
                }
                else
                {
                    repo.Editar(g);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(Genre Brand)
        {
            var GenreInDb = context.Genres.Find(Brand.GenreId);
            if (GenreInDb != null)
            {
                context.Genres.Remove(GenreInDb);
                context.SaveChanges();
                Console.WriteLine($"Autor Genre {GenreInDb.GenreName} borrado!!!");
            }
            else
            {
                Console.WriteLine("ID de Genre no existente!!!");
            }
        }

        public void Editar(Genre pais)
        {
            throw new NotImplementedException();
        }

        public bool existe(Genre b)
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

        public Genre? GetGenrePorId(int b)
        {
            return repo.GetGenrePorId(b);
        }

        public List<Genre> GetLista()
        {
            
                return repo.GetLista(); 
            


        }

        public Genre? GetPorName(string nombre)
        {
            return repo.GetPorName(nombre);
        }
    }

     //   public Paise GetPaisporId(int paisId)
      //  {
          //  throw new NotImplementedException();
       // }
    }

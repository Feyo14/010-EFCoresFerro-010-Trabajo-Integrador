using EFCoreFerro2.Datos;
using EFCoreFerro2.Datos.Repositorio;
using EFCoreFerro2.Entidades.Dto;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro.Services.Services
{
    public class ServicioGenero : IServicioGenero
    {
        private readonly IGeneroRepo _repository;
        private readonly EFCoresDbContext context;
        public ServicioGenero( )
        {
            context = new EFCoresDbContext();
              _repository = new GeneroRepo(context);
        }

        public void Agregar(Genero c)
        {
            try
            {
                if (c.GeneroId == 0)
                {
                    _repository.Agregar(c);
                }
                else
                {
                    _repository.Editar(c);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(Genero col)
        {

            var gInDb = context.Generos.Find(col.GeneroId);
            if (gInDb != null)
            {
                context.Generos.Remove(gInDb);
                context.SaveChanges();
                Console.WriteLine($"Genero:  {gInDb.GeneroName} borrado!!!");
            }
            else
            {
                Console.WriteLine("ID de Deporte no existente!!!");
            }
        }

        public void Editar(Genero b)
        {
            throw new NotImplementedException();

        }

        public bool existe(Genero b)
        {
            try
            {
                return _repository.existe(b);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(Func<Genero, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

     

        public Genero? GetGeneroPorNombre(string nombre)
        {
            return _repository.GetGeneroPorNombre(nombre);
        }

        public List<Genero> GetLista()
        {
            return _repository.GetLista();
                           
       
        }

    }
}

using EFCore3.Entidades;
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
    public class ServicioMarca : IServicioMarca
    {
        private readonly IMarcaRepo _repository;
         private readonly IUnitOfWork _unitOfWork;
        private readonly EFCoresDbContext context;
        public ServicioMarca( )
        {
            context = new EFCoresDbContext();

            _repository = new MarcaRepo(context);
        }

        public void Agregar(Marca c)
        {
            try
            {
                if (c.MarcaId == 0)
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

        public void Borrar(Marca col)
        {

            var gInDb = context.Marcas.Find(col.MarcaId);
            if (gInDb != null)
            {
                context.Marcas.Remove(gInDb);
                context.SaveChanges();
                Console.WriteLine($"Marca:  {gInDb.MarcaName} borrada!!!");
            }
            else
            {
                Console.WriteLine("ID de Marca no existente!!!");
            }
        }

        public void Editar(Marca b)
        {
            throw new NotImplementedException();

        }

        public bool existe(Marca b)
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

        public int GetCantidad(Func<Marca, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

        public List<Marca> GetLista()
        {
            return _repository.GetLista();
                           
       
        }

        public Marca? GetMarcaPorNombre(string nombre)
        {
            return _repository.GetMarcaPorNombre(nombre);
        }
        public Marca? GetMarcaPorId(int b)
        {
            return _repository.GetMarcaPorId(b);
        }

        public bool estarelacionado(int id)
        {
            return _repository?.estarelacionado(id) ?? true;
        }
    }
}

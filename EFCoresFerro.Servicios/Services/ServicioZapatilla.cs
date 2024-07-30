using EFCore3.Entidades;
using EFCoreFerro2.Datos;
using EFCoreFerro2.Datos.Repositorio;
using EFCoreFerro2.Entidades.Dto;
using EFCoresFerro.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro.Services.Services
{
    public class ServicioZapatilla : IServicioZapatilla
    {
        private readonly IZapatillaRepository _repository;
         private readonly IUnitOfWork _unitOfWork;
        public ServicioZapatilla(IZapatillaRepository repo,IUnitOfWork u)
        {
            _repository = repo ?? throw new ArgumentNullException(nameof(repo));
            _unitOfWork = u;
        }

        public void Agregar(Zapatilla z)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (z.ZapatillaId == 0)
                {
                    z.Genero = null;
                    z.Deporte = null;
                    z.Marca = null;
                    _repository.Agregar(z);
                    _unitOfWork.SaveChanges(); // Guardar cambios para obtener el id de la planta agregada

                }
                else
                {
                    _repository.Editar(z);
                    _unitOfWork.SaveChanges(); // Guardar cambios para obtener el id de la planta agregada

                }
                _unitOfWork.SaveChanges(); // Guardar todos los cambios al final
                _unitOfWork.Commit(); // Confirmar los cambios
                                      // _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(Zapatilla z)
        {
            _unitOfWork.BeginTransaction();

            Zapatilla gInDb = _repository.GetZapatillaPorId(z.ZapatillaId);
            if (gInDb != null)
            {
                z.Deporte = null;
                z.Genero = null;
                z.Marca = null;
                _repository.Borrar(z);
                _unitOfWork.SaveChanges(); // Guardar cambios para confirmar eliminación 

                _unitOfWork.Commit(); // Confirmar los cambios
                Console.WriteLine($"Shoe:  {gInDb.NombreZapatilla} borrado!!!");
            }
            else
            {
                _unitOfWork.Rollback();

                Console.WriteLine("ID de zapatilla no existente!!!");
            }
        }

        public void Editar(Zapatilla z)
        {
            _unitOfWork.BeginTransaction();

            _repository.Editar(z);
            _unitOfWork.Commit();
        }

        public bool existe(Zapatilla d)
        {
            return _repository.existe(d);
        }

        public int GetCantidad(Func<Zapatilla, bool>? filtro = null, Marca? m=null,Genero? g = null, Deporte? d = null,decimal? max = null, decimal? min = null )
        {
            return _repository.GetCantidad(filtro,m,g,d,max,min);
        }

        public List<ZapatillalistDto> GetListaPaginadaOrdenadaFiltradaporCombos(int page, int pageSize, Marca? marcafiltro = null, Genero? g = null, Deporte? d = null,
            decimal? max = null, decimal? min = null)
        {
            return _repository.GetListaPaginadaOrdenadaFiltradaporCombos(page, pageSize, marcafiltro,g,d,max,min);
                }

        public Zapatilla? GetZapatillaPorId(int id)
        {
            return _repository.GetZapatillaPorId(id);
        }
    }
}

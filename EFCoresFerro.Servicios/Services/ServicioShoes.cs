using EFCore3.DATOS.Interfaces;
using EFCore3.DATOS.Repositorio;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace EFCore3.Servicios.Servicios
{
    public class ServicioShoes : IServicioShoes
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositorioShoes repo;
private readonly EFCoresDbContext _dbContext;
    

        public ServicioShoes(IRepositorioShoes repositor, IUnitOfWork unitOfWork)
        {
            repo = repositor ?? throw new ArgumentNullException(nameof(repositor));
            _unitOfWork = unitOfWork;
            _dbContext = new EFCoresDbContext();
        }
        public void Agregar(Shoes shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (shoe.ShoeId == 0)
                {
                    shoe.genre = null;
                    shoe.sport = null;
                    shoe.brand = null;
                    repo.Agregar(shoe);
                   _unitOfWork.SaveChanges(); // Guardar cambios para obtener el id de la planta agregada

                }
                else
                {
                    repo.Editar(shoe);
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

        public void Borrar(Shoes s)
        {
            _unitOfWork.BeginTransaction();

            Shoes gInDb = repo.GetShoePorId(s.ShoeId);
            if (gInDb != null)
            {
                s.sport = null;
                s.genre = null;
                s.brand = null;
                repo.Borrar(gInDb);
                _unitOfWork.SaveChanges(); // Guardar cambios para confirmar eliminación 

                _unitOfWork.Commit(); // Confirmar los cambios
                Console.WriteLine($"Shoe:  {gInDb.Descripcion} borrado!!!");
            }
            else
            {
                _unitOfWork.Rollback();

                Console.WriteLine("ID de Shoe no existente!!!");
            }
        }

        public void Editar(Shoes s)
        {
            _unitOfWork.BeginTransaction();
          
            repo.Editar(s);
            _unitOfWork.Commit();

        }

        public bool existe(Shoes d)
        {
            return repo.existe(d);
        }

        public List<Shoes> GetLista()
        {
            
                return repo.GetLista(); 
            
        }

        public Shoes? GetShoePorId(int id)
        {
          return   repo.GetShoePorId(id);        }
    }

     //   public Paise GetPaisporId(int paisId)
      //  {
          //  throw new NotImplementedException();
       // }
    }

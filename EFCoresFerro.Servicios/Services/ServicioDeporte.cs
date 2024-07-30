using EFCore3.Entidades;
using EFCoreFerro2.Datos;
using EFCoreFerro2.Datos.Repositorio;
using EFCoresFerro.Datos;

namespace EFCoreFerro.Services.Services
{
    public class ServicioDeporte : IServicioDeporte
    {
        private readonly IDeporteRep _repository;
 //        private readonly IUnitOfWork _unitOfWork;
        private readonly EFCoresDbContext context;

        public ServicioDeporte( )
        {
            context = new EFCoresDbContext();
            _repository = new DeporteRepo(context);

        }

        public void Agregar(Deporte c)
        {
            try
            {
                if (c.DeporteId == 0)
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

        public void Borrar(Deporte col)
        {

            var deporteInDb = context.Deportes.Find(col.DeporteId);
            if (deporteInDb != null)
            {
                context.Deportes.Remove(deporteInDb);
                context.SaveChanges();
                Console.WriteLine($"Deporte:  {deporteInDb.DeporteName} borrado!!!");
            }
            else
            {
                Console.WriteLine("ID de Deporte no existente!!!");
            }
        }

        public void Editar(Deporte b)
        {
            throw new NotImplementedException();

        }

        public bool existe(Deporte b)
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

        public int GetCantidad(Func<Deporte, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }

        public Deporte? GetDeportePorNombre(string nombre)
        {
            return _repository.GetDeportePorNombre(nombre);
        }

        public List<Deporte> GetLista()
        {
            return _repository.GetLista();
                           
       
        }

    }
}

using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Datos.Repositorio
{
    public class MarcaRepo : IMarcaRepo
    {
        private readonly EFCoresDbContext _context;
        public MarcaRepo(EFCoresDbContext c)
        {
            _context = c;
                }
        public int GetCantidad(Func<Marca, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Marcas.Count(filtro);
            }
            else
            {
                return _context.Marcas.Count();
            }
        }

        public List<Marca> GetLista()
        {
return _context.Marcas
                          .AsNoTracking()
                          .ToList();
        }

        public Marca? GetMarcaPorNombre(string nombre)
        {
            return _context.Marcas
                          .FirstOrDefault(te => te.MarcaName == nombre);
        }

        public bool existe(Marca d)
        {
            if (d.MarcaId == 0)
            {
                return _context.Marcas.Any(p => p.MarcaName == d.MarcaName);
            }
            else
            {
                return _context.Marcas.Any(p => p.MarcaName == d.MarcaName && p.MarcaId != d.MarcaId);
            }
        }


        public void Agregar(Marca m)
        {
            _context.Marcas.Add(m);
        }

        public void Borrar(Marca m)
        {
            _context.Marcas.Remove(m);
        }

        public void Editar(Marca m)
        {
            _context.Marcas.Update(m);
        }

        public Marca? GetMarcaPorId(int b)
        {
            return _context.Marcas
                            .FirstOrDefault(t => t.MarcaId == b);
        }

        public bool estarelacionado(int id)
        {
            return _context.Zapatillas.Any(p => p.MarcaId == id);
        }
    }

   
}

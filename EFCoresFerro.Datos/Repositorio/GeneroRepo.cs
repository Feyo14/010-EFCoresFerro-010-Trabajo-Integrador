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
    public class GeneroRepo : IGeneroRepo
    {
        private readonly EFCoresDbContext _context;

        public GeneroRepo(EFCoresDbContext context)
        {
            _context = context;
        }

        public void Agregar(Genero m)
        {
            _context.Generos.Add(m);
        }

        public void Borrar(Genero m)
        {
            _context.Generos.Remove(m);
        }

        public void Editar(Genero m)
        {
            _context.Generos.Update(m);
        }

        public bool existe(Genero d)
        {
            if (d.GeneroId == 0)
            {
                return _context.Generos.Any(p => p.GeneroName == d.GeneroName);
            }
            else
            {
                return _context.Generos.Any(p => p.GeneroName == d.GeneroName && p.GeneroId != d.GeneroId);
            }
        }


        public int GetCantidad(Func<Genero, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Generos.Count(filtro);
            }
            else
            {
                return _context.Generos.Count();
            }
        }

        public Genero? GetGeneroPorNombre(string nombre)
        {
            return _context.Generos
                         .FirstOrDefault(te => te.GeneroName == nombre);
        }

        List<Genero> IGeneroRepo.GetLista()
        {
            return _context.Generos
                                   .AsNoTracking()
                                   .ToList();
        }
    }
}

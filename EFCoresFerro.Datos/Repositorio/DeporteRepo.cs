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
    public class DeporteRepo : IDeporteRep
    {
        private readonly EFCoresDbContext _context;

        public DeporteRepo(EFCoresDbContext context)
        {
            _context = context;
        }

        public void Agregar(Deporte m)
        {
            _context.Deportes.Add(m);
        }

        public void Borrar(Deporte m)
        {
            _context.Deportes.Remove(m);
        }
        public bool existe(Deporte d)
        {
            if (d.DeporteId == 0)
            {
                return _context.Deportes.Any(p => p.DeporteName == d.DeporteName);
            }
            else
            {
                return _context.Colors.Any(p => p.ColorName == d.DeporteName && p.ColorId != d.DeporteId);
            }
        }

        public void Editar(Deporte m)
        {
            _context.Deportes.Update(m);
        }

        public int GetCantidad(Func<Deporte, bool>? filtro = null)
        {
            if (filtro != null)
            {
                return _context.Deportes.Count(filtro);
            }
            else
            {
                return _context.Deportes.Count();
            }
        }

        public Deporte? GetDeportePorNombre(string nombre)
        {
            return _context.Deportes
                         .FirstOrDefault(te => te.DeporteName == nombre);
        }

        public List<Deporte> GetLista()
        {
            return _context.Deportes
                          .AsNoTracking()
                          .ToList();
        }

    }
}

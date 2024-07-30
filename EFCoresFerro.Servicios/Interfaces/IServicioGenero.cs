using EFCoreFerro2.Datos;
using EFCoreFerro2.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFCoreFerro.Services.Services
{
    public interface IServicioGenero
    {
        void Agregar(Genero d);
        void Borrar(Genero d);
        void Editar(Genero d);
        public bool existe(Genero d);
        int GetCantidad(Func<Genero, bool>? filtro = null);
        List<Genero> GetLista();
        Genero? GetGeneroPorNombre(string nombre);
    }
}

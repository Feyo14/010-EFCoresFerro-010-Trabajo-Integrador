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
    public interface IServicioMarca
    {
        void Agregar(Marca d);
        void Borrar(Marca d);
        void Editar(Marca d);
        public bool existe(Marca d);
        int GetCantidad(Func<Marca, bool>? filtro = null);
        List<Marca> GetLista();
        Marca? GetMarcaPorNombre(string nombre);


    }
}

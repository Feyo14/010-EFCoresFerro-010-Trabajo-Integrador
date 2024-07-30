using EFCore3.Entidades;
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
    public interface IServicioDeporte
    {
        void Agregar(Deporte d);
        void Borrar(Deporte d);
        void Editar(Deporte d);
        public bool existe(Deporte d);
        int GetCantidad(Func<Deporte, bool>? filtro = null);
        List<Deporte> GetLista();
        Deporte? GetDeportePorNombre(string nombre);
    }
}

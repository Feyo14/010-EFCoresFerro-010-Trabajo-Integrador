using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Datos.Repositorio
{
    public interface IDeporteRep
    {
        // void Agregar(Planta planta);
        // void Editar(Planta planta);
        //   void Borrar(Planta planta);
        List<Deporte> GetLista();
        int GetCantidad(Func<Deporte, bool>? filtro = null);
        Deporte? GetDeportePorNombre(string nombre);

        void Agregar(Deporte d);
        void Borrar(Deporte d);
        void Editar(Deporte d);
        public bool existe(Deporte d);

    }
}

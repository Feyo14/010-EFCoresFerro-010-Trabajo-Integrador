using EFCoreFerro2.Entidades.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFerro2.Datos.Repositorio
{
    public interface IMarcaRepo
    {
        // void Agregar(Planta planta);
        // void Editar(Planta planta);
        //   void Borrar(Planta planta);
      
        int GetCantidad(Func<Marca, bool>? filtro = null);
        List<Marca> GetLista();
        Marca? GetMarcaPorNombre(string nombre);

        void Agregar(Marca g);
        void Borrar(Marca g);
        void Editar(Marca g);
        public bool existe(Marca d);

    }
}

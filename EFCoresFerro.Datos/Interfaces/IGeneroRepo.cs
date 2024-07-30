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
    public interface IGeneroRepo
    {
        // void Agregar(Planta planta);
        // void Editar(Planta planta);
        //   void Borrar(Planta planta);
        List<Genero> GetLista();
        int GetCantidad(Func<Genero, bool>? filtro = null);
        Genero? GetGeneroPorNombre(string nombre);

        void Agregar(Genero g);
        void Borrar(Genero g);
        void Editar(Genero g);
        public bool existe(Genero d);


    }
}

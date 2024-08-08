﻿

using EFCore3.Entidades;
using EFCoreFerro2.Datos;

namespace EFCore3.DATOS.Interfaces
{
    public interface IRepositorioShoeSize
    {
        List<ShoeSize> GetLista();
        void Agregar(ShoeSize shoesize);
        void Borrar(ShoeSize shoeSize);
        void Editar(ShoeSize shoeSize);
        ShoeSize? GetShoeSizePorId(int id);
        public bool existe(ShoeSize d);

    }
}

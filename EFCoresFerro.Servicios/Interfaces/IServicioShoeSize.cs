﻿





using EFCore3.Entidades;

namespace EFCore3.Servicios.Interfaces
{
    public interface IServicioShoeSize
    {
        List<ShoeSize> GetLista();
        void Agregar(ShoeSize shoe);
        void Borrar(ShoeSize shoe);
        void Editar(ShoeSize shoe);
        ShoeSize? GetShoeSizePorId(int id);
        public bool existe(ShoeSize d);
    }
}

﻿

using EFCore3.Entidades;
using EFCoreFerro2.Entidades.Dto;

namespace EFCoresFerro.GUI.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case Brand marca:
                    r.Cells[0].Value = marca.BrandName;
            break;
                case Sports deporte:
                    r.Cells[0].Value = deporte.SportName;
                    break;
                case Genre genero:
                    r.Cells[0].Value = genero.GenreName;
                    break;
                case ZapatillalistDto z:
                    r.Cells[0].Value=z.NombreZapatilla;
                    r.Cells[1].Value = z.Marcan;
                    r.Cells[2].Value=z.Generon;
                    r.Cells[3].Value = z.Deporten;
                    r.Cells[4].Value = z.Precion.ToString("C");
                    break;
               
              
                case Colors color:
                    r.Cells[0].Value = color.ColorName;
                    break;
              
                case Shoes shoe:
                    r.Cells[0].Value = shoe.brand.BrandName;
                    r.Cells[1].Value = shoe.sport.SportName;
                    r.Cells[2].Value = shoe.genre.GenreName;
                    r.Cells[3].Value = shoe.Model;
                    r.Cells[4].Value = shoe.Descripcion;
                    r.Cells[5].Value = shoe.Price.ToString("C");
                    //  r.Cells[0].Value = shoe.Model;

                    break;
                case ShoeSize shoe:
                    r.Cells[0].Value = shoe.Shoe.Descripcion;
                    r.Cells[1].Value = shoe.Size.sizeNumber;
                    r.Cells[2].Value = shoe.QuantityInStock.ToString("C");
                
                    break;

                default:
                    break;

            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

    }
}

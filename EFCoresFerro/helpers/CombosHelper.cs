using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System;
using Size = EFCore3.Entidades.Size;


namespace EFCoresFerro.GUI.Helpers
{
    public static class CombosHelper
    {
        public static void CargarCombosPaginas(int pageCount, ref ComboBox cbo)
        {
            cbo.Items.Clear();
            for (int page = 1; page <= pageCount; page++)
            {
                cbo.Items.Add(page.ToString());
            }
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboMarcas( ref ToolStripComboBox cbo)
        {
            var servicio = new ServicioBrands();

            var lista = servicio.GetLista();
            var defaultmarca = new Brand
            {
                BrandName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultmarca);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Brand marca in lista)
            {
                cbo.Items.Add(marca.BrandName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        public static void cargarComboGenero(ref ToolStripComboBox cbo)
        {
            var servicio = new ServicioGenre();

            var lista = servicio.GetLista();
            var defaultgenero = new Genre
            {
                GenreName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultgenero);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Genre g in lista)
            {
                cbo.Items.Add(g.GenreName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        internal static void CargarComboDeporte(ref ToolStripComboBox cbo)
        {
            var servicio = new ServicioSports();

            var lista = servicio.GetLista();
            var defaultdeporte = new Sports
            {
                SportName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultdeporte);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Sports d in lista)
            {
                cbo.Items.Add(d.SportName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }
        public static void CargarComboMarcaBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioBrands>();
            var lista = servicio.GetLista();
            var defaultmarca = new Brand
            {
                BrandName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultmarca);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Brand b in lista)
            {
                cbo.Items.Add(b.BrandName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboGeneroBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioGenre>();
            var lista = servicio.GetLista();
            var defaultgenero = new Genre
            {
                GenreName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultgenero);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Genre b in lista)
            {
                cbo.Items.Add(b.GenreName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboDeporteBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioSports>();
            var lista = servicio.GetLista();
            var defaultdeporte = new Sports
            {
                SportName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultdeporte);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Sports b in lista)
            {
                cbo.Items.Add(b.SportName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboBrands(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioBrands>();
            var lista = servicio.GetLista();
            var defaultbrand = new Brand
            {
                BrandName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultbrand);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Brand b in lista)
            {
                cbo.Items.Add(b.BrandName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboGenre(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioGenre>();
            var lista = servicio.GetLista();
            var defaultbrand = new Genre
            {
                GenreName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultbrand);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Genre b in lista)
            {
                cbo.Items.Add(b.GenreName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboSports(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioSports>();
            var lista = servicio.GetLista();
            var defaultbrand = new Sports
            {
                SportName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultbrand);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Sports b in lista)
            {
                cbo.Items.Add(b.SportName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboShoes(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioShoes>();
            var lista = servicio.GetLista();
            var defaultmodel = new Shoes
            {
                Descripcion = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultmodel);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Shoes b in lista)
            {
                cbo.Items.Add(b.Descripcion);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboSize(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioSize>();
            var lista = servicio.GetLista();
            var defaultsize = new Size
            {
                sizeNumber = 0
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultsize);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Size b in lista)
            {
                cbo.Items.Add(b.sizeNumber);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
    }

}

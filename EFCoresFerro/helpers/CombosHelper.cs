using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;
using Microsoft.Extensions.DependencyInjection;
using System;


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
            var servicio = new ServicioMarca();

            var lista = servicio.GetLista();
            var defaultmarca = new Marca
            {
                MarcaName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultmarca);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Marca marca in lista)
            {
                cbo.Items.Add(marca.MarcaName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        public static void cargarComboGenero(ref ToolStripComboBox cbo)
        {
            var servicio = new ServicioGenero();

            var lista = servicio.GetLista();
            var defaultgenero = new Genero
            {
                GeneroName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultgenero);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Genero g in lista)
            {
                cbo.Items.Add(g.GeneroName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        internal static void CargarComboDeporte(ref ToolStripComboBox cbo)
        {
            var servicio = new ServicioDeporte();

            var lista = servicio.GetLista();
            var defaultdeporte = new Deporte
            {
                DeporteName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultdeporte);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Deporte d in lista)
            {
                cbo.Items.Add(d.DeporteName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }
        public static void CargarComboMarcaBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioMarca>();
            var lista = servicio.GetLista();
            var defaultmarca = new Marca
            {
                MarcaName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultmarca);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Marca b in lista)
            {
                cbo.Items.Add(b.MarcaName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboGeneroBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioGenero>();
            var lista = servicio.GetLista();
            var defaultgenero = new Genero
            {
                GeneroName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultgenero);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Genero b in lista)
            {
                cbo.Items.Add(b.GeneroName);
            }

            // Seleccionar el primer elemento del ToolStripComboBox si hay elementos
            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;

            }
        }
        public static void CargarComboDeporteBox(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IServicioDeporte>();
            var lista = servicio.GetLista();
            var defaultdeporte = new Deporte
            {
                DeporteName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultdeporte);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Deporte b in lista)
            {
                cbo.Items.Add(b.DeporteName);
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
            var defaultbrand = new Brands
            {
                BrandName = "Seleccione"
            };
            cbo.Items.Clear();
            lista.Insert(0, defaultbrand);
            // Agregar los tipos de envases al ToolStripComboBox
            foreach (Brands b in lista)
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
    }

}

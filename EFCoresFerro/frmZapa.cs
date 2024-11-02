using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCore3Ferro.GUI;

using EFCoreFerro2.Entidades.Dto;
using EFCoreFerro2.GUI.Helpers;
using EFCoresFerro.GUI.Helpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFCoreFerro2.GUI
{
    public partial class frmZapa : Form
    {
        private readonly IServicioShoes _servicio;
        private List<ZapatillalistDto>? lista;
        private readonly IServiceProvider provider;
        //  private string? zapanombre = null;

        private Brand? TipoMarca = null;
        private Genre? TipoGenero = null;
        private Sports? TipoDeporte = null;
        //   private decimal? precio = null;
        private bool FilterOn = false;
        decimal max = 0;
        decimal min = 0;
        private int pageCount;
        private int pageSize = 2;
        private int pageNum = 0;
        private int recordCount;
        /*
        public frmZapa()
        {
            InitializeComponent();
            _servicio = new ServicioZapatilla();
        }
        */
        public frmZapa(IServicioShoes? servicioZapatilla, IServiceProvider serviceProvider)
        {
            _servicio = servicioZapatilla;
            provider = serviceProvider;
            InitializeComponent();

        }

        private void frmZapa_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarcas(ref ComboMarca);
            CombosHelper.cargarComboGenero(ref ComboGenero);
            CombosHelper.CargarComboDeporte(ref ComboDeporte);

            RecargarGrillDeTodasLasZapatillas();
        }
        private void MostrarDatosEnGrilla()
        {
            // Mostrar los datos en la grilla
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var item in lista)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, item);
                    GridHelper.AgregarFila(r, dgvDatos);
                }
            }
        }
        private void RecargarGrillDeTodasLasZapatillas()
        {
            try
            {
                recordCount = _servicio.GetCantidad(null, TipoMarca, TipoGenero, TipoDeporte, max, min);
                pageCount = FormHelper.CalcularPaginas(recordCount, pageSize);
                txtCantidadRegistros.Text = pageCount.ToString();
                CombosHelper.CargarCombosPaginas(pageCount, ref cboPaginas);

                // Obtener la lista paginada ordenada y filtrada por defecto (sin orden ni filtro)
                lista = _servicio.GetListaPaginadaOrdenadaFiltradaporCombos(pageNum, pageSize, TipoMarca, TipoGenero, TipoDeporte, max, min);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void cb(object sender, EventArgs e)
        {
            // Cambiar a la página seleccionada
            pageNum = cboPaginas.SelectedIndex;

        }
        private void tcboTiposDeEnvases_Click(object sender, EventArgs e)
        {

        }

        private void ComboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (ComboMarca.SelectedIndex > 0)
            {
                FilterOn = true;
                var servicio = new ServicioBrands();
                TipoMarca = servicio?
                    .GetPorName(ComboMarca.Text);

                // Definir el filtro
                Func<Shoes, bool> filtro =
                    p => p.brand == TipoMarca;

                // Obtener la cantidad de registros después de aplicar el filtro
                recordCount = _servicio.GetCantidad(filtro);

                // Recalcular el número de páginas
                pageCount = FormHelper
                    .CalcularPaginas(recordCount, pageSize);

                // Actualizar el texto del cuadro de texto de cantidad de registros
                txtCantidadRegistros.Text = pageCount.ToString();

                // Recargar el combo de páginas
                CombosHelper.CargarCombosPaginas(pageCount,
                    ref cboPaginas);

                // Obtener la lista paginada ordenada y filtrada
                lista = _servicio
                    .GetListaPaginadaOrdenadaFiltradaporCombos(pageNum,
                    pageSize, TipoMarca, TipoGenero, TipoDeporte, max, min
                    );
                RecargarGrillDeTodasLasZapatillas();
                //   tsbFiltrar.Image = Resources.filter_intense_40px;
                tsbFiltrar.BackColor = Color.DarkGray;
                //  tsbFiltrar.Enabled = false;
            }
            else
            {
                TipoMarca = null;
            }
            RecargarGrillDeTodasLasZapatillas();
            pageNum = 0;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > pageCount - 1) { pageNum = pageCount - 1; }
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = pageCount - 1;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void ActualizarListaPaginada()
        {
            // Actualizar la lista paginada según la página actual y tamaño de página
            lista = _servicio
                .GetListaPaginadaOrdenadaFiltradaporCombos(pageNum, pageSize, TipoMarca, TipoGenero, TipoDeporte, max, min
                );
            MostrarDatosEnGrilla();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {

            FilterOn = false;
            tsbFiltrar.Enabled = true;
            RecargarGrillDeTodasLasZapatillas();
            //   tsbFiltrar.Image = Resources.filter_40px;
            tsbFiltrar.BackColor = SystemColors.Control;
        }

        private void ComboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboGenero.SelectedIndex > 0)
            {
                FilterOn = true;
                var servicio = new ServicioGenre();
                TipoGenero = servicio?
                    .GetPorName(ComboGenero.Text);

                // Definir el filtro
                Func<Shoes, bool> filtro =
                    p => p.genre == TipoGenero;

                // Obtener la cantidad de registros después de aplicar el filtro
                recordCount = _servicio.GetCantidad(filtro);

                // Recalcular el número de páginas
                pageCount = FormHelper
                    .CalcularPaginas(recordCount, pageSize);

                // Actualizar el texto del cuadro de texto de cantidad de registros
                txtCantidadRegistros.Text = pageCount.ToString();

                // Recargar el combo de páginas
                CombosHelper.CargarCombosPaginas(pageCount,
                    ref cboPaginas);

                // Obtener la lista paginada ordenada y filtrada
                lista = _servicio
                    .GetListaPaginadaOrdenadaFiltradaporCombos(pageNum,
                    pageSize, TipoMarca, TipoGenero, TipoDeporte, max, min
                    );
                RecargarGrillDeTodasLasZapatillas();

                //   tsbFiltrar.Image = Resources.filter_intense_40px;
                tsbFiltrar.BackColor = Color.DarkGray;
                //  tsbFiltrar.Enabled = false;
            }
            else
            {
                TipoGenero = null;
            }


            RecargarGrillDeTodasLasZapatillas();
            pageNum = 0;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();

        }

        private void ComboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboDeporte.SelectedIndex > 0)
            {
                FilterOn = true;
                var servicio = new ServicioSports();
                TipoDeporte = servicio?
                    .GetPorName(ComboDeporte.Text);

                // Definir el filtro
                Func<Shoes, bool> filtro =
                    p => p.sport == TipoDeporte;

                // Obtener la cantidad de registros después de aplicar el filtro
                recordCount = _servicio.GetCantidad(filtro);

                // Recalcular el número de páginas
                pageCount = FormHelper
                    .CalcularPaginas(recordCount, pageSize);

                // Actualizar el texto del cuadro de texto de cantidad de registros
                txtCantidadRegistros.Text = pageCount.ToString();

                // Recargar el combo de páginas
                CombosHelper.CargarCombosPaginas(pageCount,
                    ref cboPaginas);

                // Obtener la lista paginada ordenada y filtrada
                lista = _servicio
                    .GetListaPaginadaOrdenadaFiltradaporCombos(pageNum,
                    pageSize, TipoMarca, TipoGenero, TipoDeporte, max, min
                    );
                RecargarGrillDeTodasLasZapatillas();

                //   tsbFiltrar.Image = Resources.filter_intense_40px;
                tsbFiltrar.BackColor = Color.DarkGray;
                //   tsbFiltrar.Enabled = false;
            }
            else
            {
                TipoDeporte = null;
            }
            RecargarGrillDeTodasLasZapatillas();
            pageNum = 0;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ComboMarca.SelectedIndex = 0;
            ComboGenero.SelectedIndex = 0;
            ComboDeporte.SelectedIndex = 0;

            TipoMarca = null;
            TipoGenero = null;
            TipoDeporte = null;
            FilterOn = false;
            tsbFiltrar.Enabled = true;
            RecargarGrillDeTodasLasZapatillas();
            //   tsbFiltrar.Image = Resources.filter_40px;
            tsbFiltrar.BackColor = SystemColors.Control;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmZapaAE frm = new frmZapaAE(provider);
            DialogResult df = frm.ShowDialog(this);
            if (df == DialogResult.Cancel) { return; }
            try
            {
                Shoes g = frm.GetZapa();

                if (!_servicio.existe(g))
                {

                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, g);
                    GridHelper.AgregarFila(r, dgvDatos);
                    _servicio.Agregar(g);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro Duplicado ",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RecargarGrillDeTodasLasZapatillas();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error Seleccione",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                var r = dgvDatos.SelectedRows[0];
                ZapatillalistDto zz = (ZapatillalistDto)r.Tag;
                Shoes z = new Shoes();
                z.ShoeId = zz.ZapatillaId;


                if (!_servicio.existe(z))
                {

                    var zapatilla = _servicio.GetShoePorId(z.ShoeId);
                    DialogResult dr = MessageBox.Show($"desea borrar la zapatilla {zapatilla.Descripcion} seleccionado?",
                "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        _servicio.Borrar(zapatilla);
                        MessageBox.Show("Registro Borrado Satisfactoriamente",
                                "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarGrillDeTodasLasZapatillas();
                    }
                }
                else
                {
                    MessageBox.Show("Zapatilla existente!!!", "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { return; }
            var r = dgvDatos.SelectedRows[0];
            ZapatillalistDto zapadt = (ZapatillalistDto)r.Tag;
            Shoes s = new Shoes();
            s = _servicio.GetShoePorId(zapadt.ZapatillaId);
            s.sport = new Sports();
            s.genre = new Genre();
            s.brand = new Brand();

            s.sport.SportName = zapadt.Deporten;
            s.genre.GenreName = zapadt.Generon;
            s.brand.BrandName = zapadt.Marcan;

            frmZapaAE frm = new frmZapaAE(provider)
            { Text = "Editar Zapatilla" };
            frm.SetZapa(s);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    s = frm.GetZapa();
                    if (!_servicio.existe(s))
                    {
                        _servicio.Editar(s);
                        MessageBox.Show("Registro Agregado!!!", "update",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Zapatilla existente!!!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            RecargarGrillDeTodasLasZapatillas();
        }


        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void filtrarEntre2PreciosToolSt_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtmin.Text, out decimal f) || txtmin.Text == null)
            {
                errorProvider1.SetError(txtmin.Control, "precio invalido");
                min = 0;
            }
            else
            {
                min = decimal.Parse(txtmin.Text);

            }

            if (!decimal.TryParse(txtMax.Text, out decimal x) || txtMax.Text == null)
            {
                errorProvider1.SetError(txtMax.Control, "precio invalido");
                max = 0;
            }
            else
            {
                max = decimal.Parse(txtMax.Text);
            }
            RecargarGrillDeTodasLasZapatillas();
            pageNum = 0;
            ActualizarListaPaginada();
        }

        private void txtmin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmZapa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TsbPrecios_Click(object sender, EventArgs e)
        {
            txtmin.Text = "";
            txtMax.Text = "";
            max = 0;
            min = 0;
            RecargarGrillDeTodasLasZapatillas();
            pageNum = 0;
            ActualizarListaPaginada();
            errorProvider1.Clear();
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNum = cboPaginas.SelectedIndex;
            ActualizarListaPaginada();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
    


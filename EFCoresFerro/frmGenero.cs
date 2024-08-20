using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3Ferro.GUI;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;
using EFCoresFerro.GUI.Helpers;

namespace EFCoresFerro.Windows
{
    public partial class frmGenero : Form
    {
        private readonly IServicioGenero _servicio;
        private List<Genero> lista;
        public frmGenero(IServicioGenero servicio)
        {
            _servicio = servicio;
            InitializeComponent();
        }

        public frmGenero(IServicioGenero? servicio, IServiceProvider serviceProvider)
        {
            _servicio = servicio;
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dataGridView1);
            foreach (var item in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dataGridView1);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dataGridView1);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmGeneroAE frm = new frmGeneroAE(_servicio) { Text = "agregar Genero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Genero g = frm.GetGenero();
                if (!_servicio.existe(g))
                {
                    _servicio.Agregar(g);
                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, g);
                    GridHelper.AgregarFila(r, dataGridView1);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Genero existente!!!", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error Seleccione",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                var r = dataGridView1.SelectedRows[0];
                Genero genero = (Genero)r.Tag;
                var generos = _servicio.GetGeneroPorNombre(genero.GeneroName);
                DialogResult dr = MessageBox.Show($"desea borrar el {genero.GeneroName} seleccionado?",
                 "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    _servicio.Borrar(genero);
                    MessageBox.Show("Registro Borrado Satisfactoriamente",
                            "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RecargarGrilla();
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) { return; }
            var r = dataGridView1.SelectedRows[0];
            Genero genero = (Genero)r.Tag;
            var generos = _servicio.GetGeneroPorNombre(genero.GeneroName);
            frmGeneroAE frm = new frmGeneroAE(_servicio)
            { Text = "Editar Genero" };
            frm.SetGenero(generos);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    generos = frm.GetGenero();
                    if (!_servicio.existe(generos))
                    {
                        _servicio.Agregar(generos);
                        MessageBox.Show("Registro Agregado!!!", "update",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Genero existente!!!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            RecargarGrilla();

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

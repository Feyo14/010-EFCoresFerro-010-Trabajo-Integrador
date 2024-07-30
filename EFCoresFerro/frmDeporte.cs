using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3Ferro.GUI;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;
using EFCoresFerro.GUI.Helpers;

namespace EFCoresFerro.Windows
{
    public partial class frmDeporte : Form
    {
        private readonly IServicioDeporte _servicio;
        private List<Deporte> lista;
        public frmDeporte(IServicioDeporte servicio)
        {
            _servicio = servicio;
            InitializeComponent();
        }



        private void frmDeporte_Load(object sender, EventArgs e)
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

            frmDeporteAE frm = new frmDeporteAE(_servicio) { Text = "agregar Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Deporte d = frm.GetDeporte();
                if (!_servicio.existe(d))
                {
                    _servicio.Agregar(d);
                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, d);
                    GridHelper.AgregarFila(r, dataGridView1);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                Deporte d = (Deporte)r.Tag;
                var brands = _servicio.GetDeportePorNombre(d.DeporteName);
                _servicio.Borrar(d);
                MessageBox.Show("Registro Borrado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) { return; }
            var r = dataGridView1.SelectedRows[0];
            Deporte deporte = (Deporte)r.Tag;
            var d = _servicio.GetDeportePorNombre(deporte.DeporteName);
            frmDeporteAE frm = new frmDeporteAE(_servicio)
            { Text = "Editar Deporte" };
            frm.SetDeporte(d);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    d = frm.GetDeporte();
                    if (!_servicio.existe(d))
                    {
                        _servicio.Agregar(d);

                    }
                    else
                    {
                        MessageBox.Show("Deporte existente!!!", "Error",
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

using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3Ferro.GUI;
using EFCoresFerro.GUI.Helpers;

namespace EFCore3Ferro
{
    public partial class frmColors : Form
    {
        private readonly IServicioColors servicio;
        private List<Colors> lista;
        public frmColors(IServicioColors serv)
        {
            servicio = serv;
            InitializeComponent();
        }
        private void frmColors_Load(object sender, EventArgs e)
        {
            RecargarGrilla();

        }
        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmColorsAE frm = new frmColorsAE(servicio) { Text = "agregar Color" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Colors g = frm.GetColor();
                if (!servicio.existe(g))
                {
                    servicio.Agregar(g);
                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, g);
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
                Colors brand = (Colors)r.Tag;
                var brands = servicio.GetColorsPorId(brand.ColorId);
                servicio.Borrar(brands);
                MessageBox.Show("Registro Borrado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) { return; }
            var r = dataGridView1.SelectedRows[0];
            Colors brand = (Colors)r.Tag;
            var brands = servicio.GetColorsPorId(brand.ColorId);
            frmColorsAE frm = new frmColorsAE(servicio)
            { Text = "Editar Color" };
            frm.SetColor(brands);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    brands = frm.GetColor();
                    if (!servicio.existe(brands))
                    {
                        servicio.Agregar(brands);

                    }
                    else
                    {
                        MessageBox.Show("Color existente!!!", "Error",
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

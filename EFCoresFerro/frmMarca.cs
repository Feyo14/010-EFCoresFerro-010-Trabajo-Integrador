using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoresFerro.GUI.Helpers;

namespace EFCoresFerro.Windows
{
    public partial class frmMarca : Form
    {
        private readonly IServicioBrands _servicio;
        private List<Brand> lista;
        public frmMarca(IServicioBrands? servicio)
        {
            _servicio = servicio;
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
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
            frmMarcaAE frm = new frmMarcaAE(_servicio) { Text = "agregar Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Brand m = frm.GetMarca();
                if (!_servicio.existe(m))
                {
                    _servicio.Agregar(m);
                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, m);
                    GridHelper.AgregarFila(r, dataGridView1);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Marca existente!!!", "Error",
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
                Brand marca = (Brand)r.Tag;
                var brands = _servicio.GetPorName(marca.BrandName);
                DialogResult dr = MessageBox.Show($"desea borrar el {brands.BrandName} seleccionado?",
                 "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    _servicio.Borrar(marca);
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
            Brand brand = (Brand)r.Tag;
            var brands = _servicio.GetPorName(brand.BrandName);
            frmMarcaAE frm = new frmMarcaAE(_servicio)
            { Text = "Editar Marca" };
            frm.SetMarca(brands);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    brands = frm.GetMarca();
                    if (!_servicio.existe(brands))
                    {
                        _servicio.Agregar(brands);
                        MessageBox.Show("Registro Agregado!!!", "update",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Marca existente!!!", "Error",
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

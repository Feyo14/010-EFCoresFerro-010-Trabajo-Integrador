using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3Ferro.GUI;
using EFCoreFerro.Services.Services;
using EFCoresFerro.GUI.Helpers;

namespace EFCore3Ferro
{
    public partial class frmBrands : Form
    {
        private readonly IServicioBrands serviciobrands;
        private List<Brand> lista;


        public frmBrands(IServicioBrands? s)
        {

            serviciobrands = s;
            InitializeComponent();

        }

        private void frmbrands_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                lista = serviciobrands.GetLista();
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
            frmBrandsAE frm = new frmBrandsAE(serviciobrands) { Text = "agregar Brand" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Brand brand = frm.GetBrand();
                if (!serviciobrands.existe(brand))
                {
                    serviciobrands.Agregar(brand);
                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, brand);
                    GridHelper.AgregarFila(r, dataGridView1);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Brand existente!!!", "Error",
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
                Brand brand = (Brand)r.Tag;
                var brands = serviciobrands.GetBrandsPorId(brand.BrandId);
                DialogResult dr = MessageBox.Show($"desea borrar el {brands.BrandName} seleccionado?",
                   "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr==DialogResult.Yes)
                {
                    serviciobrands.Borrar(brands);
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
            var brands = serviciobrands.GetBrandsPorId(brand.BrandId);
            frmBrandsAE frm = new frmBrandsAE(serviciobrands)
            { Text = "Editar Brand" };
            frm.SetBrand(brands);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    brands = frm.GetBrand();
                    if (!serviciobrands.existe(brands))
                    {
                        serviciobrands.Agregar(brands);
                        MessageBox.Show("Registro Agregado!!!", "update",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        brands = brand;
                        MessageBox.Show("Brand existente!!!", "Error",
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

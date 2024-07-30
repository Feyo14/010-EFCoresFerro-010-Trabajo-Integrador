using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;
using EFCoresFerro.GUI.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore3Ferro.GUI
{
    public partial class frmZapaAE : Form
    {
        private Zapatilla zapatilla;
        private Genero genero = new Genero();
        private Deporte deporte = new Deporte();
        private Marca marca = new Marca();
        private readonly IServiceProvider Iserviceprovider;
        //   private readonly ServiceProvider serviceprovider;

        public frmZapaAE(IServiceProvider serv)
        {
            Iserviceprovider = serv;
            InitializeComponent();

        }
        public Zapatilla GetZapa()
        {
            return zapatilla;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (zapatilla == null)
                {
                    zapatilla = new Zapatilla();
                }


                zapatilla.Marca = marca;
                zapatilla.Genero = genero;
                zapatilla.Deporte = deporte;
                zapatilla.DeporteId = deporte.DeporteId;
                zapatilla.GeneroId = genero.GeneroId;
                zapatilla.MarcaId = marca.MarcaId;
                zapatilla.NombreZapatilla = txtdescripcion.Text;
                zapatilla.Price = decimal.Parse(txtprecio.Text);

                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
           
            if (string.IsNullOrEmpty(txtdescripcion.Text))
            {
                valid = false;
                errorProvider1.SetError(txtdescripcion, "descripcion Invalida");
            }
            if (string.IsNullOrEmpty(txtprecio.Text))
            {
                valid = false;
                errorProvider1.SetError(txtprecio, "Precio Invalido");
            }
            if (cboMarca.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboMarca, "seleccione brand");
            }
            if (cboGenero.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboGenero, "seleccione Genre");
            }
            if (cboDeporte.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboDeporte, "seleccione sport");
            }
            if (!decimal.TryParse(txtprecio.Text, out decimal f))
            {
                valid = false;
                errorProvider1.SetError(txtprecio, "precio invalido (con letras)");
            }
            return valid;
        }
        public void SetZapa(Zapatilla zapa)
        {
            this.zapatilla = zapa;
        }

        private void frmShoesAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboMarcaBox(Iserviceprovider, ref cboMarca);
            CombosHelper.CargarComboGeneroBox(Iserviceprovider, ref cboGenero);
            CombosHelper.CargarComboDeporteBox(Iserviceprovider, ref cboDeporte);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (zapatilla != null)
            {
                txtdescripcion.Text = zapatilla.NombreZapatilla.ToString();
                txtprecio.Text = zapatilla.Price.ToString();
                genero = zapatilla.Genero;
                deporte = zapatilla.Deporte;
                marca = zapatilla.Marca;
                cboMarca.SelectedItem = zapatilla.Marca.MarcaName;
                cboGenero.SelectedItem = zapatilla.Genero.GeneroName;
                cboDeporte.SelectedItem = zapatilla.Deporte.DeporteName;
            }
        }

        private void cboBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex > 0)
            {
                var serv = new ServicioMarca();
                marca = serv.GetMarcaPorNombre((string)cboMarca.SelectedItem);

            }
            else
            {
                marca = null;
            }
        }

        private void cboSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > 0)
            {
                var serv = new ServicioDeporte();
                deporte = serv.GetDeportePorNombre((string)cboDeporte.SelectedItem);
            }
            else
            {
                deporte = null;
            }
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenero.SelectedIndex > 0)
            {
                var serv = new ServicioGenero();
                genero = serv.GetGeneroPorNombre((string)cboGenero.SelectedItem);
            }
            else
            {
                genero = null;
            }

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}

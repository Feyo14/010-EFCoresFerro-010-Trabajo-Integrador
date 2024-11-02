using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCoresFerro.GUI.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore3Ferro.GUI
{
    public partial class frmZapaAE : Form
    {
        private Shoes zapatilla;
        private Genre genero = new Genre();
        private Sports deporte = new Sports();
        private Brand marca = new Brand();
        private readonly IServiceProvider Iserviceprovider;
        //   private readonly ServiceProvider serviceprovider;

        public frmZapaAE(IServiceProvider serv)
        {
            Iserviceprovider = serv;
            InitializeComponent();

        }
        public Shoes GetZapa()
        {
            return zapatilla;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (zapatilla == null)
                {
                    zapatilla = new Shoes();
                }


                zapatilla.brand = marca;
                zapatilla.genre = genero;
                zapatilla.sport = deporte;
                zapatilla.SportId = deporte.SportId;
                zapatilla.GenreId = genero.GenreId;
                zapatilla.BrandId = marca.BrandId;
                zapatilla.Descripcion = txtdescripcion.Text;
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
        public void SetZapa(Shoes zapa)
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
                txtdescripcion.Text = zapatilla.Descripcion.ToString();
                txtprecio.Text = zapatilla.Price.ToString();
                genero = zapatilla.genre;
                deporte = zapatilla.sport;
                marca = zapatilla.brand;
                cboMarca.SelectedItem = zapatilla.brand.BrandName;
                cboGenero.SelectedItem = zapatilla.genre.GenreName;
                cboDeporte.SelectedItem = zapatilla.sport.SportName;
            }
        }

        private void cboBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex > 0)
            {
                var serv = new ServicioBrands();
                marca = serv.GetPorName((string)cboMarca.SelectedItem);

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
                var serv = new ServicioSports();
                deporte = serv.GetPorName((string)cboDeporte.SelectedItem);
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
                var serv = new ServicioGenre();
                genero = serv.GetPorName((string)cboGenero.SelectedItem);
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

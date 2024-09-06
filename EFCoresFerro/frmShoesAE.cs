using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCoresFerro.GUI.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore3Ferro.GUI
{
    public partial class frmShoesAE : Form
    {
        private Shoes shoes;
        private Genre genre = new Genre();
        private Sports sports = new Sports();
        private Brand brands = new Brand();
        private readonly IServiceProvider Iserviceprovider;
        //   private readonly ServiceProvider serviceprovider;

        public frmShoesAE(IServiceProvider serv)
        {
            Iserviceprovider = serv;
            InitializeComponent();

        }



        public Shoes GetShoe()
        {
            return shoes;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (shoes == null)
                {
                    shoes = new Shoes();
                }


                shoes.brand = brands;
                shoes.genre = genre;
                shoes.sport = sports;
                shoes.SportId = sports.SportId;
                shoes.GenreId = genre.GenreId;
                shoes.BrandId = brands.BrandId;
                shoes.Descripcion = txtdescripcion.Text;
                shoes.Model = txtmodel.Text;
                shoes.Price = decimal.Parse(txtprecio.Text);

                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtmodel.Text))
            {
                valid = false;
                errorProvider1.SetError(txtmodel, "Modelo Invalido");
            }
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
            if (cboBrands.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboBrands, "seleccione brand");
            }
            if (cboGenre.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboGenre, "seleccione Genre");
            }
            if (cboSports.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboSports, "seleccione sport");
            }
            if (!decimal.TryParse(txtprecio.Text, out decimal f))
            {
                valid = false;
                errorProvider1.SetError(txtprecio, "precio invalido (con letras)");
            }
            return valid;
        }
        public void SetShoe(Shoes shoes)
        {
            this.shoes = shoes;
        }

        private void frmShoesAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboBrands(Iserviceprovider, ref cboBrands);
            CombosHelper.CargarComboGenre(Iserviceprovider, ref cboGenre);
            CombosHelper.CargarComboSports(Iserviceprovider, ref cboSports);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (shoes != null)
            {
                txtmodel.Text = shoes.Model.ToString();
                txtdescripcion.Text = shoes.Descripcion.ToString();
                txtprecio.Text = shoes.Price.ToString();
                genre = shoes.genre;
                sports = shoes.sport;
                brands = shoes.brand;
                cboBrands.SelectedItem = shoes.brand.BrandName;
                cboGenre.SelectedItem = shoes.genre.GenreName;
                cboSports.SelectedItem = shoes.sport.SportName;
            }
        }

        private void cboBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBrands.SelectedIndex > 0)
            {
                var serv = new ServicioBrands();
                brands = serv.GetPorName((string)cboBrands.SelectedItem);

            }
            else
            {
                brands = null;
            }
        }

        private void cboSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSports.SelectedIndex > 0)
            {
                var serv = new ServicioSports();
                sports = serv.GetPorName((string)cboSports.SelectedItem);
            }
            else
            {
                sports = null;
            }
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenre.SelectedIndex > 0)
            {
                var serv = new ServicioGenre();
                genre = serv.GetPorName((string)cboGenre.SelectedItem);
            }
            else
            {
                genre = null;
            }

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}

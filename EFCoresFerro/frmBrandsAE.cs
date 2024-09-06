using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCore3Ferro.GUI
{
    public partial class frmBrandsAE : Form
    {
        private Brand Brand;
        public frmBrandsAE(IServicioBrands service)
        {
            InitializeComponent();
        }

        public Brand GetBrand()
        {
            return Brand;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Brand == null)
                {
                    Brand = new Brand();
                }
                Brand.BrandName = textBox1.Text;
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                valid = false;
                errorProvider1.SetError(textBox1, "Nombre Brand Invalido");
            }
            return valid;
        }
        public void SetBrand(Brand? brand)
        {
            this.Brand = brand;
        }

        private void frmBrandsAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Brand != null)
            {
                textBox1.Text = Brand.BrandName;
            }
        }
    }
}

using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCore3Ferro.GUI
{
    public partial class frmColorsAE : Form
    {
        private Colors colors;
        public frmColorsAE(IServicioColors service)
        {
            InitializeComponent();
        }

        public Colors GetColor()
        {
            return colors;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (colors == null)
                {
                    colors = new Colors();
                }
                colors.ColorName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Nombre del Color Invalido");
            }
            return valid;
        }
        public void SetColor(Colors? gen)
        {
            this.colors = gen;
        }

        private void frmColorsAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (colors != null)
            {
                textBox1.Text = colors.ColorName;
            }
        }
    }
}

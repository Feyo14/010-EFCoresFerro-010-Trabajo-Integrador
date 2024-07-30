using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;

namespace EFCoresFerro.Windows
{
    public partial class frmGeneroAE : Form
    {
        private Genero g;
        private readonly IServicioGenero servicio;
        public frmGeneroAE(IServicioGenero service)
        {
            servicio = service;
            InitializeComponent();
        }

        public Genero GetGenero()
        {
            return g;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (g == null)
                {
                   g= new Genero();
                }
                g.GeneroName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Genero Invalido");
            }
            return valid;
        }
        public void SetGenero(Genero? gen)
        {
            this.g = gen;
        }

        private void frmGeneroAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (g != null)
            {
                textBox1.Text = g.GeneroName;
            }
        }
    }
}

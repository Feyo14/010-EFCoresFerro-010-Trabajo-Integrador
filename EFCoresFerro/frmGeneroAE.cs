using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCoresFerro.Windows
{
    public partial class frmGeneroAE : Form
    {
        private Genre g;
        private readonly IServicioGenre servicio;
        public frmGeneroAE(IServicioGenre service)
        {
            servicio = service;
            InitializeComponent();
        }

        public Genre GetGenero()
        {
            return g;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (g == null)
                {
                   g= new Genre();
                }
                g.GenreName = textBox1.Text;
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
        public void SetGenero(Genre? gen)
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
                textBox1.Text = g.GenreName;
            }
        }
    }
}

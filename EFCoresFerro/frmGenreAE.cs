using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCore3Ferro.GUI
{
    public partial class frmGenreAE : Form
    {
        private Genre Genre;
        public frmGenreAE(IServicioGenre service)
        {
            InitializeComponent();
        }

        public Genre GetGenre()
        {
            return Genre;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Genre == null)
                {
                    Genre = new Genre();
                }
                Genre.GenreName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Nombre Genre Invalido");
            }
            return valid;
        }
        public void SetGenre(Genre? gen)
        {
            this.Genre = gen;
        }

        private void frmGenreAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Genre != null)
            {
                textBox1.Text = Genre.GenreName;
            }
        }
    }
}

using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCore3Ferro.GUI
{
    public partial class frmSportsAE : Form
    {
        private Sports sports;
        public frmSportsAE(IServicioSports service)
        {
            InitializeComponent();
        }

        public Sports GetSports()
        {
            return sports;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (sports == null)
                {
                    sports = new Sports();
                }
                sports.SportName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Nombre del Sport Invalido");
            }
            return valid;
        }
        public void SetSport(Sports? gen)
        {
            this.sports = gen;
        }

        private void frmSportsAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sports != null)
            {
                textBox1.Text = sports.SportName;
            }
        }
    }
}

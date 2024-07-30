using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;

namespace EFCoresFerro.Windows
{
    public partial class frmDeporteAE : Form
    {
        private Deporte d;
        private readonly IServicioDeporte servicio;
        public frmDeporteAE(IServicioDeporte service)
        {
            servicio = service;
            InitializeComponent();
        }

        public Deporte GetDeporte()
        {
            return d;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (d == null)
                {
                    d = new Deporte();
                }
                d.DeporteName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Deporte Invalido");
            }
            return valid;
        }
        public void SetDeporte(Deporte? gen)
        {
            this.d = gen;
        }

        private void frmDeporteAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (d != null)
            {
                textBox1.Text = d.DeporteName;
            }
        }
    }
}

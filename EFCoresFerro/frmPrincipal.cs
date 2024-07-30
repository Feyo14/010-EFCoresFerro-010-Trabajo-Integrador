using EFCore3.Servicios.Interfaces;
using EFCore3Ferro;
using EFCore3Ferro.GUI;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.GUI;
using EFCoresFerro;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoresFerro.Windows
{
    public partial class frmPrincipal : Form
    {

        private readonly IServiceProvider _serviceProvider;
        public frmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBrands frm = new frmBrands(_serviceProvider.GetService<IServicioBrands>());
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmColors frm = new frmColors(_serviceProvider.GetService<IServicioColors>());
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGe_r frm = new frmGe_r(_serviceProvider.GetService<IServicioGenre>());
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSports frm = new frmSports(_serviceProvider.GetService<IServicioSports>());
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmShoes frm = new frmShoes(_serviceProvider.GetService<IServicioShoes>(), _serviceProvider);
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmZapa frm = new frmZapa(_serviceProvider.GetService<IServicioZapatilla>(), _serviceProvider);
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca(_serviceProvider.GetService<IServicioMarca>());
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmGenero frm = new frmGenero(_serviceProvider.GetService<IServicioGenero>(), _serviceProvider);
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmDeporte frm = new frmDeporte(_serviceProvider.GetService<IServicioDeporte>());
            frm.ShowDialog();
        }
    }
}

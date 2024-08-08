using EFCore3.DATOS.Interfaces;
using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3.Servicios.Servicios;
using EFCoresFerro.Datos;
using EFCoresFerro.GUI.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using Size = EFCore3.Entidades.Size;

namespace EFCore3Ferro.GUI
{
    public partial class frmShoeSizeAE : Form
    {
        private ShoeSize shoes;
        private EFCore3.Entidades.Size size = new Size();
        private Shoes shoe = new Shoes();
        private readonly IServiceProvider Iserviceprovider;
           private readonly EFCoresDbContext contex;
        public frmShoeSizeAE(IServiceProvider serv)
        {
            Iserviceprovider = serv;
            InitializeComponent();
            
        }
        public void SetShoe(ShoeSize shoes)
        {

            this.shoes = shoes;
        }


        public ShoeSize GetShoe()
        {
            return shoes;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (shoes == null)
                {
                    shoes = new ShoeSize();
                }

                shoes.SizeId = size.SizeId;
                shoes.ShoeId = shoe.ShoeId;
                shoes.Size = size;
                shoes.Shoe = shoe;
                shoes.QuantityInStock = int.Parse(txtQuantityInStock.Text);


                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtQuantityInStock.Text))
            {
                valid = false;
                errorProvider1.SetError(txtQuantityInStock, "QuantityInStock Invalido");
            }

            if (cboShoe.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboShoe, "seleccione Shoe");
            }

            if (cboSize.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboSize, "seleccione Size");
            }
            if (!decimal.TryParse(txtQuantityInStock.Text, out decimal f))
            {
                valid = false;
                errorProvider1.SetError(txtQuantityInStock, "QuantityInStock invalido (con letras)");
            }
            return valid;
        }
    

        private void frmShoeSizeAE_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboShoes(Iserviceprovider, ref cboShoe);
            CombosHelper.CargarComboSize(Iserviceprovider, ref cboSize);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (shoes != null)
            {
                txtQuantityInStock.Text = shoes.QuantityInStock.ToString();
                cboShoe.SelectedItem = shoes.Shoe.Descripcion;
                cboSize.SelectedItem = shoes.Size.sizeNumber;
                shoe = shoes.Shoe;
                size = shoes.Size;
              
            }
        }



        private void cboShoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShoe.SelectedIndex > 0)
            {
                var sev = Iserviceprovider.GetService<IServicioShoes>();
                shoe=sev.GetPorName((string)cboShoe.SelectedItem);
            }
            else
            {
                shoe = null;
            }
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSize.SelectedIndex > 0)
            {
                var serv = new ServicioSize();
                size = serv.GetPorName((decimal)cboSize.SelectedItem);
            }
            else
            {
               // size = null;
            }

        }


    }
}

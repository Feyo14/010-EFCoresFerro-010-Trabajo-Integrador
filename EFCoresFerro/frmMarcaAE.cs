﻿using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;

namespace EFCoresFerro.Windows
{
    public partial class frmMarcaAE : Form
    {
        private Brand Marca;
        private readonly IServicioBrands servicio;
        public frmMarcaAE(IServicioBrands service)
        {
            servicio = service;
            InitializeComponent();
        }

        public Brand GetMarca()
        {
            return Marca;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Marca == null)
                {
                    Marca = new Brand();
                }
                Marca.BrandName = textBox1.Text;
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
                errorProvider1.SetError(textBox1, "Marca Invalida");
            }
            return valid;
        }
        public void SetMarca(Brand? gen)
        {
            this.Marca = gen;
        }

        private void frmMarcaAE_Load(object sender, EventArgs e)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Marca != null)
            {
                textBox1.Text = Marca.BrandName;
            }
        }
    }
}

using EFCore3.Entidades;
using EFCore3.Servicios.Interfaces;
using EFCore3Ferro.GUI;
using EFCoreFerro2.Datos;
using EFCoresFerro.GUI.Helpers;
using EFCoresFerro.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore3Ferro
{
    public partial class frmShoes : Form
    {
        private readonly IServicioShoes _servicio;
        private readonly IServiceProvider serviceProvider;

        private List<Shoes> lista;
        //#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        /*   public frmShoes(IServicioShoes serv,ServiceProvider _serviceProvider)
   #pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
           {
               serviceProvider = _serviceProvider;
               _servicio = serv;
               //    _serviceProvider = serviceProvider;
               InitializeComponent();

           }

        corregir las entidades y no se pueden borrar los registros relaciona
        dos agregarle un nuevo campo a la base y tildaro como desactivo.
           */
        public frmShoes(IServicioShoes? serv, IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
            _servicio = serv;
            InitializeComponent();

        }

        private void frmShoes_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }





        private void RecargarGrilla()
        {
            try
            {
                lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dataGridView1);
            foreach (var item in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dataGridView1);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dataGridView1);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmShoesAE frm = new frmShoesAE(serviceProvider);
            DialogResult df = frm.ShowDialog(this);
            if (df == DialogResult.Cancel) { return; }
            try
            {
                Shoes g = frm.GetShoe();

                if (!_servicio.existe(g))
                {

                    var r = GridHelper.ConstruirFila(dataGridView1);
                    GridHelper.SetearFila(r, g);
                    GridHelper.AgregarFila(r, dataGridView1);
                    _servicio.Agregar(g);
                    MessageBox.Show("Registro Agregado Satisfactoriamente",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro Duplicado ",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            RecargarGrilla();

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error Seleccione",
                        "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                var r = dataGridView1.SelectedRows[0];
                Shoes ss = (Shoes)r.Tag;
                var s = _servicio.GetShoePorId(ss.ShoeId);
                if (_servicio.existeShoeSize(ss.ShoeId))
                {
                  DialogResult dr=  MessageBox.Show("Alto el Shoe que quiere borrar se encuentra en la tabla Shoe Size desea continuar y borrar todo?",
                       "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 

                    if (dr == DialogResult.Yes)
                    {
                        _servicio.Borrar(ss);
                        MessageBox.Show("Registro Borrado Satisfactoriamente de ambas tablas",
                                "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(dr==DialogResult.No)
                    {
                        MessageBox.Show("el Registro no fue borrado",
                           "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"desea borrar el {ss.Descripcion} seleccionado?",
                 "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        _servicio.Borrar(ss);
                        MessageBox.Show("Registro Borrado Satisfactoriamente",
                               "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                RecargarGrilla();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) { return; }
            var r = dataGridView1.SelectedRows[0];
            Shoes shoe = (Shoes)r.Tag;
            var s = _servicio.GetShoePorId(shoe.ShoeId);
            frmShoesAE frm = new frmShoesAE(serviceProvider)
            { Text = "Editar Shoe" };
            frm.SetShoe(shoe);
            DialogResult dr = frm.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel)
            { return; }
            else
            {


                try
                {
                    s = frm.GetShoe();
                    if (!_servicio.existe(s))
                    {
                        _servicio.Editar(s);
                        MessageBox.Show("Registro Agregado!!!", "update",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Shoe existente!!!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            RecargarGrilla();

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

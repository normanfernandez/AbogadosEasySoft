using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbogadosEasySoft
{
    public partial class Frm_CapturaDeClientes : Form
    {
               Imagen img = new Imagen();

        public Frm_CapturaDeClientes()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        public Cliente Clienteseleccionado { get; set; }

        private void Frm_CapturaDeClientes_Load(object sender, EventArgs e)
        {


            img.abrirConexion();
            TxtAbono.Text = ("0");
            TxtCostoTotServ.Text = ("0");

        }


        // Comienza el codigo de guardar datos//
        private void BtnGuardar_Click(object sender, EventArgs e)
        { 


            MessageBox.Show(img.insertarImagen(pictureBox1.Text, pictureBox1));
            Cliente Cliente = new Cliente();
            Cliente.Codigo = TxtCodigo.Text;
            Cliente.NoCedula = TxtNoCedula.Text;
            Cliente.NoPasaporte = TxtNoPasaporte.Text;
            Cliente.Nombres = TxtNombre.Text;
            Cliente.Apellidos = TxtApellido.Text;
            Cliente.Apodo = TxtApodo.Text;
            Cliente.EMail = TxtEmail.Text;
            Cliente.Contacto = TxtContacto.Text;
            Cliente.Direccion = TxtDireccion.Text;
            Cliente.Provincia = TxtProvincia.Text;
            Cliente.Municipio = TxtMunicipio.Text;
            Cliente.TelCasa = TxtTelCasa.Text;
            Cliente.TelTrabajo = TxtTelTrabajo.Text;
            Cliente.Cel = TxtCel.Text;
            Cliente.EstadoCivil = TxtEstadoCivil.Text;
            Cliente.Empleado = TxtEmpleo.Text;
            Cliente.DirecEmpleo = TxtDireccionEmpleo.Text;
            Cliente.ServioArealizar = TxtServARealizar.Text;
            Cliente.CostoTotServ = Convert.ToInt32(TxtCostoTotServ.Text);
            Cliente.Abono = Convert.ToInt32(TxtAbono.Text);
            Cliente.FiscaliaCorresp = TxtFiscaliaCorresp.Text;
            Cliente.ProcuradorCorresp = TxtProcuCorr.Text;
            Cliente.Notas = TxtNotas.Text;
            Cliente.FechaActual = maskedTexFechAct.Text;



            int resultado = ClienteDal.AgregarCl(Cliente);


            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        // Termina el codigo de guardar datos//


                
        private void BtnImgCedPasap_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }

        }
        
        




        private void timer1_Tick(object sender, EventArgs e)
        {
            maskedTexFechAct.Text = DateTime.Now.ToShortDateString();
        }

        private void maskedTexFechAct_Validated(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClienteDal.BuscarCli(MskNoCedula.Text, TxtNoPasaporte.Text);


            if (dataGridView1.SelectedRows.Count == 1)            
            {
                Int32 Id_Cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Clienteseleccionado = ClienteDal.ObtenerCli(Id_Cliente);


                      
            }

            if (this.Clienteseleccionado != null) 
            {
                TxtNoCedula.Text = this.Clienteseleccionado.NoCedula;
                TxtNoPasaporte.Enabled = true;
                BtnImgCedPasap.Enabled = true;
                TxtCodigo.Enabled = true;
                TxtNombre.Enabled = true;
                TxtApellido.Enabled = true;
                TxtApodo.Enabled = true;
                TxtEmail.Enabled = true;
                TxtContacto.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtProvincia.Enabled = true;
                TxtMunicipio.Enabled = true;
                TxtTelCasa.Enabled = true;
                TxtTelTrabajo.Enabled = true;
                TxtCel.Enabled = true;
                TxtEstadoCivil.Enabled = true;
                TxtEmpleo.Enabled = true;
                TxtDireccionEmpleo.Enabled = true;
                TxtServARealizar.Enabled = true;
                TxtCostoTotServ.Enabled = true;
                TxtAbono.Enabled = true;
                TxtFiscaliaCorresp.Enabled = true;
                TxtProcuCorr.Enabled = true;
                TxtNotas.Enabled = true;
                BtnGuardar.Enabled = true;
            }



            if (dataGridView1.SelectedRows.Count == 0)

            {
                TxtNoCedula.Enabled = true;
                TxtNoPasaporte.Enabled = true;
                BtnImgCedPasap.Enabled = true;
                TxtCodigo.Enabled = true;
                TxtNombre.Enabled = true;
                TxtApellido.Enabled = true;
                TxtApodo.Enabled = true;
                TxtEmail.Enabled = true;
                TxtContacto.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtProvincia.Enabled = true;
                TxtMunicipio.Enabled = true;
                TxtTelCasa.Enabled = true;
                TxtTelTrabajo.Enabled = true;
                TxtCel.Enabled = true;
                TxtEstadoCivil.Enabled = true;
                TxtEmpleo.Enabled = true;
                TxtDireccionEmpleo.Enabled = true;
                TxtServARealizar.Enabled = true;
                TxtCostoTotServ.Enabled = true;
                TxtAbono.Enabled = true;
                TxtFiscaliaCorresp.Enabled = true;
                TxtProcuCorr.Enabled = true;
                TxtNotas.Enabled = true;
                BtnGuardar.Enabled = true;

            }
        }

                
    }
}

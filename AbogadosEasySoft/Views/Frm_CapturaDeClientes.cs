using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_CapturaDeClientes : Form
    {
        private DAO.Repository<Models.cliente> ClienteDAO = new DAO.Repository<Models.cliente>();


        public Frm_CapturaDeClientes()
        {
            InitializeComponent();
        }

        private void Frm_CapturaDeClientes_Load(object sender, EventArgs e)
        {
            TxtAbono.Text = ("0");
            TxtCostoTotServ.Text = ("0");

        }


        // Comienza el codigo de guardar datos//
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Revisa si los campos son validos
            if (!this.CheckFields())
                return;

            //Se guardan los datos del cliente en una variable
            Models.cliente cliente = new Models.cliente
            {
                abono = decimal.Parse(TxtAbono.Text),
                apellido = TxtApellido.Text,
                cedula = TxtNoCedula.Text.NullIfWhiteSpace(),
                celular = TxtCel.Text,
                contacto = TxtContacto.Text.NullIfWhiteSpace(),
                costo_servicio = decimal.Parse(TxtCostoTotServ.Text),
                direccion = TxtDireccion.Text,
                direccion_empleo = TxtDireccionEmpleo.Text.NullIfWhiteSpace(),
                email = TxtEmail.Text.NullIfWhiteSpace(),
                empleado = TxtEmpleo.Text.NullIfWhiteSpace(),
                estado_civil = TxtEstadoCivil.Text,
                fecha_actual = DateTime.Now,
                fiscalia = TxtFiscaliaCorresp.Text.NullIfWhiteSpace(),
                img = Utils.PictureBinary.GetBinary(openFileDialog1.FileName),
                municipio = TxtMunicipio.Text.NullIfWhiteSpace(),
                nombre = TxtNombre.Text,
                notas = TxtNotas.Text.NullIfWhiteSpace(),
                pasaporte = txtPasaporte.Text.NullIfWhiteSpace(),
                procurador = TxtProcuCorr.Text.NullIfWhiteSpace(),
                provincia = TxtProvincia.Text,
                segundo_apellido = txtSegundoApellido.Text.NullIfWhiteSpace(),
                segundo_nombre = txtSegundoNombre.Text.NullIfWhiteSpace(),
                servicio = TxtServARealizar.Text,
                telefono = TxtTelCasa.Text.NullIfWhiteSpace()

            };

            ClienteDAO.Insert(cliente);
            ClienteDAO.SaveAll();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //se busca si la cédula o pasapporte ya están en la base de datos
            if (MskNoCedula.MaskFull)
                TxtNoCedula.Text = MskNoCedula.Text.Replace("-","");
            else if (!string.IsNullOrEmpty(txtPasaporte.Text))
                TxtNoPasaporte.Text = txtPasaporte.Text;
            else
            {
                MessageBox.Show(this, "Campos de búsqueda vacíos!");
                return;
            }

            string cedula_trimmed = MskNoCedula.Text.Replace("-","");

            Models.cliente cliente= ClienteDAO.SelectSingle(c => c.cedula == cedula_trimmed 
                || c.pasaporte == txtPasaporte.Text);
            if (cliente != null)
                MessageBox.Show(this, "Ya existe ese cliente!");
            else
            {

                #region Se habilitan los controles
                TextBox[] list = { TxtNombre, txtSegundoNombre,TxtApellido, txtSegundoApellido,
                    TxtApodo, TxtEmail, TxtContacto, TxtDireccion, TxtProvincia,
                    TxtMunicipio, TxtTelCasa, TxtCel,
                    TxtEstadoCivil, TxtEmpleo, TxtDireccionEmpleo, TxtServARealizar,
                    TxtCostoTotServ, TxtAbono, TxtFiscaliaCorresp, TxtProcuCorr, TxtNotas};

                foreach (var t in list)
                    t.Enabled = true;

                BtnImgCedPasap.Enabled = true;

                BtnGuardar.Enabled = true;

                #endregion
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validaciones

        private bool CheckFields()
        {
            ePvacio.Clear();
            bool validation = true;

            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                ePvacio.SetError(this.TxtNombre, "El nombre no puede estar vacío!");
                validation = false;
            }
            if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                ePvacio.SetError(this.TxtApellido, "El apellido no puede estar vacío!");
                validation = false;
            }
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                ePvacio.SetError(this.TxtDireccion, "La direccion no puede estar vacía!");
                validation = false;
            }
            if (string.IsNullOrEmpty(TxtProvincia.Text))
            {
                ePvacio.SetError(this.TxtProvincia, "La provincia no puede estar vacía!");
                validation = false;
            }
            if (string.IsNullOrEmpty(TxtMunicipio.Text))
            {
                ePvacio.SetError(this.TxtMunicipio, "El municipio no puede estar vacío!");
                validation = false;
            }
            if (string.IsNullOrEmpty(TxtEstadoCivil.Text))
            {
                ePvacio.SetError(this.TxtEstadoCivil, "El estado civil no puede estar vacío!");
                validation = false;
            }

            if (string.IsNullOrEmpty(TxtServARealizar.Text))
            {
                ePvacio.SetError(this.TxtServARealizar, "El estado civil no puede estar vacío!");
                validation = false;
            }

            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                ePvacio.SetError(this.pictureBox1, "Se debe de elegir una foto");
                validation = false;
            }

            string extension = Path.GetExtension(openFileDialog1.FileName);

            if (extension != ".jpg" && extension != ".jpeg")
            {
                ePvacio.SetError(this.pictureBox1, "Debe ser una imagen en formato JPG.");
                validation = false;
            }

            decimal dummy;

            if (string.IsNullOrEmpty(TxtCostoTotServ.Text))
            {
                ePvacio.SetError(this.TxtCostoTotServ, "El costo del servicio no puede estar vacío!");
                validation = false;
            }
            if (!decimal.TryParse(TxtCostoTotServ.Text, out dummy))
            {
                ePvacio.SetError(this.TxtCostoTotServ, "Cantidad no válida");
                validation = false;
            }

            return validation;
        }
        #endregion
    }

    //Se le agrega una erxtensión a los string que los devuelve null si están vacíos
    public static class Extensions
    {
        public static string NullIfWhiteSpace(this string value)
        {
            if (String.IsNullOrWhiteSpace(value)) { return null; }
            return value;
        }
    }
}

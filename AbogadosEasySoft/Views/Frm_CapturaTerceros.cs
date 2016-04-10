using System;
using System.Windows.Forms;
using AbogadosEasySoft.DAO;
using AbogadosEasySoft.Models;
using AbogadosEasySoft.Utils;
using System.IO;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_CapturaTerceros : Form
    {
        private tercero Tercero;
        private Repository<tercero> TerceroDAO = new Repository<tercero>();

        public Frm_CapturaTerceros()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Revisa si los campos son validos
            if (!this.CheckFields())
                return;

            //Se guardan los datos del cliente en una variable
            tercero Tercero = new tercero
            {
                apellido = TxtApellido.Text,
                cedula = TxtNoCedula.Text.NullIfWhiteSpace(),
                celular = TxtCel.Text,
                contacto = TxtContacto.Text.NullIfWhiteSpace(),
                direccion = TxtDireccion.Text,
                direccion_empleo = TxtDireccionEmpleo.Text.NullIfWhiteSpace(),
                email = TxtEmail.Text.NullIfWhiteSpace(),
                empleado = TxtEmpleo.Text.NullIfWhiteSpace(),
                estado_civil = TxtEstadoCivil.Text,
                fecha_actual = DateTime.Now,
                img = Utils.PictureBinary.GetBinary(openFileDialog1.FileName),
                municipio = TxtMunicipio.Text.NullIfWhiteSpace(),
                nombre = TxtNombre.Text,
                notas = TxtNotas.Text.NullIfWhiteSpace(),
                pasaporte = txtPasaporte.Text.NullIfWhiteSpace(),
                provincia = TxtProvincia.Text,
                segundo_apellido = txtSegundoApellido.Text.NullIfWhiteSpace(),
                segundo_nombre = txtSegundoNombre.Text.NullIfWhiteSpace(),
                telefono = TxtTelCasa.Text.NullIfWhiteSpace()

            };

            TerceroDAO.Insert(Tercero);
            TerceroDAO.SaveAll();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //se busca si la cédula o pasapporte ya están en la base de datos
            if (MskNoCedula.MaskFull)
                TxtNoCedula.Text = MskNoCedula.Text.Replace("-", "");
            else if (!string.IsNullOrEmpty(txtPasaporte.Text))
                TxtNoPasaporte.Text = txtPasaporte.Text;
            else
            {
                MessageBox.Show(this, "Campos de búsqueda vacíos!");
                return;
            }

            string cedula_trimmed = MskNoCedula.Text.Replace("-", "");

            Tercero = TerceroDAO.SelectSingle(c => c.cedula == cedula_trimmed
                 || c.pasaporte == txtPasaporte.Text);
            if (Tercero != null)
                MessageBox.Show(this, "Ya existe ese tercero!");
            else
            {

                #region Se habilitan los controles
                TextBox[] list = { TxtNombre, txtSegundoNombre,TxtApellido, txtSegundoApellido,
                    TxtApodo, TxtEmail, TxtContacto, TxtDireccion, TxtProvincia,
                    TxtMunicipio, TxtTelCasa, TxtCel,
                    TxtEstadoCivil, TxtEmpleo, TxtDireccionEmpleo,
                    TxtNotas};

                foreach (var t in list)
                    t.Enabled = true;

                BtnImgCedPasap.Enabled = true;

                BtnGuardar.Enabled = true;

                #endregion
            }
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

            return validation;
        }
        #endregion

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
    }
}

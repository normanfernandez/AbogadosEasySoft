using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbogadosEasySoft.DAO;
using AbogadosEasySoft.Models;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_Alquiler : Form
    {
        private cliente Propietario;
        private tercero Inquilino;
        private tercero Gerente;
        private alquiler Alquiler;

        private Repository<cliente> PropietarioDAO = new Repository<cliente>();
        private Repository<tercero> InquilinoDAO = new Repository<tercero>();
        private Repository<tercero> GerenteDAO = new Repository<tercero>();
        private Repository<alquiler> AlquilerDAO = new Repository<alquiler>();


        public Frm_Alquiler()
        {
            InitializeComponent();
        }

        private void txtAlquilerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Enabled = false;
                Alquiler = AlquilerDAO.SelectSingle(a => a.id.ToString() == txtAlquilerId.Text);
            }

            if (Alquiler == null)
            {
                MessageBox.Show(this, "Alquiler no encontrado!");
                Gerente = null;
                Inquilino = null;
                Propietario = null;
                return;
            }

            btnGuardar.Enabled = true;

            Inquilino = InquilinoDAO.SelectSingle(i => i.id == Alquiler.inquilino_id);
            txtInquilinoNombre.Text = Inquilino?.nombre ?? "";
            txtInquilinoSegundoNombre.Text = Inquilino?.segundo_nombre ?? "";
            txtInquilinoApellido.Text = Inquilino?.apellido ?? "";
            txtInquilinoSegundoApellido.Text = Inquilino?.segundo_apellido ?? "";

            Propietario = PropietarioDAO.SelectSingle(p => p.id == Alquiler.propietario_id);
            txtPropietarioNombre.Text = Propietario?.nombre ?? "";
            txtPropietarioSegundoNombre.Text = Propietario?.segundo_nombre ?? "";
            txtPropietarioApellido.Text = Propietario?.apellido ?? "";
            txtPropietarioSegundoApellido.Text = Propietario?.segundo_apellido ?? "";

            Gerente = GerenteDAO.SelectSingle(g => g.id == Alquiler.gerente_id);
            txtGerenteNombre.Text = Gerente?.nombre ?? "";
            txtGerenteSegundoNombre.Text = Gerente?.segundo_nombre ?? "";
            txtGerenteApelido.Text = Gerente?.apellido ?? "";
            txtGerenteSegundoApellido.Text = Gerente?.segundo_apellido ?? "";

            txtCantidadDeposito.Text = Alquiler.cantidad_deposito.ToString();
            txtCiudad.Text = Alquiler.ciudad;
            txtComisionInicial.Text = Alquiler.comision_inicial.ToString();
            txtComisionMensual.Text = Alquiler.comision_mensual.ToString();
            txtDescripcionCompleta.Text = Alquiler.descripcion;
            txtTipoMobilaria.Text = Alquiler.mobilaria;
            txtPrecio.Text = Alquiler.precio.ToString();

        }

        private void txtPropietarioId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Propietario = PropietarioDAO.SelectSingle(p => p.id.ToString() == txtPropietarioId.Text);
                txtPropietarioNombre.Text = Propietario?.nombre ?? "";
                txtPropietarioSegundoNombre.Text = Propietario?.segundo_nombre ?? "";
                txtPropietarioApellido.Text = Propietario?.apellido ?? "";
                txtPropietarioSegundoApellido.Text = Propietario?.segundo_apellido ?? "";
            }
        }

        private void txtInquilinoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Inquilino = InquilinoDAO.SelectSingle(i => i.id.ToString() == txtInquilinoId.Text);
                txtInquilinoNombre.Text = Inquilino?.nombre ?? "";
                txtInquilinoSegundoNombre.Text = Inquilino?.segundo_nombre ?? "";
                txtInquilinoApellido.Text = Inquilino?.apellido ?? "";
                txtInquilinoSegundoApellido.Text = Inquilino?.segundo_apellido ?? "";
            }
        }

        private void txtGerenteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Gerente = GerenteDAO.SelectSingle(g => g.id.ToString() == txtGerenteId.Text);
                txtGerenteNombre.Text = Gerente?.nombre ?? "";
                txtGerenteSegundoNombre.Text = Gerente?.segundo_nombre ?? "";
                txtGerenteApelido.Text = Gerente?.apellido ?? "";
                txtGerenteSegundoApellido.Text = Gerente?.segundo_apellido ?? "";
            }
        }

        private void chbNota_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNota.Enabled = chbNota.Checked;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Gerente == null || Inquilino == null || Propietario == null)
            {
                MessageBox.Show(this, "Se deben de entrar a todas las personas referentes al alquiler!");
                return;
            }

            Alquiler = new alquiler
            {
                cantidad_deposito = decimal.Parse(txtCantidadDeposito.Text),
                ciudad = txtCiudad.Text,
                comision_inicial = decimal.Parse(txtComisionInicial.Text),
                comision_mensual = decimal.Parse(txtComisionMensual.Text),
                descripcion = txtDescripcionCompleta.Text,
                gerente_id = Gerente.id,
                inquilino_id = Inquilino.id,
                mobilaria = txtTipoMobilaria.Text,
                precio = decimal.Parse(txtPrecio.Text),
                propietario_id = Propietario.id,
            };

            AlquilerDAO.Insert(Alquiler);
            AlquilerDAO.SaveAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AlquilerDAO.SaveAll();
        }
    }
}

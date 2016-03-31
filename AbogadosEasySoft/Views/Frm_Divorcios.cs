using System;
using System.Windows.Forms;
using AbogadosEasySoft.DAO;
using AbogadosEasySoft.Models;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_Divorcios : Form
    {
        private Repository<cliente> ClienteDAO = new Repository<cliente>();
        private Repository<tercero> TerceroDAO = new Repository<tercero>();
        private Repository<divorcio> DivorcioDAO = new Repository<divorcio>();

        private cliente Cliente;
        private tercero Tercero;
        private divorcio Divorcio;

        public Frm_Divorcios()
        {
            InitializeComponent();
        }

        private void txtDemandanteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Cliente = ClienteDAO.SelectSingle(c =>
                    c.id.ToString() == txtDemandadoId.Text);

                txtDemandanteNombre.Text = Cliente?.nombre ?? "";
                txtDemandanteSegundoNombre.Text = Cliente?.segundo_nombre ?? "";
                txtDemandanteApellido.Text = Cliente?.apellido ?? "";
                txtDemandanteSegundoApellido.Text = Cliente?.segundo_apellido ?? "";
            }
        }

        private void txtDemandadoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Tercero = TerceroDAO.SelectSingle(t =>
                    t.id.ToString() == txtDemandadoId.Text);

                txtDemandadoNombre.Text = Tercero?.nombre ?? "";
                txtDemandadoSegundoNombre.Text = Tercero?.segundo_nombre ?? "";
                txtDemandadoApellido.Text = Tercero?.apellido ?? "";
                txtDemandadoSegundoApellido.Text = Tercero?.segundo_apellido ?? "";
            }
        }

        private void txtDivorcioId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Divorcio = DivorcioDAO.SelectSingle(d => 
                    d.id.ToString() == txtDivorcioId.Text);

                if (Divorcio == null)
                {
                    MessageBox.Show(this, "Divorcio no encontrado!");
                    Cliente = null;
                    Tercero = null;
                    btnGuardar.Enabled = false;
                    return;
                }

                btnGuardar.Enabled = true;

                Cliente = ClienteDAO.SelectSingle(c =>
                    c.id == Divorcio.demandante_id);

                Tercero = TerceroDAO.SelectSingle(t =>
                    t.id == Divorcio.demandado_id);

                txtDemandanteNombre.Text = Cliente?.nombre ?? "";
                txtDemandanteSegundoNombre.Text = Cliente?.segundo_nombre ?? "";
                txtDemandanteApellido.Text = Cliente?.apellido ?? "";
                txtDemandanteSegundoApellido.Text = Cliente?.segundo_apellido ?? "";

                txtDemandadoNombre.Text = Tercero?.nombre ?? "";
                txtDemandadoSegundoNombre.Text = Tercero?.segundo_nombre ?? "";
                txtDemandadoApellido.Text = Tercero?.apellido ?? "";
                txtDemandadoSegundoApellido.Text = Tercero?.segundo_apellido ?? "";

                txtJuez.Text = Divorcio.juez;
                txtTipo.Text = Divorcio.tipo;
                mskHonorarios.Text = Divorcio.honorarios.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Cliente == null || Tercero == null)
            {
                MessageBox.Show(this, "Cliente y/o Tercero no insertados");
                return;
            }

            Divorcio = new divorcio
            {
                juez = txtJuez.Text,
                tipo = txtTipo.Text,
                honorarios = decimal.Parse(mskHonorarios.Text),
                demandado_id = Tercero.id,
                demandante_id = Cliente.id
            };

            DivorcioDAO.Insert(Divorcio);
            DivorcioDAO.SaveAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DivorcioDAO.SaveAll();
        }
    }
}

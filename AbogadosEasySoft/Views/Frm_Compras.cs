using System;
using System.Windows.Forms;
using AbogadosEasySoft.DAO;
using AbogadosEasySoft.Models;

namespace AbogadosEasySoft.Views
{

    public partial class Frm_Compras : Form
    {

        private cliente Cliente;
        private tercero Tercero;
        private compra Compra;

        private Repository<cliente> ClienteDAO = new Repository<cliente>();
        private Repository<tercero> TerceroDAO = new Repository<tercero>();
        private Repository<compra> CompraDAO = new Repository<compra>();

        public Frm_Compras()
        {
            InitializeComponent();
        }

        private void txtCompraId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Enabled = false;

                Compra = CompraDAO.SelectSingle(c => c.id.ToString() == txtCompraId.Text);

                if (Compra == null)
                    return;

                btnGuardar.Enabled = true;

                Cliente = ClienteDAO.SelectSingle(c => c.id == Compra.comprador_id);
                txtCompradorNombre.Text = Cliente?.nombre ?? "";
                txtCompradorSegundoNombre.Text = Cliente?.segundo_nombre ?? "";
                txtCompradorApellido.Text = Cliente?.apellido ?? "";
                txtCompradorSegundoApellido.Text = Cliente?.segundo_apellido ?? "";

                Tercero = TerceroDAO.SelectSingle(t => t.id.ToString() == txtVendedorId.Text);
                txtVendedorNombre.Text = Tercero?.nombre ?? "";
                txtVendedorSegundoNombre.Text = Tercero?.segundo_nombre ?? "";
                txtVendedorApellido.Text = Tercero?.apellido ?? "";
                txtVendedorSegundoApellido.Text = Tercero?.segundo_apellido ?? "";

                txtCiudad.Text = Compra.ciudad;
                txtPrecio.Text = Compra.precio.ToString();
                txtDescripcionCompleta.Text = Compra.descripcion;
            }
        }

        private void txtCompradorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //Se llenan los campos los valores de la base de datos. Se poenen en blanco si son null
                Cliente = ClienteDAO.SelectSingle(c => c.id.ToString() == txtCompraId.Text);
                txtCompradorNombre.Text = Cliente?.nombre ?? "";
                txtCompradorSegundoNombre.Text = Cliente?.segundo_nombre ?? "";
                txtCompradorApellido.Text = Cliente?.apellido ?? "";
                txtCompradorSegundoApellido.Text = Cliente?.segundo_apellido ?? "";
            }
        }

        private void txtVendedorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //Se llenan los campos los valores de la base de datos. Se poenen en blanco si son null
                Tercero = TerceroDAO.SelectSingle(t => t.id.ToString() == txtVendedorId.Text);
                txtVendedorNombre.Text = Tercero?.nombre ?? "";
                txtVendedorSegundoNombre.Text = Tercero?.segundo_nombre ?? "";
                txtVendedorApellido.Text = Tercero?.apellido ?? "";
                txtVendedorSegundoApellido.Text = Tercero?.segundo_apellido ?? "";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if(Cliente == null || Tercero == null)
            {
                MessageBox.Show(this, "Cliente y/o Tercero no insertados");
                return;
            }

            Compra = new compra
            {
                ciudad = txtCiudad.Text,
                comprador_id = Cliente.id,
                descripcion = txtDescripcionCompleta.Text,
                precio = decimal.Parse(txtPrecio.Text),
                vendedor_id = Tercero.id,
                tipo_mobilaria = txtTipoMobilaria.Text
            };

            CompraDAO.Insert(Compra);
            CompraDAO.SaveAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CompraDAO.SaveAll();
        }
    }
}

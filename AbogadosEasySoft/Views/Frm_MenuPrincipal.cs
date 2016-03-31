using System;
using System.Windows.Forms;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_MenuPrincipal : Form
    {
        private static Models.user usuario = null;

        public Frm_MenuPrincipal(Models.user u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CapturaDeClientes pServicioClientes = new Frm_CapturaDeClientes();
            pServicioClientes.ShowDialog();

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ConsultaDeClientes pServicioClientes = new Frm_ConsultaDeClientes();
            pServicioClientes.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void capturasYConsultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoUsuario pMantenimientoUsuarios = new FrmMantenimientoUsuario();
            pMantenimientoUsuarios.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_ConsultaDeClientes pConsultarClientes = new Frm_ConsultaDeClientes();
            pConsultarClientes.ShowDialog();
        }

        private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CapturaTerceros form = new Frm_CapturaTerceros();
            form.ShowDialog();
        }

        private void divorciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Divorcios form = new Frm_Divorcios();
            form.ShowDialog();
        }

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alquiler form = new Frm_Alquiler();
            form.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Compras form = new Frm_Compras();
            form.ShowDialog();
        }
    }
}

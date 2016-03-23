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
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbogadosEasySoft.Views
{
    public partial class Frm_CapturaDeClientes : Form
    {

        public Frm_CapturaDeClientes()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Frm_CapturaDeClientes_Load(object sender, EventArgs e)
        {
            TxtAbono.Text = ("0");
            TxtCostoTotServ.Text = ("0");

        }


        // Comienza el codigo de guardar datos//
        private void BtnGuardar_Click(object sender, EventArgs e)
        { 

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
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

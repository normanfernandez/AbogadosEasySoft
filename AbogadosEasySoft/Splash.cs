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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 1000;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

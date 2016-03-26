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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Se detiene el timer, se esconde el splash y se inicia la vista del login
            this.timer.Stop();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AbogadosEasySoft.Views
{
    public partial class Login : Form
    {
        private int count = 1;
        private DAO.Repository<Models.user> UserDAO = new DAO.Repository<Models.user>();

        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                Models.user usuario = UserDAO.SelectSingle(u => u.username == TxtUsuario.Text 
                    && u.password == TxtContraseña.Text);

                if (usuario != null)
                {
                    Frm_MenuPrincipal menu = new Frm_MenuPrincipal(usuario);
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();
                    this.Hide();
                    return;
                }

                count++;
                MessageBox.Show(this, "Usuario o contraseña incorrectos!");
            }
            else
            {
                MessageBox.Show(this, "Cantidad de login excedidas!");
                Application.Exit();
            }
        }
    }
}
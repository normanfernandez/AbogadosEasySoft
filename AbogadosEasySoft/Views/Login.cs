using System;
using System.Windows.Forms;

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

        public void TryLogin()
        {
            if (count < 3)
            {
                //Busca el usuario donde coincidad el username con password
                Models.user usuario = UserDAO.SelectSingle(u => u.username == TxtUsuario.Text
                    && u.password == TxtContraseña.Text);

                if (usuario != null)
                {
                    //Se encontro un usuario que coincide
                    Frm_MenuPrincipal menu = new Frm_MenuPrincipal(usuario);
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();
                    this.Hide();
                    return;
                }

                //Se no encuentra el usuario y se agrega 1 al conteo
                count++;
                MessageBox.Show(this, "Usuario o contraseña incorrectos!");
            }
            else
            {
                //Se cierra el programa por excesos de login
                MessageBox.Show(this, "Cantidad de login excedidas!");
                Application.Exit();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Llama la funcion cuando se presiona la tecla enter en los textos
            if (e.KeyChar == 13)
                TryLogin();
        }
    }
}
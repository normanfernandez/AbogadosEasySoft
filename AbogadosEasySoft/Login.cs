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

namespace AbogadosEasySoft
{
    public partial class Login : Form
    {
        int cont = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                errorProvider1.SetError(TxtUsuario, "El Nombre De Usuario No Puede Estar En Blanco");
            }
            else errorProvider1.Clear();

            if (TxtContraseña.Text == "")
            {
                errorProvider1.SetError(TxtContraseña, "La Contraseña No Puede Estar En Blanco");

            }
            else errorProvider1.Clear();




            SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS; integrated security=True;database=BD_Abogados_Easy_Soft;");

            try
            {
                SqlCommand cmd = new SqlCommand("select user_Name, user_Password, user_Level from Usuarios where user_Name ='" + TxtUsuario.Text + "' and user_Password = '" + TxtContraseña.Text + "'", cn);

                cn.Open();
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Usuarios");

                DataRow dro;
                dro = ds.Tables["Usuarios"].Rows[0];

                if ((TxtUsuario.Text == dro["user_Name"].ToString()) & (TxtContraseña.Text == dro["user_Password"].ToString()))
                {


                    if ("1" == dro["user_Level"].ToString())
                    {


                        Frm_MenuPrincipal p = new Frm_MenuPrincipal();
                        p.Show();
                        this.Hide();

                    }

                    if ("2" == dro["user_Level"].ToString())
                    {


                        Frm_MenuCaja p = new Frm_MenuCaja();
                        p.Show();
                        this.Hide();

                    }
                    



                }

            }
            catch { MessageBox.Show("Error, Ingrese Datos Nuevamente"); }
            
            finally
            {
                                  
                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                        TxtUsuario.Focus();
                        cont++;

                        if (cont == 1)
                           // MessageBox.Show("Intenta de nuevo Primer Intento", "Fallaste!",
                            //MessageBoxButtons.OK, MessageBoxIcon.Error);


                        if (cont == 2)
                            MessageBox.Show("Intenta de nuevo Segundo Intento", "Fallaste!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    if (cont == 3)
                    {
                        MessageBox.Show("Se ha introducido la contraseña incorrecta 3 veces! \n\nEste programa se cerrara!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                cn.Close();
            }
        }
    }


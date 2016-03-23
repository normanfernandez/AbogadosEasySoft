using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AbogadosEasySoft
{
    class Imagen
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        public string abrirConexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=DESKTOP-4MUAPPO\SQLEXPRESS;Initial Catalog=BD_Abogados_Easy_Soft;Integrated Security=True");
                cn.Open();
                return "Conectado";
            }
            catch (Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        public string insertarImagen(string descripcion, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen";
            try
            {
                cmd = new SqlCommand("Insert into Cliente(img) values(@Imagen)", cn);
                cmd.Parameters.Add("@Imagen", SqlDbType.Image);


                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }


    }
}

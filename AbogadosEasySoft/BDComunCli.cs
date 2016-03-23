using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AbogadosEasySoft
{
    public class BDComunCli

    {
        public static SqlConnection ObtenerConeccionCl()
        {
            SqlConnection conncl = new SqlConnection(@"Data source=DESKTOP-4MUAPPO\SQLEXPRESS; initial catalog=BD_Abogados_Easy_Soft; Integrated Security=True");
            conncl.Open();

            return conncl;

        }
    }
}
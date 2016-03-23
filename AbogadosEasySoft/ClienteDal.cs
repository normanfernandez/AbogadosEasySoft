using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AbogadosEasySoft
{
    public class ClienteDal
    {
        public static int AgregarCl(Cliente PCliente)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComunCli.ObtenerConeccionCl())
            {
                //metodo para insertar en la base de datos//
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Cliente (Codigo, NoCedula, NoPasaporte, Nombres, Apellidos, Apodo, EMail, Contacto, Direccion, Provincia, Municipio, TelCasa, TelTrabajo, Cel, EstadoCivil, Empleado, DirecEmpleo, ServioArealizar, CostoTotServ, Abono, FiscaliaCorresp, ProcuradorCorresp, Notas, FechaActual) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}')",
                    PCliente.Codigo, PCliente.NoCedula, PCliente.NoPasaporte, PCliente.Nombres, PCliente.Apellidos, PCliente.Apodo, PCliente.EMail, PCliente.Contacto, PCliente.Direccion, PCliente.Provincia, PCliente.Municipio, PCliente.TelCasa, PCliente.TelTrabajo, PCliente.Cel, PCliente.EstadoCivil, PCliente.Empleado, PCliente.DirecEmpleo, PCliente.ServioArealizar, PCliente.CostoTotServ, PCliente.Abono, PCliente.FiscaliaCorresp, PCliente.ProcuradorCorresp, PCliente.Notas, PCliente.FechaActual), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();


            }
            return retorno;
        }

        //Aqui se termina el codigo de insertar//  
 
        
        //Aqui inicia codigo para consultar clientes por cedula o pasaporte// 

                public static List<Cliente> BuscarCli(String pNoCedula, String pNoPasaporte)
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = BDComunCli.ObtenerConeccionCl())
            {
                SqlCommand comando = new SqlCommand(String.Format(
                    "Select Id_Cliente, Codigo, NoCedula, NoPasaporte, Nombres, Apellidos, Apodo, EMail, Contacto, Direccion, Provincia, Municipio, TelCasa, TelTrabajo, Cel, EstadoCivil, Empleado, DirecEmpleo, ServioArealizar, CostoTotServ, Abono, FiscaliaCorresp, ProcuradorCorresp, Notas, FechaActual from Cliente where NoCedula  like '%{0}' and NoPasaporte like '%{1}'", pNoCedula, pNoPasaporte), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente pCliente = new Cliente();
                    pCliente.Id_Cliente = reader.GetInt32(0);
                    pCliente.Codigo = reader.GetString(1);
                    pCliente.NoCedula = reader.GetString(2);
                    pCliente.NoPasaporte = reader.GetString(3);
                    pCliente.Nombres = reader.GetString(4);
                    pCliente.Apellidos = reader.GetString(5);
                    pCliente.Apodo = reader.GetString(6);
                    pCliente.EMail = reader.GetString(7);
                    pCliente.Contacto = reader.GetString(8);
                    pCliente.Direccion = reader.GetString(9);
                    pCliente.Provincia = reader.GetString(10);
                    pCliente.Municipio = reader.GetString(11);
                    pCliente.TelCasa = reader.GetString(12);
                    pCliente.TelTrabajo = reader.GetString(13);
                    pCliente.Cel = reader.GetString(14);
                    pCliente.EstadoCivil = reader.GetString(15);
                    pCliente.Empleado = reader.GetString(16);
                    pCliente.DirecEmpleo = reader.GetString(17);
                    pCliente.ServioArealizar = reader.GetString(18);
                    pCliente.CostoTotServ = Convert.ToInt32(reader.GetInt32(19));
                    pCliente.Abono = Convert.ToInt32(reader.GetInt32(20));
                    pCliente.FiscaliaCorresp = reader.GetString(21);
                    pCliente.ProcuradorCorresp = reader.GetString(22);
                    pCliente.Notas = reader.GetString(23);
                    pCliente.FechaActual = reader.GetString(24);

                    Lista.Add(pCliente);


                }
                conexion.Close();
                return Lista;
                //Aqui termina codigo para consultar clientes por cedula o pasaporte// 
            }

        }

        // Comienza Codigo Para llenar los campos del formulario clientes //


                public static Cliente ObtenerCli(Int32 pId_Cliente)
                {

                    using (SqlConnection conexion = BDComunCli.ObtenerConeccionCl())
                    {
                        Cliente pCliente = new Cliente();
                        SqlCommand comando = new SqlCommand(string.Format(
                            "Select Id_Cliente, Codigo, NoCedula, NoPasaporte, Nombres, Apellidos, Apodo, EMail, Contacto, Direccion, Provincia, Municipio, TelCasa, TelTrabajo, Cel, EstadoCivil, Empleado, DirecEmpleo, ServioArealizar, CostoTotServ, Abono, FiscaliaCorresp, ProcuradorCorresp, Notas, FechaActual from Cliente where Id_Cliente={0}", pId_Cliente), conexion);

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            pCliente.Id_Cliente = reader.GetInt32(0);
                            pCliente.Codigo = reader.GetString(1);
                            pCliente.NoCedula = reader.GetString(2);
                            pCliente.NoPasaporte = reader.GetString(3);
                            pCliente.Nombres = reader.GetString(4);
                            pCliente.Apellidos = reader.GetString(5);
                            pCliente.Apodo = reader.GetString(6);
                            pCliente.EMail = reader.GetString(7);
                            pCliente.Contacto = reader.GetString(8);
                            pCliente.Direccion = reader.GetString(9);
                            pCliente.Provincia = reader.GetString(10);
                            pCliente.Municipio = reader.GetString(11);
                            pCliente.TelCasa = reader.GetString(12);
                            pCliente.TelTrabajo = reader.GetString(13);
                            pCliente.Cel = reader.GetString(14);
                            pCliente.EstadoCivil = reader.GetString(15);
                            pCliente.Empleado = reader.GetString(16);
                            pCliente.DirecEmpleo = reader.GetString(17);
                            pCliente.ServioArealizar = reader.GetString(18);
                            pCliente.CostoTotServ = Convert.ToInt32(reader.GetInt32(19));
                            pCliente.Abono = Convert.ToInt32(reader.GetInt32(20));
                            pCliente.FiscaliaCorresp = reader.GetString(21);
                            pCliente.ProcuradorCorresp = reader.GetString(22);
                            pCliente.Notas = reader.GetString(23);
                            pCliente.FechaActual = reader.GetString(24);



                        }
                        conexion.Close();
                        return pCliente;
                        // Termina Codigo Para llenar los campos del formulario clientes //
                    }

                }

         

    }
}
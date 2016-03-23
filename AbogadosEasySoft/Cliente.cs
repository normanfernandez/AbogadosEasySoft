using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbogadosEasySoft
{
    public class Cliente
    {
        public Int64 Id_Cliente { get; set; }
        public String Codigo { get; set; }
        public String NoCedula { get; set; }
        public String NoPasaporte { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Apodo { get; set; }
        public String EMail { get; set; }
        public String Contacto { get; set; }
        public String Direccion { get; set; }
        public String Provincia { get; set; }
        public String Municipio { get; set; }
        public String TelCasa { get; set; }
        public String TelTrabajo { get; set; }
        public String Cel { get; set; }
        public String EstadoCivil { get; set; }
        public String Empleado { get; set; }
        public String DirecEmpleo { get; set; }
        public String ServioArealizar { get; set; }
        public int CostoTotServ { get; set; }
        public int Abono { get; set; }
        public String FiscaliaCorresp { get; set; }
        public String ProcuradorCorresp { get; set; }
        public String Notas { get; set; }
        public String FechaActual { get; set; }

        public Cliente() { }

        public Cliente(Int64 pId_Cliente, String pCodigo, String pNoCedula, String pNoPasaporte, String pNombres, String pApellidos, String pApodo, String pEMail, String pContacto, String pDireccion, String pProvincia, String pMunicipio, String pTelCasa, String pTelTrabajo, String pCel, String pEstadoCivil, String pEmpleado, String pDirecEmpleo, String pServioArealizar, int pCostoTotServ, int pAbono, String pFiscaliaCorresp, String pProcuradorCorresp, String pNotas, String pFechaActual)

        {
            this.Id_Cliente = pId_Cliente;
            this.Codigo = pCodigo;
            this.NoCedula = pNoCedula;
            this.NoPasaporte = pNoPasaporte;
            this.Nombres = pNombres;
            this.Apellidos = pApellidos;
            this.Apodo = pApodo;
            this.EMail = pEMail;
            this.Contacto = pContacto;
            this.Direccion = pDireccion;
            this.Provincia = pProvincia;
            this.Municipio = pMunicipio;
            this.TelCasa = pTelCasa;
            this.TelTrabajo = pTelTrabajo;
            this.Cel = pCel;
            this.EstadoCivil = pEstadoCivil;
            this.Empleado = pEmpleado;
            this.DirecEmpleo = pDirecEmpleo;
            this.ServioArealizar = pServioArealizar;
            this.CostoTotServ = pCostoTotServ;
            this.Abono = pAbono;
            this.FiscaliaCorresp = pFiscaliaCorresp;
            this.ProcuradorCorresp = pProcuradorCorresp;
            this.Notas = pNotas;
            this.FechaActual = pFechaActual;

        
        
        }
    }
}

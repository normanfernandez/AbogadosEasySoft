using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbogadosEasySoft.Views;

namespace AbogadosEasySoft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            /*
            Parte que crea la base de datos si no existe usando un connection string y 
            el archivo de LINQ
            */
            string dbConnection = Properties.Settings.Default.AbogadosEasySoftConnectionString;
            AbogadosEasySoft.Models.AbogadosDataModelsDataContext db = new Models.AbogadosDataModelsDataContext(dbConnection);
            if (!db.DatabaseExists())
                db.CreateDatabase();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
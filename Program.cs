using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Batista.Views;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

            //variáveis globais do sistema
        
        public static string funcaoUsuario;
        public static string nomeUsuario;
        public static string chamadadizimistas;
        public static string membroDizimista;
        public static string idmembro;
      
        //variável usada nos relatórios de cultos
        public static string idCULTO;

        [STAThread]

       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());

        }
    }
}

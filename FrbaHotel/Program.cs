using FrbaHotel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrbaHotel.AbmHabitacion;
using System.Windows.Forms;
using FrbaHotel.AbmRegimen;
using FrbaHotel.CancelarReservaT;
using FrbaHotel.AbmCliente;


namespace FrbaHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          //Application.Run(new Form1());
            
          LoginForm frmLogin = new LoginForm();

           frmLogin.ShowDialog();

          if (frmLogin.DialogResult == DialogResult.OK)
                Application.Run(new PrincipalForm());
                  

        }
    }
}

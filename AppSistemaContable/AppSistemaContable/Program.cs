using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace AppSistemaContable
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2007 Green");

            Application.Run(new Form1());
            //Application.Run(new ActividadEconomica.frmPrincipalActividadEconómica());
            //Application.Run(new VentasRegistroVentas.frmNuevaVenta());

        }
    }
}
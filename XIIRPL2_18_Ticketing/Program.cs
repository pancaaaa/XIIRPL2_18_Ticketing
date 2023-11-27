using XIIRPL2_18_Ticketing.MasterForm;
using XIIRPL2_18_Ticketing.NewFolder;

namespace XIIRPL2_18_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin login = new Frmlogin();
            //Login.Show();

            // FormMaskapai FormMaskapai = new FormMaskapai();
            //   FormMaskapai.Show();


             FormMasterBandara formMasterBandara = new FormMasterBandara();
             formMasterBandara.Show(); 
 
           //  FormMasterKodePromo formMasterKodePromo = new FormMasterKodePromo();
           //  formMasterKodePromo.Show();
               Application.Run();

        }
    }
}
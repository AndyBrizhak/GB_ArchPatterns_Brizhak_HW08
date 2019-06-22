using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Controller;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Model;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MVCForm view = new MVCForm();
            IMod    mod = new Model.Model();
            IContr contr = new Controller.Controller(view,mod);
            Application.Run(view);
        }
    }
}

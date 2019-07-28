using System;
using System.Windows.Forms;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Controller;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Model;

// Дз к занятию 8 по курсу Паттерны на C# Брижак Андрей
//1. Используя шаблон MVC, разработать следующее приложение: на форме расположен textbox, listbox и button.
//После ввода текста в textbox введенная строка добавляется в коллекцию значений в модели,
//а затем добавленная строка отображается в listbox.

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

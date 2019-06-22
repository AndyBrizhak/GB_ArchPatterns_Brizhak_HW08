using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Controller;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.View
{
    public delegate void ViewDelegate<IView>(IView sender, ViewEvent e);

    public interface IView
    {
        event ViewDelegate<IView> AddStr;

        void SetContr(IContr contr);
    }
}

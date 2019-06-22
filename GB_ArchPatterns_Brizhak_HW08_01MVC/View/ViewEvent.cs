using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.View
{
    public class ViewEvent : EventArgs
    {
        public string _str;
        public ViewEvent(string Str)
        {
            _str = Str;
        }
    }
}

using System;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.View
{
    public class ViewEvent : EventArgs
    {
        public string _str;
        public ViewEvent(string str)
        {
            _str = str ?? throw new ArgumentNullException(nameof(str));
        }
    }
}

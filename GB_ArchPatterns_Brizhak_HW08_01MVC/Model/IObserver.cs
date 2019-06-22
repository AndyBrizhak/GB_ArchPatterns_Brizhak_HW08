using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
   public interface IObserver
   {
       void Change(IMod mod);
   }
}

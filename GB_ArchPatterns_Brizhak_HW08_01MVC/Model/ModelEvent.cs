﻿using System;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
    public delegate void ModDelegate<IMod>(IMod sender, ModelEvent e);

   public class ModelEvent : EventArgs
   {
       public string NewStr;
        public ModelEvent(string str)
        {
            NewStr = str;
        }
    }
}

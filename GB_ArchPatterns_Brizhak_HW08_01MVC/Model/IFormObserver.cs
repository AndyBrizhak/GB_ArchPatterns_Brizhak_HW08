﻿namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
    /// <summary>
    /// Интерфейс для создания Наблюдателя
    /// </summary>
    public interface IFormObserver
   {
       void Change(IMod mod, ModelEvent e);
   }
}

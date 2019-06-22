using GB_ArchPatterns_Brizhak_HW08_01MVC.Controller;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.View
{
    /// <summary>
    /// Делегат для создания события 
    /// </summary>
    /// <typeparam name="IView"></typeparam>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ViewDelegate<IView>(IView sender, ViewEvent e);

    /// <summary>
    /// Интерфейс для создания <see cref="View"/>
    /// </summary>
    public interface IView
    {
        event ViewDelegate<IView> AddStr;

        void SetContr(IContr contr);
    }
}

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
    /// <summary>
    /// Интерфейс для создания Модели данных и методов работы с ними.
    /// </summary>
    public interface IMod
   {
       void AddStr(string str);
       void AddObserver(IFormObserver obs);
   }
}

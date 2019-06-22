namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
    public interface IFormObserver
   {
       void Change(IMod mod, ModelEvent e);
   }
}

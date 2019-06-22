using System.Collections.Generic;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Model
{
    public class Model : IMod
    {
        public event ModDelegate<Model> Change;
        private List<string> _listStr;

        public Model() => _listStr = new List<string>();

        public void AddObserver(IFormObserver obs)
        {
            Change += new ModDelegate<Model>(obs.Change);
        }

        public void AddStr(string str)
        {
            _listStr.Add(str);
            if (Change != null) Change.Invoke(this, new ModelEvent(str));
        }
    }
}

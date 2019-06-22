﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Model;
using GB_ArchPatterns_Brizhak_HW08_01MVC.View;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC.Controller
{
    public class Controller : IContr
    {
        IView _view;
        IMod _model;

        public Controller(IView view, IMod model)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _model = model ?? throw new ArgumentNullException(nameof(model));

            _view.SetContr(this);
            _model.AddObserver((IFormObserver) _view);
            _view.AddStr += new ViewDelegate<IView>(this.ViewChange);
        }

        public void AddList()
        {
            throw new NotImplementedException();
        }

        public void ViewChange(IView view, ViewEvent e)
        {
            _model.AddStr(e._str);
        }
    }
}

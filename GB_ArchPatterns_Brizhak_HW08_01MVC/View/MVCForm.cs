using System;
using System.Windows.Forms;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Controller;
using GB_ArchPatterns_Brizhak_HW08_01MVC.Model;
using GB_ArchPatterns_Brizhak_HW08_01MVC.View;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC
{
    public partial class MVCForm : Form, IView, IFormObserver
    {
        private IContr _controller;

        public MVCForm()
        {
            InitializeComponent();
        }

        public event ViewDelegate<IView> AddStr;

        public void Change(IMod mod, ModelEvent e)
        {
            listBox.Items.Add(e.NewStr);
        }

        public void SetContr(IContr contr)
        {
            _controller = contr;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxString.Text != null) AddStr.Invoke(this, new ViewEvent(textBoxString.Text));
        }
    }
}

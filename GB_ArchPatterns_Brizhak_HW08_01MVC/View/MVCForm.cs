using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GB_ArchPatterns_Brizhak_HW08_01MVC.View;

namespace GB_ArchPatterns_Brizhak_HW08_01MVC
{
    public partial class MVCForm : Form, IView, 
    {
        public MVCForm()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubliminaleWahrnehmungTest
{
    internal interface IModelSubTest
    {
        public void View(ViewSubTest:IViewSubTest) { set; };
        public void Controller(ControllerSubTest:IControllerSubTest) { set; };
        public void save(testergebnis:Testergebnis);
        public void checkProband(int idProband, int pwd):bool
    }
}

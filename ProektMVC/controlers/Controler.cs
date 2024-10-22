using ProektMVC.models;
using ProektMVC.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMVC.controlers
{
    public class Controler
    {
        //suzdavam obekt ot model i disssplay
        Model mymodel = new Model();
        Display mydisplay = new Display();

        //suzdavam construktor koito kontrolira zad
        public Controler()
        {
            mydisplay.Input();
            mymodel.Numbers = mydisplay.Numbers;
            mydisplay.P1 = mymodel.CalculateP1();
            mydisplay.P2 = mymodel.CalculateP2();
            mydisplay.Output();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestVisitor
{
    interface IBogi
    {
        Dictionary<int,Coach> BogiList(string side);

        string BogiSitSide(int sitNumber, int bogyType);
    }
}

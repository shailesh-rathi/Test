using System;
using System.Collections.Generic;
using System.Text;

namespace TestVisitor
{
    public class Coach
    {
        public int SitNumber { get; set; }

        public int BogiNumber { get; set; }

        public string SitSide { get; set; }

        public string Status { get; set; }

        public CoachStructure Cstruture { get; set; }
    }

    public class CoachStructure
    {
        public int NumberofSeats { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchBogi ss = new SearchBogi();
            var sitsite = ss.BogiSitSide(2,72);

            Console.WriteLine(sitsite);
            Console.ReadLine();
        }
    }
}

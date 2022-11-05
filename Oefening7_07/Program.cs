using System;
using System.Collections.Generic;

namespace Oefening7_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "appel", "peer", "paard", "ezel", "koffie", "thee"
                , "water", "keuken", "badkamer", "frigo" };

            list.ForEach(Console.WriteLine);
        }
    }
}

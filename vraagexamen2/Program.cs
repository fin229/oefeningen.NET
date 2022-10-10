using System;

namespace vraagexamen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string werknemer="";
            DateTime vertrek;

            do
            {
                Console.Write("Wie werkt er vandaag?");
                werknemer=Console.ReadLine();
            } while (werknemer!="Jan"&&werknemer!="Sofie");
        }
    }
}

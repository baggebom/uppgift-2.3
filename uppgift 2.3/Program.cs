using System;

namespace uppgift
{

    class Program
    {

        static void Main(string[]args)
        {

            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            double dagar= double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine(" Hur många kilometer vill du hyra bilen?");

            double km = double.Parse(Console.ReadLine());

            double hyra = 300 + km + ((dagar - 1) * 500);
            Console.WriteLine("Hyran blir " + hyra);

            Console.ReadKey();
        }
    }
}

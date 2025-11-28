using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("0 Kilépés");
            Console.WriteLine("1 Mindent megjelenít");
            Console.WriteLine("2 Csak a számjegyeket tartalmazók");
            Console.WriteLine("3 Csak a 12 hosszúak");
            Console.WriteLine("4 Csak a számjegyeket és + jeleket tartalmazhat");
            Console.WriteLine("5 Csak azok a jelenjenek meg amiben 6-os szám van");
            Console.WriteLine("6 Csak számok és + jel, de csak elől lehet a + jel");
            Console.WriteLine("7 06-tal kezdődik");
            Console.WriteLine("8 ( és vagy ) jel van benne");

            string valasztas = Console.ReadLine();
            if (valasztas == "0")
            {
                return;
            }
            else if (valasztas == "1")
            {
                //1
            }
            else if (valasztas == "2")
            {
                //2
            }
            else if (valasztas == "3")
            {
                //3
            }
            else if (valasztas == "4")
            {
                //4
            }
            else if (valasztas == "5")
            {
                //5
            }
            else if (valasztas == "6")
            {
                //6
            }
            else if (valasztas == "7")
            {
                //7
            }
            else if (valasztas == "8")
            {
                //8
            }
            else
            {
                Console.WriteLine("Nincs ilyen opció!");
            }
            Console.ReadKey();
        }
    }
}

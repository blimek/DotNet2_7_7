using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć za chwilę podasz trzy liczby a ja sprawdzę która jest liczbą największą");
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dziękuje...podaj drugą liczbę");
            int liczba2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dziękuje bardzo...podaj ostatnią liczbę");
            int liczba3 = Int32.Parse(Console.ReadLine());

            if(liczba1 > liczba2 && liczba1 > liczba3)
            {
                Console.WriteLine($"Liczba {liczba1} jest największą wpisaną liczbą");
            }
            else if (liczba2 > liczba1 && liczba2 > liczba3)
            {
                Console.WriteLine($"Liczba {liczba2} jest największą wpisaną liczbą");

            }
            else
            {
                Console.WriteLine($"liczba {liczba3}wpisana to liczba najwieksza");
            }
            Console.ReadLine();



        }
    }
}

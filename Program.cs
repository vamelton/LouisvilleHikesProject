using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouisvilleHikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to Louisville's Hiking Guide!***");
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Let's choose a Park");
            Console.WriteLine("1) Jefferson Memorial Forest");
            Console.WriteLine("2) Waverly Park");
            Console.WriteLine("3) Exit");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    JeffersonMemorialPark();
                    return true;
                case "2":
                    WaverlyPark();
                    return true;

                case "3":
                    return false;
                default:
                    return true;


            }
        }

        private static string WaverlyPark()
        {
            Console.WriteLine("Waverly Park");
            return NewMethod();

            static string? NewMethod()
            {
                return Console.ReadLine();
            }
        }

        private static string JeffersonMemorialPark()
        {
            Console.WriteLine("Jefferson Memorial Forest");
            return Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LouisvilleHikes
{
    public class Park
    {
        public static Trails Trails { get; set; } = new Trails();

        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("***Welcome to Louisville's Hiking Guide!***");
            Console.WriteLine("1) Search for Trails by Park");
            Console.WriteLine("2) Search for Trails by Difficulty");
            Console.WriteLine("3) Search for Trails by Time");
            Console.WriteLine("4) Search for Trails by Distance");
            Console.WriteLine("5) Exit");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return false;
                default:
                    return true;



            }

        }


    }
}




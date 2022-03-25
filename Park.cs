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
                    Console.WriteLine("Which Park?");
                    List<string> parks = Trails.GetParks();
                    for (int i = 0; i < parks.Count; i++)
                    {
                        Console.WriteLine($"\t{i + 1} {parks[i]}");
                    }
                    int parkIndex;
                    string? userSelection = Console.ReadLine();
                    if (int.TryParse(userSelection, out parkIndex) && parkIndex > 0 && parkIndex <= parks.Count)
                    {
                        string selectedPark = parks[parkIndex - 1];
                        List<Trail> trails = Trails.GetTrailsByPark(selectedPark);
                        Console.WriteLine($"Here are the trails in {selectedPark}");
                        // now show the user the list of trails in the selected park
                        foreach (Trail trail in trails)
                        {
                            Console.WriteLine($"\t{trail}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    Console.Write("\nPress any key to continue: ");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.WriteLine("How Difficult of a hike?");
                    Console.WriteLine("\t1: Easy");
                    Console.WriteLine("\t2: Moderate");
                    Console.WriteLine("\t3: Strenuous");
                   
                    int parkDifficulty;
                    string? userSelection4 = Console.ReadLine();
                    if (int.TryParse(userSelection4, out parkDifficulty) && parkDifficulty > x && parkDifficulty <= 5)
                    {
                        if (parkDifficulty == Easy)
                        {
                            Easy;

                        }
                        else if (parkDifficulty == Moderate)
                        {
                            Moderate;
                        }
                        else
                        {
                            Strenuous;
                        }


                        List<Trail> parkDifficulty = Trails.GetTrailsByDifficulty(parkDifficulty);
                        foreach (Trail trail in parkDifficulty)
                        {
                            Console.WriteLine($"\t{trail}");
                            Console.WriteLine("Invalid Selection");
                        }

                    }
                        Console.Write("\nPress any key to continue: ");
                    Console.ReadLine();
                    return true;
                   
                case "3":
                    Console.WriteLine("How long would you like to hike?");
                    Console.WriteLine("\t1: Between 0-1 Hour");
                    Console.WriteLine("\t2: Between 1-2 Hours");
                    Console.WriteLine("\t3: Greater than 2 Hours");

                    int parkTime;
                    string? userSelection2 = Console.ReadLine();
                    if (int.TryParse(userSelection2, out parkTime) && parkTime > 0 && parkTime <= 3)
                    {
                        if (parkTime == 1)
                        {

                            Trails.GetTrailsByTime(new TimeSpan(0, 0, 0), new TimeSpan(1, 0, 0)).ForEach(x => Console.WriteLine($"\t{x}"));
                        }
                        else if (parkTime == 2)
                        {
                            Trails.GetTrailsByTime(new TimeSpan(0, 0, 0), new TimeSpan(2, 0, 0)).ForEach(x => Console.WriteLine($"\t{x}"));
                        }
                        else
                        {
                            Trails.GetTrailsByTime(new TimeSpan(0, 0, 0), new TimeSpan(10, 0, 0)).ForEach(x => Console.WriteLine($"\t{x}"));
                        }


                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    Console.Write("\nPress any key to continue: ");
                    Console.ReadLine();
                    return true;
                
                case "4":
                    Console.WriteLine("How far would you like to hike?");
                    Console.WriteLine("\t1: Between 0-2 Miles");
                    Console.WriteLine("\t2: Between 2-5 Miles ");
                    Console.WriteLine("\t3: Greater than 5 Hours");

                    int parkDistance;
                    double minDistance = -1, maxDistance = -1;
                    string? userSelection3 = Console.ReadLine();
                    if (int.TryParse(userSelection3, out parkDistance) && parkDistance > 0 && parkDistance <= 5)
                    {
                        if (parkDistance == 2)
                        {
                            minDistance = 2.0;
                            maxDistance = 5.0;

                        }
                        else if (parkDistance == 5)
                        {
                            minDistance = 5.0;
                        }
                        else
                        {
                            minDistance = 0;
                            maxDistance = 2;
                        }


                        List<Trail> parkDistance2 = Trails.GetTrailsbyDistance(minDistance, maxDistance);
                        foreach (Trail trail in parkDistance2)
                        {
                            Console.WriteLine($"\t{trail}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    Console.Write("\nPress any key to continue: ");
                    Console.ReadLine();
                    return true;
                    
                case "5":
                    return false;
                default:
                    return true;



            }

        }


    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LouisvilleHikes.Trails;


namespace LouisvilleHikes
{
    public class Park
    {
        public static void Main(string[] args)
        {
            Trail trail1 = new Trail("Red Trail");
            trail1.Park = "Jefferson Memorial Forest";
            trail1.Distance = "4.8 Miles";
            trail1.Difficulty = "Moderate";
            trail1.Time = "2h 35m";

            Trail trail2 = new Trail("Silstone Trail");
            trail2.Park = "Jefferson Memorial Forest";
            trail2.Distance = "6.7 Miles";
            trail2.Difficulty = "Strenuous";
            trail2.Time = "3h 40m";

            Trail trail3 = new Trail("Mitchell Hill Lake Loop");
            trail3.Park = "Jefferson Memorial Forest";
            trail3.Distance = "1.4 Miles";
            trail3.Difficulty = "Easy";
            trail3.Time = "1h 30m";

            Trail trail4 = new Trail("Fresh Air Loop");
            trail4.Park = "Waverly Park";
            trail4.Distance = "3 Miles";
            trail4.Difficulty = "Strenuous";
            trail4.Time = "1h 30m";

            Trail trail5 = new Trail("Playground Loop");
            trail5.Park = "Waverly Park";
            trail5.Distance = "0.6 Miles";
            trail5.Difficulty = "Easy";
            trail5.Time = "18 m";

            Trail trail6 = new Trail("Twisting Bends Loop");
            trail6.Park = "Waverly Park";
            trail6.Distance = "2.2 Miles";
            trail6.Difficulty = "Moderate";
            trail6.Time = "1h 6m";
        }
       
        }

    }


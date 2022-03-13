using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.LouisvilleHikes.Trails;


namespace LouisvilleHikes
{
    public class Park
    {
        private static Trails trails = new Trails();
        public static void Main(string[] args);
      
       
            Trails trail1 = new Trails("Red Trail");
        trail1.Park = "Jefferson Memorial Forest";
            trail1.Distance = "4.8";
            trail1.Difficulty = "Moderate";
            trail1.Time = "2,35,0";


            Trail trail2 = new Trail("Silstone Trail");
        trail2.Park = "Jefferson Memorial Forest";
            trail2.Distance = "6.7";
            trail2.Difficulty = "Strenuous";
            trail2.Time = "3,40,0";

            Trail trail3 = new Trail("Mitchell Hill Lake Loop");
        trail3.Park = "Jefferson Memorial Forest";
            trail3.Distance = "1.4";
            trail3.Difficulty = "Easy";
            trail3.Time = "1,30,0";

            Trail trail4 = new Trail("Fresh Air Loop");
        trail4.Park = "Waverly Park";
            trail4.Distance = "3";
            trail4.Difficulty = "Strenuous";
            trail4.Time = "1,30,0";

            Trail trail5 = new Trail("Playground Loop");
        trail5.Park = "Waverly Park";
            trail5.Distance = "0.6";
            trail5.Difficulty = "Easy";
            trail5.Time = "0,18,0";

            Trail trail6 = new Trail("Twisting Bends Loop");
        trail6.Park = "Waverly Park";
            trail6.Distance = "2.2";
            trail6.Difficulty = "Moderate";
            trail6.Time = "1,6,0";

            trails = new List<Trail>();
            trails.Add(trail1);
            trails.Add(trail2);
            trails.Add(trail3);
            trails.Add(trail4);
            trails.Add(trail5);
            trails.Add(trail6);
         
     }

    internal class trailList
    {
    }
}




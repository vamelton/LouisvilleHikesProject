using LouisvilleHikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LouisvilleHikes
{
    public class Trail
    {
        private string park;
        private string trail;
        private double distance;
        private string difficulty;
        private string name;
      

        public Trail()
        {
        }

        public Trail(string v) => V = v;

        public string Park { get => park; set => park = value; }
        public string Name { get => trail; set => trail = value; }
        public double Distance { get => distance; set => distance = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public string V { get; }
        public TimeSpan TimeSpan { get; set; }

    }


}

public class Trails : List<Trail>
{
    public Trails()
    {
        Initialize();
    }
    private void Initialize()
    {
        Trail trail1 = new Trail("Red Trail");
        trail1.Park = "Jefferson Memorial Forest";
        trail1.Distance = (4.8);
        trail1.Difficulty = "Moderate";
        trail1.TimeSpan = new TimeSpan(2, 35, 0);


        Trail trail2 = new Trail("Silstone Trail");
        trail2.Park = "Jefferson Memorial Forest";
        trail2.Distance = (6.7);
        trail2.Difficulty = "Strenuous";
        trail2.TimeSpan = new TimeSpan(3, 40, 0);

        Trail trail3 = new Trail("Mitchell Hill Lake Loop");
        trail3.Park = "Jefferson Memorial Forest";
        trail3.Distance = (1.4);
        trail3.Difficulty = "Easy";
        trail3.TimeSpan = new TimeSpan(1, 30, 0);

        Trail trail4 = new Trail("Fresh Air Loop");
        trail4.Park = "Waverly Park";
        trail4.Distance = (3);
        trail4.Difficulty = "Strenuous";
        trail4.TimeSpan = new TimeSpan(1, 30, 0);

        Trail trail5 = new Trail("Playground Loop");
        trail5.Park = "Waverly Park";
        trail5.Distance = (0.6);
        trail5.Difficulty = "Easy";
        trail5.TimeSpan = new TimeSpan(0, 18, 0);

        Trail trail6 = new Trail("Twisting Bends Loop");
        trail6.Park = "Waverly Park";
        trail6.Distance = (2.2);
        trail6.Difficulty = "Moderate";
        trail6.TimeSpan = new TimeSpan(1, 6, 0);

        List<Trail> Trails = new List<Trail>();
        Add(trail1);
        Add(trail2);
        Add(trail3);
        Add(trail4);
        Add(trail5);
        Add(trail6);
    }
}


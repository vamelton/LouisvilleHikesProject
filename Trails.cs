using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LouisvilleHikes
{
    public class Trails
    {
        private string park;
        private string trail;
        private string distance;
        private string difficulty;
        private string name;

       public string Park { get => park; set => park = value; }
        public string Trail { get => trail; set => trail = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public int Time { get; set; }
        public string Name { get => name; set => name = value; }

        public Trails(string trailName)
        {
            name = trailName;
        }

        public Trails()
        {
        }

        public string Listing
        {
            get
            {
                return trail + " - " + distance;

            }
        }


    }


}

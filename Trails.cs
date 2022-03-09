using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LouisvilleHikes
{
    internal class Trails
    {
        private string park;
        private string trail;
        private string distance;
        private string difficulty;

       public string Park { get => park; set => park = value; }
        public string Trail { get => trail; set => trail = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public int Time { get; set; }
        public string Listing
        {
            get
            {
                return Trail + " - " + Distance;

            }
        }


    }


}

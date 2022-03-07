using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouisvilleHikes
{
    internal class Trails
    {
        public char trailName;

        public Trails(char trailName)
        {
            this.trailName = trailName;
        }

       
        public int trailDistance;
        public int trailDifficulty;
        public decimal trailLength;
        public int trailTime;

}
    }

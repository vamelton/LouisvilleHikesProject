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

        public Trails()
        {
        }

        public int trailDistance;
        public int trailDifficulty;
        public decimal trailLength;
        public int trailTime;
        private int Id;
        private static readonly List<Trails> trails = new List<Trails>()
        {
            new Trails() {Id = 1, trailName="Red Trail"},
            new Trails() {Id = 2, trailName="Siltstone Trail"},
            new Trails() {Id = 3, trailName="Michtell Hill Lake Trail"},
            new Trails() {Id = 4, trailName="Fresh Air Loop"},
            new Trails() {Id=5, trailName="Playground Loop" },
            new Trails() {Id = 6, trailName="Twisting Bends Trail"}

        };

    }
    
     
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs_proj
{
    class Herd
    {
        public List<Dinosaur> Dinosaurs = new List<Dinosaur>();

        public Herd()
        {
            Dinosaur Tim = new Dinosaur(150, 100, 25, "T-Rex");
            Dinosaur Bob = new Dinosaur(200, 100, 25, "TerrorBird");
            Dinosaur Jake = new Dinosaur(100, 100, 25, "Tri");

            Dinosaurs.Add(Tim);
            Dinosaurs.Add(Bob);
            Dinosaurs.Add(Jake);
        }
    }
}

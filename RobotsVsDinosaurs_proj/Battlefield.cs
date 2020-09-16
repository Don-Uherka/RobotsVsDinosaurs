using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs_proj
{
    class Battlefield
    {

        public Herd herd;
        public Fleet fleet;

        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }
        public void Battle()
        {
            while (herd.Dinosaurs.Count > 0 && fleet.Robots.Count > 0)
            {
                herd.Dinosaurs[0].Attack(fleet.Robots[0]);
                if(fleet.Robots[0].health == 0)
                {
                    
                    Console.WriteLine(fleet.Robots[0].name + "Eliminated");
                    fleet.Robots.RemoveAt(0);

                }


                fleet.Robots[0].Attack(herd.Dinosaurs[0]);
               
                if(herd.Dinosaurs[0].Health == 0)
                {
                    
                    Console.WriteLine(herd.Dinosaurs[0].Type + "Eliminated");
                    herd.Dinosaurs.RemoveAt(0);
                }

                if (herd.Dinosaurs.Count == 0)
                { 
                    Console.WriteLine("Robots Win!");
                }
                else if(fleet.Robots.Count == 0)
                {
                    Console.WriteLine("Dinosaurs Win!");
                }
                
            }
            
        }
        
    }
}

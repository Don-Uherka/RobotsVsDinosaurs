using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs_proj
{
    class Fleet
    {
       

        public List<Robot> Robots = new List<Robot>();
        public Fleet()
        {
            Robot brett = new Robot("brett", 150, 50, "sword");
            Robot tweedle = new Robot("Dee", 125, 60, "sword");
            Robot Lary = new Robot("Lary", 100, 75, "sword");

            Robots.Add(brett);
            Robots.Add(tweedle);
            Robots.Add(Lary);
        }
    }
}

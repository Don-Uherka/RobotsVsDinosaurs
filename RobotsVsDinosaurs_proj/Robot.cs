using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs_proj
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public string weopon;
        

        //constructor
        public Robot(string name, int health, int powerLevel, string weopon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weopon = weopon;
            
        }
        //method
        public void Attack()
        {
             
        }

        
    }
}

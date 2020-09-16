using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs_proj
{
    class Dinosaur
    {
        //member variables 
        public int Health;
        public int Energy;
        public int attackPower;
        public string Type;

        //constructor
        public Dinosaur(int Health, int Energy, int attackPower, string Type)
        {
            this.Health = Health;
            this.Energy = Energy;
            this.attackPower = attackPower;
            this.Type = Type;
        }
        //methods

        public void Attack(Robot robot)//what parameter will this have? What needs to get "inside" this attack method?
        {
            robot.health -= attackPower;

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Character
    {
    public String name { get; set; }

    public int health { get; set; }

    public int strength { get; set; }

    public int luck { get; set; }

        public Character()
        {
        }

        public Character(string name, int health, int strength, int luck)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.luck = luck;
        }




}


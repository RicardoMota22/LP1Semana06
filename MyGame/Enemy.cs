using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        // Construtor
        public Enemy(string name)
        {
            this.name=name; // Porque razao usamos "this", like self in python?
            health =100;
            shield = 0;
        }
    }
}
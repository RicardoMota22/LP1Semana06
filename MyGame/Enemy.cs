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

        // Construtor (same name as class)
        public Enemy(string name)
        {
            this.name=name; // Porque razao usamos "this", like self in python?
            
            health =100;
            shield = 0;
        }

        //Different Names from class
        public string GetName()
        {
            return name;
        }

         public float GetHealth()
        {
            return health;
        }


        public float GetShield()
        {
            return shield;
        }
        

        public void TakeDamage(float damage)
        {
            shield -=damage;
            if (shield < 0)
            {
                float damageStillToInflict =-shield;
                shield = 0;
                health -= damageStillToInflict ;
                if (health< 0) health = 0;
            }
        }
       
       public void SetName(string newname)
       {
            if (newname.Length > 8)
            {
                int maxLength = 8;
                string limitedString = new string(newname.Take(maxLength).ToArray());
            }
            else
            {
                name = newname;
            }
       }

        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    //Encapsulação + Enumeração
        public enum PowerUp
        {
            Health,
            Shield
        }
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        // Construtor (same name as class)
        public Enemy(string name, float startHealth = 100, float startShield = 0)
        {
            //this.name=name; // Porque razao usamos "this", like self in python?
            SetName(name);
            //health =100;
            //shield = 0;
            health = startHealth;
            shield = startShield;
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
                name = new string(newname.Take(maxLength).ToArray());
            }
            else
            {
                name = newname;
            }
       }


        public void PickupPowerUp(PowerUp powerUp ,float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health = health + value;
                if (health > 100)
                {
                    health = 100;
                }
            }

            if (powerUp == PowerUp.Shield)
            {
                shield = shield + value;
                if (shield > 100)
                {
                    shield = 100;
                }
            }


        }

    }
}
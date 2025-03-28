using System;
using Humanizer;

namespace MyRoguelike
{
    public enum Toughness
    {
        VeryEasy,
        Easy,
        Normal,
        Tough, 
        Nightmare
    }
    public class Enemy
    {
        private string name;
    
        public Enemy(string name)
            {
                this.name = name;
            }
    }
    public class Level
    {
        private string name;
        private int room;

        private string difficulty;

        public Level(int roomcount, string difficulty)
        {
            this.room = roomcount;
            this.difficulty = difficulty;
        }
        public void SetEnemyInRoom(int room, string newname)
        {
            //int roomplace = int.Parse(args[0]);
            
        }
        public string GetToughness()
        {
            return difficulty;
        }
        public string GetNumRooms()
        {
            string rooms = Convert.ToString(room);
            return rooms;
        }
        public string GetNumEnemies()
        {
            return name;
        }
        public void PrintEnemies(Level name, int room)
        {
            room.ToWords();
            
            Console.WriteLine($"{room}: {name}");
        }
    }

}
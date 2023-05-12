using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Player
    {
        public string playerName { get; }

        private int healthPoints = 1000;
        private int damage;
        private int weaponspeed;
        private int defensive;
        private int agility;
        private int movement;

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Damage kann nicht 0 oder kleiner sein!");
                }
                else
                {
                    damage = value;
                }
            }
        }

        public int Weaponspeed
        {
            get
            {
                return weaponspeed;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Weaponspeed kann nicht 0 oder kleiner sein!");
                }
                else
                {
                    weaponspeed = value;
                }
            }
        }

        public int Defensive
        {
            get
            {
                return defensive;
            }
            set
            {
                defensive = value;
            }
        }

        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Agility kann nicht 0 oder kleiner sein!");
                }
                else
                {
                    agility = value;
                }
            }
        }

        public int Movement
        {
            get
            {
                return movement;
            }
        }
        public Player(string playerName)
        {
            this.playerName = playerName;
        }
        public void playerStatus()
        {
            Console.WriteLine("Aktueller Spieler-Status");

            movement = weaponspeed + agility;
            Console.WriteLine("Der schreckliche {0}", playerName);
            Console.WriteLine("Schaden: {0}", damage);
            Console.WriteLine("Verteidigung: {0}", defensive);
            Console.WriteLine("Beweglichkeit: {0}", movement);
            Console.WriteLine("Leben: {0}", healthPoints);
        }
    }
}

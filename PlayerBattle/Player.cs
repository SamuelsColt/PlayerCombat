using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Player
    {
        public string playerName { get; }
        public int healthPoints = 1000;
        public int damage;
        public int weaponspeed;
        public int defensive;
        public int agility;
        public int movement;

        public Player(string playerName)
        {
            this.playerName = playerName;
        }

        public Weapon Weapon { get; }
        public Armor Armor { get; }

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

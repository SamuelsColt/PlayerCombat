using PlayerBattle;

namespace PlayerCombat
{
    class Program
    {
        /// <summary>
        /// Einstiehspunkt!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Player player = createCharakter();
            equipment(player);
            player.playerStatus();
        }

        public static int eingabePrüfung(string input, int minValue, int maxValue)
        {

            if (int.TryParse(input, out int output) && output >= minValue && output <= maxValue)
            {
                return output;
            }
            else
            {
                Console.WriteLine("Formatfehler, trage eine Zahl ein die sich zwischen {0} und {1} befindet", minValue, maxValue);
                return eingabePrüfung(Console.ReadLine(), minValue, maxValue);
            }
        }

        public static Player createCharakter()
        {
            Console.WriteLine("gib deinem Charakter eine Name");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                return new Player(name);
            }
            
            Console.WriteLine("Ohne gibts nicht!");
            return createCharakter();
        }
        public static void equipment(Player player)
        {
            Weapon dagger = new Weapon("Dolch", 25, 3);
            Weapon sword = new Weapon("Schwert", 50, 2);
            Weapon hammer = new Weapon("Hammer", 100, 1);

            Armor leatheramor = new Armor("Leder-Rüstung", 3, 3);
            Armor studdedarmour = new Armor("Beschlagene-Rüstung", 6, 2);
            Armor steelarmor = new Armor("Stahl-Rüstung", 9, 1);

            Console.WriteLine("also gut {0}, zieh dir mal was an das ist ja unerträglich!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-");
            leatheramor.showValue();
            Console.WriteLine("-");
            studdedarmour.showValue();
            Console.WriteLine("-");
            steelarmor.showValue();
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("gebe '1' für die Leder-Rüstung ein");
            Console.WriteLine("gebe '2' für die Beschlagene-Rüstung ein");
            Console.WriteLine("gebe '3' für die Stahl-Rüstung ein");

            int armorChoise = eingabePrüfung(Console.ReadLine(), 1 , 3);

            switch(armorChoise)
            {
                case 1:
                    player.defensive = leatheramor.armorDefensive;
                    player.agility = leatheramor.armorAgility;
                    break;

                case 2:
                    player.defensive = studdedarmour.armorDefensive;
                    player.agility = studdedarmour.armorAgility;
                    break;

                case 3:
                    player.defensive = steelarmor.armorDefensive;
                    player.agility = steelarmor.armorAgility;
                    break;

            }

            Console.WriteLine("hier! nimm noch einen Meinungsverstärker");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-");
            dagger.showValue();
            Console.WriteLine("-");
            sword.showValue();
            Console.WriteLine("-");
            hammer.showValue();
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Eins Zwei oder Drei....");

            int weaponChoise = eingabePrüfung(Console.ReadLine(), 1, 3);

            switch (weaponChoise)
            {
                case 1:
                    player.damage = dagger.weaponDamage;
                    player.weaponspeed =dagger.weaponSpeed;
                    break;

                case 2:
                    player.damage = sword.weaponDamage;
                    player.weaponspeed = sword.weaponSpeed;
                    break;

                case 3:
                    player.damage = hammer.weaponDamage;
                    player.weaponspeed = hammer.weaponSpeed;
                    break;

            }

        }
    }
}
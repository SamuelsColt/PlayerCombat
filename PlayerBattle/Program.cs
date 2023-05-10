using PlayerBattle;

namespace PlayerCombat
{
    class Program
    {
        public static Player player1;
        static void Main(string[] args)
        {
            createCharakter();
            equipment();
            player1.playerStatus();
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

        public static void createCharakter()
        {
            Console.WriteLine("gib deinem Charakter eine Name");
            string name = Console.ReadLine();
            if (name != null && name != "")
            {
                Player player1 = new Player(name);
            }
            else
            {
                Console.WriteLine("Ohne gibts nicht!");
                createCharakter();
            }
        }
        public static void equipment()
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
                    player1.defensive = leatheramor.armorDefensive;
                    player1.agility = leatheramor.armorAgility;
                    break;

                case 2:
                    player1.defensive = studdedarmour.armorDefensive;
                    player1.agility = studdedarmour.armorAgility;
                    break;

                case 3:
                    player1.defensive = steelarmor.armorDefensive;
                    player1.agility = steelarmor.armorAgility;
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
                    player1.damage = dagger.weaponDamage;
                    player1.weaponspeed =dagger.weaponSpeed;
                    break;

                case 2:
                    player1.damage = sword.weaponDamage;
                    player1.weaponspeed = sword.weaponSpeed;
                    break;

                case 3:
                    player1.damage = hammer.weaponDamage;
                    player1.weaponspeed = hammer.weaponSpeed;
                    break;

            }

        }
    }
}
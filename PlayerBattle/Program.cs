using PlayerBattle;
using System.Numerics;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace PlayerCombat
{
    class Program
    {
        static void Main(String[] args)
        {
            Player player = createCharakter();
            equipment(player);
            player.playerStatus();

            Player player2 = createCharakter();
            equipment(player2);
            player2.playerStatus();


            // PlayerAttackPlayer2(Player player,Player player2);


        }


        public static int eingabePrüfung(String input, Int32 minValue, Int32 maxValue)
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

            Console.WriteLine("also gut {0}, zieh dir mal was an das ist ja unerträglich!", player.playerName);

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
                    player.Defensive = leatheramor.ArmorDefensive;
                    player.Agility = leatheramor.ArmorAgility;
                    break;

                case 2:
                    player.Defensive = studdedarmour.ArmorDefensive;
                    player.Agility = studdedarmour.ArmorAgility;
                    break;

                case 3:
                    player.Defensive = steelarmor.ArmorDefensive;
                    player.Agility = steelarmor.ArmorAgility;
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
                    player.Damage = dagger.WeaponDamage;
                    player.Weaponspeed =dagger.WeaponSpeed;
                    break;

                case 2:
                    player.Damage = sword.WeaponDamage;
                    player.Weaponspeed = sword.WeaponSpeed;
                    break;

                case 3:
                    player.Damage = hammer.WeaponDamage;
                    player.Weaponspeed = hammer.WeaponSpeed;
                    break;

            }
        }

        public void PlayerAttackPlayer2(Player player, Player player2)
        {
            for (int i = 0; i < player.Movement ; i++)
            {
                player2.HealthPoints = player2.HealthPoints - (player.Damage - player2.Defensive);
            }
        }
    }
}
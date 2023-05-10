using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Weapon
    {
        public string weaponName;
        public int weaponDamage;
        public int weaponSpeed;

        public Weapon(string weaponName, int weaponDamage, int weaponSpeed)
        {
            this.weaponName = weaponName;
            this.weaponDamage = weaponDamage;
            this.weaponSpeed = weaponSpeed;
        }

        public void showValue()
        {
            Console.WriteLine("{0}: Schaden = {1}, Geschwindigkeit = {2}", weaponName, weaponDamage, weaponSpeed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Weapon
    {
        private string weaponName;
        private int weaponDamage;
        private int weaponSpeed;

        public Weapon(string weaponName, int weaponDamage, int weaponSpeed)
        {
            this.weaponName = weaponName;
            this.weaponDamage = weaponDamage;
            this.weaponSpeed = weaponSpeed;
        }

        public string WeaponName
        {
            get
            {
                return weaponName;
            }
        }

        public int WeaponDamage
        {
            get
            {
                return weaponDamage;
            }
            set
            {
                weaponDamage = value;
            }
        }
        public int WeaponSpeed
        {
            get
            {
                return weaponSpeed;
            }
            set
            {
                weaponSpeed = value;
            }
        }
        public void showValue()
        {
            Console.WriteLine("{0}: Schaden = {1}, Geschwindigkeit = {2}", weaponName, weaponDamage, weaponSpeed);
        }
    }
}

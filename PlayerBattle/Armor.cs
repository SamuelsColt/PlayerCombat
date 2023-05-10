using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Armor
    {
        public string armorName;
        public int armorDefensive;
        public int armorAgility;
        public Armor(string armorName, int armorDefensive, int armoragility)
        {
            this.armorName = armorName;
            this.armorDefensive = armorDefensive;
            this.armorAgility = armoragility;
        }

        public void showValue()
        {
            Console.WriteLine("{0}: Defensive = {1}, Beweglichkeit = {2}", armorName, armorDefensive, armorAgility);
        }
    }
}

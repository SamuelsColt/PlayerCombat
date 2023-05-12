using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    internal class Armor
    {
        private string armorName;
        private int armorDefensive;
        private int armorAgility;

        public Armor(string armorName, int armorDefensive, int armoragility)
        {
            this.armorName = armorName;
            this.armorDefensive = armorDefensive;
            this.armorAgility = armoragility;
        }

        public string ArmorName
        {
            get
            {
                return armorName;
            }
        }

        public int ArmorDefensive
        {
            get
            {
                return armorDefensive;
            }
            set
            {
                armorDefensive = value;
            }
        }
         public int ArmorAgility
        {
            get
            {
                return armorAgility;
            }
            set
            {
                armorAgility = value;
            }
        }

        public void showValue()
        {
            Console.WriteLine("{0}: Defensive = {1}, Beweglichkeit = {2}", armorName, armorDefensive, armorAgility);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerBattle
{
    public interface ITestInterface
    {
        String Name { get; }
    }

    internal class TestClass : ITestInterface
    {
        private Int32 value;

        public String Name { get; }

        public void SetValue(Int32 value)
        {
            this.value = value;
        }

        public Int32 GetValue()
        { 
            return this.value; 
        }
    }

    internal class ExtendedSuperCrazyClass : TestClass
    {

    }
}

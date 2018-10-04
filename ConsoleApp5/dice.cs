using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class dice
    {
        
        
        private Random roll = new Random(); // removed static
        private int _value;
        private int cpu;
        public dice()
        {
            _value = roll.Next(1, 7);
            cpu = roll.Next(1, 4);
        }

        public int Value
        {
            get { return _value; }
        }

        public int Com
        {
            get { return cpu; }
        }
        
        /*
        public void Roll()
        {
            _value = roll.Next(6) + 1;
        }
        */

        // nor rain and thunder shall stop me on succeeding on making a random nummber class!!!
        // and ive did, didnt work since Random number was Static at 1st
    }
            

}

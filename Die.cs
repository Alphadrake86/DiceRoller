using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    class Die
    {
        static Random random;

        public byte sides { get; private set; }
        public byte value { get; set; }
        public bool isHeld { get; set; }

        static Die()
        {
            random = new Random();
        }

        public Die(): this(6){}

        public Die(byte sides)
        {
            this.sides = sides;
            Roll();
        }

        public byte Roll()
        {
            if (isHeld)
            {
                return value;
            }

            value = (byte)random.Next(sides + 1);
            return value;
        }

    }
}

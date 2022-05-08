using System;
using System.Collections.Generic;
using System.Text;

namespace AnimRef
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings => 4;

        public override string Sound()
        {
            return base.Sound() + "Bzzzz!";
        }
    }
}

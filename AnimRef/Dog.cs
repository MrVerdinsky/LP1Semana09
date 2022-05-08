using System;

namespace AnimRef
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples => 10;

        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}

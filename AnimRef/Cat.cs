using System;

namespace AnimRef
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples => 8;

        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}

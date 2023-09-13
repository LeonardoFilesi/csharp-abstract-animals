using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public abstract void DoCall();
        public abstract void WhatDoUEat();

        public void Sleep()
        {
            Console.WriteLine("zzzzzzz");
        }
    }

    public class Dog : Animal
    {
        public override void DoCall()
        {
            Console.WriteLine("Woof woof!");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Omnivore, but love treats in particular");
        }
    }

    public class Sparrow : Animal
    {
        public override void DoCall()
        {
            Console.WriteLine("Chip chip chip chip");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Grains, seeds, insects, discarded food (in cities)");
        }
    }

    public class Eagle : Animal
    {
        public override void DoCall()
        {
            Console.WriteLine("A series of high-pitched screeches and whistling");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("They are raptors, so birds are in the diet, but small mammals and fish too");
        }
    }

    public class Dolphin : Animal
    {
        public override void DoCall()
        {
            Console.WriteLine("No name, it's a series of Clicks for echolocation and communication");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Smaller fishes, crustaceans and molluscs");
        }
    }


}

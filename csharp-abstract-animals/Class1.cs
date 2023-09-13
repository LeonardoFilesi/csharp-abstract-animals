using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    // --------------------------CLASSE ASTRATTA ANIMALE--------------------------------
    public abstract class Animal
    {
        public abstract void DoCall();
        public abstract void WhatDoUEat();

        public void Sleep()
        {
            Console.WriteLine("zzzzzzz");
        }
    }

    // ------------------------------CANE---------------------------
    public class Dog : Animal, IMovementMethod
    {
        public override void DoCall()
        {
            Console.WriteLine("Woof woof!");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Omnivore, but love treats in particular");
        }
        public void ToSwim()
        {
            Console.WriteLine("I'm not born to swim, but I do it pretty good, cause I'm a good boy");
        }
        public void ToFly()
        {
            Console.WriteLine("I cannot fly, *sad woof*");
        }
    }

    //-----------------------------------PASSEROTTO--------------------------------
    public class Sparrow : Animal, IMovementMethod
    {
        public override void DoCall()
        {
            Console.WriteLine("Chip chip chip chip");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Grains, seeds, insects, discarded food (in cities)");
        }
        public void ToFly()
        {
            Console.WriteLine("Chip chip I can fly very fast so dogs and humans cannot catch me!!! *flies away*");
        }
        public void ToSwim()
        {
            Console.WriteLine("I will surely drown and die very badly");
        }
    }

    //----------------------------------AQUILA--------------------------------------
    public class Eagle : Animal, IMovementMethod
    {
        public override void DoCall()
        {
            Console.WriteLine("A series of high-pitched screeches and whistling");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("They are raptors, so birds are in the diet, but small mammals and fish too");
        }
        public void ToFly()
        {
            Console.WriteLine("I can fly faster than that sparrow, more efficently than that sparrow, cause I eat sparrows, I'm a raptor");
        }
        public void ToSwim()
        {
            Console.WriteLine("Some of my relatives prefere maritime hunting operation, I do admit...");
        }
    }

    //----------------------------------DELFINO------------------------------------
    public class Dolphin : Animal, IMovementMethod
    {
        public override void DoCall()
        {
            Console.WriteLine("No name, it's a series of Clicks for echolocation and communication");
        }
        public override void WhatDoUEat()
        {
            Console.WriteLine("Smaller fishes, crustaceans and molluscs");
        }
        public void ToSwim()
        {
            Console.WriteLine("I'm a very very proficient and fast swimmer, I'm a mammal, but I've evolved that way");
        }
        public void ToFly()
        {
            Console.WriteLine("I do fly, well... briefly, when I playfully jump out of the water... ");
        }
    }


}

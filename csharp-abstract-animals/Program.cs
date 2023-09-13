namespace csharp_abstract_animals
{
     class Program
    {
        static void Main()
        {
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Dog());
            Animals.Add(new Sparrow());
            Animals.Add(new Eagle());
            Animals.Add(new Dolphin());

            Console.WriteLine("Here is a list of animals and some of their characteristics:");
            foreach (Animal animal in Animals)
            {
                Console.WriteLine("The sound that this animal makes is:");
                animal.DoCall();
                Console.WriteLine("The 'sparrow' diet is:");
                animal.WhatDoUEat();
                Console.WriteLine("And when a 'sparrow' sleeps it just");
                animal.Sleep();
                animal.ToFly();
                animal.ToSwim();
            }

        }
    }
}
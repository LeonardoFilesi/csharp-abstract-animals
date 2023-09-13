namespace csharp_abstract_animals
{
     class Program
    {
        static void Main()
        {

            Dog dog = new Dog();
           
            Sparrow sparrow = new Sparrow();
          
            Eagle eagle = new Eagle();
            
            Dolphin dolphin = new Dolphin();

            Console.WriteLine("Here is a list of animals and some of their characteristics:");
            Console.WriteLine("This is a 'dog', the sound that it makes is:");
            dog.DoCall();
            Console.WriteLine("The 'dog' diet is:");
            dog.WhatDoUEat();
            Console.WriteLine("And when a 'dog' sleeps it just");
            dog.Sleep();

            Console.WriteLine("This is a 'sparrow', the sound that it makes is:");
            sparrow.DoCall();
            Console.WriteLine("The 'sparrow' diet is:");
            sparrow.WhatDoUEat();
            Console.WriteLine("And when a 'sparrow' sleeps it just");
            sparrow.Sleep();

            Console.WriteLine("This is a 'eagle', the sound that it makes is:");
            eagle.DoCall();
            Console.WriteLine("The 'eagle' diet is:");
            eagle.WhatDoUEat();
            Console.WriteLine("And when a 'eagle' sleeps it just");
            eagle.Sleep();

            Console.WriteLine("This is a 'dolphin', the sound that it makes is:");
            dolphin.DoCall();
            Console.WriteLine("The 'dolphin' diet is:");
            dolphin.WhatDoUEat();
            Console.WriteLine("And when a 'dolphin' sleeps it just");
            dolphin.Sleep();
        }
    }
}
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var toucanSam = new Bird();
           toucanSam.Beaks = true;
            toucanSam.LightweightSkeleton= true;
            toucanSam.Wings = true;
            toucanSam.WarmBlood = true;

            var franklinTurtle = new Reptile();
            franklinTurtle.ColdBlood= true;
            franklinTurtle.Scales= true;
            franklinTurtle.NoEars = true;
            franklinTurtle.OptionalLimbs = 4;
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var newAnimal = new Animal[] { toucanSam, franklinTurtle };

            foreach (var animal in newAnimal)
            {
                Console.WriteLine($"Sexually Reproduces: {animal.SexualReproduction}");
                Console.WriteLine($"Is Multicellular: {animal.Multicellular}");
                Console.WriteLine($"Heterotrophic: {animal.Heterotrophic}");
                Console.WriteLine($"It travels by {animal.Motility}");
                Console.WriteLine("");
            }
        }
    }
}

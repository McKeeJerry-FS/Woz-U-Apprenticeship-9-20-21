using System;
using System.Collections.Generic;
using System.Collections;

namespace Lesson_8_Hands_On_Practice_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a List of IMammal Objects
            List<IAnimal> animals = new List<IAnimal>();

            // Creating animal (IMammal) Objects to fill the list
            Dog fido = new Dog();
            Cat whiskers = new Cat();
            Cow bessie = new Cow();
            Bacterium bacteria = new Bacterium();

            // Add objects to the list
            animals.Add(fido);
            animals.Add(whiskers);
            animals.Add(bessie);
            animals.Add(bacteria);
            // running a For() Loop to iterate through the list and call the 
            // methods from the interface on each animal abject
            foreach (IAnimal animal in animals)
            {
                animal.Speak();
                animal.Run();
                animal.Eat();
            }


        }
    }
}

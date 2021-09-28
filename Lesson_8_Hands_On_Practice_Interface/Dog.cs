using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Hands_On_Practice_Interface
{
    class Dog : IMammal, IAnimal
    {
        
        public void Speak()
        {
            Console.WriteLine("Bark!");
           
        }

        public void Run()
        {
            Console.WriteLine("Dogs can run at a top speed of 45 mph!");
            
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat bones.");
        }
    }
}
